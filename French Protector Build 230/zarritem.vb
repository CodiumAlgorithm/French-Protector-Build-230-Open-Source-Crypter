Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices
Imports Microsoft.CSharp
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Zarrme
	' Token: 0x0200000F RID: 15
	Public Class Varrme
		' Token: 0x06000079 RID: 121 RVA: 0x00004008 File Offset: 0x00002208
		Public Shared Sub build(Path As String, Code As String, MainClass As String)
			Dim csharpCodeProvider As CSharpCodeProvider = New CSharpCodeProvider(New Dictionary(Of String, String)() From {{"CompilerVersion", "v4.0"}})
			Dim compilerParameters As CompilerParameters = New CompilerParameters()
			Dim compilerParameters2 As CompilerParameters = compilerParameters
			compilerParameters2.GenerateExecutable = True
			compilerParameters2.OutputAssembly = Path
			Dim compilerParameters3 As CompilerParameters = compilerParameters2
			Dim compilerParameters4 As CompilerParameters = compilerParameters3
			compilerParameters3.CompilerOptions = compilerParameters4.CompilerOptions + "/platform:X86 /target:winexe"
			compilerParameters2.MainClass = MainClass
			compilerParameters2.IncludeDebugInformation = True
			compilerParameters2.ReferencedAssemblies.Add("System.Core.dll")
			compilerParameters2.ReferencedAssemblies.Add("System.Data.dll")
			compilerParameters2.ReferencedAssemblies.Add("System.Data.DataSetExtensions.dll")
			compilerParameters2.ReferencedAssemblies.Add("System.Deployment.dll")
			compilerParameters2.ReferencedAssemblies.Add("Microsoft.CSharp.dll")
			compilerParameters2.ReferencedAssemblies.Add("System.dll")
			compilerParameters2.ReferencedAssemblies.Add("System.Windows.Forms.dll")
			compilerParameters2.ReferencedAssemblies.Add("System.Drawing.dll")
			Dim compilerResults As CompilerResults = csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, New String() {Code})
			If compilerResults.Errors.Count > 0 Then
				Try
					For Each obj As Object In compilerResults.Errors
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
						Interaction.MsgBox(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, Nothing, "ErrorText", New Object(-1) {}, Nothing, Nothing, Nothing)), MsgBoxStyle.OkOnly, Nothing)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x0600007A RID: 122 RVA: 0x00002305 File Offset: 0x00000505
		Friend Shared Sub m11WrQjSbQd1BM1A6sW()
		End Sub

		' Token: 0x0600007B RID: 123 RVA: 0x000025DA File Offset: 0x000007DA

	End Class
End Namespace
