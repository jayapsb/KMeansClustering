Public Class FormAntarMuka

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        Dim datauser As New FormDataUser
        datauser.Show()
    End Sub

    Private Sub DataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMenuToolStripMenuItem.Click
        Dim datamenu As New FormDataMenu
        datamenu.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As New FormAbout
        about.Show()
    End Sub

    Private Sub UpdateDataPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDataPenjualanToolStripMenuItem.Click
        Dim update As New FormUpdateDataPenjualan
        update.Show()
    End Sub

    Private Sub HitungMixToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HitungMixToolStripMenuItem.Click
        Dim hitungmix As New FormHitungMix
        hitungmix.Show()
    End Sub

    Private Sub ProsesClusterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProsesClusterToolStripMenuItem.Click
        Dim prosescluster As New FormProsesCluster
        prosescluster.Show()
    End Sub
End Class