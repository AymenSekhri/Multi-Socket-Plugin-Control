Public Class Victim
    Dim WithEvents p As New Timer
    Dim WithEvents n As New Timer
    Public A, B, C, D As String
    Dim index As Double = 0.7
    Private Sub Victim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        index = 0.7
        Me.Opacity = index
        Me.Left = My.Computer.Screen.Bounds.Width - Me.Width
        Me.Top = My.Computer.Screen.Bounds.Height - Me.Height - 40
        Label2.Text = A
        Label3.Text = B
        Label4.Text = C
        Label5.Text = D
        p.Interval = 3000
        p.Start()
    End Sub
    Sub x() Handles p.Tick
        p.Stop()
        n.Interval = 50
        n.Start()
    End Sub
    Sub fd() Handles n.Tick
        index = index - 0.05
        Me.Opacity = index
        If index <= 0 Then
            p.Dispose()
            n.Dispose()
            Me.Dispose()
            Me.Close()
        End If
    End Sub
End Class