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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim hhh As String = My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins\type.txt")
        'If hhh = "image" Then
        '    Label1.Text = "Recived Image"
        '    PictureBox1.Visible = True
        '    TextBox1.Visible = False
        '    Dim aymen = My.Computer.FileSystem.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\PlugControl_Images")
        '    For Each x As String In aymen
        '        PictureBox1.Image = Image.FromFile(aymen(aymen.Count - 1))
        '    Next
        'Else
        '    Dim tetx As String = My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins\text.txt")
        '    PictureBox1.Visible = False
        '    TextBox1.Visible = True
        '    TextBox1.Text = tetx
        'End If


        
    End Sub
End Class