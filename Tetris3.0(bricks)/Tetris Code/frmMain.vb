Public Class frmMain

    Private TwoDArrayPieces(20, 30) As PictureBox
    Private color1 As Color
    Private randomWhichPiece As Integer
    Private x1 As Integer = 1
    Private y1 As Integer = 1
    Private x2 As Integer = 1
    Private y2 As Integer = 1
    Private x3 As Integer = 1
    Private y3 As Integer = 1
    Private x4 As Integer = 1
    Private y4 As Integer = 1
    Private color2 As Color
    Private randomWhichPiece1 As Integer
    Private randomWhichPiece2 As Integer
    Private x5 As Integer = 1
    Private y5 As Integer = 1
    Private x6 As Integer = 1
    Private y6 As Integer = 1
    Private x7 As Integer = 1
    Private y7 As Integer = 1
    Private x8 As Integer = 1
    Private y8 As Integer = 1
    Private ycheck As Integer = 1
    Private rotate As Integer = 1
    Private score As Integer = 0
    Private level As Integer = 1
    Private levelcounter As Integer = 0
    Private linecounter As Integer = 0
    Private q As Integer = 1
    Private w As Integer = 1


    'rerandomizes which piece to send down
    Private Sub reset()
        Randomize()
        randomWhichPiece2 = Rnd() * 700 + 1
    End Sub

    'used to set cordinates and color
    Private Sub makepiece()
        For x = 1 To 20
            If TwoDArrayPieces(x, 3).BackColor <> Color.Transparent Then
                test.Enabled = True
                movesdown.Enabled = False
            End If
        Next
        x1 = x5
        y1 = y5
        x2 = x6
        y2 = y6
        x3 = x7
        y3 = y7
        x4 = x8
        y4 = y8
        color1 = color2
        randomWhichPiece = randomWhichPiece1
        rotate = 1
        'sets which picturebox and color
        If randomWhichPiece2 < 101 Then
            color2 = Color.Cyan
            x5 = 10
            y5 = 1
            x6 = 10
            y6 = 2
            x7 = 10
            y7 = 3
            x8 = 10
            y8 = 4
            randomWhichPiece1 = 1
        ElseIf randomWhichPiece2 > 100 And randomWhichPiece2 < 201 Then
            color2 = Color.Yellow
            x5 = 10
            y5 = 1
            x6 = 11
            y6 = 1
            x7 = 10
            y7 = 2
            x8 = 11
            y8 = 2
            randomWhichPiece1 = 2
        ElseIf randomWhichPiece2 > 200 And randomWhichPiece2 < 301 Then
            color2 = Color.DarkOrchid
            x5 = 9
            y5 = 1
            x6 = 10
            y6 = 1
            x7 = 11
            y7 = 1
            x8 = 10
            y8 = 2
            randomWhichPiece1 = 3
        ElseIf randomWhichPiece2 > 300 And randomWhichPiece2 < 401 Then
            color2 = Color.Green
            x5 = 10
            y5 = 1
            x6 = 11
            y6 = 1
            x7 = 9
            y7 = 2
            x8 = 10
            y8 = 2
            randomWhichPiece1 = 4
        ElseIf randomWhichPiece2 > 400 And randomWhichPiece2 < 501 Then
            color2 = Color.Red
            x5 = 9
            y5 = 1
            x6 = 10
            y6 = 1
            x7 = 10
            y7 = 2
            x8 = 11
            y8 = 2
            randomWhichPiece1 = 5
        ElseIf randomWhichPiece2 > 500 And randomWhichPiece2 < 601 Then
            color2 = Color.Orange
            x5 = 10
            y5 = 1
            x6 = 10
            y6 = 2
            x7 = 10
            y7 = 3
            x8 = 11
            y8 = 3
            randomWhichPiece1 = 6
        ElseIf randomWhichPiece2 > 600 Then
            color2 = Color.Blue
            x5 = 10
            y5 = 1
            x6 = 10
            y6 = 2
            x7 = 10
            y7 = 3
            x8 = 9
            y8 = 3
            randomWhichPiece1 = 7
        End If
        nextup()
        'resets speed
        If frmStart.level.Text = 1 Then
            movesdown.Interval = 130
        ElseIf frmStart.level.Text = 2 Then
            movesdown.Interval = 120
        ElseIf frmStart.level.Text = 3 Then
            movesdown.Interval = 110
        ElseIf frmStart.level.Text = 4 Then
            movesdown.Interval = 100
        ElseIf frmStart.level.Text = 5 Then
            movesdown.Interval = 90
        ElseIf frmStart.level.Text = 6 Then
            movesdown.Interval = 80
        ElseIf frmStart.level.Text = 7 Then
            movesdown.Interval = 70
        ElseIf frmStart.level.Text = 8 Then
            movesdown.Interval = 60
        ElseIf frmStart.level.Text = 9 Then
            movesdown.Interval = 50
        ElseIf frmStart.level.Text = 10 Then
            movesdown.Interval = 40
        End If
    End Sub

    'moves pieces down
    Private Sub movesdown_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles movesdown.Tick
        'if piece is at the bottom
        If y1 + 1 = 31 Then
            reset()
            makepiece()
        End If
        If y2 + 1 = 31 Then
            reset()
            makepiece()
        End If
        If y3 + 1 = 31 Then
            reset()
            makepiece()
        End If
        If y4 + 1 = 31 Then
            reset()
            makepiece()
        End If
        'moves pieces
        If (TwoDArrayPieces(x1, y1 + 1).BackColor = Color.Transparent Or (x1 = x2 And y1 + 1 = y2) Or (x1 = x3 And y1 + 1 = y3) Or (x1 = x4 And y1 + 1 = y4)) And (TwoDArrayPieces(x2, y2 + 1).BackColor = Color.Transparent Or (x2 = x1 And y2 + 1 = y1) Or (x2 = x3 And y2 + 1 = y3) Or (x2 = x4 And y2 + 1 = y4)) And (TwoDArrayPieces(x3, y3 + 1).BackColor = Color.Transparent Or (x3 = x2 And y3 + 1 = y2) Or (x3 = x1 And y3 + 1 = y1) Or (x3 = x4 And y3 + 1 = y4)) And (TwoDArrayPieces(x4, y4 + 1).BackColor = Color.Transparent Or (x4 = x2 And y4 + 1 = y2) Or (x4 = x3 And y4 + 1 = y3) Or (x4 = x1 And y4 + 1 = y1)) Then
            TwoDArrayPieces(x1, y1).BackColor = Color.Transparent
            TwoDArrayPieces(x2, y2).BackColor = Color.Transparent
            TwoDArrayPieces(x3, y3).BackColor = Color.Transparent
            TwoDArrayPieces(x4, y4).BackColor = Color.Transparent
            TwoDArrayPieces(x1, y1 + 1).BackColor = color1
            TwoDArrayPieces(x2, y2 + 1).BackColor = color1
            TwoDArrayPieces(x3, y3 + 1).BackColor = color1
            TwoDArrayPieces(x4, y4 + 1).BackColor = color1
            y1 += 1
            y2 += 1
            y3 += 1
            y4 += 1
        Else
            reset()
            makepiece()
        End If
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
        scoring()
    End Sub

    'test
    Private Sub test_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles test.Tick
        'testes to see if arrays are in order
        TwoDArrayPieces(q, w).BackColor = Color.Black
        q += 1
        If q = 21 Then
            w += 1
            q = 1
        End If
        If q = 1 And w = 31 Then
            test.Enabled = False
            Me.Close()
        End If
    End Sub

    'sets array and first piece
    Private Sub frmMain_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'declares arrays
        'Array (col, row)
        TwoDArrayPieces(1, 1) = PictureBox1
        TwoDArrayPieces(2, 1) = PictureBox2
        TwoDArrayPieces(3, 1) = PictureBox3
        TwoDArrayPieces(4, 1) = PictureBox4
        TwoDArrayPieces(5, 1) = PictureBox5
        TwoDArrayPieces(6, 1) = PictureBox6
        TwoDArrayPieces(7, 1) = PictureBox7
        TwoDArrayPieces(8, 1) = PictureBox8
        TwoDArrayPieces(9, 1) = PictureBox9
        TwoDArrayPieces(10, 1) = PictureBox10
        TwoDArrayPieces(11, 1) = PictureBox11
        TwoDArrayPieces(12, 1) = PictureBox12
        TwoDArrayPieces(13, 1) = PictureBox13
        TwoDArrayPieces(14, 1) = PictureBox14
        TwoDArrayPieces(15, 1) = PictureBox15
        TwoDArrayPieces(16, 1) = PictureBox16
        TwoDArrayPieces(17, 1) = PictureBox17
        TwoDArrayPieces(18, 1) = PictureBox18
        TwoDArrayPieces(19, 1) = PictureBox19
        TwoDArrayPieces(20, 1) = PictureBox20
        TwoDArrayPieces(1, 2) = PictureBox21
        TwoDArrayPieces(2, 2) = PictureBox22
        TwoDArrayPieces(3, 2) = PictureBox23
        TwoDArrayPieces(4, 2) = PictureBox24
        TwoDArrayPieces(5, 2) = PictureBox25
        TwoDArrayPieces(6, 2) = PictureBox26
        TwoDArrayPieces(7, 2) = PictureBox27
        TwoDArrayPieces(8, 2) = PictureBox28
        TwoDArrayPieces(9, 2) = PictureBox29
        TwoDArrayPieces(10, 2) = PictureBox30
        TwoDArrayPieces(11, 2) = PictureBox31
        TwoDArrayPieces(12, 2) = PictureBox32
        TwoDArrayPieces(13, 2) = PictureBox33
        TwoDArrayPieces(14, 2) = PictureBox34
        TwoDArrayPieces(15, 2) = PictureBox35
        TwoDArrayPieces(16, 2) = PictureBox36
        TwoDArrayPieces(17, 2) = PictureBox37
        TwoDArrayPieces(18, 2) = PictureBox38
        TwoDArrayPieces(19, 2) = PictureBox39
        TwoDArrayPieces(20, 2) = PictureBox40
        TwoDArrayPieces(1, 3) = PictureBox41
        TwoDArrayPieces(2, 3) = PictureBox42
        TwoDArrayPieces(3, 3) = PictureBox43
        TwoDArrayPieces(4, 3) = PictureBox44
        TwoDArrayPieces(5, 3) = PictureBox45
        TwoDArrayPieces(6, 3) = PictureBox46
        TwoDArrayPieces(7, 3) = PictureBox47
        TwoDArrayPieces(8, 3) = PictureBox48
        TwoDArrayPieces(9, 3) = PictureBox49
        TwoDArrayPieces(10, 3) = PictureBox50
        TwoDArrayPieces(11, 3) = PictureBox51
        TwoDArrayPieces(12, 3) = PictureBox52
        TwoDArrayPieces(13, 3) = PictureBox53
        TwoDArrayPieces(14, 3) = PictureBox54
        TwoDArrayPieces(15, 3) = PictureBox55
        TwoDArrayPieces(16, 3) = PictureBox56
        TwoDArrayPieces(17, 3) = PictureBox57
        TwoDArrayPieces(18, 3) = PictureBox58
        TwoDArrayPieces(19, 3) = PictureBox59
        TwoDArrayPieces(20, 3) = PictureBox60
        TwoDArrayPieces(1, 4) = PictureBox61
        TwoDArrayPieces(2, 4) = PictureBox62
        TwoDArrayPieces(3, 4) = PictureBox63
        TwoDArrayPieces(4, 4) = PictureBox64
        TwoDArrayPieces(5, 4) = PictureBox65
        TwoDArrayPieces(6, 4) = PictureBox66
        TwoDArrayPieces(7, 4) = PictureBox67
        TwoDArrayPieces(8, 4) = PictureBox68
        TwoDArrayPieces(9, 4) = PictureBox69
        TwoDArrayPieces(10, 4) = PictureBox70
        TwoDArrayPieces(11, 4) = PictureBox71
        TwoDArrayPieces(12, 4) = PictureBox72
        TwoDArrayPieces(13, 4) = PictureBox73
        TwoDArrayPieces(14, 4) = PictureBox74
        TwoDArrayPieces(15, 4) = PictureBox75
        TwoDArrayPieces(16, 4) = PictureBox76
        TwoDArrayPieces(17, 4) = PictureBox77
        TwoDArrayPieces(18, 4) = PictureBox78
        TwoDArrayPieces(19, 4) = PictureBox79
        TwoDArrayPieces(20, 4) = PictureBox80
        TwoDArrayPieces(1, 5) = PictureBox81
        TwoDArrayPieces(2, 5) = PictureBox82
        TwoDArrayPieces(3, 5) = PictureBox83
        TwoDArrayPieces(4, 5) = PictureBox84
        TwoDArrayPieces(5, 5) = PictureBox85
        TwoDArrayPieces(6, 5) = PictureBox86
        TwoDArrayPieces(7, 5) = PictureBox87
        TwoDArrayPieces(8, 5) = PictureBox88
        TwoDArrayPieces(9, 5) = PictureBox89
        TwoDArrayPieces(10, 5) = PictureBox90
        TwoDArrayPieces(11, 5) = PictureBox91
        TwoDArrayPieces(12, 5) = PictureBox92
        TwoDArrayPieces(13, 5) = PictureBox93
        TwoDArrayPieces(14, 5) = PictureBox94
        TwoDArrayPieces(15, 5) = PictureBox95
        TwoDArrayPieces(16, 5) = PictureBox96
        TwoDArrayPieces(17, 5) = PictureBox97
        TwoDArrayPieces(18, 5) = PictureBox98
        TwoDArrayPieces(19, 5) = PictureBox99
        TwoDArrayPieces(20, 5) = PictureBox100
        TwoDArrayPieces(1, 6) = PictureBox101
        TwoDArrayPieces(2, 6) = PictureBox102
        TwoDArrayPieces(3, 6) = PictureBox103
        TwoDArrayPieces(4, 6) = PictureBox104
        TwoDArrayPieces(5, 6) = PictureBox105
        TwoDArrayPieces(6, 6) = PictureBox106
        TwoDArrayPieces(7, 6) = PictureBox107
        TwoDArrayPieces(8, 6) = PictureBox108
        TwoDArrayPieces(9, 6) = PictureBox109
        TwoDArrayPieces(10, 6) = PictureBox110
        TwoDArrayPieces(11, 6) = PictureBox111
        TwoDArrayPieces(12, 6) = PictureBox112
        TwoDArrayPieces(13, 6) = PictureBox113
        TwoDArrayPieces(14, 6) = PictureBox114
        TwoDArrayPieces(15, 6) = PictureBox115
        TwoDArrayPieces(16, 6) = PictureBox116
        TwoDArrayPieces(17, 6) = PictureBox117
        TwoDArrayPieces(18, 6) = PictureBox118
        TwoDArrayPieces(19, 6) = PictureBox119
        TwoDArrayPieces(20, 6) = PictureBox120
        TwoDArrayPieces(1, 7) = PictureBox121
        TwoDArrayPieces(2, 7) = PictureBox122
        TwoDArrayPieces(3, 7) = PictureBox123
        TwoDArrayPieces(4, 7) = PictureBox124
        TwoDArrayPieces(5, 7) = PictureBox125
        TwoDArrayPieces(6, 7) = PictureBox126
        TwoDArrayPieces(7, 7) = PictureBox127
        TwoDArrayPieces(8, 7) = PictureBox128
        TwoDArrayPieces(9, 7) = PictureBox129
        TwoDArrayPieces(10, 7) = PictureBox130
        TwoDArrayPieces(11, 7) = PictureBox131
        TwoDArrayPieces(12, 7) = PictureBox132
        TwoDArrayPieces(13, 7) = PictureBox133
        TwoDArrayPieces(14, 7) = PictureBox134
        TwoDArrayPieces(15, 7) = PictureBox135
        TwoDArrayPieces(16, 7) = PictureBox136
        TwoDArrayPieces(17, 7) = PictureBox137
        TwoDArrayPieces(18, 7) = PictureBox138
        TwoDArrayPieces(19, 7) = PictureBox139
        TwoDArrayPieces(20, 7) = PictureBox140
        TwoDArrayPieces(1, 8) = PictureBox141
        TwoDArrayPieces(2, 8) = PictureBox142
        TwoDArrayPieces(3, 8) = PictureBox143
        TwoDArrayPieces(4, 8) = PictureBox144
        TwoDArrayPieces(5, 8) = PictureBox145
        TwoDArrayPieces(6, 8) = PictureBox146
        TwoDArrayPieces(7, 8) = PictureBox147
        TwoDArrayPieces(8, 8) = PictureBox148
        TwoDArrayPieces(9, 8) = PictureBox149
        TwoDArrayPieces(10, 8) = PictureBox150
        TwoDArrayPieces(11, 8) = PictureBox151
        TwoDArrayPieces(12, 8) = PictureBox152
        TwoDArrayPieces(13, 8) = PictureBox153
        TwoDArrayPieces(14, 8) = PictureBox154
        TwoDArrayPieces(15, 8) = PictureBox155
        TwoDArrayPieces(16, 8) = PictureBox156
        TwoDArrayPieces(17, 8) = PictureBox157
        TwoDArrayPieces(18, 8) = PictureBox158
        TwoDArrayPieces(19, 8) = PictureBox159
        TwoDArrayPieces(20, 8) = PictureBox160
        TwoDArrayPieces(1, 9) = PictureBox161
        TwoDArrayPieces(2, 9) = PictureBox162
        TwoDArrayPieces(3, 9) = PictureBox163
        TwoDArrayPieces(4, 9) = PictureBox164
        TwoDArrayPieces(5, 9) = PictureBox165
        TwoDArrayPieces(6, 9) = PictureBox166
        TwoDArrayPieces(7, 9) = PictureBox167
        TwoDArrayPieces(8, 9) = PictureBox168
        TwoDArrayPieces(9, 9) = PictureBox169
        TwoDArrayPieces(10, 9) = PictureBox170
        TwoDArrayPieces(11, 9) = PictureBox171
        TwoDArrayPieces(12, 9) = PictureBox172
        TwoDArrayPieces(13, 9) = PictureBox173
        TwoDArrayPieces(14, 9) = PictureBox174
        TwoDArrayPieces(15, 9) = PictureBox175
        TwoDArrayPieces(16, 9) = PictureBox176
        TwoDArrayPieces(17, 9) = PictureBox177
        TwoDArrayPieces(18, 9) = PictureBox178
        TwoDArrayPieces(19, 9) = PictureBox179
        TwoDArrayPieces(20, 9) = PictureBox180
        TwoDArrayPieces(1, 10) = PictureBox181
        TwoDArrayPieces(2, 10) = PictureBox182
        TwoDArrayPieces(3, 10) = PictureBox183
        TwoDArrayPieces(4, 10) = PictureBox184
        TwoDArrayPieces(5, 10) = PictureBox185
        TwoDArrayPieces(6, 10) = PictureBox186
        TwoDArrayPieces(7, 10) = PictureBox187
        TwoDArrayPieces(8, 10) = PictureBox188
        TwoDArrayPieces(9, 10) = PictureBox189
        TwoDArrayPieces(10, 10) = PictureBox190
        TwoDArrayPieces(11, 10) = PictureBox191
        TwoDArrayPieces(12, 10) = PictureBox192
        TwoDArrayPieces(13, 10) = PictureBox193
        TwoDArrayPieces(14, 10) = PictureBox194
        TwoDArrayPieces(15, 10) = PictureBox195
        TwoDArrayPieces(16, 10) = PictureBox196
        TwoDArrayPieces(17, 10) = PictureBox197
        TwoDArrayPieces(18, 10) = PictureBox198
        TwoDArrayPieces(19, 10) = PictureBox199
        TwoDArrayPieces(20, 10) = PictureBox200
        TwoDArrayPieces(1, 11) = PictureBox201
        TwoDArrayPieces(2, 11) = PictureBox202
        TwoDArrayPieces(3, 11) = PictureBox203
        TwoDArrayPieces(4, 11) = PictureBox204
        TwoDArrayPieces(5, 11) = PictureBox205
        TwoDArrayPieces(6, 11) = PictureBox206
        TwoDArrayPieces(7, 11) = PictureBox207
        TwoDArrayPieces(8, 11) = PictureBox208
        TwoDArrayPieces(9, 11) = PictureBox209
        TwoDArrayPieces(10, 11) = PictureBox210
        TwoDArrayPieces(11, 11) = PictureBox211
        TwoDArrayPieces(12, 11) = PictureBox212
        TwoDArrayPieces(13, 11) = PictureBox213
        TwoDArrayPieces(14, 11) = PictureBox214
        TwoDArrayPieces(15, 11) = PictureBox215
        TwoDArrayPieces(16, 11) = PictureBox216
        TwoDArrayPieces(17, 11) = PictureBox217
        TwoDArrayPieces(18, 11) = PictureBox218
        TwoDArrayPieces(19, 11) = PictureBox219
        TwoDArrayPieces(20, 11) = PictureBox220
        TwoDArrayPieces(1, 12) = PictureBox221
        TwoDArrayPieces(2, 12) = PictureBox222
        TwoDArrayPieces(3, 12) = PictureBox223
        TwoDArrayPieces(4, 12) = PictureBox224
        TwoDArrayPieces(5, 12) = PictureBox225
        TwoDArrayPieces(6, 12) = PictureBox226
        TwoDArrayPieces(7, 12) = PictureBox227
        TwoDArrayPieces(8, 12) = PictureBox228
        TwoDArrayPieces(9, 12) = PictureBox229
        TwoDArrayPieces(10, 12) = PictureBox230
        TwoDArrayPieces(11, 12) = PictureBox231
        TwoDArrayPieces(12, 12) = PictureBox232
        TwoDArrayPieces(13, 12) = PictureBox233
        TwoDArrayPieces(14, 12) = PictureBox234
        TwoDArrayPieces(15, 12) = PictureBox235
        TwoDArrayPieces(16, 12) = PictureBox236
        TwoDArrayPieces(17, 12) = PictureBox237
        TwoDArrayPieces(18, 12) = PictureBox238
        TwoDArrayPieces(19, 12) = PictureBox239
        TwoDArrayPieces(20, 12) = PictureBox240
        TwoDArrayPieces(1, 13) = PictureBox241
        TwoDArrayPieces(2, 13) = PictureBox242
        TwoDArrayPieces(3, 13) = PictureBox243
        TwoDArrayPieces(4, 13) = PictureBox244
        TwoDArrayPieces(5, 13) = PictureBox245
        TwoDArrayPieces(6, 13) = PictureBox246
        TwoDArrayPieces(7, 13) = PictureBox247
        TwoDArrayPieces(8, 13) = PictureBox248
        TwoDArrayPieces(9, 13) = PictureBox249
        TwoDArrayPieces(10, 13) = PictureBox250
        TwoDArrayPieces(11, 13) = PictureBox251
        TwoDArrayPieces(12, 13) = PictureBox252
        TwoDArrayPieces(13, 13) = PictureBox253
        TwoDArrayPieces(14, 13) = PictureBox254
        TwoDArrayPieces(15, 13) = PictureBox255
        TwoDArrayPieces(16, 13) = PictureBox256
        TwoDArrayPieces(17, 13) = PictureBox257
        TwoDArrayPieces(18, 13) = PictureBox258
        TwoDArrayPieces(19, 13) = PictureBox259
        TwoDArrayPieces(20, 13) = PictureBox260
        TwoDArrayPieces(1, 14) = PictureBox261
        TwoDArrayPieces(2, 14) = PictureBox262
        TwoDArrayPieces(3, 14) = PictureBox263
        TwoDArrayPieces(4, 14) = PictureBox264
        TwoDArrayPieces(5, 14) = PictureBox265
        TwoDArrayPieces(6, 14) = PictureBox266
        TwoDArrayPieces(7, 14) = PictureBox267
        TwoDArrayPieces(8, 14) = PictureBox268
        TwoDArrayPieces(9, 14) = PictureBox269
        TwoDArrayPieces(10, 14) = PictureBox270
        TwoDArrayPieces(11, 14) = PictureBox271
        TwoDArrayPieces(12, 14) = PictureBox272
        TwoDArrayPieces(13, 14) = PictureBox273
        TwoDArrayPieces(14, 14) = PictureBox274
        TwoDArrayPieces(15, 14) = PictureBox275
        TwoDArrayPieces(16, 14) = PictureBox276
        TwoDArrayPieces(17, 14) = PictureBox277
        TwoDArrayPieces(18, 14) = PictureBox278
        TwoDArrayPieces(19, 14) = PictureBox279
        TwoDArrayPieces(20, 14) = PictureBox280
        TwoDArrayPieces(1, 15) = PictureBox281
        TwoDArrayPieces(2, 15) = PictureBox282
        TwoDArrayPieces(3, 15) = PictureBox283
        TwoDArrayPieces(4, 15) = PictureBox284
        TwoDArrayPieces(5, 15) = PictureBox285
        TwoDArrayPieces(6, 15) = PictureBox286
        TwoDArrayPieces(7, 15) = PictureBox287
        TwoDArrayPieces(8, 15) = PictureBox288
        TwoDArrayPieces(9, 15) = PictureBox289
        TwoDArrayPieces(10, 15) = PictureBox290
        TwoDArrayPieces(11, 15) = PictureBox291
        TwoDArrayPieces(12, 15) = PictureBox292
        TwoDArrayPieces(13, 15) = PictureBox293
        TwoDArrayPieces(14, 15) = PictureBox294
        TwoDArrayPieces(15, 15) = PictureBox295
        TwoDArrayPieces(16, 15) = PictureBox296
        TwoDArrayPieces(17, 15) = PictureBox297
        TwoDArrayPieces(18, 15) = PictureBox298
        TwoDArrayPieces(19, 15) = PictureBox299
        TwoDArrayPieces(20, 15) = PictureBox300
        TwoDArrayPieces(1, 16) = PictureBox301
        TwoDArrayPieces(2, 16) = PictureBox302
        TwoDArrayPieces(3, 16) = PictureBox303
        TwoDArrayPieces(4, 16) = PictureBox304
        TwoDArrayPieces(5, 16) = PictureBox305
        TwoDArrayPieces(6, 16) = PictureBox306
        TwoDArrayPieces(7, 16) = PictureBox307
        TwoDArrayPieces(8, 16) = PictureBox308
        TwoDArrayPieces(9, 16) = PictureBox309
        TwoDArrayPieces(10, 16) = PictureBox310
        TwoDArrayPieces(11, 16) = PictureBox311
        TwoDArrayPieces(12, 16) = PictureBox312
        TwoDArrayPieces(13, 16) = PictureBox313
        TwoDArrayPieces(14, 16) = PictureBox314
        TwoDArrayPieces(15, 16) = PictureBox315
        TwoDArrayPieces(16, 16) = PictureBox316
        TwoDArrayPieces(17, 16) = PictureBox317
        TwoDArrayPieces(18, 16) = PictureBox318
        TwoDArrayPieces(19, 16) = PictureBox319
        TwoDArrayPieces(20, 16) = PictureBox320
        TwoDArrayPieces(1, 17) = PictureBox321
        TwoDArrayPieces(2, 17) = PictureBox322
        TwoDArrayPieces(3, 17) = PictureBox323
        TwoDArrayPieces(4, 17) = PictureBox324
        TwoDArrayPieces(5, 17) = PictureBox325
        TwoDArrayPieces(6, 17) = PictureBox326
        TwoDArrayPieces(7, 17) = PictureBox327
        TwoDArrayPieces(8, 17) = PictureBox328
        TwoDArrayPieces(9, 17) = PictureBox329
        TwoDArrayPieces(10, 17) = PictureBox330
        TwoDArrayPieces(11, 17) = PictureBox331
        TwoDArrayPieces(12, 17) = PictureBox332
        TwoDArrayPieces(13, 17) = PictureBox333
        TwoDArrayPieces(14, 17) = PictureBox334
        TwoDArrayPieces(15, 17) = PictureBox335
        TwoDArrayPieces(16, 17) = PictureBox336
        TwoDArrayPieces(17, 17) = PictureBox337
        TwoDArrayPieces(18, 17) = PictureBox338
        TwoDArrayPieces(19, 17) = PictureBox339
        TwoDArrayPieces(20, 17) = PictureBox340
        TwoDArrayPieces(1, 18) = PictureBox341
        TwoDArrayPieces(2, 18) = PictureBox342
        TwoDArrayPieces(3, 18) = PictureBox343
        TwoDArrayPieces(4, 18) = PictureBox344
        TwoDArrayPieces(5, 18) = PictureBox345
        TwoDArrayPieces(6, 18) = PictureBox346
        TwoDArrayPieces(7, 18) = PictureBox347
        TwoDArrayPieces(8, 18) = PictureBox348
        TwoDArrayPieces(9, 18) = PictureBox349
        TwoDArrayPieces(10, 18) = PictureBox350
        TwoDArrayPieces(11, 18) = PictureBox351
        TwoDArrayPieces(12, 18) = PictureBox352
        TwoDArrayPieces(13, 18) = PictureBox353
        TwoDArrayPieces(14, 18) = PictureBox354
        TwoDArrayPieces(15, 18) = PictureBox355
        TwoDArrayPieces(16, 18) = PictureBox356
        TwoDArrayPieces(17, 18) = PictureBox357
        TwoDArrayPieces(18, 18) = PictureBox358
        TwoDArrayPieces(19, 18) = PictureBox359
        TwoDArrayPieces(20, 18) = PictureBox360
        TwoDArrayPieces(1, 19) = PictureBox361
        TwoDArrayPieces(2, 19) = PictureBox362
        TwoDArrayPieces(3, 19) = PictureBox363
        TwoDArrayPieces(4, 19) = PictureBox364
        TwoDArrayPieces(5, 19) = PictureBox365
        TwoDArrayPieces(6, 19) = PictureBox366
        TwoDArrayPieces(7, 19) = PictureBox367
        TwoDArrayPieces(8, 19) = PictureBox368
        TwoDArrayPieces(9, 19) = PictureBox369
        TwoDArrayPieces(10, 19) = PictureBox370
        TwoDArrayPieces(11, 19) = PictureBox371
        TwoDArrayPieces(12, 19) = PictureBox372
        TwoDArrayPieces(13, 19) = PictureBox373
        TwoDArrayPieces(14, 19) = PictureBox374
        TwoDArrayPieces(15, 19) = PictureBox375
        TwoDArrayPieces(16, 19) = PictureBox376
        TwoDArrayPieces(17, 19) = PictureBox377
        TwoDArrayPieces(18, 19) = PictureBox378
        TwoDArrayPieces(19, 19) = PictureBox379
        TwoDArrayPieces(20, 19) = PictureBox380
        TwoDArrayPieces(1, 20) = PictureBox381
        TwoDArrayPieces(2, 20) = PictureBox382
        TwoDArrayPieces(3, 20) = PictureBox383
        TwoDArrayPieces(4, 20) = PictureBox384
        TwoDArrayPieces(5, 20) = PictureBox385
        TwoDArrayPieces(6, 20) = PictureBox386
        TwoDArrayPieces(7, 20) = PictureBox387
        TwoDArrayPieces(8, 20) = PictureBox388
        TwoDArrayPieces(9, 20) = PictureBox389
        TwoDArrayPieces(10, 20) = PictureBox390
        TwoDArrayPieces(11, 20) = PictureBox391
        TwoDArrayPieces(12, 20) = PictureBox392
        TwoDArrayPieces(13, 20) = PictureBox393
        TwoDArrayPieces(14, 20) = PictureBox394
        TwoDArrayPieces(15, 20) = PictureBox395
        TwoDArrayPieces(16, 20) = PictureBox396
        TwoDArrayPieces(17, 20) = PictureBox397
        TwoDArrayPieces(18, 20) = PictureBox398
        TwoDArrayPieces(19, 20) = PictureBox399
        TwoDArrayPieces(20, 20) = PictureBox400
        TwoDArrayPieces(1, 21) = PictureBox401
        TwoDArrayPieces(2, 21) = PictureBox402
        TwoDArrayPieces(3, 21) = PictureBox403
        TwoDArrayPieces(4, 21) = PictureBox404
        TwoDArrayPieces(5, 21) = PictureBox405
        TwoDArrayPieces(6, 21) = PictureBox406
        TwoDArrayPieces(7, 21) = PictureBox407
        TwoDArrayPieces(8, 21) = PictureBox408
        TwoDArrayPieces(9, 21) = PictureBox409
        TwoDArrayPieces(10, 21) = PictureBox410
        TwoDArrayPieces(11, 21) = PictureBox411
        TwoDArrayPieces(12, 21) = PictureBox412
        TwoDArrayPieces(13, 21) = PictureBox413
        TwoDArrayPieces(14, 21) = PictureBox414
        TwoDArrayPieces(15, 21) = PictureBox415
        TwoDArrayPieces(16, 21) = PictureBox416
        TwoDArrayPieces(17, 21) = PictureBox417
        TwoDArrayPieces(18, 21) = PictureBox418
        TwoDArrayPieces(19, 21) = PictureBox419
        TwoDArrayPieces(20, 21) = PictureBox420
        TwoDArrayPieces(1, 22) = PictureBox421
        TwoDArrayPieces(2, 22) = PictureBox422
        TwoDArrayPieces(3, 22) = PictureBox423
        TwoDArrayPieces(4, 22) = PictureBox424
        TwoDArrayPieces(5, 22) = PictureBox425
        TwoDArrayPieces(6, 22) = PictureBox426
        TwoDArrayPieces(7, 22) = PictureBox427
        TwoDArrayPieces(8, 22) = PictureBox428
        TwoDArrayPieces(9, 22) = PictureBox429
        TwoDArrayPieces(10, 22) = PictureBox430
        TwoDArrayPieces(11, 22) = PictureBox431
        TwoDArrayPieces(12, 22) = PictureBox432
        TwoDArrayPieces(13, 22) = PictureBox433
        TwoDArrayPieces(14, 22) = PictureBox434
        TwoDArrayPieces(15, 22) = PictureBox435
        TwoDArrayPieces(16, 22) = PictureBox436
        TwoDArrayPieces(17, 22) = PictureBox437
        TwoDArrayPieces(18, 22) = PictureBox438
        TwoDArrayPieces(19, 22) = PictureBox439
        TwoDArrayPieces(20, 22) = PictureBox440
        TwoDArrayPieces(1, 23) = PictureBox441
        TwoDArrayPieces(2, 23) = PictureBox442
        TwoDArrayPieces(3, 23) = PictureBox443
        TwoDArrayPieces(4, 23) = PictureBox444
        TwoDArrayPieces(5, 23) = PictureBox445
        TwoDArrayPieces(6, 23) = PictureBox446
        TwoDArrayPieces(7, 23) = PictureBox447
        TwoDArrayPieces(8, 23) = PictureBox448
        TwoDArrayPieces(9, 23) = PictureBox449
        TwoDArrayPieces(10, 23) = PictureBox450
        TwoDArrayPieces(11, 23) = PictureBox451
        TwoDArrayPieces(12, 23) = PictureBox452
        TwoDArrayPieces(13, 23) = PictureBox453
        TwoDArrayPieces(14, 23) = PictureBox454
        TwoDArrayPieces(15, 23) = PictureBox455
        TwoDArrayPieces(16, 23) = PictureBox456
        TwoDArrayPieces(17, 23) = PictureBox457
        TwoDArrayPieces(18, 23) = PictureBox458
        TwoDArrayPieces(19, 23) = PictureBox459
        TwoDArrayPieces(20, 23) = PictureBox460
        TwoDArrayPieces(1, 24) = PictureBox461
        TwoDArrayPieces(2, 24) = PictureBox462
        TwoDArrayPieces(3, 24) = PictureBox463
        TwoDArrayPieces(4, 24) = PictureBox464
        TwoDArrayPieces(5, 24) = PictureBox465
        TwoDArrayPieces(6, 24) = PictureBox466
        TwoDArrayPieces(7, 24) = PictureBox467
        TwoDArrayPieces(8, 24) = PictureBox468
        TwoDArrayPieces(9, 24) = PictureBox469
        TwoDArrayPieces(10, 24) = PictureBox470
        TwoDArrayPieces(11, 24) = PictureBox471
        TwoDArrayPieces(12, 24) = PictureBox472
        TwoDArrayPieces(13, 24) = PictureBox473
        TwoDArrayPieces(14, 24) = PictureBox474
        TwoDArrayPieces(15, 24) = PictureBox475
        TwoDArrayPieces(16, 24) = PictureBox476
        TwoDArrayPieces(17, 24) = PictureBox477
        TwoDArrayPieces(18, 24) = PictureBox478
        TwoDArrayPieces(19, 24) = PictureBox479
        TwoDArrayPieces(20, 24) = PictureBox480
        TwoDArrayPieces(1, 25) = PictureBox481
        TwoDArrayPieces(2, 25) = PictureBox482
        TwoDArrayPieces(3, 25) = PictureBox483
        TwoDArrayPieces(4, 25) = PictureBox484
        TwoDArrayPieces(5, 25) = PictureBox485
        TwoDArrayPieces(6, 25) = PictureBox486
        TwoDArrayPieces(7, 25) = PictureBox487
        TwoDArrayPieces(8, 25) = PictureBox488
        TwoDArrayPieces(9, 25) = PictureBox489
        TwoDArrayPieces(10, 25) = PictureBox490
        TwoDArrayPieces(11, 25) = PictureBox491
        TwoDArrayPieces(12, 25) = PictureBox492
        TwoDArrayPieces(13, 25) = PictureBox493
        TwoDArrayPieces(14, 25) = PictureBox494
        TwoDArrayPieces(15, 25) = PictureBox495
        TwoDArrayPieces(16, 25) = PictureBox496
        TwoDArrayPieces(17, 25) = PictureBox497
        TwoDArrayPieces(18, 25) = PictureBox498
        TwoDArrayPieces(19, 25) = PictureBox499
        TwoDArrayPieces(20, 25) = PictureBox500
        TwoDArrayPieces(1, 26) = PictureBox501
        TwoDArrayPieces(2, 26) = PictureBox502
        TwoDArrayPieces(3, 26) = PictureBox503
        TwoDArrayPieces(4, 26) = PictureBox504
        TwoDArrayPieces(5, 26) = PictureBox505
        TwoDArrayPieces(6, 26) = PictureBox506
        TwoDArrayPieces(7, 26) = PictureBox507
        TwoDArrayPieces(8, 26) = PictureBox508
        TwoDArrayPieces(9, 26) = PictureBox509
        TwoDArrayPieces(10, 26) = PictureBox510
        TwoDArrayPieces(11, 26) = PictureBox511
        TwoDArrayPieces(12, 26) = PictureBox512
        TwoDArrayPieces(13, 26) = PictureBox513
        TwoDArrayPieces(14, 26) = PictureBox514
        TwoDArrayPieces(15, 26) = PictureBox515
        TwoDArrayPieces(16, 26) = PictureBox516
        TwoDArrayPieces(17, 26) = PictureBox517
        TwoDArrayPieces(18, 26) = PictureBox518
        TwoDArrayPieces(19, 26) = PictureBox519
        TwoDArrayPieces(20, 26) = PictureBox520
        TwoDArrayPieces(1, 27) = PictureBox521
        TwoDArrayPieces(2, 27) = PictureBox522
        TwoDArrayPieces(3, 27) = PictureBox523
        TwoDArrayPieces(4, 27) = PictureBox524
        TwoDArrayPieces(5, 27) = PictureBox525
        TwoDArrayPieces(6, 27) = PictureBox526
        TwoDArrayPieces(7, 27) = PictureBox527
        TwoDArrayPieces(8, 27) = PictureBox528
        TwoDArrayPieces(9, 27) = PictureBox529
        TwoDArrayPieces(10, 27) = PictureBox530
        TwoDArrayPieces(11, 27) = PictureBox531
        TwoDArrayPieces(12, 27) = PictureBox532
        TwoDArrayPieces(13, 27) = PictureBox533
        TwoDArrayPieces(14, 27) = PictureBox534
        TwoDArrayPieces(15, 27) = PictureBox535
        TwoDArrayPieces(16, 27) = PictureBox536
        TwoDArrayPieces(17, 27) = PictureBox537
        TwoDArrayPieces(18, 27) = PictureBox538
        TwoDArrayPieces(19, 27) = PictureBox539
        TwoDArrayPieces(20, 27) = PictureBox540
        TwoDArrayPieces(1, 28) = PictureBox541
        TwoDArrayPieces(2, 28) = PictureBox542
        TwoDArrayPieces(3, 28) = PictureBox543
        TwoDArrayPieces(4, 28) = PictureBox544
        TwoDArrayPieces(5, 28) = PictureBox545
        TwoDArrayPieces(6, 28) = PictureBox546
        TwoDArrayPieces(7, 28) = PictureBox547
        TwoDArrayPieces(8, 28) = PictureBox548
        TwoDArrayPieces(9, 28) = PictureBox549
        TwoDArrayPieces(10, 28) = PictureBox550
        TwoDArrayPieces(11, 28) = PictureBox551
        TwoDArrayPieces(12, 28) = PictureBox552
        TwoDArrayPieces(13, 28) = PictureBox553
        TwoDArrayPieces(14, 28) = PictureBox554
        TwoDArrayPieces(15, 28) = PictureBox555
        TwoDArrayPieces(16, 28) = PictureBox556
        TwoDArrayPieces(17, 28) = PictureBox557
        TwoDArrayPieces(18, 28) = PictureBox558
        TwoDArrayPieces(19, 28) = PictureBox559
        TwoDArrayPieces(20, 28) = PictureBox560
        TwoDArrayPieces(1, 29) = PictureBox561
        TwoDArrayPieces(2, 29) = PictureBox562
        TwoDArrayPieces(3, 29) = PictureBox563
        TwoDArrayPieces(4, 29) = PictureBox564
        TwoDArrayPieces(5, 29) = PictureBox565
        TwoDArrayPieces(6, 29) = PictureBox566
        TwoDArrayPieces(7, 29) = PictureBox567
        TwoDArrayPieces(8, 29) = PictureBox568
        TwoDArrayPieces(9, 29) = PictureBox569
        TwoDArrayPieces(10, 29) = PictureBox570
        TwoDArrayPieces(11, 29) = PictureBox571
        TwoDArrayPieces(12, 29) = PictureBox572
        TwoDArrayPieces(13, 29) = PictureBox573
        TwoDArrayPieces(14, 29) = PictureBox574
        TwoDArrayPieces(15, 29) = PictureBox575
        TwoDArrayPieces(16, 29) = PictureBox576
        TwoDArrayPieces(17, 29) = PictureBox577
        TwoDArrayPieces(18, 29) = PictureBox578
        TwoDArrayPieces(19, 29) = PictureBox579
        TwoDArrayPieces(20, 29) = PictureBox580
        TwoDArrayPieces(1, 30) = PictureBox581
        TwoDArrayPieces(2, 30) = PictureBox582
        TwoDArrayPieces(3, 30) = PictureBox583
        TwoDArrayPieces(4, 30) = PictureBox584
        TwoDArrayPieces(5, 30) = PictureBox585
        TwoDArrayPieces(6, 30) = PictureBox586
        TwoDArrayPieces(7, 30) = PictureBox587
        TwoDArrayPieces(8, 30) = PictureBox588
        TwoDArrayPieces(9, 30) = PictureBox589
        TwoDArrayPieces(10, 30) = PictureBox590
        TwoDArrayPieces(11, 30) = PictureBox591
        TwoDArrayPieces(12, 30) = PictureBox592
        TwoDArrayPieces(13, 30) = PictureBox593
        TwoDArrayPieces(14, 30) = PictureBox594
        TwoDArrayPieces(15, 30) = PictureBox595
        TwoDArrayPieces(16, 30) = PictureBox596
        TwoDArrayPieces(17, 30) = PictureBox597
        TwoDArrayPieces(18, 30) = PictureBox598
        TwoDArrayPieces(19, 30) = PictureBox599
        TwoDArrayPieces(20, 30) = PictureBox600
        'which piece to send down
        reset()
        makepiece()
        reset()
        makepiece()
    End Sub

    'key downs
    Private Sub frmMain_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim key As KeyEventArgs
        key = e
        If key.KeyCode = Keys.P Then
            test.Enabled = False
            movesdown.Enabled = False
            frmPause.Show()
        End If
        If movesdown.Enabled = True Then
            'moves pieces
            If key.KeyCode = Keys.Left Then
                'left
                If x1 - 1 > 0 And x2 - 1 > 0 And x3 - 1 > 0 And x4 - 1 > 0 Then
                    If (TwoDArrayPieces(x1 - 1, y1).BackColor = Color.Transparent Or (x1 - 1 = x2 And y1 = y2) Or (x1 - 1 = x3 And y1 = y3) Or (x1 - 1 = x4 And y1 = y4)) And (TwoDArrayPieces(x2 - 1, y2).BackColor = Color.Transparent Or (x2 - 1 = x1 And y2 = y1) Or (x2 - 1 = x3 And y2 = y3) Or (x2 - 1 = x4 And y2 = y4)) And (TwoDArrayPieces(x3 - 1, y3).BackColor = Color.Transparent Or (x3 - 1 = x2 And y3 = y2) Or (x3 - 1 = x1 And y3 = y1) Or (x3 - 1 = x4 And y3 = y4)) And (TwoDArrayPieces(x4 - 1, y4).BackColor = Color.Transparent Or (x4 - 1 = x2 And y4 = y2) Or (x4 - 1 = x3 And y4 = y3) Or (x4 - 1 = x1 And y4 = y1)) Then
                        TwoDArrayPieces(x1, y1).BackColor = Color.Transparent
                        TwoDArrayPieces(x2, y2).BackColor = Color.Transparent
                        TwoDArrayPieces(x3, y3).BackColor = Color.Transparent
                        TwoDArrayPieces(x4, y4).BackColor = Color.Transparent
                        TwoDArrayPieces(x1 - 1, y1).BackColor = color1
                        TwoDArrayPieces(x2 - 1, y2).BackColor = color1
                        TwoDArrayPieces(x3 - 1, y3).BackColor = color1
                        TwoDArrayPieces(x4 - 1, y4).BackColor = color1
                        x1 -= 1
                        x2 -= 1
                        x3 -= 1
                        x4 -= 1
                    End If
                End If
            End If
            If key.KeyCode = Keys.Right Then
                'right
                If x1 + 1 < 21 And x2 + 1 < 21 And x3 + 1 < 21 And x4 + 1 < 21 Then
                    If (TwoDArrayPieces(x1 + 1, y1).BackColor = Color.Transparent Or (x1 + 1 = x2 And y1 = y2) Or (x1 + 1 = x3 And y1 = y3) Or (x1 + 1 = x4 And y1 = y4)) And (TwoDArrayPieces(x2 + 1, y2).BackColor = Color.Transparent Or (x2 + 1 = x1 And y2 = y1) Or (x2 + 1 = x3 And y2 = y3) Or (x2 + 1 = x4 And y2 = y4)) And (TwoDArrayPieces(x3 + 1, y3).BackColor = Color.Transparent Or (x3 + 1 = x2 And y3 = y2) Or (x3 + 1 = x1 And y3 = y1) Or (x3 + 1 = x4 And y3 = y4)) And (TwoDArrayPieces(x4 + 1, y4).BackColor = Color.Transparent Or (x4 + 1 = x2 And y4 = y2) Or (x4 + 1 = x3 And y4 = y3) Or (x4 + 1 = x1 And y4 = y1)) Then
                        TwoDArrayPieces(x1, y1).BackColor = Color.Transparent
                        TwoDArrayPieces(x2, y2).BackColor = Color.Transparent
                        TwoDArrayPieces(x3, y3).BackColor = Color.Transparent
                        TwoDArrayPieces(x4, y4).BackColor = Color.Transparent
                        TwoDArrayPieces(x1 + 1, y1).BackColor = color1
                        TwoDArrayPieces(x2 + 1, y2).BackColor = color1
                        TwoDArrayPieces(x3 + 1, y3).BackColor = color1
                        TwoDArrayPieces(x4 + 1, y4).BackColor = color1
                        x1 += 1
                        x2 += 1
                        x3 += 1
                        x4 += 1
                    End If
                End If
            End If
            If key.KeyCode = Keys.Up Then
                'up
                TwoDArrayPieces(x1, y1).BackColor = Color.Transparent
                TwoDArrayPieces(x2, y2).BackColor = Color.Transparent
                TwoDArrayPieces(x3, y3).BackColor = Color.Transparent
                TwoDArrayPieces(x4, y4).BackColor = Color.Transparent
                If rotate = 1 Then
                    If randomWhichPiece = 1 Then
                        x1 += 1
                        y1 += 1
                        x3 -= 1
                        y3 -= 1
                        x4 -= 2
                        y4 -= 2
                    ElseIf randomWhichPiece = 3 Then
                        x1 += 1
                        y1 -= 1
                        x3 -= 1
                        y3 += 1
                        x4 -= 1
                        y4 -= 1
                    ElseIf randomWhichPiece = 4 Then
                        x2 -= 1
                        y2 += 1
                        y3 -= 2
                        x4 -= 1
                        y4 -= 1
                    ElseIf randomWhichPiece = 5 Then
                        x1 += 1
                        y1 -= 1
                        x3 -= 1
                        y3 -= 1
                        x4 -= 2
                    ElseIf randomWhichPiece = 6 Then
                        x1 += 1
                        y1 += 1
                        x3 -= 1
                        y3 -= 1
                        x4 -= 2
                    ElseIf randomWhichPiece = 7 Then
                        x1 -= 1
                        y1 += 1
                        x3 += 1
                        y3 -= 1
                        x4 += 2
                    End If
                ElseIf rotate = 2 Then
                    If randomWhichPiece = 1 Then
                        x1 -= 1
                        y1 -= 1
                        x3 += 1
                        y3 += 1
                        x4 += 2
                        y4 += 2
                    ElseIf randomWhichPiece = 3 Then
                        x1 += 1
                        y1 += 1
                        x3 -= 1
                        y3 -= 1
                        x4 += 1
                        y4 -= 1
                    ElseIf randomWhichPiece = 4 Then
                        x2 += 1
                        y2 -= 1
                        y3 += 2
                        x4 += 1
                        y4 += 1
                    ElseIf randomWhichPiece = 5 Then
                        x1 -= 1
                        y1 += 1
                        x3 += 1
                        y3 += 1
                        x4 += 2
                    ElseIf randomWhichPiece = 6 Then
                        x1 -= 1
                        y1 += 1
                        x3 += 1
                        y3 -= 1
                        y4 -= 2
                    ElseIf randomWhichPiece = 7 Then
                        x1 += 1
                        y1 += 1
                        x3 -= 1
                        y3 -= 1
                        y4 -= 2
                    End If
                ElseIf rotate = 3 Then
                    If randomWhichPiece = 1 Then
                        x1 += 1
                        y1 += 1
                        x3 -= 1
                        y3 -= 1
                        x4 -= 2
                        y4 -= 2
                    ElseIf randomWhichPiece = 3 Then
                        x1 -= 1
                        y1 += 1
                        x3 += 1
                        y3 -= 1
                        x4 += 1
                        y4 += 1
                    ElseIf randomWhichPiece = 4 Then
                        x2 -= 1
                        y2 += 1
                        y3 -= 2
                        x4 -= 1
                        y4 -= 1
                    ElseIf randomWhichPiece = 5 Then
                        x1 += 1
                        y1 -= 1
                        x3 -= 1
                        y3 -= 1
                        x4 -= 2
                    ElseIf randomWhichPiece = 6 Then
                        x1 -= 1
                        y1 -= 1
                        x3 += 1
                        y3 += 1
                        x4 += 2
                    ElseIf randomWhichPiece = 7 Then
                        x1 += 1
                        y1 -= 1
                        x3 -= 1
                        y3 += 1
                        x4 -= 2
                    End If
                ElseIf rotate = 4 Then
                    If randomWhichPiece = 1 Then
                        x1 -= 1
                        y1 -= 1
                        x3 += 1
                        y3 += 1
                        x4 += 2
                        y4 += 2
                    ElseIf randomWhichPiece = 3 Then
                        x1 -= 1
                        y1 -= 1
                        x3 += 1
                        y3 += 1
                        x4 -= 1
                        y4 += 1
                    ElseIf randomWhichPiece = 4 Then
                        x2 += 1
                        y2 -= 1
                        y3 += 2
                        x4 += 1
                        y4 += 1
                    ElseIf randomWhichPiece = 5 Then
                        x1 -= 1
                        y1 += 1
                        x3 += 1
                        y3 += 1
                        x4 += 2
                    ElseIf randomWhichPiece = 6 Then
                        x1 += 1
                        y1 -= 1
                        x3 -= 1
                        y3 += 1
                        y4 += 2
                    ElseIf randomWhichPiece = 7 Then
                        x1 -= 1
                        y1 -= 1
                        x3 += 1
                        y3 += 1
                        y4 += 2
                    End If
                End If
                TwoDArrayPieces(x1, y1).BackColor = color1
                TwoDArrayPieces(x2, y2).BackColor = color1
                TwoDArrayPieces(x3, y3).BackColor = color1
                TwoDArrayPieces(x4, y4).BackColor = color1
                If rotate < 4 Then
                    rotate += 1
                Else
                    rotate = 1
                End If
            End If
            'changes speed of piecies
            If key.KeyCode = Keys.Down Then
                'down
                movesdown.Interval = 10
            End If
        End If
    End Sub

    'close button
    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    'scoring
    Private Sub scoring()
        lbllevel.Text = "level" & ControlChars.NewLine & level
        lblscore.Text = "score" & ControlChars.NewLine & score
        For x = 1 To 20
            If TwoDArrayPieces(x, ycheck).BackColor <> Color.Transparent Then
                levelcounter += 1
            End If
        Next
        If levelcounter = 20 Then
            linecounter += 1
            For x = 1 To 20
                TwoDArrayPieces(x, ycheck).BackColor = Color.Transparent
            Next
            For y = ycheck To 1 Step -1
                For x = 1 To 20
                    If y > 1 Then
                        TwoDArrayPieces(x, y).BackColor = TwoDArrayPieces(x, y - 1).BackColor
                    Else
                        TwoDArrayPieces(x, y).BackColor = Color.Transparent
                    End If
                Next
            Next
            score += 40 * (level + 1)
        End If
        If linecounter = 10 Then
            level += 1
            linecounter = 0
        End If
        ycheck += 1
        If ycheck = 31 Then
            ycheck = 1
        End If
        levelcounter = 0
    End Sub

    'next up
    Private Sub nextup()
        If randomWhichPiece1 = 1 Then
            PictureBox601.Visible = False
            PictureBox602.Visible = True
            PictureBox603.Visible = False
            PictureBox604.Visible = True
            PictureBox605.Visible = False
            PictureBox606.Visible = False
            PictureBox607.Visible = False
            PictureBox608.Visible = False
            PictureBox609.Visible = False
            PictureBox610.Visible = False
            PictureBox611.Visible = False
            PictureBox612.Visible = False
            PictureBox613.Visible = False
            PictureBox614.Visible = False
            PictureBox615.Visible = False
            PictureBox616.Visible = False
            PictureBox617.Visible = False
            PictureBox618.Visible = False
            PictureBox619.Visible = False
            PictureBox620.Visible = False
            PictureBox621.Visible = True
            PictureBox622.Visible = False
            PictureBox623.Visible = False
            PictureBox624.Visible = False
            PictureBox625.Visible = True
            PictureBox626.Visible = False
            PictureBox627.Visible = False
            PictureBox628.Visible = False
        ElseIf randomWhichPiece1 = 2 Then
            PictureBox601.Visible = False
            PictureBox602.Visible = False
            PictureBox603.Visible = False
            PictureBox604.Visible = False
            PictureBox605.Visible = False
            PictureBox606.Visible = False
            PictureBox607.Visible = False
            PictureBox608.Visible = False
            PictureBox609.Visible = True
            PictureBox610.Visible = False
            PictureBox611.Visible = True
            PictureBox612.Visible = False
            PictureBox613.Visible = True
            PictureBox614.Visible = False
            PictureBox615.Visible = False
            PictureBox616.Visible = False
            PictureBox617.Visible = False
            PictureBox618.Visible = False
            PictureBox619.Visible = False
            PictureBox620.Visible = False
            PictureBox621.Visible = False
            PictureBox622.Visible = False
            PictureBox623.Visible = False
            PictureBox624.Visible = False
            PictureBox625.Visible = False
            PictureBox626.Visible = True
            PictureBox627.Visible = False
            PictureBox628.Visible = False
        ElseIf randomWhichPiece1 = 3 Then
            PictureBox601.Visible = False
            PictureBox602.Visible = False
            PictureBox603.Visible = False
            PictureBox604.Visible = False
            PictureBox605.Visible = False
            PictureBox606.Visible = False
            PictureBox607.Visible = False
            PictureBox608.Visible = False
            PictureBox609.Visible = False
            PictureBox610.Visible = False
            PictureBox611.Visible = False
            PictureBox612.Visible = False
            PictureBox613.Visible = False
            PictureBox614.Visible = True
            PictureBox615.Visible = False
            PictureBox616.Visible = True
            PictureBox617.Visible = False
            PictureBox618.Visible = True
            PictureBox619.Visible = False
            PictureBox620.Visible = False
            PictureBox621.Visible = False
            PictureBox622.Visible = False
            PictureBox623.Visible = False
            PictureBox624.Visible = False
            PictureBox625.Visible = False
            PictureBox626.Visible = False
            PictureBox627.Visible = True
            PictureBox628.Visible = False
        ElseIf randomWhichPiece1 = 4 Then
            PictureBox601.Visible = False
            PictureBox602.Visible = False
            PictureBox603.Visible = True
            PictureBox604.Visible = False
            PictureBox605.Visible = False
            PictureBox606.Visible = False
            PictureBox607.Visible = False
            PictureBox608.Visible = False
            PictureBox609.Visible = False
            PictureBox610.Visible = True
            PictureBox611.Visible = False
            PictureBox612.Visible = True
            PictureBox613.Visible = False
            PictureBox614.Visible = False
            PictureBox615.Visible = False
            PictureBox616.Visible = False
            PictureBox617.Visible = False
            PictureBox618.Visible = False
            PictureBox619.Visible = False
            PictureBox620.Visible = True
            PictureBox621.Visible = False
            PictureBox622.Visible = False
            PictureBox623.Visible = False
            PictureBox624.Visible = False
            PictureBox625.Visible = False
            PictureBox626.Visible = False
            PictureBox627.Visible = False
            PictureBox628.Visible = False
        ElseIf randomWhichPiece1 = 5 Then
            PictureBox601.Visible = False
            PictureBox602.Visible = False
            PictureBox603.Visible = False
            PictureBox604.Visible = False
            PictureBox605.Visible = False
            PictureBox606.Visible = True
            PictureBox607.Visible = False
            PictureBox608.Visible = True
            PictureBox609.Visible = False
            PictureBox610.Visible = False
            PictureBox611.Visible = False
            PictureBox612.Visible = False
            PictureBox613.Visible = False
            PictureBox614.Visible = False
            PictureBox615.Visible = True
            PictureBox616.Visible = False
            PictureBox617.Visible = False
            PictureBox618.Visible = False
            PictureBox619.Visible = False
            PictureBox620.Visible = False
            PictureBox621.Visible = False
            PictureBox622.Visible = False
            PictureBox623.Visible = False
            PictureBox624.Visible = True
            PictureBox625.Visible = False
            PictureBox626.Visible = False
            PictureBox627.Visible = False
            PictureBox628.Visible = False
        ElseIf randomWhichPiece1 = 6 Then
            PictureBox601.Visible = True
            PictureBox602.Visible = False
            PictureBox603.Visible = False
            PictureBox604.Visible = False
            PictureBox605.Visible = False
            PictureBox606.Visible = False
            PictureBox607.Visible = True
            PictureBox608.Visible = False
            PictureBox609.Visible = False
            PictureBox610.Visible = False
            PictureBox611.Visible = False
            PictureBox612.Visible = False
            PictureBox613.Visible = False
            PictureBox614.Visible = False
            PictureBox615.Visible = False
            PictureBox616.Visible = False
            PictureBox617.Visible = True
            PictureBox618.Visible = False
            PictureBox619.Visible = False
            PictureBox620.Visible = False
            PictureBox621.Visible = False
            PictureBox622.Visible = False
            PictureBox623.Visible = True
            PictureBox624.Visible = False
            PictureBox625.Visible = False
            PictureBox626.Visible = False
            PictureBox627.Visible = False
            PictureBox628.Visible = False
        ElseIf randomWhichPiece1 = 7 Then
            PictureBox601.Visible = False
            PictureBox602.Visible = False
            PictureBox603.Visible = False
            PictureBox604.Visible = False
            PictureBox605.Visible = True
            PictureBox606.Visible = False
            PictureBox607.Visible = False
            PictureBox608.Visible = False
            PictureBox609.Visible = False
            PictureBox610.Visible = False
            PictureBox611.Visible = False
            PictureBox612.Visible = False
            PictureBox613.Visible = False
            PictureBox614.Visible = False
            PictureBox615.Visible = False
            PictureBox616.Visible = False
            PictureBox617.Visible = False
            PictureBox618.Visible = False
            PictureBox619.Visible = True
            PictureBox620.Visible = False
            PictureBox621.Visible = False
            PictureBox622.Visible = True
            PictureBox623.Visible = False
            PictureBox624.Visible = False
            PictureBox625.Visible = False
            PictureBox626.Visible = False
            PictureBox627.Visible = False
            PictureBox628.Visible = True
        End If
    End Sub

End Class

