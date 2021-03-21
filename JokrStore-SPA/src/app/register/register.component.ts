import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model: any = {};
  confirmPassword: string;
  constructor(
    private authService: AuthService,
    private toastr: ToastrService,
    private router: Router
  ) { }

  ngOnInit() {
  }

  register() {
    if (this.model.password != this.confirmPassword) {
      console.log("Error: Passwords are different");
      this.toastr.error('Passwords are different');
      return;
    }
    this.authService.register(this.model).subscribe(response => {
      console.log("Register succesfull");
      this.toastr.success("Register succesfull");
      this.router.navigateByUrl('/home');
    }, error => {
      console.log(error);
      this.toastr.error('Failed to register.');
    });
  }

  cancel() {
    
  }

}
