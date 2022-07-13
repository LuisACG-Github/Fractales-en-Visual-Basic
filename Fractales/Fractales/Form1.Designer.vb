<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Picture_Plano = New System.Windows.Forms.PictureBox()
        Me.Text_Iteracion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_Graficar = New System.Windows.Forms.Button()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_Op = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox_An = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_Variantes = New System.Windows.Forms.ComboBox()
        CType(Me.Picture_Plano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture_Plano
        '
        Me.Picture_Plano.BackColor = System.Drawing.Color.DimGray
        Me.Picture_Plano.Location = New System.Drawing.Point(229, 7)
        Me.Picture_Plano.Name = "Picture_Plano"
        Me.Picture_Plano.Size = New System.Drawing.Size(800, 800)
        Me.Picture_Plano.TabIndex = 2
        Me.Picture_Plano.TabStop = False
        Me.Picture_Plano.UseWaitCursor = True
        '
        'Text_Iteracion
        '
        Me.Text_Iteracion.BackColor = System.Drawing.Color.DodgerBlue
        Me.Text_Iteracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Iteracion.ForeColor = System.Drawing.Color.White
        Me.Text_Iteracion.Location = New System.Drawing.Point(12, 35)
        Me.Text_Iteracion.Name = "Text_Iteracion"
        Me.Text_Iteracion.Size = New System.Drawing.Size(211, 22)
        Me.Text_Iteracion.TabIndex = 1
        Me.Text_Iteracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 774)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 33)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fractales"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 754)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Luis Alfredo Cervantes González"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_Graficar
        '
        Me.Button_Graficar.BackColor = System.Drawing.Color.DimGray
        Me.Button_Graficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Graficar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Graficar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Graficar.Location = New System.Drawing.Point(12, 228)
        Me.Button_Graficar.Name = "Button_Graficar"
        Me.Button_Graficar.Size = New System.Drawing.Size(211, 29)
        Me.Button_Graficar.TabIndex = 3
        Me.Button_Graficar.Text = "Graficar"
        Me.Button_Graficar.UseVisualStyleBackColor = False
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.BackColor = System.Drawing.Color.DimGray
        Me.Button_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Limpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Limpiar.Location = New System.Drawing.Point(12, 263)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(211, 29)
        Me.Button_Limpiar.TabIndex = 4
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "¿Qué tamaño deseas?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "¿Cuántas iteraciones deseas?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_Op
        '
        Me.ComboBox_Op.BackColor = System.Drawing.Color.DodgerBlue
        Me.ComboBox_Op.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_Op.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Op.ForeColor = System.Drawing.Color.White
        Me.ComboBox_Op.FormattingEnabled = True
        Me.ComboBox_Op.Items.AddRange(New Object() {"Fractal de Mandelbrot", "Fractal de Julia"})
        Me.ComboBox_Op.Location = New System.Drawing.Point(12, 143)
        Me.ComboBox_Op.Name = "ComboBox_Op"
        Me.ComboBox_Op.Size = New System.Drawing.Size(211, 24)
        Me.ComboBox_Op.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(12, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Selecciona un Fractal"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_An
        '
        Me.ComboBox_An.BackColor = System.Drawing.Color.DodgerBlue
        Me.ComboBox_An.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_An.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_An.ForeColor = System.Drawing.Color.White
        Me.ComboBox_An.FormattingEnabled = True
        Me.ComboBox_An.Items.AddRange(New Object() {"Escala al 20%", "Escala al 40%", "Escala al 60%", "Escala al 80%", "Escala al 100%"})
        Me.ComboBox_An.Location = New System.Drawing.Point(12, 88)
        Me.ComboBox_An.Name = "ComboBox_An"
        Me.ComboBox_An.Size = New System.Drawing.Size(211, 24)
        Me.ComboBox_An.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(12, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Variantes del fractal de Julia"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_Variantes
        '
        Me.ComboBox_Variantes.BackColor = System.Drawing.Color.DodgerBlue
        Me.ComboBox_Variantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox_Variantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Variantes.ForeColor = System.Drawing.Color.White
        Me.ComboBox_Variantes.FormattingEnabled = True
        Me.ComboBox_Variantes.Items.AddRange(New Object() {"C= -0.72 & 0.196i", "C= 0.285 & -0.01i  ", "C= -0.8 & 0.0i", "C= 0.0 & 0.8", "C= -0.8 & -0.25i"})
        Me.ComboBox_Variantes.Location = New System.Drawing.Point(12, 198)
        Me.ComboBox_Variantes.Name = "ComboBox_Variantes"
        Me.ComboBox_Variantes.Size = New System.Drawing.Size(211, 24)
        Me.ComboBox_Variantes.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1041, 819)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox_Variantes)
        Me.Controls.Add(Me.ComboBox_An)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox_Op)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text_Iteracion)
        Me.Controls.Add(Me.Picture_Plano)
        Me.Controls.Add(Me.Button_Limpiar)
        Me.Controls.Add(Me.Button_Graficar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Fractales"
        CType(Me.Picture_Plano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Picture_Plano As PictureBox
    Friend WithEvents Text_Iteracion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button_Graficar As Button
    Friend WithEvents Button_Limpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox_Op As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox_An As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_Variantes As ComboBox
End Class
