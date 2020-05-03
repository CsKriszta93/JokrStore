/* Auto Generated */

import { UserDto } from "./UserDtos/userDto";
import { DescriptionDto } from "./descriptionDto";
import { SysReqDto } from "./sysReqDto";
import { CommentDto } from "./commentDto";
import { MediaDto } from "./mediaDto";
import { GamePropertyDto } from "./gamePropertyDto";

export interface GameDto {
    id: any;
    gameName: string;
    userId: any;
    user: UserDto;
    coverArt: string;
    descriptionId?: any;
    description: DescriptionDto;
    rate: number;
    price: number;
    release: Date;
    downloadLink: string;
    demoLink: string;
    numOfDownloads: number;
    publish: Date;
    state: number;
    releaseState: number;
    minSysReqId?: any;
    minSysReq: SysReqDto;
    recSysReqId?: any;
    recSysReq: SysReqDto;
    sysReqNotes: string;
    comments: CommentDto[];
    medias: MediaDto[];
    genres: GamePropertyDto[];
}
