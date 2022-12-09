Imports System.Runtime.InteropServices

Public Class frmFinJuego

    Private Sub FormFinJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pboxFinJuego.BackgroundImageLayout = ImageLayout.Zoom
        Me.TopMost = True
    End Sub

    Private Sub BotonesCierre_Click(sender As Object, e As EventArgs) Handles btnVolver.Click, btnCerrar.Click
        Me.Close()
    End Sub

#Region "Arrastre de la interfaz"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub Controles_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, panelTitulo.MouseMove,
                            lblTitulo.MouseMove, pboxFinJuego.MouseMove, lblMensajeFinal.MouseMove, lblSaldoFinal.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region

End Class