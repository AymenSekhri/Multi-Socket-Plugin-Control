Public Class Form2
    Public a As String
    Public P(4096 * 8000) As Byte
    Public t As String
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        TextBox1.Dock = DockStyle.Fill
        PictureBox1.Dock = DockStyle.Fill
    End Sub
    Public oo As Boolean
    
End Class
