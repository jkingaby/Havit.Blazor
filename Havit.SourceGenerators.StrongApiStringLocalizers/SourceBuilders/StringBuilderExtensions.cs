﻿using System.Text;
using System.Text.RegularExpressions;
using Havit.SourceGenerators.StrongApiStringLocalizers.Helpers;

namespace Havit.SourceGenerators.StrongApiStringLocalizers.SourceBuilders;

internal static class StringBuilderExtensions
{
	public static StringBuilder AppendAutoGeneratedDocumenationCommentLine(this StringBuilder builder)
	{
		return builder.AppendLine("// <auto-generated />");
	}

	public static StringBuilder AppendGeneratedCodeAttributeLine(this StringBuilder builder)
	{
		return builder.AppendLine($"[GeneratedCode(\"{nameof(Havit)}.{nameof(SourceGenerators)}.{nameof(StrongApiStringLocalizers)}.{nameof(StrongApiStringLocalizersGenerator)}\", \"{typeof(StringBuilderExtensions).Assembly.GetName().Version}\")]");
	}

	public static StringBuilder AppendSummaryCommentLine(this StringBuilder builder, string comment)
	{
		if (!String.IsNullOrEmpty(comment))
		{
			string[] commentLines = Regex.Split(comment, "\r\n|\r|\n");
			builder.AppendLine("\t/// <summary>");
			foreach (var commentLine in commentLines)
			{
				builder.Append("\t/// ").AppendLine(HttpUtilityExt.HtmlEncode(commentLine, HtmlEncodeOptions.IgnoreNonASCIICharacters));
			}
			builder.AppendLine("\t/// </summary>");
		}

		return builder;
	}
}
