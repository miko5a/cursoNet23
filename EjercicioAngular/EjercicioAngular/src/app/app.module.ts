import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule,ReactiveFormsModule  } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { RegistroUsuario } from './usuarioRegistro/usuarioRegistro.component';
import { BarraNav } from './navBar/navbar.component';
import { UsuarioLista } from './usuarios/usuario.component';
import { InicioComponent } from './inicio/inicio.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule, ToastContainerDirective } from 'ngx-toastr';



const appRoutes: Routes = [
  { path: 'usuarios', component: UsuarioLista },
  { path: 'usuarioRegistro', component: RegistroUsuario },
  { path: 'inicio', component: InicioComponent },
  { path: '', redirectTo: 'inicio', pathMatch: 'full' },
  { path: '**', redirectTo: 'inicio', pathMatch: 'full' }

];

@NgModule({
  declarations: [
    BarraNav,
    AppComponent,
    RegistroUsuario,
    UsuarioLista,
    InicioComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes),
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({ 
      positionClass: 'inline',
      timeOut: 2000, }),
    ToastContainerDirective,  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
