import { Component, OnInit } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { EarthApiService } from '../../services/earth-api.service';

@Component({
  selector: 'app-earth',
  standalone: true,
  imports: [MatButtonModule],
  templateUrl: './earth.component.html',
  styleUrl: './earth.component.css'
})
export class EarthComponent implements OnInit {
  intro: string;
  fact: string;
  constructor(private earthApiService: EarthApiService) {
    this.intro = "";
    this.fact = "Click button to get a random fact";
  }

  ngOnInit() {
    this.earthApiService.getIntro().subscribe(r => this.intro = r);
  }

  getFact() {
    this.earthApiService.getFact().subscribe(f => this.fact = f);
  }
}
