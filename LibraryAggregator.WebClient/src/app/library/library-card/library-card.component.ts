import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
    selector: 'app-library-card',
    templateUrl: './library-card.component.html',
    styleUrls: ['./library-card.component.css']
})

export class LibraryCardComponent {
    @Input()
    library!: any;
}