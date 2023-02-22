import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Library } from 'src/app/models/library';

@Component({
    selector: 'app-library-card',
    templateUrl: './library-card.component.html',
    styleUrls: ['./library-card.component.css']
})

export class LibraryCardComponent {
    @Input()
    library?: Library;
}
