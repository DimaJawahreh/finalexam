import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { bed } from 'src/data/bed';
import { city } from 'src/data/city';
import { country } from 'src/data/country';
import { department } from 'src/data/department';
import { doctor } from 'src/data/doctor';
import { patient } from 'src/data/patient';
import { room } from 'src/data/room';
import { bedservice } from 'src/services/bedservice';
import { cityservice } from 'src/services/cityservice';
import { countryservice } from 'src/services/countryservice';
import { departmentservicee } from 'src/services/deprtmentservice';
import { doctorservice } from 'src/services/doctorservice';
import { rommservice } from 'src/services/roomservice';

@Component({
  selector: 'app-newpatient',
  templateUrl: './newpatient.component.html',
  styleUrls: ['./newpatient.component.css']
})
export class NewpatientComponent implements OnInit {
licounrty:country[];
licity:city[];
libed:bed[];
lidept:department[];
liroom:room[];
lidoct:doctor[];
mydate=new Date();
@ViewChild("f") formpat:NgForm
  constructor(private countryservice1:countryservice,private cityservice1:cityservice
    ,private bedservice1:bedservice,private departmentservicee1:departmentservicee,
    private rommservice1:rommservice,private doctorservice1:doctorservice ) { }

  ngOnInit() {
    debugger;
this.countryservice1.LoadCountry().subscribe(
  data=>{debugger;
    this.licounrty=data;}
);
this.cityservice1.LoadCity().subscribe(
  data=>{debugger;
    this.licity=data;}
);
this.bedservice1.LoadBed().subscribe(
  data=>{this.libed=data;}
);
this.departmentservicee1.LoadDeprtment().subscribe(
  data=>{this.lidept=data;}
);
this.rommservice1.LoadRoom().subscribe(
  data=>{this.liroom=data;}
);
this.doctorservice1.LoadDoctor().subscribe(
  data=>{this.lidoct=data;}
);


  }

  OnSave(){
var obj=new patient();
obj.bdate= "" ;
obj.country_id=this.formpat.value["ddlcnt"];
obj.city_id=this.formpat.value["ddlcity"];
obj.fname=this.formpat.value["txtfname"];
obj.lname=this.formpat.value["txtlname"];

obj.dept_id=this.formpat.value["ddldepartment"];
obj.doctor_id=this.formpat.value["ddldoct"];

obj.room_id=this.formpat.value["ddlroom"];
obj.bed_id=this.formpat.value["ddlbed"];

  }

}