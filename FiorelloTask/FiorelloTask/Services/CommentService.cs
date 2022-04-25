using System;
using System.Collections.Generic;
using System.Linq;
using FiorelloTask.DAL;
using FiorelloTask.Entities;
using FiorelloTask.Exceptions;

namespace FiorelloTask.Services
{
    public class CommentService
    {
        TaskDbContext taskDbContext = new TaskDbContext();

        public void DeleteCommentById(int id)
        {
                var deleteIt = taskDbContext.Comments.FirstOrDefault(x => x.Id == id);
                taskDbContext.Comments.Remove(deleteIt);
                taskDbContext.SaveChanges();
        }

       public List<Comment> GetCommentsThroughDateRange(DateTime startDate, DateTime endDate)
        {
            List<Comment> NewComments = taskDbContext.Comments.Where(x => x.CreatedAt >= startDate && x.CreatedAt < endDate).ToList();
            if (NewComments != null)
            {
                return NewComments;
            }
            else
            {
                throw new NotFoundException("Commentler yoxdu bu vaxt araliginda!");
            }
            
        }
    }
}
