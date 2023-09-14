import { IUsuarioRegistro } from './usuarioRegistro';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegistroService {
  registroUrl: string;
  private http: HttpClient;

  constructor(httpClient: HttpClient) {
    this.registroUrl = 'https://localhost:7092/api/usuarios/registro';
    this.http = httpClient;
  }

  postRealizarRegistro(registro: IUsuarioRegistro): Observable<any> {
    return this.http.post(this.registroUrl, registro);
  }
}
