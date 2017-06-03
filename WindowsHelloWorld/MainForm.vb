'------------------------------------------------------------------------------------------
'           Notice of My Copyright and Intellectual Property Rights
'
'            Copyright © 2017 Joseph L. Bolen. All rights reserved.
'        All trademarks remain the property of their respective owners.
'
'    This program Is free software: you can redistribute it And/Or modify
'    it under the terms Of the GNU General Public License As published by
'    the Free Software Foundation, either version 3 Of the License, Or
'    any later version.
'
'    This program Is distributed In the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty Of
'    MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License For more details.
'
'    You should have received a copy Of the GNU General Public License
'    along with this program.  If Not, see < http: //www.gnu.org/licenses/>.
'
'-------------------------------------------------------------------------------------------
' Program Name:   Windows Hello World
'
' Author:         Joseph L. Bolen
' Date Created:   02 JUN 2017
'
' Description:    Classic Windows Hello World app. Introducing the Label and
'                 Button controls.  ALso, introducing the Event Handlier.
'
'                 Documentation is at:
'                   App's documentation is at:  https://jaybeeoh.github.io/WindowsHelloWorld/
'                   Video tutorials at YouTube: http://www.youtube.com/user/bolenpresents
'-------------------------------------------------------------------------------------------
Public Class MainForm

    Private Sub EnglishButton_Click(sender As Object, e As EventArgs) _
        Handles EnglishButton.Click

        ResultLabel.Text = "Hello, World!"
    End Sub

    Private Sub GermanButton_Click(sender As Object, e As EventArgs) _
        Handles GermanButton.Click

        ResultLabel.Text = "Hallo Welt!"
    End Sub

    Private Sub FrenchButton_Click(sender As Object, e As EventArgs) _
        Handles FrenchButton.Click

        ResultLabel.Text = "Bonjour le monde!"
    End Sub

    Private Sub SpainishButton_Click(sender As Object, e As EventArgs) _
        Handles SpainishButton.Click

        ResultLabel.Text = "¡Hola Mundo!"
    End Sub

    Private Sub PigLatinButton_Click(sender As Object, e As EventArgs) _
        Handles PigLatinButton.Click

        ResultLabel.Text = "Ellohay, Orldway!"
    End Sub

    Private Sub PirateButton_Click(sender As Object, e As EventArgs) _
        Handles PirateButton.Click

        ResultLabel.Text = "Yo-ho-ho! Ahoy, World!"
    End Sub

End Class
