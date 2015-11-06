﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using GoogleApi.Entities.Common.Interfaces;
using GoogleApi.Entities.Maps.Common;

namespace GoogleApi.Entities.Maps.Directions.Response
{
    /// <summary>
    /// Directions Response.
    /// </summary>
	[DataContract(Name = "DirectionsResponse")]
	public class DirectionsResponse : MapsBaseResponse, IResponseFor
	{
		/// <summary>
		/// "routes" contains an array of routes from the origin to the destination. See Routes below.
		/// </summary>
		[DataMember(Name = "routes")]
        public virtual IEnumerable<Route> Routes { get; set; }

		/// <summary>
		/// "routes" contains an array of routes from the origin to the destination. See Routes below.
		/// </summary>
        [DataMember(Name = "geocoded_waypoints")]
        public virtual IEnumerable<Route> WayPoints { get; set; }
	}
}
