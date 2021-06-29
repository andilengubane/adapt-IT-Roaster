import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Customer } from './customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http: HttpClient ) { }
  
  readonly baseUrl = 'http://localhost:50373/api/Customer';
  formdata: Customer = new Customer();

}
