import { BrowserModule } from '@angular/platform-browser';
import { NgModule, LOCALE_ID } from '@angular/core';
import { RouterModule } from '@angular/router';
import { LocationStrategy, HashLocationStrategy } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { LayoutModule } from './layout/layout.module';
import { registerLocaleData } from '@angular/common';
import localePTBR from '@angular/common/locales/pt';

registerLocaleData(localePTBR);

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    FormsModule,
    LayoutModule
  ],
  bootstrap: [AppComponent],
  providers: [
    { provide: LOCALE_ID, useValue: "pt-BR" },
    { provide: LocationStrategy, useClass: HashLocationStrategy }
  ]
})
export class AppModule { }
