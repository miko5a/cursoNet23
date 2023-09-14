import { Component, OnInit } from '@angular/core';
import { PersonaService } from './services/persona.service';
import { IPersonaGet } from './interfaces/ipersona-get';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IPersonaForCreation } from './interfaces/ipersona-for-creation';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'ExamenSummerCampAngular';
  listPersonas: IPersonaGet[] = [];
  register: FormGroup;

  constructor(private personaService: PersonaService, private fb: FormBuilder) {
    this.register = this.fb.group({
      nombre: ['', Validators.required],
      fechaNacimiento: ['', Validators.required],
      telefono: ['', Validators.required]
    });
  }

  crearPersona(): void {
    console.log(this.register);

    const personaDTO: IPersonaForCreation = {
      nombre: this.register.value.nombre,
      fechaNacimiento: this.register.value.fechaNacimiento,
      telefono: this.register.value.telefono,
    };

    this.personaService.crearPersona(personaDTO).subscribe(data => {
      console.log(data.message);
      this.cargarPersonas();
    }, error => {
      console.log('error');
      this.cargarPersonas();
    })
    
  }

  ngOnInit(): void {
    this.cargarPersonas();
  }

  cargarPersonas(): void {
    this.personaService.getPersonas().subscribe(data => {
      this.listPersonas = data;
    }, error => {
      console.log(error.error.message);
    });
  }

}