import {Component} from '@angular/core';
import {ROUTER_DIRECTIVES} from '@angular/router';

import './app.global.less';

@Component({
    selector: 'app',
    pipes: [],
    providers: [],
    directives: [ROUTER_DIRECTIVES],
    templateUrl: './app.html',
    // styleUrls: ['./app.less']
})
export class App {
    constructor () {}

}
