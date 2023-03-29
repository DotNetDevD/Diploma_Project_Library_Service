import { Library } from "./library";

export interface OperatingModes {
    operatingModesId: number;
    monday?: string;
    tuesday?: string;
    wednesday?: string;
    thursday?: string;
    friday?: string;
    saturday?: string;
    sunday?: string;
    libraryId: number;
    library: Library;
} 