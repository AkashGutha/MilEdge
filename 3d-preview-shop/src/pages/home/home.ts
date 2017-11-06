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
    console.log("did load");
  };

  ionViewWillEnter = () => {
    console.log("will enter");
    const renderCanvas = <HTMLCanvasElement>document.getElementById(
      "renderCanvas"
    );
    const engine = new BABYLON.Engine(renderCanvas);

    // Render a scene
    let scene = new BABYLON.Scene(engine);
    // Change the scene background color to black.
    scene.clearColor = new BABYLON.Color4(0, 0, 0, 1);
    let sun = new BABYLON.HemisphericLight(
      "Sun",
      new BABYLON.Vector3(1, 1, 1),
      scene
    );
    sun.diffuse = new BABYLON.Color3(0.5, 0.5, 1);

    let camera = new BABYLON.FreeCamera(
      "camera",
      new BABYLON.Vector3(0, 1, -10),
      scene
    );
    camera.setTarget(BABYLON.Vector3.Zero());

    // create in scene objects and meshes
    const floor = BABYLON.MeshBuilder.CreateGround(
      "floor",
      { width: 1000, height: 1000, subdivisions: 10 },
      scene
    );
    const floorMat = new BABYLON.StandardMaterial("floorMat", scene);
    floorMat.diffuseColor = new BABYLON.Color3(1, 1, 1);
    floor.material = floorMat;

    camera.attachControl(renderCanvas, false);
    console.log(camera);

    engine.runRenderLoop(() => {
      scene.render();
    });

    // the canvas/window resize event handler
    window.addEventListener("resize", () => {
      engine.resize();
    });
  };
}
