using AutoMapper;
using BLL.DTO;
using BLL.ServiceInterfaces;
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

        [HttpPost("comment")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostComment(CommentDto comment)
        {
            var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
            if (!ModelState.IsValid)
            {
                return Content("error");
            }


            comment.CommenterId = Guid.Parse(UserId);
            comment.CommentDate = DateTime.Now.ToString("yyyy.MM.dd. hh:mm");

            await commentService.AddComment(comment);

           return Ok("Success");
        }
    }
}