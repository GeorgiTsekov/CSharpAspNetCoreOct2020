﻿namespace AstrologyBlog.Web.ViewModels.Articles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text.RegularExpressions;

    using AstrologyBlog.Data.Models;
    using AstrologyBlog.Services.Mapping;
    using AutoMapper;
    using Ganss.XSS;

    public class ArticleViewModel : IMapFrom<Article>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string SanitizedDescription => new HtmlSanitizer().Sanitize(this.Description);

        public string ImageUrl { get; set; }

        public string CreatedByUserUserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public double AverageStarsVote { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<CommentInArticleViewModel> Comments { get; set; }

        public string ShortDescription
        {
            get
            {
                var description = WebUtility.HtmlDecode(Regex.Replace(this.SanitizedDescription, @"<[^>]+>", string.Empty));
                return description.Length > 200
                        ? description.Substring(0, 200) + "..."
                        : description;
            }
        }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Article, ArticleViewModel>()
                .ForMember(a => a.AverageStarsVote, opt =>
                    opt.MapFrom(a => a.Votes.Count() == 0 ? 0 : a.Votes.Average(v => v.StarsCount)))
                .ForMember(x => x.ImageUrl, opt =>
                    opt.MapFrom(x =>
                        x.Images.FirstOrDefault().RemoteImageUrl != null ?
                        x.Images.FirstOrDefault().RemoteImageUrl :
                        "/images/articles/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }
    }
}
