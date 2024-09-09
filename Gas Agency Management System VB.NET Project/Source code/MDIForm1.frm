VERSION 5.00
Begin VB.MDIForm MDIForm1 
   BackColor       =   &H00E0E0E0&
   Caption         =   "Gas Agency Management System"
   ClientHeight    =   10245
   ClientLeft      =   165
   ClientTop       =   855
   ClientWidth     =   12000
   LinkTopic       =   "MDIForm1"
   Picture         =   "MDIForm1.frx":0000
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.Menu file 
      Caption         =   "File"
      Begin VB.Menu changepassword 
         Caption         =   "Change Password"
      End
      Begin VB.Menu logout 
         Caption         =   "Logout"
      End
      Begin VB.Menu exit 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu add 
      Caption         =   "Add"
      Begin VB.Menu consumer 
         Caption         =   "Consumer"
      End
      Begin VB.Menu stockupdate 
         Caption         =   "Stock Update"
      End
   End
   Begin VB.Menu bookings 
      Caption         =   "Bookings"
      Begin VB.Menu book 
         Caption         =   "Book"
      End
      Begin VB.Menu dlivery 
         Caption         =   "Delivery"
      End
   End
   Begin VB.Menu view 
      Caption         =   "View"
      Begin VB.Menu vconsumer 
         Caption         =   "Consumer"
      End
      Begin VB.Menu vstock 
         Caption         =   "Stock"
      End
      Begin VB.Menu vbooking 
         Caption         =   "Booking"
      End
      Begin VB.Menu vdelivery 
         Caption         =   "Delivery"
      End
      Begin VB.Menu rate 
         Caption         =   "Cylinder Rate"
      End
      Begin VB.Menu vreport 
         Caption         =   "Report"
      End
   End
End
Attribute VB_Name = "MDIForm1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset
Dim g As Integer
Private Sub book_Click()
cn.Open "gas"
rs.Open "consumer", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
MsgBox "No consumer exits"
Else
rs.MoveFirst
g = 0
n = 0
n = Val(InputBox("Enter the Consumer number", "Search"))
Do Until rs.EOF
If (rs(0) = n) Then
g = 1
If (rs(10) = "Deleted") Then
MsgBox "Consumer already deleted", vbOKOnly, "error"
Else
Booking.Show
End If
Exit Do
End If
rs.MoveNext
Loop
If n = 0 Then
Else
If g = 0 Then
MsgBox "No record found", vbOKOnly, "Search"
End If
End If
End If
rs.Close
cn.Close
End Sub

Private Sub changepassword_Click()
Password.Show
End Sub

Private Sub consumer_Click()
Consumers.Show
End Sub

Private Sub dlivery_Click()
cn.Open "gas"
rs.Open "stock", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
MsgBox "No stock", vbOKOnly, "Stock"
Stock.Show
Else
rs.Close
rs.Open "rate", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
MsgBox "Price not set", vbOKOnly, "Price"
Vrate.Show
Else
rs.Close
rs.Open "booking", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
MsgBox "No booking exits", vbOKOnly, "Error"
Else
rs.MoveFirst
g = 0
n = 0
n = Val(InputBox("Enter the booking number", "Search"))
Do Until rs.EOF
If (rs(0) = n) Then
g = 1
Exit Do
End If
rs.MoveNext
Loop
If n = 0 Then
Else
If g = 0 Then
MsgBox "No record found", vbOKOnly, "Error"
Else
If (rs(4) = "Delivered") Then
MsgBox "Booking already Delivered", vbOKOnly, "Error"
Else
If (rs(4) = "Canceled") Then
MsgBox "Booking already cancled", vbOKOnly, "Cancel"
Else
Delivery.Show
End If
End If
End If
End If
End If
End If
End If
rs.Close
cn.Close
End Sub

Private Sub exit_Click()
Unload Me
End Sub

Private Sub logout_Click()
Login.Show
End Sub

Private Sub rate_Click()
Vrate.Show
End Sub

Private Sub stockupdate_Click()
Stock.Show
End Sub

Private Sub vbooking_Click()
cn.Open "gas"
rs.Open "booking", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
MsgBox "No records", vbOKOnly, "Error"
Else
rs.MoveFirst
g = 0
n = 0
n = Val(InputBox("Enter the booking number", "Search"))
Do Until rs.EOF
If (rs(0) = n) Then
g = 1
Exit Do
End If
rs.MoveNext
Loop
If n = 0 Then
Else
If g = 0 Then
MsgBox "No record found", vbOKOnly, "Error"
Else
If (rs(4) = "Canceled") Then
MsgBox "Booking already canceled", vbOKOnly, "Cancel"
Else
Vbook.Show
End If
End If
End If
End If
rs.Close
cn.Close
End Sub

Private Sub vconsumer_Click()
cn.Open "gas"
rs.Open "consumer", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
MsgBox "No records", vbOKOnly, "Error"
Else
rs.MoveFirst
g = 0
n = 0
n = Val(InputBox("Enter the Consumer number", "Search"))
Do Until rs.EOF
If (rs(0) = n) Then
g = 1
Exit Do
End If
rs.MoveNext
Loop
If n = 0 Then
Else
If g = 0 Then
MsgBox "No record found", vbOKOnly, "Error"
Else
If (rs(10) = "Deleted") Then
MsgBox "Consumer already deleted", vbOKOnly, "error"
Else
ConsumerV.Show
End If
End If
End If
End If
rs.Close
cn.Close
End Sub

Private Sub vdelivery_Click()
cn.Open "gas"
rs.Open "delivery", cn, adOpenDynamic, adLockOptimistic
If rs.EOF Then
MsgBox "No delivery exits", vbOKOnly, "Error"
Else
rs.MoveFirst
g = 0
n = 0
n = Val(InputBox("Enter the delivery number", "Search"))
Do Until rs.EOF
If (rs(0) = n) Then
g = 1
Exit Do
End If
rs.MoveNext
Loop
If n = 0 Then
Else
If g = 0 Then
MsgBox "No record found", vbOKOnly, "Error"
Else
Deliveryv.Show
End If
End If
End If
rs.Close
cn.Close
End Sub

Private Sub vreport_Click()
Report.Show
End Sub

Private Sub vstock_Click()
Stock.Show
End Sub
