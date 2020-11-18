import { Role } from "./Role";
import { Contract } from "./Contract";

export class Employee {
  id: number;
  name: string;
  anualSalary: number;
  role: Role;
  contract: Contract;

  constructor(id: number, name: string, anualSalary: number, role: Role, contract: Contract) {
    this.id = id;
    this.name = name;
    this.anualSalary = anualSalary;
    this.role = role;
    this.contract = contract;
  }
}
