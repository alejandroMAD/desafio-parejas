<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinJuego
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
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelDerecho = New System.Windows.Forms.Panel()
        Me.panelIzquierdo = New System.Windows.Forms.Panel()
        Me.panelInferior = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pboxFinJuego = New System.Windows.Forms.PictureBox()
        Me.lblMensajeFinal = New System.Windows.Forms.Label()
        Me.lblSaldoFinal = New System.Windows.Forms.Label()
        Me.panelTitulo.SuspendLayout()
        CType(Me.pboxFinJuego, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.panelTitulo.Controls.Add(Me.lblTitulo)
        Me.panelTitulo.Controls.Add(Me.btnCerrar)
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(584, 36)
        Me.panelTitulo.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitulo.Location = New System.Drawing.Point(142, 1)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(284, 33)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "F i n  d e  l a  p a r t i d a"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Parejas.My.Resources.Resources.materialclose_yellow
        Me.btnCerrar.Location = New System.Drawing.Point(550, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(24, 24)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'panelDerecho
        '
        Me.panelDerecho.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.panelDerecho.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelDerecho.Location = New System.Drawing.Point(582, 36)
        Me.panelDerecho.Name = "panelDerecho"
        Me.panelDerecho.Size = New System.Drawing.Size(2, 245)
        Me.panelDerecho.TabIndex = 1
        '
        'panelIzquierdo
        '
        Me.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelIzquierdo.Location = New System.Drawing.Point(0, 36)
        Me.panelIzquierdo.Name = "panelIzquierdo"
        Me.panelIzquierdo.Size = New System.Drawing.Size(2, 245)
        Me.panelIzquierdo.TabIndex = 2
        '
        'panelInferior
        '
        Me.panelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelInferior.Location = New System.Drawing.Point(2, 279)
        Me.panelInferior.Name = "panelInferior"
        Me.panelInferior.Size = New System.Drawing.Size(580, 2)
        Me.panelInferior.TabIndex = 3
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(234, 232)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(112, 32)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'pboxFinJuego
        '
        Me.pboxFinJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pboxFinJuego.Location = New System.Drawing.Point(24, 48)
        Me.pboxFinJuego.Name = "pboxFinJuego"
        Me.pboxFinJuego.Size = New System.Drawing.Size(220, 170)
        Me.pboxFinJuego.TabIndex = 7
        Me.pboxFinJuego.TabStop = False
        '
        'lblMensajeFinal
        '
        Me.lblMensajeFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeFinal.Location = New System.Drawing.Point(262, 63)
        Me.lblMensajeFinal.Name = "lblMensajeFinal"
        Me.lblMensajeFinal.Size = New System.Drawing.Size(300, 56)
        Me.lblMensajeFinal.TabIndex = 8
        Me.lblMensajeFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSaldoFinal
        '
        Me.lblSaldoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoFinal.Location = New System.Drawing.Point(262, 143)
        Me.lblSaldoFinal.Name = "lblSaldoFinal"
        Me.lblSaldoFinal.Size = New System.Drawing.Size(300, 56)
        Me.lblSaldoFinal.TabIndex = 9
        Me.lblSaldoFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFinJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 281)
        Me.Controls.Add(Me.lblSaldoFinal)
        Me.Controls.Add(Me.lblMensajeFinal)
        Me.Controls.Add(Me.pboxFinJuego)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.panelInferior)
        Me.Controls.Add(Me.panelIzquierdo)
        Me.Controls.Add(Me.panelDerecho)
        Me.Controls.Add(Me.panelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFinJuego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFinJuego"
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        CType(Me.pboxFinJuego, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTitulo As Panel
    Friend WithEvents panelDerecho As Panel
    Friend WithEvents panelIzquierdo As Panel
    Friend WithEvents panelInferior As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents pboxFinJuego As PictureBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblMensajeFinal As Label
    Friend WithEvents lblSaldoFinal As Label
End Class
