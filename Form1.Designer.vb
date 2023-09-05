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
        btnResult = New Button()
        Label1 = New Label()
        txtMark = New TextBox()
        SuspendLayout()
        ' 
        ' btnResult
        ' 
        btnResult.Location = New Point(187, 213)
        btnResult.Name = "btnResult"
        btnResult.Size = New Size(94, 29)
        btnResult.TabIndex = 0
        btnResult.Text = "Results"
        btnResult.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(76, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter Mark"
        ' 
        ' txtMark
        ' 
        txtMark.Location = New Point(204, 140)
        txtMark.Name = "txtMark"
        txtMark.Size = New Size(125, 27)
        txtMark.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtMark)
        Controls.Add(Label1)
        Controls.Add(btnResult)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnResult As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMark As TextBox
End Class
