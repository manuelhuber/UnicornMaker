import {Component} from '@angular/core';
import {NgFor, NgIf} from '@angular/common'
import {OptionService} from "../../../services/option-service";
import {OptionMenuEntry} from "./option-menu-entry/option-menu-entry";

@Component({
  selector: 'option-menu',
  pipes: [],
  providers: [OptionService],
  directives: [OptionMenuEntry, NgFor, NgIf],
  templateUrl: './option-menu.html',
  styleUrls: ['./option-menu.less']
})
/**
 * The working station where unicorns are modified
 * Written by Manuel Huber
 */
export class OptionMenu {
  bodies : Option[];
  hats : Option[];
  wings : Option[];
  shoes : Option[];


  constructor (optionService : OptionService) {
    optionService.getBodies().subscribe((bodies : Option[]) => {
      this.bodies = bodies;
      console.log(this.bodies);
    });
    // optionService.getHats().subscribe((hats : Option[]) => {
    //   this.hats = hats;
    //   console.log(this.hats);
    // });
    // optionService.getWings().subscribe((wings : Option[]) => {
    //   this.wings = wings;
    //   console.log(this.wings);
    // });
    // optionService.getShoes().subscribe((shoes : Option[]) => {
    //   this.shoes = shoes;
    //   console.log(this.shoes);
    // });
  }
}
