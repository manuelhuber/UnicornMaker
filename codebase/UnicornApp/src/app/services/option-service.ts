import {Injectable} from '@angular/core';
import {Http} from '@angular/http';
import {Observable} from 'rxjs'
import 'rxjs/add/operator/map';

const BASE : string = 'http://localhost:5001/';

@Injectable()
/**
 * The service responsible for fetching all available options
 * Written by Manuel Huber
 */
export class OptionService {
  constructor (private http : Http) {
  }

  getBodies () : Observable<Option[]> {
    return this.get('v1/bodies');
  }

  getWings () : Observable<Option[]> {
    return this.get('v1/Wings');
  }

  getHats () : Observable<Option[]> {
    return this.get('v1/Hats');
  }

  getShoes () : Observable<Option[]> {
    return this.get('v1/Shoes');
  }

  private get (path : string) : any {
    return this.http.get(`${BASE}${ path }`)
      .map((res) => res.json());
  }
}
