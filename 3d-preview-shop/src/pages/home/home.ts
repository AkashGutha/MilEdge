import { Component } from "@angular/core";
import { NavController } from "ionic-angular";

// babylon imports
import * as BABYLON from "babylonjs";

@Component({
  selector: "page-home",
  templateUrl: "home.html"
})
export class HomePage {
  constructor(public navCtrl: NavController) {}

  ionViewDidLoad = () => {

  };

  ionViewWillEnter = () => {
    const renderCanvas = <HTMLCanvasElement>document.getElementById(
      "renderCanvas"
    );
    const engine = new BABYLON.Engine(renderCanvas);

    //render a scene
    let scene = new BABYLON.Scene(engine);
    // Change the scene background color to black.
    scene.clearColor = new BABYLON.Color4(0, 0, 0, 1);

    let camera = new BABYLON.FreeCamera(
      "camera",
      new BABYLON.Vector3(0, 2, -10),
      scene
    );

    camera.attachControl(renderCanvas, false);
    console.log(camera);
  }
}
