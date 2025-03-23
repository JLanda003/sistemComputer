Imports System.IO
Imports System.Text.Json
Imports CRUDJLanda.Lang

Module LangModule

    Function LangLogin(ByVal idioma As String) As Lang.Login
        Dim json As String = File.ReadAllText("../../../src/lang/lang.json")
        Dim langData As Dictionary(Of String, LanguageData) = JsonSerializer.Deserialize(Of Dictionary(Of String, LanguageData))(json)

        If langData.ContainsKey(idioma) Then
            Return langData(idioma).login
        Else
            Return Nothing
        End If
    End Function

End Module
