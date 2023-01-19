import { Genre } from "./Genre.model";

export interface Book {
id: number;
title: string;
isbn: string;
coverImgPath: string;
publishDate: string;
description: string;
pageCount: number;
Genres:Genre[];
}
