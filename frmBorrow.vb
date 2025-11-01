Public Class frmBorrow
    Public SelectedItemID As Integer

    Private Sub frmBorrow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim qty As Integer = CInt(nupQuantity.Value)
        Call cb_loader("SELECT * FROM tblitemlist", cbItemList, "ItemName", "ItemID")

        If SelectedItemID > 0 Then
            cbItemList.SelectedValue = SelectedItemID
        End If
        cbBorrowRemarks.Items.Clear()
        cbBorrowRemarks.Items.Add("Good")

    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs)
        frmCartListView.ShowDialog()

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            Dim isValid As Boolean = True
            Dim availableQty As Integer = 0
            Dim totalqty As New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?", con)
            totalqty.Parameters.AddWithValue("?", CInt(cbItemList.SelectedValue))
            Dim availqty = totalqty.ExecuteScalar()

            If availqty IsNot Nothing Then
                availableQty = CInt(availqty)
            End If

            If nupQuantity.Value = 0 Then
                MsgBox("invalid quantity")
                Exit Sub
            End If

            If txtPurpose.Text.Trim() = "" Or txtContact.Text.Trim() = "" Then
                MsgBox("Fill this information")
                Exit Sub
            End If

            If nupQuantity.Value > availqty Then
                MsgBox("Not enough available stock! Only " & availableQty & " left", vbInformation)
                isValid = False
                Exit Sub
            End If

            ' =============================
            ' 🔹 1. GET Student Information
            ' =============================
            Dim sID As Integer = -1
            Dim yID As Integer = -1
            Dim cID As Integer = -1

            Dim studentCmd As New Odbc.OdbcCommand("SELECT sID, yID, cID FROM tblstudentlist WHERE TRIM(studentNo) = ?", con)
            studentCmd.Parameters.AddWithValue("?", Trim(txtStudentNo.Text))
            Dim rdr As Odbc.OdbcDataReader = studentCmd.ExecuteReader()

            If rdr.Read() Then
                sID = rdr("sID")
                yID = rdr("yID")
                cID = rdr("cID")
            Else
                MsgBox("Student not found. Please check the Student No.", vbCritical)
                rdr.Close()
                Exit Sub
            End If
            rdr.Close()

            ' =============================
            ' 🔹 2. GET Teacher Information
            ' =============================
            Dim tID As Integer = -1
            Dim teacherCmd As New Odbc.OdbcCommand("SELECT tID FROM vw_teacher WHERE TRIM(teacher_fullname) = ?", con)
            teacherCmd.Parameters.AddWithValue("?", Trim(txtTeacher.Text))
            Dim resultT = teacherCmd.ExecuteScalar()
            If resultT IsNot Nothing Then
                tID = CInt(resultT)
            Else
                MsgBox("Teacher not found in the database!", vbCritical)
                Exit Sub
            End If

            ' =============================
            ' 🔹 3. GET Latest Setting (Semester + SY)
            ' =============================
            Dim settingID As Integer = -1
            Dim settingCmd As New Odbc.OdbcCommand("SELECT settingID FROM tblsettings ORDER BY settingID ASC LIMIT 1", con)
            Dim resultS = settingCmd.ExecuteScalar()
            If resultS IsNot Nothing Then
                settingID = CInt(resultS)
            Else
                MsgBox("No settings found. Please add school year and semester.", vbCritical)
                Exit Sub
            End If

            ' =============================
            ' 🔹 4. GET Item Info and Check Quantity
            ' =============================
            Dim itemID As Integer = -1

            Dim itemCmd As New Odbc.OdbcCommand("SELECT ItemID, ItemQuantity FROM tblitemlist WHERE ItemName = ?", con)
            itemCmd.Parameters.AddWithValue("?", Trim(cbItemList.Text))
            Dim itemRdr As Odbc.OdbcDataReader = itemCmd.ExecuteReader()
            If itemRdr.Read() Then
                itemID = itemRdr("ItemID")
                availQty = itemRdr("ItemQuantity")
            Else
                MsgBox("Item not found in the item list!", vbCritical)
                itemRdr.Close()
                Exit Sub
            End If
            itemRdr.Close()

            If nupQuantity.Value > availQty Then
                MsgBox("Not enough stock! Only " & availQty & " available.", vbInformation)
                Exit Sub
            End If

            ' =============================
            ' 🔹 5. INSERT INTO TEMP CART
            ' =============================
            Dim insertCmd As New Odbc.OdbcCommand("INSERT INTO tblcartlist (ItemID, BorrowerName, QuantityBorrowed, Contact, Purpose, borrowDateTime, Remarks, sID, tID, settingID, yID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con)

            With insertCmd.Parameters
                .AddWithValue("?", itemID)
                .AddWithValue("?", txtBorrowerName.Text)
                .AddWithValue("?", CInt(nupQuantity.Value))
                .AddWithValue("?", txtContact.Text)
                .AddWithValue("?", txtPurpose.Text)
                .AddWithValue("?", dtpBorrowed.Value)
                .AddWithValue("?", cbBorrowRemarks.Text)
                .AddWithValue("?", sID)
                .AddWithValue("?", tID)
                .AddWithValue("?", settingID)
                .AddWithValue("?", yID)
            End With

            insertCmd.ExecuteNonQuery()
            MsgBox("Item added to temporary cart successfully!", vbInformation)

            ' =============================
            ' 🔹 6. Clear and Refresh
            ' =============================
            Call listLoader()
            cbItemList.SelectedIndex = -1
            nupQuantity.Value = 0
            txtContact.Clear()
            txtPurpose.Clear()
            cbBorrowRemarks.SelectedIndex = -1
            Me.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class