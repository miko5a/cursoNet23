import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'pm-nav',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})

export class BarraNav{
  pageTitle: string = 'Ejercicio';

  constructor(private router : Router) {}

  isCollapse = false;
  toggleState() {
      let foo = this.isCollapse;
      this.isCollapse = foo === false ? true : false; 
  }
}