/* Auto Generated */

import { UserDtoLite } from "./UserDtos/userDtoLite";
import { ForumCategoryDto } from "./forumCategoryDto";

export interface ForumTopicDto {
    id: any;
    title: string;
    content: string;
    date: Date;
    userId: any;
    user: UserDtoLite;
    forumCategoryId: any;
    forumCategory: ForumCategoryDto;
    comments: any[];
}
