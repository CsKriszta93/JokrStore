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
        public async Task<IActionResult> PostComment(string contain, string gameId, string topicId, string commentType)
        {
            System.Diagnostics.Debug.WriteLine("***********PostComment executed:" + contain + " " + gameId + " " + topicId);
            var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
            if (!ModelState.IsValid)
            {
                return View(contain);
            }

            var newComment = new CommentViewModel
            {
                UserId = Guid.Parse(UserId),
                Contain = contain,
                CommentDate = DateTime.Now.ToString("yyyy.MM.dd. hh:mm")
            };

            if (gameId != null)
                newComment.GameId = Guid.Parse(gameId);
            else
                newComment.GameId = null;

            if (topicId != null)
                newComment.ForumTopicId = Guid.Parse(topicId);
            else
                newComment.ForumTopicId = null;    


            System.Diagnostics.Debug.WriteLine("Game Id: " + newComment.GameId.ToString());

            await commentService.AddComment(mapper.Map<CommentDto>(newComment));

            if (commentType == "1")
                return RedirectToAction("ForumTopicContent", "Forum", new { id = topicId });

            return RedirectToAction("Games", "Details", new { id = gameId });
            //return RedirectToAction("Detalils");
        }
    }
}