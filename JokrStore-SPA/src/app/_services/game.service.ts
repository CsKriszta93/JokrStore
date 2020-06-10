import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { GameDto } from '../_models/GameDtos/gameDto';
import { Observable } from 'rxjs';
import { GameDtoLite } from '../_models/GameDtos/gameDtoLite';
import { PaginatedResult } from './Pagination';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class GameService {

  baseUrl = 'http://localhost:5000/api/games/';

  constructor(private http: HttpClient) { }

  getGameList(page?, itemsPerPage?): Observable<PaginatedResult<GameDtoLite[]>> {
    const paginatedResult: PaginatedResult<GameDtoLite[]> = new PaginatedResult<GameDtoLite[]>();
    
    let params = new HttpParams();

    if (page != null && itemsPerPage != null) {
      params = params.append('pageNumber', page);
      params = params.append('pageSize', itemsPerPage);
    }
    
    return this.http.get<GameDtoLite[]>(this.baseUrl + 'games', { observe: 'response', params})
      .pipe(
        map(response => {
          paginatedResult.result = response.body;
          if (response.headers.get('Pagination') != null) {
            paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'))
          }
          return paginatedResult;
        })
      );
  }

  getGame(id: number): Observable<GameDto> {
    return this.http.get<GameDto>(this.baseUrl + 'games/' + id);
  }

}
