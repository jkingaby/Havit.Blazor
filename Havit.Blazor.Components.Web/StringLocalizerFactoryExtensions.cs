﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.Localization;

namespace Havit.Blazor.Components.Web
{
	/// <summary>
	/// Extension methods for IStringLocalizerFactory.
	/// </summary>
	public static class StringLocalizerFactoryExtensions
	{
		/// <summary>
		/// Returns localized value when resourceType is not null.
		/// Otherwise returns value (without attemp to get localized value).
		/// </summary>
		public static string GetLocalizedValue(this IStringLocalizerFactory stringLocalizerFactory, string value, Type resourceType)
		{
			if ((resourceType != null) && !String.IsNullOrEmpty(value))
			{
				return stringLocalizerFactory.Create(resourceType).GetString(value).Value;
			}
			
			return value;
		}
	}
}
