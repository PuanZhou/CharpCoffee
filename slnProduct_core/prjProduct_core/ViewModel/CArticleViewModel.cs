using Microsoft.AspNetCore.Http;
using prjCSCoffee.Models;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CArticleViewModel
    {
        public CArticleViewModel()
        {
            _article = new Article();
            _pro = new Product();
        }
        private Article _article;
        private Product _pro;
        public Article article
        {
            get { return _article; }
            set { _article = value; }
        }
        public Product product
        {
            get { return _pro; }
            set { _pro = value; }
        }
        public int ProductId
        {
            get { return _pro.ProductId; }
            set { _pro.ProductId = value; }
        }
        public string ProductName
        {
            get { return _pro.ProductName; }
            set { _pro.ProductName = value; }
        }
        public string MainPhotoPath
        {
            get { return _pro.MainPhotoPath; }
            set { _pro.MainPhotoPath = value; }
        }
        public int ArticleId
        {
            get { return _article.ArticleId; }
            set { _article.ArticleId = value; }
        }
        public string ArticleName
        {
            get { return _article.ArticleName; }
            set { _article.ArticleName = value; }
        }
        public string ArticleDescription
        {
            get { return _article.ArticleDescription; }
            set { _article.ArticleDescription = value; }
        }
        public string ArticleImage
        {
            get { return _article.ArticleImage; }
            set { _article.ArticleImage = value; }
        }
        public DateTime? ArticleDate
        {
            get { return _article.ArticleDate; }
            set { _article.ArticleDate = value; }
        }
    }
}
