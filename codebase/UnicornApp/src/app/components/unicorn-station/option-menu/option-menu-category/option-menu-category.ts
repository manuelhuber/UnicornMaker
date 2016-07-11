import {Component, Input, Output, EventEmitter} from '@angular/core';
import {OptionMenuEntry} from '../option-menu-entry/option-menu-entry';

@Component({
  selector: 'option-menu-category',
  pipes: [],
  providers: [],
  directives: [OptionMenuEntry],
  templateUrl: './option-menu-category.html',
  styleUrls: ['./option-menu-category.less']
})
/**
 * Written by Manuel Huber
 */
export class OptionMenuCategory {
  @Input()
  options : Option[];
  @Input()
  id : number;

  @Output()
  update : EventEmitter<number> = new EventEmitter<number>();

  changeId (id : number) : void {
    this.update.emit(id);
    this.id = id;
  }
}
