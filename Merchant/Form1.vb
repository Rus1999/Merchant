Imports System.Net.Security
Imports System.Reflection

Public Class Form1

    Dim Quantities As Integer = 1
    Dim PurchaseProductStr As String = ""
    'Plant type
    Private Sub พลูฉลุ_CheckedChanged(sender As Object, e As EventArgs) Handles พลูฉลุ.CheckedChanged
        If พลูฉลุ.Checked Then
            PlantPic.Image = (My.Resources.พลูฉลุ)
        End If
    End Sub

    Private Sub เศรษฐีนำโชค_CheckedChanged(sender As Object, e As EventArgs) Handles เศรษฐีนำโชค.CheckedChanged
        If เศรษฐีนำโชค.Checked Then
            PlantPic.Image = (My.Resources.เศรษฐีนำโชค)
        End If
    End Sub

    Private Sub ออมมณี_CheckedChanged(sender As Object, e As EventArgs) Handles ออมมณี.CheckedChanged
        If ออมมณี.Checked Then
            PlantPic.Image = (My.Resources.ออมมณี)
        End If
    End Sub

    Private Sub รวยโชค_CheckedChanged(sender As Object, e As EventArgs) Handles รวยโชค.CheckedChanged
        If รวยโชค.Checked Then
            PlantPic.Image = (My.Resources.รวยโชค)
        End If
    End Sub

    Private Sub ออมทรัพย์_CheckedChanged(sender As Object, e As EventArgs) Handles ออมทรัพย์.CheckedChanged
        If ออมทรัพย์.Checked Then
            PlantPic.Image = (My.Resources.ออมทรัพย์)
        End If
    End Sub

    Private Sub เล็บครุฑด่าง_CheckedChanged(sender As Object, e As EventArgs) Handles เล็บครุฑด่าง.CheckedChanged
        If เล็บครุฑด่าง.Checked Then
            PlantPic.Image = (My.Resources.เล็บครุฑด่าง)
        End If
    End Sub

    Private Sub เพชรชมพู_CheckedChanged(sender As Object, e As EventArgs) Handles เพชรชมพู.CheckedChanged
        If เพชรชมพู.Checked Then
            PlantPic.Image = (My.Resources.เพชรชมพู)
        End If
    End Sub

    'Pot type
    Private Sub Standard_CheckedChanged(sender As Object, e As EventArgs) Handles Standard.CheckedChanged
        If Standard.Checked Then
            PotPic.Image = (My.Resources.Standard)
        End If
    End Sub

    Private Sub Plastic1_CheckedChanged(sender As Object, e As EventArgs) Handles Plastic1.CheckedChanged
        If Plastic1.Checked Then
            PotPic.Image = (My.Resources.prastic1)
        End If
    End Sub

    Private Sub Plastic2_CheckedChanged(sender As Object, e As EventArgs) Handles Plastic2.CheckedChanged
        If Plastic2.Checked Then
            PotPic.Image = (My.Resources.prastic2)
        End If
    End Sub

    Private Sub Ceramic1_CheckedChanged(sender As Object, e As EventArgs) Handles Ceramic1.CheckedChanged
        If Ceramic1.Checked Then
            PotPic.Image = (My.Resources.ceramic1)
        End If
    End Sub

    Private Sub Ceramic2_CheckedChanged(sender As Object, e As EventArgs) Handles Ceramic2.CheckedChanged
        If Ceramic2.Checked Then
            PotPic.Image = (My.Resources.ceramic2)

        End If
    End Sub

    Private Sub Ceramic3_CheckedChanged(sender As Object, e As EventArgs) Handles Ceramic3.CheckedChanged
        If Ceramic3.Checked Then
            PotPic.Image = (My.Resources.ceramic3)
        End If
    End Sub

    Private Sub Ceramic4_CheckedChanged(sender As Object, e As EventArgs) Handles Ceramic4.CheckedChanged
        If Ceramic4.Checked Then
            PotPic.Image = (My.Resources.ceramic4)

        End If
    End Sub

    'Misscellaneous
    Private Sub ดินปลูกLabel_Click(sender As Object, e As EventArgs) Handles ดินปลูกLabel.Click
        MiscellaneousPic.Image = My.Resources.ดินปลูก
    End Sub

    Private Sub หินขาวLabel_Click(sender As Object, e As EventArgs) Handles หินขาวLabel.Click
        MiscellaneousPic.Image = My.Resources.หินขาว
    End Sub

    Private Sub หินเกล็ดชมพูLabel_Click(sender As Object, e As EventArgs) Handles หินเกล็ดชมพูLabel.Click
        MiscellaneousPic.Image = My.Resources.หินเกล็ดชมพู
    End Sub

    Private Sub หินเกล็ดดำLabel_Click(sender As Object, e As EventArgs) Handles หินเกล็ดดำLabel.Click
        MiscellaneousPic.Image = My.Resources.หินเกล็ดดำ
    End Sub

    Private Sub ปุ๋ยบำรุงดินLabel_Click(sender As Object, e As EventArgs) Handles ปุ๋ยบำรุงดินLabel.Click
        MiscellaneousPic.Image = My.Resources.ปุ๋ยบำรุงต้น
    End Sub

    Private Sub ป้ายชื่อต้นไม้Label_Click(sender As Object, e As EventArgs) Handles ป้ายชื่อต้นไม้Label.Click
        MiscellaneousPic.Image = My.Resources.ป้ายชื่อต้นไม้
    End Sub

    Private Sub ตะกร้าใส่ปุ๋ยLabel_Click(sender As Object, e As EventArgs) Handles ตะกร้าใส่ปุ๋ยLabel.Click
        MiscellaneousPic.Image = My.Resources.ตะกร้าใส่ปุ๋ย
    End Sub

    Dim sum As Integer
    Private Sub AddToCartBtn_Click(sender As Object, e As EventArgs) Handles CheckoutBtn.Click
        If พลูฉลุ.Checked Then
            sum += 20
            PurchaseProductStr = "พลูฉลุ, "
        ElseIf เศรษฐีนำโชค.Checked Then
            sum += 20
            PurchaseProductStr = "เศรษฐีนำโชค, "
        ElseIf ออมมณี.Checked Then
            sum += 20
            PurchaseProductStr = "ออมมณี, "
        ElseIf รวยโชค.Checked Then
            sum += 20
            PurchaseProductStr = "รวยโชค, "
        ElseIf ออมทรัพย์.Checked Then
            sum += 20
            PurchaseProductStr = "ออมทรัพย์, "
        ElseIf เล็บครุฑด่าง.Checked Then
            sum += 20
            PurchaseProductStr = "เล็บครุฑด่าง, "
        ElseIf เพชรชมพู.Checked Then
            sum += 20
            PurchaseProductStr = "เพชรชมพู, "
        End If

        If Standard.Checked Then
            sum += 0
            PurchaseProductStr += "Standard, "
        ElseIf Plastic1.Checked Then
            sum += 15
            PurchaseProductStr += "Plastic1, "
        ElseIf Plastic2.Checked Then
            sum += 15
            PurchaseProductStr += "Plastic2, "
        ElseIf Ceramic1.Checked Then
            sum += 40
            PurchaseProductStr += "Ceramic1, "
        ElseIf Ceramic2.Checked Then
            sum += 40
            PurchaseProductStr += "Ceramic2, "
        ElseIf Ceramic3.Checked Then
            sum += 40
            PurchaseProductStr += "Ceramic3, "
        ElseIf Ceramic4.Checked Then
            sum += 40
            PurchaseProductStr += "Ceramic4, "
        End If

        If ดินปลูก.Checked Then
            sum += 20
            PurchaseProductStr += "ดินปลูก, "
        End If

        If หินขาว.Checked Then
            sum += 20
            PurchaseProductStr += "หินขาว, "
        End If

        If หินเกล็ดชมพู.Checked Then
            sum += 20
            PurchaseProductStr += "หินเกล็ดชมพู, "
        End If

        If หินเกล็ดดำ.Checked Then
            sum += 20
            PurchaseProductStr += "หินเกล็ดดำ, "
        End If

        If ปุ๋ยบำรุงต้น.Checked Then
            sum += 25
            PurchaseProductStr += "ปุ๋ยบำรุงต้น, "
        End If

        If ป้ายชื่อต้นไม้.Checked Then
            sum += 5
            PurchaseProductStr += "ป้ายชื่อต้นไม้, "
        End If

        If ตะกร้าใส่ปุ๋ย.Checked Then
            sum += 5
            PurchaseProductStr += "ตะกร้าใส่ปุ๋ย, "
        End If

        TotalValue.Text = "฿" & (sum * Quantities)

        PurchaseProduct.Text = PurchaseProductStr.Remove(PurchaseProductStr.Length() - 2, 2)

        sum = 0

    End Sub

    Private Sub SubBtn_Click(sender As Object, e As EventArgs) Handles SubBtn.Click
        If Quantities <> 1 Then
            Quantities -= 1
            QuantityValue.Text = Quantities
        End If

    End Sub

    Private Sub PlusBtn_Click(sender As Object, e As EventArgs) Handles PlusBtn.Click
        Quantities += 1
        QuantityValue.Text = Quantities
    End Sub
End Class
