import { Component } from '@angular/core';
import { Subscription } from 'rxjs';
import { RegistroService } from './usuarioRegistro.service';
import { IUsuarioRegistro } from './usuarioRegistro';
import { IRespuesta } from './respuesta';
import { Validators, FormBuilder, FormGroup} from '@angular/forms';
import { Router } from '@angular/router';
import { IUsuario } from "../usuarios/usuario";
import { UsuarioService } from '../usuarios/usuario.service';

@Component({
  selector: 'pm-registro',
  templateUrl: './usuarioRegistro.component.html',
})

export class RegistroUsuario {
  errorMessage: IRespuesta | undefined; 
  sub!: Subscription;
  resultRegistro: IRespuesta | undefined; 
  resFormateadoBien:string | undefined;
  resFormateadoMal:string | undefined;
  nombre: string="";
  telefono: string ="";
  fechaNacimiento: string ="";
  usuarios: IUsuario[] = [];
  myForm: FormGroup;

  constructor(private registroService: RegistroService, public formulario: FormBuilder, public router: Router,private usuariosLista: UsuarioService) {
    this.myForm = this.formulario.group({
      nombre: ['', [Validators.required,Validators.maxLength(50)]],
      telefono: ['', [Validators.required,Validators.maxLength(25)]],
      fechaNacimiento: ['', [Validators.required,Validators.max(new Date(new Date().getFullYear() - 16).getTime())]],     
    });
  }

  registro(myForm : FormGroup): void {
    const registroDTO: IUsuarioRegistro = {
      nombre: myForm.value.nombre,
      telefono: myForm.value.telefono,
      fechaNacimiento: myForm.value.fechaNacimiento,
    };
    this.postRegistro(registroDTO);
  }

  postRegistro(registroDTO: IUsuarioRegistro): void {
  this.registroService.postRealizarRegistro(registroDTO).subscribe({
    next:(registro) => {
      this.resultRegistro = registro;
      var estado = this.resultRegistro?.status
      var mensaje = this.resultRegistro?.message
      this.resFormateadoBien = mensaje;
      this.resFormateadoMal = undefined;
      this.cargarLista(true)
    },
    error: err  => {
      this.errorMessage = err.error;
      var mensaje = this.errorMessage?.message
      this.resFormateadoMal = mensaje;
    }
  });  
 }

  cargarLista(cambio : boolean): void {
    this.sub = this.usuariosLista.getUsuarios().subscribe({
      next: usuarios => {
        this.usuarios = usuarios;
      },
    });
} 
}