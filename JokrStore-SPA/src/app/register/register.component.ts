import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  model: any = {};
  confirmPassword: string;
  constructor(private authService: AuthService,
              private toastr: ToastrService) { }

  ngOnInit() {
  }

  register() {
    if (this.model.password != this.confirmPassword) {
      console.log("Error: Passwords are different");
      this.toastr.error('Passwords are different');
      return;
    }
    this.authService.register(this.model).subscribe(response => {
      console.log(response);
    }, error => {
      console.log(error);
    });
  }

  cancel() {
    
  }

}
