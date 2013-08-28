<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnPurchasing = New System.Windows.Forms.Button()
        Me.btnSupervisor = New System.Windows.Forms.Button()
        Me.btnProduction = New System.Windows.Forms.Button()
        Me.btnLodging = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnSystem = New System.Windows.Forms.Button()
        Me.gbMain = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPOS = New System.Windows.Forms.Button()
        Me.gbMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPurchasing
        '
        Me.btnPurchasing.Image = CType(resources.GetObject("btnPurchasing.Image"), System.Drawing.Image)
        Me.btnPurchasing.Location = New System.Drawing.Point(36, 34)
        Me.btnPurchasing.Name = "btnPurchasing"
        Me.btnPurchasing.Size = New System.Drawing.Size(100, 100)
        Me.btnPurchasing.TabIndex = 0
        Me.btnPurchasing.Text = "Purchasing"
        Me.btnPurchasing.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPurchasing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPurchasing.UseVisualStyleBackColor = True
        '
        'btnSupervisor
        '
        Me.btnSupervisor.Image = CType(resources.GetObject("btnSupervisor.Image"), System.Drawing.Image)
        Me.btnSupervisor.Location = New System.Drawing.Point(142, 34)
        Me.btnSupervisor.Name = "btnSupervisor"
        Me.btnSupervisor.Size = New System.Drawing.Size(100, 100)
        Me.btnSupervisor.TabIndex = 0
        Me.btnSupervisor.Text = "Supervisor"
        Me.btnSupervisor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSupervisor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSupervisor.UseVisualStyleBackColor = True
        '
        'btnProduction
        '
        Me.btnProduction.Image = CType(resources.GetObject("btnProduction.Image"), System.Drawing.Image)
        Me.btnProduction.Location = New System.Drawing.Point(248, 34)
        Me.btnProduction.Name = "btnProduction"
        Me.btnProduction.Size = New System.Drawing.Size(100, 100)
        Me.btnProduction.TabIndex = 0
        Me.btnProduction.Text = "Production"
        Me.btnProduction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProduction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProduction.UseVisualStyleBackColor = True
        '
        'btnLodging
        '
        Me.btnLodging.Image = CType(resources.GetObject("btnLodging.Image"), System.Drawing.Image)
        Me.btnLodging.Location = New System.Drawing.Point(36, 140)
        Me.btnLodging.Name = "btnLodging"
        Me.btnLodging.Size = New System.Drawing.Size(100, 100)
        Me.btnLodging.TabIndex = 0
        Me.btnLodging.Text = "Lodging"
        Me.btnLodging.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLodging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLodging.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.Location = New System.Drawing.Point(142, 140)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(100, 100)
        Me.btnReports.TabIndex = 0
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnSystem
        '
        Me.btnSystem.Image = CType(resources.GetObject("btnSystem.Image"), System.Drawing.Image)
        Me.btnSystem.Location = New System.Drawing.Point(248, 140)
        Me.btnSystem.Name = "btnSystem"
        Me.btnSystem.Size = New System.Drawing.Size(100, 100)
        Me.btnSystem.TabIndex = 0
        Me.btnSystem.Text = "System"
        Me.btnSystem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSystem.UseVisualStyleBackColor = True
        '
        'gbMain
        '
        Me.gbMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbMain.Controls.Add(Me.btnSystem)
        Me.gbMain.Controls.Add(Me.btnReports)
        Me.gbMain.Controls.Add(Me.btnLodging)
        Me.gbMain.Controls.Add(Me.btnExit)
        Me.gbMain.Controls.Add(Me.btnPOS)
        Me.gbMain.Controls.Add(Me.btnProduction)
        Me.gbMain.Controls.Add(Me.btnSupervisor)
        Me.gbMain.Controls.Add(Me.btnPurchasing)
        Me.gbMain.Location = New System.Drawing.Point(47, 44)
        Me.gbMain.MinimumSize = New System.Drawing.Size(422, 275)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(491, 275)
        Me.gbMain.TabIndex = 1
        Me.gbMain.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(354, 140)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 100)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPOS
        '
        Me.btnPOS.Image = CType(resources.GetObject("btnPOS.Image"), System.Drawing.Image)
        Me.btnPOS.Location = New System.Drawing.Point(354, 34)
        Me.btnPOS.Name = "btnPOS"
        Me.btnPOS.Size = New System.Drawing.Size(100, 100)
        Me.btnPOS.TabIndex = 0
        Me.btnPOS.Text = "Point-Of-Sale"
        Me.btnPOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPOS.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(584, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbMain)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Central Mindanao University Food and Lodging Services"
        Me.gbMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPurchasing As System.Windows.Forms.Button
    Friend WithEvents btnSupervisor As System.Windows.Forms.Button
    Friend WithEvents btnProduction As System.Windows.Forms.Button
    Friend WithEvents btnLodging As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnSystem As System.Windows.Forms.Button
    Friend WithEvents gbMain As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPOS As System.Windows.Forms.Button

End Class
