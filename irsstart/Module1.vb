Imports System.Text
Module Module1

    Sub Main()
        Console.WriteLine("Checking for update....")
        Dim myversion As String = My.Computer.FileSystem.ReadAllText("\\savfils03\softwareupdate$\IRSUpdater\version.txt", Encoding.UTF8)
        If IO.Directory.Exists("\\savfils03\softwareupdate$\IRSUpdater\" + myversion) = True Then
            'code for update here
            Console.WriteLine("Updating IRS....")
            My.Computer.FileSystem.CopyDirectory("\\savfils03\softwareupdate$\IRSUpdater\" + myversion, ".\", True)

        End If
        Console.WriteLine("Executing " + My.Application.Info.DirectoryPath + "\SVIRS.exe .....")

        Process.Start(My.Application.Info.DirectoryPath + "\SVIRS.exe")
    End Sub

End Module
