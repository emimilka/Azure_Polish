<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.downloadProgress = New MetroFramework.Controls.MetroProgressBar()
        Me.adressTxtBox = New MetroFramework.Controls.MetroTextBox()
        Me.btnDownload = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnPaste = New MetroFramework.Controls.MetroButton()
        Me.lblSpeed = New MetroFramework.Controls.MetroLabel()
        Me.lblProgress = New MetroFramework.Controls.MetroLabel()
        Me.lblPercentProgress = New MetroFramework.Controls.MetroLabel()
        Me.lblStatus = New MetroFramework.Controls.MetroLabel()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.NnnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllCompletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhenDownloadCompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitAzuréToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultSaveLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysAskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.lblDownloadedSize = New MetroFramework.Controls.MetroLabel()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'downloadProgress
        '
        Me.downloadProgress.Location = New System.Drawing.Point(0, 180)
        Me.downloadProgress.Name = "downloadProgress"
        Me.downloadProgress.Size = New System.Drawing.Size(487, 31)
        Me.downloadProgress.TabIndex = 0
        '
        'adressTxtBox
        '
        '
        '
        '
        Me.adressTxtBox.CustomButton.Image = Nothing
        Me.adressTxtBox.CustomButton.Location = New System.Drawing.Point(382, 1)
        Me.adressTxtBox.CustomButton.Name = ""
        Me.adressTxtBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.adressTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.adressTxtBox.CustomButton.TabIndex = 1
        Me.adressTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.adressTxtBox.CustomButton.UseSelectable = True
        Me.adressTxtBox.CustomButton.Visible = False
        Me.adressTxtBox.ForeColor = System.Drawing.Color.Gray
        Me.adressTxtBox.Lines = New String() {"Adres..."}
        Me.adressTxtBox.Location = New System.Drawing.Point(12, 42)
        Me.adressTxtBox.MaxLength = 32767
        Me.adressTxtBox.Name = "adressTxtBox"
        Me.adressTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.adressTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.adressTxtBox.SelectedText = ""
        Me.adressTxtBox.SelectionLength = 0
        Me.adressTxtBox.SelectionStart = 0
        Me.adressTxtBox.ShowClearButton = True
        Me.adressTxtBox.Size = New System.Drawing.Size(404, 23)
        Me.adressTxtBox.TabIndex = 1
        Me.adressTxtBox.Text = "Adres..."
        Me.adressTxtBox.UseCustomForeColor = True
        Me.adressTxtBox.UseSelectable = True
        Me.adressTxtBox.WaterMarkColor = System.Drawing.Color.Gray
        Me.adressTxtBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(12, 71)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(349, 39)
        Me.btnDownload.TabIndex = 2
        Me.btnDownload.Text = "Pobierz"
        Me.btnDownload.UseSelectable = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(367, 72)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 38)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Anuluj"
        Me.btnCancel.UseSelectable = True
        '
        'btnPaste
        '
        Me.btnPaste.Location = New System.Drawing.Point(422, 42)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(50, 23)
        Me.btnPaste.TabIndex = 4
        Me.btnPaste.Text = "Wklej"
        Me.btnPaste.UseSelectable = True
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.BackColor = System.Drawing.SystemColors.Control
        Me.lblSpeed.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable
        Me.lblSpeed.Location = New System.Drawing.Point(12, 113)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(82, 19)
        Me.lblSpeed.TabIndex = 6
        Me.lblSpeed.Text = "Prędkość: --\--"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable
        Me.lblProgress.Location = New System.Drawing.Point(313, 158)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(159, 19)
        Me.lblProgress.TabIndex = 7
        Me.lblProgress.Text = "Ściągnięto: --\--"
        '
        'lblPercentProgress
        '
        Me.lblPercentProgress.AutoSize = True
        Me.lblPercentProgress.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblPercentProgress.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblPercentProgress.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable
        Me.lblPercentProgress.Location = New System.Drawing.Point(367, 126)
        Me.lblPercentProgress.Name = "lblPercentProgress"
        Me.lblPercentProgress.Size = New System.Drawing.Size(38, 25)
        Me.lblPercentProgress.TabIndex = 8
        Me.lblPercentProgress.Text = "0%"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblStatus.Location = New System.Drawing.Point(12, 158)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(79, 19)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Status: --\--"
        Me.lblStatus.UseCustomForeColor = True
        '
        'timer
        '
        Me.timer.Interval = 1
        '
        'NnnToolStripMenuItem
        '
        Me.NnnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryToolStripMenuItem, Me.DeleteAllCompletedToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.NnnToolStripMenuItem.Name = "NnnToolStripMenuItem"
        Me.NnnToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.NnnToolStripMenuItem.Text = "Pobrania"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.HistoryToolStripMenuItem.Text = "Historia"
        '
        'DeleteAllCompletedToolStripMenuItem
        '
        Me.DeleteAllCompletedToolStripMenuItem.Name = "DeleteAllCompletedToolStripMenuItem"
        Me.DeleteAllCompletedToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.DeleteAllCompletedToolStripMenuItem.Text = "Usuń wszystkie ukończone"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhenDownloadCompleteToolStripMenuItem, Me.DefaultSaveLocationToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.OptionsToolStripMenuItem.Text = "Opcje"
        '
        'WhenDownloadCompleteToolStripMenuItem
        '
        Me.WhenDownloadCompleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShutdownToolStripMenuItem, Me.ExitAzuréToolStripMenuItem, Me.OpenFileToolStripMenuItem})
        Me.WhenDownloadCompleteToolStripMenuItem.Name = "WhenDownloadCompleteToolStripMenuItem"
        Me.WhenDownloadCompleteToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.WhenDownloadCompleteToolStripMenuItem.Text = "Kiedy pobieranie się zakończy"
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.CheckOnClick = True
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ShutdownToolStripMenuItem.Text = "Wyłącz"
        '
        'ExitAzuréToolStripMenuItem
        '
        Me.ExitAzuréToolStripMenuItem.CheckOnClick = True
        Me.ExitAzuréToolStripMenuItem.Name = "ExitAzuréToolStripMenuItem"
        Me.ExitAzuréToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ExitAzuréToolStripMenuItem.Text = "Zamknij Azuré"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.CheckOnClick = True
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.OpenFileToolStripMenuItem.Text = "Otwórz ściągnięty plik"
        '
        'DefaultSaveLocationToolStripMenuItem
        '
        Me.DefaultSaveLocationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysAskToolStripMenuItem, Me.BrowseToolStripMenuItem, Me.ToolStripTextBox1})
        Me.DefaultSaveLocationToolStripMenuItem.Name = "DefaultSaveLocationToolStripMenuItem"
        Me.DefaultSaveLocationToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.DefaultSaveLocationToolStripMenuItem.Text = "Domyślna lokalizacja plików"
        '
        'AlwaysAskToolStripMenuItem
        '
        Me.AlwaysAskToolStripMenuItem.Name = "AlwaysAskToolStripMenuItem"
        Me.AlwaysAskToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AlwaysAskToolStripMenuItem.Text = "Zawsze pytaj"
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BrowseToolStripMenuItem.Text = "Przeglądaj"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 22)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.HelpToolStripMenuItem.Text = "Pomoc"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.AboutToolStripMenuItem.Text = "O programie"
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NnnToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(484, 24)
        Me.menuStrip.TabIndex = 5
        Me.menuStrip.Text = "MenuStrip1"
        '
        'lblDownloadedSize
        '
        Me.lblDownloadedSize.AutoSize = True
        Me.lblDownloadedSize.Location = New System.Drawing.Point(12, 132)
        Me.lblDownloadedSize.Name = "lblDownloadedSize"
        Me.lblDownloadedSize.Size = New System.Drawing.Size(68, 19)
        Me.lblDownloadedSize.TabIndex = 10
        Me.lblDownloadedSize.Text = "Wielkość: --\--"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(484, 212)
        Me.Controls.Add(Me.lblDownloadedSize)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblPercentProgress)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.btnPaste)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.adressTxtBox)
        Me.Controls.Add(Me.downloadProgress)
        Me.Controls.Add(Me.menuStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Azuré"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents downloadProgress As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents adressTxtBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnDownload As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPaste As MetroFramework.Controls.MetroButton
    Friend WithEvents lblSpeed As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProgress As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPercentProgress As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblStatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents timer As Timer
    Friend WithEvents NnnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAllCompletedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhenDownloadCompleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitAzuréToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultSaveLocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents saveFileDialog As SaveFileDialog
    Friend WithEvents AlwaysAskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents BrowseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDownloadedSize As MetroFramework.Controls.MetroLabel
End Class
