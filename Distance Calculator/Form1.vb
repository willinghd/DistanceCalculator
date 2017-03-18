Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "click Calculate to begin"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' local variable declarations
        Dim speed As Integer = InputBox("Please enter vehicle speed (in MPH):")
        Dim distance As Integer = InputBox("Please enter time traveled (in hours):")
        Dim total As Integer


        ' ensure user entered valid data
        If (Not IsNumeric(speed) Or Not IsNumeric(distance)) Then
            MessageBox.Show("Please enter valid values for speed and time. Click Calculate to try again.")

            Exit Sub
        End If

        ' display header info
        TextBox1.Text = "Vehicle Speed: " & speed & " MPH" & vbCrLf
        TextBox1.Text += "Time Traveled: " & distance & " hours" & vbCrLf
        TextBox1.Text += vbCrLf
        TextBox1.Text += "Hours" & vbTab & "Distance Traveled" & vbCrLf
        TextBox1.Text += "-------------------------" & vbCrLf

        ' display aggregate
        For i As Integer = 1 To distance
            ' calculate total distance traveled
            total += speed

            ' display total
            TextBox1.Text += i & vbTab & total & vbCrLf
        Next

        ' display total
        TextBox1.Text += vbCrLf & "Total Distance: " & total & " miles"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
