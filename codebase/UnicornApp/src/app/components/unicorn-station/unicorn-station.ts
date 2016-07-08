import {Component, Input} from '@angular/core';

@Component({
  selector: 'unicorn-station',
  pipes: [],
  providers: [],
  directives: [],
  templateUrl: './unicorn-station.html',
  styleUrls: ['./unicorn-station.less']
})
export class UnicornStation {
  @Input()
  next : Function;
  @Input()
  previous : Function;

}
