using System;
using System.Collections.Generic;
using System.Linq;
using FiorelloTask.DAL;
using FiorelloTask.Entities;

namespace FiorelloTask.Services
{
    public class UserService
    {
        TaskDbContext taskDbContext = new TaskDbContext();

        public List<Comment> GetCommentsByUserId(int userId)
        {
            return taskDbContext.Comments.Where(x => x.UserId == userId).ToList();
        }
    }
}
