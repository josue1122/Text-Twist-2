Imports ClasesJuego

Public Class frmJuego
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnTwist.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblPuntos_Click(sender As Object, e As EventArgs) Handles lblPuntos.Click

    End Sub

    Private tiempoRestante As Integer = 150 'Dos minutos en segundos

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


        Dim x As Integer = 10
        Dim y As Integer = 10
        Dim labelWidth As Integer = 30
        Dim labelHeight As Integer = 20
        Dim palabraGeneradora As Palabra

        Dim anchoTotal As Integer = 0
        Dim espacioEntreLabels As Integer = 10

        For Each palabraGeneradora In Nivel1
            For Each letra As Char In palabraGeneradora.Texto
                Dim label As New Label()
                label.Text = String.Empty
                label.BackColor = Color.White
                label.Size = New Size(labelWidth, labelHeight)
                label.Location = New Point(x, y)
                Me.Controls.Add(label)
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
    Private Sub GenerarBotones(palabra As String)
        Dim anchoBoton As Integer = 50
        Dim espacioEntreBotones As Integer = 20
        Dim xInicial As Integer = Me.Width - ((anchoBoton + espacioEntreBotones) * palabra.Length - espacioEntreBotones) - 150
        Dim yInicial As Integer = 300
        Dim letras As List(Of Char) = palabra.ToList() ' Convertimos la palabra en una lista de caracteres
        letras = letras.OrderBy(Function() Guid.NewGuid()).ToList() ' Barajamos los caracteres
        For Each letra As Char In letras
            Dim boton As New Button()
            boton.Width = anchoBoton
            boton.Height = anchoBoton
            boton.BackColor = Color.White
            boton.Location = New Point(xInicial, yInicial)
            boton.Text = letra.ToString.ToUpper
            Me.Controls.Add(boton)
            xInicial += anchoBoton + espacioEntreBotones
        Next
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tiempo = True Then
            tiempoRestante -= 1
            If tiempoRestante >= 0 Then
                Me.lblHora.Text = String.Format("{0:m\:ss}", TimeSpan.FromSeconds(tiempoRestante))
            Else
                Timer1.Stop()
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

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class