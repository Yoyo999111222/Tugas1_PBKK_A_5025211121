Public Class Form1
    Friend Hasil As Single = 0
    Dim operasi As String = ""
    Dim OperasiHitung As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OperasiHitung = False
        operasi = ""
        Hasil = 0
        TxtLayar.Text = "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If OperasiHitung = True Or TxtLayar.Text = "0" Then
            TxtLayar.Text = "1"
            OperasiHitung = False
        Else
            TxtLayar.Text = TxtLayar.Text + "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If OperasiHitung = True Or TxtLayar.Text = "0" Then
            TxtLayar.Text = "2"
            OperasiHitung = False
        Else
            TxtLayar.Text = TxtLayar.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If OperasiHitung = True Or TxtLayar.Text = "0" Then
            TxtLayar.Text = "3"
            OperasiHitung = False
        Else
            TxtLayar.Text = TxtLayar.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If OperasiHitung = True Or TxtLayar.Text = "0" Then
            TxtLayar.Text = "4"
            OperasiHitung = False
        Else
            TxtLayar.Text = TxtLayar.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If OperasiHitung = True Or TxtLayar.Text = "0" Then
            TxtLayar.Text = "5"
            OperasiHitung = False
        Else
            TxtLayar.Text = TxtLayar.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If OperasiHitung = True Or TxtLayar.Text = "0" Then
            TxtLayar.Text = "6"
            OperasiHitung = False
        Else
            TxtLayar.Text = TxtLayar.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If OperasiHitung = True Or TxtLayar.Text = "0" Then
            TxtLayar.Text = "7"
            OperasiHitung = False
        Else
            TxtLayar.Text = TxtLayar.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If OperasiHitung = True Or TxtLayar.Text = "0" Then
            TxtLayar.Text = "8"
            OperasiHitung = False
        Else
            TxtLayar.Text = TxtLayar.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If OperasiHitung = True Or TxtLayar.Text = "0" Then
            TxtLayar.Text = "9"
            OperasiHitung = False
        Else
            TxtLayar.Text = TxtLayar.Text + "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If OperasiHitung = True Or TxtLayar.Text = "0" Then
            TxtLayar.Text = "0"
            OperasiHitung = False
        Else
            TxtLayar.Text = TxtLayar.Text + "0"
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        operasi = "tambah"
        Hasil = Val(TxtLayar.Text)
        OperasiHitung = True
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        operasi = "kurang"
        Hasil = Val(TxtLayar.Text)
        OperasiHitung = True
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        operasi = "kali"
        Hasil = Val(TxtLayar.Text)
        OperasiHitung = True
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        operasi = "bagi"
        Hasil = Val(TxtLayar.Text)
        OperasiHitung = True
    End Sub

    Private Sub btnPangkat_Click(sender As Object, e As EventArgs) Handles btnPangkat.Click
        operasi = "pangkat"
        Hasil = Val(TxtLayar.Text)
        OperasiHitung = True
    End Sub

    Private Sub btnHasil_Click(sender As Object, e As EventArgs) Handles btnHasil.Click
        Select Case operasi
            Case "tambah"
                Hasil = Hasil + Val(TxtLayar.Text)
            Case "kurang"
                Hasil = Hasil - Val(TxtLayar.Text)
            Case "kali"
                Hasil = Hasil * Val(TxtLayar.Text)
            Case "bagi"
                Hasil = Hasil / Val(TxtLayar.Text)
            Case "pangkat"
                Hasil = Hasil ^ Val(TxtLayar.Text)
        End Select
        TxtLayar.Text = Hasil
        OperasiHitung = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TxtLayar.Text = "0"
        operasi = ""
    End Sub

    Private Sub btnHapusSatu_Click(sender As Object, e As EventArgs) Handles btnHapusSatu.Click
        If TxtLayar.Text.Length <> 0 Then
            TxtLayar.Text = TxtLayar.Text.Remove(TxtLayar.Text.Length - 1)
        End If

    End Sub

    Private Sub btnKoma_Click(sender As Object, e As EventArgs) Handles btnKoma.Click
        If Not TxtLayar.Text.Contains(".") Then
            TxtLayar.Text += "."
        End If
    End Sub
End Class
