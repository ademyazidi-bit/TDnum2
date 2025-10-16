<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        LblCode = New Label()
        LblPrix = New Label()
        LblDes = New Label()
        LblQt = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        TxtCode = New TextBox()
        TxtPrix = New TextBox()
        TxtDes = New TextBox()
        TxtQt = New TextBox()
        BtnAjou = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' LblCode
        ' 
        LblCode.AutoSize = True
        LblCode.Location = New Point(122, 54)
        LblCode.Name = "LblCode"
        LblCode.Size = New Size(44, 20)
        LblCode.TabIndex = 0
        LblCode.Text = "Code"
        ' 
        ' LblPrix
        ' 
        LblPrix.AutoSize = True
        LblPrix.Location = New Point(122, 267)
        LblPrix.Name = "LblPrix"
        LblPrix.Size = New Size(33, 20)
        LblPrix.TabIndex = 1
        LblPrix.Text = "Prix"
        ' 
        ' LblDes
        ' 
        LblDes.AutoSize = True
        LblDes.Location = New Point(122, 168)
        LblDes.Name = "LblDes"
        LblDes.Size = New Size(89, 20)
        LblDes.TabIndex = 2
        LblDes.Text = "Designation"
        ' 
        ' LblQt
        ' 
        LblQt.AutoSize = True
        LblQt.Location = New Point(122, 375)
        LblQt.Name = "LblQt"
        LblQt.Size = New Size(66, 20)
        LblQt.TabIndex = 3
        LblQt.Text = "Quantite"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' TxtCode
        ' 
        TxtCode.Location = New Point(270, 54)
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(125, 27)
        TxtCode.TabIndex = 5
        ' 
        ' TxtPrix
        ' 
        TxtPrix.Location = New Point(270, 269)
        TxtPrix.Name = "TxtPrix"
        TxtPrix.Size = New Size(125, 27)
        TxtPrix.TabIndex = 6
        ' 
        ' TxtDes
        ' 
        TxtDes.Location = New Point(270, 168)
        TxtDes.Name = "TxtDes"
        TxtDes.Size = New Size(125, 27)
        TxtDes.TabIndex = 7
        ' 
        ' TxtQt
        ' 
        TxtQt.Location = New Point(270, 368)
        TxtQt.Name = "TxtQt"
        TxtQt.Size = New Size(125, 27)
        TxtQt.TabIndex = 8
        ' 
        ' BtnAjou
        ' 
        BtnAjou.Location = New Point(543, 86)
        BtnAjou.Name = "BtnAjou"
        BtnAjou.Size = New Size(168, 68)
        BtnAjou.TabIndex = 10
        BtnAjou.Text = "Ajouter"
        BtnAjou.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(543, 213)
        Button2.Name = "Button2"
        Button2.Size = New Size(168, 68)
        Button2.TabIndex = 11
        Button2.Text = "Annuler"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(BtnAjou)
        Controls.Add(TxtQt)
        Controls.Add(TxtDes)
        Controls.Add(TxtPrix)
        Controls.Add(TxtCode)
        Controls.Add(LblQt)
        Controls.Add(LblDes)
        Controls.Add(LblPrix)
        Controls.Add(LblCode)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblCode As Label
    Friend WithEvents LblPrix As Label
    Friend WithEvents LblDes As Label
    Friend WithEvents LblQt As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents TxtPrix As TextBox
    Friend WithEvents TxtDes As TextBox
    Friend WithEvents TxtQt As TextBox
    Friend WithEvents BtnAjou As Button
    Friend WithEvents Button2 As Button

End Class
