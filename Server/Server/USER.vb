'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class USER
    Public Property ID As Integer
    Public Property ROUTE_ID As Nullable(Of Integer)
    Public Property USERNAME As String
    Public Property USER_PASSWORD As String
    Public Property NAME As String
    Public Property ADRESS As String
    Public Property PHONE As String
    Public Property EMAIL As String

    Public Overridable Property CUSTOMER As ICollection(Of CUSTOMER) = New HashSet(Of CUSTOMER)
    Public Overridable Property ROUTE As ROUTE

End Class
