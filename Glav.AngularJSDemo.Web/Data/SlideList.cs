using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glav.AgularJSDemo.Web.Models;

namespace Glav.AgularJSDemo.Web.Data
{
	public class SlideList : List<Slide>
	{
		public SlideList()
		{
			PopulatePresentationSlides();
		}

		private void PopulatePresentationSlides()
		{
			int sequenceNumber=0;
			// Slide 0
			var deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber,
				Title = "AngularJS Superheroic famework,and ASP.Net too...",
				SubTitle="Paul Glavich - ASP.NET MVP, ASPInsider, Author, CTO Saasu.com",
				TitleBlurb = "Twitter, blog, email etc...",
				DetailHeading = "Access this demo at http://angularjsdemo.azurewebsites.net",
				DemoPage = "",
				ImageSource = "/images/sleeping.jpg"
				 

			};
            deckSlide.DetailPoints.Add(new SlideDetailPoint("@glav", "Twitter" ) { HighlightClass = HeaderHighlightCssType.InfoPointBlue });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("http://weblogs.asp.net/pglavich","Blog") { HighlightClass = HeaderHighlightCssType.InfoPointTeal });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("glav@theglavs.com","Email") { HighlightClass = HeaderHighlightCssType.InfoPointOrange });
			this.Add(deckSlide);

			// Slide 1
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Agenda",
				SubTitle = "",
				TitleBlurb = "",
				DetailHeading = "Stuff we will cover",
				DemoPage = "",
				ImageSource = "/images/agenda.jpg"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("The basics", "What is can do, how, and why is it different"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("More advanced", "Directives, twisting HTML"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Integration with ASP.Net and jQuery", "Making beautiful music together"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Wrap up", "Loud applause and high eval scores."));
			this.Add(deckSlide);
			
			// Slide 2
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Bit of history",
				SubTitle = "",
				TitleBlurb = "",
				DetailHeading = "Where we started from in the .Net world",
				DemoPage = "",
				ImageSource = "/images/professor.jpg"

			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("ASMX", "The original .Net webservice"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("WSE 2 & 3", "Beginnings of WS-* stack. Verbose, getting complex. Secure but brain numbing"));			
			deckSlide.DetailPoints.Add(new SlideDetailPoint("WCF", "WS-FreakinEverything. All Windows communications unified. But the masses still were not happy."));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("MVC and custom views", "Building a pure REST Api via MVC and custom views was actually pretty easy."));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("WCF WebApi", "Trying to make WCF easier to build REST services."));
			
			this.Add(deckSlide);

			// Slide 3
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "REST - Simple wins",
				SubTitle = "",
				TitleBlurb = "",
				DetailHeading = "HTTP -just run with it",
				DemoPage = ""
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Use what is available", "HTTP Content types, SSL, HTTP Status codes etc"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("JSON &amp; XML", "The favoured few, but all media types can be supported"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Resource Based - HTTP Verb determines the action", "<em>http://host/contact/1</em> as opposed to <em>http://host/contact/get/1</em>"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("HATEOAS", "Hypermedia as the Engine of Application State. Community media formatters provide limited support <strong>http://hal.codeplex.com/</strong>, <strong>https://bitbucket.org/smichelotti/hal-media-type</strong> and <strong>https://github.com/JakeGinnivan/WebApi.Hal</strong>"));
			this.Add(deckSlide);

			// Slide 4
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "WebApi Basics",
				SubTitle = "",
				TitleBlurb = "",
				DetailHeading = "Default Support",
				DemoPage = "SimpleGetPost.htm"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Controllers inherit from ApiController", ""));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("GlobalConfiguration.Configuration holds your api setup", "Can access handlers, media formatters, modelbinders etc..."));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Defaults to <string>api</strong> route", "eg. <em>http://host/api/{controller}</em>. Change via routing table - MapHttpRoute"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("HTTP method inferred from controller actions.","For eg. GetStuff, PostStuff, PutStuff. Can still use [HttpGet], [HttpPost] attribs though"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Conneg", "Automatic content negotiation. x-www-form-urlencoded xml, json. Dont want XML support, just remove it."));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Interception points, DI and handlers - all async too", "Setting up interception points is very similar to MVC, but distinct and separate. Also, get used dealing with System.Threading.Tasks. All Async"));
			this.Add(deckSlide);

			// Slide 5
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Binding to parameters",
				SubTitle = "How data gets into your variables",
				TitleBlurb = "",
				DetailHeading = "A few basic rules and defaults"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Simple types generally use model binding", "int, string etc will be searched for in the Uri and body using ValueProviders. WebApi does a pretty good job of working out what goes where."));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Complex types default to using MediaFormatters", "These typically use a content-type and read from the message body"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Can change with [FromUri] or [FromBody] attributes on parameters or types", "These attributes can be on your action methods or your model objects"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Message Body can only be read once!", "Once its read, it cannot be re-read.Need to make a copy and pass it around. ModelBinding does this."));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("If 2 complex types as action parms, at least one must use ModelBinding", "Whether defined using the [ModelBinder] attribute or hooked up via a custom ModelBinder provider."));
			this.Add(deckSlide);

			// Slide 6
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Delegating Handlers",
				SubTitle = "Handling requests early in the pipeline",
				TitleBlurb = "",
				DetailHeading = "",
				ImageSource = "/images/pipeline-delegatinghandler.png"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Typically used for intercepting all requests", ""));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Typically not concerned with content type", ""));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Logging, authorisation and other cross cutting concerns", ""));
			this.Add(deckSlide);

			// Slide 7
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Media Formatters",
				SubTitle = "Supporting different content types",
				TitleBlurb = "",
				DetailHeading = "",
				DemoPage = "MediaFormatter.htm",
				ImageSource = "/images/pipeline-mediaformatter.png"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Create MediaTypeFormatters to support any content types", "Simply inherit from MediaTypeFormatter and specify what content type and encoding to support"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Register your custom formatter", "via <strong>GlobalConfiguration.Configuration.Formatters</strong>"));
			this.Add(deckSlide);

			// Slide 8
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Model Binding",
				SubTitle = "General behaviour for binding data to a type",
				TitleBlurb = "",
				DetailHeading = "",
				DemoPage = "ModelBinder.htm"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Support a common type for all your actions", "The model binder will kick in whenever it sees this type as an argument on an action"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Can use a <strong>[ModelBinder(typeof(MyModelBinder)]</strong> attribute", "The model binder will kick in whenever it sees this type as an argument on an action"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Register ModelBinderProvider to return custom model binders", ""));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Can also create IControllerConfiguration instance to handle per controller requirements", "Also allows handling route table, formatters, binders, message handlers etc.."));
            this.Add(deckSlide);

			// Slide 8
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "More on protocol support via convention",
				SubTitle = "OData Support was present in RC, but RTM has no OData support out of the box",
				TitleBlurb = "",
				DetailHeading = "OData Support - in RC but NOT IN RTM",
				DemoPage = "ODataSupport.htm"
			};
            deckSlide.DetailPoints.Add(new SlideDetailPoint("OData support is an add-on nuget package for RTM", "OData support was in RC"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Add OData support by installing nuget package Microsoft.AspNet.WebApi.OData", "<strong>http://www.nuget.org/packages/Microsoft.AspNet.WebApi.OData/0.1.0-alpha-120815</strong>"));
			
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Simply implement IQueryable<T>/IEnumerable<T> + [Queryable]", "Sometimes... early OData support is a little painfull to setup. Often manually set keys etc"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Based on ODataLib NuGet package", "OData formatter, an EDM model builder, richer query support, $metadata support and link generation support"));
			this.Add(deckSlide);

			// Slide 9
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Dependency Injection",
				SubTitle = "",
				TitleBlurb = "",
				DetailHeading = "Similar but different",
				ImageSource = "/images/arnie-di.jpg"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Confusingly, uses IDependencyResolver", "Yes it is the same name as the MVC one, but different..."));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Supports lifetime scopes", "via the IDependencyScope interface"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Setup via different injection point than regular MVC", "GlobalConfiguration.Configuration.DependencyResolver = {your resolver}"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("All interception points support DI", "MessageHandlers, Mediaformatters etc.."));
			this.Add(deckSlide);

			// Slide 10
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Authentication/Authorisation",
				SubTitle = "I want in....now",
				TitleBlurb = "",
				DetailHeading = "Not tied to MVC but supports it",
				DemoPage = "Authorisation.htm"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Can use standard attributes", "[Authorize] and [AllowAnonymous]"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Can create your own Authorize attrib", "Just inherit from '<strong>ActionFilterAttribute</strong>'. Can use same technique for validation to provide result from model validation`"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Http Status 401 - Unauthorized must be handled by client", "Often this is Javascript, must redirect to logon to grab the cookie"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Can also be handled by MessageHandler - DelegatingHandler", "Good for coverage over entire site"));
			this.Add(deckSlide);
			
			// Slide 11
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Advertising/Self Documenting",
				SubTitle = "Using the ApiExplorer",
				TitleBlurb = "",
				DetailHeading = "Providing a Self Documenting Api",
				DemoPage = "ApiExplorer.htm"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Create an instance of ApiExplorer from the global configuration", "GlobalConfiguration.Configuration.Services.GetApiExplorer()"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("ApiExplorer interrogates the configuration and your Api", "ActionDescriptions, ParameterDescriptions. It skips past actions with the <em>[ApiExplorerSettings(IgnoreApi = true)]</em> attribute"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("It provides the Raw data, has no verbose documentation mechanism", "You provide the visual representation of your Api"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("You can provide a verbose documentation implementation", "Implement IDocumentationProvider and attaching to ApiExplorer"));
			this.Add(deckSlide);

			// Slide 12
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Self Hosting",
				SubTitle = "Don't need no stinkin web host",
				TitleBlurb = "",
				DetailHeading = "Host outside of your web app",
				DemoPage ="SelfHosted.htm"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Install-Package AspNetWebApi.SelfHost", "Gives you standard WebApi assemblies plus <strong>System.Web.Http.SelfHost</strong>"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Set config via HttpSelfHostConfiguration instance", ""));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Create new HttpSelfHostServer with config", "new HttpSelfHostServer(new HttpSelfHostConfiguration(\"http://localhost:8000\"));"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Open the server instance, then wait for requests", "instance.OpenAsync().Wait();"));
			this.Add(deckSlide);

			// Slide 13
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Async Support",
				SubTitle = "Async-ness produces less suck-ness",
				TitleBlurb = "",
				DetailHeading = "Getting jiggy in parallel...",
				DemoPage = "../api/AsyncTest"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("WebApi inherently supports Task based programming", ""));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Return a Task<T> from any action", ""));

			this.Add(deckSlide);

			// Slide 14
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Resource / Related Content",
				SubTitle = "",
				TitleBlurb = "",
				DetailHeading = "Further information"
			};
            deckSlide.DetailPoints.Add(new SlideDetailPoint("https://github.com/thinktecture/Thinktecture.Web.Http", "Thinktecture.Web.Http repository") { HighlightClass = HeaderHighlightCssType.InfoPointBlue });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("WebApiBloggers.com", "Bunch of people blogging solely around WebApi") { HighlightClass = HeaderHighlightCssType.InfoPointPurple });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("http://webapidemo.azurewebsites.net", "Online version of this demo") { HighlightClass = HeaderHighlightCssType.InfoPointTeal });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("https://bitbucket.org/glav/glav.webapidemo", "Complete source code for entire deck and demo") { HighlightClass = HeaderHighlightCssType.InfoPointOrange });
			this.Add(deckSlide);

            // Slide 15
            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Thanks",
                SubTitle = "Enjoy the rest of TechEd",
                TitleBlurb = "",
                DetailHeading = ""
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("<img src='images/LastSlide.png' />"));
            this.Add(deckSlide);
        }
	}

    public enum HeaderHighlightCssType
    {
        None,
        InfoPointBlue,
        InfoPointPurple,
        InfoPointTeal,
        InfoPointOrange
    }

}