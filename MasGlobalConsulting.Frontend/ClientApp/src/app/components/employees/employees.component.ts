import { animate, state, style, transition, trigger } from '@angular/animations';
import { Employee } from '../../models/employee';
import { EmployeesService } from '../../services/emplyeesService';
import { FormControl } from '@angular/forms';
import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({ height: '0px', minHeight: '0' })),
      state('expanded', style({ height: '*' })),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})

/** Employees component*/
export class EmployeesComponent {

  dataSource: any;
  columnsToDisplay = ['id', 'name', 'anualSalary'];
  filterId: string;

  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;


  /** Employees ctor */
  constructor(private employeesService: EmployeesService) {
    this.GetEmployees();
  }

  GetEmployees() {

    this.employeesService.getAll().pipe()
      .subscribe((data: Employee[]) => {

        this.dataSource = new MatTableDataSource(data);;

        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
      });
  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  search(): void {
    this.dataSource.filter = this.filterId;
    this.employeesService.getEmployeesFiltered(this.filterId).subscribe(response => {
      this.dataSource = response;
    });
  }
}
