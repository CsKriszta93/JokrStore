import { Component, OnInit } from '@angular/core';
import { GameService } from '../_services/game.service';
import { UserService } from '../_services/user.service';
import { ActivatedRoute, Params } from '@angular/router';
import { UserDto } from '../_models/UserDtos/userDto';

@Component({
  selector: 'app-userDetails',
  templateUrl: './userDetails.component.html',
  styleUrls: ['./userDetails.component.css']
})
export class UserDetailsComponent implements OnInit {

  id: any;
  user: UserDto;
  isMyUser: boolean;

  constructor(
    private userService: UserService,
    private route: ActivatedRoute,
  ) { }

  ngOnInit() {
    this.route.params
      .subscribe(
        (params: Params) => {
          this.id = params['id'];
        }
      );

      this.userService.getUserDetails(this.id)
      .subscribe((x: any) => {
        this.user = x.user;
        this.isMyUser = x.isMyUser;
      }, error => {
        console.log(error);
      });
  }

}
