import {Injectable} from '@angular/core';
import {Router} from '@angular/router';
import {BehaviorSubject} from 'rxjs'

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
  private unicorn : Unicorn;

  constructor (private router : Router) {
    router.events.subscribe(a => console.log(a));3
    this.unicorn = this.unicornSubject.getValue();
  }

  getUnicorn () : BehaviorSubject<Unicorn> {
    return this.unicornSubject;
  }

  setName (name : string) : void {
    this.unicorn.name = name;
    this.unicornSubject.next(this.unicorn);
  }

  getName() : string {
    return this.unicorn.name;
  }

  setBody (id : number) : void {
    this.unicorn.body = id;
    this.unicornSubject.next(this.unicorn);
  }

  setHat (id : number) : void {
    this.unicorn.hat = id;
    this.unicornSubject.next(this.unicorn);
  }

  setWings (id : number) : void {
    this.unicorn.wings = id;
    this.unicornSubject.next(this.unicorn);
  }

  setShoes (id : number) : void {
    this.unicorn.shoes = id;
    this.unicornSubject.next(this.unicorn);
  }
  
}
