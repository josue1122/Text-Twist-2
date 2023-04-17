Public Class frmJuego
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub lblPuntos_Click(sender As Object, e As EventArgs) Handles lblPuntos.Click

    End Sub

    Private tiempoRestante As Integer = 120 'Dos minutos en segundos

    Private Sub frmJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblHora.Text = String.Format("{0:m\:ss}", TimeSpan.FromSeconds(tiempoRestante))
        Timer1.Interval = 1000 'Un segundo
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempoRestante -= 1
        If tiempoRestante >= 0 Then
            Me.lblHora.Text = String.Format("{0:m\:ss}", TimeSpan.FromSeconds(tiempoRestante))
        Else
            Timer1.Stop()
            'Aquí es donde puedes hacer cualquier cosa que necesites hacer cuando el tiempo se agote
        End If
    End Sub



End Class