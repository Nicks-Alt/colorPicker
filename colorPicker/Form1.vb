
Public Class frmColorPicker
    Private pixel As Color
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.Keyboard.CapsLock Then
            tmrBackgroundTimer.Start()
            panStatus.BackColor = Color.Lime
        Else
            tmrBackgroundTimer.Stop()
            panStatus.BackColor = Color.PaleVioletRed
        End If
    End Sub
    Private Sub tmrBackgroundTimer_Tick(sender As Object, e As EventArgs) Handles tmrBackgroundTimer.Tick
        Dim BMP As New Bitmap(1, 1)
        Dim GFX As Graphics = Graphics.FromImage(BMP)
        GFX.CopyFromScreen(New Point(MousePosition.X, MousePosition.Y), New Point(0, 0), BMP.Size)
        pixel = BMP.GetPixel(0, 0)
        panColorPanel.BackColor = pixel
        lblRed.Text = "Red: " & pixel.R
        lblGreen.Text = "Green: " & pixel.G
        lblBlue.Text = "Blue: " & pixel.B
    End Sub
    Private Sub OpenColorPickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenColorPickerToolStripMenuItem.Click
        Dim colorPicker As New ColorDialog
        If colorPicker.ShowDialog = DialogResult.OK Then
            lblRed.Text = "Red: " & colorPicker.Color.R
            lblGreen.Text = "Green: " & colorPicker.Color.G
            lblBlue.Text = "Blue: " & colorPicker.Color.B
            panColorPanel.BackColor = colorPicker.Color
            pixel = colorPicker.Color
        End If
    End Sub
    Private Sub CopyRGBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyRGBToolStripMenuItem.Click
        Dim rgb As String = lblRed.Text.Substring(lblRed.Text.IndexOf(" ") + 1, lblRed.Text.Length - lblRed.Text.IndexOf(" ") - 1) & "," & lblGreen.Text.Substring(lblGreen.Text.IndexOf(" ") + 1, lblGreen.Text.Length - lblGreen.Text.IndexOf(" ") - 1) & "," & lblBlue.Text.Substring(lblBlue.Text.IndexOf(" ") + 1, lblBlue.Text.Length - lblBlue.Text.IndexOf(" ") - 1)
        Clipboard.SetText(rgb)
        MsgBox("RGB copied to clipboard" & Environment.NewLine & "RGB Copied: " & rgb, vbInformation, "Copied.")
    End Sub
    Private Sub CopyHEXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyHEXToolStripMenuItem.Click
        Dim hexValue As String = String.Format("{0}{1}{2}", pixel.R.ToString("X").PadLeft(2, "0"), pixel.G.ToString("X").PadLeft(2, "0"), pixel.B.ToString("X").PadLeft(2, "0"))
        Clipboard.SetText(hexValue)
        MsgBox("Hex copied to clipboard" & Environment.NewLine & Environment.NewLine & Environment.NewLine & "Hex Copied: #" & hexValue, vbInformation, "Copied")
    End Sub
End Class
