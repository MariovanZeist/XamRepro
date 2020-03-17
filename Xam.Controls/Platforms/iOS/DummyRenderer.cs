using Xamarin.Forms;

#if __MOBILE__
using Xamarin.Forms.Platform.iOS;
using NativeLabel = UIKit.UILabel;
#else
using Xamarin.Forms.Platform.MacOS;
using AppKit;
using NativeLabel = AppKit.NSTextField;
#endif
[assembly: ExportRenderer(typeof(Label), typeof(FixXam.Forms.Platforms.iOS.DummyRenderer))]
namespace FixXam.Forms.Platforms.iOS
{
	public class DummyRenderer : ViewRenderer<Label, NativeLabel>
	{

	}
}
