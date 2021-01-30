import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { CommentDto } from '../_models/commentDto'

@Injectable({
  providedIn: 'root'
})
export class CommentService {

  baseUrl = environment.baseUrl;

  constructor(private http: HttpClient) { }
  
  postComment(comment: CommentDto) {
    this.http.post(this.baseUrl + 'comment', comment);
  }

}
