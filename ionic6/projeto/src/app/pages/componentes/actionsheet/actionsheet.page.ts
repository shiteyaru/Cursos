import { Component, OnInit } from '@angular/core';
import { ActionSheetController } from '@ionic/angular';

@Component({
  selector: 'app-actionsheet',
  templateUrl: './actionsheet.page.html',
  styleUrls: ['./actionsheet.page.scss'],
})
export class ActionsheetPage implements OnInit {

  constructor(private actionsheetCtrl: ActionSheetController) { }

  async actionsheet() {
    const actionSheet = await this.actionsheetCtrl.create({
      header: 'Albums',
      mode: 'ios',
      buttons: [
        {
          text: 'Delete',
          role: 'destructive',
          icon: 'trash',
          handler: () => {
            console.log('Delete clicked');
          }
        },
        {
          text: 'Share',
          role: 'share',
          icon: 'share',
          handler: () => {
            console.log('Share clicked');
          }
        }, {
          text: 'Play',
          icon: 'play',
          handler: () => {
            console.log('Play clicked');
          }
        },
        {
          text: 'Favorite',
          icon: 'heart',
          handler: () => {
            console.log('Favorite clicked');
          }
        },
        {
          text: 'Cancel',
          icon: 'close',
          role: 'cancel',
          handler: () => {
            console.log('Cancel clicked');
          }
        }]
    });


    await actionSheet.present();
  }



  ngOnInit() {
  }

}
