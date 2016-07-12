import { provideRouter, RouterConfig } from '@angular/router';
import {Main} from './components/main';


const routes: RouterConfig = [
  { path: '', component: Main},
  { path: '**', redirectTo: ''},
];

export const APP_ROUTER_PROVIDERS = [
  provideRouter(routes)
];
