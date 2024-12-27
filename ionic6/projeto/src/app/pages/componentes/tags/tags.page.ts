import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tags',
  templateUrl: './tags.page.html',
  styleUrls: ['./tags.page.scss'],
})
export class TagsPage implements OnInit {
  public progress = 0;


  constructor() {
  
  setInterval(() => {
    this.progress +=0.01;

    if (this.progress > 1){
      setTimeout(() =>{
        this.progress = 0;
      }, 1000);
    }
  }, 50);
}




  ngOnInit() {
  }

}
