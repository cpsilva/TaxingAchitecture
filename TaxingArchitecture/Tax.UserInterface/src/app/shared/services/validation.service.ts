import { Injectable } from '@angular/core';

@Injectable()
export class ValidationService {
  constructor() { }

  form(id) {
    if (!id || !document.forms || !document.forms[id] || !document.forms[id].reportValidity) { return true; }
    var form = document.forms[id];
    return form.reportValidity();
  }
}
