import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

 @Injectable()
 export class cityservice{
    constructor(private httpclient:HttpClient){}

    LoadCity():Observable<any>{
 return this.httpclient.get("http://localhost/FinalExam/api/City/GetCities");
    }
}