Public Class Form1

    Private eleccionJugador As Integer
    Dim puntajeActual As Integer = 0
    Dim puntajeMasAlto As Integer = 0
    Dim eleccionMaquina As Integer
    Private random As New Random()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_racha.Text = "Puntaje mas alto: " + puntajeMasAlto.ToString()
        lb_puntajeActual.Text = "Puntaje actual: " + puntajeActual.ToString()
        generarEleccionMaquina()
    End Sub

    Private Sub generarEleccionMaquina()
        eleccionMaquina = random.Next(1, 4)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_piedra.Click
        eleccionJugador = 1
        calcularResultados()
        generarEleccionMaquina()
    End Sub

    Private Sub btn_papel_Click(sender As Object, e As EventArgs) Handles btn_papel.Click
        eleccionJugador = 2
        calcularResultados()
        generarEleccionMaquina()
    End Sub

    Private Sub btn_tijeras_Click(sender As Object, e As EventArgs) Handles btn_tijeras.Click
        eleccionJugador = 3
        calcularResultados()
        generarEleccionMaquina()
    End Sub

    Private Sub calcularResultados()
        If eleccionMaquina = 1 And eleccionJugador = 3 Or
            eleccionMaquina = 2 And eleccionJugador = 1 Or
            eleccionMaquina = 3 And eleccionJugador = 2 Then
            MessageBox.Show("Gana la maquina")
            puntajeActual = 0
        ElseIf eleccionMaquina = eleccionJugador Then
            MessageBox.Show("Empate")
            puntajeActual = 0
        Else
            MessageBox.Show("Gana el jugador")
            puntajeActual += 1

            If puntajeActual > puntajeMasAlto Then
                puntajeMasAlto = puntajeActual
            End If
        End If
        lb_puntajeActual.Text = "Puntaje actual: " + puntajeActual.ToString()
        lb_racha.Text = "Puntaje mas alto: " + puntajeMasAlto.ToString()
    End Sub

    Private Sub lb_maquina_Click(sender As Object, e As EventArgs) Handles lb_maquina.Click

    End Sub
End Class
