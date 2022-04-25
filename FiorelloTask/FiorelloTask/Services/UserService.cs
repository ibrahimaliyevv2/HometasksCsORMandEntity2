using System;
using System.Collections.Generic;
using System.Linq;
using FiorelloTask.DAL;
using FiorelloTask.Entities;
using FiorelloTask.Exceptions;

namespace FiorelloTask.Services
{
    public class UserService
    {
        TaskDbContext taskDbContext = new TaskDbContext();

        public List<Comment> GetCommentsByUserId(int userId)
        {
            List<Comment> NewComments = taskDbContext.Comments.Where(x => x.UserId == userId).ToList();
            if (NewComments!=null)
            {
                return NewComments;
            }
            else
            {
                throw new NotFoundException("Comment yazmayib bu user!");
            }
        }
    }
}
