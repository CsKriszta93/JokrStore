/* Auto Generated */

import { UserDtoLite } from "./UserDtos/userDtoLite";
import { CPUDto } from "./cPUDto";
import { GPUDto } from "./gPUDto";
import { OSDto } from "./oSDto";

export interface ConfigDTO {
    id: any;
    userId: any;
    user: UserDtoLite;
    cPUId: any;
    cpu: CPUDto;
    ram: number;
    gPUId: any;
    gpu: GPUDto;
    gPUSize: number;
    oSId: any;
    os: OSDto;
    others: string;
}
