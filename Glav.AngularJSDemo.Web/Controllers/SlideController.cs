using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Glav._WebApiDemo.Web.Data;
using Glav.AgularJSDemo.Web.Models;

namespace Glav._WebApiDemo.Web.Controllers
{
    public class SlideController : ApiController
    {
        private IRepository _repo = new Repository();

        /// <summary>
        /// Gets the startiung slide in the Deck
        /// </summary>
        /// <returns>Presentation slide information</returns>
        public Slide Get()
        {
			return GetSlide(0);
        }

		/// <summary>
		/// Gets aspecific Slide in the deck
		/// </summary>
		/// <param name="slideNumber">The slide number to retrieve</param>
		/// <returns>Presentation slide information/returns>
		public Slide GetSlide(int? slideNumber)
		{
			if (!slideNumber.HasValue || slideNumber.Value < 0)
			{
				slideNumber = 0;
			}

			return _repo.GetSlide(slideNumber.Value);
		}

		public void PostFeedback(FeedbackData feedbackBlob)  // posting data, this works as modelbinding is put in play
		{

		}
		
    }

	public class FeedbackData
	{
		public string slide {get ;set;}
		public string feedback { get; set; }
	}
}
