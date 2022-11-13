Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs)
        MsgBox("Clicked!")
        'MsgBox("File: " & GlobalVariables.FILEPATH)
        'System.Diagnostics.Process.Start("notepad.exe ", GlobalVariables.FILEPATH)

    End Sub

    Private Sub Button5_Click(sender As Object, e As RibbonControlEventArgs) Handles btn_config.Click
        System.Diagnostics.Process.Start("notepad.exe ", GlobalVariables.FILEPATH)
    End Sub

    Private Sub Button6_Click(sender As Object, e As RibbonControlEventArgs) Handles btn_contact.Click
        System.Diagnostics.Process.Start(GlobalVariables.giturl)
    End Sub

    Private Sub Button4_Click(sender As Object, e As RibbonControlEventArgs)

    End Sub

    Private Sub btn_domainchecker_Click(sender As Object, e As RibbonControlEventArgs) Handles btn_domainchecker.Click
        System.Diagnostics.Process.Start(GlobalVariables.giturl)
    End Sub
End Class
