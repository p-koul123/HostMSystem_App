Public Class Slide

    Private Sub StaffToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem2.Click
        Panel1.Controls.Clear()
        Form1.TopLevel = False
        Panel1.Controls.Add(Form1)
        Form1.Show()
    End Sub

    Private Sub AppointmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentToolStripMenuItem.Click
        Panel1.Controls.Clear()
        appointment.TopLevel = False
        Panel1.Controls.Add(appointment)
        appointment.Show()
    End Sub

    Private Sub PatientToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientToolStripMenuItem3.Click
        Panel1.Controls.Clear()
        Form3.TopLevel = False
        Panel1.Controls.Add(Form3)
        Form3.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub DoctorToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorToolStripMenuItem3.Click
        Panel1.Controls.Clear()
        Doctorin.TopLevel = False
        Panel1.Controls.Add(Doctorin)
        Doctorin.Show()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Serachstaff.TopLevel = False
        Panel1.Controls.Add(Serachstaff)
        Serachstaff.Show()
    End Sub

    Private Sub PatientToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientToolStripMenuItem2.Click
        Panel1.Controls.Clear()
        Patientin.TopLevel = False
        Panel1.Controls.Add(Patientin)
        Patientin.Show()
    End Sub

    Private Sub DoctorToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorToolStripMenuItem2.Click
        Panel1.Controls.Clear()
        DrSerach.TopLevel = False
        Panel1.Controls.Add(DrSerach)
        DrSerach.Show()
    End Sub

    Private Sub LaboratoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaboratoryToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Labtest.TopLevel = False
        Panel1.Controls.Add(Labtest)
        Labtest.Show()
    End Sub

    Private Sub LabResultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabResultToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Labresult.TopLevel = False
        Panel1.Controls.Add(Labresult)
        Labresult.Show()
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactUsToolStripMenuItem.Click
        Panel1.Controls.Clear()
        CUs.TopLevel = False
        Panel1.Controls.Add(CUs)
        CUs.Show()
    End Sub

    Private Sub DoctorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorToolStripMenuItem1.Click
        Panel1.Controls.Clear()
        Viewdr.TopLevel = False
        Panel1.Controls.Add(Viewdr)
        Viewdr.Show()
    End Sub

    Private Sub PatientToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientToolStripMenuItem1.Click
        Panel1.Controls.Clear()
        Viewpa.TopLevel = False
        Panel1.Controls.Add(Viewpa)
        Viewpa.Show()
    End Sub

    Private Sub StaffToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem1.Click
        Panel1.Controls.Clear()
        viewstff.TopLevel = False
        Panel1.Controls.Add(viewstff)
        viewstff.Show()
    End Sub

    Private Sub LaboratoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaboratoryToolStripMenuItem1.Click
        Panel1.Controls.Clear()
        Viewlab.TopLevel = False
        Panel1.Controls.Add(Viewlab)
        Viewlab.Show()
    End Sub

    Private Sub LaboratoryResultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaboratoryResultToolStripMenuItem.Click
        Panel1.Controls.Clear()
        ViewResults.TopLevel = False
        Panel1.Controls.Add(ViewResults)
        ViewResults.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Panel1.Controls.Clear()
        PatientRoom.TopLevel = False
        Panel1.Controls.Add(PatientRoom)
        PatientRoom.Show()
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        Panel1.Controls.Clear()
        RoomModify.TopLevel = False
        Panel1.Controls.Add(RoomModify)
        RoomModify.Show()
    End Sub

    Private Sub CreateNewAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewAccountToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Billing.TopLevel = False
        Panel1.Controls.Add(Billing)
        Billing.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Panel1.Controls.Clear()
        New_Acc.TopLevel = False
        Panel1.Controls.Add(New_Acc)
        New_Acc.Show()
    End Sub
End Class