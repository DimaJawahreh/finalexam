import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
@Injectable()
export class rommservice{
    constructor( private httpclient:HttpClient){}
    LoadRoom():Observable<any>{
     return   this.httpclient.get("http://localhost/FinalExam/api/Room/rooms");
    }
}