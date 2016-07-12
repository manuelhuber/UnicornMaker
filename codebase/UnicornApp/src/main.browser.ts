import {LocationStrategy, HashLocationStrategy} from '@angular/common';
import {bootstrap} from '@angular/platform-browser-dynamic';
import {HTTP_PROVIDERS} from '@angular/http';
// import {enableProdMode} from '@angular/core';

import {APP_ROUTER_PROVIDERS} from './app/app.routes';
import {App} from './app/app';
import {UnicornService} from './app/services/unicorn-service';
import {OptionService} from './app/services/option-service';

// enableProdMode()

bootstrap(App, [
  HTTP_PROVIDERS,
  APP_ROUTER_PROVIDERS,
  UnicornService,
  OptionService,
  {provide: LocationStrategy, useClass: HashLocationStrategy}
])
  .catch(err => console.error(err));
