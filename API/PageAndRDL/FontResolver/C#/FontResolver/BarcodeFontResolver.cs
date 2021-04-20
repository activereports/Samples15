using GrapeCity.Documents.Text.Windows;

namespace GrapeCity.ActiveReports.Samples.FontResolver
{
	internal sealed class BarcodeFontResolver : IFontResolver
	{
		public static IFontResolver Instance = new BarcodeFontResolver();

		Documents.Text.FontCollection _fonts;

		private BarcodeFontResolver()
		{
			_fonts = new Documents.Text.FontCollection();
			// load Windows fonts
			FontLinkHelper.UpdateFontLinks(_fonts, true);
			// load barcode fonts
			_fonts.RegisterDirectory("../../../../Fonts");
			_fonts.DefaultFont = _fonts.FindFamilyName("Arial");
		}

		Documents.Text.FontCollection IFontResolver.GetFonts(string familyName, bool isBold, bool isItalic)
		{
			var fonts = new Documents.Text.FontCollection();
			fonts.Add(_fonts.FindFamilyName(familyName, isBold, isItalic) ?? _fonts.DefaultFont);
			return fonts;
		}
	}
}
