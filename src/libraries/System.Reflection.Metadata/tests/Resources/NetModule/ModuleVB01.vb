' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Imports System.Collections.Generic

' Use types exposed from ModuleCS00
Public Class ModVBClass

    Public Enum ModVBInnerEnum
        None
        Red
        Yellow
        Blue
    End Enum

    Friend Const ConstString As String = "VB Constant String Field"

    Default Friend Property ModVBDefaultProp(ByVal index As Integer) As String
        Get
            Return "AAA"
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    Public ReadOnly Property ModVBProp As NS.Module.ModStruct
        Get
            Return New NS.Module.ModStruct()
        End Get
    End Property

    Public Sub BCSub01(ByVal em As ModEnum, Optional ByVal cls As NS.Module.ModClass = Nothing)
        Dim local As ModIBase = cls.CM()
    End Sub

    Public Function BCFunc02(ByRef del As ModDele) As Action
        Return Nothing
    End Function

End Class


Public Structure ModVBStruct

    Public Structure ModVBInnerStruct
        Public Interface ModVBInnerIFoo

        End Interface
    End Structure

    Public Shared ArrayField(9, 9) As ModVBInnerStruct

    Public Delegate Sub ModVBDele(ByVal o As Object, ByVal e As EventArgs)
    Public Event AnEvent As ModVBDele

    Sub EventHandler1(ByVal o As Object, ByVal e As EventArgs)
    End Sub

    Public Function BSFunc01(ByRef p As ModVBInnerStruct) As Object
        AddHandler AnEvent, AddressOf Me.EventHandler1
        Return Nothing
    End Function

End Structure
