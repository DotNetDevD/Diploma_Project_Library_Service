import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import ValidateForm from 'src/app/helpers/validateForm';
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

    constructor(private Fb: FormBuilder, private auth: AuthAdminService) { }

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
            console.log(this.loginForm.value);
            this.auth.login(this.loginForm.value)
                .subscribe({
                    next: (data) => {
                        console.log(data)
                    },
                    error: (err) => {
                        alert(err.error.message);
                    }
                })
        }
        else {
            ValidateForm.validateAllFields(this.loginForm);
            alert("this form is not valid")
        }
    }
}
