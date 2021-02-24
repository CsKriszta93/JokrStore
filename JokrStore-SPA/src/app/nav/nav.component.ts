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
  @Input() stateFromApp : number;
  model: UserLoginDto = {
    userName : "",
    password : ""
  };

  constructor(public authService: AuthService, private router: Router,
      private toastr: ToastrService) { }

  ngOnInit() {
  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      console.log('Logged in successfully');
    }, error => {
      console.log('failed to login');
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

}
