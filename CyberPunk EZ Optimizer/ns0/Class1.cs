using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal sealed class Class1
	{
		internal Class1()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Class1.resourceManager_0 == null)
				{
					ResourceManager resourceManager = new ResourceManager("A.c1d800f62168008aeca978bfb04a23363", typeof(Class1).Assembly);
					Class1.resourceManager_0 = resourceManager;
				}
				return Class1.resourceManager_0;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Class1.cultureInfo_0;
			}
			set
			{
				Class1.cultureInfo_0 = value;
			}
		}

		private static ResourceManager resourceManager_0;

		private static CultureInfo cultureInfo_0;
	}
}
