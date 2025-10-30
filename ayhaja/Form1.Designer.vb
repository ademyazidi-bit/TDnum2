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
        TxtNom = New TextBox()
        TxtPrenom = New TextBox()
        BtnAjou = New Button()
        BtnAnn = New Button()
        DataGridView2 = New DataGridView()
        Code = New DataGridViewTextBoxColumn()
        Nom = New DataGridViewTextBoxColumn()
        Prenom = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        NumAge = New NumericUpDown()
        Label4 = New Label()
        lblDate = New Label()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAge, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(134, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(134, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 1
        Label2.Text = "Prenom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(134, 277)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 20)
        Label3.TabIndex = 2
        Label3.Text = "Age"
        ' 
        ' TxtNom
        ' 
        TxtNom.Location = New Point(275, 92)
        TxtNom.Name = "TxtNom"
        TxtNom.Size = New Size(125, 27)
        TxtNom.TabIndex = 3
        ' 
        ' TxtPrenom
        ' 
        TxtPrenom.Location = New Point(275, 182)
        TxtPrenom.Name = "TxtPrenom"
        TxtPrenom.Size = New Size(125, 27)
        TxtPrenom.TabIndex = 4
        ' 
        ' BtnAjou
        ' 
        BtnAjou.Location = New Point(118, 402)
        BtnAjou.Name = "BtnAjou"
        BtnAjou.Size = New Size(94, 29)
        BtnAjou.TabIndex = 6
        BtnAjou.Text = "Ajouter"
        BtnAjou.UseVisualStyleBackColor = True
        ' 
        ' BtnAnn
        ' 
        BtnAnn.Location = New Point(342, 402)
        BtnAnn.Name = "BtnAnn"
        BtnAnn.Size = New Size(94, 29)
        BtnAnn.TabIndex = 7
        BtnAnn.Text = "Annuler"
        BtnAnn.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Code, Nom, Prenom, Age})
        DataGridView2.Location = New Point(658, 116)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(480, 280)
        DataGridView2.TabIndex = 9
        ' 
        ' Code
        ' 
        Code.HeaderText = "Code"
        Code.MinimumWidth = 6
        Code.Name = "Code"
        Code.Width = 125
        ' 
        ' Nom
        ' 
        Nom.HeaderText = "Nom"
        Nom.MinimumWidth = 6
        Nom.Name = "Nom"
        Nom.Width = 125
        ' 
        ' Prenom
        ' 
        Prenom.HeaderText = "Prenom"
        Prenom.MinimumWidth = 6
        Prenom.Name = "Prenom"
        Prenom.Width = 125
        ' 
        ' Age
        ' 
        Age.HeaderText = "Age"
        Age.MinimumWidth = 6
        Age.Name = "Age"
        Age.Width = 125
        ' 
        ' NumAge
        ' 
        NumAge.Location = New Point(275, 277)
        NumAge.Name = "NumAge"
        NumAge.Size = New Size(150, 27)
        NumAge.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F)
        Label4.Location = New Point(134, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(433, 46)
        Label4.TabIndex = 11
        Label4.Text = "Ajouter un Nouveay patient"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(795, 32)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(0, 20)
        lblDate.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveBorder
        ClientSize = New Size(1262, 597)
        Controls.Add(lblDate)
        Controls.Add(Label4)
        Controls.Add(NumAge)
        Controls.Add(DataGridView2)
        Controls.Add(BtnAnn)
        Controls.Add(BtnAjou)
        Controls.Add(TxtPrenom)
        Controls.Add(TxtNom)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAge, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtPrenom As TextBox
    Friend WithEvents BtnAjou As Button
    Friend WithEvents BtnAnn As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prenom As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents NumAge As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDate As Label

End Class
