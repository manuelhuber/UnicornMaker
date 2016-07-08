import {Component} from '@angular/core';
import {NgIf} from '@angular/common'

import {WelcomeScreen} from './welcome-screen/welcome-screen';
import {UnicornStation} from './unicorn-station/unicorn-station';
import {SaveScreen} from './save-screen/save-screen';
import {UnicornDisplay} from "./unicorn-display/unicorn-display";
import {OptionService} from "../services/option-service";

@Component({
  selector: 'main',
  pipes: [],
  providers: [OptionService],
  directives: [WelcomeScreen, UnicornStation, SaveScreen, UnicornDisplay, NgIf],
  templateUrl: './main.html',
  styleUrls: ['./main.less']
})
/**
 * The 
 * Written by Manuel Huber
 */
export class Main {
  public show : number = 0;
  public total : number = 2;
  public boundNext : Function;
  public boundPrevious : Function;

  constructor (service : OptionService) {
    service.getBodies().subscribe(a => console.log(a));
  }

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
