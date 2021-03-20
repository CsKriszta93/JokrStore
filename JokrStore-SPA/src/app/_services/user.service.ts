import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ApiPaths } from '../api-paths';
import { UserDto } from '../_models/UserDtos/userDto';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  baseUrl = environment.baseUrl;
  
  constructor(private http: HttpClient) { }
  
  getUserDetails(id: any): Observable<UserDto> {
    return this.http.get<UserDto>(`${this.baseUrl}users/${id}`);
  }

}
