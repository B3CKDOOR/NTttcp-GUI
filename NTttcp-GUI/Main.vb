Public Class Main
#Disable Warning BC40000 ' Type or member is obsolete
    ' Variables
    Dim dataDirectory = Environment.CurrentDirectory
    Dim executable = dataDirectory + "\NTttcp.exe"
    Dim commandstring = ("")

    Private Sub BTNrun_Click(sender As Object, e As EventArgs) Handles BTNrun.Click
        BTNstop.Enabled = True
        BTNrun.Enabled = False
        BTNexit.Enabled = False
        On Error Resume Next
        Shell(executable + commandstring)
    End Sub
    Private Sub BTNstop_Click(sender As Object, e As EventArgs) Handles BTNstop.Click
        BTNrun.Enabled = True
        BTNstop.Enabled = False
        BTNexit.Enabled = True
        On Error Resume Next
        Shell("taskkill /F NTttcp.exe")
    End Sub

    Private Sub CHKsend_CheckedChanged(sender As Object, e As EventArgs) Handles CHKsend.CheckedChanged
        ' Lock receive button if other option is selected to prevent double selection
        If CHKsend.Checked = True Then
            CHKreceive.Enabled = False
        Else
            CHKreceive.Enabled = True
        End If
    End Sub

    Private Sub CHKreceive_CheckedChanged(sender As Object, e As EventArgs) Handles CHKreceive.CheckedChanged
        ' Lock send button if other option is selected to prevent double selection
        If CHKreceive.Checked = True Then
            CHKsend.Enabled = False
        Else
            CHKsend.Enabled = True
        End If

        ' Automatic obtain IP address from adapter
        ' #DISABLE until made working correctly

        'Dim strHostName As String
        'Dim strIPAddress As String
        '
        '
        '   strHostName = System.Net.Dns.GetHostName()
        '  strIPAddress = Net.Dns.Resolve(strHostName).AddressList(0).ToString()
        'Dim ni = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
        'Dim niEthernet = ni.Where(Function(x) x.NetworkInterfaceType =
        '             Net.NetworkInformation.NetworkInterfaceType.Ethernet)
        '
        '   CMBip.DataSource = niEthernet.Select(Function(x) x.Name).ToList()
        '
        '
        '   'will set the textbox to the selected item in the combobox
        '  TXBip.Text = CMBip.SelectedItem
        '
        'or set it based on the combo selection
        'Select Case CMBip.SelectedItem
        'Case "Ethernet"
        '           TXBip.Text = Net.Dns.Resolve(strHostName).AddressList(0).ToString()
        '
        'Case "Ethernet2"
        '           TXBip.Text = Net.Dns.Resolve(strHostName).AddressList(1).ToString()

        'End Select
    End Sub
End Class
