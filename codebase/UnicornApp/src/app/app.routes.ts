import {provideRouter, RouterConfig} from '@angular/router';
import {Main} from './components/main';

const routes : RouterConfig = [
    {path: 'magic', component: Main},
    {path: '**', redirectTo: 'magic', terminal: true},
];

export const APP_ROUTER_PROVIDERS = [
    provideRouter(routes)
];
