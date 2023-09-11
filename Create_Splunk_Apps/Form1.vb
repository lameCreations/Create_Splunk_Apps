Imports System.IO
Imports System.Reflection.Metadata
Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub btnCreateApp_Click(sender As Object, e As EventArgs) Handles btnCreateApp.Click
        Dim tempDirectory As String = ""
        tempDirectory = txtDeployLocation.Text + txtSiteName.Text
        'tempDirectory = "C:\Temp\" + txtSiteName.Text
        My.Computer.FileSystem.CreateDirectory(tempDirectory)

        If chkCreateLicenseServer.Checked = True Then
            CreateLicenseServer(tempDirectory)
            CreateMainLicenseServer(tempDirectory)
        End If
        If chkUseDeploymentServer.Checked = True Then
            CreateDeploymentServer(tempDirectory)
        End If
        If chkDefineIndexers.Checked = True Then

        End If
        If chkSetupForwarding.Checked = True Then
            CreateForwardingApp(tempDirectory)
        End If
        CreateIndexer_IndexerApp(tempDirectory)
        CreateNonIndexer_IndexerApp(tempDirectory)

        CreateGUISettings(tempDirectory)
        CreateNonGuiSettings(tempDirectory)



        If chkSetUpClusterIndexing.Checked = True Then
            CreateClusterMaster(tempDirectory)
            CreateClusterSlave(tempDirectory)
            CreateClusterSearchHead(tempDirectory)
        Else
            CreateDistSearchApp(tempDirectory)
        End If

        WriteHelpDocument()

        MsgBox("Successfully created New App")



    End Sub

    Public Sub CreateClusterSearchHead(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\ClusterSearchHead"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        WriteClusterMasterSearchHead("ClusterSearchHead")

        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)
    End Sub

    Public Sub CreateClusterMaster(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\ClusterMaster"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        WriteClusterMasterIndexFile("ClusterMaster")

        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)
    End Sub
    Public Sub CreateClusterSlave(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\ClusterClient"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        WriteClusterClientIndexFle("ClusterClient")

        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)
    End Sub

    Public Sub CreateDistSearchApp(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\DistributedSearch"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        WriteDistributedSearch(localFolder)

        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)
    End Sub

    Public Sub CreateGUISettings(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\GUI_Settings"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        WriteWebGuiConf(localFolder)

        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)
    End Sub

    Public Sub CreateNonGuiSettings(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\NonGUI_Settings"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        WriteWebNonGuiConf(localFolder)

        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)
    End Sub


    Public Sub CreateIndexer_IndexerApp(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\Indexer_IndexSettings"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        WriteServerConf_Indexer(localFolder)
        WriteInputsConf(localFolder)

        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)
    End Sub

    Public Sub CreateNonIndexer_IndexerApp(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\NonIndexer_IndexSettings"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        WriteServerConf_NonIndexer(localFolder)

        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)
    End Sub

    Public Sub CreateForwardingApp(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\all_forwarder_outputs"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        WriteLimitFile(localFolder)
        WriteOutputFile(localFolder)
        'app, limit, outputs

        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)
    End Sub
    Public Sub CreateDeploymentServer(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\deployment_client"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        CreateDeploymentClientConf(localFolder, txtDeploymentServer.Text)

        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)
    End Sub


    Public Sub CreateLicenseServer(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\license_client"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        WriteLicenseClientFile(localFolder, txtLicenseServerIP.Text)
        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)

    End Sub

    Public Sub CreateMainLicenseServer(ByVal tempDirectory As String)
        Dim mainFolder As String = tempDirectory + "\license_server"
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim localFolder As String = mainFolder + "\local"
        My.Computer.FileSystem.CreateDirectory(localFolder)
        WriteAppFile(localFolder)
        WriteLicenseServerFile(localFolder, txtLicenseServerIP.Text)
        Dim metaFolder As String = mainFolder + "\meta"
        My.Computer.FileSystem.CreateDirectory(metaFolder)
        WriteMetaFile(metaFolder)

    End Sub

    Public Sub WriteLimitFile(ByVal limitFolder As String)
        Dim file As System.IO.StreamWriter
        Dim limitFile As String = limitFolder + "\limits.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(limitFile, True)
        file.WriteLine("[thruput]")
        file.WriteLine("maxKBps = " + txtForwardingKBPS.Text)

        file.Close()
    End Sub

    Public Sub WriteOutputFile(ByVal outputFolder As String)
        Dim file As System.IO.StreamWriter
        Dim outputFile As String = outputFolder + "\outputs.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(outputFile, True)
        file.WriteLine("[tcpout]")
        file.WriteLine("defaultGroup = primary_indexers")
        file.WriteLine("")

        file.WriteLine("[tcpout:primary_indexers]")
        file.WriteLine("defaultGroup = primary_indexers")

        Dim SetUpIndexerString As String = ""
        Dim x As Integer = 0
        For Each item In lstIndexerIPs.Items
            If x = 0 Then
                SetUpIndexerString = item + ":9997"
            Else
                SetUpIndexerString = SetUpIndexerString + ", " + item + ":9997"
            End If
            x += 1

        Next

        Dim tempListOfIndexers As String = "server" + " = " + SetUpIndexerString
        file.WriteLine(tempListOfIndexers)
        file.Close()
    End Sub

    Public Sub WriteDistributedSearch(ByVal localFolder As String)
        Dim file As System.IO.StreamWriter
        Dim DistSearchFile As String = localFolder + "\distsearch.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(DistSearchFile, True)
        file.WriteLine("[distributedSearch]")


        Dim distSearchPeers As String = ""
        Dim x As Integer = 0
        For Each item In lstIndexerIPs.Items
            If x = 0 Then
                distSearchPeers = "https://" + item + ":8089"
            Else
                distSearchPeers = distSearchPeers + ", " + "https://" + item + ":8089"
            End If
            x += 1

        Next

        Dim tempListOfIndexers As String = "servers" + " = " + distSearchPeers
        file.WriteLine(tempListOfIndexers)
        file.Close()
    End Sub

    Public Sub WriteMetaFile(ByVal metaFolder As String)
        Dim file As System.IO.StreamWriter
        Dim metaFile As String = metaFolder + "\local.meta"
        file = My.Computer.FileSystem.OpenTextFileWriter(metaFile, True)
        file.WriteLine("[]")
        file.WriteLine("access = read : [ * ], write : [ admin ]")
        file.WriteLine("export = system")

        file.Close()
    End Sub

    Public Sub WriteInputsConf(ByVal serverFolder As String)
        Dim file As System.IO.StreamWriter
        Dim serverFile As String = serverFolder + "\inputs.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(serverFile, True)
        file.WriteLine("[splunktcp://9997]")
        file.WriteLine("disabled = 0")

        file.Close()
    End Sub

    Public Sub WriteLicenseServerFile(ByVal serverFolder As String, ByVal deploymentServer As String)
        Dim file As System.IO.StreamWriter
        Dim serverFile As String = serverFolder + "\server.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(serverFile, True)
        file.WriteLine("[license]")
        file.WriteLine("active_group = Enterprise")
        file.WriteLine("")

        file.WriteLine("[lmpool:auto_generated_pool_enterprise]")
        file.WriteLine("description = auto_generated_pool_enterprise")
        file.WriteLine("peers = *")
        file.WriteLine("quota = MAX")
        file.WriteLine("stack_id = enterprise")

        file.Close()

    End Sub

    Public Sub WriteLicenseClientFile(ByVal serverFolder As String, ByVal deploymentServer As String)
        Dim file As System.IO.StreamWriter
        Dim serverFile As String = serverFolder + "\server.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(serverFile, True)
        file.WriteLine("[license]")
        Dim master_uri As String = "master_uri = https://" + deploymentServer + ":8089"
        file.WriteLine(master_uri)

        file.Close()

    End Sub

    Public Sub CreateDeploymentClientConf(ByVal deploymentFolder As String, ByVal deploymentServerIp As String)
        Dim file As System.IO.StreamWriter
        Dim serverFile As String = deploymentFolder + "\deploymentclient.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(serverFile, True)
        file.WriteLine("[deployment-client]")
        'file.WriteLine("phoneHomeIntervalInSecs = " + txtPhoneHomeInterval.Text)
        file.WriteLine("")
        file.WriteLine("[target-broker:deploymentServer]")

        Dim master_uri As String = "targetUri = " + deploymentServerIp + ":8089"
        file.WriteLine(master_uri)

        file.Close()

    End Sub

    Public Sub WriteWebGuiConf(ByVal filePath As String)
        Dim file As System.IO.StreamWriter
        Dim appFile As String = filePath + "\web.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(appFile, True)
        file.WriteLine("[settings]")
        file.WriteLine("enableSplunkWebSSL = true")
        file.WriteLine("startwebserver = 1")
        file.WriteLine("tools.sessions.timeout = " + txtUITimeout.Text)

        file.Close()
    End Sub

    Public Sub WriteWebNonGuiConf(ByVal filePath As String)
        Dim file As System.IO.StreamWriter
        Dim appFile As String = filePath + "\web.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(appFile, True)
        file.WriteLine("[settings]")
        file.WriteLine("enableSplunkWebSSL = true")
        file.WriteLine("startwebserver = 0")


        file.Close()
    End Sub

    Public Sub WriteAppFile(ByVal appFolder As String)
        Dim file As System.IO.StreamWriter
        Dim appFile As String = appFolder + "\app.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(appFile, True)
        file.WriteLine("[install]")
        file.WriteLine("state = enabled")
        file.WriteLine("")

        file.WriteLine("[package]")
        file.WriteLine("check_for_updates = false")
        file.WriteLine("")

        file.WriteLine("[ui]")
        file.WriteLine("is_visible = false")
        file.WriteLine("is_manageable = false")

        file.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Public Sub WriteServerConf_Indexer(ByVal tempDirectory As String)
        Dim file As System.IO.StreamWriter
        Dim serverFile As String = tempDirectory + "\indexes.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(serverFile, True)
        file.WriteLine("[default]")
        'file.WriteLine("homePath.maxDataSizeMB = " + txtMaxMB.Text)
        file.WriteLine("")

        file.WriteLine("[volume:primary]")
        file.WriteLine("path = " + txtVolumePrimary.Text)
        file.WriteLine("maxTotalDataSizeMB = " + txtMaxMB.Text)
        file.WriteLine("")

        file.WriteLine("[main]")
        file.WriteLine("homePath   = " + txtMainHomePath.Text)
        file.WriteLine("coldPath   = " + txtMainColdPath.Text)
        file.WriteLine("thawedPath = " + txtMainThawedPath.Text)
        file.WriteLine("maxTotalDataSizeMB = " + txtMainMB.Text)
        file.WriteLine("")

        file.WriteLine("[history]")
        file.WriteLine("homePath   = " + txtHistoryHomePath.Text)
        file.WriteLine("coldPath   = " + txtHistoryColdPath.Text)
        file.WriteLine("thawedPath = " + txtHistoryThawedPath.Text)
        file.WriteLine("maxTotalDataSizeMB = " + txtHistoryMB.Text)
        file.WriteLine("")

        file.WriteLine("[summary]")
        file.WriteLine("homePath   = " + txtSummaryHomePath.Text)
        file.WriteLine("coldPath   = " + txtSummaryColdPath.Text)
        file.WriteLine("thawedPath = " + txtSummaryThawedPath.Text)
        file.WriteLine("maxTotalDataSizeMB = " + txtSummaryMB.Text)
        file.WriteLine("")

        file.WriteLine("[_internal]")
        file.WriteLine("homePath   = " + txtInternalHomePath.Text)
        file.WriteLine("coldPath   = " + txtInternalColdPath.Text)
        file.WriteLine("thawedPath = " + txtInternalThawedPath.Text)
        file.WriteLine("maxTotalDataSizeMB = " + txtInternalMB.Text)
        file.WriteLine("")

        file.WriteLine("[_introspection]")
        file.WriteLine("homePath   = " + txtIntrospectionHomePath.Text)
        file.WriteLine("coldPath   = " + txtIntrospectionColdPath.Text)
        file.WriteLine("thawedPath = " + txtIntrospectionThawedPath.Text)
        file.WriteLine("maxTotalDataSizeMB = " + txtIntrospectionMB.Text)
        file.WriteLine("")

        file.WriteLine("[_telemetry]")
        file.WriteLine("homePath   = " + txtTelemetryHomePath.Text)
        file.WriteLine("coldPath   = " + txtTelemetryColdPath.Text)
        file.WriteLine("thawedPath = " + txtTelemetryThawedPath.Text)
        file.WriteLine("maxTotalDataSizeMB = " + txtTelemetryMB.Text)
        file.WriteLine("")

        file.WriteLine("[_audit]")
        file.WriteLine("homePath   = " + txtAuditHomePath.Text)
        file.WriteLine("coldPath   = " + txtAuditColdPath.Text)
        file.WriteLine("thawedPath = " + txtAuditThawedPath.Text)
        file.WriteLine("maxTotalDataSizeMB = " + txtAuditMB.Text)
        file.WriteLine("")

        file.WriteLine("[_thefishbucket]")
        file.WriteLine("homePath   = " + txtFishBucketHomePath.Text)
        file.WriteLine("coldPath   = " + txtFishBucketColdPath.Text)
        file.WriteLine("thawedPath = " + txtFishBucketThawedPath.Text)
        file.WriteLine("maxTotalDataSizeMB = " + txtFishBucketMB.Text)
        file.WriteLine("")

        file.Close()
    End Sub
    Public Sub WriteServerConf_NonIndexer(ByVal tempDirectory As String)
        Dim file As System.IO.StreamWriter
        Dim serverFile As String = tempDirectory + "\indexes.conf"
        file = My.Computer.FileSystem.OpenTextFileWriter(serverFile, True)
        file.WriteLine("[default]")
        'file.WriteLine("homePath.maxDataSizeMB = " + txtMaxMB.Text)
        file.WriteLine("")

        file.WriteLine("[volume:primary]")
        file.WriteLine("path = " + txtVolumePrimary.Text)
        'file.WriteLine("maxVolumeDataSizeMB = " + txtMaxMB.Text)
        file.WriteLine("")

        file.WriteLine("[main]")
        file.WriteLine("homePath   = " + txtMainHomePath.Text)
        file.WriteLine("coldPath   = " + txtMainColdPath.Text)
        file.WriteLine("thawedPath = " + txtMainThawedPath.Text)
        'file.WriteLine("maxVolumeDataSizeMB = " + txtMainMB.Text)
        file.WriteLine("")

        file.WriteLine("[history]")
        file.WriteLine("homePath   = " + txtHistoryHomePath.Text)
        file.WriteLine("coldPath   = " + txtHistoryColdPath.Text)
        file.WriteLine("thawedPath = " + txtHistoryThawedPath.Text)
        'file.WriteLine("maxVolumeDataSizeMB = " + txtHistoryMB.Text)
        file.WriteLine("")

        file.WriteLine("[summary]")
        file.WriteLine("homePath   = " + txtSummaryHomePath.Text)
        file.WriteLine("coldPath   = " + txtSummaryColdPath.Text)
        file.WriteLine("thawedPath = " + txtSummaryThawedPath.Text)
        'file.WriteLine("maxVolumeDataSizeMB = " + txtSummaryMB.Text)
        file.WriteLine("")

        file.WriteLine("[_internal]")
        file.WriteLine("homePath   = " + txtInternalHomePath.Text)
        file.WriteLine("coldPath   = " + txtInternalColdPath.Text)
        file.WriteLine("thawedPath = " + txtInternalThawedPath.Text)
        'file.WriteLine("maxVolumeDataSizeMB = " + txtInternalMB.Text)
        file.WriteLine("")

        file.WriteLine("[_introspection]")
        file.WriteLine("homePath   = " + txtIntrospectionHomePath.Text)
        file.WriteLine("coldPath   = " + txtIntrospectionColdPath.Text)
        file.WriteLine("thawedPath = " + txtIntrospectionThawedPath.Text)
        'file.WriteLine("maxVolumeDataSizeMB = " + txtIntrospectionMB.Text)
        file.WriteLine("")

        file.WriteLine("[_telemetry]")
        file.WriteLine("homePath   = " + txtTelemetryHomePath.Text)
        file.WriteLine("coldPath   = " + txtTelemetryColdPath.Text)
        file.WriteLine("thawedPath = " + txtTelemetryThawedPath.Text)
        'file.WriteLine("maxVolumeDataSizeMB = " + txtTelemetryMB.Text)
        file.WriteLine("")

        file.WriteLine("[_audit]")
        file.WriteLine("homePath   = " + txtAuditHomePath.Text)
        file.WriteLine("coldPath   = " + txtAuditColdPath.Text)
        file.WriteLine("thawedPath = " + txtAuditThawedPath.Text)
        'file.WriteLine("maxVolumeDataSizeMB = " + txtAuditMB.Text)
        file.WriteLine("")

        file.WriteLine("[_thefishbucket]")
        file.WriteLine("homePath   = " + txtFishBucketHomePath.Text)
        file.WriteLine("coldPath   = " + txtFishBucketColdPath.Text)
        file.WriteLine("thawedPath = " + txtFishBucketThawedPath.Text)
        'file.WriteLine("maxVolumeDataSizeMB = " + txtFishBucketMB.Text)
        file.WriteLine("")

        file.Close()
    End Sub
    Private Sub btnAddIndexer_Click(sender As Object, e As EventArgs) Handles btnAddIndexer.Click
        lstIndexerIPs.Items.Add(txtIndexerIP.Text)
        txtIndexerIP.Text = ""
    End Sub

    Private Sub btnClearIndexers_Click(sender As Object, e As EventArgs) Handles btnClearIndexers.Click
        lstIndexerIPs.Items.Clear()
    End Sub

    Public Sub WriteClusterMasterSearchHead(ByVal appName As String)
        Dim mainFolder As String = txtDeployLocation.Text
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim file As System.IO.StreamWriter
        Dim serverFile As String = mainFolder + txtSiteName.Text + "\" + appName + "\local\" + "server.conf"

        file = My.Computer.FileSystem.OpenTextFileWriter(serverFile, True)
        file.WriteLine("[clustering]")
        file.WriteLine("mode = searchhead")
        file.WriteLine("master_uri = https://" + txtClusterMasterIP.Text + ":8089")
        file.WriteLine("pass4SymmKey = " + txtSymmKeyForCluster.Text)
        file.Close()
    End Sub
    Public Sub WriteClusterMasterIndexFile(ByVal appName As String)
        Dim mainFolder As String = txtDeployLocation.Text
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim file As System.IO.StreamWriter
        Dim serverFile As String = mainFolder + txtSiteName.Text + "\" + appName + "\local\" + "server.conf"

        file = My.Computer.FileSystem.OpenTextFileWriter(serverFile, True)
        file.WriteLine("[clustering]")
        file.WriteLine("cluster_label = " + txtClusterLabel.Text)
        file.WriteLine("mode = manager")
        file.WriteLine("pass4SymmKey = " + txtSymmKeyForCluster.Text)
        file.WriteLine("search_factor = " + txtSearchFactor.Text)
        file.WriteLine("replication_factor = " + txtReplicationFactor.Text)

        file.Close()
    End Sub

    Public Sub WriteClusterClientIndexFle(ByVal appName As String)
        Dim mainFolder As String = txtDeployLocation.Text
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim file As System.IO.StreamWriter
        Dim serverFile As String = mainFolder + txtSiteName.Text + "\" + appName + "\local\" + "server.conf"

        file = My.Computer.FileSystem.OpenTextFileWriter(serverFile, True)
        file.WriteLine("[clustering]")
        file.WriteLine("master_uri = https://" + txtClusterMasterIP.Text + ":8089")
        file.WriteLine("mode = peer")
        file.WriteLine("pass4SymmKey = " + txtSymmKeyForCluster.Text)
        file.WriteLine("")
        file.WriteLine("[replication_port://8080]")

        file.Close()
    End Sub



    Public Sub WriteHelpDocument()
        Dim mainFolder As String = txtDeployLocation.Text
        My.Computer.FileSystem.CreateDirectory(mainFolder)

        Dim file As System.IO.StreamWriter
        Dim serverFile As String = mainFolder + txtSiteName.Text + "\" + "help.txt"

        file = My.Computer.FileSystem.OpenTextFileWriter(serverFile, True)
        file.WriteLine("Instructions For Installing Splunk Apps")
        file.WriteLine("")
        ' ##################
        ' #### Indexer #####
        ' ##################
        file.WriteLine("Apps to be installed on Indexer")
        file.WriteLine("Indexer_IndexSettings")
        If chkCreateLicenseServer.Checked = True Then
            file.WriteLine("license_client")
        End If
        If chkSetUpClusterIndexing.Checked = True Then
            file.WriteLine("ClusterClient")
        End If
        file.WriteLine("NonGUI_Settings")
        file.WriteLine("")

        '###################
        '### Search Head ###
        '###################
        file.WriteLine("Apps to be installed on Search Head")
        If chkSetupForwarding.Checked = True Then
            file.WriteLine("all_forwarder_outputs")
        End If
        If chkUseDeploymentServer.Checked = True Then
            file.WriteLine("deployment_client")
        End If
        If chkSetUpClusterIndexing.Checked = True Then
            file.WriteLine("ClusterSearchHead")
        Else
            file.WriteLine("DistributedSearch")
        End If

        file.WriteLine("GuiSettings")
        If chkCreateLicenseServer.Checked = True Then
            file.WriteLine("license_client")
        End If
        file.WriteLine("NonIndexer_IndexSettings")
        file.WriteLine("")

        '########################
        '### Cluster Indexing ###
        '########################
        If chkSetUpClusterIndexing.Checked = True Then
            file.WriteLine("Apps to be installed on Cluster Master")
            If chkCreateLicenseServer.Checked = True Then
                file.WriteLine("license_client")
            End If
            file.WriteLine("GuiSettings")
            If chkSetUpClusterIndexing.Checked = True Then
                file.WriteLine("ClusterMaster")
            End If

            file.WriteLine("")
        End If
        '######################
        '### License Server ###
        '######################

        If chkCreateLicenseServer.Checked = True Then
            file.WriteLine("Apps to be installed on License Server")
            If chkCreateLicenseServer.Checked = True Then
                file.WriteLine("license_server")
            End If
            file.WriteLine("GuiSettings")
            file.WriteLine("")
        End If

        file.WriteLine("Install Instructions")
        file.WriteLine("1. Start Up License Server and Add License")
        file.WriteLine("2. Start Up Master Node ")
        file.WriteLine("3. Start Up Indexers")
        file.WriteLine("4. Start Up Search Heads")
        file.WriteLine("")


        file.Close()
    End Sub


End Class
