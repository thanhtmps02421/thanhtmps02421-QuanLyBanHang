Public Class Main

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DangNhap.Close()
        Me.Close()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        DangNhap.ShowDialog()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ThoátToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub QuảnLýSảnPhẩmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuảnLýToolStripMenuItem1.Click
        QuanLySanPham.ShowDialog()
    End Sub

    Private Sub QuảnLýThôngTinKháchHàngToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuảnLýThôngTinKháchHàngToolStripMenuItem.Click
        QuanLyThongTinKH.ShowDialog()
    End Sub

    Private Sub HệThốngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HệThốngToolStripMenuItem.Click

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuảnLýThôngTinKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýThôngTinKháchHàngToolStripMenuItem.Click

    End Sub

    Private Sub QuảnLýToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem1.Click

    End Sub
End Class