import { Injectable } from '@angular/core'
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { IUsuario } from './usuario';
import { Observable, throwError } from "rxjs";
import { catchError, tap } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})

export class UsuarioService {
  private usuariosUrl = 'https://localhost:7092/api/usuarios';

  constructor(private http: HttpClient) { }

  getUsuarios(): Observable<IUsuario[]> {
    return this.http.get<IUsuario[]>(this.usuariosUrl).pipe(
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