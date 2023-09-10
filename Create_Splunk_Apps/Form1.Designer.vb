<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label13 = New Label()
        txtDeployLocation = New TextBox()
        btnCreateApp = New Button()
        txtSiteName = New TextBox()
        Label1 = New Label()
        TabPage2 = New TabPage()
        Label2 = New Label()
        txtLicenseServerIP = New TextBox()
        chkCreateLicenseServer = New CheckBox()
        TabPage3 = New TabPage()
        Label21 = New Label()
        txtPhoneHomeInterval = New TextBox()
        Label3 = New Label()
        chkUseDeploymentServer = New CheckBox()
        txtDeploymentServer = New TextBox()
        TabPage4 = New TabPage()
        Label20 = New Label()
        txtForwardingKBPS = New TextBox()
        chkSetupForwarding = New CheckBox()
        TabPage5 = New TabPage()
        chkDefineIndexers = New CheckBox()
        btnClearIndexers = New Button()
        Label5 = New Label()
        lstIndexerIPs = New ListBox()
        Label4 = New Label()
        txtIndexerIP = New TextBox()
        btnAddIndexer = New Button()
        TabPage6 = New TabPage()
        txtFishBucketMB = New TextBox()
        txtAuditMB = New TextBox()
        txtTelemetryMB = New TextBox()
        txtIntrospectionMB = New TextBox()
        txtInternalMB = New TextBox()
        txtSummaryMB = New TextBox()
        txtHistoryMB = New TextBox()
        txtMainMB = New TextBox()
        Label14 = New Label()
        txtFishBucketThawedPath = New TextBox()
        txtFishBucketColdPath = New TextBox()
        txtFishBucketHomePath = New TextBox()
        txtFishbucketIndex = New TextBox()
        txtAuditThawedPath = New TextBox()
        txtAuditColdPath = New TextBox()
        txtAuditHomePath = New TextBox()
        txtAuditIndex = New TextBox()
        txtTelemetryThawedPath = New TextBox()
        txtTelemetryColdPath = New TextBox()
        txtTelemetryHomePath = New TextBox()
        txtTelemetryIndex = New TextBox()
        txtIntrospectionThawedPath = New TextBox()
        txtIntrospectionColdPath = New TextBox()
        txtIntrospectionHomePath = New TextBox()
        txtIntrospectionIndex = New TextBox()
        txtInternalThawedPath = New TextBox()
        txtInternalColdPath = New TextBox()
        txtInternalHomePath = New TextBox()
        txtInternalIndex = New TextBox()
        txtSummaryThawedPath = New TextBox()
        txtSummaryColdPath = New TextBox()
        txtSummaryHomePath = New TextBox()
        txtSummaryIndex = New TextBox()
        txtHistoryThawedPath = New TextBox()
        txtHistoryColdPath = New TextBox()
        txtHistoryHomePath = New TextBox()
        txtHistoryIndex = New TextBox()
        txtMainThawedPath = New TextBox()
        txtMainColdPath = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        txtMainHomePath = New TextBox()
        txtMainIndex = New TextBox()
        txtMaxMB = New TextBox()
        Label8 = New Label()
        txtVolumePrimary = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        lstDefaultIndexes = New ListBox()
        TabPage7 = New TabPage()
        chkSetUpClusterIndexing = New CheckBox()
        txtSearchFactor = New TextBox()
        txtReplicationFactor = New TextBox()
        Label19 = New Label()
        Label18 = New Label()
        txtSymmKeyForIndexerDiscovery = New TextBox()
        txtSymmKeyForCluster = New TextBox()
        txtClusterLabel = New TextBox()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label22 = New Label()
        txtUITimeout = New TextBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        TabPage6.SuspendLayout()
        TabPage7.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage6)
        TabControl1.Controls.Add(TabPage7)
        TabControl1.Location = New Point(6, 10)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1441, 607)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label22)
        TabPage1.Controls.Add(txtUITimeout)
        TabPage1.Controls.Add(Label13)
        TabPage1.Controls.Add(txtDeployLocation)
        TabPage1.Controls.Add(btnCreateApp)
        TabPage1.Controls.Add(txtSiteName)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1433, 574)
        TabPage1.TabIndex = 0
        TabPage1.Text = "App Info"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(44, 46)
        Label13.Name = "Label13"
        Label13.Size = New Size(162, 20)
        Label13.TabIndex = 4
        Label13.Text = "Where To Deploy Apps"
        ' 
        ' txtDeployLocation
        ' 
        txtDeployLocation.Location = New Point(31, 69)
        txtDeployLocation.Name = "txtDeployLocation"
        txtDeployLocation.Size = New Size(429, 27)
        txtDeployLocation.TabIndex = 3
        txtDeployLocation.Text = "C:\temp\"
        ' 
        ' btnCreateApp
        ' 
        btnCreateApp.Location = New Point(63, 188)
        btnCreateApp.Name = "btnCreateApp"
        btnCreateApp.Size = New Size(126, 29)
        btnCreateApp.TabIndex = 2
        btnCreateApp.Text = "Create Apps"
        btnCreateApp.UseVisualStyleBackColor = True
        ' 
        ' txtSiteName
        ' 
        txtSiteName.Location = New Point(516, 69)
        txtSiteName.Name = "txtSiteName"
        txtSiteName.Size = New Size(207, 27)
        txtSiteName.TabIndex = 1
        txtSiteName.Text = "splunk_foo"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(529, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 0
        Label1.Text = "Site Name"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(txtLicenseServerIP)
        TabPage2.Controls.Add(chkCreateLicenseServer)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1433, 574)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Licensing"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 20)
        Label2.TabIndex = 2
        Label2.Text = "License Server IP"
        ' 
        ' txtLicenseServerIP
        ' 
        txtLicenseServerIP.Location = New Point(45, 83)
        txtLicenseServerIP.Name = "txtLicenseServerIP"
        txtLicenseServerIP.Size = New Size(223, 27)
        txtLicenseServerIP.TabIndex = 1
        txtLicenseServerIP.Text = "192.168.0.128"
        ' 
        ' chkCreateLicenseServer
        ' 
        chkCreateLicenseServer.AutoSize = True
        chkCreateLicenseServer.Checked = True
        chkCreateLicenseServer.CheckState = CheckState.Checked
        chkCreateLicenseServer.Location = New Point(20, 21)
        chkCreateLicenseServer.Name = "chkCreateLicenseServer"
        chkCreateLicenseServer.Size = New Size(171, 24)
        chkCreateLicenseServer.TabIndex = 0
        chkCreateLicenseServer.Text = "Create License Server"
        chkCreateLicenseServer.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Label21)
        TabPage3.Controls.Add(txtPhoneHomeInterval)
        TabPage3.Controls.Add(Label3)
        TabPage3.Controls.Add(chkUseDeploymentServer)
        TabPage3.Controls.Add(txtDeploymentServer)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1433, 574)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Deployment Server"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(295, 85)
        Label21.Name = "Label21"
        Label21.Size = New Size(223, 20)
        Label21.TabIndex = 4
        Label21.Text = "Phone Home Interval In Seconds"
        ' 
        ' txtPhoneHomeInterval
        ' 
        txtPhoneHomeInterval.Location = New Point(342, 115)
        txtPhoneHomeInterval.Name = "txtPhoneHomeInterval"
        txtPhoneHomeInterval.Size = New Size(125, 27)
        txtPhoneHomeInterval.TabIndex = 3
        txtPhoneHomeInterval.Text = "600"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 20)
        Label3.TabIndex = 2
        Label3.Text = "Deployment Server IP "
        ' 
        ' chkUseDeploymentServer
        ' 
        chkUseDeploymentServer.AutoSize = True
        chkUseDeploymentServer.Checked = True
        chkUseDeploymentServer.CheckState = CheckState.Checked
        chkUseDeploymentServer.Location = New Point(26, 37)
        chkUseDeploymentServer.Name = "chkUseDeploymentServer"
        chkUseDeploymentServer.Size = New Size(186, 24)
        chkUseDeploymentServer.TabIndex = 1
        chkUseDeploymentServer.Text = "Use Deployment Server"
        chkUseDeploymentServer.UseVisualStyleBackColor = True
        ' 
        ' txtDeploymentServer
        ' 
        txtDeploymentServer.Location = New Point(45, 115)
        txtDeploymentServer.Name = "txtDeploymentServer"
        txtDeploymentServer.Size = New Size(213, 27)
        txtDeploymentServer.TabIndex = 0
        txtDeploymentServer.Text = "192.168.0.128"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Label20)
        TabPage4.Controls.Add(txtForwardingKBPS)
        TabPage4.Controls.Add(chkSetupForwarding)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1433, 574)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Forwarding"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(25, 74)
        Label20.Name = "Label20"
        Label20.Size = New Size(308, 20)
        Label20.TabIndex = 2
        Label20.Text = "Forwarding Thruput (No Throttle = 0) in KBps"
        ' 
        ' txtForwardingKBPS
        ' 
        txtForwardingKBPS.Location = New Point(103, 97)
        txtForwardingKBPS.Name = "txtForwardingKBPS"
        txtForwardingKBPS.Size = New Size(125, 27)
        txtForwardingKBPS.TabIndex = 1
        txtForwardingKBPS.Text = "0"
        ' 
        ' chkSetupForwarding
        ' 
        chkSetupForwarding.AutoSize = True
        chkSetupForwarding.Checked = True
        chkSetupForwarding.CheckState = CheckState.Checked
        chkSetupForwarding.Location = New Point(48, 28)
        chkSetupForwarding.Name = "chkSetupForwarding"
        chkSetupForwarding.Size = New Size(152, 24)
        chkSetupForwarding.TabIndex = 0
        chkSetupForwarding.Text = "Set up Forwarding"
        chkSetupForwarding.UseVisualStyleBackColor = True
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(chkDefineIndexers)
        TabPage5.Controls.Add(btnClearIndexers)
        TabPage5.Controls.Add(Label5)
        TabPage5.Controls.Add(lstIndexerIPs)
        TabPage5.Controls.Add(Label4)
        TabPage5.Controls.Add(txtIndexerIP)
        TabPage5.Controls.Add(btnAddIndexer)
        TabPage5.Location = New Point(4, 29)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(1433, 574)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Indexers"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' chkDefineIndexers
        ' 
        chkDefineIndexers.AutoSize = True
        chkDefineIndexers.Checked = True
        chkDefineIndexers.CheckState = CheckState.Checked
        chkDefineIndexers.Location = New Point(20, 25)
        chkDefineIndexers.Name = "chkDefineIndexers"
        chkDefineIndexers.Size = New Size(134, 24)
        chkDefineIndexers.TabIndex = 6
        chkDefineIndexers.Text = "Define Indexers"
        chkDefineIndexers.UseVisualStyleBackColor = True
        ' 
        ' btnClearIndexers
        ' 
        btnClearIndexers.Location = New Point(86, 469)
        btnClearIndexers.Name = "btnClearIndexers"
        btnClearIndexers.Size = New Size(94, 29)
        btnClearIndexers.TabIndex = 5
        btnClearIndexers.Text = "Clear List"
        btnClearIndexers.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(70, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 20)
        Label5.TabIndex = 4
        Label5.Text = "List Of Indexers"
        ' 
        ' lstIndexerIPs
        ' 
        lstIndexerIPs.FormattingEnabled = True
        lstIndexerIPs.ItemHeight = 20
        lstIndexerIPs.Items.AddRange(New Object() {"192.168.0.128"})
        lstIndexerIPs.Location = New Point(48, 219)
        lstIndexerIPs.Name = "lstIndexerIPs"
        lstIndexerIPs.Size = New Size(224, 244)
        lstIndexerIPs.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 70)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 20)
        Label4.TabIndex = 2
        Label4.Text = "Add IP Address Of Indexer"
        ' 
        ' txtIndexerIP
        ' 
        txtIndexerIP.Location = New Point(48, 101)
        txtIndexerIP.Name = "txtIndexerIP"
        txtIndexerIP.Size = New Size(226, 27)
        txtIndexerIP.TabIndex = 1
        ' 
        ' btnAddIndexer
        ' 
        btnAddIndexer.Location = New Point(86, 149)
        btnAddIndexer.Name = "btnAddIndexer"
        btnAddIndexer.Size = New Size(94, 29)
        btnAddIndexer.TabIndex = 0
        btnAddIndexer.Text = "Add Server"
        btnAddIndexer.UseVisualStyleBackColor = True
        ' 
        ' TabPage6
        ' 
        TabPage6.Controls.Add(txtFishBucketMB)
        TabPage6.Controls.Add(txtAuditMB)
        TabPage6.Controls.Add(txtTelemetryMB)
        TabPage6.Controls.Add(txtIntrospectionMB)
        TabPage6.Controls.Add(txtInternalMB)
        TabPage6.Controls.Add(txtSummaryMB)
        TabPage6.Controls.Add(txtHistoryMB)
        TabPage6.Controls.Add(txtMainMB)
        TabPage6.Controls.Add(Label14)
        TabPage6.Controls.Add(txtFishBucketThawedPath)
        TabPage6.Controls.Add(txtFishBucketColdPath)
        TabPage6.Controls.Add(txtFishBucketHomePath)
        TabPage6.Controls.Add(txtFishbucketIndex)
        TabPage6.Controls.Add(txtAuditThawedPath)
        TabPage6.Controls.Add(txtAuditColdPath)
        TabPage6.Controls.Add(txtAuditHomePath)
        TabPage6.Controls.Add(txtAuditIndex)
        TabPage6.Controls.Add(txtTelemetryThawedPath)
        TabPage6.Controls.Add(txtTelemetryColdPath)
        TabPage6.Controls.Add(txtTelemetryHomePath)
        TabPage6.Controls.Add(txtTelemetryIndex)
        TabPage6.Controls.Add(txtIntrospectionThawedPath)
        TabPage6.Controls.Add(txtIntrospectionColdPath)
        TabPage6.Controls.Add(txtIntrospectionHomePath)
        TabPage6.Controls.Add(txtIntrospectionIndex)
        TabPage6.Controls.Add(txtInternalThawedPath)
        TabPage6.Controls.Add(txtInternalColdPath)
        TabPage6.Controls.Add(txtInternalHomePath)
        TabPage6.Controls.Add(txtInternalIndex)
        TabPage6.Controls.Add(txtSummaryThawedPath)
        TabPage6.Controls.Add(txtSummaryColdPath)
        TabPage6.Controls.Add(txtSummaryHomePath)
        TabPage6.Controls.Add(txtSummaryIndex)
        TabPage6.Controls.Add(txtHistoryThawedPath)
        TabPage6.Controls.Add(txtHistoryColdPath)
        TabPage6.Controls.Add(txtHistoryHomePath)
        TabPage6.Controls.Add(txtHistoryIndex)
        TabPage6.Controls.Add(txtMainThawedPath)
        TabPage6.Controls.Add(txtMainColdPath)
        TabPage6.Controls.Add(Label12)
        TabPage6.Controls.Add(Label11)
        TabPage6.Controls.Add(Label10)
        TabPage6.Controls.Add(Label9)
        TabPage6.Controls.Add(txtMainHomePath)
        TabPage6.Controls.Add(txtMainIndex)
        TabPage6.Controls.Add(txtMaxMB)
        TabPage6.Controls.Add(Label8)
        TabPage6.Controls.Add(txtVolumePrimary)
        TabPage6.Controls.Add(Label7)
        TabPage6.Controls.Add(Label6)
        TabPage6.Controls.Add(lstDefaultIndexes)
        TabPage6.Location = New Point(4, 29)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.Size = New Size(1433, 574)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Index Size Settings"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' txtFishBucketMB
        ' 
        txtFishBucketMB.Location = New Point(1246, 358)
        txtFishBucketMB.Name = "txtFishBucketMB"
        txtFishBucketMB.Size = New Size(156, 27)
        txtFishBucketMB.TabIndex = 58
        txtFishBucketMB.Text = "10240"
        ' 
        ' txtAuditMB
        ' 
        txtAuditMB.Location = New Point(1246, 312)
        txtAuditMB.Name = "txtAuditMB"
        txtAuditMB.Size = New Size(156, 27)
        txtAuditMB.TabIndex = 58
        txtAuditMB.Text = "10240"
        ' 
        ' txtTelemetryMB
        ' 
        txtTelemetryMB.Location = New Point(1246, 268)
        txtTelemetryMB.Name = "txtTelemetryMB"
        txtTelemetryMB.Size = New Size(156, 27)
        txtTelemetryMB.TabIndex = 60
        txtTelemetryMB.Text = "10240"
        ' 
        ' txtIntrospectionMB
        ' 
        txtIntrospectionMB.Location = New Point(1246, 225)
        txtIntrospectionMB.Name = "txtIntrospectionMB"
        txtIntrospectionMB.Size = New Size(156, 27)
        txtIntrospectionMB.TabIndex = 59
        txtIntrospectionMB.Text = "10240"
        ' 
        ' txtInternalMB
        ' 
        txtInternalMB.Location = New Point(1246, 179)
        txtInternalMB.Name = "txtInternalMB"
        txtInternalMB.Size = New Size(156, 27)
        txtInternalMB.TabIndex = 58
        txtInternalMB.Text = "10240"
        ' 
        ' txtSummaryMB
        ' 
        txtSummaryMB.Location = New Point(1246, 135)
        txtSummaryMB.Name = "txtSummaryMB"
        txtSummaryMB.Size = New Size(156, 27)
        txtSummaryMB.TabIndex = 57
        txtSummaryMB.Text = "10240"
        ' 
        ' txtHistoryMB
        ' 
        txtHistoryMB.Location = New Point(1246, 91)
        txtHistoryMB.Name = "txtHistoryMB"
        txtHistoryMB.Size = New Size(156, 27)
        txtHistoryMB.TabIndex = 56
        txtHistoryMB.Text = "10240"
        ' 
        ' txtMainMB
        ' 
        txtMainMB.Location = New Point(1246, 45)
        txtMainMB.Name = "txtMainMB"
        txtMainMB.Size = New Size(156, 27)
        txtMainMB.TabIndex = 55
        txtMainMB.Text = "10240"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(1275, 22)
        Label14.Name = "Label14"
        Label14.Size = New Size(63, 20)
        Label14.TabIndex = 54
        Label14.Text = "Max MB"
        ' 
        ' txtFishBucketThawedPath
        ' 
        txtFishBucketThawedPath.Location = New Point(968, 358)
        txtFishBucketThawedPath.Name = "txtFishBucketThawedPath"
        txtFishBucketThawedPath.Size = New Size(252, 27)
        txtFishBucketThawedPath.TabIndex = 52
        txtFishBucketThawedPath.Text = "$SPLUNK_DB/thefishbucketdb/thaweddb"
        ' 
        ' txtFishBucketColdPath
        ' 
        txtFishBucketColdPath.Location = New Point(707, 358)
        txtFishBucketColdPath.Name = "txtFishBucketColdPath"
        txtFishBucketColdPath.Size = New Size(240, 27)
        txtFishBucketColdPath.TabIndex = 51
        txtFishBucketColdPath.Text = "volume:primary/thefishbucketdb/colddb"
        ' 
        ' txtFishBucketHomePath
        ' 
        txtFishBucketHomePath.Location = New Point(476, 358)
        txtFishBucketHomePath.Name = "txtFishBucketHomePath"
        txtFishBucketHomePath.Size = New Size(215, 27)
        txtFishBucketHomePath.TabIndex = 50
        txtFishBucketHomePath.Text = "volume:primary/thefishbucketdb/db"
        ' 
        ' txtFishbucketIndex
        ' 
        txtFishbucketIndex.Location = New Point(308, 358)
        txtFishbucketIndex.Name = "txtFishbucketIndex"
        txtFishbucketIndex.Size = New Size(156, 27)
        txtFishbucketIndex.TabIndex = 49
        txtFishbucketIndex.Text = "_thefishbucket"
        ' 
        ' txtAuditThawedPath
        ' 
        txtAuditThawedPath.Location = New Point(968, 312)
        txtAuditThawedPath.Name = "txtAuditThawedPath"
        txtAuditThawedPath.Size = New Size(252, 27)
        txtAuditThawedPath.TabIndex = 48
        txtAuditThawedPath.Text = "$SPLUNK_DB/auditdb/thaweddb"
        ' 
        ' txtAuditColdPath
        ' 
        txtAuditColdPath.Location = New Point(707, 312)
        txtAuditColdPath.Name = "txtAuditColdPath"
        txtAuditColdPath.Size = New Size(240, 27)
        txtAuditColdPath.TabIndex = 47
        txtAuditColdPath.Text = "volume:primary/auditdb/colddb"
        ' 
        ' txtAuditHomePath
        ' 
        txtAuditHomePath.Location = New Point(476, 312)
        txtAuditHomePath.Name = "txtAuditHomePath"
        txtAuditHomePath.Size = New Size(215, 27)
        txtAuditHomePath.TabIndex = 46
        txtAuditHomePath.Text = "volume:primary/auditdb/db"
        ' 
        ' txtAuditIndex
        ' 
        txtAuditIndex.Location = New Point(308, 312)
        txtAuditIndex.Name = "txtAuditIndex"
        txtAuditIndex.Size = New Size(156, 27)
        txtAuditIndex.TabIndex = 45
        txtAuditIndex.Text = "_audit"
        ' 
        ' txtTelemetryThawedPath
        ' 
        txtTelemetryThawedPath.Location = New Point(968, 268)
        txtTelemetryThawedPath.Name = "txtTelemetryThawedPath"
        txtTelemetryThawedPath.Size = New Size(252, 27)
        txtTelemetryThawedPath.TabIndex = 44
        txtTelemetryThawedPath.Text = "$SPLUNK_DB/telemetrydb/thaweddb"
        ' 
        ' txtTelemetryColdPath
        ' 
        txtTelemetryColdPath.Location = New Point(707, 268)
        txtTelemetryColdPath.Name = "txtTelemetryColdPath"
        txtTelemetryColdPath.Size = New Size(240, 27)
        txtTelemetryColdPath.TabIndex = 43
        txtTelemetryColdPath.Text = "volume:primary/telemetrydb/colddb"
        ' 
        ' txtTelemetryHomePath
        ' 
        txtTelemetryHomePath.Location = New Point(476, 268)
        txtTelemetryHomePath.Name = "txtTelemetryHomePath"
        txtTelemetryHomePath.Size = New Size(215, 27)
        txtTelemetryHomePath.TabIndex = 42
        txtTelemetryHomePath.Text = "volume:primary/telemetrydb/db"
        ' 
        ' txtTelemetryIndex
        ' 
        txtTelemetryIndex.Location = New Point(308, 268)
        txtTelemetryIndex.Name = "txtTelemetryIndex"
        txtTelemetryIndex.Size = New Size(156, 27)
        txtTelemetryIndex.TabIndex = 41
        txtTelemetryIndex.Text = "_telemetry"
        ' 
        ' txtIntrospectionThawedPath
        ' 
        txtIntrospectionThawedPath.Location = New Point(968, 225)
        txtIntrospectionThawedPath.Name = "txtIntrospectionThawedPath"
        txtIntrospectionThawedPath.Size = New Size(252, 27)
        txtIntrospectionThawedPath.TabIndex = 40
        txtIntrospectionThawedPath.Text = "$SPLUNK_DB/introspectiondb/thaweddb"
        ' 
        ' txtIntrospectionColdPath
        ' 
        txtIntrospectionColdPath.Location = New Point(707, 225)
        txtIntrospectionColdPath.Name = "txtIntrospectionColdPath"
        txtIntrospectionColdPath.Size = New Size(240, 27)
        txtIntrospectionColdPath.TabIndex = 39
        txtIntrospectionColdPath.Text = "volume:primary/introspectiondb/colddb"
        ' 
        ' txtIntrospectionHomePath
        ' 
        txtIntrospectionHomePath.Location = New Point(476, 225)
        txtIntrospectionHomePath.Name = "txtIntrospectionHomePath"
        txtIntrospectionHomePath.Size = New Size(215, 27)
        txtIntrospectionHomePath.TabIndex = 38
        txtIntrospectionHomePath.Text = "volume:primary/introspectiondb/db"
        ' 
        ' txtIntrospectionIndex
        ' 
        txtIntrospectionIndex.Location = New Point(308, 225)
        txtIntrospectionIndex.Name = "txtIntrospectionIndex"
        txtIntrospectionIndex.Size = New Size(156, 27)
        txtIntrospectionIndex.TabIndex = 37
        txtIntrospectionIndex.Text = "_introspection"
        ' 
        ' txtInternalThawedPath
        ' 
        txtInternalThawedPath.Location = New Point(968, 179)
        txtInternalThawedPath.Name = "txtInternalThawedPath"
        txtInternalThawedPath.Size = New Size(252, 27)
        txtInternalThawedPath.TabIndex = 36
        txtInternalThawedPath.Text = "$SPLUNK_DB/internaldb/thaweddb"
        ' 
        ' txtInternalColdPath
        ' 
        txtInternalColdPath.Location = New Point(707, 179)
        txtInternalColdPath.Name = "txtInternalColdPath"
        txtInternalColdPath.Size = New Size(240, 27)
        txtInternalColdPath.TabIndex = 35
        txtInternalColdPath.Text = "volume:primary/internaldb/colddb"
        ' 
        ' txtInternalHomePath
        ' 
        txtInternalHomePath.Location = New Point(476, 179)
        txtInternalHomePath.Name = "txtInternalHomePath"
        txtInternalHomePath.Size = New Size(215, 27)
        txtInternalHomePath.TabIndex = 34
        txtInternalHomePath.Text = "volume:primary/internaldb/db"
        ' 
        ' txtInternalIndex
        ' 
        txtInternalIndex.Location = New Point(308, 179)
        txtInternalIndex.Name = "txtInternalIndex"
        txtInternalIndex.Size = New Size(156, 27)
        txtInternalIndex.TabIndex = 33
        txtInternalIndex.Text = "_internal"
        ' 
        ' txtSummaryThawedPath
        ' 
        txtSummaryThawedPath.Location = New Point(968, 135)
        txtSummaryThawedPath.Name = "txtSummaryThawedPath"
        txtSummaryThawedPath.Size = New Size(252, 27)
        txtSummaryThawedPath.TabIndex = 32
        txtSummaryThawedPath.Text = "$SPLUNK_DB/summarydb/thaweddb"
        ' 
        ' txtSummaryColdPath
        ' 
        txtSummaryColdPath.Location = New Point(707, 135)
        txtSummaryColdPath.Name = "txtSummaryColdPath"
        txtSummaryColdPath.Size = New Size(240, 27)
        txtSummaryColdPath.TabIndex = 31
        txtSummaryColdPath.Text = "volume:primary/summarydb/colddb"
        ' 
        ' txtSummaryHomePath
        ' 
        txtSummaryHomePath.Location = New Point(476, 135)
        txtSummaryHomePath.Name = "txtSummaryHomePath"
        txtSummaryHomePath.Size = New Size(215, 27)
        txtSummaryHomePath.TabIndex = 30
        txtSummaryHomePath.Text = "volume:primary/summarydb/db"
        ' 
        ' txtSummaryIndex
        ' 
        txtSummaryIndex.Location = New Point(308, 135)
        txtSummaryIndex.Name = "txtSummaryIndex"
        txtSummaryIndex.Size = New Size(156, 27)
        txtSummaryIndex.TabIndex = 29
        txtSummaryIndex.Text = "summary"
        ' 
        ' txtHistoryThawedPath
        ' 
        txtHistoryThawedPath.Location = New Point(968, 91)
        txtHistoryThawedPath.Name = "txtHistoryThawedPath"
        txtHistoryThawedPath.Size = New Size(252, 27)
        txtHistoryThawedPath.TabIndex = 28
        txtHistoryThawedPath.Text = "$SPLUNK_DB/historydb/thaweddb"
        ' 
        ' txtHistoryColdPath
        ' 
        txtHistoryColdPath.Location = New Point(707, 91)
        txtHistoryColdPath.Name = "txtHistoryColdPath"
        txtHistoryColdPath.Size = New Size(240, 27)
        txtHistoryColdPath.TabIndex = 27
        txtHistoryColdPath.Text = "volume:primary/historydb/colddb"
        ' 
        ' txtHistoryHomePath
        ' 
        txtHistoryHomePath.Location = New Point(476, 91)
        txtHistoryHomePath.Name = "txtHistoryHomePath"
        txtHistoryHomePath.Size = New Size(215, 27)
        txtHistoryHomePath.TabIndex = 26
        txtHistoryHomePath.Text = "volume:primary/historydb/db"
        ' 
        ' txtHistoryIndex
        ' 
        txtHistoryIndex.Location = New Point(308, 91)
        txtHistoryIndex.Name = "txtHistoryIndex"
        txtHistoryIndex.Size = New Size(156, 27)
        txtHistoryIndex.TabIndex = 25
        txtHistoryIndex.Text = "history"
        ' 
        ' txtMainThawedPath
        ' 
        txtMainThawedPath.Location = New Point(968, 45)
        txtMainThawedPath.Name = "txtMainThawedPath"
        txtMainThawedPath.Size = New Size(252, 27)
        txtMainThawedPath.TabIndex = 24
        txtMainThawedPath.Text = "$SPLUNK_DB/maindb/thaweddb"
        ' 
        ' txtMainColdPath
        ' 
        txtMainColdPath.Location = New Point(707, 45)
        txtMainColdPath.Name = "txtMainColdPath"
        txtMainColdPath.Size = New Size(240, 27)
        txtMainColdPath.TabIndex = 23
        txtMainColdPath.Text = "volume:primary/maindb/colddb"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(1030, 22)
        Label12.Name = "Label12"
        Label12.Size = New Size(93, 20)
        Label12.TabIndex = 22
        Label12.Text = "Thawed Path"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(769, 22)
        Label11.Name = "Label11"
        Label11.Size = New Size(72, 20)
        Label11.TabIndex = 20
        Label11.Text = "Cold Path"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(515, 22)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 20)
        Label10.TabIndex = 18
        Label10.Text = "Home Path"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(369, 22)
        Label9.Name = "Label9"
        Label9.Size = New Size(45, 20)
        Label9.TabIndex = 17
        Label9.Text = "Index"
        ' 
        ' txtMainHomePath
        ' 
        txtMainHomePath.Location = New Point(476, 45)
        txtMainHomePath.Name = "txtMainHomePath"
        txtMainHomePath.Size = New Size(215, 27)
        txtMainHomePath.TabIndex = 16
        txtMainHomePath.Text = "volume:primary/maindb/db"
        ' 
        ' txtMainIndex
        ' 
        txtMainIndex.Location = New Point(308, 45)
        txtMainIndex.Name = "txtMainIndex"
        txtMainIndex.Size = New Size(156, 27)
        txtMainIndex.TabIndex = 15
        txtMainIndex.Text = "main"
        ' 
        ' txtMaxMB
        ' 
        txtMaxMB.Location = New Point(28, 471)
        txtMaxMB.Name = "txtMaxMB"
        txtMaxMB.Size = New Size(112, 27)
        txtMaxMB.TabIndex = 14
        txtMaxMB.Text = "1024"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(28, 448)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 20)
        Label8.TabIndex = 13
        Label8.Text = "Max MB"
        ' 
        ' txtVolumePrimary
        ' 
        txtVolumePrimary.Location = New Point(28, 405)
        txtVolumePrimary.Name = "txtVolumePrimary"
        txtVolumePrimary.Size = New Size(264, 27)
        txtVolumePrimary.TabIndex = 12
        txtVolumePrimary.Text = "/opt/splunk/var/lib/splunk"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(88, 382)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 20)
        Label7.TabIndex = 11
        Label7.Text = "Volume:Primary"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(107, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 20)
        Label6.TabIndex = 10
        Label6.Text = "Default Indexes"
        ' 
        ' lstDefaultIndexes
        ' 
        lstDefaultIndexes.FormattingEnabled = True
        lstDefaultIndexes.ItemHeight = 20
        lstDefaultIndexes.Location = New Point(28, 45)
        lstDefaultIndexes.Name = "lstDefaultIndexes"
        lstDefaultIndexes.Size = New Size(264, 324)
        lstDefaultIndexes.TabIndex = 9
        ' 
        ' TabPage7
        ' 
        TabPage7.Controls.Add(chkSetUpClusterIndexing)
        TabPage7.Controls.Add(txtSearchFactor)
        TabPage7.Controls.Add(txtReplicationFactor)
        TabPage7.Controls.Add(Label19)
        TabPage7.Controls.Add(Label18)
        TabPage7.Controls.Add(txtSymmKeyForIndexerDiscovery)
        TabPage7.Controls.Add(txtSymmKeyForCluster)
        TabPage7.Controls.Add(txtClusterLabel)
        TabPage7.Controls.Add(Label17)
        TabPage7.Controls.Add(Label16)
        TabPage7.Controls.Add(Label15)
        TabPage7.Location = New Point(4, 29)
        TabPage7.Name = "TabPage7"
        TabPage7.Padding = New Padding(3)
        TabPage7.Size = New Size(1433, 574)
        TabPage7.TabIndex = 6
        TabPage7.Text = "Cluster Index"
        TabPage7.UseVisualStyleBackColor = True
        ' 
        ' chkSetUpClusterIndexing
        ' 
        chkSetUpClusterIndexing.AutoSize = True
        chkSetUpClusterIndexing.Checked = True
        chkSetUpClusterIndexing.CheckState = CheckState.Checked
        chkSetUpClusterIndexing.Location = New Point(30, 13)
        chkSetUpClusterIndexing.Name = "chkSetUpClusterIndexing"
        chkSetUpClusterIndexing.Size = New Size(179, 24)
        chkSetUpClusterIndexing.TabIndex = 10
        chkSetUpClusterIndexing.Text = "Setup Index Clustering"
        chkSetUpClusterIndexing.UseVisualStyleBackColor = True
        ' 
        ' txtSearchFactor
        ' 
        txtSearchFactor.Location = New Point(67, 242)
        txtSearchFactor.Name = "txtSearchFactor"
        txtSearchFactor.Size = New Size(81, 27)
        txtSearchFactor.TabIndex = 9
        txtSearchFactor.Text = "2"
        ' 
        ' txtReplicationFactor
        ' 
        txtReplicationFactor.Location = New Point(67, 160)
        txtReplicationFactor.Name = "txtReplicationFactor"
        txtReplicationFactor.Size = New Size(81, 27)
        txtReplicationFactor.TabIndex = 8
        txtReplicationFactor.Text = "3"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(54, 208)
        Label19.Name = "Label19"
        Label19.Size = New Size(97, 20)
        Label19.TabIndex = 7
        Label19.Text = "Search Factor"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(36, 126)
        Label18.Name = "Label18"
        Label18.Size = New Size(128, 20)
        Label18.TabIndex = 6
        Label18.Text = "Replication Factor"
        ' 
        ' txtSymmKeyForIndexerDiscovery
        ' 
        txtSymmKeyForIndexerDiscovery.Location = New Point(530, 181)
        txtSymmKeyForIndexerDiscovery.Name = "txtSymmKeyForIndexerDiscovery"
        txtSymmKeyForIndexerDiscovery.Size = New Size(251, 27)
        txtSymmKeyForIndexerDiscovery.TabIndex = 5
        txtSymmKeyForIndexerDiscovery.Text = "YourOwnKey"
        ' 
        ' txtSymmKeyForCluster
        ' 
        txtSymmKeyForCluster.Location = New Point(530, 75)
        txtSymmKeyForCluster.Name = "txtSymmKeyForCluster"
        txtSymmKeyForCluster.Size = New Size(251, 27)
        txtSymmKeyForCluster.TabIndex = 4
        txtSymmKeyForCluster.Text = "MyOwnKey"
        ' 
        ' txtClusterLabel
        ' 
        txtClusterLabel.Location = New Point(36, 75)
        txtClusterLabel.Name = "txtClusterLabel"
        txtClusterLabel.Size = New Size(251, 27)
        txtClusterLabel.TabIndex = 3
        txtClusterLabel.Text = "MyLabel"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(521, 143)
        Label17.Name = "Label17"
        Label17.Size = New Size(269, 20)
        Label17.TabIndex = 2
        Label17.Text = "Pass 4 Symm Key  for Indexer Discovery"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(556, 49)
        Label16.Name = "Label16"
        Label16.Size = New Size(197, 20)
        Label16.TabIndex = 1
        Label16.Text = "Pass 4 Symm Key  for Cluster"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(54, 49)
        Label15.Name = "Label15"
        Label15.Size = New Size(94, 20)
        Label15.TabIndex = 0
        Label15.Text = "Cluster Label"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(851, 46)
        Label22.Name = "Label22"
        Label22.Size = New Size(272, 20)
        Label22.TabIndex = 6
        Label22.Text = "Time Out Session For Web UI in Minutes"
        ' 
        ' txtUITimeout
        ' 
        txtUITimeout.Location = New Point(929, 69)
        txtUITimeout.Name = "txtUITimeout"
        txtUITimeout.Size = New Size(125, 27)
        txtUITimeout.TabIndex = 5
        txtUITimeout.Text = "120"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1459, 641)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Splunk App Creator"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        TabPage6.ResumeLayout(False)
        TabPage6.PerformLayout()
        TabPage7.ResumeLayout(False)
        TabPage7.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreateApp As Button
    Friend WithEvents txtSiteName As TextBox
    Friend WithEvents chkCreateLicenseServer As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLicenseServerIP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkUseDeploymentServer As CheckBox
    Friend WithEvents txtDeploymentServer As TextBox
    Friend WithEvents btnAddIndexer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIndexerIP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstIndexerIPs As ListBox
    Friend WithEvents btnClearIndexers As Button
    Friend WithEvents chkDefineIndexers As CheckBox
    Friend WithEvents chkSetupForwarding As CheckBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents txtVolumePrimary As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lstDefaultIndexes As ListBox
    Friend WithEvents txtMaxMB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMainIndex As TextBox
    Friend WithEvents txtMainThawedPath As TextBox
    Friend WithEvents txtMainColdPath As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMainHomePath As TextBox
    Friend WithEvents txtFishBucketThawedPath As TextBox
    Friend WithEvents txtFishBucketColdPath As TextBox
    Friend WithEvents txtFishBucketHomePath As TextBox
    Friend WithEvents txtFishbucketIndex As TextBox
    Friend WithEvents txtAuditThawedPath As TextBox
    Friend WithEvents txtAuditColdPath As TextBox
    Friend WithEvents txtAuditHomePath As TextBox
    Friend WithEvents txtAuditIndex As TextBox
    Friend WithEvents txtTelemetryThawedPath As TextBox
    Friend WithEvents txtTelemetryColdPath As TextBox
    Friend WithEvents txtTelemetryHomePath As TextBox
    Friend WithEvents txtTelemetryIndex As TextBox
    Friend WithEvents txtIntrospectionThawedPath As TextBox
    Friend WithEvents txtIntrospectionColdPath As TextBox
    Friend WithEvents txtIntrospectionHomePath As TextBox
    Friend WithEvents txtIntrospectionIndex As TextBox
    Friend WithEvents txtInternalThawedPath As TextBox
    Friend WithEvents txtInternalColdPath As TextBox
    Friend WithEvents txtInternalHomePath As TextBox
    Friend WithEvents txtInternalIndex As TextBox
    Friend WithEvents txtSummaryThawedPath As TextBox
    Friend WithEvents txtSummaryColdPath As TextBox
    Friend WithEvents txtSummaryHomePath As TextBox
    Friend WithEvents txtSummaryIndex As TextBox
    Friend WithEvents txtHistoryThawedPath As TextBox
    Friend WithEvents txtHistoryColdPath As TextBox
    Friend WithEvents txtHistoryHomePath As TextBox
    Friend WithEvents txtHistoryIndex As TextBox
    Friend WithEvents txtMainMB As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTelemetryMB As TextBox
    Friend WithEvents txtIntrospectionMB As TextBox
    Friend WithEvents txtInternalMB As TextBox
    Friend WithEvents txtSummaryMB As TextBox
    Friend WithEvents txtHistoryMB As TextBox
    Friend WithEvents txtFishBucketMB As TextBox
    Friend WithEvents txtAuditMB As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDeployLocation As TextBox
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSymmKeyForCluster As TextBox
    Friend WithEvents txtClusterLabel As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtSymmKeyForIndexerDiscovery As TextBox
    Friend WithEvents txtSearchFactor As TextBox
    Friend WithEvents txtReplicationFactor As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents chkSetUpClusterIndexing As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtForwardingKBPS As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtPhoneHomeInterval As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtUITimeout As TextBox
End Class
