import {Component} from '@angular/core';
import {NgIf} from '@angular/common'

import {WelcomeScreen} from './welcome-screen/welcome-screen';
import {UnicornStation} from './unicorn-station/unicorn-station';
import {SaveScreen} from './save-screen/save-screen';
import {UnicornDisplay} from "./unicorn-display/unicorn-display";

@Component({
  selector: 'main',
  pipes: [],
  providers: [],
  directives: [WelcomeScreen, UnicornStation, SaveScreen, UnicornDisplay, NgIf],
  templateUrl: './main.html',
  styleUrls: ['./main.less']
})
export class Main {
  public show : number = 0;
  public total : number = 2;
  public boundNext : Function;
  public boundPrevious : Function;

  public ngOnInit () {
    this.boundNext = this.next.bind(this);
    this.boundPrevious = this.previous.bind(this);
  }

  public next () {
    this.show++;
  }

  public previous () {
    this.show--;
  }

}
