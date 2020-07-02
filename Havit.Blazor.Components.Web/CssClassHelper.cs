﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Havit.Blazor.Components.Web
{
	/// <summary>
	/// Helper for working with classes.
	/// </summary>
	public static class CssClassHelper
	{
		/// <summary>
		/// Join class names to one class attribute value (using space as a separator). Null or empty items in cssClasses argument are ignored.
		/// </summary>
		/// <example>
		/// For "btn btn-primary", null, "bt-lrg" returns "btn btn-primary bt-lrg".
		/// </example>
		public static string Combine(params string[] cssClasses)
		{
			return String.Join(" ", cssClasses.Where(item => !String.IsNullOrEmpty(item)));
		}
	}
}
