import {Injectable} from '@angular/core';
import {Router, ActivatedRoute} from '@angular/router';
import {Http, Headers, RequestOptions} from '@angular/http';
import {BehaviorSubject} from 'rxjs';
import {SERVER} from '../app';

let fluff : string[] = [
  'rainbows',
  'lollipops',
  'sunshine',
  'wildflower',
  'love',
  'magic',
  'friendship',
  'fluffy',
  'popcorn',
  '♥',
  'sweets'
];

@Injectable()
/**
 * The service responsible for fetching all available options
 * Written by Manuel Huber
 */
export class UnicornService {

  private unicornSubject : BehaviorSubject<Unicorn> = new BehaviorSubject({
    name: '',
    wings: 0,
    hat: 0,
    body: 0,
    shoes: 0,
  });
  private url : BehaviorSubject<string> = new BehaviorSubject('');
  private unicorn : Unicorn;

  constructor (private router : Router, private route : ActivatedRoute, private http : Http) {
    this.unicorn = this.unicornSubject.getValue();
  }

  /**
   * Returns a observable unicorn
   */
  getUnicorn () : BehaviorSubject<Unicorn> {
    return this.unicornSubject;
  }

  getCurrentUrl () : BehaviorSubject<string> {
    return this.url;
  }

  /**
   * set Name and update the observable
   */
  setName (name : string) : void {
    this.unicorn.name = name;
    this.updateSubject();
  }

  /**
   * set Body and update the observable
   */
  setBody (id : number) : void {
    this.unicorn.body = id;
    this.updateSubject();
  }

  /**
   * set Hat and update the observable
   */
  setHat (id : number) : void {
    this.unicorn.hat = id;
    this.updateSubject();
  }

  /**
   * set Wings and update the observable
   */
  setWings (id : number) : void {
    this.unicorn.wings = id;
    this.updateSubject();
  }

  /**
   * set Shoes and update the observable
   */
  setShoes (id : number) : void {
    this.unicorn.shoes = id;
    this.updateSubject();
  }

  save () : void {
    let headers : Headers = new Headers({'Content-Type': 'application/json'});
    let options = new RequestOptions({headers: headers});
    this.http.post(`${SERVER}/v1/unicorns`, JSON.stringify(this.unicorn), options)
      .subscribe(res => {
        let id = JSON.parse(res._body).id;
        let random = fluff[Math.floor(Math.random() * fluff.length)];
        let url = window.location.href + random + '/' + id;
        this.url.next(url);
      });
  }

  load (id : number) : void {
    this.http.get(`${SERVER}/v1/unicorns/${id}`).subscribe((res : any) => {
      this.unicorn = JSON.parse(res._body);
      this.updateSubject();
    })
  }

  private updateSubject () {
    this.unicornSubject.next(this.unicorn);
  }
}
