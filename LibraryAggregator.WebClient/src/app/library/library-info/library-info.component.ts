import { Component , Input } from '@angular/core';

@Component({
  selector: 'app-library-info',
  templateUrl: './library-info.component.html',
  styleUrls: ['./library-info.component.css']
})
export class LibraryInfoComponent {
  data = [
    { img: "http://content.onliner.by/news/2014/07/default/7fb79907ab333a5679b1fecde955f22d.jpg", title: "Slide 1" },
    { img: "https://therichpost.com/wp-content/uploads/2021/05/bootstrap5-carousel-slider-img2.jpg", title: "Slide 2" },
    { img: "https://therichpost.com/wp-content/uploads/2021/05/bootstrap5-carousel-slider-img3.jpg", title: "Slide 3" }
  ];

  @Input()
  library!: any;
}
