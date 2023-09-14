import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IPersonaForCreation } from '../interfaces/ipersona-for-creation';
import { Observable } from 'rxjs';
import { IPersonaGet } from '../interfaces/ipersona-get';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {
  myAppUrl: string;
  myApiUrl: string;

  constructor(private http: HttpClient) { 
    this.myAppUrl = 'https://localhost:7170/';
    this.myApiUrl = 'api/Persona';
  }

  crearPersona(personaDTO: IPersonaForCreation): Observable<any> {
    return this.http.post<any>(this.myAppUrl + this.myApiUrl, personaDTO);
  }

  getPersonas(): Observable<IPersonaGet[]> {
    return this.http.get<IPersonaGet[]>(this.myAppUrl + this.myApiUrl);
  }
}