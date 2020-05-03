/* Auto Generated */

import { UserDto } from "./UserDtos/userDto";
import { ForumCategoryDto } from "./forumCategoryDto";

export interface ForumTopicDto {
    id: any;
    title: string;
    content: string;
    date: Date;
    userId: any;
    user: UserDto;
    forumCategoryId: any;
    forumCategory: ForumCategoryDto;
    comments: any[];
}
