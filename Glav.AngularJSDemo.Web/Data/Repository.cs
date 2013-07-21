using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glav.AgularJSDemo.Web.Models;
using Glav.AgularJSDemo.Web.Data;

namespace Glav._WebApiDemo.Web.Data
{
	public class Repository : IRepository
	{
		private SlideList _slideList = new SlideList();

		public Slide GetSlide(int sequenceNumber)
		{
			return _slideList[sequenceNumber];
		}

		public IEnumerable<Slide> GetAllSlides()
		{
			return _slideList;
		}
	}
}