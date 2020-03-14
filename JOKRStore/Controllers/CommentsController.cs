using AutoMapper;
using BLL.DTO;
using BLL.ServiceInterfaces;
using JOKRStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JOKRStore.Web.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentService commentService;
        private readonly IMapper mapper;

        public CommentsController(ICommentService commentService, IMapper mapper)
        {
            this.commentService = commentService;
            this.mapper = mapper;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostComment(string contain, string gameId)
        { 
            var commenterId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;

            if (!ModelState.IsValid)
            {
                return View(contain);
            }

            var newComment = new CommentViewModel
            {
                CommenterId = Guid.Parse(commenterId),
                Contain = contain,
                CommentDate = DateTime.Now,
                GameId = Guid.Parse(gameId)
            };

            await commentService.AddComment(mapper.Map<CommentDto>(newComment));

            return Ok();
            //return RedirectToAction("Detalils");
        }
    }
}
