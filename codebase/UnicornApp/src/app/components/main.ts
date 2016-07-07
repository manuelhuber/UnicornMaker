import {Component} from '@angular/core';
import {WelcomeScreen} from './welcome-screen/welcome-screen';

@Component({
    selector: 'main',
    pipes: [],
    providers: [],
    directives: [WelcomeScreen],
    templateUrl: './main.html',
    styleUrls: ['./main.less']
})
export class Main {
    constructor () {}

}
