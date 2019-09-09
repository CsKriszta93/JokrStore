using JOKRStore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using BLL.ServiceInterfaces;
using JOKRStore.Web.ViewModels;
using AutoMapper;
using System.Security.Claims;

namespace JOKRStore.Web.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForumService forumService;
        private readonly IMapper mapper;
        public ForumController(IForumService forumService, IMapper mapper)
        {
            this.forumService = forumService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> ForumCategoryList()
        {
            var categories = await forumService.GetForumCategories();
            return View(mapper.Map<IEnumerable<ForumCategoryViewModel>>(categories));
        }

        public async Task<ActionResult> ForumTopicList(Guid Id)
        {
            var category = await forumService.GetForumCategoryByIdAsync(Id);
            return View(mapper.Map<ForumCategoryViewModel>(category));
        }

        public async Task<ActionResult> ForumTopic(Guid Id)
        {
            var topic = await forumService.GetForumTopicByIdAsync(Id);
            return View(mapper.Map<ForumTopicViewModel>(topic));
        }

        public async Task<ActionResult> NewTopicForm(Guid Id)
        {
            ForumTopicViewModel new_model = new ForumTopicViewModel
            {
                ForumCategoryId = Id
            };

            return View("NewForum", new_model);
        }

        [HttpPost]
        public async Task<ActionResult> NewTopic(ForumTopicViewModel new_model)
        {
            var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
            await forumService.AddNewTopicAsync(Guid.Parse(UserId), new_model.ForumCategoryId, new_model.title, new_model.content);

            return RedirectToAction("ForumTopicList", new_model.ForumCategoryId);
            //return Content(CategoryId);
        }
    }
}