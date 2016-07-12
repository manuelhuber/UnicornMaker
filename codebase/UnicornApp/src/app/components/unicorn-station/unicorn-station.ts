import {Component, Input} from '@angular/core';
import {OptionMenu} from "./option-menu/option-menu";
import {UnicornService} from "../../services/unicorn-service";

@Component({
  selector: 'unicorn-station',
  pipes: [],
  providers: [],
  directives: [OptionMenu],
  templateUrl: './unicorn-station.html',
  styleUrls: ['./unicorn-station.less']
})
/**
 * The working station where unicorns are modified
 * Written by Manuel Huber
 */
export class UnicornStation {
  @Input()
  next : Function;
  @Input()
  previous : Function;
  i : number = 0;
  private _name : string;

  get name () : string {
    return this._name;
  }

  set name (s : string) {
    this._name = s;
    this.unicornService.setName(s);
  }

  constructor (private unicornService : UnicornService) {

  }

  save () : void {
    this.unicornService.save();
    this.next();
  }

}
