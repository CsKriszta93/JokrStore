import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { UserLoginDto } from '../_models/UserDtos/userLoginDto';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: UserLoginDto = {
    userName : "",
    password : ""
  };

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      console.log('Logged in successfully');
    }, error => {
      console.log('failed to login');
    });
  }

  logout() {
    localStorage.removeItem('token');
    console.log('log out');
  }

  isLoggedIn() {
    const token = localStorage.getItem('token');
    return !!token;
  }

}
