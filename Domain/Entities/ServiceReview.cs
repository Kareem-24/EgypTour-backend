﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ServiceReview : Review
    {
        public int ServiceReviewdId { get; private set; }
        public virtual Service ServiceReviewd { get; private set; }
        public ServiceReview(string content, float rating, Tourist writer) : base(content, rating, writer) { }
        private ServiceReview() { }

    }
}
