<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJuego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJuego))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.lblRonda = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblHora = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(35, 58)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1170, 251)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("SF Pro Display", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(269, 600)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 54)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ENTER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("SF Pro Display", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(510, 600)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(228, 54)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("SF Pro Display", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(753, 600)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(228, 54)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "TWIST"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("SF Pro Display", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(492, 660)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(263, 85)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "NEXT LEVEL"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("SF Pro Display", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SCORE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("SF Pro Display", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(214, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "TIME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("SF Pro Display", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(410, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ROUND:"
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoSize = True
        Me.lblPuntos.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblPuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPuntos.Font = New System.Drawing.Font("SF Pro Display", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblPuntos.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPuntos.Location = New System.Drawing.Point(98, 9)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(64, 26)
        Me.lblPuntos.TabIndex = 10
        Me.lblPuntos.Text = "0000"
        '
        'lblRonda
        '
        Me.lblRonda.AutoSize = True
        Me.lblRonda.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblRonda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRonda.Font = New System.Drawing.Font("SF Pro Display", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblRonda.ForeColor = System.Drawing.SystemColors.Control
        Me.lblRonda.Location = New System.Drawing.Point(501, 9)
        Me.lblRonda.Name = "lblRonda"
        Me.lblRonda.Size = New System.Drawing.Size(21, 26)
        Me.lblRonda.TabIndex = 11
        Me.lblRonda.Text = "1"
        '
        'Timer1
        '
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHora.Font = New System.Drawing.Font("SF Pro Display", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblHora.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHora.Location = New System.Drawing.Point(280, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(64, 26)
        Me.lblHora.TabIndex = 12
        Me.lblHora.Text = "0000"
        '
        'frmJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1241, 757)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblRonda)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmJuego"
        Me.Text = "frmJuego"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPuntos As Label
    Friend WithEvents lblRonda As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblHora As Label
End Class
