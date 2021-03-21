import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { ReplaySubject } from 'rxjs';
import { UserDto } from '../_models/UserDtos/userDto';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  baseUrl = environment.baseUrl + 'auth/';
  private currentUserSource = new ReplaySubject<UserDto>(1);
  currentUser$ = this.currentUserSource.asObservable();

  constructor(private http: HttpClient) { }

  public login(model: any) {
    return this.http.post(this.baseUrl + 'login', model).pipe(
      map((response: any) => {
        const user = response;
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSource.next(user);
        }
      })
    );
  }

  public register(model: any) {
    return this.http.post(this.baseUrl + 'register', model).pipe(
      map((user: any) => {
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSource.next(user);
        }
      })
    )
  }

  public logout() {
    localStorage.removeItem('user');
    this.currentUserSource.next(null);
  }

  public setCurrentUser(user: UserDto) {
    this.currentUserSource.next(user);
  }

  public getCurrentUser() {
    return JSON.parse(localStorage.getItem('user')).user;
  }

  public getCurrentToken() {
    let user = localStorage.getItem('user');

    if (user)
      return JSON.parse(user).token ?? null;
  }
}
