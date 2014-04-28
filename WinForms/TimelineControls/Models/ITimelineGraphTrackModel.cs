﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdamsLair.WinForms.TimelineControls
{
	public interface ITimelineGraphTrackModel : ITimelineTrackModel
	{
		IEnumerable<ITimelineGraph> Graphs { get; }

		event EventHandler GraphCollectionChanged;
		event EventHandler<TimelineGraphRangeEventArgs> GraphChanged;
	}
}