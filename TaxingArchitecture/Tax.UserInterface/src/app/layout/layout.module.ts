import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { SharedModule } from '../shared/shared.module';
import { ViewModule } from '../view/view.module';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from '../route/app-routing.module';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    ViewModule,
    FormsModule,
    AppRoutingModule
  ],
  declarations: [
    HeaderComponent,
    FooterComponent
  ],
  exports: [
    HeaderComponent,
    FooterComponent
  ]
})
export class LayoutModule { }
