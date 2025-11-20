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
        BtnAjou = New Button()
        BtnAnn = New Button()
        TxtCode = New TextBox()
        TxtDes = New TextBox()
        TxtPrix = New TextBox()
        TxtQt = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        DataGridView = New DataGridView()
        Code = New DataGridViewTextBoxColumn()
        Designation = New DataGridViewTextBoxColumn()
        Prix = New DataGridViewTextBoxColumn()
        Quantite = New DataGridViewTextBoxColumn()
        Somme = New DataGridViewTextBoxColumn()
        Total = New DataGridViewTextBoxColumn()
        BtnAff = New Button()
        BtnMax = New Button()
        BtnMin = New Button()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnAjou
        ' 
        BtnAjou.Location = New Point(417, 70)
        BtnAjou.Name = "BtnAjou"
        BtnAjou.Size = New Size(94, 29)
        BtnAjou.TabIndex = 0
        BtnAjou.Text = "Ajouter"
        BtnAjou.UseVisualStyleBackColor = True
        ' 
        ' BtnAnn
        ' 
        BtnAnn.Location = New Point(417, 229)
        BtnAnn.Name = "BtnAnn"
        BtnAnn.Size = New Size(94, 29)
        BtnAnn.TabIndex = 1
        BtnAnn.Text = "Anuuler"
        BtnAnn.UseVisualStyleBackColor = True
        ' 
        ' TxtCode
        ' 
        TxtCode.Location = New Point(216, 70)
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(125, 27)
        TxtCode.TabIndex = 2
        ' 
        ' TxtDes
        ' 
        TxtDes.Location = New Point(216, 157)
        TxtDes.Name = "TxtDes"
        TxtDes.Size = New Size(125, 27)
        TxtDes.TabIndex = 3
        ' 
        ' TxtPrix
        ' 
        TxtPrix.Location = New Point(216, 257)
        TxtPrix.Name = "TxtPrix"
        TxtPrix.Size = New Size(125, 27)
        TxtPrix.TabIndex = 4
        ' 
        ' TxtQt
        ' 
        TxtQt.Location = New Point(216, 344)
        TxtQt.Name = "TxtQt"
        TxtQt.Size = New Size(125, 27)
        TxtQt.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 20)
        Label1.TabIndex = 6
        Label1.Text = "Code"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(85, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 7
        Label2.Text = "Designation"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(85, 264)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 20)
        Label3.TabIndex = 8
        Label3.Text = "Prix"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(85, 351)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 9
        Label4.Text = "Quantite"
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Columns.AddRange(New DataGridViewColumn() {Code, Designation, Prix, Quantite, Somme, Total})
        DataGridView.Location = New Point(532, 70)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 51
        DataGridView.Size = New Size(796, 373)
        DataGridView.TabIndex = 10
        ' 
        ' Code
        ' 
        Code.HeaderText = "Code"
        Code.MinimumWidth = 6
        Code.Name = "Code"
        Code.Width = 125
        ' 
        ' Designation
        ' 
        Designation.HeaderText = "Designation"
        Designation.MinimumWidth = 6
        Designation.Name = "Designation"
        Designation.Width = 125
        ' 
        ' Prix
        ' 
        Prix.HeaderText = "Prix"
        Prix.MinimumWidth = 6
        Prix.Name = "Prix"
        Prix.Width = 125
        ' 
        ' Quantite
        ' 
        Quantite.HeaderText = "Quantite"
        Quantite.MinimumWidth = 6
        Quantite.Name = "Quantite"
        Quantite.Width = 125
        ' 
        ' Somme
        ' 
        Somme.HeaderText = "Somme"
        Somme.MinimumWidth = 6
        Somme.Name = "Somme"
        Somme.Width = 125
        ' 
        ' Total
        ' 
        Total.HeaderText = "Total"
        Total.MinimumWidth = 6
        Total.Name = "Total"
        Total.Width = 125
        ' 
        ' BtnAff
        ' 
        BtnAff.Location = New Point(417, 342)
        BtnAff.Name = "BtnAff"
        BtnAff.Size = New Size(94, 29)
        BtnAff.TabIndex = 11
        BtnAff.Text = "Afficher"
        BtnAff.UseVisualStyleBackColor = True
        ' 
        ' BtnMax
        ' 
        BtnMax.Location = New Point(109, 431)
        BtnMax.Name = "BtnMax"
        BtnMax.Size = New Size(94, 29)
        BtnMax.TabIndex = 12
        BtnMax.Text = "Max"
        BtnMax.UseVisualStyleBackColor = True
        ' 
        ' BtnMin
        ' 
        BtnMin.Location = New Point(272, 431)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(94, 29)
        BtnMin.TabIndex = 13
        BtnMin.Text = "Min"
        BtnMin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1340, 615)
        Controls.Add(BtnMin)
        Controls.Add(BtnMax)
        Controls.Add(BtnAff)
        Controls.Add(DataGridView)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxtQt)
        Controls.Add(TxtPrix)
        Controls.Add(TxtDes)
        Controls.Add(TxtCode)
        Controls.Add(BtnAnn)
        Controls.Add(BtnAjou)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnAjou As Button
    Friend WithEvents BtnAnn As Button
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents TxtDes As TextBox
    Friend WithEvents TxtPrix As TextBox
    Friend WithEvents TxtQt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents BtnAff As Button
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Designation As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents Quantite As DataGridViewTextBoxColumn
    Friend WithEvents Somme As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents BtnMax As Button
    Friend WithEvents BtnMin As Button

End Class
