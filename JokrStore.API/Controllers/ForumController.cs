using System;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BLL.ServiceInterfaces;

namespace JOKRStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ForumController : Controller
    {
        private readonly IForumService forumService;
        public ForumController(IForumService forumService)
        {
            this.forumService = forumService;
        }

        [HttpGet("Categories")]
        public async Task<IActionResult> ForumCategoryList()
        {
            return Ok(await forumService.GetForumCategories());
        }

        [HttpGet("Topics")]
        public async Task<ActionResult> ForumTopicList(Guid Id)
        {
            return Ok(await forumService.GetForumCategoryByIdAsync(Id));
        }

        [HttpGet("Topics/{id}")]
        public async Task<ActionResult> ForumTopicContent(Guid Id)
        {
            return View(await forumService.GetForumTopicByIdAsync(Id));
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