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
        public async Task<IActionResult> PostComment(string contain)
        {
            var commenterId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;

            if (!ModelState.IsValid)
            {
                return View(Contain);
            }

            var newComment = new CommentViewModel
            {
                CommenterId = Guid.Parse(commenterId),
                Contain = Contain,
                CommentDate = DateTime.Now                
            };
            await commentService.AddComment(mapper.Map<CommentDto>(newComment));

            return Ok();
            //return RedirectToAction("Detalils");
        }
    }
}
