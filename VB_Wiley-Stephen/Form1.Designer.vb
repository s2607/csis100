﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.User_Text = New System.Windows.Forms.TextBox()
        Me.Password_Text = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Error_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'User_Text
        '
        Me.User_Text.Location = New System.Drawing.Point(86, 13)
        Me.User_Text.Name = "User_Text"
        Me.User_Text.Size = New System.Drawing.Size(186, 20)
        Me.User_Text.TabIndex = 2
        '
        'Password_Text
        '
        Me.Password_Text.Location = New System.Drawing.Point(86, 40)
        Me.Password_Text.Name = "Password_Text"
        Me.Password_Text.Size = New System.Drawing.Size(186, 20)
        Me.Password_Text.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Error_Label
        '
        Me.Error_Label.AutoSize = True
        Me.Error_Label.ForeColor = System.Drawing.Color.Red
        Me.Error_Label.Location = New System.Drawing.Point(17, 76)
        Me.Error_Label.Name = "Error_Label"
        Me.Error_Label.Size = New System.Drawing.Size(0, 13)
        Me.Error_Label.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 132)
        Me.Controls.Add(Me.Error_Label)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Password_Text)
        Me.Controls.Add(Me.User_Text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents User_Text As System.Windows.Forms.TextBox
    Friend WithEvents Password_Text As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Error_Label As System.Windows.Forms.Label

End Class
