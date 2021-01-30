import { Component, OnInit, Input } from '@angular/core';
import { SysReqDto } from 'src/app/_models/sysReqDto';

@Component({
  selector: 'app-sysReq',
  templateUrl: './sysReq.component.html',
  styleUrls: ['./sysReq.component.css']
})
export class SysReqComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  @Input() sysReqData: SysReqDto;

}
