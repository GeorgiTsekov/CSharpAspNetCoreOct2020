﻿namespace ForumSystem.Web.Controllers
{
    using System.Threading.Tasks;

    using ForumSystem.Data.Models;
    using ForumSystem.Services.Data;
    using ForumSystem.Web.ViewModels.Posts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class PostsController : Controller
    {
        private readonly IPostsService postService;
        private readonly ICategoriesService categoriesService;
        private readonly UserManager<ApplicationUser> userManager;

        public PostsController(
            IPostsService postService,
            ICategoriesService categoriesService,
            UserManager<ApplicationUser> userManager)
        {
            this.postService = postService;
            this.categoriesService = categoriesService;
            this.userManager = userManager;
        }

        public IActionResult ById(int id)
        {
            // TODO: read the post
            return this.View();
        }

        [Authorize]
        public IActionResult Create()
        {
            var categories = this.categoriesService.GetAll<CategoryDropDownViewModel>();
            var viewModel = new PostCreateInputModel()
            {
                Categories = categories,
            };
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(PostCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var user = await this.userManager.GetUserAsync(this.User);
            var postId = await this.postService.CreateAsynk(input.Title, input.Content, input.CategoryId, user.Id);

            return this.RedirectToAction("ById", new { id = postId });
        }
    }
}