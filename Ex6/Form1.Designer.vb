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
        LblNom = New Label()
        LblPrenom = New Label()
        LblNote = New Label()
        TxtNom = New TextBox()
        TxtPrenom = New TextBox()
        TxtNote = New TextBox()
        BtnAdd = New Button()
        BtnAnu = New Button()
        SuspendLayout()
        ' 
        ' LblNom
        ' 
        LblNom.AutoSize = True
        LblNom.Location = New Point(178, 97)
        LblNom.Name = "LblNom"
        LblNom.Size = New Size(42, 20)
        LblNom.TabIndex = 0
        LblNom.Text = "Nom"
        ' 
        ' LblPrenom
        ' 
        LblPrenom.AutoSize = True
        LblPrenom.Location = New Point(178, 203)
        LblPrenom.Name = "LblPrenom"
        LblPrenom.Size = New Size(60, 20)
        LblPrenom.TabIndex = 2
        LblPrenom.Text = "Prenom"
        ' 
        ' LblNote
        ' 
        LblNote.AutoSize = True
        LblNote.Location = New Point(178, 283)
        LblNote.Name = "LblNote"
        LblNote.Size = New Size(42, 20)
        LblNote.TabIndex = 1
        LblNote.Text = "Note"
        ' 
        ' TxtNom
        ' 
        TxtNom.Location = New Point(340, 97)
        TxtNom.Name = "TxtNom"
        TxtNom.Size = New Size(125, 27)
        TxtNom.TabIndex = 3
        ' 
        ' TxtPrenom
        ' 
        TxtPrenom.Location = New Point(340, 203)
        TxtPrenom.Name = "TxtPrenom"
        TxtPrenom.Size = New Size(125, 27)
        TxtPrenom.TabIndex = 4
        ' 
        ' TxtNote
        ' 
        TxtNote.Location = New Point(340, 283)
        TxtNote.Name = "TxtNote"
        TxtNote.Size = New Size(125, 27)
        TxtNote.TabIndex = 5
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(639, 135)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(94, 29)
        BtnAdd.TabIndex = 6
        BtnAdd.Text = "Add"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' BtnAnu
        ' 
        BtnAnu.Location = New Point(639, 234)
        BtnAnu.Name = "BtnAnu"
        BtnAnu.Size = New Size(94, 29)
        BtnAnu.TabIndex = 7
        BtnAnu.Text = "Annuler"
        BtnAnu.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnAnu)
        Controls.Add(BtnAdd)
        Controls.Add(TxtNote)
        Controls.Add(TxtPrenom)
        Controls.Add(TxtNom)
        Controls.Add(LblPrenom)
        Controls.Add(LblNote)
        Controls.Add(LblNom)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblNom As Label
    Friend WithEvents LblPrenom As Label
    Friend WithEvents LblNote As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtPrenom As TextBox
    Friend WithEvents TxtNote As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnAnu As Button

End Class
