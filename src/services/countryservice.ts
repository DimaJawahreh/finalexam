import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable()
export class countryservice{
    constructor(private httpclient:HttpClient){

    }
    LoadCountry():Observable<any>{
debugger;
  return  this.httpclient.get("http://localhost/FinalExam/api/Country/countries");
    }
}
