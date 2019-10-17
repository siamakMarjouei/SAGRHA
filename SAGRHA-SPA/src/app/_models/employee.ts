import { Children } from './children';
import { Photo } from './photo';

export interface Employee {
  id: number;
  name: string;
  lastName: string;
  gender: string;
  age: number;
  dni: string;
  phone: string;
  email: string;
  profession: string;
  address: string;
  cuaNumber?: string;
  afp?: string;
  dateOfBirth?: Date;
  children?: Children[];
  photo?: Photo;
}
