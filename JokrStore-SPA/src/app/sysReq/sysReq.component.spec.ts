/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { SysReqComponent } from './sysReq.component';

describe('SysReqComponent', () => {
  let component: SysReqComponent;
  let fixture: ComponentFixture<SysReqComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SysReqComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SysReqComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
