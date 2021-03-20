import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { GameDto } from '../_models/GameDtos/gameDto';
import { Observable } from 'rxjs';
import { GameDtoLite } from '../_models/GameDtos/gameDtoLite';
import { PaginatedResult } from './Pagination';
import { map } from 'rxjs/operators';
import { ApiPaths } from '../api-paths';
import { environment } from 'src/environments/environment';
import { CartGameDto } from '../_models/GameDtos/cartGameDto';

@Injectable({
  providedIn: 'root'
})
export class GameService {

  baseUrl = environment.baseUrl;

  constructor(private http: HttpClient) { }

  getGameList(page?, itemsPerPage?): Observable<PaginatedResult<GameDtoLite[]>> {
    const paginatedResult: PaginatedResult<GameDtoLite[]> = new PaginatedResult<GameDtoLite[]>();

    let params = new HttpParams();

    if (page != null && itemsPerPage != null) {
      params = params.append('CurrentPage', page);
      params = params.append('PageSize', itemsPerPage);
    }

    return this.http.get<GameDtoLite[]>(this.baseUrl + ApiPaths.Games, { observe: 'response', params })
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
    return this.http.get<GameDto>(`${this.baseUrl}${ApiPaths.Games}/${id}`);
  }

  getUserGames(id: any): Observable<GameDto> {
    return this.http.get<GameDto>(`${this.baseUrl}${ApiPaths.Games}/my-games/${id}`);
  }

  buyGames() {
    let cart : Array<CartGameDto>;
    cart = JSON.parse(localStorage.getItem('cart'));
    return this.http.post(this.baseUrl + 'cart', cart);
  }

}
