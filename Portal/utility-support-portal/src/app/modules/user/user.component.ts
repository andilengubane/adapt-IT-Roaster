import { Component, OnInit } from '@angular/core';
import { CustomerService } from '../customer.service';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {
  checkoutForm = this.formBuilder.group({
    Firstname: '',
    Surname: ''
  });

  constructor(public service : CustomerService, private formBuilder:FormBuilder) { }
  
  ngOnInit(): void {
  
  }

}
