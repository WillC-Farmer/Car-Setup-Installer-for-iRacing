Imports System.ComponentModel
Imports System.IO
Imports System.Xml
Imports System.IO.Compression

Public Class Form1
    Dim SelectedFile As String
    Dim SelectedSetupFolder As String
    Dim UsersDocFolder As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    Dim iRacingSetupFolder As String
    Dim TrackName As String
    Dim AdditonalFolderName
    ' For OVAL:
    Private carData_Enascar As New List(Of KeyValuePair(Of String, String))()
    Private carData_AsphaltOval As New List(Of KeyValuePair(Of String, String))()

    ' For ROAD:
    Private carData_Road As New List(Of KeyValuePair(Of String, String))()

    ' For DIRT OVAL:
    Private carData_DirtOval As New List(Of KeyValuePair(Of String, String))()

    ' For DIRT ROAD:
    Private carData_DirtRoad As New List(Of KeyValuePair(Of String, String))()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCarData()
        Btn_Browse.Region = New Region(New Rectangle(3, 3, Btn_Browse.Width - 6, Btn_Browse.Height - 6))
        Btn_Transfer.Region = New Region(New Rectangle(3, 3, Btn_Transfer.Width - 6, Btn_Transfer.Height - 6))
        AssignValidation(txt_TrackName, ValidationType.Only_Folder) 'makes sure u dont type invalid folder characters
        AssignValidation(txt_FolderAdditonal, ValidationType.Only_Folder)

        Cbo_CarList.SelectedItem = My.Settings.LastCarSelection
        txt_TrackName.Text = My.Settings.LastTrackFolder
        txt_FolderAdditonal.Text = My.Settings.LastAdditionalFolder
        iRacingSetupFolder = My.Settings.iRacingDefaultSetupLocation
        SelectedSetupFolder = My.Settings.LastSetupSelection

        If My.Settings.CboxState = True Then
            Cbox_OpenDestination.CheckState = CheckState.Checked
        Else
            Cbox_OpenDestination.CheckState = CheckState.Unchecked
        End If

        If My.Settings.CboxCutState = True Then
            Cbox_Cut.CheckState = CheckState.Checked
        Else
            Cbox_Cut.CheckState = CheckState.Unchecked
        End If

        'this checks if the user is using the program for the first time
        If My.Settings.IsFirstTimeUse = True Then
            MessageBox.Show("Welcome to the Car Setup Installer for iRacing.

This simple utlity allows you easily move your setups to your desired car in iRacing!

If you did not install iRacing in its default location, you must go to: 
Options > iRacing Directory 
To update your setups folder location. 

Enjoy!", "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
            My.Settings.iRacingDefaultSetupLocation = UsersDocFolder + "\" + "iRacing" + "\" + "Setups"
            My.Settings.IsFirstTimeUse = False
            My.Settings.Save()
        End If

        cBox_Oval.Checked = My.Settings.cbox_Oval
        cbox_Road.Checked = My.Settings.cbox_Road
        cbox_DirtOval.Checked = My.Settings.cbox_DirtOval
        cbox_DirtRoad.Checked = My.Settings.Cbox_DirtRoad
    End Sub
    Public Sub DefaultFolderSelection()
        FolderBrowserDialog1.Description = "Please Select your iRacing Setups Folder. 
Do not select an individual car folder.
By default, this located is: Documents > iRacing > Setups"

        If FolderBrowserDialog1.ShowDialog + Windows.Forms.DialogResult.OK Then
            iRacingSetupFolder = FolderBrowserDialog1.SelectedPath
            My.Settings.iRacingDefaultSetupLocation = iRacingSetupFolder
            My.Settings.Save()
        End If
    End Sub
    Private Sub ModifyDefaultFolderLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyDefaultFolderLocationToolStripMenuItem.Click
        DefaultFolderSelection()
    End Sub
    'Loads data from CarSelection.ini Format in file should be- [Class Name:FolderName]
    Private Sub LoadCarData()
        ' 1) Clear old data
        carData_Enascar.Clear()
        carData_AsphaltOval.Clear()
        carData_Road.Clear()
        carData_DirtOval.Clear()
        carData_DirtRoad.Clear()

        Dim filePath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Car Setup Installer for iRacing\" & "Configuration", "CarSelection.ini")
        If Not File.Exists(filePath) Then
            MessageBox.Show("CarSelection.ini not found!")
            Return
        End If

        Dim lines As String() = File.ReadAllLines(filePath)
        Dim currentSection As String = ""

        For Each line As String In lines
            line = line.Trim()
            If String.IsNullOrEmpty(line) Then Continue For

            ' Check if this line is a section header, e.g. "--eNASCAR--"
            If line.StartsWith("--") AndAlso line.EndsWith("--") Then
                ' Convert something like "--eNASCAR--" => "enascar"
                currentSection = line.Replace("-", "").Trim().ToLower()
                Continue For
            End If

            ' Parse "Car Name:Folder Name"
            Dim parts As String() = line.Split(":"c)
            If parts.Length <> 2 Then Continue For

            Dim carName As String = parts(0).Trim()
            Dim folderName As String = parts(1).Trim()

            ' Store based on section
            Select Case currentSection
                Case "enascar"
                    carData_Enascar.Add(New KeyValuePair(Of String, String)(carName, folderName))

                Case "asphalt oval"
                    carData_AsphaltOval.Add(New KeyValuePair(Of String, String)(carName, folderName))

                Case "road"
                    carData_Road.Add(New KeyValuePair(Of String, String)(carName, folderName))

                Case "dirt oval"
                    carData_DirtOval.Add(New KeyValuePair(Of String, String)(carName, folderName))

                Case "dirt road"
                    carData_DirtRoad.Add(New KeyValuePair(Of String, String)(carName, folderName))

                Case Else
                    ' If you have other sections or lines not recognized, ignore or handle them
            End Select
        Next
    End Sub

    Private Sub LoadSelectedCarList()
        Cbo_CarList.Items.Clear()

        If cBox_Oval.Checked Then
            ' 1) eNASCAR
            If carData_Enascar.Count > 0 Then
                Cbo_CarList.Items.Add("--eNASCAR--")
                For Each pair In carData_Enascar
                    Cbo_CarList.Items.Add(pair.Key)  ' Just car name
                Next
            End If

            ' 2) Asphalt Oval
            If carData_AsphaltOval.Count > 0 Then
                Cbo_CarList.Items.Add("--Asphalt Oval--")
                For Each pair In carData_AsphaltOval
                    Cbo_CarList.Items.Add(pair.Key)
                Next
            End If

        ElseIf cbox_Road.Checked Then
            ' Road
            For Each pair In carData_Road
                Cbo_CarList.Items.Add(pair.Key)
            Next

        ElseIf cbox_DirtOval.Checked Then
            ' Dirt Oval
            For Each pair In carData_DirtOval
                Cbo_CarList.Items.Add(pair.Key)
            Next

        ElseIf cbox_DirtRoad.Checked Then
            ' Dirt Road
            For Each pair In carData_DirtRoad
                Cbo_CarList.Items.Add(pair.Key)
            Next
        End If
    End Sub

    Private Sub Btn_Browse_Click(sender As Object, e As EventArgs) Handles Btn_Browse.Click
        iRacingSetupFolder = My.Settings.iRacingDefaultSetupLocation
        If iRacingSetupFolder = "" Then
            MessageBox.Show("Please Select your iRacing Setups Folder. 
This is the folder named Setups. Do not select an individual car folder.

By Default, your iRacing Setups file should be: 

C:\Users\[USERNAME]\Documents\iRacing\Setups", "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
            If DialogResult.OK Then
                DefaultFolderSelection()
            End If

            Exit Sub 'dont let them continue since they had no folder
        End If
        If OpenFileDialog1.ShowDialog + Windows.Forms.DialogResult.OK Then
            txt_BrowseResult.Clear()
            Dim filePaths As String() = OpenFileDialog1.FileNames
            ' Combine all file paths into a single string, separated by a new line
            For Each filePath In filePaths
                txt_BrowseResult.AppendText(filePath & vbCrLf)
            Next
            SelectedFile = OpenFileDialog1.SafeFileName
        End If
    End Sub
    Private Sub cbox_Oval_CheckedChanged(sender As Object, e As EventArgs) Handles cBox_Oval.CheckedChanged
        If cBox_Oval.Checked Then
            cbox_Road.Checked = False
            cbox_DirtOval.Checked = False
            cbox_DirtRoad.Checked = False
            LoadSelectedCarList()
            My.Settings.cbox_Oval = True
            My.Settings.cbox_Road = False
            My.Settings.cbox_DirtOval = False
            My.Settings.Cbox_DirtRoad = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub cbox_Road_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_Road.CheckedChanged
        If cbox_Road.Checked Then
            cBox_Oval.Checked = False
            cbox_DirtOval.Checked = False
            cbox_DirtRoad.Checked = False
            LoadSelectedCarList()
            My.Settings.cbox_Oval = False
            My.Settings.cbox_Road = True
            My.Settings.cbox_DirtOval = False
            My.Settings.Cbox_DirtRoad = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub cbox_DirtOval_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_DirtOval.CheckedChanged
        If cbox_DirtOval.Checked Then
            cBox_Oval.Checked = False
            cbox_Road.Checked = False
            cbox_DirtRoad.Checked = False
            LoadSelectedCarList()
            My.Settings.cbox_Oval = False
            My.Settings.cbox_Road = False
            My.Settings.cbox_DirtOval = True
            My.Settings.Cbox_DirtRoad = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub cbox_DirtRoad_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_DirtRoad.CheckedChanged
        If cbox_DirtRoad.Checked Then
            cBox_Oval.Checked = False
            cbox_Road.Checked = False
            cbox_DirtOval.Checked = False
            LoadSelectedCarList()
            My.Settings.cbox_Oval = False
            My.Settings.cbox_Road = False
            My.Settings.cbox_DirtOval = False
            My.Settings.Cbox_DirtRoad = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub cbo_CarList_SelectionChangeCommitted(sender As Object, e As EventArgs) _
    Handles Cbo_CarList.SelectionChangeCommitted

        Dim selectedItemText As String = Cbo_CarList.SelectedItem.ToString()

        ' If user selected a "header," ignore it
        If selectedItemText.StartsWith("--") Then
            SelectedSetupFolder = ""  ' or Nothing
            Return
        End If

        ' Otherwise find the matching folder
        If cBox_Oval.Checked Then
            ' 1) Check eNASCAR
            Dim found = carData_Enascar.FirstOrDefault(Function(p) p.Key = selectedItemText)
            If Not String.IsNullOrEmpty(found.Key) Then
                SelectedSetupFolder = found.Value
                Return
            End If

            ' 2) Check Asphalt Oval
            found = carData_AsphaltOval.FirstOrDefault(Function(p) p.Key = selectedItemText)
            If Not String.IsNullOrEmpty(found.Key) Then
                SelectedSetupFolder = found.Value
                Return
            End If

        ElseIf cbox_Road.Checked Then
            Dim found = carData_Road.FirstOrDefault(Function(p) p.Key = selectedItemText)
            SelectedSetupFolder = found.Value

        ElseIf cbox_DirtOval.Checked Then
            Dim found = carData_DirtOval.FirstOrDefault(Function(p) p.Key = selectedItemText)
            SelectedSetupFolder = found.Value

        ElseIf cbox_DirtRoad.Checked Then
            Dim found = carData_DirtRoad.FirstOrDefault(Function(p) p.Key = selectedItemText)
            SelectedSetupFolder = found.Value
        End If
    End Sub



    Private Sub Btn_Transfer_Click(sender As Object, e As EventArgs) Handles Btn_Transfer.Click
        ' Initial variable assignments
        AdditonalFolderName = txt_FolderAdditonal.Text
        Dim filePaths As String() = txt_BrowseResult.Lines
        Dim TrackName = txt_TrackName.Text
        Dim TransferLocation = iRacingSetupFolder + "\" + SelectedSetupFolder + "\" + TrackName + "\" + AdditonalFolderName + "\"
        Dim FinalLocation_WithTrack = iRacingSetupFolder + "\" + SelectedSetupFolder + "\" + TrackName + "\"
        Dim FinalLocation_NoTrack = iRacingSetupFolder + "\" + SelectedSetupFolder + "\"
        Dim FinalLocation_All = iRacingSetupFolder + "\" + SelectedSetupFolder + "\" + TrackName + "\" + AdditonalFolderName + "\"

        ' Perform initial checks
        If String.IsNullOrEmpty(SelectedFile) Then
            MessageBox.Show("Please select a setup file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        ElseIf String.IsNullOrEmpty(SelectedSetupFolder) Then
            MessageBox.Show("Please select the car that you would like to set up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        ElseIf String.IsNullOrEmpty(iRacingSetupFolder) Then
            MessageBox.Show("Please select your iRacing Setups Folder. 

This can be found in the toolbar under Options > iRacing Directory. 
By Default, your iRacing Setups file should be: 

C:\Users\[USERNAME]\Documents\iRacing\Setups", "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
            Return
        ElseIf String.IsNullOrEmpty(TrackName) And Not String.IsNullOrEmpty(AdditonalFolderName) Then
            MessageBox.Show("Please Enter a Track Name. Can not create an additonal folder outside a track folder.

Note: If you want to make an additonal folder inside your setups folder, but outside outside a track folder..

Simply name your track folder with the name of the additonal folder you're trying to create, and leave the additional folder box empty ", "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Return
        End If

        ' Determine the destination based on the input fields
        Dim destination As String = DetermineDestination(TrackName, AdditonalFolderName, FinalLocation_WithTrack, FinalLocation_NoTrack, FinalLocation_All)

        ' Move or copy files based on the checkbox state
        If Cbox_Cut.Checked Then
            MoveMultipleFiles(filePaths, destination)
        Else
            CopyMultipleFiles(filePaths, destination)
        End If

        ' Opening the destination folder
        If Cbox_OpenDestination.Checked Then
            Process.Start("explorer.exe", destination)
        End If

        ' Save settings
        SaveSettings(TrackName, AdditonalFolderName)
    End Sub

    Private Function DetermineDestination(trackName As String, additionalFolderName As String, locationWithTrack As String, locationNoTrack As String, locationAll As String) As String
        If String.IsNullOrEmpty(trackName) And String.IsNullOrEmpty(additionalFolderName) Then
            Return locationNoTrack
        ElseIf Not String.IsNullOrEmpty(trackName) And String.IsNullOrEmpty(additionalFolderName) Then
            Return locationWithTrack
        Else
            Return locationAll
        End If
    End Function

    Private Sub MoveMultipleFiles(sourcePaths As String(), destinationFolder As String)
        For Each sourcePath In sourcePaths
            If String.IsNullOrWhiteSpace(sourcePath) Then Continue For

            Dim fileName As String = Path.GetFileName(sourcePath)
            Dim fileExtension As String = Path.GetExtension(fileName).ToLower()
            Dim destinationPath As String = Path.Combine(destinationFolder, fileName)

            ' -- Create the destination folder upfront if not existing --
            If Not Directory.Exists(destinationFolder) Then
                Directory.CreateDirectory(destinationFolder)
            End If

            If fileExtension = ".zip" Then
                ' --- 1) Create a random temp folder for extraction ---
                Dim tempFolderPath As String = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName())
                Directory.CreateDirectory(tempFolderPath)

                Try
                    ' --- 2) Extract the ZIP entries, creating subfolders as needed ---
                    Using archive As ZipArchive = ZipFile.OpenRead(sourcePath)
                        For Each entry As ZipArchiveEntry In archive.Entries
                            ' Some entries might be directories if entry.Name is empty
                            If String.IsNullOrEmpty(entry.Name) Then Continue For

                            ' Convert entry.FullName’s slashes to the OS-specific separator.
                            Dim combinedPath As String = Path.Combine(tempFolderPath, entry.FullName.Replace("/"c, Path.DirectorySeparatorChar))

                            ' Ensure directory exists if the ZIP entry has subdirectories
                            Dim dirName As String = Path.GetDirectoryName(combinedPath)
                            If Not Directory.Exists(dirName) Then
                                Directory.CreateDirectory(dirName)
                            End If

                            ' Extract the file (overwrite := True in case the same file name appears more than once)
                            entry.ExtractToFile(combinedPath, True)
                        Next
                    End Using

                    ' --- 3) Now move only .sto files from temp to final destination ---
                    Dim allExtractedFiles As String() =
                    Directory.GetFiles(tempFolderPath, "*.*", SearchOption.AllDirectories)

                    For Each extractedFile In allExtractedFiles
                        Dim unZippedFileName As String = Path.GetFileName(extractedFile)
                        Dim extractedFileExtension As String = Path.GetExtension(unZippedFileName).ToLower()
                        Dim extractedDestinationPath As String = Path.Combine(destinationFolder, unZippedFileName)

                        If extractedFileExtension = ".sto" Then
                            Try
                                ' Move the .sto file
                                My.Computer.FileSystem.MoveFile(
                                extractedFile,
                                extractedDestinationPath,
                                showUI:=FileIO.UIOption.AllDialogs
                            )
                            Catch ex As Exception
                                MessageBox.Show("Error moving file: " & extractedFile & vbCrLf & ex.Message)
                            End Try
                        End If
                    Next
                Catch ex As Exception
                    MessageBox.Show("Error extracting ZIP file: " & ex.Message,
                                "Extraction Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                Finally
                    ' --- 4) Cleanup the temp folder ---
                    Try
                        If Directory.Exists(tempFolderPath) Then
                            Directory.Delete(tempFolderPath, True)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error deleting temporary folder: " & ex.Message)
                    End Try
                End Try

                ' --- 5) Optionally remove the original ZIP (if you no longer want it) ---
                Try
                    File.Delete(sourcePath)
                Catch ex As Exception
                    MessageBox.Show("Error deleting original ZIP file: " & ex.Message)
                End Try

            Else
                ' --- If not a .zip, just move the file as before ---
                Try
                    My.Computer.FileSystem.MoveFile(
                    sourcePath,
                    destinationPath,
                    showUI:=FileIO.UIOption.AllDialogs
                )
                Catch ex As Exception
                    MessageBox.Show("Error moving file: " & sourcePath & vbCrLf & ex.Message)
                End Try
            End If
        Next
    End Sub
    Private Sub CopyMultipleFiles(sourcePaths As String(), destinationFolder As String)
        For Each sourcePath In sourcePaths
            If String.IsNullOrWhiteSpace(sourcePath) Then Continue For

            Dim fileName As String = Path.GetFileName(sourcePath)
            Dim fileExtension As String = Path.GetExtension(fileName).ToLower()
            Dim destinationPath As String = Path.Combine(destinationFolder, fileName)

            ' -- Create the destination folder upfront if not existing --
            If Not Directory.Exists(destinationFolder) Then
                Directory.CreateDirectory(destinationFolder)
            End If

            If fileExtension = ".zip" Then
                ' --- 1) Create a random temp folder for extraction ---
                Dim tempFolderPath As String = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName())
                Directory.CreateDirectory(tempFolderPath)

                Try
                    ' --- 2) Extract the ZIP entries, creating subfolders as needed ---
                    Using archive As ZipArchive = ZipFile.OpenRead(sourcePath)
                        For Each entry As ZipArchiveEntry In archive.Entries
                            ' Some entries might be directories if entry.Name is empty
                            If String.IsNullOrEmpty(entry.Name) Then Continue For

                            ' Convert entry.FullName’s internal slashes to the OS-specific separator.
                            Dim combinedPath As String = Path.Combine(tempFolderPath, entry.FullName.Replace("/"c, Path.DirectorySeparatorChar))

                            ' Ensure directory exists if the ZIP entry has subdirectories
                            Dim dirName As String = Path.GetDirectoryName(combinedPath)
                            If Not Directory.Exists(dirName) Then
                                Directory.CreateDirectory(dirName)
                            End If

                            ' Extract the file (overwrite := True in case the same file name appears more than once)
                            entry.ExtractToFile(combinedPath, True)
                        Next
                    End Using

                    ' --- 3) Now copy only .sto files from temp to final destination ---
                    Dim allExtractedFiles As String() =
                    Directory.GetFiles(tempFolderPath, "*.*", SearchOption.AllDirectories)

                    For Each extractedFile In allExtractedFiles
                        Dim unZippedFileName As String = Path.GetFileName(extractedFile)
                        Dim extractedFileExtension As String = Path.GetExtension(unZippedFileName).ToLower()
                        Dim extractedDestinationPath As String = Path.Combine(destinationFolder, unZippedFileName)

                        If extractedFileExtension = ".sto" Then
                            Try
                                My.Computer.FileSystem.CopyFile(
                                extractedFile,
                                extractedDestinationPath,
                                showUI:=FileIO.UIOption.AllDialogs
                            )
                            Catch ex As Exception
                                MessageBox.Show("Error copying file: " & extractedFile & vbCrLf & ex.Message)
                            End Try
                        End If
                    Next
                Catch ex As Exception
                    MessageBox.Show("Error extracting ZIP file: " & ex.Message,
                                "Extraction Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                Finally
                    ' --- 4) Cleanup the temp folder ---
                    Try
                        If Directory.Exists(tempFolderPath) Then
                            Directory.Delete(tempFolderPath, True)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error deleting temporary folder: " & ex.Message)
                    End Try
                End Try

            Else
                ' --- If not a .zip, just copy the file as before ---
                Try
                    My.Computer.FileSystem.CopyFile(
                    sourcePath,
                    destinationPath,
                    showUI:=FileIO.UIOption.AllDialogs
                )
                Catch ex As Exception
                    MessageBox.Show("Error copying file: " & sourcePath & vbCrLf & ex.Message)
                End Try
            End If
        Next
    End Sub


    Private Sub SaveSettings(trackName As String, additionalFolderName As String)
        My.Settings.LastBrowseResult = txt_BrowseResult.Text
        My.Settings.LastCarSelection = Cbo_CarList.SelectedItem.ToString()
        My.Settings.LastSetupSelection = SelectedSetupFolder
        My.Settings.LastTrackFolder = trackName
        My.Settings.LastAdditionalFolder = additionalFolderName
        My.Settings.CboxState = Cbox_OpenDestination.Checked
        My.Settings.CboxCutState = Cbox_OpenDestination.Checked
        My.Settings.Save()

        ' Clear the selected file and update the UI accordingly
        txt_BrowseResult.Text = ""
        SelectedFile = ""
    End Sub


    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("This Car Setup Installer is not created by, or affiliated with iRacing. This is a 3rd party utility. 

This is a simple utility program that is designed to work with any .sto setup file. 

Regarding questions or concerns, please PM
Will C Farmer on the iRacing Fourms.

Thank you for using this program. ", "Info",
MessageBoxButtons.OK,
MessageBoxIcon.None)
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
    End Sub

    Private Sub Cbox_Cut_CheckStateChanged(sender As Object, e As EventArgs) Handles Cbox_Cut.CheckStateChanged
        If Cbox_Cut.Checked = True Then
            My.Settings.CboxCutState = True
        Else
            My.Settings.CboxCutState = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub Cbox_OpenDestination_CheckStateChanged(sender As Object, e As EventArgs) Handles Cbox_OpenDestination.CheckStateChanged
        If Cbox_OpenDestination.Checked = True Then
            My.Settings.CboxState = True
        Else
            My.Settings.CboxState = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub btn_BrowseTrack_Click(sender As Object, e As EventArgs) Handles btn_BrowseTrack.Click
        If String.IsNullOrEmpty(iRacingSetupFolder) Then
            MessageBox.Show("Please select your iRacing Setups Folder. 

This can be found in the toolbar under Options > iRacing Directory. 
By Default, your iRacing Setups file should be: 

C:\Users\[USERNAME]\Documents\iRacing\Setups", "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
            Return
        ElseIf String.IsNullOrEmpty(SelectedSetupFolder) Then
            MessageBox.Show("Please select the car that you would like to set up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim FinalLocation_NoTrack = iRacingSetupFolder + "\" + SelectedSetupFolder + "\"
        Using SelectTrack As New FolderBrowserDialog()
            SelectTrack.Description = "Please select a track folder."
            SelectTrack.SelectedPath = FinalLocation_NoTrack
            If SelectTrack.ShowDialog = DialogResult.OK Then
                txt_TrackName.Text = System.IO.Path.GetFileName(SelectTrack.SelectedPath)
            End If
        End Using
    End Sub

    Private Sub btn_BrowseAdditional_Click(sender As Object, e As EventArgs) Handles btn_BrowseAdditional.Click
        TrackName = txt_TrackName.Text
        If String.IsNullOrEmpty(iRacingSetupFolder) Then
            MessageBox.Show("Please select your iRacing Setups Folder. 

This can be found in the toolbar under Options > iRacing Directory. 
By Default, your iRacing Setups file should be: 

C:\Users\[USERNAME]\Documents\iRacing\Setups", "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
            Return
        ElseIf String.IsNullOrEmpty(SelectedSetupFolder) Then
            MessageBox.Show("Please select the car that you would like to set up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        ElseIf String.IsNullOrEmpty(TrackName) Then
            MessageBox.Show("Please Enter a Track Name.", "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Return
        End If

        Dim FinalLocation_WithTrack = iRacingSetupFolder + "\" + SelectedSetupFolder + "\" + TrackName + "\"
        TrackName = txt_TrackName.Text
        Using SelectAdditonal As New FolderBrowserDialog()
            SelectAdditonal.Description = "Please select an additonal folder."
            SelectAdditonal.SelectedPath = FinalLocation_WithTrack
            If SelectAdditonal.ShowDialog = DialogResult.OK Then
                txt_FolderAdditonal.Text = System.IO.Path.GetFileName(SelectAdditonal.SelectedPath)
            End If
        End Using
    End Sub
End Class

