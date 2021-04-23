
Imports Tesseract
Imports System.Drawing
Imports System.ComponentModel
Public Class Form1

    Dim Pos As Point

    Dim engine As TesseractEngine
    Dim img As Pix
    Dim page As Page
    Dim texto As String
    Dim path As String

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Dispose()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim di As New OpenFileDialog
        di.Filter = "Jpg|* jpg| Png|* png"
        If (di.ShowDialog) = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(di.FileName)
            path = di.FileName
        Else
            path = Nothing
            PictureBox1.Image = Nothing
            Exit Sub

        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("There is no any information.", "Scanning...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Clipboard.SetText(TextBox1.Text)
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If path = Nothing Then
            MessageBox.Show("Please Select Your Document!.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ComboBox1.Text = "" Then
            MessageBox.Show("Please Choose Languae!.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            BackgroundWorker1.WorkerReportsProgress = True

            Select Case ComboBox1.Text
                Case "English"
                    engine = New TesseractEngine("tessdata", "eng", EngineMode.Default)
                Case "Thai"
                    engine = New TesseractEngine("tessdata", "tha", EngineMode.Default)
                Case "Lao"
                    engine = New TesseractEngine("tessdata", "lao", EngineMode.Default)
                Case "Japan"
                    engine = New TesseractEngine("tessdata", "jpn", EngineMode.Default)
                Case "Malay"
                    engine = New TesseractEngine("tessdata", "msa", EngineMode.Default)
                Case "Latin"
                    engine = New TesseractEngine("tessdata", "lat", EngineMode.Default)
            End Select

            Try
                BackgroundWorker1.RunWorkerAsync()
                ComboBox1.Enabled = False
                btn1.Enabled = False
                PictureBox1.Image = My.Resources.ld1
                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            Catch ex As Exception
                MessageBox.Show("Please Wait...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try


        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            img = Pix.LoadFromFile(path)
            page = engine.Process(img)
            texto = page.GetText
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Scanning...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        TextBox1.Clear()
        TextBox1.Text = texto
        PictureBox1.Image = Image.FromFile(path)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        btn1.Enabled = True
        ComboBox1.Enabled = True
        btn1.Enabled = True

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.Clear()
    End Sub
End Class
