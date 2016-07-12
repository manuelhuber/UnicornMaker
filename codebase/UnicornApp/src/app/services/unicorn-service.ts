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
    router.events.subscribe(a => console.log(a));
    this.unicorn = this.unicornSubject.getValue();
  }

  /**
   * Returns a observable unicorn
   */
  getUnicorn () : BehaviorSubject<Unicorn> {
    return this.unicornSubject;
  }

  /**
   * set Name and update the observable
   */
  setName (name : string) : void {
    this.unicorn.name = name;
    this.unicornSubject.next(this.unicorn);
  }

  /**
   * set Body and update the observable
   */
  setBody (id : number) : void {
    this.unicorn.body = id;
    this.unicornSubject.next(this.unicorn);
  }

  /**
   * set Hat and update the observable
   */
  setHat (id : number) : void {
    this.unicorn.hat = id;
    this.unicornSubject.next(this.unicorn);
  }

  /**
   * set Wings and update the observable
   */
  setWings (id : number) : void {
    this.unicorn.wings = id;
    this.unicornSubject.next(this.unicorn);
  }

  /**
   * set Shoes and update the observable
   */
  setShoes (id : number) : void {
    this.unicorn.shoes = id;
    this.unicornSubject.next(this.unicorn);
  }

}
