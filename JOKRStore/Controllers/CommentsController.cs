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
            var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
            if (!ModelState.IsValid)
            {
                return View(contain);
            }

            var newComment = new CommentViewModel
            {
                UserId = Guid.Parse(UserId),
                Contain = contain,
                CommentDate = DateTime.Now,
                GameId = Guid.Parse(gameId)
            };

            System.Diagnostics.Debug.WriteLine("Game Id: " + newComment.GameId.ToString());

            await commentService.AddComment(mapper.Map<CommentDto>(newComment));

            return RedirectToAction("Games", "Details", gameId);
            //return RedirectToAction("Detalils");
        }
    }
}
