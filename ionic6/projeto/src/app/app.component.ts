import { Component } from '@angular/core';
@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss'],
})
export class AppComponent {

  public menuComponenteCollection = [
    { title: 'Home', url: 'home', icon: 'home' },
    { title: 'Alert', url: 'alert', icon: 'alert' },
    { title: 'Accordion', url: 'accordion', icon: 'dice' },
    { title: 'ActionSheet', url: 'actionsheet', icon: 'dice' },
    { title: 'Ion-Button', url: 'button', icon: 'dice' },
    { title: 'Card', url: 'card', icon: 'card' },
    { title: 'Tags', url: 'tags', icon: 'dice' },
    { title: 'JS', url: 'js', icon: 'dice' },
    { title: 'Datetime', url: 'datetime', icon: 'dice' },
  ];

  public menuNativoCollection = [
    { title: 'Câmera', url: 'camera', icon: 'camera' },
  ];
  
  public labels = ['Family', 'Friends', 'Notes', 'Work', 'Travel', 'Reminders'];
  constructor() {}
}
