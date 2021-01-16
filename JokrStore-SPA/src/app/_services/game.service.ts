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

  baseUrl = 'http://localhost:5000/api/Games/';

  constructor(private http: HttpClient) { }

  getGameList(page?, itemsPerPage?): Observable<PaginatedResult<GameDtoLite[]>> {
    const paginatedResult: PaginatedResult<GameDtoLite[]> = new PaginatedResult<GameDtoLite[]>();

    let params = new HttpParams();

    if (page != null && itemsPerPage != null) {
      params = params.append('CurrentPage', page);
      params = params.append('PageSize', itemsPerPage);
    }

    return this.http.get<GameDtoLite[]>(this.baseUrl + 'Games', { observe: 'response', params })
      .pipe(
        map(response => {
          paginatedResult.result = response.body["games"];
          if (response.headers.get('Pagination') != null) {
            paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'))
          }
          return paginatedResult;
        })
      );
  }

  getGame(id: any): Observable<GameDto> {
    return this.http.get<GameDto>(this.baseUrl + 'games/' + id);
  }

}
