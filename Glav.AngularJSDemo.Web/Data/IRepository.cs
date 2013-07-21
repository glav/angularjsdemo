using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glav.AgularJSDemo.Web.Models;

namespace Glav._WebApiDemo.Web.Data
{
	public interface IRepository
	{
		Slide GetSlide(int sequenceNumber);
		IEnumerable<Slide> GetAllSlides();
	}
}