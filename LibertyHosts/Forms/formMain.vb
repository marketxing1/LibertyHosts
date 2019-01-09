Imports System.Threading
Public Class formMain
    Dim thGetHostsFile As Thread 'GetHosts
    Dim thPing As Thread 'GetPing
    Dim thStatistics As Thread 'GetStatus

    Private varOriginalRegion As Region = Nothing
    Private varFormDragging As Boolean = False
    Private varPointClicked As Point

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (
                                              ByVal hwnd As IntPtr,
                                              ByVal wMsg As Integer,
                                              ByVal wParam As Integer,
                                              ByVal lParam As Integer) _
                                              As Boolean
    Declare Function ReleaseCapture Lib "user32" Alias "ReleaseCapture" () As Boolean
    Const WM_SYSCOMMAND = &H112
    Const SC_MOVE = &HF010&
    Const HTCAPTION = 2

    Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
    End Sub
    Private Sub Statistics()
        Try
            'Dim varUpdateInfo As String
            'varUpdateInfo = mdlDownload.subStatistics()
            'If varUpdateInfo <> "" Then
            '    varUpdateInfo = varUpdateInfo & vbNewLine & "Click To Update"
            '    Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varUpdateInfo)
            '    Me.Invoke(New subLabelDelegate(AddressOf EnableLabel), varUpdateInfo)
            'End If
        Finally
            thStatistics.Abort()
        End Try
    End Sub
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thStatistics = New Thread(AddressOf Statistics)
        thStatistics.Start()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        End
    End Sub

    Private Sub ToolBoxButton_Click(sender As Object, e As EventArgs) Handles ToolBoxButton.Click
        formToolbox.Show()
        Me.Hide()
    End Sub

    Private Sub GetHostsButton_Click(sender As Object, e As EventArgs) Handles GetHostsButton.Click
        thGetHostsFile = New Thread(AddressOf GetHosts)
        thGetHostsFile.Start()
    End Sub

    Private Sub GetHosts()
        Try
            Dim varInfo As String
            Dim varHostsText As String
            Dim varWriteHosts As Boolean
            varInfo = "Downloading Hosts File"
            Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)

            varHostsText = mdlDownload.funcGetHosts()
            If varHostsText = "" Then
                varInfo = "Fail To Download Hosts File"
                Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)
                thGetHostsFile.Abort()
                Exit Sub
            End If

            varInfo = "Writing The Hosts File"
            Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)
            varWriteHosts = mdlFile.funcWirteHosts(varHostsText, True)

            If varWriteHosts = False Then
                varInfo = "Fail To WriteThe Hosts File"
                Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)
                thGetHostsFile.Abort()
                Exit Sub
            End If
            varInfo = "The Hosts File Has Already Changed" & vbNewLine & "Please Click On 'Check Connectivity' To Make Sure The Hosts File Is Avaliable"
            Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)

        Catch varExc As Exception
            mdlMessageBox.MessageBox(varExc.Message)
        Finally
            thGetHostsFile.Abort()
        End Try
    End Sub
    Private Delegate Sub subLabelDelegate(ByVal varString As String)

    Private Sub SetInfo(ByVal Info As String)
        Me.Label.Text = Info
        Me.Label.Left = (Me.Width - Me.Label.Width) \ 2
    End Sub
    Private Sub EnableLabel(ByVal Info As String)
        Me.Label.Enabled = Enabled
    End Sub

    Private Sub CheckHostsButton_Click(sender As Object, e As EventArgs) Handles CheckHostsButton.Click
        thPing = New Thread(AddressOf Ping)
        thPing.Start()
    End Sub

    Private Sub Ping()
        Try
            Dim varPingReply As Single
            Dim varInfo As String

            varPingReply = mdlPing.funcPing("google.com")
            If varPingReply = -1 Then
                varInfo = "Fail To Connect Google"
                Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)
            Else
                varInfo = "Success" & vbNewLine & "Latency:" & varPingReply & "Ms"
                Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)
            End If

        Catch varExc As Exception
            mdlMessageBox.MessageBox(varExc.Message)
        Finally
            thPing.Abort()
        End Try
    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label.Click
        Process.Start("https://github.com/xAsiimov/LibertyHosts/releases")
    End Sub
End Class
