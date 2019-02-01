Imports System.Net

Public Class Main

    'Zmienne
    Dim WC As New WebClient
    Dim Speed As Integer
    Dim SavePath As String
    Dim BytesDownloaded As String
    Dim BytesToRecieve As String

    'Interakcja z polem tekstowym
    Private Sub adressTxtBox_Enter(sender As Object, e As EventArgs) Handles adressTxtBox.Enter
        If adressTxtBox.Text = "Adres..." And adressTxtBox.ForeColor = Color.Gray Then
            adressTxtBox.Text = ""
            adressTxtBox.ForeColor = Color.Black
        Else
            adressTxtBox.SelectAll()
        End If
    End Sub

    'Opuszczenie pola tekstowego
    Private Sub adressTxtBox_Leave(sender As Object, e As EventArgs) Handles adressTxtBox.Leave
        If adressTxtBox.Text = "Adres..." And adressTxtBox.ForeColor = Color.Black Then
            adressTxtBox.Text = ""
            adressTxtBox.ForeColor = Color.Gray
        Else
            adressTxtBox.SelectAll()
        End If
    End Sub

    'Wklejenie w pole tekstowe zawartości schowka po naciśnięciu przycisku
    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        adressTxtBox.Text = My.Computer.Clipboard.GetText
        adressTxtBox.ForeColor = Color.Black
    End Sub

    'Wyłączenie i natychmiastowe włączenie pola tekstowego gdyż było od razu zaznaczane po włączeniu programu
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adressTxtBox.Enabled = False
        timer.Start()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        adressTxtBox.Enabled = True
    End Sub

    'Pobieranie pliku
    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Try

            'https://
            If adressTxtBox.Text <> "" And adressTxtBox.Text.StartsWith("https://") Then

                'Okno dialogowe z zapisem pliku
                saveFileDialog.FileName = adressTxtBox.Text.Split("/"c)(adressTxtBox.Text.Split("/"c).Length - 1)

                'Wskazanie miejsca docelowego przed pobraniem pliku
                If AlwaysAskToolStripMenuItem.Checked = True Then
                    If saveFileDialog.ShowDialog = DialogResult.OK Then
                        SavePath = saveFileDialog.FileName
                        saveFileDialog.FileName = ""

                        'Rozpoczęcie pobierania
                        AddHandler WC.DownloadProgressChanged, AddressOf Calculation
                        lblStatus.Text = "Status: Pobieranie..."
                        WC.DownloadFileAsync(New Uri(adressTxtBox.Text), SavePath.ToString, Stopwatch.StartNew)

                        btnDownload.Enabled = False
                        btnCancel.Enabled = True
                    End If

                    'Jeżeli funkcja wskazania nie jest dostępna i ToolTextBox nie jest pusty
                ElseIf ToolStripTextBox1.Text <> "C:/" Then
                    SavePath = saveFileDialog.FileName
                    saveFileDialog.FileName = ""

                    'Rozpoczęcie pobierania
                    AddHandler WC.DownloadProgressChanged, AddressOf Calculation
                    lblStatus.Text = "Status: Pobieranie..."
                    WC.DownloadFileAsync(New Uri(adressTxtBox.Text), (ToolStripTextBox1.Text & SavePath.ToString), Stopwatch.StartNew)
                    btnDownload.Enabled = False
                    btnCancel.Enabled = True
                Else
                    MsgBox("Domyślna lokalizacja nie odnaleziona. Sprawdź 'Pobrania - Opcje - Domyślna lokalizacja plików'", MsgBoxStyle.Exclamation, "Error")
                End If

                'http://
            ElseIf adressTxtBox.Text <> "" And adressTxtBox.Text.StartsWith("http://") Then

                'Okno dialogowe z zapisem pliku
                saveFileDialog.FileName = adressTxtBox.Text.Split("/"c)(adressTxtBox.Text.Split("/"c).Length - 1)

                'Wskazanie miejsca docelowego przed pobraniem pliku
                If AlwaysAskToolStripMenuItem.Checked = True Then
                    If saveFileDialog.ShowDialog = DialogResult.OK Then
                        SavePath = saveFileDialog.FileName
                        saveFileDialog.FileName = ""

                        'Rozpoczęcie pobierania
                        AddHandler WC.DownloadProgressChanged, AddressOf Calculation
                        lblStatus.Text = "Status: Pobieranie..."
                        WC.DownloadFileAsync(New Uri(adressTxtBox.Text), SavePath.ToString, Stopwatch.StartNew)
                        btnDownload.Enabled = False
                        btnCancel.Enabled = True

                    End If

                    'Jeżeli funkcja wskazania nie jest dostępna i ToolTextBox nie jest pusty
                ElseIf AlwaysAskToolStripMenuItem.Checked = False Then
                    SavePath = saveFileDialog.FileName
                    saveFileDialog.FileName = ""

                    'Rozpoczęcie pobierania
                    lblStatus.Text = "Status: Pobieranie..."
                    AddHandler WC.DownloadProgressChanged, AddressOf Calculation

                    WC.DownloadFileAsync(New Uri(adressTxtBox.Text), (ToolStripTextBox1.Text & SavePath.ToString), Stopwatch.StartNew)
                    SavePath = ToolStripTextBox1.Text & SavePath.ToString
                    btnDownload.Enabled = False
                    btnCancel.Enabled = True
                Else
                    MsgBox("Domyślna lokalizacja nie odnaleziona. Sprawdź 'Pobrania - Opcje - Domyślna lokalizacja plików'", MsgBoxStyle.Exclamation, "Error")
                End If

            Else 'Jeżeli pole tekstowe jest puste :v
                MsgBox("Wprowadź poprawny i działąjący link!", MsgBoxStyle.Exclamation, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Obliczanie Prędkości pobrania, Postęp %, konwertowanie otrzymanych bajtów i wszystkich bajtów
    Private Sub Calculation(sender As Object, e As DownloadProgressChangedEventArgs)

        'Obliczanie prędkości w bajtach i zamiana ich na MB
        Speed = (e.BytesReceived / (DirectCast(e.UserState, Stopwatch).ElapsedMilliseconds / 1000.0#)).ToString("#")

        If Speed >= 1073741824 Then
            lblSpeed.Text = "Speed: " & Format(Speed / 1024 / 1024 / 1024, "#0.00") & " GB/s"
        ElseIf Speed >= 1048576 Then
            lblSpeed.Text = "Speed: " & Format(Speed / 1024 / 1024, "#0.00") & " MB/s"
        ElseIf Speed >= 1024 Then
            lblSpeed.Text = "Speed: " & Format(Speed / 1024, "#0.00") & " KB/s"
        ElseIf Speed < 1024 Then
            lblSpeed.Text = "Speed: " & Fix(Speed) & " B/s"
        End If

        'Wartość paska postępu i %
        downloadProgress.Value = e.ProgressPercentage
        lblPercentProgress.Text = e.ProgressPercentage & "%"

        'Ukończone pobieranie
        If e.ProgressPercentage = 100 Then
            If ShutdownToolStripMenuItem.Checked = True Then
                Shell("shutdown -s")
            ElseIf ExitAzuréToolStripMenuItem.Checked = True Then
                Me.Close()
            ElseIf OpenFileToolStripMenuItem.Checked = True Then
                Try
                    Process.Start(SavePath)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
                End Try
            Else
                btnDownload.Enabled = True
                btnCancel.Enabled = False
                lblSpeed.Text = "Prędkość: --/--"
                lblStatus.Text = "Status: Ukończone, gotowe do następnego"
                lblProgress.Text = "Pobrano: --/--"
                lblPercentProgress.Text = "0%"
                downloadProgress.Value = 0
                MsgBox("Pobieranie zakończono", MsgBoxStyle.MsgBoxHelp, "Status pobierań")
            End If
        End If

        'Konwertowanie pobranych bajtów
        If e.BytesReceived >= 1073741824 Then
            BytesDownloaded = Format(e.BytesReceived / 1024 / 1024 / 1024, "#0.00") _
         & " GB"
        ElseIf e.BytesReceived >= 1048576 Then
            BytesDownloaded = Format(e.BytesReceived / 1024 / 1024, "#0.00") & " MB"
        ElseIf e.BytesReceived >= 1024 Then
            BytesDownloaded = Format(e.BytesReceived / 1024, "#0.00") & " KB"
        ElseIf e.BytesReceived < 1024 Then
            BytesDownloaded = Fix(e.BytesReceived) & " Bytes"
        End If

        'Konwertowanie wszystkich bajtów
        If e.TotalBytesToReceive >= 1073741824 Then
            BytesToRecieve = Format(e.TotalBytesToReceive / 1024 / 1024 / 1024, "#0.00") _
         & " GB"
        ElseIf e.TotalBytesToReceive >= 1048576 Then
            BytesToRecieve = Format(e.TotalBytesToReceive / 1024 / 1024, "#0.00") & " MB"
        ElseIf e.TotalBytesToReceive >= 1024 Then
            BytesToRecieve = Format(e.TotalBytesToReceive / 1024, "#0.00") & " KB"
        ElseIf e.TotalBytesToReceive < 1024 Then
            BytesToRecieve = Fix(e.TotalBytesToReceive) & " Bytes"
        End If

        'Pokazanie pobranego rozmiaru/całkowitego rozmiaru
        lblDownloadedSize.Text = "Size: " & BytesDownloaded & " / " & BytesToRecieve

    End Sub

    'Anulowanie pobrania
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            WC.CancelAsync()
            lblSpeed.Text = "Prędkość: --/--"
            lblDownloadedSize.Text = "Wielkość: --/--"
            lblStatus.Text = "Status: Anulowany"
            lblProgress.Text = "Ściągnięto: --/--"
            lblPercentProgress.Text = "0%"
            downloadProgress.Value = 0
            My.Computer.FileSystem.DeleteFile(SavePath)
            btnCancel.Enabled = False
            btnDownload.Enabled = True
            MsgBox("Pobieranie zostało anulowane", MsgBoxStyle.Exclamation, "Status pobierań")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BrowseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowseToolStripMenuItem.Click
        Dim OpenFolder As New FolderBrowserDialog
        If OpenFolder.ShowDialog() = DialogResult.OK Then
            ToolStripTextBox1.Text = OpenFolder.SelectedPath
            AlwaysAskToolStripMenuItem.Checked = False
        End If

    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        If ShutdownToolStripMenuItem.Checked = True Then
            ExitAzuréToolStripMenuItem.Checked = False
            OpenFileToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub ExitDMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitAzuréToolStripMenuItem.Click
        If ExitAzuréToolStripMenuItem.Checked = True Then
            ShutdownToolStripMenuItem.Checked = False
            OpenFileToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        If OpenFileToolStripMenuItem.Checked = True Then
            ExitAzuréToolStripMenuItem.Checked = False
            ShutdownToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Azuré v1.0.0.0" + vbNewLine + "2019, Jakub 'dzejqub' Semeniuk. Przetłumaczone przez ui a.k.a 'infernus01'" + vbNewLine + "https://github.com/dzejqub/Azuré", vbInformation, "About Azuré")
    End Sub
End Class