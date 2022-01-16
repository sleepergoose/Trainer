import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from 'src/app/guards/auth.guard';
import { RoleGuard } from 'src/app/guards/role.guard';
import { AddWordsComponent } from './components/add-words/add-words.component';
import { ContainerComponent } from './components/container/container.component';
import { EditWordComponent } from './components/edit-word/edit-word.component';

const routes: Routes = [
  {
    path: '',
    component: ContainerComponent,
    children: [
      {
        path: 'addwords',
        component: AddWordsComponent
      },
      {
        path: 'editword',
        component: EditWordComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
  providers: [AuthGuard, RoleGuard]
})
export class TrainerAdminRoutingModule { }