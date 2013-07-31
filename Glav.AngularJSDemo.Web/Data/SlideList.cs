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
				TitleBlurb = "This site was built with AngularJS",
				DetailHeading = "Access this demo at http://angularjsdemo.azurewebsites.net",
				DemoPage = "",
                BlockHeadingStyle=true,
				ImageSource = "/images/angularjs.png"
				 

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
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Part 1: Getting to know AngularJS", "What it can do, how, and why is it different"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Part 2: Integration with ASP.Net, jQuery, legacy code", "Making beautiful music together"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Part 3: Tips, tricks, likes, dislikes, advanced", "What we found was good and also bad, plus some gotchas"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Wrap up", "Loud applause and high eval scores."));
			this.Add(deckSlide);
			
			// Slide 2
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "But first, what is it?",
				SubTitle = "So you can do Databinding, so what?",
				TitleBlurb = "",
				DetailHeading = "The high level bits",
				DemoPage = "",
				ImageSource = "/images/bacon-coffee-cup.jpg"

			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Created by Google", "A Javascript framework to promote what good HTML development"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Code Reduction", "SPA - Single page applications"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Download", "You can get it from <strong><a href='http://angularjs.org/' target='_blank'>http://angularjs.org/</a></strong>"));
			
			this.Add(deckSlide);

            // Slide 3
            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Structure of an Angular App",
                SubTitle = "Basic structure and flow of an angular app",
                TitleBlurb = "",
                DetailHeading = "",
                DemoPage = "",
                FullPageImage = true,
                ImageSource = "/images/AngularJS-Structure.png"

            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Created by Google", "A Javascript framework to promote what good HTML development"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Code Reduction", "SPA - Single page applications"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Download", "You can get it from <strong>http://somewhere</strong>"));

            this.Add(deckSlide);
            
            // Slide 3
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Some of the basics",
				SubTitle = "Something simple to start us off",
				TitleBlurb = "",
				DetailHeading = "Key concepts and differences",
				DemoPage = "AngularBasics.htm"
			};
            deckSlide.DetailPoints.Add(new SlideDetailPoint("View", "This is your HTML"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Controllers", "Controllers interact with data, other dependencies, and the scope. Controllers *should* never modify the DOM"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Data Model / Scope", "Data is your model/view model contained within the scope. Controllers interact with scope and data. Views are your HTML"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Declarative ng-*, data-ng-*, ng:*", "AngularJS is very declarative and forgiving. ng-show/data-ng-show/...."));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Play by Angular rules", "AngularJS works well when playing by its rules. You can break them, but it can get painfull."));
            this.Add(deckSlide);

           
            // Slide 4
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Basics - Built in 'directives'",
				SubTitle = "You will hear the word directives a lot",
				TitleBlurb = "Being declarative has lots of benefits",
				DetailHeading = "Some typical examples of declarative behaviour",
				DemoPage = "BuiltInDirectives.htm"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("ngShow", "Conditionally hide/show elements in the DOM"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("ngClick", "Click handler on the scope"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("ngClass", "Conditionally add/remove css class(es)"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("ngClassEven/ngClassOdd", "Apply classes to alternating rows"));
            this.Add(deckSlide);

            // Slide 5
            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Services and Factories",
                SubTitle = "Separating concerns",
                TitleBlurb = "Breaking the monolithic application into pieces",
                DetailHeading = "Service and/or Factory",
                DemoPage = "ServicesFactories.htm"
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Typically provide external data", "But can do anything you want really"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Performing data access", "The cononical example via XMLHTTP"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Services and Factories very similar", "How they are written and constructed differs somewhat"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Separation into services/factories good for DI and Testability", ""));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Effectively all are application singletons", ""));
            this.Add(deckSlide);

            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Built in services",
                SubTitle = "Angular gives you a range of supporting services",
                TitleBlurb = "",
                DetailHeading = "Here are just a few",
                DemoPage = "BuiltInServices.htm"
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("$resource/ $http", "Make async HTTP requests"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("$route", "An angular wrapper around the location object with some extras"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("$location", "An angular wrapper around the location object with some extras"));
            this.Add(deckSlide);

            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Routing",
                SubTitle = "One way that Angular really flexes its muscle",
                TitleBlurb = "Automatic history support",
                DetailHeading = "",
                DemoPage = "Routing.htm"
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Partial views", "Make async HTTP requests"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("$route", "An angular wrapper around the location object with some extras"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("$location", "An angular wrapper around the location object with some extras"));
            this.Add(deckSlide);

            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Directives - Angulars super power",
                SubTitle = "Bending HTML to your needs",
                TitleBlurb = "",
                DetailHeading = "",
                DemoPage = "ServicesFactories.htm"
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Components that can manipulate the DOM", "Processed in the Angular lifecycle where DOM changes are picked up"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("", ""));
            this.Add(deckSlide);

            // Slide 5
            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "A brief comparison- AngularJS and KnockoutJS",
                SubTitle = "KnockoutJS has data bindng too you know",
                TitleBlurb = "",
                DetailHeading = "Similar but different",
                DemoPage = "Angular-ko-compared.htm"
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("KnockoutJS - Mostly Imperitive via observables", "Wraps object properties and fires notifications when a property changes") { HighlightClass = HeaderHighlightCssType.KnockoutJS });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("AngularJS - Declarative/Plain JSON", "Uses 'dirty data/dirty checking' to compare an object before and after") { HighlightClass = HeaderHighlightCssType.AngularJS });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("KnockoutJS - Is all about data binding.", "Provides very rich data binding operations") { HighlightClass = HeaderHighlightCssType.KnockoutJS });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("AngularJS - Does more than just data binding", "Dependency injection, reuseable components via directives, form validation etc") { HighlightClass = HeaderHighlightCssType.AngularJS });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("jQuery not required, AngularJS is a little faster", "<a href='http://jsperf.com/angularjs-vs-knockoutjs/10' target='_blank'>http://jsperf.com/angularjs-vs-knockoutjs/10</a>"));
            
            this.Add(deckSlide);
            
            // Slide 12
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

        }
	}

    public enum HeaderHighlightCssType
    {
        None,
        InfoPointBlue,
        InfoPointPurple,
        InfoPointTeal,
        InfoPointOrange,
        AngularJS,
        KnockoutJS
    }

}