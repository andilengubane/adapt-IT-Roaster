import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DefaultComponent } from './default.component';
import { DashboardComponent } from 'src/app/modules/dashboard/dashboard.component';

import { RouterModule } from '@angular/router';
import { SharedModule } from 'src/app/shared/shared.module';
import { MatSidenavModule} from '@angular/material/sidenav';
import { FormsModule,ReactiveFormsModule }   from '@angular/forms';
import { UserComponent } from 'src/app/modules/user/user.component';

@NgModule({
  declarations: [
    DefaultComponent,
    DashboardComponent,
    UserComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    SharedModule,
    MatSidenavModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class DefaultModule { }
