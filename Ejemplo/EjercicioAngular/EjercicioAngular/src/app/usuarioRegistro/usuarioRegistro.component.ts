import { Component, OnInit,ViewChild  } from '@angular/core';
import { Subscription } from 'rxjs';
import { RegistroService } from './usuarioRegistro.service';
import { IUsuarioRegistro } from './usuarioRegistro';
import { IRespuesta } from './respuesta';
import { Validators, FormBuilder, FormGroup} from '@angular/forms';
import { Router } from '@angular/router';
import { IUsuario } from "../usuarios/usuario";
import { UsuarioService } from '../usuarios/usuario.service';
import { ToastContainerDirective, ToastrService } from 'ngx-toastr';

@Component({
  selector: 'pm-registro',
  templateUrl: './usuarioRegistro.component.html',
})

export class RegistroUsuario implements OnInit{
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
  @ViewChild(ToastContainerDirective, { static: true })
  toastContainer: ToastContainerDirective | undefined;

  constructor(private registroService: RegistroService, 
    public formulario: FormBuilder, 
    public router: Router,
    private usuariosLista: UsuarioService,
    private toastrService: ToastrService) 
    {
    this.myForm = this.formulario.group({
      nombre: ['', [Validators.required,Validators.maxLength(50)]],
      telefono: ['', [Validators.required,Validators.maxLength(25)]],
      fechaNacimiento: ['', [Validators.required,Validators.max(new Date(new Date().getFullYear() - 16).getTime())]],     
    });
  }
  ngOnInit(): void {
    this.toastrService.overlayContainer = this.toastContainer;
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
      this.cargarLista(true)
      this.toastrService.success(mensaje);
    },
    error: err  => {
      this.errorMessage = err.error;
      var mensaje = this.errorMessage?.message
      this.toastrService.error(mensaje);
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