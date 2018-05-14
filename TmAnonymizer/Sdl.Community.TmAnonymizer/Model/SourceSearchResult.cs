﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Sdl.Community.TmAnonymizer.Model
{
    public class SourceSearchResult : ModelBase
	{
		public string Id { get; set; }
		public string TmSegmentId { get; set; }
		public string SegmentNumber { get; set; }
		public string SourceText { get; set; }
		public string TmFilePath { get; set; }
		public object Document { get; set; }
		public MatchResult MatchResult { get; set; }
		
	}
}
