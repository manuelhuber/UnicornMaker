import {Injectable} from '@angular/core';
import {Http, Headers, RequestOptions, Response} from '@angular/http';
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
  // The url to share your (saved) unicorn with
  private url : BehaviorSubject<string> = new BehaviorSubject('');
  private unicorn : Unicorn;

  constructor (private http : Http) {
    this.unicorn = this.unicornSubject.getValue();
  }

  /**
   * Returns a observable unicorn
   */
  getUnicorn () : BehaviorSubject<Unicorn> {
    return this.unicornSubject;
  }

  /**
   * Returns a observable that contains the URL to show the latest saved unicorn
   */
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

  /**
   * Saves the current Unicorn and updates the url as soon as the server responds
   */
  save () : void {
    let headers : Headers = new Headers({'Content-Type': 'application/json'});
    let options = new RequestOptions({headers: headers});
    this.http.post(`${SERVER}/v1/unicorns`, JSON.stringify(this.unicorn), options)
      .subscribe((res : Response) => {
        let id = res.json().id;
        let random = fluff[Math.floor(Math.random() * fluff.length)];
        let url = window.location.href + random + '/' + id;
        this.url.next(url);
      });
  }

  /**
   * Fetch the unicorn with the given ID from the server and set it as the current unicorn
   */
  load (id : number) : void {
    this.http.get(`${SERVER}/v1/unicorns/${id}`).subscribe((res : Response) => {
      this.unicorn = res.json();
      this.updateSubject();
    })
  }

  /**
   * Propagate the current unicorn to the subject
   */
  private updateSubject () {
    this.unicornSubject.next(this.unicorn);
  }
}
