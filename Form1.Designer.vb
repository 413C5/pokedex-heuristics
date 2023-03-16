<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnQuizz = New System.Windows.Forms.Button()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.labCategoria = New System.Windows.Forms.Label()
        Me.picImagen = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labNumero = New System.Windows.Forms.Label()
        Me.lstNumero = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.labHabilidad = New System.Windows.Forms.Label()
        Me.picTipo1 = New System.Windows.Forms.PictureBox()
        Me.btnSonido = New System.Windows.Forms.Button()
        Me.picTipo2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.picTipo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTipo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(94, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(-47, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 153)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrada Pokédex"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(3, 363)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 20)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(3, 363)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 20)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 363)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(40, 20)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Entrada Pokédex"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(3, 23)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(34, 0)
        Me.TextBox1.TabIndex = 0
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(187, 363)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(40, 20)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Salir"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 100)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bulbasaur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 80)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pokemon Semilla"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 80)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pokemon Semilla"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 0
        '
        'btnQuizz
        '
        Me.btnQuizz.Location = New System.Drawing.Point(219, 360)
        Me.btnQuizz.Name = "btnQuizz"
        Me.btnQuizz.Size = New System.Drawing.Size(189, 29)
        Me.btnQuizz.TabIndex = 3
        Me.btnQuizz.Text = "¡&Prueba tu conocimiento!"
        Me.btnQuizz.UseVisualStyleBackColor = True
        '
        'txtEntrada
        '
        Me.txtEntrada.BackColor = System.Drawing.Color.White
        Me.txtEntrada.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEntrada.ForeColor = System.Drawing.Color.Black
        Me.txtEntrada.Location = New System.Drawing.Point(30, 292)
        Me.txtEntrada.Multiline = True
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.ReadOnly = True
        Me.txtEntrada.Size = New System.Drawing.Size(496, 62)
        Me.txtEntrada.TabIndex = 2
        Me.txtEntrada.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(422, 360)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(104, 29)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'labNombre
        '
        Me.labNombre.AutoSize = True
        Me.labNombre.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel4.SetColumnSpan(Me.labNombre, 4)
        Me.labNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labNombre.Location = New System.Drawing.Point(224, 1)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(174, 23)
        Me.labNombre.TabIndex = 1
        Me.labNombre.Text = "Bulbasaur"
        '
        'labCategoria
        '
        Me.labCategoria.AutoSize = True
        Me.labCategoria.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel4.SetColumnSpan(Me.labCategoria, 5)
        Me.labCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labCategoria.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labCategoria.Location = New System.Drawing.Point(224, 25)
        Me.labCategoria.Name = "labCategoria"
        Me.labCategoria.Size = New System.Drawing.Size(218, 23)
        Me.labCategoria.TabIndex = 2
        Me.labCategoria.Text = "Pokemon Semilla"
        '
        'picImagen
        '
        Me.picImagen.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.SetColumnSpan(Me.picImagen, 3)
        Me.picImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picImagen.Image = Global.Pokedex.My.Resources.Resources.pic1
        Me.picImagen.Location = New System.Drawing.Point(4, 4)
        Me.picImagen.Name = "picImagen"
        Me.TableLayoutPanel4.SetRowSpan(Me.picImagen, 6)
        Me.picImagen.Size = New System.Drawing.Size(125, 137)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImagen.TabIndex = 3
        Me.picImagen.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label6, 2)
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(136, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tipo(s):"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNumero
        '
        Me.labNumero.AutoSize = True
        Me.labNumero.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel4.SetColumnSpan(Me.labNumero, 2)
        Me.labNumero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labNumero.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labNumero.Location = New System.Drawing.Point(136, 1)
        Me.labNumero.Name = "labNumero"
        Me.labNumero.Size = New System.Drawing.Size(81, 23)
        Me.labNumero.TabIndex = 0
        Me.labNumero.Text = "#001"
        Me.labNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstNumero
        '
        Me.lstNumero.AutoCompleteCustomSource.AddRange(New String() {"Bulbasaur   #1", "Ivysaur     #2", "Venusaur    #3", "Charmander  #4", "Charmeleon  #5", "Charizard   #6", "Squirtle    #7", "Wartortle   #8", "Blastoise   #9", "Caterpie    #10", "Metapod     #11", "Butterfree  #12", "Weedle      #13", "Kakuna      #14", "Beedrill    #15", "Pidgey      #16", "Pidgeotto   #17", "Pidgeot     #18", "Rattata     #19", "Raticate    #20", "Spearow     #21", "Fearow      #22", "Ekans       #23", "Arbok       #24", "Pikachu     #25", "Raichu      #26", "Sandshrew   #27", "Sandslash   #28", "Nidoran ♀   #29", "Nidorina    #30", "Nidoqueen   #31", "Nidoran ♂   #32", "Nidorino    #33", "Nidoking    #34", "Clefairy    #35", "Clefable    #36", "Vulpix      #37", "Ninetales   #38", "Jigglypuff  #39", "Wigglytuff  #40", "Zubat       #41", "Golbat      #42", "Oddish      #43", "Gloom       #44", "Vileplume   #45", "Paras       #46", "Parasect    #47", "Venonat     #48", "Venomoth    #49", "Diglett     #50", "Dugtrio     #51", "Meowth      #52", "Persian     #53", "Psyduck     #54", "Golduck     #55", "Mankey      #56", "Primeape    #57", "Growlithe   #58", "Arcanine    #59", "Poliwag     #60", "Poliwhirl   #61", "Poliwrath   #62", "Abra        #63", "Kadabra     #64", "Alakazam    #65", "Machop      #66", "Machoke     #67", "Machamp     #68", "Bellsprout  #69", "Weepinbell  #70", "Victreebel  #71", "Tentacool   #72", "Tentacruel  #73", "Geodude     #74", "Graveler    #75", "Golem       #76", "Ponyta      #77", "Rapidash    #78", "Slowpoke    #79", "Slowbro     #80", "Magnemite   #81", "Magneton    #82", "Farfetch'd  #83", "Doduo       #84", "Dodrio      #85", "Seel        #86", "Dewgong     #87", "Grimer      #88", "Muk         #89", "Shellder    #90", "Cloyster    #91", "Gastly      #92", "Haunter     #93", "Gengar      #94", "Onix        #95", "Drowzee     #96", "Hypno       #97", "Krabby      #98", "Kingler     #99", "Voltorb     #100", "Electrode   #101", "Exeggcute   #102", "Exeggutor   #103", "Cubone      #104", "Marowak     #105", "Hitmonlee   #106", "Hitmonchan  #107", "Lickitung   #108", "Koffing     #109", "Weezing     #110", "Rhyhorn     #111", "Rhydon      #112", "Chansey     #113", "Tangela     #114", "Kangaskhan  #115", "Horsea      #116", "Seadra      #117", "Goldeen     #118", "Seaking     #119", "Staryu      #120", "Starmie     #121", "Mr. Mime    #122", "Scyther     #123", "Jynx        #124", "Electabuzz  #125", "Magmar      #126", "Pinsir      #127", "Tauros      #128", "Magikarp    #129", "Gyarados    #130", "Lapras      #131", "Ditto       #132", "Eevee       #133", "Vaporeon    #134", "Jolteon     #135", "Flareon     #136", "Porygon     #137", "Omanyte     #138", "Omastar     #139", "Kabuto      #140", "Kabutops    #141", "Aerodactyl  #142", "Snorlax     #143", "Articuno    #144", "Zapdos      #145", "Moltres     #146", "Dratini     #147", "Dragonair   #148", "Dragonite   #149", "Mewtwo      #150", "Mew         #151"})
        Me.lstNumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.lstNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.lstNumero.BackColor = System.Drawing.Color.White
        Me.lstNumero.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lstNumero.ForeColor = System.Drawing.Color.Black
        Me.lstNumero.FormattingEnabled = True
        Me.lstNumero.Items.AddRange(New Object() {"Bulbasaur      #1", "Ivysaur           #2", "Venusaur        #3", "Charmander   #4", "Charmeleon   #5", "Charizard       #6", "Squirtle          #7", "Wartortle       #8", "Blastoise        #9", "Caterpie         #10", "Metapod       #11", "Butterfree      #12", "Weedle          #13", "Kakuna          #14", "Beedrill         #15", "Pidgey      #16", "Pidgeotto   #17", "Pidgeot     #18", "Rattata     #19", "Raticate    #20", "Spearow     #21", "Fearow      #22", "Ekans       #23", "Arbok       #24", "Pikachu     #25", "Raichu      #26", "Sandshrew   #27", "Sandslash   #28", "Nidoran ♀   #29", "Nidorina    #30", "Nidoqueen   #31", "Nidoran ♂   #32", "Nidorino    #33", "Nidoking    #34", "Clefairy    #35", "Clefable    #36", "Vulpix      #37", "Ninetales   #38", "Jigglypuff  #39", "Wigglytuff  #40", "Zubat       #41", "Golbat      #42", "Oddish      #43", "Gloom       #44", "Vileplume   #45", "Paras       #46", "Parasect    #47", "Venonat     #48", "Venomoth    #49", "Diglett     #50", "Dugtrio     #51", "Meowth      #52", "Persian     #53", "Psyduck     #54", "Golduck     #55", "Mankey      #56", "Primeape    #57", "Growlithe   #58", "Arcanine    #59", "Poliwag     #60", "Poliwhirl   #61", "Poliwrath   #62", "Abra        #63", "Kadabra     #64", "Alakazam    #65", "Machop      #66", "Machoke     #67", "Machamp     #68", "Bellsprout  #69", "Weepinbell  #70", "Victreebel  #71", "Tentacool   #72", "Tentacruel  #73", "Geodude     #74", "Graveler    #75", "Golem       #76", "Ponyta      #77", "Rapidash    #78", "Slowpoke    #79", "Slowbro     #80", "Magnemite   #81", "Magneton    #82", "Farfetch'd  #83", "Doduo       #84", "Dodrio      #85", "Seel        #86", "Dewgong     #87", "Grimer      #88", "Muk         #89", "Shellder    #90", "Cloyster    #91", "Gastly      #92", "Haunter     #93", "Gengar      #94", "Onix        #95", "Drowzee     #96", "Hypno       #97", "Krabby      #98", "Kingler     #99", "Voltorb     #100", "Electrode   #101", "Exeggcute   #102", "Exeggutor   #103", "Cubone      #104", "Marowak     #105", "Hitmonlee   #106", "Hitmonchan  #107", "Lickitung   #108", "Koffing     #109", "Weezing     #110", "Rhyhorn     #111", "Rhydon      #112", "Chansey     #113", "Tangela     #114", "Kangaskhan  #115", "Horsea      #116", "Seadra      #117", "Goldeen     #118", "Seaking     #119", "Staryu      #120", "Starmie     #121", "Mr. Mime    #122", "Scyther     #123", "Jynx        #124", "Electabuzz  #125", "Magmar      #126", "Pinsir      #127", "Tauros      #128", "Magikarp    #129", "Gyarados    #130", "Lapras      #131", "Ditto       #132", "Eevee       #133", "Vaporeon    #134", "Jolteon     #135", "Flareon     #136", "Porygon     #137", "Omanyte     #138", "Omastar     #139", "Kabuto      #140", "Kabutops    #141", "Aerodactyl  #142", "Snorlax     #143", "Articuno    #144", "Zapdos      #145", "Moltres     #146", "Dratini     #147", "Dragonair   #148", "Dragonite   #149", "Mewtwo      #150", "Mew         #151"})
        Me.lstNumero.Location = New System.Drawing.Point(318, 50)
        Me.lstNumero.Name = "lstNumero"
        Me.lstNumero.Size = New System.Drawing.Size(208, 28)
        Me.lstNumero.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 11
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.000899!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.000899!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.000899!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.000899!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.000899!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.000899!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.990998!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.000899!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.000899!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.000899!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.000899!))
        Me.TableLayoutPanel4.Controls.Add(Me.picImagen, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label11, 3, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.labNumero, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 3, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.labHabilidad, 6, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.labNombre, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.labCategoria, 5, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.picTipo1, 6, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.btnSonido, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.picTipo2, 9, 3)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(30, 84)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 8
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(496, 197)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label11, 3)
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(136, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 23)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Habilidad:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHabilidad
        '
        Me.labHabilidad.AutoSize = True
        Me.labHabilidad.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel4.SetColumnSpan(Me.labHabilidad, 3)
        Me.labHabilidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labHabilidad.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labHabilidad.Location = New System.Drawing.Point(268, 145)
        Me.labHabilidad.Name = "labHabilidad"
        Me.labHabilidad.Size = New System.Drawing.Size(130, 23)
        Me.labHabilidad.TabIndex = 6
        Me.labHabilidad.Text = "Crecimiento"
        Me.labHabilidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picTipo1
        '
        Me.picTipo1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.SetColumnSpan(Me.picTipo1, 2)
        Me.picTipo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picTipo1.Location = New System.Drawing.Point(268, 76)
        Me.picTipo1.Name = "picTipo1"
        Me.picTipo1.Size = New System.Drawing.Size(86, 17)
        Me.picTipo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTipo1.TabIndex = 23
        Me.picTipo1.TabStop = False
        '
        'btnSonido
        '
        Me.btnSonido.BackColor = System.Drawing.Color.White
        Me.btnSonido.BackgroundImage = Global.Pokedex.My.Resources.Resources.picPlay5
        Me.btnSonido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TableLayoutPanel4.SetColumnSpan(Me.btnSonido, 3)
        Me.btnSonido.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSonido.FlatAppearance.BorderSize = 0
        Me.btnSonido.Location = New System.Drawing.Point(4, 148)
        Me.btnSonido.Name = "btnSonido"
        Me.TableLayoutPanel4.SetRowSpan(Me.btnSonido, 2)
        Me.btnSonido.Size = New System.Drawing.Size(125, 45)
        Me.btnSonido.TabIndex = 4
        Me.btnSonido.UseVisualStyleBackColor = False
        '
        'picTipo2
        '
        Me.picTipo2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.SetColumnSpan(Me.picTipo2, 2)
        Me.picTipo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picTipo2.Location = New System.Drawing.Point(405, 76)
        Me.picTipo2.Name = "picTipo2"
        Me.picTipo2.Size = New System.Drawing.Size(87, 17)
        Me.picTipo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTipo2.TabIndex = 24
        Me.picTipo2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Pokedex.My.Resources.Resources.logoPokedex
        Me.PictureBox1.Location = New System.Drawing.Point(30, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Pokedex.My.Resources.Resources.lupa3
        Me.PictureBox2.Location = New System.Drawing.Point(279, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(563, 407)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.btnQuizz)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lstNumero)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pokédex"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.picTipo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTipo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnQuizz As Button
    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents labCategoria As Label
    Friend WithEvents picImagen As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents labNumero As Label
    Friend WithEvents lstNumero As ComboBox
    Friend WithEvents labNombre As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents labHabilidad As Label
    Friend WithEvents picTipo1 As PictureBox
    Friend WithEvents btnSonido As Button
    Friend WithEvents picTipo2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
