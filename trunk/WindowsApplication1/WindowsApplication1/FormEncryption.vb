Public Class FormEncryption

    Private Sub FormEncryption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = AESCrypter.AES_Encrypt(TextBox1.Text)
    End Sub
End Class