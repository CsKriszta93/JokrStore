using JOKRStore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using BLL.ServiceInterfaces;
using JOKRStore.Web.ViewModels;
using AutoMapper;

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
    }
}