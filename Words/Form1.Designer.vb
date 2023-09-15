<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtAddButton = New Button()
        Label1 = New Label()
        txtText = New TextBox()
        txtListBox1 = New ListBox()
        txtLabel2 = New Label()
        txtToUpper = New RadioButton()
        GroupBox1 = New GroupBox()
        txtToLower = New RadioButton()
        GroupBox2 = New GroupBox()
        txtToBlue = New RadioButton()
        txtToPurple = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtAddButton
        ' 
        txtAddButton.Location = New Point(394, 106)
        txtAddButton.Name = "txtAddButton"
        txtAddButton.Size = New Size(254, 34)
        txtAddButton.TabIndex = 0
        txtAddButton.Text = "Add"
        txtAddButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(69, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter a word:"
        ' 
        ' txtText
        ' 
        txtText.Location = New Point(69, 49)
        txtText.Name = "txtText"
        txtText.Size = New Size(279, 31)
        txtText.TabIndex = 2
        ' 
        ' txtListBox1
        ' 
        txtListBox1.FormattingEnabled = True
        txtListBox1.ItemHeight = 25
        txtListBox1.Location = New Point(83, 149)
        txtListBox1.Name = "txtListBox1"
        txtListBox1.Size = New Size(189, 154)
        txtListBox1.TabIndex = 3
        ' 
        ' txtLabel2
        ' 
        txtLabel2.AutoSize = True
        txtLabel2.BackColor = SystemColors.ButtonHighlight
        txtLabel2.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point)
        txtLabel2.Location = New Point(376, 257)
        txtLabel2.Name = "txtLabel2"
        txtLabel2.Size = New Size(139, 46)
        txtLabel2.TabIndex = 4
        txtLabel2.Text = "Label2"
        ' 
        ' txtToUpper
        ' 
        txtToUpper.AutoSize = True
        txtToUpper.Location = New Point(6, 30)
        txtToUpper.Name = "txtToUpper"
        txtToUpper.Size = New Size(109, 29)
        txtToUpper.TabIndex = 6
        txtToUpper.TabStop = True
        txtToUpper.Text = "To Upper"
        txtToUpper.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtToLower)
        GroupBox1.Controls.Add(txtToUpper)
        GroupBox1.Location = New Point(69, 357)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 150)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Case"
        ' 
        ' txtToLower
        ' 
        txtToLower.AutoSize = True
        txtToLower.Location = New Point(6, 72)
        txtToLower.Name = "txtToLower"
        txtToLower.Size = New Size(107, 29)
        txtToLower.TabIndex = 7
        txtToLower.TabStop = True
        txtToLower.Text = "To Lower"
        txtToLower.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtToBlue)
        GroupBox2.Controls.Add(txtToPurple)
        GroupBox2.Location = New Point(461, 355)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(300, 150)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Colour"
        ' 
        ' txtToBlue
        ' 
        txtToBlue.AutoSize = True
        txtToBlue.Location = New Point(17, 74)
        txtToBlue.Name = "txtToBlue"
        txtToBlue.Size = New Size(70, 29)
        txtToBlue.TabIndex = 1
        txtToBlue.TabStop = True
        txtToBlue.Text = "Blue"
        txtToBlue.UseVisualStyleBackColor = True
        ' 
        ' txtToPurple
        ' 
        txtToPurple.AutoSize = True
        txtToPurple.Location = New Point(17, 29)
        txtToPurple.Name = "txtToPurple"
        txtToPurple.Size = New Size(87, 29)
        txtToPurple.TabIndex = 0
        txtToPurple.TabStop = True
        txtToPurple.Text = "Purple"
        txtToPurple.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 532)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(txtLabel2)
        Controls.Add(txtListBox1)
        Controls.Add(txtText)
        Controls.Add(Label1)
        Controls.Add(txtAddButton)
        Name = "Form1"
        Text = "Words"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtAddButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtText As TextBox
    Friend WithEvents txtListBox1 As ListBox
    Friend WithEvents txtLabel2 As Label
    Friend WithEvents txtToUpper As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtToLower As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtToBlue As RadioButton
    Friend WithEvents txtToPurple As RadioButton
End Class
