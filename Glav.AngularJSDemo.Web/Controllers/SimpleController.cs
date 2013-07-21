#region using statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;
using System.Web.Http.Description;
using System.Web.Http.Controllers;
using System.ComponentModel.DataAnnotations;
#endregion

namespace Glav.AgularJSDemo.Web.Controllers
{
    public class SimpleController : ApiController
    {
		/// <summary>
		/// The default GET implementation
		/// </summary>
		/// <returns></returns>
		public string Get()
		{
			return string.Format("From the Get method at: {0}",DateTime.Now.ToShortTimeString());
		}

		/// <summary>
		/// Standard GET but expecting an integer parameter
		/// </summary>
		/// <param name="id">Some identifier</param>
		/// <returns></returns>
		public string Get(int id)
		{
			return string.Format("From the Get(id) method id:{0}", id);
		}

		[ApiExplorerSettings(IgnoreApi = true)]
		public string Get(string someText)
		{
			return string.Format("From the Get(someText) method someText:{0}", someText);
		}

		/// <summary>
		/// Demand a serving of your favourite amber beverage
		/// </summary>
		/// <param name="kindOfBeer">The type of beeryou want</param>
		/// <returns>A string showing complete compliance with your request</returns>
		public string GetMeSomeBeer(string kindOfBeer)
		{
			return string.Format("Here you go kind sir, your {0} beer.", kindOfBeer);
		}

		public Response Post(PostedData data)
		{
			var response = new Response { WasSuccessfull = true };
			if (data == null)
			{
				response.Result = "POST with complex object -> NULL";
				response.WasSuccessfull = false;
				return response;
			}
			if (string.IsNullOrEmpty(data.argOne) == null && string.IsNullOrEmpty(data.argTwo) == null && string.IsNullOrEmpty(data.argThree) == null)
			{
				response.Result = "POST with complex object -> All Datamembers were null";
				response.WasSuccessfull = false;
				return response;
			}
			response.Result = string.Format("POST with complex object -> Arg1:{0}, Arg2: {1}, Arg3:{2}", data.argOne, data.argTwo, data.argThree);

			return response;
		}

		public Response PutJunk(PostedData data)
		{
			var result = Post(data);
			result.Result = "PUT -> " + result.Result;
			return result;
		}

		public Response HeadOfCatHerding()
		{
			var result = new Response { WasSuccessfull = true, Result = "HEAD -> blown" };
			return result;
		}

		public Response DeleteSomeStuff(int? id)
		{
			return new Response { Result = "Deleted!", WasSuccessfull = true };
		}

	}


	public class PostedData
	{
        //[StringLength(2)]
		public string argOne {get; set;}
		public string argTwo {get; set;}
		public string argThree {get; set;}
	}

	public class Response
	{
		public string Result;
		public bool WasSuccessfull;
	}
}
 