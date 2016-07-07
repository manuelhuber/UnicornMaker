import {Component} from '@angular/core';
import {NgIf} from '@angular/common'

import {WelcomeScreen} from './welcome-screen/welcome-screen';
import {UnicornStation} from './unicorn-station/unicorn-station';
import {SaveScreen} from './save-screen/save-screen';

@Component({
    selector: 'main',
    pipes: [],
    providers: [],
    directives: [WelcomeScreen, UnicornStation, SaveScreen, NgIf],
    templateUrl: './main.html',
    styleUrls: ['./main.less']
})
export class Main {
    show : number = 0;
    total : number = 2;

    next () {
        this.show++;
    }

    previous () {
        this.show--;
    }

}
