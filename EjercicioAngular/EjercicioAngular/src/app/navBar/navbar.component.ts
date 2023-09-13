import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'pm-nav',
  templateUrl: './navbar.component.html',
styleUrls: ['./navbar.component.css']
})

export class BarraNav{
  pageTitle: string = 'Angular';


  constructor(private router : Router) {}

  isCollapse = false;   // guardamos el valor
  toggleState() { // manejador del evento
      let foo = this.isCollapse;
      this.isCollapse = foo === false ? true : false; 
  }
}