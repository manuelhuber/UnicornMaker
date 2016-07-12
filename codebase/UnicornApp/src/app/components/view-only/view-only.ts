import {Component} from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {UnicornService} from '../../services/unicorn-service';
import {UnicornDisplay} from '../unicorn-display/unicorn-display';

@Component({
  selector: 'view-only',
  pipes: [],
  providers: [UnicornService],
  directives: [UnicornDisplay],
  templateUrl: './view-only.html',
  styleUrls: ['./view-only.less']
})
/**
 * The working station where unicorns are modified
 * Written by Manuel Huber
 */
export class ViewOnly {
  private sub : any;
  unicorn : Unicorn;

  constructor (private route : ActivatedRoute, private unicornService : UnicornService) {
    unicornService.getUnicorn().subscribe(unicorn => this.unicorn = unicorn);
  }

  ngOnInit () {
    let id = +this.route.snapshot.params['id'];
    this.unicornService.load(id);
  }
}
