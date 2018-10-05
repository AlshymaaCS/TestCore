import { Component, OnInit } from '@angular/core';
import { MakeService } from '../services/make.service';

@Component({
  selector: 'app-car-form',
  templateUrl: './car-form.component.html',
  styleUrls: ['./car-form.component.css']
})
export class CarFormComponent implements OnInit {

  private makes;
  constructor(private makesService: MakeService) { }

  ngOnInit() {
    this.makesService.getMakes().subscribe(makes => this.makes = makes);
  }

}
