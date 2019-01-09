Module mdlMessageBox
    Function MessageBox(varText As String, Optional varTitle As String = "", Optional var2Button As Boolean = False)
        formMessageBox.TextLabel.Text = varText

        If formMessageBox.TextLabel.Width + 20 >= formMessageBox.Width Then
            formMessageBox.Width = formMessageBox.TextLabel.Width + 100
        End If
        If formMessageBox.TextLabel.Height + 100 >= formMessageBox.Height Then
            formMessageBox.Height = formMessageBox.TextLabel.Height + 100
        End If
        formMessageBox.TextLabel.Left = (formMessageBox.Width - formMessageBox.TextLabel.Width) \ 2
        formMessageBox.OKButton.Top = (formMessageBox.Height - formMessageBox.OKButton.Height - 12)
        formMessageBox.CloseButton.Left = (formMessageBox.Width - 50)

        If var2Button = False Then
            formMessageBox.NoButton.Visible = False
            formMessageBox.OKButton.Left = (formMessageBox.Width - formMessageBox.OKButton.Width) \ 2
        Else
            formMessageBox.NoButton.Visible = True
        End If
        If varTitle = "" Then
            varTitle = "LibertyHosts Error"
        End If

        formMessageBox.TitleLabel.Text = varTitle
        formMessageBox.Show()
        Return 0
    End Function
End Module
