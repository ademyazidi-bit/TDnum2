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
        Label1 = New Label()
        Label2 = New Label()
        ComboBoxLigne = New ComboBox()
        Label3 = New Label()
        ComboBoxArrive = New ComboBox()
        ComboBoxDepart = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        DateTimePicker2 = New DateTimePicker()
        GrpBoxOp = New GroupBox()
        ChBus = New CheckBox()
        ChWifi = New CheckBox()
        ChClim = New CheckBox()
        GrBoxTrajet = New GroupBox()
        RdNoc = New RadioButton()
        Rdexp = New RadioButton()
        RdReg = New RadioButton()
        NumUpDownPlace = New NumericUpDown()
        DGVHeure = New DataGridView()
        Ligne = New DataGridViewTextBoxColumn()
        Depart = New DataGridViewTextBoxColumn()
        Arrive = New DataGridViewTextBoxColumn()
        Heure_Depart = New DataGridViewTextBoxColumn()
        Heure_arrive = New DataGridViewTextBoxColumn()
        Places = New DataGridViewTextBoxColumn()
        Options = New DataGridViewTextBoxColumn()
        BtnAjou = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        GrpBoxOp.SuspendLayout()
        GrBoxTrajet.SuspendLayout()
        CType(NumUpDownPlace, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVHeure, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(451, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(333, 35)
        Label1.TabIndex = 0
        Label1.Text = "Gestion Des Horaires De Bus"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(70, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(202, 28)
        Label2.TabIndex = 1
        Label2.Text = "Informations du trajet"
        ' 
        ' ComboBoxLigne
        ' 
        ComboBoxLigne.FormattingEnabled = True
        ComboBoxLigne.Items.AddRange(New Object() {"Ligne 1", "Ligne2 ", "Ligne 3"})
        ComboBoxLigne.Location = New Point(253, 134)
        ComboBoxLigne.Name = "ComboBoxLigne"
        ComboBoxLigne.Size = New Size(285, 28)
        ComboBoxLigne.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(83, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 3
        Label3.Text = "Ligne"
        ' 
        ' ComboBoxArrive
        ' 
        ComboBoxArrive.FormattingEnabled = True
        ComboBoxArrive.Location = New Point(253, 276)
        ComboBoxArrive.Name = "ComboBoxArrive"
        ComboBoxArrive.Size = New Size(285, 28)
        ComboBoxArrive.TabIndex = 4
        ' 
        ' ComboBoxDepart
        ' 
        ComboBoxDepart.FormattingEnabled = True
        ComboBoxDepart.Items.AddRange(New Object() {"Bizerte", "Manzel Abderhmen", "manzel jmil"})
        ComboBoxDepart.Location = New Point(253, 203)
        ComboBoxDepart.Name = "ComboBoxDepart"
        ComboBoxDepart.Size = New Size(285, 28)
        ComboBoxDepart.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(83, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 6
        Label4.Text = "Ville depart :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(83, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 20)
        Label5.TabIndex = 7
        Label5.Text = "Ville arrivee :"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Time
        DateTimePicker1.Location = New Point(253, 347)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(285, 27)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(83, 347)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 20)
        Label6.TabIndex = 9
        Label6.Text = "Heure depart :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(83, 423)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 20)
        Label7.TabIndex = 10
        Label7.Text = "Heure arrivee :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(83, 474)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 20)
        Label8.TabIndex = 11
        Label8.Text = "Place :"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(253, 416)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(285, 27)
        DateTimePicker2.TabIndex = 12
        ' 
        ' GrpBoxOp
        ' 
        GrpBoxOp.Controls.Add(ChBus)
        GrpBoxOp.Controls.Add(ChWifi)
        GrpBoxOp.Controls.Add(ChClim)
        GrpBoxOp.Location = New Point(956, 115)
        GrpBoxOp.Name = "GrpBoxOp"
        GrpBoxOp.Size = New Size(250, 148)
        GrpBoxOp.TabIndex = 13
        GrpBoxOp.TabStop = False
        GrpBoxOp.Text = "Options"
        ' 
        ' ChBus
        ' 
        ChBus.AutoSize = True
        ChBus.Location = New Point(24, 116)
        ChBus.Name = "ChBus"
        ChBus.Size = New Size(110, 24)
        ChBus.TabIndex = 2
        ChBus.Text = "Bus A etage"
        ChBus.UseVisualStyleBackColor = True
        ' 
        ' ChWifi
        ' 
        ChWifi.AutoSize = True
        ChWifi.Location = New Point(24, 75)
        ChWifi.Name = "ChWifi"
        ChWifi.Size = New Size(60, 24)
        ChWifi.TabIndex = 1
        ChWifi.Text = "WIFI"
        ChWifi.UseVisualStyleBackColor = True
        ' 
        ' ChClim
        ' 
        ChClim.AutoSize = True
        ChClim.Location = New Point(24, 31)
        ChClim.Name = "ChClim"
        ChClim.Size = New Size(124, 24)
        ChClim.TabIndex = 0
        ChClim.Text = "Climatsisation"
        ChClim.UseVisualStyleBackColor = True
        ' 
        ' GrBoxTrajet
        ' 
        GrBoxTrajet.Controls.Add(RdNoc)
        GrBoxTrajet.Controls.Add(Rdexp)
        GrBoxTrajet.Controls.Add(RdReg)
        GrBoxTrajet.Location = New Point(956, 336)
        GrBoxTrajet.Name = "GrBoxTrajet"
        GrBoxTrajet.Size = New Size(250, 147)
        GrBoxTrajet.TabIndex = 14
        GrBoxTrajet.TabStop = False
        GrBoxTrajet.Text = "Type de trajet"
        ' 
        ' RdNoc
        ' 
        RdNoc.AutoSize = True
        RdNoc.Location = New Point(13, 112)
        RdNoc.Name = "RdNoc"
        RdNoc.Size = New Size(91, 24)
        RdNoc.TabIndex = 2
        RdNoc.TabStop = True
        RdNoc.Text = "Noctume"
        RdNoc.UseVisualStyleBackColor = True
        ' 
        ' Rdexp
        ' 
        Rdexp.AutoSize = True
        Rdexp.Location = New Point(13, 69)
        Rdexp.Name = "Rdexp"
        Rdexp.Size = New Size(79, 24)
        Rdexp.TabIndex = 1
        Rdexp.TabStop = True
        Rdexp.Text = "Express"
        Rdexp.UseVisualStyleBackColor = True
        ' 
        ' RdReg
        ' 
        RdReg.AutoSize = True
        RdReg.Location = New Point(13, 26)
        RdReg.Name = "RdReg"
        RdReg.Size = New Size(85, 24)
        RdReg.TabIndex = 0
        RdReg.TabStop = True
        RdReg.Text = "Regulier"
        RdReg.UseVisualStyleBackColor = True
        ' 
        ' NumUpDownPlace
        ' 
        NumUpDownPlace.Location = New Point(246, 472)
        NumUpDownPlace.Name = "NumUpDownPlace"
        NumUpDownPlace.Size = New Size(150, 27)
        NumUpDownPlace.TabIndex = 15
        ' 
        ' DGVHeure
        ' 
        DGVHeure.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVHeure.Columns.AddRange(New DataGridViewColumn() {Ligne, Depart, Arrive, Heure_Depart, Heure_arrive, Places, Options})
        DGVHeure.Location = New Point(46, 546)
        DGVHeure.Name = "DGVHeure"
        DGVHeure.RowHeadersWidth = 51
        DGVHeure.Size = New Size(927, 218)
        DGVHeure.TabIndex = 16
        ' 
        ' Ligne
        ' 
        Ligne.HeaderText = "Ligne"
        Ligne.MinimumWidth = 6
        Ligne.Name = "Ligne"
        Ligne.Width = 125
        ' 
        ' Depart
        ' 
        Depart.HeaderText = "Depart"
        Depart.MinimumWidth = 6
        Depart.Name = "Depart"
        Depart.Width = 125
        ' 
        ' Arrive
        ' 
        Arrive.HeaderText = "Arrive"
        Arrive.MinimumWidth = 6
        Arrive.Name = "Arrive"
        Arrive.Width = 125
        ' 
        ' Heure_Depart
        ' 
        Heure_Depart.HeaderText = "Heure_Depart"
        Heure_Depart.MinimumWidth = 6
        Heure_Depart.Name = "Heure_Depart"
        Heure_Depart.Width = 125
        ' 
        ' Heure_arrive
        ' 
        Heure_arrive.HeaderText = "Heure_arrive"
        Heure_arrive.MinimumWidth = 6
        Heure_arrive.Name = "Heure_arrive"
        Heure_arrive.Width = 125
        ' 
        ' Places
        ' 
        Places.HeaderText = "Places"
        Places.MinimumWidth = 6
        Places.Name = "Places"
        Places.Width = 125
        ' 
        ' Options
        ' 
        Options.HeaderText = "Options"
        Options.MinimumWidth = 6
        Options.Name = "Options"
        Options.Width = 125
        ' 
        ' BtnAjou
        ' 
        BtnAjou.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        BtnAjou.Font = New Font("Segoe UI", 14F)
        BtnAjou.Location = New Point(603, 125)
        BtnAjou.Name = "BtnAjou"
        BtnAjou.Size = New Size(123, 80)
        BtnAjou.TabIndex = 17
        BtnAjou.Text = "Ajouter"
        BtnAjou.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1343, 793)
        Controls.Add(BtnAjou)
        Controls.Add(DGVHeure)
        Controls.Add(NumUpDownPlace)
        Controls.Add(GrBoxTrajet)
        Controls.Add(GrpBoxOp)
        Controls.Add(DateTimePicker2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ComboBoxDepart)
        Controls.Add(ComboBoxArrive)
        Controls.Add(Label3)
        Controls.Add(ComboBoxLigne)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GrpBoxOp.ResumeLayout(False)
        GrpBoxOp.PerformLayout()
        GrBoxTrajet.ResumeLayout(False)
        GrBoxTrajet.PerformLayout()
        CType(NumUpDownPlace, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVHeure, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxLigne As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxArrive As ComboBox
    Friend WithEvents ComboBoxDepart As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents GrpBoxOp As GroupBox
    Friend WithEvents ChBus As CheckBox
    Friend WithEvents ChWifi As CheckBox
    Friend WithEvents ChClim As CheckBox
    Friend WithEvents GrBoxTrajet As GroupBox
    Friend WithEvents RdNoc As RadioButton
    Friend WithEvents Rdexp As RadioButton
    Friend WithEvents RdReg As RadioButton
    Friend WithEvents NumUpDownPlace As NumericUpDown
    Friend WithEvents DGVHeure As DataGridView
    Friend WithEvents Ligne As DataGridViewTextBoxColumn
    Friend WithEvents Depart As DataGridViewTextBoxColumn
    Friend WithEvents Arrive As DataGridViewTextBoxColumn
    Friend WithEvents Heure_Depart As DataGridViewTextBoxColumn
    Friend WithEvents Heure_arrive As DataGridViewTextBoxColumn
    Friend WithEvents Places As DataGridViewTextBoxColumn
    Friend WithEvents Options As DataGridViewTextBoxColumn
    Friend WithEvents BtnAjou As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
