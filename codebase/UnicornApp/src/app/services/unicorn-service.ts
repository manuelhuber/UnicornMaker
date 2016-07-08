import {Injectable} from '@angular/core';
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

  constructor () {
    this.unicorn = this.unicornSubject.getValue();
  }

  getUnicorn () : BehaviorSubject<Unicorn> {
    return this.unicornSubject;
  }

  setName (name : string) : void {
    this.unicorn.name = name;
    this.unicornSubject.next(this.unicorn);
  }

  setBody (id : number) : void {
    console.log('setting body id');
    this.unicorn.body = id;
    this.unicornSubject.next(this.unicorn);
  }


}
