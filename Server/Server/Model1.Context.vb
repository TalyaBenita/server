'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class SENDIT1Entities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=SENDIT1Entities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property CUSTOMER() As DbSet(Of CUSTOMER)
    Public Overridable Property DELIVERY() As DbSet(Of DELIVERY)
    Public Overridable Property ORDER() As DbSet(Of ORDER)
    Public Overridable Property PACKAGE() As DbSet(Of PACKAGE)
    Public Overridable Property ROUTE() As DbSet(Of ROUTE)
    Public Overridable Property USER() As DbSet(Of USER)

End Class
