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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTimed = New System.Windows.Forms.Button()
        Me.btnUntimed = New System.Windows.Forms.Button()
        Me.btnSound = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("SF Pro Display", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(82, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1050, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REARRANGE LETTERS TO MAKE AS MANY WORDS AS YOU CAN!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTimed
        '
        Me.btnTimed.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTimed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTimed.Font = New System.Drawing.Font("SF Pro Display", 26.25!, System.Drawing.FontStyle.Bold)
        Me.btnTimed.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTimed.Location = New System.Drawing.Point(235, 446)
        Me.btnTimed.Name = "btnTimed"
        Me.btnTimed.Size = New System.Drawing.Size(276, 90)
        Me.btnTimed.TabIndex = 2
        Me.btnTimed.Text = "TIMED"
        Me.btnTimed.UseVisualStyleBackColor = False
        '
        'btnUntimed
        '
        Me.btnUntimed.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUntimed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUntimed.Font = New System.Drawing.Font("SF Pro Display", 26.25!, System.Drawing.FontStyle.Bold)
        Me.btnUntimed.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUntimed.Location = New System.Drawing.Point(673, 446)
        Me.btnUntimed.Name = "btnUntimed"
        Me.btnUntimed.Size = New System.Drawing.Size(276, 90)
        Me.btnUntimed.TabIndex = 3
        Me.btnUntimed.Text = "UNTIMED"
        Me.btnUntimed.UseVisualStyleBackColor = False
        '
        'btnSound
        '
        Me.btnSound.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSound.Image = CType(resources.GetObject("btnSound.Image"), System.Drawing.Image)
        Me.btnSound.Location = New System.Drawing.Point(547, 592)
        Me.btnSound.Name = "btnSound"
        Me.btnSound.Size = New System.Drawing.Size(86, 87)
        Me.btnSound.TabIndex = 4
        Me.btnSound.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TextTwist2.My.Resources.Resources._81Y2lHoTFqL_transformed_transformed
        Me.PictureBox1.Image = Global.TextTwist2.My.Resources.Resources._81Y2lHoTFqL_transformed_transformed
        Me.PictureBox1.Location = New System.Drawing.Point(89, -66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(774, 340)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1216, 742)
        Me.Controls.Add(Me.btnSound)
        Me.Controls.Add(Me.btnUntimed)
        Me.Controls.Add(Me.btnTimed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "TextTwist2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTimed As Button
    Friend WithEvents btnUntimed As Button
    Friend WithEvents btnSound As Button
End Class
