Imports ClasesJuego

Public Class frmJuego
    Private tiempoRestante As Integer = 150 'Dos minutos en segundos
    Private listaGaps As New List(Of Label)
    Private Sub frmJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnSonido.Text = "🔊"
        Conectar()
        If tiempo = True Then
            Me.lblHora.Text = String.Format("{0:m\:ss}", TimeSpan.FromSeconds(tiempoRestante))
            Timer1.Interval = 1000 'Un segundo
            Timer1.Start()
        Else
            lblHora.Text = "Ꝏ"
        End If

        GenerarBotones(Nivel1(1).texto)
        GenerarGapsBlanco(Nivel1(1).texto)

    End Sub
    Dim btnsGlobales As New List(Of Button)
    Private Sub Btn_Click(sender As Object, e As EventArgs)
        ' Aquí va el código que se ejecutará al hacer click en el botón
        ' Para acceder al botón que ha sido clickeado, podemos utilizar la variable "sender"
        Dim btnCaracteres As Button = DirectCast(sender, Button)
        'MessageBox.Show("Has clickeado el botón " & btnCaracteres.Text)
        lblTextoBotones.Text += sender.text
        ' Deshabilitar el botón para que no se pueda pulsar de nuevo
        btnCaracteres.Enabled = False
        btnsGlobales.Add(btnCaracteres)
    End Sub
    Private Sub GenerarGapsBlanco(palabra As String)
        Dim x As Integer = 10
        Dim y As Integer = 10
        Dim labelWidth As Integer = 30
        Dim labelHeight As Integer = 20
        Dim palabraGeneradora As pal
        Dim anchoTotal As Integer = 0
        Dim espacioEntreLabels As Integer = 10

        For Each palabraGeneradora In Nivel1
            For Each letra As Char In palabraGeneradora.Texto
                Dim lblGaps As New Label()
                lblGaps.Text = String.Empty
                lblGaps.BackColor = Color.White
                lblGaps.Size = New Size(labelWidth, labelHeight)
                lblGaps.Location = New Point(x, y)
                lblGaps.Name = "lblGaps"
                Me.Controls.Add(lblGaps)
                listaGaps.Add(lblGaps)
                x += labelWidth + 5
                If x > 10 + labelWidth * 10 + espacioEntreLabels * 9 Then
                    'Reiniciar la posición horizontal y agregar espacio entre columnas
                    x = x + espacioEntreLabels
                    y = 10
                End If
            Next
            x = 10
            y += labelHeight + 5
        Next
    End Sub
    Private botones As List(Of Button) = New List(Of Button)()
    Private Sub GenerarBotones(palabra As String)
        Dim anchoBoton As Integer = 50
        Dim espacioEntreBotones As Integer = 20
        Dim xInicial As Integer = Me.Width - ((anchoBoton + espacioEntreBotones) * palabra.Length - espacioEntreBotones) - 150
        Dim yInicial As Integer = 300
        Dim letras As List(Of Char) = palabra.ToList() ' Convertimos la palabra en una lista de caracteres
        letras = letras.OrderBy(Function() Guid.NewGuid()).ToList() ' Barajamos los caracteres
        Dim contadorLetras As Integer = 0
        For Each letra As Char In letras
            Dim boton As New Button()
            contadorLetras += 1
            boton.Name = "btnCaracteres" & contadorLetras
            boton.Width = anchoBoton
            boton.Height = anchoBoton
            boton.BackColor = Color.White
            boton.Location = New Point(xInicial, yInicial)
            boton.Text = letra.ToString.ToUpper
            Me.Controls.Add(boton)
            botones.Add(boton)
            xInicial += anchoBoton + espacioEntreBotones
            AddHandler boton.Click, AddressOf Btn_Click
        Next

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tiempo = True Then
            tiempoRestante -= 1
            If tiempoRestante >= 0 Then
                Me.lblHora.Text = String.Format("{0:m\:ss}", TimeSpan.FromSeconds(tiempoRestante))
            Else
                Timer1.Stop()
                Dim result As DialogResult = MessageBox.Show("Tiempo Finalizado", "¡Juego Finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result = DialogResult.OK Then
                    Form1.Show()
                    Me.Hide()
                End If
                'Aquí es donde puedes hacer cualquier cosa que necesites hacer cuando el tiempo se agote
            End If
        Else
            lblHora.Text = "Ꝏ"
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSonido.Click
        If btnSonido.Text = "🔊" Then
            If Desconectar() Then btnSonido.Text = "🔈"
        Else
            If Conectar() Then btnSonido.Text = "🔊"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each btn As Button In btnsGlobales
            btn.Enabled = True
        Next
        lblTextoBotones.Text = ""
    End Sub
    Private Sub Shuffle(Of T)(list As IList(Of T))
        Dim rng As New Random()
        Dim n As Integer = list.Count
        While n > 1
            n -= 1
            Dim k As Integer = rng.Next(n + 1)
            Dim value As T = list(k)
            list(k) = list(n)
            list(n) = value
        End While
    End Sub
    Private Sub btnTwist_Click(sender As Object, e As EventArgs) Handles btnTwist.Click
        botones = botones.OrderBy(Function() Guid.NewGuid()).ToList()
        For i As Integer = 0 To botones.Count - 1
            Dim boton As Button = botones(i)
            Dim xInicial As Integer = Me.Width - ((boton.Width + 20) * botones.Count - 20) - 150
            Dim yInicial As Integer = 300
            boton.Location = New Point(xInicial + (boton.Width + 20) * i, yInicial)
        Next
    End Sub
    Private Sub MostrarDefinicion(x As Integer, y As Integer)
        Dim btnDef As New Button
        btnDef.Name = "btnDef"
        btnDef.FlatStyle = FlatStyle.Flat
        btnDef.BackgroundImageLayout = ImageLayout.Zoom
        btnDef.BackgroundImage = New Bitmap(My.Resources.libro2, 20, 15)
        btnDef.Location = New Point(x, y)
        btnDef.Size = New Size(30, 20)
        AddHandler btnDef.Click, AddressOf btnDef_click
        Controls.Add(btnDef)
    End Sub
    Private Sub btnDef_click(sender As Object, a As EventArgs)
        MessageBox.Show("Def")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
    End Sub

    Private Sub lblTextoBotones_Click(sender As Object, e As EventArgs) Handles lblTextoBotones.Click

    End Sub



End Class
