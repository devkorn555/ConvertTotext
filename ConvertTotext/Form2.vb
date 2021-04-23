Public Class Form2
    Dim pnl As Panel

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnl = New Panel
    End Sub

    Private Sub panelenter(sender As Object, e As EventArgs) Handles Panel3.MouseHover, Panel9.MouseHover, Panel7.MouseHover, Panel5.MouseHover, Panel13.MouseHover, Panel11.MouseHover
        pnl = sender

        pnl.BackColor = Color.FromArgb(20, 77, 158)
        'pnl.BackColor = Color.White
    End Sub

    Private Sub panelleave(sender As Object, e As EventArgs) Handles Panel3.MouseEnter, Panel9.MouseEnter, Panel7.MouseEnter, Panel5.MouseEnter, Panel13.MouseEnter, Panel11.MouseEnter
        pnl = sender
        pnl.BackColor = Color.FromArgb(17, 64, 132)
        'pnl.BackColor = Color.FromArgb(17, 64, 132)
    End Sub
End Class