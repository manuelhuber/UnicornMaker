import {Component} from '@angular/core';
import {NgIf} from '@angular/common';
import {UnicornService} from "../../services/unicorn-service";
import {OptionService} from "../../services/option-service";

@Component({
  selector: 'unicorn-display',
  pipes: [],
  providers: [],
  directives: [NgIf],
  templateUrl: './unicorn-display.html',
  styleUrls: ['./unicorn-display.less']
})
/**
 * A component to display the current unicorn
 * Written by Manuel Huber
 */
export class UnicornDisplay {
  bodyUrl : string;
  hatUrl : string;
  shoesUrl : string;
  wingsUrl : string;

  constructor (unicornService : UnicornService, private optionService : OptionService) {
    unicornService.getUnicorn().subscribe((unicorn : Unicorn) => {
      this.updateUrls(unicorn);
    });
  }

  updateUrls (unicorn : Unicorn) : void {
    this.optionService.getBodyUrlForId(unicorn.body).subscribe(url => this.bodyUrl = url);
    this.optionService.getHatUrlForId(unicorn.hat).subscribe(url => this.hatUrl = url);
    this.optionService.getShoesUrlForId(unicorn.shoes).subscribe(url => this.shoesUrl = url);
    this.optionService.getWingsUrlForId(unicorn.wings).subscribe(url => this.wingsUrl = url);

  }
}
