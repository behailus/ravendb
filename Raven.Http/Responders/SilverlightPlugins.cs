﻿namespace Raven.Http.Responders
{
	using System.IO;
	using System.Linq;
	using Abstractions;
	using Extensions;
	using Newtonsoft.Json.Linq;

	public class SilverlightPlugins : AbstractRequestResponder
	{
		public override string UrlPattern { get { return @"^/silverlight/plugins$"; } }

		public override string[] SupportedVerbs { get { return new[] { "GET" }; } }

		public override void Respond(IHttpContext context)
		{
			var dir = ResourceStore.Configuration.PluginsDirectory;
			if (Directory.Exists(dir))
			{
				var paths = from path in Directory.GetFiles(dir, "*.xap", SearchOption.AllDirectories)
				            select path.Replace(dir, string.Empty).Replace(".xap", string.Empty);

				var xaps = new JArray(paths);
				context.WriteJson(xaps);
			}
			else
			{
				context.WriteJson(new JArray());
			}
		}
	}
}