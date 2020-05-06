/* Auto Generated */

import { UserDto } from "./UserDtos/userDto";
import { CPUDto } from "./cPUDto";
import { GPUDto } from "./gPUDto";
import { OSDto } from "./oSDto";

export interface ConfigDTO {
    id: any;
    userId: any;
    user: UserDto;
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
