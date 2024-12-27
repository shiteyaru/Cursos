import { Component, OnInit } from '@angular/core';
import { Camera, CameraResultType } from '@capacitor/camera';

@Component({
  selector: 'app-camera',
  templateUrl: './camera.page.html',
  styleUrls: ['./camera.page.scss'],
})
export class CameraPage implements OnInit {
  foto: any;

  constructor() { }

  ngOnInit() {
  }


  tirarFoto = async () => {
    const image = await Camera.getPhoto({
      quality: 90,
      allowEditing: true,
      resultType: CameraResultType.Base64
    });

    //var imageUrl = image.webPath;
    //this.foto = imageUrl;
    let base64Image = "data:Image/jpeg/base64" + image.base64String;
    this.foto = base64Image;
  };


}
