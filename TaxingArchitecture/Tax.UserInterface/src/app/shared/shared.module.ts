import { NgModule, LOCALE_ID } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { ServicesModule } from './services/services.module';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    ServicesModule
  ],
  declarations: [],
  providers: [
    {
      provide: LOCALE_ID,
      useValue: navigator.language
    }
  ]
})
export class SharedModule { }
