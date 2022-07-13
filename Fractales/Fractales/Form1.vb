Imports System.Drawing
Public Class Form1
    Dim i As Integer, j As Integer, escala As Integer, lineaX As Integer, lineaY As Integer, iteracion As Integer
    Dim c_re As Double, c_im As Double, x As Double, y As Double, x_temp As Double
    Dim opcionA As Integer, opcionB As Integer, opcionC As Integer
    Dim R As Integer, G As Integer, B As Integer
    Dim Cr As Single
    Dim Ci As Single
    Dim bmp As Bitmap

    Private Sub Button_Graficar_Click(sender As Object, e As EventArgs) Handles Button_Graficar.Click
        Repeticiones()
        Anchura()
        Seleccion()
    End Sub
    Private Sub Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        Limpiar()
    End Sub
    Sub Repeticiones()
        If Text_Iteracion.Text = "" Then
            iteracion = 1000
        Else
            iteracion = Text_Iteracion.Text
        End If
    End Sub
    Sub Anchura()
        opcionB = ComboBox_An.SelectedIndex

        If opcionB = 0 Then
            Picture_Plano.Width = 160
            Picture_Plano.Height = 160
        ElseIf opcionB = 1 Then
            Picture_Plano.Width = 320
            Picture_Plano.Height = 320
        ElseIf opcionB = 2 Then
            Picture_Plano.Width = 480
            Picture_Plano.Height = 480
        ElseIf opcionB = 3 Then
            Picture_Plano.Width = 640
            Picture_Plano.Height = 640
        ElseIf opcionB = 4 Then
            Picture_Plano.Width = 800
            Picture_Plano.Height = 800
        End If
    End Sub
    Sub Seleccion()
        opcionA = ComboBox_Op.SelectedIndex
        opcionC = ComboBox_Variantes.SelectedIndex
        If opcionA = 0 Then
            Mandelbrot()
        ElseIf opcionA = 1 Then
            If ComboBox_Variantes.SelectedIndex = -1 Then
                MsgBox("Selecciona la variante del fractal de julia.")
            ElseIf opcionC = 0 Then
                Cr = -0.72
                Ci = 0.196
                Julia()
            ElseIf opcionC = 1 Then
                Cr = 0.285
                Ci = -0.01
                Julia()
            ElseIf opcionC = 2 Then
                Cr = -0.8
                Ci = 0.0
                Julia()
            ElseIf opcionC = 3 Then
                Cr = 0.0
                Ci = 0.8
                Julia()
            ElseIf opcionC = 4 Then
                Cr = -0.8
                Ci = -0.25
                Julia()
            End If
        End If
    End Sub
    Sub Mandelbrot()
        Dim width As Integer, heigth As Integer, Coll As Integer, Row As Integer, iteraciones As Integer
        width = Picture_Plano.Width
        heigth = Picture_Plano.Height

        bmp = New Bitmap(width, heigth)

        For Row = 0 To (Width - 1)
            For Coll = 0 To (heigth - 1)
                c_re = (Coll - width / 2.0) * 4.0 / width
                c_im = (Row - heigth / 2.0) * 4.0 / heigth
                iteraciones = 0
                x = 0
                y = 0

                While iteraciones < iteracion And ((x * x) + (y * y)) <= 4
                    x_temp = (x * x) - (y * y) + c_re
                    y = 2 * x * y + c_im
                    x = x_temp
                    iteraciones = iteraciones + 1
                End While

                R = iteraciones Mod 128
                G = iteraciones Mod 50 * 5
                B = iteraciones Mod 10

                If iteraciones < iteracion Then
                    bmp.SetPixel(Coll, Row, Color.FromArgb(R, G, B))
                Else
                    bmp.SetPixel(Coll, Row, Color.Black)
                End If

            Next Coll
        Next Row
        Picture_Plano.Image = bmp
    End Sub



    Sub Julia()

        Dim bmp As Bitmap

        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim N As Integer
        Dim paso As Integer

        Dim delta As Single
        Dim rr As Single
        Dim a As Single
        Dim B As Single
        Dim an As Single
        Dim a0 As Single
        Dim b0 As Single

        j = 0
        k = 0
        i = 0
        N = iteracion
        paso = 200

        delta = 4 / Picture_Plano.Width
        a0 = -2.0
        b0 = -2.0

        bmp = New Bitmap(Picture_Plano.Width, Picture_Plano.Height)

        For j = 1 To Picture_Plano.Width - 1
            For k = 1 To Picture_Plano.Height - 1

                a = a0 + j * delta

                B = b0 + k * delta

                i = 0
                rr = 0

                While i < N And (a * a) + (B * B) < 4
                    an = a * a - B * B + Cr
                    B = 2 * a * B + Ci
                    a = an
                    i = i + 1
                End While

                'If i < 100 Then
                '    bmp.SetPixel(j, k, Color.Black)
                'Else
                '    bmp.SetPixel(j, k, Color.White)
                'End If

                If i < 5 Then
                    bmp.SetPixel(j, k, Color.Black)
                ElseIf i >= 5 And i < 25
                    bmp.SetPixel(j, k, Color.Purple)
                ElseIf i >= 25 And i < 50
                    bmp.SetPixel(j, k, Color.Blue)
                ElseIf i >= 50 And i < 75
                    bmp.SetPixel(j, k, Color.DarkOrchid)
                ElseIf i >= 75 And i < 100
                    bmp.SetPixel(j, k, Color.White)
                ElseIf i >= 100 And i < 1001
                    bmp.SetPixel(j, k, Color.DarkSlateGray)
                End If


            Next k
        Next j

        Picture_Plano.Image = bmp
    End Sub
    Sub Limpiar()
        Picture_Plano.Image.Dispose()
        Picture_Plano.Image = Nothing
        Text_Iteracion.Clear()
        ComboBox_An.Text = ""
        ComboBox_Op.Text = ""
        ComboBox_Variantes.Text = ""
    End Sub
End Class