using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using oxu.az.Abstractions;
using oxu.az.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oxu.az.Models
{
    public class NewsRepository : INewsRepository
    {
        private readonly NewsContext _context;

        public NewsRepository(NewsContext context)
        {
            _context = context;
        }

        public void AddNews(News news)
        {
            _context.News.Add(news);
            _context.SaveChanges();
        }

        public void DeleteNews(int? id)
        {
            var news = _context.News.Find(id);
            _context.News.Remove(news);
            _context.SaveChanges();
        }

        public void EditNews(News news)
        {
            var _news = _context.News.Find(news.Id);

            _news.FileName = news.FileName;
            _news.CategoryId = news.CategoryId;
            _news.Content = news.Content;
            _news.Title = news.Title;
            _news.isMain = news.isMain;

            _context.SaveChanges();
        }

        public List<News> GetAllNews()
        {
            var news = _context.News.Include("Category").ToList();

            return news;
        }

        public IQueryable<News> GetCategoryNews(int CategoryId)
        {
            var news = _context.News.Include("Category").Where(n => n.CategoryId == CategoryId);
            return news;
        }

        public IQueryable<News> GetFeaturedNews()
        {
            var featuredNews = _context.News.Where(n => n.isMain == true).OrderByDescending(n=>n.CreationTime).Take(5);
            return featuredNews;
        }

        public News GetNews(int? Id)
        {
            var news = _context.News.Include("Category").FirstOrDefault(n => n.Id == Id);
            return news;
        }
    }
}
