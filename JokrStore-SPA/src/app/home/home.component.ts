import { Component, ElementRef, OnInit } from '@angular/core';
import { GameDto } from '../_models/GameDtos/gameDto';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  newReleaseGames : GameDto[];
  newTestableGames : GameDto[];
  
  /*slideIndex: number;
  slides: HTMLCollectionOf<any>;*/

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get(environment.baseUrl + 'home').subscribe(response => {
      this.newReleaseGames = response["newReleases"];
      this.newTestableGames = response["newTests"];
    }, error => {
      console.log(error);
    });
  }
}
