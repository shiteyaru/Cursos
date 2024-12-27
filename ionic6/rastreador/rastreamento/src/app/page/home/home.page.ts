import { Component } from '@angular/core';
import { CorreioService } from 'src/app/services/correio.service';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  constructor(private correioService : CorreioService) {}

  localizarObjeto(evento: any){
    let codigoObjeto = evento.detail.value;

    this.correioService.localizarObjeto(codigoObjeto)
    .then(response=>{
      console.log(response);
    })
    .catch(erro=>{
      console.log(erro);
    })
  }

}
