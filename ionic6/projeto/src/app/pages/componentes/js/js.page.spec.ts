import { ComponentFixture, TestBed } from '@angular/core/testing';
import { JsPage } from './js.page';

describe('JsPage', () => {
  let component: JsPage;
  let fixture: ComponentFixture<JsPage>;

  beforeEach(() => {
    fixture = TestBed.createComponent(JsPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
