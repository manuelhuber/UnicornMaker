import {Component} from '@angular/core';
import {ROUTER_DIRECTIVES} from '@angular/router';
import './app.global.less';

export const SERVER : string = 'http://localhost:52443/';

@Component({
  selector: 'app',
  pipes: [],
  providers: [],
  directives: [ROUTER_DIRECTIVES],
  templateUrl: './app.html',
})
export class App {
  constructor () {}

}
