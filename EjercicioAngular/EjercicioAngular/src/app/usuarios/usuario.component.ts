import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { IUsuario } from "./usuario";
import { UsuarioService } from './usuario.service';

@Component({
    selector: 'pm-usuarios',
    templateUrl: './usuario.component.html'
})

export class UsuarioLista implements OnInit, OnDestroy{
    usuarios: IUsuario[] = [];
    errorMessage: string = '';
    sub!: Subscription;

    constructor(private usuariosLista: UsuarioService) {}

    ngOnInit(): void {
        this.sub = this.usuariosLista.getUsuarios().subscribe({
          next: usuarios => {
            this.usuarios = usuarios;
          },
        });
    }

    ngOnDestroy(): void {
        this.sub.unsubscribe();
    }
}