import {Component} from '@angular/core';
import {NgFor, NgIf} from '@angular/common'
import {OptionService} from "../../../services/option-service";
import {OptionMenuCategory} from './option-menu-category/option-menu-category';
import {UnicornService} from '../../../services/unicorn-service';

@Component({
  selector: 'option-menu',
  pipes: [],
  providers: [OptionService],
  directives: [OptionMenuCategory, NgFor, NgIf],
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

  bodyId : number;
  hatId : number;
  wingsId : number;
  shoesId : number;

  constructor (optionService : OptionService, private unicornService : UnicornService) {
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

  updateBody (id : number) : void {
    this.unicornService.setBody(id);
  }

  updateHat (id : number) : void {
    this.unicornService.setHat(id);
  }

  updateWings (id : number) : void {
    this.unicornService.setWings(id);
  }

  updateShoes (id : number) : void {
    this.unicornService.setShoes(id);
  }
}
