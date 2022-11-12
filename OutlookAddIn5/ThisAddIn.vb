Imports System.IO
Public Class GlobalVariables
    Public Shared FILEFOLDER As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\ConfigFiles"
    Public Shared FILEPATH As String = FILEFOLDER & "\Recipients.txt"
End Class
Public Class ThisAddIn

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        'MsgBox("Welcome")
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

    Private Sub Application_ItemSend(Item As Object, ByRef Cancel As Boolean) Handles Application.ItemSend
        Dim recips As Outlook.Recipients
        Dim recip As Outlook.Recipient
        Dim pa As Outlook.PropertyAccessor
        Dim prompt As String
        'Dim strMsg As String
        Dim Address As String
        Dim lLen
        'Dim arr
        Dim strMyDomain
        'Dim userAddress
        Dim pjdomains() As String
        Dim str1 As String
        Dim recipientarray() As String
        'Dim firstpass As Boolean
        Dim extrecipientcount As Integer
        Dim configfileexist As Boolean
        Dim Reconfirm As Boolean
        'Dim projectdomains As Object
        Dim externalrecipients As Boolean
        Dim temptemp As Boolean
        'Dim FILEFOLDER As String
        'Dim FILEPATH As String

        'Const FILEFOLDER = "C:\Users\Gabriel\Documents\ConfigFiles"
        'Const FILEPATH = "C:\Users\Gabriel\Documents\ConfigFiles\Recipients.txt"

        Dim jdomains() As String
        'UserForm1.Tag = "1"
        Reconfirm = True
        Dim choice As Integer
        'Dim filepath2 As String
        'FILEFOLDER = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\ConfigFiles"
        'FILEPATH = FILEFOLDER & "\Recipients.txt"

        'Dim enviro As String
        'Dim FILEFOLDER As String
        'Dim FILEPATH As String

        'enviro = CStr(Environ("USERPROFILE"))
        'FILEFOLDER = enviro & "\Documents\OutlookAddinConfigFiles"
        'FILEPATH = FILEFOLDER & "\Recipients.txt"

        'Check for config folder existence
        'If Dir(FILEFOLDER) = "" Then
        'VBA.FileSystem.MkDir(FILEFOLDER)
        'End If

        If Item.Class <> 43 Then
            Exit Sub
        End If

        If My.Computer.FileSystem.DirectoryExists(GlobalVariables.FILEFOLDER) = False Then
            My.Computer.FileSystem.CreateDirectory(GlobalVariables.FILEFOLDER)
        End If



        Const PR_SMTP_ADDRESS As String = "http://schemas.microsoft.com/mapi/proptag/0x39FE001E"

        '        projectdomains = {
        '"bausch.com, bauschhealth.com, infosys.com, hcl.com, microsoft.com",
        '"freddiemac.com",
        '"google.com, sellercloud.com"}

        ' non-exchange
        ' userAddress = Session.CurrentUser.Address
        ' use for exchange accounts
        ' userAddress = Session.CurrentUser.AddressEntry.GetExchangeUser.PrimarySmtpAddress
        lLen = Len(Item.SenderEmailAddress) - InStrRev(Item.SenderEmailAddress, "@")
        strMyDomain = Right(Item.SenderEmailAddress, lLen)
        'MsgBox("My email" & Item.SenderEmailAddress & "  My domain" & strMyDomain)
        'read config file
        If Len(Dir(GlobalVariables.FILEPATH)) <> 0 Then
            configfileexist = True
            pjdomains = readarrayffile(GlobalVariables.FILEPATH)
            'don't know why this one
            'tempbool = savearray2file(pjdomains, FILEPATH)
        Else
            configfileexist = False
            ReDim pjdomains(0)
        End If

        'filter list of external recipients
        extrecipientcount = 0
        'firstpass = True
        ReDim Preserve recipientarray(0)
        recips = Item.Recipients
        For Each recip In recips
            pa = recip.PropertyAccessor

            Address = LCase(pa.GetProperty(PR_SMTP_ADDRESS))
            lLen = Len(Address) - InStrRev(Address, "@")
            str1 = Right(Address, lLen)
            If str1 <> strMyDomain Then
                'If firstpass = True Then
                'Resolving unallocated array issue
                'ReDim Preserve recipientarray(0)
                'recipientarray(0) = str1
                'extrecipientcount = extrecipientcount + 1
                'firstpass = False
                'Else
                recipientarray = Addnewstrarray(recipientarray, str1)
                extrecipientcount = extrecipientcount + 1
                'End If
                externalrecipients = True
            End If
        Next

        'Cycle through allowed list and recipients and decide whether to show prompt
        'avoiding issue of unallocated array
        If extrecipientcount > 1 Then
            'MsgBox ("email domains: " & Join(recipientarray, ", ") & " count " & UBound(recipientarray))
            For j = LBound(pjdomains) To UBound(pjdomains)
                jdomains = Split(pjdomains(j), ", ")
                If UBound(jdomains) <> -1 Then
                    If arraywithinarray(recipientarray, jdomains) Then
                        Reconfirm = False
                        Exit For
                    End If
                    If j = UBound(pjdomains) Then
                        Reconfirm = True
                    End If
                End If
            Next
        Else
            Reconfirm = False
        End If

Reconfirm:
        If Reconfirm = True Then
            choice = 3
            prompt = "This email is being sent to people at " & Join(recipientarray, ", ") & " Do you still wish to send?"
            Dim OBJ As New Confform
            OBJ.TextLabel = "This email is being sent to people at " & Join(recipientarray, ", ")
            OBJ.TextLabel2 = "Do you still wish to send?"
            OBJ.ShowDialog()

            choice = OBJ.selectionclicked

            'choice = MsgBox(prompt, vbAbortRetryIgnore)
            'UserForm1.Label1.Caption = prompt
            'UserForm1.Show
            If choice = 3 Then
                'MsgBox("Don't send")
                Cancel = True
                Exit Sub
            End If
            If choice = 2 Then
                'MsgBox("Send and don't ask")
                ReDim Preserve pjdomains(UBound(pjdomains) + 1)
                pjdomains(UBound(pjdomains)) = Join(recipientarray, ", ")
                temptemp = savearray2file(pjdomains, GlobalVariables.FILEPATH)
            End If
        End If
ContiLabel:
        'below to avoid spamming and for testing
        '      prompt = "SURE?? ?This email is being sent to people at " & Join(recipientarray, ", ") & " Do you still wish to send?"
        '     If MsgBox(prompt, vbYesNo + vbExclamation + vbMsgBoxSetForeground, "Check Address") = vbNo Then
        '    Cancel = True
        '    Exit Sub
        '    End If

    End Sub

    Private Function Addnewstrarray(arrayinput() As String, stringinput As String) As String()
        'adds string to array if it did not exist there before
        Dim i As Integer

        For i = LBound(arrayinput) To UBound(arrayinput)
            If Trim(arrayinput(i)) = Trim(stringinput) Then
                Exit For
            Else
                If i = UBound(arrayinput) Then
                    If arrayinput(UBound(arrayinput)) = Nothing Or arrayinput(UBound(arrayinput)) = "" Then
                        arrayinput(UBound(arrayinput)) = stringinput
                    Else
                        ReDim Preserve arrayinput(UBound(arrayinput) + 1)
                        arrayinput(UBound(arrayinput)) = stringinput
                    End If

                End If
            End If
        Next

        Addnewstrarray = arrayinput
    End Function

    Private Function arraywithinarray(arrayinput1() As String, arrayinput2() As String) As Boolean
        'finds whether string1 is contained within string2

        Dim i As Integer
        Dim j As Integer
        Dim boolflag As Boolean

        boolflag = True

        For i = LBound(arrayinput1) To UBound(arrayinput1)
            For j = LBound(arrayinput2) To UBound(arrayinput2)
                If Trim(arrayinput2(j)) = Trim(arrayinput1(i)) Then
                    Exit For
                Else
                    If j = UBound(arrayinput2) Then
                        boolflag = False
                        Exit For
                    End If
                End If
            Next
        Next
        arraywithinarray = boolflag

    End Function

    Private Function savearray2file(arrayinput() As String, fpath As String) As Boolean
        'Const FILEPATH = "C:\Users\Gabriel\Documents\ConfigFiles\Recipients.txt"
        Dim strReport As String
        Dim mystreamwriter As StreamWriter
        savearray2file = False
        mystreamwriter = New StreamWriter(fpath, False)
        strReport = ""
        'MsgBox("Writing File")

        For i = LBound(arrayinput) To UBound(arrayinput)
            strReport = strReport + arrayinput(i) + vbNewLine
        Next
        mystreamwriter.Write(strReport)
        mystreamwriter.Close()
        'Open fpath For Output As 1
        'Print #1, strReport
        'Close #1

    End Function

    Private Function readarrayffile(fpath As String) As String()
        Dim domainarray() As String
        ReDim domainarray(0) 'Not needed but careful With empty arrays below
        Dim stringvar As String
        Dim mystreamreader As StreamReader
        Dim j As Int16
        'Const FILEPATH = "C:\Users\Gabriel\Documents\ConfigFiles\Recipients.txt"
        mystreamreader = New StreamReader(fpath)

        If Len(Dir(fpath)) = 0 Then
            readarrayffile = domainarray
            Exit Function
        End If


        'Discard broken short lines with 3 or less characters
        j = 0
        Do While Not mystreamreader.EndOfStream
            stringvar = mystreamreader.ReadLine
            If Len(stringvar) > 3 Then
                ReDim Preserve domainarray(j)
                domainarray(j) = stringvar
                j = j + 1
            End If
        Loop
        mystreamreader.Close()

        readarrayffile = domainarray
    End Function



End Class
