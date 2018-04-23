Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Resources
Imports System.Windows.Shapes

Namespace AdditionalLegendSample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DataContext = LoadData()
        End Sub

        Private Function LoadData() As List(Of DataPoint)
            Dim result As New List(Of DataPoint)()
            Dim info As StreamResourceInfo = Application.GetResourceStream(New Uri("Data/AUDUSDDaily.csv", UriKind.RelativeOrAbsolute))
            Dim reader As New StreamReader(info.Stream)
            Do While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim values = line.Split(","c)
                Dim point = New DataPoint()
                point.Argument = Date.ParseExact(values(0), "yyyy.MM.dd", Nothing)
                point.OpenValue = Double.Parse(values(1), CultureInfo.InvariantCulture)
                point.HighValue = Double.Parse(values(2), CultureInfo.InvariantCulture)
                point.LowValue = Double.Parse(values(3), CultureInfo.InvariantCulture)
                point.CloseValue = Double.Parse(values(4), CultureInfo.InvariantCulture)
                result.Add(point)
            Loop
            Return result
        End Function
    End Class

    Public Class DataPoint
        Public Property Argument() As Date
        Public Property LowValue() As Double
        Public Property HighValue() As Double
        Public Property OpenValue() As Double
        Public Property CloseValue() As Double
    End Class
End Namespace
