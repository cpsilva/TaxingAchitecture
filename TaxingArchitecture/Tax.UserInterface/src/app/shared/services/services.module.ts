import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApplicationService } from './application.service';
import { ConverterService } from './converter.service';
import { ValidationService } from './validation.service';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [],
  providers: [
    ApplicationService,
    ConverterService,
    ValidationService
  ]
})
export class ServicesModule { }
