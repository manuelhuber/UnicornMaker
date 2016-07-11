import {Component, Input} from '@angular/core';
import {UnicornService} from "../../services/unicorn-service";
import {OptionService} from "../../services/option-service";

@Component({
  selector: 'unicorn-display',
  pipes: [],
  providers: [],
  directives: [],
  templateUrl: './unicorn-display.html',
  styleUrls: ['./unicorn-display.less']
})
/**
 * A component to display the current unicorn
 * Written by Manuel Huber
 */
export class UnicornDisplay {
  bodyUrl : string;

  constructor (unicornService : UnicornService, private optionService : OptionService) {
    console.log(unicornService.getUnicorn().getValue());
    unicornService.getUnicorn().subscribe((unicorn : Unicorn) => {
      console.log('update: ');
      console.log(unicorn);
      this.updateUrls(unicorn);
    });
  }

  updateUrls (unicorn : Unicorn) : void {
    if (unicorn.body) {
      this.optionService.getBodyUrlForId(unicorn.body).subscribe(url => this.bodyUrl = url);
    }

  }
}
