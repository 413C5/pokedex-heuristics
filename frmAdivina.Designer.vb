<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdivina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdivina))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnReintentar = New System.Windows.Forms.Button()
        Me.btnOp4 = New System.Windows.Forms.Button()
        Me.btnOp3 = New System.Windows.Forms.Button()
        Me.btnOp2 = New System.Windows.Forms.Button()
        Me.btnOp1 = New System.Windows.Forms.Button()
        Me.labAnunciador = New System.Windows.Forms.Label()
        Me.picPokemon = New System.Windows.Forms.PictureBox()
        CType(Me.picPokemon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(525, 408)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 29)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnReintentar
        '
        Me.btnReintentar.Location = New System.Drawing.Point(505, 254)
        Me.btnReintentar.Name = "btnReintentar"
        Me.btnReintentar.Size = New System.Drawing.Size(148, 29)
        Me.btnReintentar.TabIndex = 4
        Me.btnReintentar.Text = "&Intentar con otro"
        Me.btnReintentar.UseVisualStyleBackColor = True
        '
        'btnOp4
        '
        Me.btnOp4.Location = New System.Drawing.Point(479, 209)
        Me.btnOp4.Name = "btnOp4"
        Me.btnOp4.Size = New System.Drawing.Size(194, 29)
        Me.btnOp4.TabIndex = 3
        Me.btnOp4.Text = "Button4"
        Me.btnOp4.UseVisualStyleBackColor = True
        '
        'btnOp3
        '
        Me.btnOp3.Location = New System.Drawing.Point(479, 165)
        Me.btnOp3.Name = "btnOp3"
        Me.btnOp3.Size = New System.Drawing.Size(194, 29)
        Me.btnOp3.TabIndex = 2
        Me.btnOp3.Text = "Button3"
        Me.btnOp3.UseVisualStyleBackColor = True
        '
        'btnOp2
        '
        Me.btnOp2.Location = New System.Drawing.Point(479, 119)
        Me.btnOp2.Name = "btnOp2"
        Me.btnOp2.Size = New System.Drawing.Size(194, 29)
        Me.btnOp2.TabIndex = 1
        Me.btnOp2.Text = "Button2"
        Me.btnOp2.UseVisualStyleBackColor = True
        '
        'btnOp1
        '
        Me.btnOp1.Location = New System.Drawing.Point(479, 73)
        Me.btnOp1.Name = "btnOp1"
        Me.btnOp1.Size = New System.Drawing.Size(194, 29)
        Me.btnOp1.TabIndex = 0
        Me.btnOp1.Text = "Button1"
        Me.btnOp1.UseVisualStyleBackColor = True
        '
        'labAnunciador
        '
        Me.labAnunciador.BackColor = System.Drawing.Color.Transparent
        Me.labAnunciador.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labAnunciador.Location = New System.Drawing.Point(367, 9)
        Me.labAnunciador.Name = "labAnunciador"
        Me.labAnunciador.Size = New System.Drawing.Size(432, 58)
        Me.labAnunciador.TabIndex = 0
        Me.labAnunciador.Text = "¿Quien es ese Pokémon?"
        Me.labAnunciador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picPokemon
        '
        Me.picPokemon.BackColor = System.Drawing.Color.Transparent
        Me.picPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picPokemon.Location = New System.Drawing.Point(83, 68)
        Me.picPokemon.Name = "picPokemon"
        Me.picPokemon.Size = New System.Drawing.Size(281, 249)
        Me.picPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPokemon.TabIndex = 8
        Me.picPokemon.TabStop = False
        '
        'frmAdivina
        '
        Me.AcceptButton = Me.btnReintentar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnReintentar)
        Me.Controls.Add(Me.btnOp4)
        Me.Controls.Add(Me.btnOp3)
        Me.Controls.Add(Me.btnOp2)
        Me.Controls.Add(Me.btnOp1)
        Me.Controls.Add(Me.labAnunciador)
        Me.Controls.Add(Me.picPokemon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdivina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "¿Quién es ese Pokémon?"
        CType(Me.picPokemon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnReintentar As Button
    Friend WithEvents btnOp4 As Button
    Friend WithEvents btnOp3 As Button
    Friend WithEvents btnOp2 As Button
    Friend WithEvents btnOp1 As Button
    Friend WithEvents labAnunciador As Label
    Friend WithEvents picPokemon As PictureBox
End Class
