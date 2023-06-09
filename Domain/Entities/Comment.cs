﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Comment
    {
        public int Id { get; private set; }
        public string Content { get; private set; }
        public DateTime Date { get; private set; }
        public int PostId { get; private set; }
        public virtual Post Post { get; private set; }
        public int WriterId { get; private set; }
        public virtual Tourist Writer { get; private set; }

        public Comment()
        {
        }

        public Comment(string content, DateTime date, int postId, int writerId)
        {
            Content=content;
            Date=date;
            PostId=postId;
            WriterId=writerId;
        }
    }
}
