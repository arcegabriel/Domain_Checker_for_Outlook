Public Class Confform
    Public Property TextLabel As String
    Public Property TextLabel2 As String
    Public Property selectionclicked As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        selectionclicked = 1
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Confform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = TextLabel
        Label2.Text = TextLabel2
        selectionclicked = 3


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        selectionclicked = 2
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        selectionclicked = 3
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As Windows.Forms.PopupEventArgs)
    End Sub
End Class