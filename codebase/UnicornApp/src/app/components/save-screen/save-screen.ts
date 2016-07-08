import {Component, Input} from '@angular/core';

@Component({
  selector: 'save-screen',
  pipes: [],
  providers: [],
  directives: [],
  templateUrl: './save-screen.html',
  styleUrls: ['./save-screen.less']
})
export class SaveScreen {
  @Input()
  previous : Function;
}
