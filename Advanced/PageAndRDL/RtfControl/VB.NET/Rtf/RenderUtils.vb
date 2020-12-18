Imports System.Drawing

Namespace Rendering.Layout
    Public Class RenderUtils
        Private Shared ReadOnly firstChar_ As Bitmap = New Bitmap(1, 1)

        Public Shared ReadOnly Property HorizontalResolution As Single
            Get
                Return firstChar_.HorizontalResolution
            End Get
        End Property

        Public Shared ReadOnly Property VerticalResolution As Single
            Get
                Return firstChar_.VerticalResolution
            End Get
        End Property

    End Class
End Namespace