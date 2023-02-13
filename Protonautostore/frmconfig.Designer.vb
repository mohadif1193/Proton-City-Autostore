<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconfig))
        Me.pbReport = New System.Windows.Forms.PictureBox()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.pbOrder = New System.Windows.Forms.PictureBox()
        Me.pbInvoice = New System.Windows.Forms.PictureBox()
        Me.pbClient = New System.Windows.Forms.PictureBox()
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbReport
        '
        Me.pbReport.Image = CType(resources.GetObject("pbReport.Image"), System.Drawing.Image)
        Me.pbReport.Location = New System.Drawing.Point(527, 214)
        Me.pbReport.Name = "pbReport"
        Me.pbReport.Size = New System.Drawing.Size(209, 110)
        Me.pbReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbReport.TabIndex = 5
        Me.pbReport.TabStop = False
        '
        'pbUser
        '
        Me.pbUser.Image = CType(resources.GetObject("pbUser.Image"), System.Drawing.Image)
        Me.pbUser.Location = New System.Drawing.Point(295, 214)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(209, 110)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUser.TabIndex = 4
        Me.pbUser.TabStop = False
        '
        'pbProfile
        '
        Me.pbProfile.Image = CType(resources.GetObject("pbProfile.Image"), System.Drawing.Image)
        Me.pbProfile.Location = New System.Drawing.Point(62, 214)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(209, 110)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProfile.TabIndex = 3
        Me.pbProfile.TabStop = False
        '
        'pbOrder
        '
        Me.pbOrder.Image = CType(resources.GetObject("pbOrder.Image"), System.Drawing.Image)
        Me.pbOrder.Location = New System.Drawing.Point(527, 67)
        Me.pbOrder.Name = "pbOrder"
        Me.pbOrder.Size = New System.Drawing.Size(209, 110)
        Me.pbOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbOrder.TabIndex = 2
        Me.pbOrder.TabStop = False
        '
        'pbInvoice
        '
        Me.pbInvoice.Image = CType(resources.GetObject("pbInvoice.Image"), System.Drawing.Image)
        Me.pbInvoice.Location = New System.Drawing.Point(295, 67)
        Me.pbInvoice.Name = "pbInvoice"
        Me.pbInvoice.Size = New System.Drawing.Size(209, 110)
        Me.pbInvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbInvoice.TabIndex = 1
        Me.pbInvoice.TabStop = False
        '
        'pbClient
        '
        Me.pbClient.Image = CType(resources.GetObject("pbClient.Image"), System.Drawing.Image)
        Me.pbClient.Location = New System.Drawing.Point(62, 67)
        Me.pbClient.Name = "pbClient"
        Me.pbClient.Size = New System.Drawing.Size(209, 110)
        Me.pbClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbClient.TabIndex = 0
        Me.pbClient.TabStop = False
        '
        'frmconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 396)
        Me.Controls.Add(Me.pbReport)
        Me.Controls.Add(Me.pbUser)
        Me.Controls.Add(Me.pbProfile)
        Me.Controls.Add(Me.pbOrder)
        Me.Controls.Add(Me.pbInvoice)
        Me.Controls.Add(Me.pbClient)
        Me.Name = "frmconfig"
        Me.Text = "frmconfig"
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbClient As PictureBox
    Friend WithEvents pbInvoice As PictureBox
    Friend WithEvents pbOrder As PictureBox
    Friend WithEvents pbReport As PictureBox
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents pbProfile As PictureBox
End Class
