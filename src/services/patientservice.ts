import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { InjectSetupWrapper } from "@angular/core/testing";
import { patient } from "src/data/patient";
@Injectable()
export class patientservice{
    constructor(private httpclient:HttpClient){
    }
    insert(pat:patient){
        this.httpclient.post("",pat).subscribe();
    }
}