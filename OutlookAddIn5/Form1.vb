Public Class Confform
    Public Property TextLabel As String
    Public Property TextLabel2 As String
    Public Property selectionclicked As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        selectionclicked = 1
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_send_and_remember.Click
        selectionclicked = 2
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        selectionclicked = 3
        Me.Hide()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lbl_list_of_domains.Click

    End Sub

    Private Sub Confform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_list_of_domains.Text = TextLabel
        lbl_confirmation_question.Text = TextLabel2
        selectionclicked = 3


    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_confirmation_question.Click

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As Windows.Forms.PopupEventArgs)
    End Sub
End Class