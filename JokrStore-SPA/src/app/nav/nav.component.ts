import { Component, OnInit, Input } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { UserLoginDto } from '../_models/UserDtos/userLoginDto';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  isCollapsed: boolean = true;
  @Input() stateFromApp : number;
  model: UserLoginDto = {
    userName : "",
    password : ""
  };

  constructor(
    public authService: AuthService,
    private router: Router,
    private toastr: ToastrService
  ) { }

  ngOnInit() {
    let token = this.authService.getCurrentToken();
    if (token && this.tokenExpired(token))
      this.authService.logout();
  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      console.log('Logged in successfully');
    }, error => {
      console.log(error);
      this.toastr.error('Failed to log in');
    });
  }

  logout() {
    this.authService.logout();
    this.router.navigateByUrl('/home');
  }

  gameList() {
    this.stateFromApp = 1;
    console.log('state switched');
  }

  private tokenExpired(token: string) {
    const expiry = (JSON.parse(atob(token.split('.')[1]))).exp;
    return (Math.floor((new Date).getTime() / 1000)) >= expiry;
  }

}
