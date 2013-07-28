using Glav.AgularJSDemo.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Glav.AgularJSDemo.Web.Models
{
	public class Slide
	{
		public Slide()
		{
			DetailPoints = new List<SlideDetailPoint>();
		}
		public int SequenceNumber { get; set; }
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string TitleBlurb { get; set; }
		public string DetailHeading { get; set; }
		public string DemoPage { get; set; }
		public string ImageSource { get; set; }
        public bool FullPageImage { get; set; }
		public List<SlideDetailPoint> DetailPoints { get; set; }
	}

	public class SlideDetailPoint
	{
        public SlideDetailPoint() { HighlightClass = HeaderHighlightCssType.None; }
		public SlideDetailPoint(string header) : this(header, string.Empty) { }
		public SlideDetailPoint(string header, string detail)
		{
			DetailPointHeader = header;
			DetailPointText = detail;
		}

		public string DetailPointHeader { get; set; }
		public string DetailPointText { get; set; }
        public HeaderHighlightCssType HighlightClass { get; set; }
	}
}