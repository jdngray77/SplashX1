Public Class MessageEngine

    Public Sub AddLine(line, special)
        If special = "cls" Then
            LineList.Items.Clear()
        End If
        LineList.Items.Add(line)
    End Sub
    'for calling multiline messages

    Private messageEnd = False
    Public Sub display(line)
        Line1.ResetText()
        Line2.ResetText()
        Line3.ResetText()

        'Single line message
        If Not line = "null" Or line = "Null" Then
            Line1.Text = line
            Try
                Me.ShowDialog()
            Catch
            End Try
            Exit Sub
        End If

        If Not LineList.Items.Count = 0 Then
            Try
                LineList.SelectedIndex = 0
                Line1.Text = LineList.SelectedItem
                LineList.Items.RemoveAt(LineList.SelectedIndex)

                LineList.SelectedIndex = 0
                Line2.Text = LineList.SelectedItem
                LineList.Items.RemoveAt(LineList.SelectedIndex)

                LineList.SelectedIndex = 0
                Line3.Text = LineList.SelectedItem
                LineList.Items.RemoveAt(LineList.SelectedIndex)
            Catch
            End Try

            Try
                Me.ShowDialog()
            Catch
            End Try
        Else
            messageEnd = True
            Me.Hide()
            GameEngine.Select()
        End If


    End Sub

    Private Sub MessageEngine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "1" Then
            If messageEnd = True Then
                Me.Hide()
                GameEngine.Select()
            Else Display("null")
            End If
        End If
    End Sub


    'sound
End Class