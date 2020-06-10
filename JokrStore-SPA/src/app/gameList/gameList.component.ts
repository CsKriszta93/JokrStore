import { Component, OnInit } from '@angular/core';
import { GameDtoLite } from '../_models/GameDtos/gameDtoLite';
import { GameService } from '../_services/game.service'
import { catchError } from 'rxjs/operators';

@Component({
  selector: 'app-gameList',
  templateUrl: './gameList.component.html',
  styleUrls: ['./gameList.component.css']
})
export class GameListComponent implements OnInit {
  games : GameDtoLite[];
  pageNumber = 1;
  pageSize = 2;

  constructor(private gameService: GameService) { }

  ngOnInit() {
    this.games = this.gameService.getGameList(this.pageNumber, this.pageSize)['games'].result;
  }

}
