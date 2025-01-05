<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRacingDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyDefaultFolderLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_BrowseAdditional = New System.Windows.Forms.Button()
        Me.btn_BrowseTrack = New System.Windows.Forms.Button()
        Me.Cbox_Cut = New System.Windows.Forms.CheckBox()
        Me.Cbox_OpenDestination = New System.Windows.Forms.CheckBox()
        Me.Btn_Transfer = New System.Windows.Forms.Button()
        Me.txt_FolderAdditonal = New System.Windows.Forms.TextBox()
        Me.txt_TrackName = New System.Windows.Forms.TextBox()
        Me.Btn_Browse = New System.Windows.Forms.Button()
        Me.Cbo_CarList = New System.Windows.Forms.ComboBox()
        Me.txt_BrowseResult = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cBox_Oval = New System.Windows.Forms.CheckBox()
        Me.cbox_Road = New System.Windows.Forms.CheckBox()
        Me.cbox_DirtOval = New System.Windows.Forms.CheckBox()
        Me.cbox_DirtRoad = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(767, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IRacingDirectoryToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'IRacingDirectoryToolStripMenuItem
        '
        Me.IRacingDirectoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifyDefaultFolderLocationToolStripMenuItem})
        Me.IRacingDirectoryToolStripMenuItem.Name = "IRacingDirectoryToolStripMenuItem"
        Me.IRacingDirectoryToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.IRacingDirectoryToolStripMenuItem.Text = "iRacing Directory"
        '
        'ModifyDefaultFolderLocationToolStripMenuItem
        '
        Me.ModifyDefaultFolderLocationToolStripMenuItem.Name = "ModifyDefaultFolderLocationToolStripMenuItem"
        Me.ModifyDefaultFolderLocationToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ModifyDefaultFolderLocationToolStripMenuItem.Text = "Modify Default Folder Location"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.HelpToolStripMenuItem.Text = "Info"
        '
        'btn_BrowseAdditional
        '
        Me.btn_BrowseAdditional.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_BrowseAdditional.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_BrowseAdditional.FlatAppearance.BorderSize = 2
        Me.btn_BrowseAdditional.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BrowseAdditional.Location = New System.Drawing.Point(615, 370)
        Me.btn_BrowseAdditional.Name = "btn_BrowseAdditional"
        Me.btn_BrowseAdditional.Size = New System.Drawing.Size(100, 31)
        Me.btn_BrowseAdditional.TabIndex = 32
        Me.btn_BrowseAdditional.Text = "Browse.."
        Me.btn_BrowseAdditional.UseVisualStyleBackColor = False
        '
        'btn_BrowseTrack
        '
        Me.btn_BrowseTrack.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_BrowseTrack.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_BrowseTrack.FlatAppearance.BorderSize = 2
        Me.btn_BrowseTrack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BrowseTrack.Location = New System.Drawing.Point(615, 301)
        Me.btn_BrowseTrack.Name = "btn_BrowseTrack"
        Me.btn_BrowseTrack.Size = New System.Drawing.Size(100, 31)
        Me.btn_BrowseTrack.TabIndex = 31
        Me.btn_BrowseTrack.Text = "Browse.."
        Me.btn_BrowseTrack.UseVisualStyleBackColor = False
        '
        'Cbox_Cut
        '
        Me.Cbox_Cut.AutoSize = True
        Me.Cbox_Cut.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbox_Cut.Location = New System.Drawing.Point(289, 466)
        Me.Cbox_Cut.Name = "Cbox_Cut"
        Me.Cbox_Cut.Size = New System.Drawing.Size(403, 25)
        Me.Cbox_Cut.TabIndex = 30
        Me.Cbox_Cut.Text = "Remove File From Original Location When Completed"
        Me.Cbox_Cut.UseVisualStyleBackColor = True
        '
        'Cbox_OpenDestination
        '
        Me.Cbox_OpenDestination.AutoSize = True
        Me.Cbox_OpenDestination.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbox_OpenDestination.Location = New System.Drawing.Point(329, 435)
        Me.Cbox_OpenDestination.Name = "Cbox_OpenDestination"
        Me.Cbox_OpenDestination.Size = New System.Drawing.Size(343, 25)
        Me.Cbox_OpenDestination.TabIndex = 29
        Me.Cbox_OpenDestination.Text = "Open File Transfer Location When Completed"
        Me.Cbox_OpenDestination.UseVisualStyleBackColor = True
        '
        'Btn_Transfer
        '
        Me.Btn_Transfer.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Transfer.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btn_Transfer.FlatAppearance.BorderSize = 2
        Me.Btn_Transfer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Transfer.Location = New System.Drawing.Point(82, 449)
        Me.Btn_Transfer.Name = "Btn_Transfer"
        Me.Btn_Transfer.Size = New System.Drawing.Size(103, 39)
        Me.Btn_Transfer.TabIndex = 28
        Me.Btn_Transfer.Text = "Transfer"
        Me.Btn_Transfer.UseVisualStyleBackColor = False
        '
        'txt_FolderAdditonal
        '
        Me.txt_FolderAdditonal.BackColor = System.Drawing.SystemColors.Window
        Me.txt_FolderAdditonal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_FolderAdditonal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FolderAdditonal.Location = New System.Drawing.Point(82, 375)
        Me.txt_FolderAdditonal.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_FolderAdditonal.Name = "txt_FolderAdditonal"
        Me.txt_FolderAdditonal.Size = New System.Drawing.Size(526, 22)
        Me.txt_FolderAdditonal.TabIndex = 27
        '
        'txt_TrackName
        '
        Me.txt_TrackName.BackColor = System.Drawing.SystemColors.Window
        Me.txt_TrackName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_TrackName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TrackName.Location = New System.Drawing.Point(82, 306)
        Me.txt_TrackName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_TrackName.Name = "txt_TrackName"
        Me.txt_TrackName.Size = New System.Drawing.Size(526, 22)
        Me.txt_TrackName.TabIndex = 26
        '
        'Btn_Browse
        '
        Me.Btn_Browse.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Browse.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btn_Browse.FlatAppearance.BorderSize = 2
        Me.Btn_Browse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Browse.Location = New System.Drawing.Point(615, 75)
        Me.Btn_Browse.Name = "Btn_Browse"
        Me.Btn_Browse.Size = New System.Drawing.Size(100, 31)
        Me.Btn_Browse.TabIndex = 25
        Me.Btn_Browse.Text = "Browse.."
        Me.Btn_Browse.UseVisualStyleBackColor = False
        '
        'Cbo_CarList
        '
        Me.Cbo_CarList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_CarList.FormattingEnabled = True
        Me.Cbo_CarList.Location = New System.Drawing.Point(82, 228)
        Me.Cbo_CarList.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbo_CarList.Name = "Cbo_CarList"
        Me.Cbo_CarList.Size = New System.Drawing.Size(526, 29)
        Me.Cbo_CarList.TabIndex = 24
        '
        'txt_BrowseResult
        '
        Me.txt_BrowseResult.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_BrowseResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_BrowseResult.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BrowseResult.Location = New System.Drawing.Point(82, 116)
        Me.txt_BrowseResult.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_BrowseResult.Multiline = True
        Me.txt_BrowseResult.Name = "txt_BrowseResult"
        Me.txt_BrowseResult.ReadOnly = True
        Me.txt_BrowseResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_BrowseResult.Size = New System.Drawing.Size(526, 53)
        Me.txt_BrowseResult.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 411)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Step 5: Transfer Files"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 281)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(260, 21)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Step 3: (Optional) Type in your track:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 350)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(455, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Step 4: (Optional) Add an additional folder inside the track folder"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 21)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Step 2: Select your car:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(473, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Step 1: Select your iRacing setup file, or a zip file with setups inside."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Thank you for using the Car Setup Installer for iRacing!"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Car Setup Installer for iRacing"
        Me.OpenFileDialog1.Filter = "iRacing Setup Files or .zip files (*.zip, *.sto)|*.zip;*.sto|All Files (*.*)|*.*"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "Select Setup File"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'cBox_Oval
        '
        Me.cBox_Oval.AutoSize = True
        Me.cBox_Oval.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBox_Oval.Location = New System.Drawing.Point(258, 191)
        Me.cBox_Oval.Name = "cBox_Oval"
        Me.cBox_Oval.Size = New System.Drawing.Size(61, 25)
        Me.cBox_Oval.TabIndex = 33
        Me.cBox_Oval.Text = "Oval"
        Me.cBox_Oval.UseVisualStyleBackColor = True
        '
        'cbox_Road
        '
        Me.cbox_Road.AutoSize = True
        Me.cbox_Road.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Road.Location = New System.Drawing.Point(326, 191)
        Me.cbox_Road.Name = "cbox_Road"
        Me.cbox_Road.Size = New System.Drawing.Size(65, 25)
        Me.cbox_Road.TabIndex = 34
        Me.cbox_Road.Text = "Road"
        Me.cbox_Road.UseVisualStyleBackColor = True
        '
        'cbox_DirtOval
        '
        Me.cbox_DirtOval.AutoSize = True
        Me.cbox_DirtOval.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_DirtOval.Location = New System.Drawing.Point(398, 191)
        Me.cbox_DirtOval.Name = "cbox_DirtOval"
        Me.cbox_DirtOval.Size = New System.Drawing.Size(91, 25)
        Me.cbox_DirtOval.TabIndex = 35
        Me.cbox_DirtOval.Text = "Dirt Oval"
        Me.cbox_DirtOval.UseVisualStyleBackColor = True
        '
        'cbox_DirtRoad
        '
        Me.cbox_DirtRoad.AutoSize = True
        Me.cbox_DirtRoad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_DirtRoad.Location = New System.Drawing.Point(496, 191)
        Me.cbox_DirtRoad.Name = "cbox_DirtRoad"
        Me.cbox_DirtRoad.Size = New System.Drawing.Size(95, 25)
        Me.cbox_DirtRoad.TabIndex = 36
        Me.cbox_DirtRoad.Text = "Dirt Road"
        Me.cbox_DirtRoad.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 526)
        Me.Controls.Add(Me.cbox_DirtRoad)
        Me.Controls.Add(Me.cbox_DirtOval)
        Me.Controls.Add(Me.cbox_Road)
        Me.Controls.Add(Me.cBox_Oval)
        Me.Controls.Add(Me.btn_BrowseAdditional)
        Me.Controls.Add(Me.btn_BrowseTrack)
        Me.Controls.Add(Me.Cbox_Cut)
        Me.Controls.Add(Me.Cbox_OpenDestination)
        Me.Controls.Add(Me.Btn_Transfer)
        Me.Controls.Add(Me.txt_FolderAdditonal)
        Me.Controls.Add(Me.txt_TrackName)
        Me.Controls.Add(Me.Btn_Browse)
        Me.Controls.Add(Me.Cbo_CarList)
        Me.Controls.Add(Me.txt_BrowseResult)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Car Setup Installer for iRacing"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IRacingDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyDefaultFolderLocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_BrowseAdditional As Button
    Friend WithEvents btn_BrowseTrack As Button
    Friend WithEvents Cbox_Cut As CheckBox
    Friend WithEvents Cbox_OpenDestination As CheckBox
    Friend WithEvents Btn_Transfer As Button
    Friend WithEvents txt_FolderAdditonal As TextBox
    Friend WithEvents txt_TrackName As TextBox
    Friend WithEvents Btn_Browse As Button
    Friend WithEvents Cbo_CarList As ComboBox
    Friend WithEvents txt_BrowseResult As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents cBox_Oval As CheckBox
    Friend WithEvents cbox_Road As CheckBox
    Friend WithEvents cbox_DirtOval As CheckBox
    Friend WithEvents cbox_DirtRoad As CheckBox
End Class
