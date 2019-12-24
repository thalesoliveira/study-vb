Imports System.IO
Module Module1

    Sub Main()
        Executa("C:\Users\Ikhon\Desktop\fileSystemWatcher")
    End Sub

    Private Sub Executa(ByVal path As String)
        If String.IsNullOrWhiteSpace(path) Then
            Console.WriteLine("Informe um path válido")
            Return
        End If

        Dim fsw As New FileSystemWatcher

        With fsw
            .Path = path
            .NotifyFilter = NotifyFilters.LastAccess Or NotifyFilters.LastWrite Or NotifyFilters.FileName Or NotifyFilters.DirectoryName
            .Filter = "*.txt"
        End With

        AddHandler fsw.Changed, AddressOf OnChanged
        AddHandler fsw.Created, AddressOf OnCreated
        AddHandler fsw.Deleted, AddressOf OnDeleted
        AddHandler fsw.Renamed, AddressOf OnRenamed

        fsw.EnableRaisingEvents = True
        Console.WriteLine("Monitorando o diretório C:\Users\Ikhon\Desktop\fileSystemWatcher")
        Console.WriteLine(" ************************************************************************* ")
        Console.WriteLine(" Pressione 'q' para encerrar o watcher")
        While Chr(Console.Read()) <> "q"
        End While

    End Sub

    Private Sub OnRenamed(sender As Object, e As RenamedEventArgs)
        Console.WriteLine("Arquivo : {0} renomeado para {1} ", e.OldFullPath, e.FullPath)
    End Sub

    Private Sub OnDeleted(sender As Object, e As FileSystemEventArgs)
        Console.WriteLine("Arquivo Removido: " & e.FullPath & " Em: " & DateTime.Now)
    End Sub

    Private Sub OnCreated(sender As Object, e As FileSystemEventArgs)
        Console.WriteLine("Arquivo Criado: " & e.FullPath & " " & e.ChangeType)
    End Sub

    Private Sub OnChanged(sender As Object, e As FileSystemEventArgs)
        Console.WriteLine("Arquivo Modificado: " & e.FullPath & " " & e.ChangeType)
    End Sub
End Module
