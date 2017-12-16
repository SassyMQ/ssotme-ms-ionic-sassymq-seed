import { NgModule, ErrorHandler } from '@angular/core';
import { IonicApp, IonicModule, IonicErrorHandler } from 'ionic-angular';
import { MyApp } from './app.component';
import { components } from './app.modules-base';
import { RestAPIService } from '../providers/rest-api-service';

components.push(MyApp);

@NgModule({
  declarations: components,
  imports: [
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: components,
  providers: [{ provide: ErrorHandler, useClass: IonicErrorHandler }, RestAPIService]
})
export class AppModule {}
