import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
  user:any;
  check:boolean=true;
  constructor() {
    this.user={
      name:'Anju',
      job:'engineer',
      address:'AJCE,Kanjirappally',
      phone:['9846445485','9061071656']
    };
   }
   togglecheck(){
     this.check=!this.check;
   }

  ngOnInit() {
  }

}
