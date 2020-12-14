import { Component, OnInit } from '@angular/core';
import { GameDtoLite } from '../_models/GameDtos/gameDtoLite';
import { GameService } from '../_services/game.service'
import { PaginatedResult, Pagination } from '../_services/Pagination';

@Component({
  selector: 'app-gameList',
  templateUrl: './gameList.component.html',
  styleUrls: ['./gameList.component.css']
})
export class GameListComponent implements OnInit {
  games: GameDtoLite[];
  pagination : Pagination = {
    currentPage : 1,
    itemsPerPage : 2,
    totalItems : 0,
    totalPages : 0
  };

  constructor(private gameService: GameService) { }

  ngOnInit() {
    this.loadGames();
  }

  pageChanged(event: any): void {
    this.pagination.currentPage = event.page;
    this.loadGames();
  }

  loadGames() {
    this.gameService
      .getGameList(this.pagination.currentPage, this.pagination.itemsPerPage)
      .subscribe(
        (res: PaginatedResult<GameDtoLite[]>) => {
          this.games = res.result;
          this.pagination = res.pagination;
        }
      );
  }

}
