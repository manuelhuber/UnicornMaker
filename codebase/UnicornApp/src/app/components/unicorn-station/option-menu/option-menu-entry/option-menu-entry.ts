import {Component, Input} from '@angular/core';
import {NgIf} from '@angular/common'

@Component({
  selector: 'option-menu-entry',
  pipes: [],
  providers: [],
  directives: [NgIf],
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
