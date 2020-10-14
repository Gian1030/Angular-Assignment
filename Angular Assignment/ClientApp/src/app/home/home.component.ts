import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  MenuItems: MenuItem[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<MenuItem[]>(baseUrl + 'api/MenuItems').subscribe(result => {
      this.MenuItems = result;
    }, error => console.error(error));
  }
}

interface MenuItem {
  Id: number;
  Name: string;
  Price: number;
}
