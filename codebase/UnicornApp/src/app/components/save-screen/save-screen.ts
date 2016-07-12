import {Component, Input} from "@angular/core";
import {UnicornService} from "../../services/unicorn-service";

@Component({
  selector: 'save-screen',
  pipes: [],
  providers: [],
  directives: [],
  templateUrl: './save-screen.html',
  styleUrls: ['./save-screen.less']
})
/**
 * The save page for the application
 * Written by Franziska Haaf
 */
export class SaveScreen {
  @Input()
  previous : Function;

  unicornlink : string = "http://www.unicorn-maker.com/unicorn/blablaba";
  unicornName : string;

  constructor (private unicornService : UnicornService) {
    unicornService.getUnicorn().subscribe((unicorn : Unicorn) => {
      this.unicornName = unicorn.name;
    });
    unicornService.getCurrentUrl().subscribe(url => this.unicornlink = url);
  }

  copyLinkToClipboard () : void {
    window.prompt("Copy to clipboard: Ctrl+C, Enter", this.unicornlink);
  }
}
