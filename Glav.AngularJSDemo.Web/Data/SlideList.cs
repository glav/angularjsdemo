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
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Likes and dislikes", "What we found was good and also bad, plus some gotchas"));
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
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Data Model", "Data is your model/view model within scope. Controllers interact with scope and data. Views are your HTML"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Controllers", "Controllers interact with data, other dependencies, and the scope. Controllers *should* never modify the DOM"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Scope", "Scope is applied to a view. This can be via databinding. AngularJS is 'anal' about scope management. "));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Declarative", "AngularJS is very declarative and forgiving. ng-show/data-ng-show/...."));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Play by Angular rules", "AngularJS works well when playing by its rules. You can break them, but it can get painfull."));
            this.Add(deckSlide);

           
            // Slide 4
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Basics - Built in 'directives'",
				SubTitle = "You will hear the word directives a lot",
				TitleBlurb = "Being declarative has lots of benefits",
				DetailHeading = "Declarative Behaviour",
				DemoPage = "BuiltInDirectives.htm"
			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("ngShow", "Conditionally hide/show elements in the DOM"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("ngClass", "Conditionally add/remove css class(es)"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("", ""));
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
            deckSlide.DetailPoints.Add(new SlideDetailPoint("AngularJS - Declarative/Plain JSON", "Uses 'dirty data' <verify this> to compare an object before and after its 'digest' phase to see if changes are made") { HighlightClass = HeaderHighlightCssType.AngularJS });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("KnockoutJS - Is all about data binding.", "Provides very rich data binding operations") { HighlightClass = HeaderHighlightCssType.KnockoutJS });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("AngularJS - Does more than just data binding", "Dependency injection, reuseable components via directives, form validation etc") { HighlightClass = HeaderHighlightCssType.AngularJS });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("KnockoutJS & AngularJS - jQuery not required", "Both work fine without jQuery, Angular contains jqLite jQuery subset but uses jQuery if available."));
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