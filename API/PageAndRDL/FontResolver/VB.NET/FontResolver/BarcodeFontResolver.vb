Imports GrapeCity.Documents.Text
Imports GrapeCity.Documents.Text.Windows

Friend NotInheritable Class BarcodeFontResolver
	Implements IFontResolver

	Public Shared Instance As IFontResolver = New BarcodeFontResolver()
	Private _fonts As Documents.Text.FontCollection

	Private Sub New()
		_fonts = New Documents.Text.FontCollection()
		FontLinkHelper.UpdateFontLinks(_fonts, True)
		_fonts.RegisterDirectory("../../../../Fonts")
		_fonts.DefaultFont = _fonts.FindFamilyName("Arial")
	End Sub

	Private Function IFontResolver_GetFonts(familyName As String, isBold As Boolean, isItalic As Boolean) As FontCollection Implements IFontResolver.GetFonts
		Dim fonts = New Documents.Text.FontCollection()
		fonts.Add(If(_fonts.FindFamilyName(familyName, isBold, isItalic), _fonts.DefaultFont))
		Return fonts
	End Function
End Class
