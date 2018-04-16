import { NgModule, LOCALE_ID } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { SharedModule } from '../shared/shared.module';
import { IndexComponent } from './index/index.component';
import { HomeComponent } from './home/home.component';
import { CurrencyMaskModule } from "ng2-currency-mask";

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule,
    SharedModule,
    CurrencyMaskModule
  ],
  declarations: [
    IndexComponent,
    HomeComponent,
  ],
})
export class ViewModule { }
