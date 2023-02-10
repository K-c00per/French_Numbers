Public Class frmNumbers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        lblFrench1.Visible = True
        lblFrench2.Visible = False
        lblFrench3.Visible = False
        lblFrench4.Visible = False
        lblFrench5.Visible = False

    End Sub

    Private Sub lblFrench2_Click(sender As Object, e As EventArgs) Handles lblFrench2.Click

    End Sub

    Private Sub lblFrench1_Click(sender As Object, e As EventArgs) Handles lblFrench1.Click

    End Sub

    Private Sub lblFrench3_Click(sender As Object, e As EventArgs) Handles lblFrench3.Click

    End Sub

    Private Sub lblFrench4_Click(sender As Object, e As EventArgs) Handles lblFrench4.Click

    End Sub

    Private Sub lblFrench5_Click(sender As Object, e As EventArgs) Handles lblFrench5.Click

    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrench1.Visible = False
        lblFrench2.Visible = True
        lblFrench3.Visible = False
        lblFrench4.Visible = False
        lblFrench5.Visible = False
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrench1.Visible = False
        lblFrench2.Visible = False
        lblFrench3.Visible = True
        lblFrench4.Visible = False
        lblFrench5.Visible = False
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrench1.Visible = False
        lblFrench2.Visible = False
        lblFrench3.Visible = False
        lblFrench4.Visible = True
        lblFrench5.Visible = False
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        lblFrench1.Visible = False
        lblFrench2.Visible = False
        lblFrench3.Visible = False
        lblFrench4.Visible = False
        lblFrench5.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
