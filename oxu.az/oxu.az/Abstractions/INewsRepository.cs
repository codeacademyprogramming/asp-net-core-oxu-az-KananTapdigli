using Microsoft.AspNetCore.Mvc.Rendering;
using oxu.az.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oxu.az.Abstractions
{
    public interface INewsRepository
    {
        News GetNews(int? Id);

        List<News> GetAllNews();

        IQueryable<News> GetCategoryNews(int CategoryId);

        void  AddNews(News news);

        void EditNews(News news);

        void DeleteNews(int? Id);


        IQueryable<News> GetFeaturedNews();

    }
}
