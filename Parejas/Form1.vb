Imports System.Runtime.InteropServices

Public Class Form1

    Dim tiempoMaximo, tiempoRestante As Integer
    Dim numeroCartas As Integer = 0
    Dim nivelDificultad As String
    Dim tematica As String  'TODO: Añadir sets de cartas diferentes y selector de temática
    Dim aciertos As Integer = 0, fallos As Integer = 0
    Dim puntuacion As Integer = 0
    Dim random As Random = New Random
    Dim primeraSeleccion, segundaSeleccion As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblReloj.Text = "00:00"
        btnIniciar.Enabled = False
        btnReset.Enabled = False
    End Sub

#Region "Botones de inicialización/reinicio de juego"
    Private Sub botonesDificultad_Click(sender As Object, e As EventArgs) Handles btnFacil.Click, btnDificil.Click
        borrarGridCartas()

        If sender.Equals(btnFacil) Then
            nivelDificultad = "Fácil"
            lblReloj.Text = "01:00"
            crearGridCartas(4, 4)

        ElseIf sender.Equals(btnDificil) Then
            nivelDificultad = "Difícil"
            lblReloj.Text = "02:00"
            crearGridCartas(6, 6)

        End If

        cambiarEstadoCartas(False)
        btnIniciar.Enabled = True
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        If nivelDificultad = "Fácil" Then
            tiempoMaximo = 60
        ElseIf nivelDificultad = "Difícil" Then
            tiempoMaximo = 120
        End If

        adjudicarCartas()
        cambiarEstadoCartas(True)

        tiempoRestante = tiempoMaximo
        Timer1.Enabled = True

        btnIniciar.Enabled = False
        btnReset.Enabled = True
        btnFacil.Enabled = False
        btnDificil.Enabled = False

        If nivelDificultad = "Fácil" Then
            btnDificil.Visible = False
        ElseIf nivelDificultad = "Difícil" Then
            btnFacil.Visible = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tiempoMaximo = 0
        numeroCartas = 0
        nivelDificultad = ""
        aciertos = 0
        fallos = 0
        puntuacion = 0
        primeraSeleccion = Nothing
        segundaSeleccion = Nothing
        Controls.Clear()
        InitializeComponent()
        btnIniciar.Enabled = False
        btnReset.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempoRestante -= 1

        If tiempoRestante = 20 Then
            lblReloj.ForeColor = Color.LightCoral
        End If

        If tiempoRestante <= 0 Then
            Timer1.Enabled = False
            lblReloj.Text = "00:00"
            FinJuego(False)
        End If

        Dim ts As TimeSpan = TimeSpan.FromSeconds(tiempoRestante)
        lblReloj.Text = ts.Minutes.ToString.PadLeft(2, "0"c) & ":" & ts.Seconds.ToString.PadLeft(2, "0"c)

    End Sub
#End Region

#Region "Métodos de generación del panelCartas"
    Private Sub crearGridCartas(columnas As Integer, filas As Integer)
        Dim ladoBoton As Integer = 70
        Dim separacionBoton As Integer = 10
        Dim margenX, margenY As Integer

        If columnas = 4 And filas = 4 Then
            margenX = 100
            margenY = 100
        ElseIf columnas = 6 And filas = 6 Then
            margenX = 20
            margenY = 20
        End If

        For indiceFila As Integer = 1 To filas
            For indiceColumna As Integer = 1 To columnas
                Dim boton As New Button
                With boton
                    .Size = New Size(ladoBoton, ladoBoton)
                    .Location = New Point(margenX, margenY)
                    .BackgroundImage = My.Resources.reverso
                    .BackgroundImageLayout = ImageLayout.Stretch
                End With
                AddHandler boton.Click, AddressOf Me.BtnCarta_Click
                numeroCartas += 1
                panelCartas.Controls.Add(boton)
                margenX += ladoBoton + separacionBoton
            Next
            margenX = If(columnas = 4, 100, 20)
            margenY += ladoBoton + separacionBoton
        Next
        Console.WriteLine(numeroCartas)
    End Sub

    Private Sub borrarGridCartas()
        Dim botones() As Button = panelCartas.Controls.OfType(Of Button)().ToArray
        For i As Integer = botones.Length - 1 To 0 Step -1
            botones(i).Dispose()
        Next

        numeroCartas = 0
    End Sub

    Private Sub cambiarEstadoCartas(estadoActivado As Boolean)
        Dim botones() As Button = panelCartas.Controls.OfType(Of Button)().ToArray
        For i As Integer = botones.Length - 1 To 0 Step -1
            botones(i).Enabled = estadoActivado
            If botones(i).Enabled = True Then
                botones(i).BackgroundImage = My.Resources.reverso
            Else
                botones(i).BackgroundImage = My.Resources.reverso_oscuro
            End If
        Next
    End Sub
#End Region

#Region "Métodos de lógica principal del juego de parejas"
    Private Sub adjudicarCartas()
        Dim lista As List(Of Integer) = New List(Of Integer)

        ' Creación de lista de parejas de índices ordenada (1, 1, 2, 2, 3, 3, etc)
        For i As Integer = 1 To numeroCartas / 2
            lista.Add(i)
            lista.Add(i)
        Next

        ' Barajado aleatorio de la lista de índices
        Dim listaAleatoria As List(Of Integer) = lista.OrderBy(Function(x) random.Next()).ToList

        ' Adjudicación de tags barajados a los botones del panelCartas 
        Dim contador As Integer = 0
        For Each boton As Button In panelCartas.Controls
            boton.Tag = listaAleatoria(contador)
            boton.BackColor = Color.White
            contador += 1
        Next
    End Sub

    Private Sub BtnCarta_Click(sender As Button, e As EventArgs)
        'Concatenación para mostrar la carta de resources numerada según el Tag del botón pulsado
        Dim carta As Object = My.Resources.ResourceManager.GetObject("card" & sender.Tag)
        sender.BackgroundImage = carta

        sender.Refresh()  'Necesario para forzar el dibujado antes de Thread.sleep()

        If primeraSeleccion Is Nothing And segundaSeleccion Is Nothing Then
            primeraSeleccion = sender
        Else
            segundaSeleccion = sender

            If primeraSeleccion.Tag = segundaSeleccion.Tag And Not primeraSeleccion.Equals(segundaSeleccion) Then
                aciertos += 1
                lblPuntos.Text = 2 ^ aciertos
                'Establece el Tag = 0 de las cartas volteadas para la lógica de fin de juego
                primeraSeleccion.Tag = 0
                segundaSeleccion.Tag = 0
                primeraSeleccion.Enabled = False
                segundaSeleccion.Enabled = False
                If aciertos = numeroCartas / 2 Then
                    Timer1.Enabled = False
                    FinJuego(True)
                End If
            Else
                'Delay que permite al jugador ver y memorizar las cartas no emparejadas antes de ocultarlas de nuevo
                Threading.Thread.Sleep(900)

                fallos += 1
                lblFallosContador.Text = CStr(fallos).PadLeft(2, "0"c)
                primeraSeleccion.BackgroundImage = My.Resources.reverso
                segundaSeleccion.BackgroundImage = My.Resources.reverso
            End If
            primeraSeleccion = Nothing
            segundaSeleccion = Nothing
        End If
    End Sub

    Private Sub FinJuego(victoria As Boolean)
        'Deshabilita todas las cartas y oscurece el reverso de las no volteadas
        Dim botones() As Button = panelCartas.Controls.OfType(Of Button)().ToArray
        For i As Integer = 0 To botones.Length - 1
            botones(i).Enabled = False
            If botones(i).Tag <> 0 Then
                botones(i).BackgroundImage = My.Resources.reverso_oscuro
            End If
        Next

        frmFinJuego.Show()
        If victoria Then
            frmFinJuego.pboxFinJuego.BackgroundImage = My.Resources.oso
            frmFinJuego.lblMensajeFinal.Text = "¡Felicidades! Has encontrado todas las parejas."
            frmFinJuego.lblSaldoFinal.Text =
                "Has completado el juego en " &
                tiempoMaximo - tiempoRestante &
                " segundos y has tenido " &
                fallos &
                " fallos."
        Else
            frmFinJuego.pboxFinJuego.BackgroundImage = My.Resources.caracol
            frmFinJuego.lblMensajeFinal.Text = "¡Oooh! Se ha acabado el tiempo."
            frmFinJuego.lblSaldoFinal.Text =
                "Te faltaron por encontrar " &
                numeroCartas / 2 - aciertos &
                " parejas más."
        End If
    End Sub
#End Region

#Region "Arrastre de la interfaz"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, panelCartas.MouseMove,
            lblTitulo.MouseMove, lblReloj.MouseMove, lblDificultad.MouseMove, lblPuntuacion.MouseMove, lblPuntos.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region

#Region "Controles de la barra de título"
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub
#End Region

End Class
