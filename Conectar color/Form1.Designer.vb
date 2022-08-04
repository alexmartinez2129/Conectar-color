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
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.Textcolores = New System.Windows.Forms.TextBox()
        Me.BtnRosado = New System.Windows.Forms.Button()
        Me.BtnAzul = New System.Windows.Forms.Button()
        Me.BtnNaranja = New System.Windows.Forms.Button()
        Me.BtnVerde = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRojo
        '
        Me.btnRojo.BackColor = System.Drawing.Color.Red
        Me.btnRojo.Location = New System.Drawing.Point(29, 90)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(114, 48)
        Me.btnRojo.TabIndex = 0
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = False
        '
        'Textcolores
        '
        Me.Textcolores.Location = New System.Drawing.Point(248, 105)
        Me.Textcolores.Multiline = True
        Me.Textcolores.Name = "Textcolores"
        Me.Textcolores.Size = New System.Drawing.Size(569, 322)
        Me.Textcolores.TabIndex = 1
        '
        'BtnRosado
        '
        Me.BtnRosado.BackColor = System.Drawing.Color.HotPink
        Me.BtnRosado.Location = New System.Drawing.Point(29, 154)
        Me.BtnRosado.Name = "BtnRosado"
        Me.BtnRosado.Size = New System.Drawing.Size(114, 48)
        Me.BtnRosado.TabIndex = 2
        Me.BtnRosado.Text = "Rosado"
        Me.BtnRosado.UseVisualStyleBackColor = False
        '
        'BtnAzul
        '
        Me.BtnAzul.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnAzul.Location = New System.Drawing.Point(29, 221)
        Me.BtnAzul.Name = "BtnAzul"
        Me.BtnAzul.Size = New System.Drawing.Size(114, 48)
        Me.BtnAzul.TabIndex = 3
        Me.BtnAzul.Text = "Azul"
        Me.BtnAzul.UseVisualStyleBackColor = False
        '
        'BtnNaranja
        '
        Me.BtnNaranja.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnNaranja.Location = New System.Drawing.Point(29, 289)
        Me.BtnNaranja.Name = "BtnNaranja"
        Me.BtnNaranja.Size = New System.Drawing.Size(114, 48)
        Me.BtnNaranja.TabIndex = 4
        Me.BtnNaranja.Text = "Naranja"
        Me.BtnNaranja.UseVisualStyleBackColor = False
        '
        'BtnVerde
        '
        Me.BtnVerde.BackColor = System.Drawing.Color.Lime
        Me.BtnVerde.Location = New System.Drawing.Point(29, 352)
        Me.BtnVerde.Name = "BtnVerde"
        Me.BtnVerde.Size = New System.Drawing.Size(114, 48)
        Me.BtnVerde.TabIndex = 5
        Me.BtnVerde.Text = "Verde"
        Me.BtnVerde.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(386, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 55)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Conectar Colores"
        Me.Label1.UseMnemonic = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(29, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Verde"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(933, 468)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnVerde)
        Me.Controls.Add(Me.BtnNaranja)
        Me.Controls.Add(Me.BtnAzul)
        Me.Controls.Add(Me.BtnRosado)
        Me.Controls.Add(Me.Textcolores)
        Me.Controls.Add(Me.btnRojo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRojo As Button
    Friend WithEvents Textcolores As TextBox
    Friend WithEvents BtnRosado As Button
    Friend WithEvents BtnAzul As Button
    Friend WithEvents BtnNaranja As Button
    Friend WithEvents BtnVerde As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
