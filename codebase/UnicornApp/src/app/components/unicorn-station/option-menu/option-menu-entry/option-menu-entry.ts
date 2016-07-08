import {Component, Input} from '@angular/core';
import {NgFor, NgIf} from '@angular/common'

@Component({
  selector: 'option-menu-entry',
  pipes: [],
  providers: [NgFor, NgIf],
  directives: [],
  templateUrl: './option-menu-entry.html',
  styleUrls: ['./option-menu-entry.less']
})
/**
 * Written by Manuel Huber
 */
export class OptionMenuEntry {
  @Input()
  option : Option;
}
