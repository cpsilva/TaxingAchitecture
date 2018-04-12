import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from "@angular/forms";
import { ApplicationService } from '../../shared/services/application.service';
import { ValidationService } from '../../shared/services/validation.service';
import { employeeViewModel } from '../../view-model/EmployeeViewModel';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  model: employeeViewModel = new employeeViewModel();

  @ViewChild('formulario') formulario;

  constructor(
    private applicationService: ApplicationService,
    private validationService: ValidationService
  ) { }

  ngOnInit() {
  }

  public consultar() {
    if (!this.validationService.form('formulario')) { return; }

    this.applicationService.get<employeeViewModel>("Employee", this.model).subscribe(result => {
    });
  }
}
