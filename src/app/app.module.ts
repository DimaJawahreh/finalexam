import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { NewpatientComponent } from './newpatient/newpatient.component';
import { DepartmentsComponent } from './departments/departments.component';
import { PatientComponent } from './patient/patient.component';
import { RouterModule, Routes } from '@angular/router';
import{HttpClientModule}from '@angular/common/http'
import { countryservice } from 'src/services/countryservice';
import{FormsModule}from '@angular/forms'
import { cityservice } from 'src/services/cityservice';
import { bedservice } from 'src/services/bedservice';
import { departmentservicee } from 'src/services/deprtmentservice';
import { rommservice } from 'src/services/roomservice';
import { doctorservice } from 'src/services/doctorservice';
const AppRout:Routes=[
  {path:"newpatient",component:NewpatientComponent},
  {path:"department",component:DepartmentsComponent}
];
@NgModule({
  declarations: [
    AppComponent,
    NewpatientComponent,
    DepartmentsComponent,
    PatientComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(AppRout),
    HttpClientModule,FormsModule
  ],
  providers: [countryservice,cityservice,bedservice,departmentservicee,
    rommservice,doctorservice],
  bootstrap: [AppComponent]
})
export class AppModule { }
