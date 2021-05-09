Dim totalcount
Dim subcount

Dim loopcount

Set FileSysObj = CreateObject("Scripting.FileSystemObject")

Set oFolder = FileSysObj.GetFolder(".")
dim underscorecount
underscorecount = 0
MsgBox "removing underscore names from " & oFolder.Name
For Each file In oFolder.Files
    shortname = Left(file.Name, Len(file.Name) - 4)
    ext = LCase(FileSysObj.GetExtensionName(file.Name))
    x = x + 1

    If x > 1000 Then
        MsgBox x
        Exit For
    End If
    If ext = "mp3" Then
        If Mid(shortname, Len(shortname) - 1, 1) = "_" Then
'        MsgBox shortname
        shortname = Left(shortname, Len(shortname) - 2)
        randomize
myValue = int((9999 * rnd) + 1)
mystring = "0000" & cstr(myValue)
mystring = right(mystring,4) & "[-]"
        newFileName = trim(mystring & shortname & "." & ext)
        if lcase(newFileName) <> lcase(file.Name) then file.Name = trim(newFileName)
		underscorecount = underscorecount + 1
    End If
    
    If Err.Number <> 0 Then MsgBox "can't rename " & file.Name
    On Error Resume Next
    End If
Next

msgbox "Done removing underscores." & cstr(underscorecount) & " files were renamed.  Now removing random numbers and adding new underscores."
'Do
'    loopcount = loopcount + 1
'    totalcount = totalcount + subcount
'    subcount = 0
    renFile oFolder
'Loop While subcount > 0 And loopcount < 1000

MsgBox "Renamed " & CStr(totalcount) & " files"


Sub renFile(oFolder)

Set colFiles = oFolder.Files
For Each file In colFiles
	On Error Resume Next

	If LCase(FileSysObj.GetExtensionName(file.Name)) = "mp3" Then
		baseName = left(file.Name, len(file.name)-4)
		OriginalName = file.Name
		ext = ".mp3"
		delim = instr(1,baseName,"[-]")
		if delim > 0 then
			baseName = trim(mid(baseName,delim + 6))
		end if
'		delim = instr(1, baseName, " - ")
'		if delim > 0 then
'			baseName = mid(baseName, delim + 3)
'		end if
		
		On Error Resume Next
		newFileName = trim(baseName + ext)
        if lcase(newFileName) <> lcase(file.Name) then file.Name = trim(newFileName)
		If Err.Number = 58 Then
			Dim x
			Dim newName
			Dim oldName
			oldName = baseName

			x = 1
			newName = oldName & "_"
			Do
				x = x + 1
				On Error Resume Next
				newFileName = trim(newName & CStr(x) & ext)
		        if lcase(newFileName) <> lcase(file.Name) then file.Name = trim(newFileName)
			Loop While (Err.Number = 58) And (x < 1000)
		End If
		If Err.Number = 0 and originalFilaName <> file.Name Then subcount = subcount + 1
	End If

	On Error GoTo 0
Next
For Each oSubFolder In oFolder.Subfolders
'renFile oSubFolder
Next

End Sub

