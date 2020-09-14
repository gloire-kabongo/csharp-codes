using System;
using System.Linq;

using BlogExemple.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddPost();
            GetPosts();
            //GetPostById(3);
        }

        static void AddPost()
        {
            var db = new BloggingContext();
            var post = new Post
            {
                Title = "Typescript is awesome!!!!!!",
                Body = "Typescript is awesome!!!!!!"
            };
            db.Posts.Add(post);
            //db.Add(post);
            db.SaveChanges();
        }

        private static void AddComment(int postId, string comment)
        {
            var db = new BloggingContext();

            var post = db.Posts.SingleOrDefault(p => p.Id == postId);

            post.Comments.Add(new Comment { Body = comment});
            db.SaveChanges();
        }

        static void DeletePost(int postId)
        {
            var db = new BloggingContext();

            var post = db.Posts.SingleOrDefault(p => p.Id == postId);
            db.Posts.Remove(post);
            db.SaveChanges();
        }

        static void UpdatePost(int postId, string newTitle)
        {
            var db = new BloggingContext();

            var post = db.Posts.SingleOrDefault(p => p.Id == postId);
            post.Title = newTitle;
            db.SaveChanges();
        }

        private static void GetPostById(int postId)
        {
            var db = new BloggingContext();

            var post = db.Posts
                        .Include(p => p.Comments)
                        .SingleOrDefault(p => p.Id == postId);

            Console.WriteLine(post.Title);
            Console.WriteLine("Comments ***********");
            foreach (var comment in post.Comments)
            {
                Console.WriteLine(comment.Body);
            }
        }

        private static void GetPosts()
        {
            var db = new BloggingContext();
            var posts = db.Posts
                        .Select(p => new { p.Title })
                        .ToList();
            foreach (var post in posts)
            {
                Console.WriteLine(post.Title);
            }
        }
    }
}
