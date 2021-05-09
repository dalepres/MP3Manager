Dim totalcount
Dim subcount

Dim loopcount

Set FileSysObj = CreateObject("Scripting.FileSystemObject")

Set oFolder = FileSysObj.GetFolder(".")
dim underscorecount
underscorecount = 0
MsgBox "removing track numbers from " & oFolder.Name
on error resume next
For Each file In oFolder.Files
	trackNum = left(file.name,2)
	if isnumeric(tracknum) then
		file.name = trim(mid(file.name,3))
	end if
Next