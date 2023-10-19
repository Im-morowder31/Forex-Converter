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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.PictureBox()
        Me.btnSwitch = New System.Windows.Forms.PictureBox()
        CType(Me.btnConvert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.MintCream
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"From", "US Dollar", "Hong Kong Dollar", "Canadian Dollar", "Indian Rupee", "Sri Lankan Rupee", "UAE Dinar", "Philippine Peso", "UK Pound", "Japan Yen", "Euro"})
        Me.ComboBox1.Location = New System.Drawing.Point(77, 112)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 32)
        Me.ComboBox1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.MintCream
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Items.AddRange(New Object() {"To", "US Dollar", "Hong Kong Dollar", "Canadian Dollar", "Indian Rupee", "Sri Lankan Rupee", "UAE Dinar", "Philippine Peso", "UK Pound", "Japan Yen", "Euro"})
        Me.ComboBox2.Location = New System.Drawing.Point(463, 112)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(197, 32)
        Me.ComboBox2.TabIndex = 2
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.BackColor = System.Drawing.Color.White
        Me.TextBoxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAmount.Location = New System.Drawing.Point(77, 177)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(197, 44)
        Me.TextBoxAmount.TabIndex = 3
        '
        'TextBoxResult
        '
        Me.TextBoxResult.BackColor = System.Drawing.Color.White
        Me.TextBoxResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResult.Location = New System.Drawing.Point(463, 177)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.ReadOnly = True
        Me.TextBoxResult.Size = New System.Drawing.Size(197, 44)
        Me.TextBoxResult.TabIndex = 4
        Me.TextBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.Transparent
        Me.btnConvert.Image = Global.ForexConverter.My.Resources.Resources.Frame_4
        Me.btnConvert.Location = New System.Drawing.Point(304, 200)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(131, 73)
        Me.btnConvert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.Image = Global.ForexConverter.My.Resources.Resources.Frame_11
        Me.btnClear.Location = New System.Drawing.Point(321, 283)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 58)
        Me.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClear.TabIndex = 6
        Me.btnClear.TabStop = False
        '
        'btnSwitch
        '
        Me.btnSwitch.BackColor = System.Drawing.Color.Transparent
        Me.btnSwitch.Image = Global.ForexConverter.My.Resources.Resources.Workgroup_Switch_removebg_preview
        Me.btnSwitch.Location = New System.Drawing.Point(321, 94)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(95, 65)
        Me.btnSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSwitch.TabIndex = 7
        Me.btnSwitch.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ForexConverter.My.Resources.Resources.Untitled2nd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 362)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.TextBoxAmount)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forex Converter"
        CType(Me.btnConvert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents btnConvert As PictureBox
    Friend WithEvents btnClear As PictureBox
    Friend WithEvents btnSwitch As PictureBox
End Class
