<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Confform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Confform))
        Me.btn_send = New System.Windows.Forms.Button()
        Me.btn_send_and_remember = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.lbl_list_of_domains = New System.Windows.Forms.Label()
        Me.lbl_confirmation_question = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_send
        '
        Me.btn_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_send.Location = New System.Drawing.Point(75, 18)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(142, 50)
        Me.btn_send.TabIndex = 2
        Me.btn_send.Text = "Send"
        Me.ToolTip1.SetToolTip(Me.btn_send, "Send this time. Prompt me again for future emails")
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'btn_send_and_remember
        '
        Me.btn_send_and_remember.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_send_and_remember.Location = New System.Drawing.Point(236, 18)
        Me.btn_send_and_remember.Name = "btn_send_and_remember"
        Me.btn_send_and_remember.Size = New System.Drawing.Size(142, 50)
        Me.btn_send_and_remember.TabIndex = 3
        Me.btn_send_and_remember.Text = "Send and Remember"
        Me.ToolTip2.SetToolTip(Me.btn_send_and_remember, "Send this time. Send without prompting next time for this domains")
        Me.btn_send_and_remember.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(396, 18)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(142, 50)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Cancel"
        Me.ToolTip3.SetToolTip(Me.btn_cancel, "Don't Send. Return to message")
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'lbl_list_of_domains
        '
        Me.lbl_list_of_domains.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_list_of_domains.Location = New System.Drawing.Point(28, 28)
        Me.lbl_list_of_domains.Name = "lbl_list_of_domains"
        Me.lbl_list_of_domains.Size = New System.Drawing.Size(511, 72)
        Me.lbl_list_of_domains.TabIndex = 4
        Me.lbl_list_of_domains.Text = "Label1"
        '
        'lbl_confirmation_question
        '
        Me.lbl_confirmation_question.AutoSize = True
        Me.lbl_confirmation_question.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirmation_question.Location = New System.Drawing.Point(28, 110)
        Me.lbl_confirmation_question.Name = "lbl_confirmation_question"
        Me.lbl_confirmation_question.Size = New System.Drawing.Size(59, 20)
        Me.lbl_confirmation_question.TabIndex = 5
        Me.lbl_confirmation_question.Text = "Label2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_send_and_remember)
        Me.Panel1.Controls.Add(Me.btn_send)
        Me.Panel1.Location = New System.Drawing.Point(-2, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 91)
        Me.Panel1.TabIndex = 6
        '
        'Confform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(562, 247)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_confirmation_question)
        Me.Controls.Add(Me.lbl_list_of_domains)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Confform"
        Me.Text = "Confirmation"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_send As Windows.Forms.Button
    Friend WithEvents btn_send_and_remember As Windows.Forms.Button
    Friend WithEvents btn_cancel As Windows.Forms.Button
    Friend WithEvents lbl_list_of_domains As Windows.Forms.Label
    Friend WithEvents lbl_confirmation_question As Windows.Forms.Label
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As Windows.Forms.ToolTip
    Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
