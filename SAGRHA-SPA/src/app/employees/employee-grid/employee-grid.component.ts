import { Component, OnInit, Input } from '@angular/core';
import { Employee } from 'src/app/_models/employee';


@Component({
  selector: 'app-employee-grid',
  templateUrl: './employee-grid.component.html',
  styleUrls: ['./employee-grid.component.css']
})
export class EmployeeGridComponent implements OnInit {
  @Input() employees: Employee[];

  constructor() { }

  ngOnInit() {
  }

}
