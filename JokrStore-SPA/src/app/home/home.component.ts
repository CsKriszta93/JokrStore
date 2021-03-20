import { Component, OnInit } from '@angular/core';
import { GameDto } from '../_models/GameDtos/gameDto';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  newReleaseGames : GameDto[];
  newTestableGames : GameDto[];
  slideIndex: number;
  slides: Element[];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get('http://localhost:5000/api/home').subscribe(response => {
      this.newReleaseGames = response["newReleases"];
      this.newTestableGames = response["newTests"];
    }, error => {
      console.log(error);
    });

  }

  /*carousel() {
    let i : Number;
    this.slides = document.getElementsByClassName("mySlides");
    for (i = 0; i < x.length; i++) {
      x[i].style.display = "none"; 
    }
    slideIndex++;
    if (slideIndex > x.length) {slideIndex = 1} 
    x[slideIndex-1].style.display = "block"; 
    setTimeout(carousel, 2000); 
  }*/

}
