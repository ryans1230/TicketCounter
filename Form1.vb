Public Class Form1
    Private todayTickets As Int16 = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("ticketCounter.txt")
        Label2.Text = fileReader
    End Sub

    Private Sub IncrementButton_Click(sender As Object, e As EventArgs) Handles IncrementButton.Click
        Dim number = Convert.ToInt32(Label2.Text)
        number += 1
        todayTickets += 1
        Label2.Text = number.ToString
        TodayCounter.Text = todayTickets.ToString

        My.Computer.FileSystem.WriteAllText("ticketCounter.txt", Label2.Text, False)
    End Sub

    Private Sub OopsButton_Click(sender As Object, e As EventArgs) Handles OopsButton.Click
        Dim number = Convert.ToInt32(Label2.Text)
        number -= 1
        todayTickets -= 1
        Label2.Text = number.ToString
        TodayCounter.Text = todayTickets.ToString

        My.Computer.FileSystem.WriteAllText("ticketCounter.txt", Label2.Text, False)
    End Sub
End Class
