<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoctorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 487)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem, Me.DoctorToolStripMenuItem, Me.LabToolStripMenuItem, Me.LabResultToolStripMenuItem, Me.StaffToolStripMenuItem, Me.RoomDetailsToolStripMenuItem, Me.ContactUsToolStripMenuItem, Me.AppointmentToolStripMenuItem, Me.ViewDetailsToolStripMenuItem, Me.BillingToolStripMenuItem, Me.CreateNewToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(196, 485)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'DoctorToolStripMenuItem
        '
        Me.DoctorToolStripMenuItem.Name = "DoctorToolStripMenuItem"
        Me.DoctorToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.DoctorToolStripMenuItem.Text = "Doctor"
        '
        'LabToolStripMenuItem
        '
        Me.LabToolStripMenuItem.Name = "LabToolStripMenuItem"
        Me.LabToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.LabToolStripMenuItem.Text = "Lab"
        '
        'LabResultToolStripMenuItem
        '
        Me.LabResultToolStripMenuItem.Name = "LabResultToolStripMenuItem"
        Me.LabResultToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.LabResultToolStripMenuItem.Text = "Lab Result"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'RoomDetailsToolStripMenuItem
        '
        Me.RoomDetailsToolStripMenuItem.Name = "RoomDetailsToolStripMenuItem"
        Me.RoomDetailsToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.RoomDetailsToolStripMenuItem.Text = "Room Details"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us"
        '
        'AppointmentToolStripMenuItem
        '
        Me.AppointmentToolStripMenuItem.Name = "AppointmentToolStripMenuItem"
        Me.AppointmentToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.AppointmentToolStripMenuItem.Text = "Appointment"
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoctorToolStripMenuItem1, Me.PatientToolStripMenuItem1, Me.StaffToolStripMenuItem1, Me.LabToolStripMenuItem1})
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.ViewDetailsToolStripMenuItem.Text = "View Details"
        '
        'DoctorToolStripMenuItem1
        '
        Me.DoctorToolStripMenuItem1.Name = "DoctorToolStripMenuItem1"
        Me.DoctorToolStripMenuItem1.Size = New System.Drawing.Size(172, 40)
        Me.DoctorToolStripMenuItem1.Text = "Doctor"
        '
        'PatientToolStripMenuItem1
        '
        Me.PatientToolStripMenuItem1.Name = "PatientToolStripMenuItem1"
        Me.PatientToolStripMenuItem1.Size = New System.Drawing.Size(172, 40)
        Me.PatientToolStripMenuItem1.Text = "Patient"
        '
        'StaffToolStripMenuItem1
        '
        Me.StaffToolStripMenuItem1.Name = "StaffToolStripMenuItem1"
        Me.StaffToolStripMenuItem1.Size = New System.Drawing.Size(172, 40)
        Me.StaffToolStripMenuItem1.Text = "Staff"
        '
        'LabToolStripMenuItem1
        '
        Me.LabToolStripMenuItem1.Name = "LabToolStripMenuItem1"
        Me.LabToolStripMenuItem1.Size = New System.Drawing.Size(172, 40)
        Me.LabToolStripMenuItem1.Text = "Lab"
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.BillingToolStripMenuItem.Text = "Billing"
        '
        'CreateNewToolStripMenuItem
        '
        Me.CreateNewToolStripMenuItem.Name = "CreateNewToolStripMenuItem"
        Me.CreateNewToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.CreateNewToolStripMenuItem.Text = "Create New"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(189, 40)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(198, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(703, 487)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(900, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoctorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabResultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoctorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
