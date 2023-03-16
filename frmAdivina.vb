Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class frmAdivina

#Region "Atributos"
    Dim elegido As Integer
    Dim listaPokemones() As String = {"Bulbasaur",
"Ivysaur",
"Venusaur",
"Charmander",
"Charmeleon",
"Charizard",
"Squirtle",
"Wartortle",
"Blastoise",
"Caterpie",
"Metapod",
"Butterfree",
"Weedle",
"Kakuna",
"Beedrill",
"Pidgey",
"Pidgeotto",
"Pidgeot",
"Rattata",
"Raticate",
"Spearow",
"Fearow",
"Ekans",
"Arbok",
"Pikachu",
"Raichu",
"Sandshrew",
"Sandslash",
"Nidoran ♀",
"Nidorina",
"Nidoqueen",
"Nidoran ♂",
"Nidorino",
"Nidoking",
"Clefairy",
"Clefable",
"Vulpix",
"Ninetales",
"Jigglypuff",
"Wigglytuff",
"Zubat",
"Golbat",
"Oddish",
"Gloom",
"Vileplume",
"Paras",
"Parasect",
"Venonat",
"Venomoth",
"Diglett",
"Dugtrio",
"Meowth",
"Persian",
"Psyduck",
"Golduck",
"Mankey",
"Primeape",
"Growlithe",
"Arcanine",
"Poliwag",
"Poliwhirl",
"Poliwrath",
"Abra",
"Kadabra",
"Alakazam",
"Machop",
"Machoke",
"Machamp",
"Bellsprout",
"Weepinbell",
"Victreebel",
"Tentacool",
"Tentacruel",
"Geodude",
"Graveler",
"Golem",
"Ponyta",
"Rapidash",
"Slowpoke",
"Slowbro",
"Magnemite",
"Magneton",
"Farfetch'd",
"Doduo",
"Dodrio",
"Seel",
"Dewgong",
"Grimer",
"Muk",
"Shellder",
"Cloyster",
"Gastly",
"Haunter",
"Gengar",
"Onix",
"Drowzee",
"Hypno",
"Krabby",
"Kingler",
"Voltorb",
"Electrode",
"Exeggcute",
"Exeggutor",
"Cubone",
"Marowak",
"Hitmonlee",
"Hitmonchan",
"Lickitung",
"Koffing",
"Weezing",
"Rhyhorn",
"Rhydon",
"Chansey",
"Tangela",
"Kangaskhan",
"Horsea",
"Seadra",
"Goldeen",
"Seaking",
"Staryu",
"Starmie",
"Mr. Mime",
"Scyther",
"Jynx",
"Electabuzz",
"Magmar",
"Pinsir",
"Tauros",
"Magikarp",
"Gyarados",
"Lapras",
"Ditto",
"Eevee",
"Vaporeon",
"Jolteon",
"Flareon",
"Porygon",
"Omanyte",
"Omastar",
"Kabuto",
"Kabutops",
"Aerodactyl",
"Snorlax",
"Articuno",
"Zapdos",
"Moltres",
"Dratini",
"Dragonair",
"Dragonite",
"Mewtwo",
"Mew"}
#End Region

#Region "Metodos"

    ''' <summary>
    ''' Funcion encargada de cambiar las opciones en las respuestas del quizz
    ''' </summary>
    ''' <param name="res"></param>
    Public Sub cambiarOpciones(ByVal res As Integer)
        Dim opc = New List(Of Integer)
        Dim r As Integer
        opc.Add(res)
        While opc.Count < 4
            r = Int(Rnd() * listaPokemones.Length)
            If Not (opc.Contains(r)) Then
                opc.Add(r)
            End If
        End While
        Intercambio(opc)
        btnOp1.Text = listaPokemones(opc(0))
        'btnOp1.Select()
        btnOp2.Text = listaPokemones(opc(1))
        btnOp3.Text = listaPokemones(opc(2))
        btnOp4.Text = listaPokemones(opc(3))
    End Sub

    ''' <summary>
    ''' Cambia todos los botones a si están activados o no
    ''' </summary>
    ''' <param name="i"></param>
    Private Sub estadoOpciones(ByVal i As Boolean)
        If i Then
            btnOp1.Enabled = True
            btnOp1.Select()
            btnOp1.Focus()
            btnOp2.Enabled = True
            btnOp3.Enabled = True
            btnOp4.Enabled = True
            'btnOp1.Visible = True
            'btnOp2.Visible = True
            'btnOp3.Visible = True
            'btnOp4.Visible = True
        Else
            'btnOp1.Visible = False
            'btnOp2.Visible = False
            'btnOp3.Visible = False
            'btnOp4.Visible = False
            btnOp1.Enabled = False
            btnOp2.Enabled = False
            btnOp3.Enabled = False
            btnOp4.Enabled = False
        End If
    End Sub
    'Funcion que intercambia aleatoriamente espacios en la lista usando el método Knuth-Fisher-Yates
    Private Sub Intercambio(ByVal lista As List(Of Integer))
        Dim maximo As Integer = lista.Count - 1
        Dim rnd As New Random
        For i As Integer = 0 To maximo
            Dim n = rnd.Next(i + 1)
            Dim temp = lista(i)
            lista(i) = lista(n)
            lista(n) = temp
        Next i
    End Sub

    ''' <summary>
    ''' Funcion que llama a las funciones que aleatorizan el quizz, tanto la respuesta correcta como las opciones y elige la imágen acorde
    ''' </summary>
    Public Sub randomizarTodo()
        btnReintentar.Enabled = False
        btnReintentar.Visible = False
        labAnunciador.Text = "¡¿Quien es ese Pokémon?!"
        Randomize()
        elegido = Rnd() * (listaPokemones.Length - 1)
        Dim nombre = "pic" + CStr(elegido + 1) + "Dark"
        picPokemon.Image = My.Resources.ResourceManager.GetObject(nombre)
        cambiarOpciones(elegido)
    End Sub

    ''' <summary>
    ''' Funcion que checa si la respuesta elegida fue correcta o no
    ''' </summary>
    ''' <param name="res"></param>
    Public Sub checarRespuesta(ByVal res As String)
        estadoOpciones(False)
        If res <> listaPokemones(elegido) Then
            labAnunciador.Text = "¡No! ¡Es " + listaPokemones(elegido) + "!"
        Else
            labAnunciador.Text = "¡Correcto! ¡Es " + listaPokemones(elegido) + "!"
        End If
        Dim nombre = "pic" + CStr(elegido + 1)
        picPokemon.Image = My.Resources.ResourceManager.GetObject(nombre)
        btnReintentar.Enabled = True
        btnReintentar.Visible = True
        btnReintentar.Select()
        btnReintentar.Focus()
    End Sub
#End Region

#Region "Eventos"
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub frmAdivina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.FondoQuizz
        randomizarTodo()
        estadoOpciones(True)
    End Sub

    Private Sub btnOp2_Click(sender As Object, e As EventArgs) Handles btnOp2.Click
        checarRespuesta(btnOp2.Text)
    End Sub

    Private Sub btnOp1_Click(sender As Object, e As EventArgs) Handles btnOp1.Click
        checarRespuesta(btnOp1.Text)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnOp3_Click(sender As Object, e As EventArgs) Handles btnOp3.Click
        checarRespuesta(btnOp3.Text)
    End Sub

    Private Sub btnOp4_Click(sender As Object, e As EventArgs) Handles btnOp4.Click
        checarRespuesta(btnOp4.Text)
    End Sub

    Private Sub btnReintentar_Click(sender As Object, e As EventArgs) Handles btnReintentar.Click
        estadoOpciones(True)
        randomizarTodo()
    End Sub

#End Region

End Class