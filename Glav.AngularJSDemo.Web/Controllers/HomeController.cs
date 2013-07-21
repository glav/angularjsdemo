using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glav._WebApiDemo.Web.Data;

namespace Glav._WebApiDemo.Web.Controllers
{
	public class HomeController : Controller
	{
	    private IRepository _repo = new Repository();

		public ActionResult Index()
		{
			var slideList = _repo.GetAllSlides();
			return View(slideList);
		}
	}
}
