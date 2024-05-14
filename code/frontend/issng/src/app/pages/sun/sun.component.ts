import { Component, OnInit } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { SunApiService } from '../../services/sun-api.service';

@Component({
  selector: 'app-sun',
  standalone: true,
  imports: [MatButtonModule],
  templateUrl: './sun.component.html',
  styleUrl: './sun.component.css'
})
export class SunComponent implements OnInit {
  intro: string;
  fact: string;
  constructor(private sunApiService: SunApiService) {
    this.intro = "";
    this.fact = "Click button to get a random fact";
  }

  ngOnInit() {
    this.sunApiService.getIntro().subscribe(r => this.intro = r);
  }

  getFact() {
    this.sunApiService.getFact().subscribe(f => this.fact = f);
  }
}
