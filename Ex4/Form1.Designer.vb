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
        LblEnter = New Label()
        Label2 = New Label()
        TxtRes = New TextBox()
        BtnMaj = New Button()
        BtnMin = New Button()
        BtnLon = New Button()
        BtnRem = New Button()
        BtnDec = New Button()
        TxtPh = New TextBox()
        BtnRes = New Button()
        SuspendLayout()
        ' 
        ' LblEnter
        ' 
        LblEnter.AutoSize = True
        LblEnter.Location = New Point(38, 73)
        LblEnter.Name = "LblEnter"
        LblEnter.Size = New Size(138, 20)
        LblEnter.TabIndex = 0
        LblEnter.Text = "Entrez Une Phrase : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(69, 337)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 1
        Label2.Text = "Résultat  : "
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TxtRes
        ' 
        TxtRes.Location = New Point(200, 297)
        TxtRes.Multiline = True
        TxtRes.Name = "TxtRes"
        TxtRes.Size = New Size(305, 106)
        TxtRes.TabIndex = 2
        ' 
        ' BtnMaj
        ' 
        BtnMaj.Location = New Point(69, 125)
        BtnMaj.Name = "BtnMaj"
        BtnMaj.Size = New Size(137, 66)
        BtnMaj.TabIndex = 3
        BtnMaj.Text = "Majuscules"
        BtnMaj.UseVisualStyleBackColor = True
        ' 
        ' BtnMin
        ' 
        BtnMin.Location = New Point(273, 125)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(137, 66)
        BtnMin.TabIndex = 4
        BtnMin.Text = "Minuscules"
        BtnMin.UseVisualStyleBackColor = True
        ' 
        ' BtnLon
        ' 
        BtnLon.Location = New Point(456, 125)
        BtnLon.Name = "BtnLon"
        BtnLon.Size = New Size(137, 66)
        BtnLon.TabIndex = 5
        BtnLon.Text = "Longeur"
        BtnLon.UseVisualStyleBackColor = True
        ' 
        ' BtnRem
        ' 
        BtnRem.Location = New Point(69, 206)
        BtnRem.Name = "BtnRem"
        BtnRem.Size = New Size(137, 66)
        BtnRem.TabIndex = 6
        BtnRem.Text = "Remplacer"
        BtnRem.UseVisualStyleBackColor = True
        ' 
        ' BtnDec
        ' 
        BtnDec.Location = New Point(273, 206)
        BtnDec.Name = "BtnDec"
        BtnDec.Size = New Size(137, 66)
        BtnDec.TabIndex = 7
        BtnDec.Text = "Decouper"
        BtnDec.UseVisualStyleBackColor = True
        ' 
        ' TxtPh
        ' 
        TxtPh.Location = New Point(200, 73)
        TxtPh.Name = "TxtPh"
        TxtPh.Size = New Size(305, 27)
        TxtPh.TabIndex = 8
        ' 
        ' BtnRes
        ' 
        BtnRes.Location = New Point(635, 337)
        BtnRes.Name = "BtnRes"
        BtnRes.Size = New Size(137, 66)
        BtnRes.TabIndex = 9
        BtnRes.Text = "Reset"
        BtnRes.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnRes)
        Controls.Add(TxtPh)
        Controls.Add(BtnDec)
        Controls.Add(BtnRem)
        Controls.Add(BtnLon)
        Controls.Add(BtnMin)
        Controls.Add(BtnMaj)
        Controls.Add(TxtRes)
        Controls.Add(Label2)
        Controls.Add(LblEnter)
        Name = "Form1"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblEnter As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtRes As TextBox
    Friend WithEvents BtnMaj As Button
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnLon As Button
    Friend WithEvents BtnRem As Button
    Friend WithEvents BtnDec As Button
    Friend WithEvents TxtPh As TextBox
    Friend WithEvents BtnRes As Button

End Class
