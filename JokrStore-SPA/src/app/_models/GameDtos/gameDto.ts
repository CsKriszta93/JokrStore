/* Auto Generated */

import { UserDtoLite } from "./../UserDtos/userDtoLite";
import { SysReqDto } from "./../sysReqDto";
import { CommentDto } from "./../commentDto";
import { MediaDto } from "./../mediaDto";
import { GamePropertyDto } from "./../gamePropertyDto";
import { DescriptionDto } from "./../descriptionDto";

export interface GameDto {
    id: any;
    gameName: string;
    userId: any;
    user: UserDtoLite;
    coverArt: string;
    rate: number;
    price: number;
    release: string;
    downloadLink: string;
    demoLink: string;
    numOfDownloads: number;
    publish: string;
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
    descriptions: DescriptionDto[];
}
