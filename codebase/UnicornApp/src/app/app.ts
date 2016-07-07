import {Component} from '@angular/core';
import {Main} from './components/main';
import './app.global.less';

@Component({
    selector: 'app',
    pipes: [],
    providers: [],
    directives: [Main],
    templateUrl: './app.html',
})
export class App {
    constructor () {}

}
