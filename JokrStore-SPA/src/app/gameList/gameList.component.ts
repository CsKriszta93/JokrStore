import { Component, OnInit } from '@angular/core';
import { GameDtoLite } from '../_models/GameDtos/gameDtoLite';
import { GameService } from '../_services/game.service'
import { catchError } from 'rxjs/operators';
import { PaginatedResult } from '../_services/Pagination';

@Component({
  selector: 'app-gameList',
  templateUrl: './gameList.component.html',
  styleUrls: ['./gameList.component.css']
})
export class GameListComponent implements OnInit {
  games: PaginatedResult<GameDtoLite[]>;
  currentPage = 1;
  pageSize = 2;

  constructor(private gameService: GameService) { }

  ngOnInit() {
    this.gameService.getGameList(this.currentPage, this.pageSize)
      .subscribe(result => this.games = result);
  }

  pageChanged(event: any): void {
    this.currentPage = event.page;
    console.log(this.currentPage);
  }

}
