Imports System.IO
Module mdlFile
    Dim varSysRoot As String = Environ("SystemRoot")
    Dim varHostsDir As String = varSysRoot & "\System32\drivers\etc\hosts"
    Function funcReadHosts() As String
        Try
            Dim varStr As New IO.StreamReader(varHostsDir, Text.Encoding.Default)
            Dim varText As String
            If File.Exists(varHostsDir) = True Then
                varText = varStr.ReadToEnd()
            Else
                File.Create(varHostsDir)
                varText = ""
            End If
            varStr.Close()
            Return varText
        Catch varExc As Exception
            Return False
        mdlMessageBox.MessageBox(varExc.Message)
        End Try
    End Function

    Function funcWirteHosts(varText As String, varShell As Boolean) As Boolean
        Try
            Dim varStr As New IO.StreamWriter(varHostsDir)
            If File.Exists(varHostsDir) = True Then
                'Create backup file (hosts-yyyy-MM-dd-HH-mm-ss.bak)
                Dim varNow As String = Now.ToString("-yyyy-MM-dd-HH-mm-ss.bak")
                File.Copy(varHostsDir, varHostsDir & varNow)
                varStr.WriteLine(varText)
            Else

                File.Create(varHostsDir)
                varStr.WriteLine(varText)
            End If
            varStr.Close()

            If varShell = True Then
                'Flush the dns cache
                Shell("cmd.exe /c ipconfig/flushdns", AppWinStyle.Hide)
            End If

            Return True
        Catch varExc As Exception
            mdlMessageBox.MessageBox(varExc.Message)
            Return False
        End Try
    End Function

    Function funcGetHostsDir() As String
        Return varHostsDir
    End Function
End Module
