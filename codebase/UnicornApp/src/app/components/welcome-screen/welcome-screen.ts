import {Component, Input} from '@angular/core';

@Component({
  selector: 'welcome-screen',
  pipes: [],
  providers: [],
  directives: [],
  templateUrl: './welcome-screen.html',
  styleUrls: ['./welcome-screen.less']

})
/**
 * The landing page for the app
 * Written by Franziska Haaf
 */
export class WelcomeScreen {
  @Input() next : Function;

}
