import { Component, OnInit } from '@angular/core';
import { GameDto } from '../_models/GameDtos/gameDto';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  newReleaseGames : GameDto;
  newTestableGames : GameDto;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get('http://localhost:5000/api/games/index').subscribe(response => {
      this.newReleaseGames = response["new_releases"];
      this.newTestableGames = response["new_tests"];
    }, error => {
      console.log(error);
    });

  }

}
