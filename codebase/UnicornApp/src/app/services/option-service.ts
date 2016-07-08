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

  bodiesCache : Observable<Option[]>;
  wingsCache : Observable<Option[]>;
  hatsCache : Observable<Option[]>;
  shoesCache : Observable<Option[]>;

  constructor (private http : Http) {
  }

  getBodies () : Observable<Option[]> {
    this.bodiesCache = this.get('v1/bodies');
    return this.bodiesCache;
  }

  getBodyUrlForId (id : number) : Observable<string> {
    if (!this.bodiesCache) {
      this.getBodies();
    }
    return this.bodiesCache.map((options : Option[]) => {
      return this.getOptionByIdFromArray(options, id);
    })
  }

  getWings () : Observable<Option[]> {
    this.wingsCache = this.get('v1/Wings');
    return this.wingsCache;
  }

  getWingsUrlForId (id : number) : Observable<string> {
    if (!this.wingsCache) {
      this.getWings();
    }
    return this.wingsCache.map((options : Option[]) => {
      return this.getOptionByIdFromArray(options, id);
    })
  }

  getHats () : Observable<Option[]> {
    this.hatsCache = this.get('v1/Hats');
    return this.hatsCache;
  }

  getHatUrlForId (id : number) : Observable<string> {
    if (!this.hatsCache) {
      this.getHats();
    }
    return this.hatsCache.map((options : Option[]) => {
      return this.getOptionByIdFromArray(options, id);
    })
  }

  getShoes () : Observable<Option[]> {
    this.shoesCache = this.get('v1/Shoes');
    return this.shoesCache;
  }

  getShoesUrlForId (id : number) : Observable<string> {
    if (!this.shoesCache) {
      this.getShoes();
    }
    return this.shoesCache.map((options : Option[]) => {
      return this.getOptionByIdFromArray(options, id);
    })
  }

  private get (path : string) : any {
    return this.http.get(`${BASE}${ path }`)
      .map((res) => res.json());
  }

  private getOptionByIdFromArray (options : Option[], id : number) : string {
    return options.reduce((previousValue, currentValue) => {
      if (previousValue) {
        return previousValue;
      }
      if (currentValue.id === id) {
        return currentValue;
      }
    }, undefined).url;
  }
}
