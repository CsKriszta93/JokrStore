import { analyzeAndValidateNgModules } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router} from '@angular/router';
import { GameDto } from '../_models/GameDtos/gameDto';
import { CommentDto } from '../_models/commentDto';
import { AuthService } from '../_services/auth.service';
import { GameService } from '../_services/game.service';
import { CommentService } from '../_services/comment.service';
import { CartGameDto } from '../_models/GameDtos/cartGameDto';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent implements OnInit {

  game: GameDto;
  myDevelopment: boolean;
  id: any;
  comment: CommentDto = {
    commenter: null,
    contain: "",
    commentDate: "",
    gameId: "",
    user: null
  };
  cartGame: CartGameDto = {
    id: null,
    gameName: "",
    coverArt: "",
    price: 0
  }

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    public authService: AuthService,
    private gameService: GameService,
    private commentService: CommentService
  ) { }

  ngOnInit() {
    this.route.params
      .subscribe(
        (params: Params) => {
          this.id = params['id'];
        }
      );

    this.loadGame();
  }

  public editSysReq() {

  }

  public buyGame() {
    let cart: Array<CartGameDto> = JSON.parse(localStorage.getItem('cart'));
    if (!cart)
      cart = [];
    this.cartGame = {id: this.game.id, gameName: this.game.gameName, coverArt: this.game.coverArt, price: this.game.price};
    cart.push(this.cartGame);
    localStorage.setItem('cart', JSON.stringify(cart));
    this.router.navigateByUrl('/cart');
  }

  public downloadGame() {
    console.log("asd");
  }

  public downloadDemo() {

  }

  public submitComment() {
    this.comment.gameId = this.game.id;
    this.commentService.postComment(this.comment).subscribe(() => {
      this.loadGame();
    });
  }

  loadGame() {
    this.gameService.getGame(this.id)
      .subscribe((x: any) => {
        this.game = x.game;
        this.game.comments.sort((a, b) => {
          if (a.commentDate > b.commentDate)
            return -1;
          else if (a.commentDate < b.commentDate)
            return 1;
          return 0;
        });
      });
  }

}
