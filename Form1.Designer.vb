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
        Label1 = New Label()
        Label2 = New Label()
        txtdl = New TextBox()
        txtal = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(205, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 54)
        Label1.TabIndex = 0
        Label1.Text = "Tính Năm Âm Lịch"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(135, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 21)
        Label2.TabIndex = 0
        Label2.Text = "Năm Dương Lịch"
        ' 
        ' txtdl
        ' 
        txtdl.Location = New Point(135, 237)
        txtdl.Name = "txtdl"
        txtdl.Size = New Size(128, 23)
        txtdl.TabIndex = 1
        ' 
        ' txtal
        ' 
        txtal.Location = New Point(516, 237)
        txtal.Name = "txtal"
        txtal.Size = New Size(104, 23)
        txtal.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(362, 236)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "==>"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(516, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 21)
        Label3.TabIndex = 0
        Label3.Text = "Năm Âm Lịch"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(txtal)
        Controls.Add(txtdl)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdl As TextBox
    Friend WithEvents txtal As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
