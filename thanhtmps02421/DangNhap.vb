Imports System.Data.SqlClient
Public Class DangNhap
    'Form đăng nhập
    Private Sub btnnhap_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNhap.Click
        Dim chuoiketnoi As String = "workstation id=ps02421.mssql.somee.com;packet size=4096;user id=ps02421_SQLLogin_1;pwd=tbwuqpuypy;data source=ps02421.mssql.somee.com;persist security info=False;initial catalog=ps02421"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdater As New SqlDataAdapter("select * from NhanVien where TaiKhoan='" & txt1.Text & "' and MatKhau='" & txt2.Text & "'", ketnoi)
        Dim tb As New DataTable

        Try
            ketnoi.Open()
            sqlAdater.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnthoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class

