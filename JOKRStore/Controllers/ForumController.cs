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

        [HttpGet]
        public async Task<ActionResult> ForumTopicList(Guid Id)
        {
            System.Diagnostics.Debug.WriteLine("ForumCategoryList category's id: " + Id.ToString());
            var category = await forumService.GetForumCategoryByIdAsync(Id);
            return View(mapper.Map<ForumCategoryViewModel>(category));
        }

        public async Task<ActionResult> ForumTopicContent(Guid Id)
        {
            var topic = await forumService.GetForumTopicByIdAsync(Id);
            return View(mapper.Map<ForumTopicViewModel>(topic));
        }

        public async Task<ActionResult> NewTopicForm(Guid Id)
        {
            return View("NewForum", Id);
        }

        [HttpPost]
        public async Task<ActionResult> NewTopic(string categoryId, string title, string content)
        {
            var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
            await forumService.AddNewTopicAsync(Guid.Parse(UserId), Guid.Parse(categoryId), title, content);

            return RedirectToAction("ForumTopicList", "Forum", new {Id = categoryId });
            //return Content(CategoryId);
        }
    }
}