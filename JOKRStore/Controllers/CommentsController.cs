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
        public async Task<IActionResult> PostComment(string contain, string GameId)
        {
            try
            {
                var commenterId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;

                if (!ModelState.IsValid)
                {
                    return View(contain);
                }

                var newComment = new CommentViewModel
                {
                    CommentId = Guid.NewGuid(),
                    CommenterId = Guid.Parse(commenterId),
                    Contain = contain,
                    CommentDate = DateTime.Now,
                    GameId = Guid.Parse(GameId)
                };

                System.Diagnostics.Debug.WriteLine(newComment.CommentId.ToString() + " " + newComment.CommenterId.ToString() + " " + newComment.Contain + " " + newComment.CommentDate.ToString() + newComment.GameId.ToString());

                await commentService.AddComment(mapper.Map<CommentDto>(newComment));
            } catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Error during save comment: " + e.ToString());
            }
            

            return Ok();
            //return RedirectToAction("Detalils");
        }
    }
}
