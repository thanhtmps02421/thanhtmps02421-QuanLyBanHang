Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class QuanLyThongTinKH
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ps02421.mssql.somee.com;packet size=4096;user id=ps02421_SQLLogin_1;pwd=tbwuqpuypy;data source=ps02421.mssql.somee.com;persist security info=False;initial catalog=ps02421"

    Public Sub LoadData()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from KhachHang", KetNoi)

        Try
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Khi click vào 1 cell bất kỳ, lấy giá trị tại dòng đó đưa lên các textbox tương ứng
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaKhachHang.Text = DataGridView1.Item(0, index).Value
        txtTenKhachHang.Text = DataGridView1.Item(1, index).Value
        cbbNgaySinh.Text = DataGridView1.Item(2, index).Value
        txtDiaChi.Text = DataGridView1.Item(3, index).Value
        txtDienThoai.Text = DataGridView1.Item(4, index).Value
        txtEmail.Text = DataGridView1.Item(5, index).Value

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from KhachHang", KetNoi)

        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If MessageBox.Show("Bạn muốn sửa dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim KetNoi As New SqlConnection(connectstr)
            KetNoi.Open()
            Dim stradd As String = "UPDATE KhachHang SET TenKhachHang = @TenKhachHang, NgaySinh =@NgaySinh, DiaChi =@DiaChi, DienThoai = @DienThoai, Email = @Email where MaKhachHang = @MaKhachHang"
            Dim com As New SqlCommand(stradd, KetNoi)
            Try
                com.Parameters.AddWithValue("@MaKhachHang", txtMaKhachHang.Text)
                com.Parameters.AddWithValue("@TenKhachHang", txtTenKhachHang.Text)
                com.Parameters.AddWithValue("@NgaySinh", cbbNgaySinh.Text)
                com.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                com.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text)
                com.Parameters.AddWithValue("@Email", txtEmail.Text)
                com.ExecuteNonQuery()
                KetNoi.Close()
            Catch ex As Exception
            End Try
            tb.Clear()
            DataGridView1.DataSource = tb
            DataGridView1.DataSource = Nothing
            LoadData()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "Insert KhachHang values(@MaKhachHang, @TenKhachHang, @NgaySinh, @DiaChi, @DienThoai, @Email)"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@MaKhachHang", txtMaKhachHang.Text)
            com.Parameters.AddWithValue("@TenKhachHang", txtTenKhachHang.Text)
            com.Parameters.AddWithValue("@NgaySinh", cbbNgaySinh.Text)
            com.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            com.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text)
            com.Parameters.AddWithValue("@Email", txtEmail.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
        End Try
        tb.clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "Delete from KhachHang WHERE MaKhachHang = @MaKhachHang"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@MaKhachHang", txtMaKhachHang.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
        End Try
        tb.clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()

    End Sub

    Private Sub QuanLyThongTinKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class