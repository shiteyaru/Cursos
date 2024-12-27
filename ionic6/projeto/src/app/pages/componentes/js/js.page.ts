import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-js',
  templateUrl: './js.page.html',
  styleUrls: ['./js.page.scss'],
})
export class JsPage implements OnInit {

  constructor() { }


  handleRefresh(event: { target: { complete: () => void; }; }) {
    console.log('atualização requisitada')
    setTimeout(() => {
      console.log('atualização completa')
      event.target.complete();
    }, 2000);
  }


  ngOnInit() {
  }

}
