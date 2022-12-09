<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panelCartas = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblReloj = New System.Windows.Forms.Label()
        Me.lblPuntuacion = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panelDerecho = New System.Windows.Forms.Panel()
        Me.panelIzquierdo = New System.Windows.Forms.Panel()
        Me.panelInferior = New System.Windows.Forms.Panel()
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.lblFallos = New System.Windows.Forms.Label()
        Me.btnFacil = New System.Windows.Forms.Button()
        Me.lblFallosContador = New System.Windows.Forms.Label()
        Me.btnDificil = New System.Windows.Forms.Button()
        Me.lblDificultad = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelCartas
        '
        Me.panelCartas.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.panelCartas.Location = New System.Drawing.Point(16, 56)
        Me.panelCartas.Name = "panelCartas"
        Me.panelCartas.Size = New System.Drawing.Size(510, 512)
        Me.panelCartas.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblReloj
        '
        Me.lblReloj.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblReloj.Font = New System.Drawing.Font("Consolas", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReloj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.lblReloj.Location = New System.Drawing.Point(553, 56)
        Me.lblReloj.Name = "lblReloj"
        Me.lblReloj.Size = New System.Drawing.Size(250, 46)
        Me.lblReloj.TabIndex = 1
        Me.lblReloj.Text = "00:00"
        Me.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPuntuacion
        '
        Me.lblPuntuacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntuacion.Location = New System.Drawing.Point(558, 307)
        Me.lblPuntuacion.Name = "lblPuntuacion"
        Me.lblPuntuacion.Size = New System.Drawing.Size(245, 46)
        Me.lblPuntuacion.TabIndex = 3
        Me.lblPuntuacion.Text = "Puntuación"
        Me.lblPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnIniciar.FlatAppearance.BorderSize = 0
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(558, 516)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(112, 32)
        Me.btnIniciar.TabIndex = 5
        Me.btnIniciar.Text = "Iniciar partida"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(685, 516)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 32)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reiniciar partida"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.panelTitulo.Controls.Add(Me.lblTitulo)
        Me.panelTitulo.Controls.Add(Me.btnMinimizar)
        Me.panelTitulo.Controls.Add(Me.btnCerrar)
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(834, 36)
        Me.panelTitulo.TabIndex = 7
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitulo.Location = New System.Drawing.Point(123, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(310, 33)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "D e s a f í o  d e  p a r e j a s"
        '
        'panelDerecho
        '
        Me.panelDerecho.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.panelDerecho.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelDerecho.Location = New System.Drawing.Point(0, 36)
        Me.panelDerecho.Name = "panelDerecho"
        Me.panelDerecho.Size = New System.Drawing.Size(2, 554)
        Me.panelDerecho.TabIndex = 8
        '
        'panelIzquierdo
        '
        Me.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelIzquierdo.Location = New System.Drawing.Point(832, 36)
        Me.panelIzquierdo.Name = "panelIzquierdo"
        Me.panelIzquierdo.Size = New System.Drawing.Size(2, 554)
        Me.panelIzquierdo.TabIndex = 9
        '
        'panelInferior
        '
        Me.panelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelInferior.Location = New System.Drawing.Point(2, 588)
        Me.panelInferior.Name = "panelInferior"
        Me.panelInferior.Size = New System.Drawing.Size(830, 2)
        Me.panelInferior.TabIndex = 10
        '
        'lblPuntos
        '
        Me.lblPuntos.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblPuntos.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.lblPuntos.Location = New System.Drawing.Point(553, 364)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(250, 46)
        Me.lblPuntos.TabIndex = 11
        Me.lblPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFallos
        '
        Me.lblFallos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFallos.Location = New System.Drawing.Point(558, 261)
        Me.lblFallos.Name = "lblFallos"
        Me.lblFallos.Size = New System.Drawing.Size(100, 46)
        Me.lblFallos.TabIndex = 12
        Me.lblFallos.Text = "Fallos:"
        Me.lblFallos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFacil
        '
        Me.btnFacil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnFacil.FlatAppearance.BorderSize = 0
        Me.btnFacil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacil.Location = New System.Drawing.Point(558, 181)
        Me.btnFacil.Name = "btnFacil"
        Me.btnFacil.Size = New System.Drawing.Size(112, 32)
        Me.btnFacil.TabIndex = 13
        Me.btnFacil.Text = "Fácil"
        Me.btnFacil.UseVisualStyleBackColor = False
        '
        'lblFallosContador
        '
        Me.lblFallosContador.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblFallosContador.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFallosContador.ForeColor = System.Drawing.Color.Black
        Me.lblFallosContador.Location = New System.Drawing.Point(683, 261)
        Me.lblFallosContador.Name = "lblFallosContador"
        Me.lblFallosContador.Size = New System.Drawing.Size(120, 46)
        Me.lblFallosContador.TabIndex = 14
        Me.lblFallosContador.Text = "00"
        Me.lblFallosContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDificil
        '
        Me.btnDificil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnDificil.FlatAppearance.BorderSize = 0
        Me.btnDificil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDificil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDificil.Location = New System.Drawing.Point(691, 181)
        Me.btnDificil.Name = "btnDificil"
        Me.btnDificil.Size = New System.Drawing.Size(112, 32)
        Me.btnDificil.TabIndex = 15
        Me.btnDificil.Text = "Difícil"
        Me.btnDificil.UseVisualStyleBackColor = False
        '
        'lblDificultad
        '
        Me.lblDificultad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDificultad.Location = New System.Drawing.Point(558, 120)
        Me.lblDificultad.Name = "lblDificultad"
        Me.lblDificultad.Size = New System.Drawing.Size(245, 46)
        Me.lblDificultad.TabIndex = 16
        Me.lblDificultad.Text = "Nivel de dificultad"
        Me.lblDificultad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Parejas.My.Resources.Resources.materialmin_yellow
        Me.btnMinimizar.Location = New System.Drawing.Point(772, 5)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(24, 24)
        Me.btnMinimizar.TabIndex = 9
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Parejas.My.Resources.Resources.materialclose_yellow
        Me.btnCerrar.Location = New System.Drawing.Point(798, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(24, 24)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(834, 590)
        Me.Controls.Add(Me.lblDificultad)
        Me.Controls.Add(Me.btnDificil)
        Me.Controls.Add(Me.lblFallosContador)
        Me.Controls.Add(Me.btnFacil)
        Me.Controls.Add(Me.lblFallos)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.panelInferior)
        Me.Controls.Add(Me.panelIzquierdo)
        Me.Controls.Add(Me.panelDerecho)
        Me.Controls.Add(Me.panelTitulo)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.lblPuntuacion)
        Me.Controls.Add(Me.lblReloj)
        Me.Controls.Add(Me.panelCartas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelCartas As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblReloj As Label
    Friend WithEvents lblPuntuacion As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents panelTitulo As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents panelDerecho As Panel
    Friend WithEvents panelIzquierdo As Panel
    Friend WithEvents panelInferior As Panel
    Friend WithEvents lblPuntos As Label
    Friend WithEvents lblFallos As Label
    Friend WithEvents btnFacil As Button
    Friend WithEvents lblFallosContador As Label
    Friend WithEvents btnDificil As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblDificultad As Label
End Class
