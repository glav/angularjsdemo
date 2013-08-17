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
                TitleBlurb = "Access this demo at http://angularjsdemo.azurewebsites.net",
				DetailHeading = "",
				DemoPage = "",
                BlockHeadingStyle=true,
				ImageSource = "/images/angularjs.png"
				 

			};
            deckSlide.DetailPoints.Add(new SlideDetailPoint("@glav", "Twitter" ) { HighlightClass = HeaderHighlightCssType.InfoPointAccent5 });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("http://weblogs.asp.net/pglavich","Blog") { HighlightClass = HeaderHighlightCssType.InfoPointAccent3 });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("glav@theglavs.com","Email") { HighlightClass = HeaderHighlightCssType.InfoPointAccent2 });
			this.Add(deckSlide);

			// Slide 1
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Agenda",
				SubTitle = "",
				TitleBlurb = "",
				DetailHeading = "",
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
				SubTitle = "",
				TitleBlurb = "",
				DetailHeading = "The high level bits",
				DemoPage = "",
				ImageSource = "/images/bacon-coffee-cup.jpg"

			};
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Created by Google", "A Javascript framework to promote what good HTML development"));
			deckSlide.DetailPoints.Add(new SlideDetailPoint("Code Reduction", "SPA - Single page applications"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Community", "Large, rapidly expanding community"));
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

            this.Add(deckSlide);

            // Slide 3
            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Basics",
                SubTitle = "",
                TitleBlurb = "",
                DetailHeading = "",
                DemoPage = ""
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Declarative ng-*, data-ng-*, ng:*", "AngularJS is very declarative and forgiving. ng-show/data-ng-show/...."));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Module", "You must define a module ngApp='..'. Controllers, scope, services are within the module"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("View", "This is your HTML"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Controllers", "Controllers interact with data, other dependencies, and the scope. Controllers *should* never modify the DOM"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Scope ($scope/$rootScope)", "Scope is your view model. Your data + view specifics go into the scope. Controllers interact with scope and data."));
            this.Add(deckSlide);

            // Slide 3
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "More on the basics",
				SubTitle = "",
				TitleBlurb = "",
				DetailHeading = "",
				DemoPage = "AngularBasics.htm"
			};
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Data Model", "Any JSON/POJO data. All or part can be placed into scope to populate the view"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Services / Factories", "Components that typically provide data or other service to other components"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Directives", "Re-usable components that typically perform DOM manipulation"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("", ""));
            this.Add(deckSlide);

           
            // Slide 4
			deckSlide = new Slide
			{
				SequenceNumber = sequenceNumber += 1,
				Title = "Basics - Built in 'directives'",
				SubTitle = "You will hear the word directives a lot",
				TitleBlurb = "",
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
                TitleBlurb = "",
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
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Partial views", "Make async HTTP requests to get a different view"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Browser history support", "Yes, the back button works"));
            this.Add(deckSlide);

            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Directives - AngularJS super power",
                SubTitle = "Bending HTML to your needs",
                TitleBlurb = "",
                DetailHeading = "",
                DemoPage = "DirectivesPower.htm"
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Components that can manipulate the DOM", "Processed in the Angular lifecycle where DOM changes are picked up"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("AECM", "Attributes, Elements, Classes, Comments"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Beware using 'E'lements in IE", "Need to use a shim"));

            this.Add(deckSlide);

            // Slide 12
            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Forms and validation",
                SubTitle = "",
                TitleBlurb = "",
                DetailHeading = "",
                DemoPage = "FormValidation.htm"
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Complements HTML 5 validation", ""));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Works well, but a little clunky", ""));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Dynamically adds/removes classes, sets values", "ng-valid, ng-invalid, form.$invalid etc"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("novalidate attribute", "Usually need this to prevent HTML 5 validation taking over"));
            this.Add(deckSlide);

            // Slide 12
            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Minification",
                SubTitle = "",
                TitleBlurb = "",
                DetailHeading = ""
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Need to code with Minification in mind", ""));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Often, examples are *not* minification safe", ""));
            this.Add(deckSlide);

            // Slide 12
            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Using Angular in an ASP.Net app #1",
                SubTitle = "",
                TitleBlurb = "",
                DetailHeading = "",
                ImageSource="/images/folder-structure.png"
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Start off with a good folder structure", ""));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Get rid of jQuery validation / unobtrusive", "Can work but can also cause conflicts - standardise on one"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Keep jQuery", "Sure it doesn't need it,but its much nicer with it"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Load Angular early", "Typically in &lt;head&gt; section, all others at bottom inline with good practice"));
            this.Add(deckSlide);

            // Slide 12
            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Using Angular in an ASP.Net app #2",
                SubTitle = "",
                TitleBlurb = "",
                DetailHeading = ""
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Conditionals in common view to enable Angular", "May not always want Angular invoked, particularly legacy apps"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Test in release mode", "Ensure you are bundling/minification safe"));
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
                DetailHeading = "",
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
                Title = "Testing",
                SubTitle = "",
                TitleBlurb = "",
                DetailHeading = ""
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Built from groundp up to be testable", ""));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Plenty of samples for Jasmine(Karma) and QUnit", ""));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Integrate early into build process", ""));
            this.Add(deckSlide);

            // Slide 12
            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Tips n Tricks - General",
                SubTitle = "",
                TitleBlurb = "",
                DetailHeading = "",
                DemoPage="AngularUI.htm"
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Keep controllers lean", "Same as in MVC"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Dont be tempted to change DOM in controllers", "Use directives, particularly when using 3rd party components"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Use AngularUI", "Its awesome"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Dont bother with Angular animation until AngularJS 1.2", "It has changed a lot since prior releases. Currently 1.2 in RC"));
            this.Add(deckSlide);

            // Slide 12
            deckSlide = new Slide
            {
                SequenceNumber = sequenceNumber += 1,
                Title = "Tips n Tricks - Debugging",
                SubTitle = "",
                TitleBlurb = "",
                DetailHeading = ""
            };
            deckSlide.DetailPoints.Add(new SlideDetailPoint("debugger; tends to break/stop angular", "Sometimes ok - use console.log a lot"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Look for thrown exception in console", "Angular is good at reporting these"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("Batarang", "Excellent chrome add in"));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("", ""));
            deckSlide.DetailPoints.Add(new SlideDetailPoint("", ""));
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
            deckSlide.DetailPoints.Add(new SlideDetailPoint("https://github.com/thinktecture/Thinktecture.Web.Http", "Thinktecture.Web.Http repository") { HighlightClass = HeaderHighlightCssType.InfoPointAccent5 });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("http://angularjs.azurewebsites.net", "Online version of this demo") { HighlightClass = HeaderHighlightCssType.AngularJS });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("http://angular-ui.github.io/", "AngularUI") { HighlightClass = HeaderHighlightCssType.InfoPointAccent3 });
            deckSlide.DetailPoints.Add(new SlideDetailPoint("https://bitbucket.org/glav/glav.webapidemo", "Complete source code for entire deck and demo") { HighlightClass = HeaderHighlightCssType.InfoPointAccent2 });
			this.Add(deckSlide);

        }
	}

    public enum HeaderHighlightCssType
    {
        None,
        InfoPointAccent5,
        InfoPointAccent4,
        InfoPointAccent3,
        InfoPointAccent2,
        AngularJS,
        KnockoutJS
    }

}