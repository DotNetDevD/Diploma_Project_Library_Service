import { Component } from '@angular/core';

@Component({
    selector: 'app-test',
    templateUrl: './test.component.html',
    styleUrls: ['./test.component.css']
})
export class TestComponent {
    data = [
        { img: "https://therichpost.com/wp-content/uploads/2021/05/bootstrap5-carousel-slider-img1.jpg", title: "Slide 1" },
        { img: "https://therichpost.com/wp-content/uploads/2021/05/bootstrap5-carousel-slider-img2.jpg", title: "Slide 2" },
        { img: "https://therichpost.com/wp-content/uploads/2021/05/bootstrap5-carousel-slider-img3.jpg", title: "Slide 3" }
    ];
}
