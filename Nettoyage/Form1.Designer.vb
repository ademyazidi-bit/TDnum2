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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        RbRobe = New RadioButton()
        RbPan = New RadioButton()
        RbChemise = New RadioButton()
        GroupBoxVet = New GroupBox()
        GroupBoxNett = New GroupBox()
        RbNettSec = New RadioButton()
        RbLavage = New RadioButton()
        RbRepa = New RadioButton()
        NumericUpDownArticle = New NumericUpDown()
        ChDef = New CheckBox()
        ChAnti = New CheckBox()
        GroupBoxSupp = New GroupBox()
        BrnAjou = New Button()
        btnAnn = New Button()
        DataGridView1 = New DataGridView()
        Code = New DataGridViewTextBoxColumn()
        Vetement = New DataGridViewTextBoxColumn()
        Type_de_Nettoyage = New DataGridViewTextBoxColumn()
        Supplement = New DataGridViewTextBoxColumn()
        Quantite = New DataGridViewTextBoxColumn()
        GroupBoxVet.SuspendLayout()
        GroupBoxNett.SuspendLayout()
        CType(NumericUpDownArticle, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxSupp.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 20)
        Label1.TabIndex = 0
        Label1.Text = "Choix Vetment"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(330, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 20)
        Label2.TabIndex = 1
        Label2.Text = "Type de Nettoyage"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(689, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 20)
        Label3.TabIndex = 2
        Label3.Text = "Nombre d'article"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(86, 356)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 20)
        Label4.TabIndex = 3
        Label4.Text = "Supplements"
        ' 
        ' RbRobe
        ' 
        RbRobe.AutoSize = True
        RbRobe.Location = New Point(20, 39)
        RbRobe.Name = "RbRobe"
        RbRobe.Size = New Size(65, 24)
        RbRobe.TabIndex = 4
        RbRobe.TabStop = True
        RbRobe.Text = "Robe"
        RbRobe.UseVisualStyleBackColor = True
        ' 
        ' RbPan
        ' 
        RbPan.AutoSize = True
        RbPan.Location = New Point(20, 88)
        RbPan.Name = "RbPan"
        RbPan.Size = New Size(91, 24)
        RbPan.TabIndex = 5
        RbPan.TabStop = True
        RbPan.Text = "Pantallon"
        RbPan.UseVisualStyleBackColor = True
        ' 
        ' RbChemise
        ' 
        RbChemise.AutoSize = True
        RbChemise.Location = New Point(20, 134)
        RbChemise.Name = "RbChemise"
        RbChemise.Size = New Size(86, 24)
        RbChemise.TabIndex = 6
        RbChemise.TabStop = True
        RbChemise.Text = "Chemise"
        RbChemise.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxVet
        ' 
        GroupBoxVet.Controls.Add(RbRobe)
        GroupBoxVet.Controls.Add(RbChemise)
        GroupBoxVet.Controls.Add(RbPan)
        GroupBoxVet.Location = New Point(28, 65)
        GroupBoxVet.Name = "GroupBoxVet"
        GroupBoxVet.Size = New Size(250, 206)
        GroupBoxVet.TabIndex = 7
        GroupBoxVet.TabStop = False
        GroupBoxVet.Text = "Choix Vetment"
        ' 
        ' GroupBoxNett
        ' 
        GroupBoxNett.Controls.Add(RbNettSec)
        GroupBoxNett.Controls.Add(RbLavage)
        GroupBoxNett.Controls.Add(RbRepa)
        GroupBoxNett.Location = New Point(324, 65)
        GroupBoxNett.Name = "GroupBoxNett"
        GroupBoxNett.Size = New Size(250, 206)
        GroupBoxNett.TabIndex = 8
        GroupBoxNett.TabStop = False
        GroupBoxNett.Text = "GroupBox2"
        ' 
        ' RbNettSec
        ' 
        RbNettSec.AutoSize = True
        RbNettSec.Location = New Point(20, 39)
        RbNettSec.Name = "RbNettSec"
        RbNettSec.Size = New Size(137, 24)
        RbNettSec.TabIndex = 4
        RbNettSec.TabStop = True
        RbNettSec.Text = "Nettoyage a sec"
        RbNettSec.UseVisualStyleBackColor = True
        ' 
        ' RbLavage
        ' 
        RbLavage.AutoSize = True
        RbLavage.Location = New Point(20, 88)
        RbLavage.Name = "RbLavage"
        RbLavage.Size = New Size(77, 24)
        RbLavage.TabIndex = 6
        RbLavage.TabStop = True
        RbLavage.Text = "Lavage"
        RbLavage.UseVisualStyleBackColor = True
        ' 
        ' RbRepa
        ' 
        RbRepa.AutoSize = True
        RbRepa.Location = New Point(20, 134)
        RbRepa.Name = "RbRepa"
        RbRepa.Size = New Size(101, 24)
        RbRepa.TabIndex = 5
        RbRepa.TabStop = True
        RbRepa.Text = "Repassage"
        RbRepa.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDownArticle
        ' 
        NumericUpDownArticle.Location = New Point(689, 80)
        NumericUpDownArticle.Name = "NumericUpDownArticle"
        NumericUpDownArticle.Size = New Size(150, 27)
        NumericUpDownArticle.TabIndex = 9
        ' 
        ' ChDef
        ' 
        ChDef.AutoSize = True
        ChDef.Location = New Point(6, 44)
        ChDef.Name = "ChDef"
        ChDef.Size = New Size(110, 24)
        ChDef.TabIndex = 10
        ChDef.Text = "Defroissage"
        ChDef.UseVisualStyleBackColor = True
        ' 
        ' ChAnti
        ' 
        ChAnti.AutoSize = True
        ChAnti.Location = New Point(131, 44)
        ChAnti.Name = "ChAnti"
        ChAnti.Size = New Size(98, 24)
        ChAnti.TabIndex = 11
        ChAnti.Text = "Anti tache"
        ChAnti.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxSupp
        ' 
        GroupBoxSupp.Controls.Add(ChDef)
        GroupBoxSupp.Controls.Add(ChAnti)
        GroupBoxSupp.Location = New Point(86, 421)
        GroupBoxSupp.Name = "GroupBoxSupp"
        GroupBoxSupp.Size = New Size(250, 125)
        GroupBoxSupp.TabIndex = 12
        GroupBoxSupp.TabStop = False
        GroupBoxSupp.Text = "GroupBox3"
        ' 
        ' BrnAjou
        ' 
        BrnAjou.Font = New Font("Segoe UI", 13F)
        BrnAjou.Location = New Point(969, 80)
        BrnAjou.Name = "BrnAjou"
        BrnAjou.Size = New Size(94, 48)
        BrnAjou.TabIndex = 13
        BrnAjou.Text = "Ajouter"
        BrnAjou.UseVisualStyleBackColor = True
        ' 
        ' btnAnn
        ' 
        btnAnn.Font = New Font("Segoe UI", 13F)
        btnAnn.Location = New Point(1109, 80)
        btnAnn.Name = "btnAnn"
        btnAnn.Size = New Size(107, 48)
        btnAnn.TabIndex = 14
        btnAnn.Text = "Annuler"
        btnAnn.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Code, Vetement, Type_de_Nettoyage, Supplement, Quantite})
        DataGridView1.Location = New Point(492, 370)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(674, 260)
        DataGridView1.TabIndex = 15
        ' 
        ' Code
        ' 
        Code.HeaderText = "Code"
        Code.MinimumWidth = 6
        Code.Name = "Code"
        Code.Width = 125
        ' 
        ' Vetement
        ' 
        Vetement.HeaderText = "Vetement"
        Vetement.MinimumWidth = 6
        Vetement.Name = "Vetement"
        Vetement.Width = 125
        ' 
        ' Type_de_Nettoyage
        ' 
        Type_de_Nettoyage.HeaderText = "Type_de_Nettoyage"
        Type_de_Nettoyage.MinimumWidth = 6
        Type_de_Nettoyage.Name = "Type_de_Nettoyage"
        Type_de_Nettoyage.Width = 125
        ' 
        ' Supplement
        ' 
        Supplement.HeaderText = "Supplement"
        Supplement.MinimumWidth = 6
        Supplement.Name = "Supplement"
        Supplement.Width = 125
        ' 
        ' Quantite
        ' 
        Quantite.HeaderText = "Quantite"
        Quantite.MinimumWidth = 6
        Quantite.Name = "Quantite"
        Quantite.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1368, 715)
        Controls.Add(DataGridView1)
        Controls.Add(btnAnn)
        Controls.Add(BrnAjou)
        Controls.Add(GroupBoxSupp)
        Controls.Add(NumericUpDownArticle)
        Controls.Add(GroupBoxNett)
        Controls.Add(Label1)
        Controls.Add(GroupBoxVet)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Form1"
        Text = "Form1"
        GroupBoxVet.ResumeLayout(False)
        GroupBoxVet.PerformLayout()
        GroupBoxNett.ResumeLayout(False)
        GroupBoxNett.PerformLayout()
        CType(NumericUpDownArticle, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxSupp.ResumeLayout(False)
        GroupBoxSupp.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RbRobe As RadioButton
    Friend WithEvents RbPan As RadioButton
    Friend WithEvents RbChemise As RadioButton
    Friend WithEvents GroupBoxVet As GroupBox
    Friend WithEvents GroupBoxNett As GroupBox
    Friend WithEvents RbNettSec As RadioButton
    Friend WithEvents RbLavage As RadioButton
    Friend WithEvents RbRepa As RadioButton
    Friend WithEvents NumericUpDownArticle As NumericUpDown
    Friend WithEvents ChDef As CheckBox
    Friend WithEvents ChAnti As CheckBox
    Friend WithEvents GroupBoxSupp As GroupBox
    Friend WithEvents BrnAjou As Button
    Friend WithEvents btnAnn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Vetement As DataGridViewTextBoxColumn
    Friend WithEvents Type_de_Nettoyage As DataGridViewTextBoxColumn
    Friend WithEvents Supplement As DataGridViewTextBoxColumn
    Friend WithEvents Quantite As DataGridViewTextBoxColumn

End Class
