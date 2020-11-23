﻿namespace AstrologyBlog.Web.ViewModels.Articles
{
    using System;
    using System.Collections.Generic;

    public class IndexArticleViewModel
    {
        public IEnumerable<ArticleViewModel> Articles { get; set; }

        public int PageNumber { get; set; }

        public int ArticlesCount { get; set; }

        public int ItemsPerPage { get; set; }

        public int PreviousPageNumber => this.PageNumber - 1;

        public int NextPageNumber => this.PageNumber + 1;

        public bool HasPreviousPage => this.PageNumber > 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int PagesCount => (int)Math.Ceiling((double)this.ArticlesCount / this.ItemsPerPage);
    }
}
