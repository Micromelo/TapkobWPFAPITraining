﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapkob.Model
{
    public class RequirementTraderModel
    {
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("trader")]
		public TraderModel Trader { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }
	}
}