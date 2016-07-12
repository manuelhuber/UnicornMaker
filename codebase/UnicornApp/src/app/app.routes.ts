import {provideRouter, RouterConfig} from '@angular/router';
import {Main} from './components/main';
import {ViewOnly} from './components/view-only/view-only';

const routes : RouterConfig = [
  {path: '', component: Main},
  {path: ':fun/:id', component: ViewOnly},
  {path: '**', redirectTo: ''},
];

export const APP_ROUTER_PROVIDERS = [
  provideRouter(routes)
];
