'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:N.N.NNNNN.N
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System

Namespace TestOutput
Public Class DesignTime
Private Shared __o As Object

#ExternalSource("DesignTime.vbhtml", 9)
Public Shared Function Foo() As Template

#End ExternalSource
Return New Template(Sub (__razor_helper_writer)

#ExternalSource("DesignTime.vbhtml", 10)
             
    If True Then
        

#End ExternalSource

#ExternalSource("DesignTime.vbhtml", 11)
                   
    End If


#End ExternalSource
End Sub)
End Function

Public Sub New()
MyBase.New
End Sub
Public Overrides Sub Execute()

#ExternalSource("DesignTime.vbhtml",1)
            For i = 1 to 10


#End ExternalSource

#ExternalSource("DesignTime.vbhtml",2)
             __o = i


#End ExternalSource

#ExternalSource("DesignTime.vbhtml",3)
                        
            Next


#End ExternalSource

#ExternalSource("DesignTime.vbhtml",4)
__o = Foo(Bar.Baz)


#End ExternalSource

#ExternalSource("DesignTime.vbhtml",5)
__o = Foo(Function (item) New Template(Sub (__razor_template_writer)


#End ExternalSource

#ExternalSource("DesignTime.vbhtml",6)
         __o = baz


#End ExternalSource

#ExternalSource("DesignTime.vbhtml",7)
                  End Sub))


#End ExternalSource
DefineSection("Footer", Sub ()


#ExternalSource("DesignTime.vbhtml",8)
__o = bar


#End ExternalSource
End Sub)

End Sub
End Class
End Namespace
