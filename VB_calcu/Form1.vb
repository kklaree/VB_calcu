Imports System.Linq.Expressions

Public Class Form1

    Dim num1 As Double
    Dim num2 As Double
    Dim result As Double
    Dim operation As String
    Dim operator_selector As Boolean = False

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "0"
    End Sub

    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "00"
    End Sub
    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        Dim b As Button = sender
        txtDisplay.Text = txtDisplay.Text + "."
    End Sub

    Private Sub CmdClear_Click(sender As Object, e As EventArgs) Handles CmdClear.Click
        txtDisplay.Clear()
    End Sub
    Private Sub CmdDel_Click(sender As Object, e As EventArgs) Handles CmdDel.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        num1 = txtDisplay.Text
        txtDisplay.Text = ""
        operator_selector = True
        operation = 1 ' = +
    End Sub

    Private Sub CmdSubtract_Click(sender As Object, e As EventArgs) Handles CmdSubtract.Click
        num1 = txtDisplay.Text
        txtDisplay.Text = ""
        operator_selector = True
        operation = 2 ' = -
    End Sub

    Private Sub CmdMultiply_Click(sender As Object, e As EventArgs) Handles CmdMultiply.Click
        num1 = txtDisplay.Text
        txtDisplay.Text = ""
        operator_selector = True
        operation = 3 ' = *
    End Sub

    Private Sub CmdDivide_Click(sender As Object, e As EventArgs) Handles CmdDivide.Click
        num1 = txtDisplay.Text
        txtDisplay.Text = ""
        operator_selector = True
        operation = 4 ' = /
    End Sub

    Private Sub CmdAns_Click(sender As Object, e As EventArgs) Handles CmdAns.Click
        If operator_selector = True Then
            num2 = txtDisplay.Text
            If operation = 1 Then
                txtDisplay.Text = num1 + num2
            ElseIf operation = 2 Then
                txtDisplay.Text = num1 - num2
            ElseIf operation = 3 Then
                txtDisplay.Text = num1 * num2
            Else
                If num2 = 0 Then
                    txtDisplay.Text = "Error!"
                Else
                    txtDisplay.Text = num1 / num2
                End If
            End If
            operator_selector = False
        End If
    End Sub
End Class
