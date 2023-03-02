import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, UntypedFormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/modules/shared/service/auth.service';

@Component({
    selector: 'app-login-form',
    templateUrl: './login-form.component.html',
    styleUrls: ['./login-form.component.scss'],
})
export class LoginFormComponent implements OnInit {
    form!: FormGroup;

    constructor(private readonly fb: UntypedFormBuilder,
        private readonly authService: AuthService,
        private readonly router: Router) {
    }

    ngOnInit(): void {
        this.form = this.fb.group({
            email: new FormControl('string', [Validators.required]),
            password: new FormControl('string', [Validators.required]),
        })
    }

    onLoginClick() {
        if (!this.form.valid) {
            alert('smt went wrong...');
            return;
        }

        console.log(this.form.getRawValue());
        this.authService.login(this.form.getRawValue())
            .subscribe(x => {
                if (this.authService.isAuthenticated) {
                    this.router.navigate(['book']);
                    return;
                } 

                alert('smt went wrong')
            })
    }
}
