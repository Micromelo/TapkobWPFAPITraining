﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapkob.Interfaces;

namespace Tapkob.Model.TaskObjective
{
    public class TaskObjectiveItemModel : ITaskObjective
    {
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("maps")]
		public List<MapModel> Maps { get; set; }

		[JsonProperty("optional")]
		public bool Optional { get; set; }

		[JsonProperty("item")]
		public ItemModel Item { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("foundInRaid")]
		public bool FoundInRaid { get; set; }

		[JsonProperty("dogTagLevel")]
		public int? DogTagLevel { get; set; }

		[JsonProperty("maxDurability")]
		public int? MaxDurability { get; set; }

		[JsonProperty("minDurability")]
		public int? MinDurability { get; set; }
	}
}