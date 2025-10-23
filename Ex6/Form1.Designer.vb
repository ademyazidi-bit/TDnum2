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
        LblNom = New Label()
        LblPrenom = New Label()
        LblNote = New Label()
        TxtNom = New TextBox()
        TxtPrenom = New TextBox()
        TxtNote = New TextBox()
        BtnAdd = New Button()
        BtnAnu = New Button()
        BtnAff = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        dgvListeEtudians = New DataGridView()
        Nom = New DataGridViewTextBoxColumn()
        Prenom = New DataGridViewTextBoxColumn()
        Note = New DataGridViewTextBoxColumn()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvListeEtudians, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblNom
        ' 
        LblNom.AutoSize = True
        LblNom.Location = New Point(50, 77)
        LblNom.Name = "LblNom"
        LblNom.Size = New Size(42, 20)
        LblNom.TabIndex = 0
        LblNom.Text = "Nom"
        ' 
        ' LblPrenom
        ' 
        LblPrenom.AutoSize = True
        LblPrenom.Location = New Point(50, 194)
        LblPrenom.Name = "LblPrenom"
        LblPrenom.Size = New Size(60, 20)
        LblPrenom.TabIndex = 2
        LblPrenom.Text = "Prenom"
        ' 
        ' LblNote
        ' 
        LblNote.AutoSize = True
        LblNote.Location = New Point(50, 290)
        LblNote.Name = "LblNote"
        LblNote.Size = New Size(42, 20)
        LblNote.TabIndex = 1
        LblNote.Text = "Note"
        ' 
        ' TxtNom
        ' 
        TxtNom.Location = New Point(178, 78)
        TxtNom.Name = "TxtNom"
        TxtNom.Size = New Size(125, 27)
        TxtNom.TabIndex = 3
        ' 
        ' TxtPrenom
        ' 
        TxtPrenom.Location = New Point(178, 187)
        TxtPrenom.Name = "TxtPrenom"
        TxtPrenom.Size = New Size(125, 27)
        TxtPrenom.TabIndex = 4
        ' 
        ' TxtNote
        ' 
        TxtNote.Location = New Point(178, 290)
        TxtNote.Name = "TxtNote"
        TxtNote.Size = New Size(125, 27)
        TxtNote.TabIndex = 5
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(390, 77)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(94, 29)
        BtnAdd.TabIndex = 6
        BtnAdd.Text = "Add"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' BtnAnu
        ' 
        BtnAnu.Location = New Point(390, 185)
        BtnAnu.Name = "BtnAnu"
        BtnAnu.Size = New Size(94, 29)
        BtnAnu.TabIndex = 7
        BtnAnu.Text = "Annuler"
        BtnAnu.UseVisualStyleBackColor = True
        ' 
        ' BtnAff
        ' 
        BtnAff.Location = New Point(390, 288)
        BtnAff.Name = "BtnAff"
        BtnAff.Size = New Size(94, 29)
        BtnAff.TabIndex = 8
        BtnAff.Text = "Afficher"
        BtnAff.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' dgvListeEtudians
        ' 
        dgvListeEtudians.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListeEtudians.Columns.AddRange(New DataGridViewColumn() {Nom, Prenom, Note})
        dgvListeEtudians.Location = New Point(582, 61)
        dgvListeEtudians.Name = "dgvListeEtudians"
        dgvListeEtudians.RowHeadersWidth = 51
        dgvListeEtudians.Size = New Size(429, 318)
        dgvListeEtudians.TabIndex = 9
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
        ' Note
        ' 
        Note.HeaderText = "Note"
        Note.MinimumWidth = 6
        Note.Name = "Note"
        Note.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1152, 450)
        Controls.Add(dgvListeEtudians)
        Controls.Add(BtnAff)
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
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvListeEtudians, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnAff As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dgvListeEtudians As DataGridView
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prenom As DataGridViewTextBoxColumn
    Friend WithEvents Note As DataGridViewTextBoxColumn

End Class
