Imports System.Text
Imports System.Net
Imports System.IO
'Imports System.Web.Script.Serialization
Imports BitmapDetector2.Search_Image
Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Collections
Imports System
Public Class Form1
    Dim user_ As String
    Dim pass_ As String
    Dim region_ As String
    Dim lolpath_ As String
    Public version As String
    Public upurl As String
    Public upavail As Boolean




#Region "Section - Declarations"
    Private Declare Sub mouse_event Lib "user32.dll" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As IntPtr)



    Public Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short
    Private Const mouseclickup = 4
    Private Const mouseclickdown = 2
    Public progress As Integer = 0
    Public countdown As Integer = 0
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Private Const MOUSEEVENTF_ABSOLUTE = &H8000 ' absolute move
    Private Const MOUSEEVENTF_LEFTDOWN = &H2 ' left button down
    Private Const MOUSEEVENTF_LEFTUP = &H4 ' left button up
    Private Const MOUSEEVENTF_MOVE = &H1 ' mouse move
    Private Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Private Const MOUSEEVENTF_MIDDLEUP = &H40
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10
    Declare Function SetCursorPos& Lib "user32" (ByVal p As Point)





#End Region

#Region "Section - Functions & Subs"

    Private Sub PerformMouseClick(ByVal LClick_RClick_DClick As String)
        Const MOUSEEVENTF_LEFTDOWN As Integer = 2
        Const MOUSEEVENTF_LEFTUP As Integer = 4
        Const MOUSEEVENTF_RIGHTDOWN As Integer = 6
        Const MOUSEEVENTF_RIGHTUP As Integer = 8
        If LClick_RClick_DClick = "RClick" Then
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, IntPtr.Zero)
        ElseIf LClick_RClick_DClick = "LClick" Then
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero)
        ElseIf LClick_RClick_DClick = "DClick" Then
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero)
        End If
    End Sub
    Private Function PressButton(ByRef image As Bitmap, ByRef press As Boolean, ByRef x As Integer, ByRef y As Integer)
        Dim bounds As Rectangle
        Dim point As New Point
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(0, 0, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        Dim returnString As Point = BitmapDetector2.Search_Image.search(screenshot, image, 0)
        If returnString.X = 0 And returnString.Y = 0 Then
            Return False
        Else

            If press = True Then
                point.X = returnString.X + x
                point.Y = returnString.Y + y
                Windows.Forms.Cursor.Position = point
                PerformMouseClick("LClick")

            Else
                point.X = returnString.X + x
                point.Y = returnString.Y + y
                Windows.Forms.Cursor.Position = point
            End If

            Return True
        End If
    End Function
    Sub status(ByVal status As String)
        lblStatus.Text = status & " @ " & My.Computer.Clock.LocalTime
    End Sub
#End Region

#Region "Section - Timers"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrStartBot.Tick

        tmrStartBot.Interval = 2000
        If PressButton(My.Resources.android_inactive, True, 10, 10) Then
            FlatListBox1.AddItem("InactiveTab Found!")
            PerformMouseClick("LClick")
            PerformMouseClick("LClick")

            FlatListBox1.AddItem("STOPPED: tmrStartBot")
            FlatListBox1.AddItem("STARTED: tmrPause Enabled = True [Wait 25 SEC]")

            tmrStartBot.Stop()
            tmrPause.Enabled = True
        Else
            status("Searching for InactiveTab")
        End If


    End Sub

    Private Sub tmrPause_Tick(sender As Object, e As EventArgs) Handles tmrPause.Tick
        tmrPause.Enabled = False
        FlatListBox1.AddItem("STOPPED: tmrPause Enabled = False [Done 25 SEC]")
        FlatListBox1.AddItem("STARTED: tmrStartBot2")
        status("TmrPause")
        tmrStartBot2.Start()
    End Sub
    Private Sub tmrWelcome_Tick(sender As Object, e As EventArgs) Handles tmrWelcome.Tick
        tmrWelcome.Enabled = False
        status("Started RestarterBot")
        tmrWelcome.Enabled = False
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 300
        y = Screen.PrimaryScreen.WorkingArea.Height - 621
        Me.Location = New Point(x, y)



        'For Each p5 As Process In Process.GetProcesses()
        '    If p5.ProcessName = "BlueStacks_old" Then 'Or p.ProcessName = "mspaint"
        '        p5.Kill()
        '        FlatListBox1.AddItem("TERMINATED: BlueStacks_old.exe")

        '    ElseIf p5.ProcessName = "BlueStacks_old" Then 'Or p.ProcessName = "mspaint"
        '        p5.Kill()
        '        FlatListBox1.AddItem("TERMINATED: HD-RunApp.exe {NEW}")
        '    Else
        '        Process.Start("C:\ProgramData\BlueStacksGameManager\BlueStacks_old.exe")

        '    End If

        'Next

        For Each p5 As Process In Process.GetProcesses()
            If p5.ProcessName = "BlueStacks" Then 'Or p.ProcessName = "mspaint"
                p5.Kill()
                FlatListBox1.AddItem("TERMINATED: BlueStacks.exe")
            ElseIf p5.ProcessName = "HD-RunApp" Then 'Or p.ProcessName = "mspaint"
                p5.Kill()
                FlatListBox1.AddItem("TERMINATED: HD-RunApp.exe")
            ElseIf p5.ProcessName = "HD-RunAppTemp" Then 'Or p.ProcessName = "mspaint"
                p5.Kill()
                FlatListBox1.AddItem("TERMINATED: HD-RunAppTemp.exe")
            ElseIf p5.ProcessName = "HD-UpdateInstaller" Then 'Or p.ProcessName = "mspaint"
                p5.Kill()
                FlatListBox1.AddItem("TERMINATED: HD-UpdateInstaller.exe")
            ElseIf p5.ProcessName = "HD-UpdateService" Then 'Or p.ProcessName = "mspaint"
                p5.Kill()
                FlatListBox1.AddItem("TERMINATED: HD-UpdateService")
            Else

                Process.Start("C:\ProgramData\BlueStacksGameManager\BlueStacks.exe")
            End If
        Next



        FlatListBox1.AddItem("tmrBsTv Next")
        tmrBsTv.Start()
    End Sub
    Private Sub tmrStartBot2_Tick_1(sender As Object, e As EventArgs) Handles tmrStartBot2.Tick
        tmrStartBot2.Interval = 2000
        FlatListBox1.AddItem("Searching: For Inactive/Active Game Icons")



        If PressButton(My.Resources.billard_inactive3, True, 10, 10) Then
            FlatListBox1.AddItem("Inactive Game Found! {1013}")
            PerformMouseClick("LClick")
            PerformMouseClick("LClick")
        ElseIf PressButton(My.Resources.billard_inactive2, True, 10, 10) Then
            FlatListBox1.AddItem("Inactive Game Found! {1013}")
            PerformMouseClick("LClick")
            PerformMouseClick("LClick")

        ElseIf PressButton(My.Resources.billard_inactive, True, 10, 10) Then
            FlatListBox1.AddItem("Inactive Game Found! {1013}")
            PerformMouseClick("LClick")
            PerformMouseClick("LClick")

        ElseIf PressButton(My.Resources.billard_active2, True, 10, 10) Then
            FlatListBox1.AddItem("Active Game Found! {1013}")
            PerformMouseClick("LClick")
            PerformMouseClick("LClick")

            tmrWait.Enabled = True
            FlatListBox1.AddItem("STARTED: tmrWait")
            FlatListBox1.AddItem("Waiting 3 Seconds")

            'tmrStartBot2.Stop()

        Else
            status("TmrStartBot2")
        End If

    End Sub


    Private Sub tmrWait_Tick(sender As Object, e As EventArgs) Handles tmrWait.Tick
        tmrWait.Enabled = False
        FlatListBox1.AddItem("2 Second wait finished")
        FlatListBox1.AddItem("Waiting for Miniclip")
        FlatListBox1.AddItem("STARTED: tmrStartBot3")
        tmrStartBot3.Start()


    End Sub

    Private Sub tmrStartBot2_Tick(sender As Object, e As EventArgs) Handles tmrStartBot3.Tick
        On Error Resume Next
        tmrStartBot3.Interval = 2000
        If PressButton(My.Resources.miniclip, True, 10, 10) Then
            FlatListBox1.AddItem("Miniclip Detected")
            Process.Start("BillardBot.exe")
            End

        Else
            'Thread.Sleep(2000)
            status("tmrStartBot2")
        End If


    End Sub

    Private Sub tmrBsTv_Tick(sender As Object, e As EventArgs) Handles tmrBsTv.Tick
        Thread.Sleep(2000)
        tmrBsTv.Interval = 2000
        If PressButton(My.Resources.bstvexit, True, 10, 10) Then
            PerformMouseClick("LClick")
            PerformMouseClick("LClick")
            FlatListBox1.AddItem("TERIMINATED: BlueStacks TV ")
            tmrBsTv.Stop()
            FlatListBox1.AddItem("STARTED: tmrStartBot")
            tmrStartBot.Start()
        Else
            status("TmrBsTv")
        End If
    End Sub

    Dim hotkey0 As Boolean
    Private Sub tmrHotkey_Tick(sender As Object, e As EventArgs) Handles tmrHotkey.Tick
        If (GetAsyncKeyState(Keys.NumPad0) And 1) > 0 Then
            hotkey0 = Not hotkey0
            If hotkey0 Then
                End

            Else
                End

            End If
        End If
    End Sub

#End Region


    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrHotkey.Start()
        FlatListBox1.AddItem("EXIT HOTKEY: Numpad + 0")
        tmrWelcome.Enabled = True
        FlatListBox1.AddItem("STARTING IN 5 SECONDS!")
    End Sub



    Private Sub FlatListBox1_Click(sender As Object, e As EventArgs) Handles FlatListBox1.Click

    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        tmrStartBot2.Interval = 2000
        FlatListBox1.AddItem("CONTINUE: tmrStartBot2 {1013}")

        If PressButton(My.Resources.billard_inactive3, True, 10, 10) Then
            FlatListBox1.AddItem("Inactive Game Found! {1013}")
            PerformMouseClick("LClick")
            PerformMouseClick("LClick")
        ElseIf PressButton(My.Resources.billard_inactive2, True, 10, 10) Then
            FlatListBox1.AddItem("Inactive Game Found! {1013}")
            PerformMouseClick("LClick")
            PerformMouseClick("LClick")

        ElseIf PressButton(My.Resources.billard_inactive, True, 10, 10) Then
            FlatListBox1.AddItem("Inactive Game Found! {1013}")
            PerformMouseClick("LClick")
            PerformMouseClick("LClick")

        ElseIf PressButton(My.Resources.billard_active2, True, 10, 10) Then
            FlatListBox1.AddItem("Active Game Found! {1013}")
            PerformMouseClick("LClick")
            PerformMouseClick("LClick")

            tmrWait.Enabled = True
            FlatListBox1.AddItem("STARTED: tmrWait")
            FlatListBox1.AddItem("Waiting 3 seconds")

            'tmrStartBot2.Stop()

        Else
            status("TmrStartBot2")
        End If
    End Sub
End Class
