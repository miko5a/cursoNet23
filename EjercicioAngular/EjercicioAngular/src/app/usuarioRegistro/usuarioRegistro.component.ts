import { Component } from '@angular/core';
import { Subscription } from 'rxjs';
import { RegistroService } from './usuarioRegistro.service';
import { IUsuarioRegistro } from './usuarioRegistro';
import { IRespuesta } from './respuesta';
import { Validators, FormBuilder, FormGroup} from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'pm-registro',
  templateUrl: './usuarioRegistro.component.html',
})

export class RegistroUsuario {
  errorMessage: IRespuesta | undefined; 
  sub!: Subscription;
  resultRegistro: IRespuesta | undefined; 
  resultado:string="";
  resFormateadoBien:string | undefined;
  resFormateadoMal:string | undefined;

  //Para Rellenar
  nombre: string="";
  telefono: string ="";
  fechaNacimiento: string ="";

  myForm: FormGroup;


  constructor(private registroService: RegistroService, public formulario: FormBuilder, public router: Router) {
    this.myForm = this.formulario.group({
      nombre: ['', [Validators.required,Validators.maxLength(50)]],
      telefono: ['', [Validators.required,Validators.maxLength(25)]],
      fechaNacimiento: ['', [Validators.required,Validators.max(new Date(new Date().getFullYear() - 16).getTime())]],     
    });
  }

  //Rellena con los datos del html un registro DTO
  registro(myForm : FormGroup): void {
    const registroDTO: IUsuarioRegistro = {
      nombre: myForm.value.nombre,
      telefono: myForm.value.telefono,
      fechaNacimiento: myForm.value.fechaNacimiento,
    };
    this.postRegistro(registroDTO);
    //this.router.navigate(['/inicio'])
  }

  //Realiza el POST enviando el registro rellenado
  postRegistro(registroDTO: IUsuarioRegistro): void {
  this.registroService.postRealizarRegistro(registroDTO).subscribe({
    next:(registro) => {
      this.resultRegistro = registro;
      var estado = this.resultRegistro?.status
      var mensaje = this.resultRegistro?.message
      this.resFormateadoBien = mensaje;
      this.resFormateadoMal = undefined;
    },
    error: err  => {
      this.errorMessage = err.error;
      var mensaje = this.errorMessage?.message
      this.resFormateadoMal = mensaje;
    }
  });
}
}