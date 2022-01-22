import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable()
export class departmentservicee{
    constructor( private httpclient:HttpClient){}
    


    LoadDeprtment():Observable<any>{
      return  this.httpclient.get("http://localhost/FinalExam/api/Department/departments");

    }
}