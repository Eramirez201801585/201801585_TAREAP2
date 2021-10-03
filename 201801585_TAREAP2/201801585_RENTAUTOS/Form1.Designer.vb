<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chbTarjeta = New System.Windows.Forms.CheckBox()
        Me.chbEfectivo = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTarjeta = New System.Windows.Forms.TextBox()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnProcesar = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLimpiarEntradas = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLimpiarVectores = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ltbTotal = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ltbTarjeta = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ltbEfectivo = New System.Windows.Forms.ListBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ltbPrecioParcial = New System.Windows.Forms.ListBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ltbRecargo = New System.Windows.Forms.ListBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ltbDescuento = New System.Windows.Forms.ListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ltbDias = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ltbPlaca = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ltbMarca = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ltbNit = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ltbNombre = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txtDias)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chbTarjeta)
        Me.GroupBox4.Controls.Add(Me.chbEfectivo)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtTarjeta)
        Me.GroupBox4.Controls.Add(Me.txtEfectivo)
        Me.GroupBox4.Location = New System.Drawing.Point(420, 23)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(150, 72)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pago"
        '
        'chbTarjeta
        '
        Me.chbTarjeta.AutoSize = True
        Me.chbTarjeta.Location = New System.Drawing.Point(8, 43)
        Me.chbTarjeta.Name = "chbTarjeta"
        Me.chbTarjeta.Size = New System.Drawing.Size(61, 19)
        Me.chbTarjeta.TabIndex = 11
        Me.chbTarjeta.Text = "Tarjeta"
        Me.chbTarjeta.UseVisualStyleBackColor = True
        '
        'chbEfectivo
        '
        Me.chbEfectivo.AutoSize = True
        Me.chbEfectivo.Location = New System.Drawing.Point(8, 23)
        Me.chbEfectivo.Name = "chbEfectivo"
        Me.chbEfectivo.Size = New System.Drawing.Size(68, 19)
        Me.chbEfectivo.TabIndex = 10
        Me.chbEfectivo.Text = "Efectivo"
        Me.chbEfectivo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(124, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(123, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "%"
        '
        'txtTarjeta
        '
        Me.txtTarjeta.Location = New System.Drawing.Point(77, 44)
        Me.txtTarjeta.Name = "txtTarjeta"
        Me.txtTarjeta.Size = New System.Drawing.Size(41, 23)
        Me.txtTarjeta.TabIndex = 2
        Me.txtTarjeta.Visible = False
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Location = New System.Drawing.Point(77, 19)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(41, 23)
        Me.txtEfectivo.TabIndex = 1
        Me.txtEfectivo.Visible = False
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(266, 100)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(121, 23)
        Me.txtDias.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Días"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPlaca)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbMarca)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(214, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 106)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Alquiler"
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(52, 48)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(121, 23)
        Me.txtPlaca.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Placa"
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Items.AddRange(New Object() {"Honda", "MercedesBenz", "Toyota", "Mazda"})
        Me.cmbMarca.Location = New System.Drawing.Point(52, 20)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(121, 23)
        Me.cmbMarca.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Marca"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 79)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Cliente"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(64, 49)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(100, 23)
        Me.txtNit.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIT"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(64, 20)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 23)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Maroon
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesar, Me.LimpiarEntradasToolStripMenuItem, Me.btnSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 362)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(888, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnProcesar
        '
        Me.btnProcesar.ForeColor = System.Drawing.Color.White
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(64, 20)
        Me.btnProcesar.Text = "&Procesar"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.LimpiarEntradasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnLimpiarEntradas, Me.btnLimpiarVectores})
        Me.LimpiarEntradasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "&Limpiar"
        '
        'btnLimpiarEntradas
        '
        Me.btnLimpiarEntradas.BackColor = System.Drawing.Color.Maroon
        Me.btnLimpiarEntradas.ForeColor = System.Drawing.Color.White
        Me.btnLimpiarEntradas.Name = "btnLimpiarEntradas"
        Me.btnLimpiarEntradas.Size = New System.Drawing.Size(119, 22)
        Me.btnLimpiarEntradas.Text = "&Entradas"
        '
        'btnLimpiarVectores
        '
        Me.btnLimpiarVectores.BackColor = System.Drawing.Color.Maroon
        Me.btnLimpiarVectores.ForeColor = System.Drawing.Color.White
        Me.btnLimpiarVectores.Name = "btnLimpiarVectores"
        Me.btnLimpiarVectores.Size = New System.Drawing.Size(119, 22)
        Me.btnLimpiarVectores.Text = "&Vectores"
        '
        'btnSalir
        '
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(41, 20)
        Me.btnSalir.Text = "&Salir"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.ltbTotal)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.ltbTarjeta)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.ltbEfectivo)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.ltbPrecioParcial)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.ltbRecargo)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.ltbDescuento)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.ltbDias)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.ltbPlaca)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.ltbMarca)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.ltbNit)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.ltbNombre)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 154)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(863, 205)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Resultados"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(795, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 15)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "TOTAL"
        '
        'ltbTotal
        '
        Me.ltbTotal.FormattingEnabled = True
        Me.ltbTotal.ItemHeight = 15
        Me.ltbTotal.Location = New System.Drawing.Point(795, 60)
        Me.ltbTotal.Name = "ltbTotal"
        Me.ltbTotal.Size = New System.Drawing.Size(58, 124)
        Me.ltbTotal.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(731, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 15)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Tarjeta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(731, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Subtotal"
        '
        'ltbTarjeta
        '
        Me.ltbTarjeta.FormattingEnabled = True
        Me.ltbTarjeta.ItemHeight = 15
        Me.ltbTarjeta.Location = New System.Drawing.Point(731, 60)
        Me.ltbTarjeta.Name = "ltbTarjeta"
        Me.ltbTarjeta.Size = New System.Drawing.Size(58, 124)
        Me.ltbTarjeta.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(667, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Efectivo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(667, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 15)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Subtotal"
        '
        'ltbEfectivo
        '
        Me.ltbEfectivo.FormattingEnabled = True
        Me.ltbEfectivo.ItemHeight = 15
        Me.ltbEfectivo.Location = New System.Drawing.Point(667, 60)
        Me.ltbEfectivo.Name = "ltbEfectivo"
        Me.ltbEfectivo.Size = New System.Drawing.Size(58, 124)
        Me.ltbEfectivo.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(448, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 15)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Precio Parcial"
        '
        'ltbPrecioParcial
        '
        Me.ltbPrecioParcial.FormattingEnabled = True
        Me.ltbPrecioParcial.ItemHeight = 15
        Me.ltbPrecioParcial.Location = New System.Drawing.Point(448, 60)
        Me.ltbPrecioParcial.Name = "ltbPrecioParcial"
        Me.ltbPrecioParcial.Size = New System.Drawing.Size(80, 124)
        Me.ltbPrecioParcial.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(603, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 15)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Recargo"
        '
        'ltbRecargo
        '
        Me.ltbRecargo.FormattingEnabled = True
        Me.ltbRecargo.ItemHeight = 15
        Me.ltbRecargo.Location = New System.Drawing.Point(603, 60)
        Me.ltbRecargo.Name = "ltbRecargo"
        Me.ltbRecargo.Size = New System.Drawing.Size(58, 124)
        Me.ltbRecargo.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(534, 39)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 15)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Descuento"
        '
        'ltbDescuento
        '
        Me.ltbDescuento.FormattingEnabled = True
        Me.ltbDescuento.ItemHeight = 15
        Me.ltbDescuento.Location = New System.Drawing.Point(534, 60)
        Me.ltbDescuento.Name = "ltbDescuento"
        Me.ltbDescuento.Size = New System.Drawing.Size(63, 124)
        Me.ltbDescuento.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(355, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 15)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Días de alquiler"
        '
        'ltbDias
        '
        Me.ltbDias.FormattingEnabled = True
        Me.ltbDias.ItemHeight = 15
        Me.ltbDias.Location = New System.Drawing.Point(355, 60)
        Me.ltbDias.Name = "ltbDias"
        Me.ltbDias.Size = New System.Drawing.Size(87, 124)
        Me.ltbDias.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(266, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 15)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Placa"
        '
        'ltbPlaca
        '
        Me.ltbPlaca.FormattingEnabled = True
        Me.ltbPlaca.ItemHeight = 15
        Me.ltbPlaca.Location = New System.Drawing.Point(266, 60)
        Me.ltbPlaca.Name = "ltbPlaca"
        Me.ltbPlaca.Size = New System.Drawing.Size(83, 124)
        Me.ltbPlaca.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(177, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 15)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Marca"
        '
        'ltbMarca
        '
        Me.ltbMarca.FormattingEnabled = True
        Me.ltbMarca.ItemHeight = 15
        Me.ltbMarca.Location = New System.Drawing.Point(177, 60)
        Me.ltbMarca.Name = "ltbMarca"
        Me.ltbMarca.Size = New System.Drawing.Size(83, 124)
        Me.ltbMarca.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(92, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "NIT"
        '
        'ltbNit
        '
        Me.ltbNit.FormattingEnabled = True
        Me.ltbNit.ItemHeight = 15
        Me.ltbNit.Location = New System.Drawing.Point(92, 60)
        Me.ltbNit.Name = "ltbNit"
        Me.ltbNit.Size = New System.Drawing.Size(79, 124)
        Me.ltbNit.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Nombre"
        '
        'ltbNombre
        '
        Me.ltbNombre.FormattingEnabled = True
        Me.ltbNombre.ItemHeight = 15
        Me.ltbNombre.Location = New System.Drawing.Point(7, 61)
        Me.ltbNombre.Name = "ltbNombre"
        Me.ltbNombre.Size = New System.Drawing.Size(79, 124)
        Me.ltbNombre.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201801585_RENTAUTOS.My.Resources.Resources.fONDO
        Me.ClientSize = New System.Drawing.Size(888, 386)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "RENTAUTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDias As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTarjeta As TextBox
    Friend WithEvents txtEfectivo As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnProcesar As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSalir As ToolStripMenuItem
    Friend WithEvents btnLimpiarEntradas As ToolStripMenuItem
    Friend WithEvents btnLimpiarVectores As ToolStripMenuItem
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ltbNit As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ltbNombre As ListBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ltbRecargo As ListBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ltbDescuento As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ltbDias As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ltbPlaca As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ltbMarca As ListBox
    Friend WithEvents Label21 As Label
    Friend WithEvents ltbPrecioParcial As ListBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ltbEfectivo As ListBox
    Friend WithEvents chbTarjeta As CheckBox
    Friend WithEvents chbEfectivo As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ltbTotal As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ltbTarjeta As ListBox
    Friend WithEvents Label6 As Label
End Class
