import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { GameListComponent } from '../gameList/gameList.component';
import { GameComponent } from '../game/game.component';
import { HomeComponent } from '../home/home.component';
import { RegisterComponent } from '../register/register.component';
import { CartComponent } from '../cart/cart.component';
import { UserDetailsComponent } from '../userDetails/userDetails.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: 'games',
    component: GameListComponent
  },
  {
    path: 'game/:id',
    component: GameComponent
  },
  {
    path: 'user/:id',
    component: UserDetailsComponent
  },
  {
    path: "register",
    component: RegisterComponent
  },
  {
    path: "cart",
    component: CartComponent
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [
      RouterModule
  ]
})
export class AppRoutingModule { }
