Imports SKYPE4COMLib
Imports System.Threading
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim t As New Thread(AddressOf massmessage)
        t.Start()
    End Sub

    Sub massmessage()
        Dim skype As Object
        On Error Resume Next
        skype = CreateObject("skype4COM.skype", "")
        skype.Client.Start()
        skype.Attach()
        For Each User In skype.Friends
            skype.SendMessage(User.Handle, TextBox1.Text)
        Next
    End Sub

End Class
