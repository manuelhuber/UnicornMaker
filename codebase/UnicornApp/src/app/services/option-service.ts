import {Injectable} from '@angular/core';
import {Http} from '@angular/http';
import {Observable} from 'rxjs'
import 'rxjs/add/operator/map';
import {SERVER} from '../app';

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

  /**
   * Fetch the options for bodies
   */
  getBodies () : Observable<Option[]> {
    this.bodiesCache = this.get('v1/bodies');
    return this.bodiesCache;
  }

  /**
   * Returns the image URL for the ID with the given option if such an option is known
   * Or an empty string if there is no option
   */
  getBodyUrlForId (id : number) : Observable<string> {
    if (!this.bodiesCache) {
      this.getBodies();
    }
    return this.bodiesCache.map((options : Option[]) => {
      return this.getOptionByIdFromArray(options, id);
    })
  }

  /**
   * Fetch the options for wings
   */
  getWings () : Observable<Option[]> {
    this.wingsCache = this.get('v1/Wings');
    return this.wingsCache;
  }

  /**
   * Returns the image URL for the ID with the given option if such an option is known
   * Or an empty string if there is no option
   */
  getWingsUrlForId (id : number) : Observable<string> {
    if (!this.wingsCache) {
      this.getWings();
    }
    return this.wingsCache.map((options : Option[]) => {
      return this.getOptionByIdFromArray(options, id);
    })
  }

  /**
   * Fetch the options for hats
   */
  getHats () : Observable<Option[]> {
    this.hatsCache = this.get('v1/Hats');
    return this.hatsCache;
  }

  /**
   * Returns the image URL for the ID with the given option if such an option is known
   * Or an empty string if there is no option
   */
  getHatUrlForId (id : number) : Observable<string> {
    if (!this.hatsCache) {
      this.getHats();
    }
    return this.hatsCache.map((options : Option[]) => {
      return this.getOptionByIdFromArray(options, id);
    })
  }

  /**
   * Fetch the options for shoes
   */
  getShoes () : Observable<Option[]> {
    this.shoesCache = this.get('v1/Shoes');
    return this.shoesCache;
  }

  /**
   * Returns the image URL for the ID with the given option if such an option is known
   * Or an empty string if there is no option
   */
  getShoesUrlForId (id : number) : Observable<string> {
    if (!this.shoesCache) {
      this.getShoes();
    }
    return this.shoesCache.map((options : Option[]) => {
      return this.getOptionByIdFromArray(options, id);
    })
  }

  /**
   * Sends a get request with the given path to the server
   * The observable caches the data
   */
  private get (path : string) : Observable<any> {
    return this.http.get(`${SERVER}${ path }`)
      .map((res) => res.json())
      // Caching
      .publishReplay(1)
      .refCount();
  }

  /**
   * Filters the url of the option with the given ID or returns an empty string
   */
  private getOptionByIdFromArray (options : Option[], id : number) : string {
    let option : Option = options.reduce((previousValue, currentValue) => {
      if (previousValue) {
        return previousValue;
      }
      if (currentValue.id === id) {
        return currentValue;
      }
    }, undefined);

    return option ? option.url : '';
  }
}
