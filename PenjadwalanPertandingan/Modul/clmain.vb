Imports clMainLib.General
Imports Microsoft.VisualBasic
Public Class clMain
    Public Shared cUserLogIn As String = ""
    Public Shared cGustu As String = ""
    Public Shared cIDApps As String = ""
    Public Shared cHostName As String = ""
    Public Shared dtDateTime As DateTime
    Public Shared cwh As String = ""
    Public Shared dRpBatas As Double = 0

    Public Shared cIDModul As String = ""
    Public Shared cNamaServer As String = ""
    Public Shared cNamaDatabase As String = ""
    Public Shared cNamaUser As String = ""
    Public Shared cPassUser As String = ""
    Public Shared dtAccess As DataTable

    Public Shared cHeaderMsg As String = ""
    Public Shared nUserLevel As Integer = 0
    Public Shared cstatus As String
    Public Shared ckd_unit As String = ""
    Public Shared cAppsName As String = ""

    Public Shared cRSName As String = ""
    Public Shared cCopyRight As String = ""
    Public Shared cModulName As String = ""
    Public Shared cSubModulName As String = ""

    Public Shared cRegistryLoc As String = "Software\Microsoft\.NETApps"
    Public Shared cRegKeyGroups As String = "groups"
    Public Shared clUtama As New clsGeneral
    Public Shared clTanggal As New clsGeneral
    Public Shared cLTglkode As New clsGeneral
    Public Shared alamat_rs, nm_rs, tlpn_rs, kota_rs, kdpos, fax As String
End Class
