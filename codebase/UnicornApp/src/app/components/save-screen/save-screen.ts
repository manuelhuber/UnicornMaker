import {Component, Input} from "@angular/core";

@Component({
  selector: 'save-screen',
  pipes: [],
  providers: [],
  directives: [],
  templateUrl: './save-screen.html',
  styleUrls: ['./save-screen.less']
})
/**
 * The save page for the application
 * Written by Franziska Haaf
 */
export class SaveScreen {
  @Input()
  previous:Function;

  unicornlink:string = "http://www.unicorn-maker.com/unicorn/blablaba";

}
