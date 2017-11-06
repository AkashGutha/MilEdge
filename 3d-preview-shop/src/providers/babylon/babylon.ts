import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import "rxjs/add/operator/map";
import BABYLON from "babylonjs";

@Injectable()
export class BabylonProvider {
  constructor(public http: Http) {
    console.log("Hello BabylonProvider Provider");
  }
}
