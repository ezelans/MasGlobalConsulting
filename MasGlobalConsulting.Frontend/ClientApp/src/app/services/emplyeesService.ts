import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { Employee } from '../models/employee';
import { TrackerError } from '../models/TrackerError';
import { environment } from '../../environments/environment';

@Injectable({ providedIn: 'root' })
export class EmployeesService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Employee[] | TrackerError> {
    return this.http.get<Employee[]>(`${environment.apiUrl}/employees`)
            .pipe(
              map(employees => {
                return employees.map((employee: Employee) => new Employee(employee.id, employee.name, employee.anualSalary, employee.role, employee.contract));
                }),
                catchError(err => this.handleHttpError(err))
            );
  }

  getEmployeesFiltered(id: string): Observable<Employee[] | TrackerError> {

    const filter = id ? `?Id =` : '';

    return this.http.get<Employee[]>(`${environment.apiUrl}/employees` + filter)
      .pipe(
        map(employees => {
          return employees.map((employee: Employee) => new Employee(employee.id, employee.name, employee.anualSalary, employee.role, employee.contract));
        }),
        catchError(err => this.handleHttpError(err))
      );
  }

    private handleHttpError(error: HttpErrorResponse): Observable<TrackerError> {
      let dataError = new TrackerError();
        return throwError(dataError);
    }
}
