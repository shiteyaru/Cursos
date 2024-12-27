import { Component, OnInit } from '@angular/core';
import { AlertController } from '@ionic/angular';

@Component({
  selector: 'app-alert',
  templateUrl: './alert.page.html',
  styleUrls: ['./alert.page.scss'],
})
export class AlertPage implements OnInit {

  constructor(private alertCtrl: AlertController) { }

  async alert() {
    let alert = await this.alertCtrl.create({
      cssClass: 'alerta',
      header: 'Alerta',
      subHeader: 'Subtítulo',
      message: 'Você clicou no Alert!',
      buttons: ['OK']
    });

    await alert.present();
  }




  async multiplos() {
    let alert = await this.alertCtrl.create({
      header: 'Alerta',
      subHeader: 'Subtítulo',
      message: 'Você clicou no Alert!',
      buttons: ['Cancelar', 'Salvar', 'Deletar']
    });

    await alert.present();
  }



  async confirmar() {
    let alert = await this.alertCtrl.create({
      header: 'Atenção',
      message: 'Tem certeza que deseja excuir o usuário?',
      buttons: [
        {
          text: 'Cancelar',
          role: 'cancel',
          handler: (blah) => {
            console.log('Cancelado');
          }
        }, {
          text: 'Confirmo',
          handler: () => {
            console.log('Confirmado');
          }
        }
      ]
    });

    await alert.present();
  }



  async prompt() {
    let alert = await this.alertCtrl.create({
      header: 'Acesso Restrito!',
      inputs: [
        {
          name: 'email',
          type: 'text',
          placeholder: 'Informe seu E-Mail'
        },
        {
          name: 'senha',
          type: 'password',
          placeholder: 'Digite sua senha'
        }
      ],

      buttons: [
        {
          text: 'Cancel',
          role: 'cancel',
          handler: () => {
            console.log('Cancelado');
          }},
        {
          text: 'OK',
          handler: (form) => {
            console.log(form);
          }
        }
      ]
    });

    await alert.present();
  }


  ngOnInit() {
  }

}
