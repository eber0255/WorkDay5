Option Strict On
Public Class Form1
    

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim x As Double
        Dim y As Double
        Dim z As Double
        x = CDbl(txtSideOne.Text)
        y = CDbl(txtSideTwo.Text)
        z = hypotenuse(x, y)
        txtHyp.Text = CStr(z)


        txtHyp.Text = "Not Implemented Yet"
    End Sub


    Function hypotenuse(ByVal a As Double, b As Double) As Double
        
        Dim C As Double
        C = Math.Sqrt(a ^ 2 + b ^ 2)

        Return C


    End Function

End Class
