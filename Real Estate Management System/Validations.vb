Imports System.Text.RegularExpressions

Module Validations
    Public Function IsEmpty(ByVal input As String) As Boolean

        input = Trim(input)
        If String.IsNullOrEmpty(input) Then
            Return True
        End If
        Return False
    End Function



    Public Function isDigit(ByVal input As String) As Boolean
        If Char.IsDigit(input) Then

            Return True
        End If
        Return False
    End Function

    Public Function MoreThanZero(ByVal value) As Boolean
        If isDigit(value) AndAlso value > 0 Then
            Return True
        End If
        Return False
    End Function



    Public Function Validename(ByVal strname As String) As Boolean
        If Regex.Match(strname, "^[a-zA-Z\s]+$").Success Then
            Return True

        End If
        Return False
    End Function
    Public Function Validmail(ByVal strmail As String) As Boolean
        If Regex.Match(strmail, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success Then
            Return True

        End If
        Return False

    End Function
    Public Function Validphone(ByVal strmail As String) As Boolean
        If Regex.Match(strmail, "([0-9]){10}").Success Then
            Return True

        End If
        Return False

    End Function






End Module
