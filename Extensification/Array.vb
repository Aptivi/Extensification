﻿Imports System.Runtime.CompilerServices

Namespace ArrayExts
    Public Module Extensions

        ''' <summary>
        ''' Adds an entry to array
        ''' </summary>
        ''' <typeparam name="T">Type</typeparam>
        ''' <param name="TargetArray">Target array</param>
        ''' <param name="Item">Any item</param>
        ''' <returns>An array with added item</returns>
        <Extension>
        Public Function Add(Of T)(ByVal TargetArray() As T, ByVal Item As T) As T()
            If TargetArray Is Nothing Then Throw New ArgumentNullException(NameOf(TargetArray))
            ReDim Preserve TargetArray(TargetArray.Length)
            TargetArray(TargetArray.Length - 1) = Item
            Return TargetArray
        End Function

        ''' <summary>
        ''' Removes an entry from array
        ''' </summary>
        ''' <typeparam name="T">Type</typeparam>
        ''' <param name="TargetArray">Target array</param>
        ''' <param name="Item">Any item</param>
        ''' <returns>An array without targeted item</returns>
        <Extension>
        Public Function Remove(Of T)(ByVal TargetArray() As T, ByVal Item As T) As T()
            If TargetArray Is Nothing Then Throw New ArgumentNullException(NameOf(TargetArray))
            Dim TargetArrayList As List(Of T) = TargetArray.ToList
            TargetArrayList.Remove(Item)
            Return TargetArrayList.ToArray()
        End Function

        ''' <summary>
        ''' Converts array to array list
        ''' </summary>
        ''' <typeparam name="T">Type</typeparam>
        ''' <param name="TargetArray">Target array</param>
        ''' <returns>An array list of an array</returns>
        <Extension>
        Public Function ToArrayList(Of T)(ByVal TargetArray() As T) As ArrayList
            If TargetArray Is Nothing Then Throw New ArgumentNullException(NameOf(TargetArray))
            Dim ArrayValues As New ArrayList
            ArrayValues.AddRange(TargetArray)
            Return ArrayValues
        End Function

        ''' <summary>
        ''' Gets index from entry
        ''' </summary>
        ''' <typeparam name="T">Type</typeparam>
        ''' <param name="TargetArray">Target array</param>
        ''' <param name="Entry">An entry from array</param>
        ''' <returns>List of indexes. If none is found, returns an empty array list</returns>
        <Extension>
        Public Function GetIndexFromEntry(Of T)(ByVal TargetArray() As T, ByVal Entry As T) As Integer()
            If TargetArray Is Nothing Then Throw New ArgumentNullException(NameOf(TargetArray))
            Dim Indexes As New ArrayList
            For Index As Integer = 0 To TargetArray.Length - 1
                Dim ArrayEntry As Object = TargetArray(Index)
                If ArrayEntry = Entry Then
                    Indexes.Add(Index)
                End If
            Next
            Return Indexes.ToArray(GetType(Integer))
        End Function

        ''' <summary>
        ''' Gets how many non-empty items are there
        ''' </summary>
        ''' <typeparam name="T">Type</typeparam>
        ''' <param name="TargetArray">Target array</param>
        ''' <returns>Count of non-empty items</returns>
        <Extension>
        Public Function CountFullEntries(Of T)(TargetArray() As T) As Long
            Dim FullEntries As Long
            For i As Long = 0 To TargetArray.LongLength - 1
                If TargetArray(i) IsNot Nothing Then
                    If TypeOf TargetArray(i) Is String Then
                        If Not TargetArray(i).Equals("") Then
                            FullEntries += 1
                        End If
                    Else
                        FullEntries += 1
                    End If
                End If
            Next
            Return FullEntries
        End Function

        ''' <summary>
        ''' Gets how many empty items are there
        ''' </summary>
        ''' <typeparam name="T">Type</typeparam>
        ''' <param name="TargetArray">Target array</param>
        ''' <returns>Count of empty items</returns>
        <Extension>
        Public Function CountEmptyEntries(Of T)(TargetArray() As T) As Long
            Dim EmptyEntries As Long
            For i As Long = 0 To TargetArray.LongLength - 1
                If TargetArray(i) Is Nothing Then
                    EmptyEntries += 1
                ElseIf TypeOf TargetArray(i) Is String And TargetArray(i).Equals("") Then
                    EmptyEntries += 1
                End If
            Next
            Return EmptyEntries
        End Function

        ''' <summary>
        ''' Gets indexes of non-empty items
        ''' </summary>
        ''' <typeparam name="T">Type</typeparam>
        ''' <param name="TargetArray">Target array</param>
        ''' <returns>Indexes of non-empty items</returns>
        <Extension>
        Public Function GetIndexesOfFullEntries(Of T)(TargetArray() As T) As Integer()
            Dim FullIndexes As New List(Of Integer)
            For i As Long = 0 To TargetArray.LongLength - 1
                If TargetArray(i) IsNot Nothing Then
                    If TypeOf TargetArray(i) Is String Then
                        If Not TargetArray(i).Equals("") Then
                            FullIndexes.Add(i)
                        End If
                    Else
                        FullIndexes.Add(i)
                    End If
                End If
            Next
            Return FullIndexes.ToArray
        End Function

        ''' <summary>
        ''' Gets indexes of empty items
        ''' </summary>
        ''' <typeparam name="T">Type</typeparam>
        ''' <param name="TargetArray">Target array</param>
        ''' <returns>Indexes of empty items</returns>
        <Extension>
        Public Function GetIndexesOfEmptyEntries(Of T)(TargetArray() As T) As Integer()
            Dim EmptyIndexes As New List(Of Integer)
            For i As Long = 0 To TargetArray.LongLength - 1
                If TargetArray(i) Is Nothing Then
                    EmptyIndexes.Add(i)
                ElseIf TypeOf TargetArray(i) Is String And TargetArray(i).Equals("") Then
                    EmptyIndexes.Add(i)
                End If
            Next
            Return EmptyIndexes.ToArray
        End Function

    End Module
End Namespace
