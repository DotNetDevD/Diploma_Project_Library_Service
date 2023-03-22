
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgToastService } from 'ng-angular-popup';
import ValidateForm from 'src/app/helpers/validateForm';
import { AdminJwtService } from 'src/app/service/admin-jwt.service';
import { AuthAdminService } from 'src/app/service/auth-admin.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {

    type: string = "password";
    isText: boolean = false;
    eyeIcon: string = "fa-eye-slash";
    loginForm!: FormGroup;
    data!: any;

    constructor(private Fb: FormBuilder, 
                private auth: AuthAdminService , 
                private router:Router,
                private NgToast:NgToastService,
                private adminJwt: AdminJwtService) { }

    ngOnInit(): void {
        this.loginForm = this.Fb.group({
            adminName: ['', Validators.required],
            password: ['', Validators.required]
        })
    }

    hidePassword() {
        this.isText = !this.isText;
        this.isText ? this.eyeIcon = "fa-eye" : this.eyeIcon = "fa-eye-slash";
        this.isText ? this.type = "text" : this.type = "password";
    }

    onLogin() {
        if (this.loginForm.valid) {
            this.auth.login(this.loginForm.value)
                .subscribe({
                    next: (data) => {
                        if(data.message == "Admin"){
                            this.loginForm.reset();
                            this.auth.storeToken(data.token)
                            const tokenPayload = this.auth.decodedToken();
                            this.adminJwt.setName(tokenPayload.unique_name)
                            this.NgToast.success({ detail: "SUCCESS", summary: "Authorization Success", duration: 5000 })
                            this.router.navigate(['dashboard'])
                        }
                        else{
                            this.NgToast.error({ detail: "Error", summary: "Something when wrong", duration: 5000 })
                        }
                            
                    },
                    error: (err) => {
                        this.NgToast.error({ detail: "Error", summary: "Something when wrong", duration: 5000 })
                    }
                })
        }
        else {
            ValidateForm.validateAllFields(this.loginForm);
            alert("this form is not valid")
        }
    }
}
