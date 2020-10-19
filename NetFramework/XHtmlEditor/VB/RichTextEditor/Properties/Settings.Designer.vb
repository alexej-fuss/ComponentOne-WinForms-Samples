﻿Option Strict On
Option Explicit On
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports RichTextEditor.RichTextEditor

<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0"),
 Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
Partial Friend NotInheritable Class Settings
    Inherits Global.System.Configuration.ApplicationSettingsBase

    Private Shared defaultInstance As Settings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings)

#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region

    Public Shared ReadOnly Property [Default]() As Settings
        Get

#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
            Return defaultInstance
        End Get
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Configuration.DefaultSettingValueAttribute("False")>
    Public Property QatBelowRibbon() As Boolean
        Get
            Return CType(Me("QatBelowRibbon"), Boolean)
        End Get
        Set
            Me("QatBelowRibbon") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Configuration.DefaultSettingValueAttribute("Office2007Blue")>
    Public Property VisualStyle() As Global.C1.Win.C1Ribbon.VisualStyle
        Get
            Return CType(Me("VisualStyle"), Global.C1.Win.C1Ribbon.VisualStyle)
        End Get
        Set
            Me("VisualStyle") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Property RecentDocuments() As Global.System.Collections.Specialized.StringCollection
        Get
            Return CType(Me("RecentDocuments"), Global.System.Collections.Specialized.StringCollection)
        End Get
        Set
            Me("RecentDocuments") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Configuration.DefaultSettingValueAttribute("True")>
    Public Property ShowErrors() As Boolean
        Get
            Return CType(Me("ShowErrors"), Boolean)
        End Get
        Set
            Me("ShowErrors") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Configuration.DefaultSettingValueAttribute("")>
    Public Property Dictionary() As String
        Get
            Return CType(Me("Dictionary"), String)
        End Get
        Set
            Me("Dictionary") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute()>
    <Global.System.Configuration.SettingsSerializeAs(Global.System.Configuration.SettingsSerializeAs.Binary)>
    <Global.System.Configuration.DefaultSettingValueAttribute("")>
    Public Property OpenedFiles As System.Collections.Generic.List(Of RecentDocumentItem)
        Get
            Return TryCast(Me("OpenedFiles"), System.Collections.Generic.List(Of RecentDocumentItem))
        End Get

        Set(ByVal value As System.Collections.Generic.List(Of RecentDocumentItem))
            Me("OpenedFiles") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute()>
    <Global.System.Configuration.SettingsSerializeAs(Global.System.Configuration.SettingsSerializeAs.Binary)>
    <Global.System.Configuration.DefaultSettingValueAttribute("")>
    Public Property SavedFiles As System.Collections.Generic.List(Of RecentDocumentItem)
        Get
            Return TryCast(Me("SavedFiles"), System.Collections.Generic.List(Of RecentDocumentItem))
        End Get

        Set(ByVal value As System.Collections.Generic.List(Of RecentDocumentItem))
            Me("SavedFiles") = value
        End Set
    End Property

End Class

Namespace My

    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    Friend Module MySettingsProperty

        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>
        Friend ReadOnly Property Settings() As Global.RichTextEditor.Settings
            Get
                Return Global.RichTextEditor.Settings.Default
            End Get
        End Property
    End Module
End Namespace