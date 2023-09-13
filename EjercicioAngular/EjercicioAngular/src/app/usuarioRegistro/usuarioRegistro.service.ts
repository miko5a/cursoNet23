import { IUsuarioRegistro } from './usuarioRegistro';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, throwError } from 'rxjs';

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

  //Realiza el POST de registro
  postRealizarRegistro(registro: IUsuarioRegistro): Observable<any> {
    return this.http.post(this.registroUrl, registro).pipe(
        //tap(data => console.log('All: ', JSON.stringify(data))),
        //catchError(this.handleError)
      );
  }

  private handleError(err: HttpErrorResponse): Observable<never> {
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `Un error ha ocurrido: ${err.error.message}`;
    } else {
      errorMessage = `Servidor devuelve: ${err.status}, mensaje de error en: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(errorMessage);
  }
}
