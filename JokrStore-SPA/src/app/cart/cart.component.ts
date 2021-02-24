import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CartGameDto } from '../_models/GameDtos/cartGameDto';
import { GameService } from '../_services/game.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {

  constructor(
    private gameService: GameService,
    private router: Router
    ) { }

  cart : Array<CartGameDto>;
  priceSum: number;

  ngOnInit() {
    this.cart = JSON.parse(localStorage.getItem('cart'));
    this.show('page_cart', 'page_pay_mode');
    this.priceSum = 0;
    this.cart.forEach(element => {
      this.priceSum += element.price;
    });
  }

  show(shown, hidden) {
    document.getElementById(shown).style.display='block';
    document.getElementById(hidden).style.display='none';
  }

  public Remove(id: any) {
    this.cart = this.cart.filter(item => item.id !== id);
    localStorage.setItem('cart', JSON.stringify(this.cart));
  }

  public Buy() {
    this.gameService.buyGames().subscribe(response => {
      console.log(response);
      localStorage.removeItem('cart');
      this.router.navigateByUrl('/games');
    }, error => {
      console.log(error);
    })
  }
}