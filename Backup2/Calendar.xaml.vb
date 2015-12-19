Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes
Imports System.Collections.ObjectModel


Partial Public Class Calendar

    Private helper As ObservableCollection(Of CalendarItem)
    Private dteTime As DateTime
    Private runEvents As Boolean = False
    Private months() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
    Private days() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        helper = New ObservableCollection(Of CalendarItem)()
        dteTime = DateTime.Today

        ReloadItems(dteTime)

       
        lvwCalendar.DataContext = helper



    End Sub

    Public Sub ReloadItems(ByVal currentDate As DateTime)
        Dim frstDay As New DateTime(currentDate.Year, currentDate.Month, 1)
        Dim dayOfWeekPassed As Boolean = False
        Dim _dayofWeek As DayOfWeek = frstDay.DayOfWeek
        Dim dyCounter As Integer = 0
        Dim daysInMonth As Integer
        Dim thick As Thickness
        Dim width As Double
        helper.Clear()
        daysInMonth = days(currentDate.Month - 1)

        If (currentDate.Month = 2) Then
            If (DateTime.IsLeapYear(currentDate.Year)) Then
                daysInMonth = 29
            End If
        End If


        For i As Integer = 0 To 41
            If _dayofWeek = i Then
                dayOfWeekPassed = True
            End If

            If (i > 28) Then
                'check if the date is valie
            End If

            If dayOfWeekPassed Then
                dyCounter += 1
                helper.Add(New CalendarItem(dyCounter.ToString()))
            Else
                helper.Add(New CalendarItem(""))
            End If

            If (dyCounter >= daysInMonth) Then
                Exit For
            End If

            lblMonth.Content = months(dteTime.Month - 1)
            'lblMonth.Content = "December"
            lblYear.Content = dteTime.Year.ToString()

        Next
    End Sub

    Private Sub LinearGradientBrush_SourceUpdated(ByVal sender As System.Object, ByVal e As System.Windows.Data.DataTransferEventArgs)

    End Sub

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        lvwCalendar.SelectedIndex = dteTime.Day + dteTime.DayOfWeek
        runEvents = True
    End Sub

    Private Sub Image1_MouseLeftButtonDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
        Dim newDateTime As DateTime
        Dim month As Integer
        Dim year As Integer

        month = dteTime.Month + 1
        year = dteTime.Year

        If (month = 13) Then
            year = dteTime.Year + 1
            month = 1
        End If

        newDateTime = New DateTime(year, month, dteTime.Day)
        dteTime = newDateTime
        ReloadItems(dteTime)

    End Sub

    Private Sub Image2_MouseLeftButtonDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
        Dim newDateTime As DateTime
        Dim month As Integer
        Dim year As Integer

        month = dteTime.Month - 1
        year = dteTime.Year

        If (month = 0) Then
            year = dteTime.Year - 1
            month = 12
        End If

        newDateTime = New DateTime(year, month, dteTime.Day)
        dteTime = newDateTime
        ReloadItems(dteTime)

    End Sub

    Private Sub ImageMouseButtonDown(ByVal up As Boolean)
        Dim newDateTime As DateTime

    End Sub

    Private Sub imgYearDecrease_MouseLeftButtonDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
        Dim newDateTime As DateTime

        newDateTime = New DateTime(dteTime.Year - 1, dteTime.Month, dteTime.Day)
        dteTime = newDateTime
        ReloadItems(dteTime)
    End Sub

    Private Sub imgYearIncrease_MouseLeftButtonDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
        Dim newDateTime As DateTime

        newDateTime = New DateTime(dteTime.Year + 1, dteTime.Month, dteTime.Day)
        dteTime = newDateTime
        ReloadItems(dteTime)
    End Sub
End Class
