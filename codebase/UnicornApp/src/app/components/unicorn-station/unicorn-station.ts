import {Component, Input} from '@angular/core';
import {OptionMenu} from "./option-menu/option-menu";

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

}
