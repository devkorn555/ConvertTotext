<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.btn2 = New MetroFramework.Controls.MetroButton()
        Me.btn3 = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btn1 = New MetroFramework.Controls.MetroButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn4 = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBox1.CustomButton.Image = Nothing
        Me.TextBox1.CustomButton.Location = New System.Drawing.Point(42, 2)
        Me.TextBox1.CustomButton.Name = ""
        Me.TextBox1.CustomButton.Size = New System.Drawing.Size(529, 529)
        Me.TextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBox1.CustomButton.TabIndex = 1
        Me.TextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBox1.CustomButton.UseSelectable = True
        Me.TextBox1.CustomButton.Visible = False
        Me.TextBox1.Lines = New String(-1) {}
        Me.TextBox1.Location = New System.Drawing.Point(614, 154)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.ShortcutsEnabled = True
        Me.TextBox1.Size = New System.Drawing.Size(574, 534)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.UseCustomBackColor = True
        Me.TextBox1.UseSelectable = True
        Me.TextBox1.WaterMarkColor = System.Drawing.Color.White
        Me.TextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn2
        '
        Me.btn2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn2.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn2.Location = New System.Drawing.Point(736, 110)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(109, 38)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Scan"
        Me.btn2.UseCustomBackColor = True
        Me.btn2.UseCustomForeColor = True
        Me.btn2.UseSelectable = True
        '
        'btn3
        '
        Me.btn3.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn3.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn3.Location = New System.Drawing.Point(851, 110)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(109, 38)
        Me.btn3.TabIndex = 1
        Me.btn3.Text = "Copy"
        Me.btn3.UseCustomBackColor = True
        Me.btn3.UseCustomForeColor = True
        Me.btn3.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 50)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(22, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Convert to Text"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(1169, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 23
        Me.ComboBox1.Items.AddRange(New Object() {"English", "Thai", "Lao", "Japan", "Malay", "Latin"})
        Me.ComboBox1.Location = New System.Drawing.Point(736, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 29)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(619, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Choose Languae"
        '
        'BackgroundWorker1
        '
        '
        'btn1
        '
        Me.btn1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn1.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn1.Location = New System.Drawing.Point(621, 110)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(109, 38)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Browse"
        Me.btn1.UseCustomBackColor = True
        Me.btn1.UseCustomForeColor = True
        Me.btn1.UseSelectable = True
        Me.btn1.UseStyleColors = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(8, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(595, 632)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btn4
        '
        Me.btn4.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btn4.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn4.Location = New System.Drawing.Point(966, 110)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(109, 38)
        Me.btn4.TabIndex = 1
        Me.btn4.Text = "Clear"
        Me.btn4.UseCustomBackColor = True
        Me.btn4.UseCustomForeColor = True
        Me.btn4.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn4 As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label
End Class
