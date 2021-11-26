Imports System.Windows.Forms
Imports System.IO

Module ExtOpn

    <STAThread()>
    Sub Main()
        Console.WriteLine("@ExtOpn -> (Made by Jhin Scripter)")
        Dim fdlg As New OpenFileDialog With {
            .FileName = "",
            .DefaultExt = ".exe",
            .Filter = "External CSGO Cheat|*.exe",
            .Multiselect = True,
            .RestoreDirectory = True
        }

        Dim result? As Boolean = fdlg.ShowDialog()

        For Each path In fdlg.FileNames
            Try
                Dim fnm = System.IO.Path.GetFileName(fdlg.FileName)
                System.Diagnostics.Process.Start(path)
                Dim x As Integer
                Console.WriteLine("Loading the file...")
                If System.IO.File.Exists("C:\Windows\printer.exe") = True Then
                    System.IO.File.Delete("C:\Windows\printer.exe")
                Else
                    My.Computer.FileSystem.CopyFile(path, "C:\Windows\printer.exe")
                    Console.WriteLine("Done!")
                    Threading.Thread.Sleep(500)
                    System.Diagnostics.Process.Start("C:\Windows\printer.exe")
                    Console.WriteLine("Enjoy :)")
                    Console.ReadLine()
                End If
            Catch ex As Exception
                MsgBox("Run as administrator!")
            End Try
        Next
    End Sub

End Module
