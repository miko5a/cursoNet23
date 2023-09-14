import { Component, EventEmitter, Input, OnChanges, Output } from '@angular/core';
import { Subscription } from 'rxjs';
import { IUsuario } from "./usuario";
import { UsuarioService } from './usuario.service';

@Component({
    selector: 'pm-usuarios',
    templateUrl: './usuario.component.html'
})

export class UsuarioLista implements OnChanges{
    errorMessage: string = '';
    sub!: Subscription;
    
    constructor(private usuariosLista: UsuarioService) {}

    @Input() usuarios: IUsuario[]=[];
    @Output() cambio: EventEmitter<boolean> =
    new EventEmitter<boolean>();

    onClick(): void {
      this.cambio.emit(false);
    }
    ngOnChanges(): void {
      this.actualizar();
    }

    actualizar() {  
      this.sub = this.usuariosLista.getUsuarios().subscribe({
        next: usuarios => {
          this.usuarios = usuarios;
        },
      });
     }
}