using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ratemysession.models;

namespace ratemysession.Controllers
{
   [Route("/api/[Controller]")]

    public class ReviewsController : Controller
    {
        [HttpGet]
        public IEnumerable<Review> GetAllReviews()
        {
            var allReviews = new List<Review> {
                new Review { Text = "Yum" },
                new Review { Text = "Meh" }
            };

            return allReviews;
        }
    }

}