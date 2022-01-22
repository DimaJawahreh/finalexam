import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

 @Injectable()
 export class bedservice{
    constructor(private httpclient:HttpClient){}
    LoadBed():Observable<any>{
 return this.httpclient.get("http://localhost/FinalExam/api/Bed/GetBeds");
 
    }
}