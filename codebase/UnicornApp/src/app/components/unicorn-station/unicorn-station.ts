import {Component, Input} from '@angular/core';

@Component({
  selector: 'unicorn-station',
  pipes: [],
  providers: [],
  directives: [],
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
