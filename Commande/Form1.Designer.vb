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
        ChFromage = New CheckBox()
        Chfrites = New CheckBox()
        ChDessert = New CheckBox()
        RbPizza = New RadioButton()
        RbBurger = New RadioButton()
        RbPates = New RadioButton()
        Label3 = New Label()
        LbBoisson = New ListBox()
        Label4 = New Label()
        BtnComm = New Button()
        BtnAnn = New Button()
        LblAff = New Label()
        GrSupp = New GroupBox()
        GrSupp.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(86, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 0
        Label1.Text = "Choix du Plat "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(86, 331)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 4
        Label2.Text = "Supplement"
        ' 
        ' ChFromage
        ' 
        ChFromage.AutoSize = True
        ChFromage.Location = New Point(30, 70)
        ChFromage.Name = "ChFromage"
        ChFromage.Size = New Size(90, 24)
        ChFromage.TabIndex = 5
        ChFromage.Text = "Fromage"
        ChFromage.UseVisualStyleBackColor = True
        ' 
        ' Chfrites
        ' 
        Chfrites.AutoSize = True
        Chfrites.Location = New Point(30, 100)
        Chfrites.Name = "Chfrites"
        Chfrites.Size = New Size(66, 24)
        Chfrites.TabIndex = 6
        Chfrites.Text = "Frites"
        Chfrites.UseVisualStyleBackColor = True
        ' 
        ' ChDessert
        ' 
        ChDessert.AutoSize = True
        ChDessert.Location = New Point(40, 33)
        ChDessert.Name = "ChDessert"
        ChDessert.Size = New Size(80, 24)
        ChDessert.TabIndex = 7
        ChDessert.Text = "Dessert"
        ChDessert.UseVisualStyleBackColor = True
        ' 
        ' RbPizza
        ' 
        RbPizza.AutoSize = True
        RbPizza.Location = New Point(86, 109)
        RbPizza.Name = "RbPizza"
        RbPizza.Size = New Size(64, 24)
        RbPizza.TabIndex = 8
        RbPizza.TabStop = True
        RbPizza.Text = "Pizza"
        RbPizza.UseVisualStyleBackColor = True
        ' 
        ' RbBurger
        ' 
        RbBurger.AutoSize = True
        RbBurger.Location = New Point(86, 183)
        RbBurger.Name = "RbBurger"
        RbBurger.Size = New Size(74, 24)
        RbBurger.TabIndex = 9
        RbBurger.TabStop = True
        RbBurger.Text = "Burger"
        RbBurger.UseVisualStyleBackColor = True
        ' 
        ' RbPates
        ' 
        RbPates.AutoSize = True
        RbPates.Location = New Point(86, 265)
        RbPates.Name = "RbPates"
        RbPates.Size = New Size(64, 24)
        RbPates.TabIndex = 10
        RbPates.TabStop = True
        RbPates.Text = "Pates"
        RbPates.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(382, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 11
        Label3.Text = "Boisson"
        ' 
        ' LbBoisson
        ' 
        LbBoisson.FormattingEnabled = True
        LbBoisson.Location = New Point(504, 45)
        LbBoisson.Name = "LbBoisson"
        LbBoisson.Size = New Size(231, 44)
        LbBoisson.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(362, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 20)
        Label4.TabIndex = 13
        Label4.Text = "Facture"
        ' 
        ' BtnComm
        ' 
        BtnComm.Location = New Point(451, 441)
        BtnComm.Name = "BtnComm"
        BtnComm.Size = New Size(94, 29)
        BtnComm.TabIndex = 14
        BtnComm.Text = "Commander"
        BtnComm.UseVisualStyleBackColor = True
        ' 
        ' BtnAnn
        ' 
        BtnAnn.Location = New Point(703, 441)
        BtnAnn.Name = "BtnAnn"
        BtnAnn.Size = New Size(94, 29)
        BtnAnn.TabIndex = 15
        BtnAnn.Text = "Annuler"
        BtnAnn.UseVisualStyleBackColor = True
        ' 
        ' LblAff
        ' 
        LblAff.AutoSize = True
        LblAff.Location = New Point(451, 187)
        LblAff.Name = "LblAff"
        LblAff.Size = New Size(0, 20)
        LblAff.TabIndex = 16
        ' 
        ' GrSupp
        ' 
        GrSupp.Controls.Add(ChDessert)
        GrSupp.Controls.Add(ChFromage)
        GrSupp.Controls.Add(Chfrites)
        GrSupp.Location = New Point(46, 376)
        GrSupp.Name = "GrSupp"
        GrSupp.Size = New Size(250, 127)
        GrSupp.TabIndex = 17
        GrSupp.TabStop = False
        GrSupp.Text = "GroupBox1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1069, 574)
        Controls.Add(GrSupp)
        Controls.Add(LblAff)
        Controls.Add(BtnAnn)
        Controls.Add(BtnComm)
        Controls.Add(Label4)
        Controls.Add(LbBoisson)
        Controls.Add(Label3)
        Controls.Add(RbPates)
        Controls.Add(RbBurger)
        Controls.Add(RbPizza)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GrSupp.ResumeLayout(False)
        GrSupp.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ChFromage As CheckBox
    Friend WithEvents Chfrites As CheckBox
    Friend WithEvents ChDessert As CheckBox
    Friend WithEvents RbPizza As RadioButton
    Friend WithEvents RbBurger As RadioButton
    Friend WithEvents RbPates As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents LbBoisson As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnComm As Button
    Friend WithEvents BtnAnn As Button
    Friend WithEvents LblAff As Label
    Friend WithEvents GrSupp As GroupBox

End Class
