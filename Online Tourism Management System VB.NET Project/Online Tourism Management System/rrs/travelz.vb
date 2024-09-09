Public Class Form1
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Mnuuser As System.Windows.Forms.MenuItem
    Friend WithEvents mnunew As System.Windows.Forms.MenuItem
    Friend WithEvents mnuedit As System.Windows.Forms.MenuItem
    Friend WithEvents mnudelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnusave As System.Windows.Forms.MenuItem
    Friend WithEvents mnuclose As System.Windows.Forms.MenuItem
    Friend WithEvents mnulogin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuexit As System.Windows.Forms.MenuItem
    Friend WithEvents mnulocation As System.Windows.Forms.MenuItem
    Friend WithEvents mnufixedItiSch As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTravMas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAirTrav As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFlightTim As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFerryTim As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActProv As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAct As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActVou As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdmin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompMas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAgentTyp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAgentMas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuStafMas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCounMas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuStateMas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCityMas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLocationMas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDistMas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuClientCode As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFixItin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuVehicle As System.Windows.Forms.MenuItem
    Friend WithEvents mnuVehTyp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuVehMas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuVehTariff As System.Windows.Forms.MenuItem
    Friend WithEvents mnuVehAlloca As System.Windows.Forms.MenuItem
    Friend WithEvents mnuVehVouc As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHotel As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHotChain As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHotMas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRoomCat As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHotSeas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHotSur As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHotRoomTarif As System.Windows.Forms.MenuItem
    Friend WithEvents mnuChiRoomTarif As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHotMealTarif As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHotFac As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHotVouc As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItineraries As System.Windows.Forms.MenuItem
    Friend WithEvents mnuClientProfile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFixItiBooking As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCustItiBooking As System.Windows.Forms.MenuItem
    Friend WithEvents mnuClientArriDept As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLocalSer As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewBill As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPaymts As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBillReceiv As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReports As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTrack As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBilling As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTrackBooking As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTrackVehi As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTrackCust As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTrackArri As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTrackDept As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTrackBill As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnunew = New System.Windows.Forms.MenuItem
        Me.mnuedit = New System.Windows.Forms.MenuItem
        Me.mnudelete = New System.Windows.Forms.MenuItem
        Me.mnusave = New System.Windows.Forms.MenuItem
        Me.mnuclose = New System.Windows.Forms.MenuItem
        Me.mnulogin = New System.Windows.Forms.MenuItem
        Me.mnuexit = New System.Windows.Forms.MenuItem
        Me.mnuAdmin = New System.Windows.Forms.MenuItem
        Me.mnuCompMas = New System.Windows.Forms.MenuItem
        Me.mnuAgentTyp = New System.Windows.Forms.MenuItem
        Me.mnuAgentMas = New System.Windows.Forms.MenuItem
        Me.mnuStafMas = New System.Windows.Forms.MenuItem
        Me.mnulocation = New System.Windows.Forms.MenuItem
        Me.mnuCounMas = New System.Windows.Forms.MenuItem
        Me.mnuStateMas = New System.Windows.Forms.MenuItem
        Me.mnuCityMas = New System.Windows.Forms.MenuItem
        Me.mnuLocationMas = New System.Windows.Forms.MenuItem
        Me.mnuDistMas = New System.Windows.Forms.MenuItem
        Me.mnuClientCode = New System.Windows.Forms.MenuItem
        Me.mnuFixItin = New System.Windows.Forms.MenuItem
        Me.mnufixedItiSch = New System.Windows.Forms.MenuItem
        Me.Mnuuser = New System.Windows.Forms.MenuItem
        Me.mnuTravMas = New System.Windows.Forms.MenuItem
        Me.mnuAirTrav = New System.Windows.Forms.MenuItem
        Me.mnuFlightTim = New System.Windows.Forms.MenuItem
        Me.mnuFerryTim = New System.Windows.Forms.MenuItem
        Me.mnuActProv = New System.Windows.Forms.MenuItem
        Me.mnuAct = New System.Windows.Forms.MenuItem
        Me.mnuActVou = New System.Windows.Forms.MenuItem
        Me.mnuVehicle = New System.Windows.Forms.MenuItem
        Me.mnuVehTyp = New System.Windows.Forms.MenuItem
        Me.mnuVehMas = New System.Windows.Forms.MenuItem
        Me.mnuVehTariff = New System.Windows.Forms.MenuItem
        Me.mnuVehAlloca = New System.Windows.Forms.MenuItem
        Me.mnuVehVouc = New System.Windows.Forms.MenuItem
        Me.mnuHotel = New System.Windows.Forms.MenuItem
        Me.mnuHotChain = New System.Windows.Forms.MenuItem
        Me.mnuHotMas = New System.Windows.Forms.MenuItem
        Me.mnuRoomCat = New System.Windows.Forms.MenuItem
        Me.mnuHotSeas = New System.Windows.Forms.MenuItem
        Me.mnuHotSur = New System.Windows.Forms.MenuItem
        Me.mnuHotRoomTarif = New System.Windows.Forms.MenuItem
        Me.mnuChiRoomTarif = New System.Windows.Forms.MenuItem
        Me.mnuHotMealTarif = New System.Windows.Forms.MenuItem
        Me.mnuHotFac = New System.Windows.Forms.MenuItem
        Me.mnuHotVouc = New System.Windows.Forms.MenuItem
        Me.mnuItineraries = New System.Windows.Forms.MenuItem
        Me.mnuClientProfile = New System.Windows.Forms.MenuItem
        Me.mnuFixItiBooking = New System.Windows.Forms.MenuItem
        Me.mnuCustItiBooking = New System.Windows.Forms.MenuItem
        Me.mnuClientArriDept = New System.Windows.Forms.MenuItem
        Me.mnuLocalSer = New System.Windows.Forms.MenuItem
        Me.mnuBilling = New System.Windows.Forms.MenuItem
        Me.mnuViewBill = New System.Windows.Forms.MenuItem
        Me.mnuPaymts = New System.Windows.Forms.MenuItem
        Me.mnuBillReceiv = New System.Windows.Forms.MenuItem
        Me.mnuTrack = New System.Windows.Forms.MenuItem
        Me.mnuTrackBooking = New System.Windows.Forms.MenuItem
        Me.mnuTrackVehi = New System.Windows.Forms.MenuItem
        Me.mnuTrackCust = New System.Windows.Forms.MenuItem
        Me.mnuTrackArri = New System.Windows.Forms.MenuItem
        Me.mnuTrackDept = New System.Windows.Forms.MenuItem
        Me.mnuTrackBill = New System.Windows.Forms.MenuItem
        Me.mnuReports = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuAdmin, Me.mnuVehicle, Me.mnuHotel, Me.mnuItineraries, Me.mnuLocalSer, Me.mnuBilling, Me.mnuTrack, Me.mnuReports, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnunew, Me.mnuedit, Me.mnudelete, Me.mnusave, Me.mnuclose, Me.mnulogin, Me.mnuexit})
        Me.mnuFile.Text = "File"
        '
        'mnunew
        '
        Me.mnunew.Index = 0
        Me.mnunew.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.mnunew.Text = "New       "
        '
        'mnuedit
        '
        Me.mnuedit.Index = 1
        Me.mnuedit.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.mnuedit.Text = "Edit       "
        '
        'mnudelete
        '
        Me.mnudelete.Index = 2
        Me.mnudelete.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.mnudelete.Text = "Delete     "
        '
        'mnusave
        '
        Me.mnusave.Index = 3
        Me.mnusave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.mnusave.Text = "Save       "
        '
        'mnuclose
        '
        Me.mnuclose.Index = 4
        Me.mnuclose.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.mnuclose.Text = "Close     "
        '
        'mnulogin
        '
        Me.mnulogin.Index = 5
        Me.mnulogin.Text = "Login   "
        '
        'mnuexit
        '
        Me.mnuexit.Index = 6
        Me.mnuexit.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.mnuexit.Text = "Exit       "
        '
        'mnuAdmin
        '
        Me.mnuAdmin.Index = 1
        Me.mnuAdmin.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCompMas, Me.mnuAgentTyp, Me.mnuAgentMas, Me.mnuStafMas, Me.mnulocation, Me.mnuClientCode, Me.mnuFixItin, Me.mnufixedItiSch, Me.Mnuuser, Me.mnuTravMas, Me.mnuAirTrav, Me.mnuFlightTim, Me.mnuFerryTim, Me.mnuActProv, Me.mnuAct, Me.mnuActVou})
        Me.mnuAdmin.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.mnuAdmin.Text = "&Admin"
        '
        'mnuCompMas
        '
        Me.mnuCompMas.Index = 0
        Me.mnuCompMas.Text = "Company Master"
        '
        'mnuAgentTyp
        '
        Me.mnuAgentTyp.Index = 1
        Me.mnuAgentTyp.Text = "Agent Type"
        '
        'mnuAgentMas
        '
        Me.mnuAgentMas.Index = 2
        Me.mnuAgentMas.Text = "Agents Master"
        '
        'mnuStafMas
        '
        Me.mnuStafMas.Index = 3
        Me.mnuStafMas.Text = "Staff Master"
        '
        'mnulocation
        '
        Me.mnulocation.Index = 4
        Me.mnulocation.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCounMas, Me.mnuStateMas, Me.mnuCityMas, Me.mnuLocationMas, Me.mnuDistMas})
        Me.mnulocation.Text = "Locations"
        '
        'mnuCounMas
        '
        Me.mnuCounMas.Index = 0
        Me.mnuCounMas.Text = "Country Master"
        '
        'mnuStateMas
        '
        Me.mnuStateMas.Index = 1
        Me.mnuStateMas.Text = "State Master"
        '
        'mnuCityMas
        '
        Me.mnuCityMas.Index = 2
        Me.mnuCityMas.Text = "City Master"
        '
        'mnuLocationMas
        '
        Me.mnuLocationMas.Index = 3
        Me.mnuLocationMas.Text = "Location Master"
        '
        'mnuDistMas
        '
        Me.mnuDistMas.Index = 4
        Me.mnuDistMas.Text = "Distance Master"
        '
        'mnuClientCode
        '
        Me.mnuClientCode.Index = 5
        Me.mnuClientCode.Text = "Client Code"
        '
        'mnuFixItin
        '
        Me.mnuFixItin.Index = 6
        Me.mnuFixItin.Text = "Fixed Itinerarie"
        '
        'mnufixedItiSch
        '
        Me.mnufixedItiSch.Index = 7
        Me.mnufixedItiSch.Text = "Fixed Itinerarie Schedule"
        '
        'Mnuuser
        '
        Me.Mnuuser.Index = 8
        Me.Mnuuser.Text = "User Master"
        '
        'mnuTravMas
        '
        Me.mnuTravMas.Index = 9
        Me.mnuTravMas.Text = "Travels Master"
        '
        'mnuAirTrav
        '
        Me.mnuAirTrav.Index = 10
        Me.mnuAirTrav.Text = "AirLine Travels"
        '
        'mnuFlightTim
        '
        Me.mnuFlightTim.Index = 11
        Me.mnuFlightTim.Text = "Flight Timings"
        '
        'mnuFerryTim
        '
        Me.mnuFerryTim.Index = 12
        Me.mnuFerryTim.Text = "Ferry Timings"
        '
        'mnuActProv
        '
        Me.mnuActProv.Index = 13
        Me.mnuActProv.Text = "Activity Provider"
        '
        'mnuAct
        '
        Me.mnuAct.Index = 14
        Me.mnuAct.Text = "Activity "
        '
        'mnuActVou
        '
        Me.mnuActVou.Index = 15
        Me.mnuActVou.Text = "Activity Voucher"
        '
        'mnuVehicle
        '
        Me.mnuVehicle.Index = 2
        Me.mnuVehicle.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuVehTyp, Me.mnuVehMas, Me.mnuVehTariff, Me.mnuVehAlloca, Me.mnuVehVouc})
        Me.mnuVehicle.Text = "Vehicle"
        '
        'mnuVehTyp
        '
        Me.mnuVehTyp.Index = 0
        Me.mnuVehTyp.Text = "Vehicle Type"
        '
        'mnuVehMas
        '
        Me.mnuVehMas.Index = 1
        Me.mnuVehMas.Text = "Vehicle Master"
        '
        'mnuVehTariff
        '
        Me.mnuVehTariff.Index = 2
        Me.mnuVehTariff.Text = "Vehicle Tariff"
        '
        'mnuVehAlloca
        '
        Me.mnuVehAlloca.Index = 3
        Me.mnuVehAlloca.Text = "Vehicle Allocation"
        '
        'mnuVehVouc
        '
        Me.mnuVehVouc.Index = 4
        Me.mnuVehVouc.Text = "Vehicle Voucher"
        '
        'mnuHotel
        '
        Me.mnuHotel.Index = 3
        Me.mnuHotel.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHotChain, Me.mnuHotMas, Me.mnuRoomCat, Me.mnuHotSeas, Me.mnuHotSur, Me.mnuHotRoomTarif, Me.mnuChiRoomTarif, Me.mnuHotMealTarif, Me.mnuHotFac, Me.mnuHotVouc})
        Me.mnuHotel.Text = "Hotel"
        '
        'mnuHotChain
        '
        Me.mnuHotChain.Index = 0
        Me.mnuHotChain.Text = "Hotel Chain"
        '
        'mnuHotMas
        '
        Me.mnuHotMas.Index = 1
        Me.mnuHotMas.Text = "Hotel Master"
        '
        'mnuRoomCat
        '
        Me.mnuRoomCat.Index = 2
        Me.mnuRoomCat.Text = "Room Category"
        '
        'mnuHotSeas
        '
        Me.mnuHotSeas.Index = 3
        Me.mnuHotSeas.Text = "Hotel Season"
        '
        'mnuHotSur
        '
        Me.mnuHotSur.Index = 4
        Me.mnuHotSur.Text = "Hotel Surcharge"
        '
        'mnuHotRoomTarif
        '
        Me.mnuHotRoomTarif.Index = 5
        Me.mnuHotRoomTarif.Text = "Hotel Room Tariff"
        '
        'mnuChiRoomTarif
        '
        Me.mnuChiRoomTarif.Index = 6
        Me.mnuChiRoomTarif.Text = "Child Room Tariff"
        '
        'mnuHotMealTarif
        '
        Me.mnuHotMealTarif.Index = 7
        Me.mnuHotMealTarif.Text = "Hotel Meal Tariff"
        '
        'mnuHotFac
        '
        Me.mnuHotFac.Index = 8
        Me.mnuHotFac.Text = "Hotel Facilities"
        '
        'mnuHotVouc
        '
        Me.mnuHotVouc.Index = 9
        Me.mnuHotVouc.Text = "Hotel Voucher"
        '
        'mnuItineraries
        '
        Me.mnuItineraries.Index = 4
        Me.mnuItineraries.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuClientProfile, Me.mnuFixItiBooking, Me.mnuCustItiBooking, Me.mnuClientArriDept})
        Me.mnuItineraries.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.mnuItineraries.Text = "Itineraries"
        '
        'mnuClientProfile
        '
        Me.mnuClientProfile.Index = 0
        Me.mnuClientProfile.Text = "Client Profile"
        '
        'mnuFixItiBooking
        '
        Me.mnuFixItiBooking.Index = 1
        Me.mnuFixItiBooking.Text = "Fixed Itineraries Booking"
        '
        'mnuCustItiBooking
        '
        Me.mnuCustItiBooking.Index = 2
        Me.mnuCustItiBooking.Text = "Custom Itineraries Booking"
        '
        'mnuClientArriDept
        '
        Me.mnuClientArriDept.Index = 3
        Me.mnuClientArriDept.Text = "Client Arrival Departure "
        '
        'mnuLocalSer
        '
        Me.mnuLocalSer.Index = 5
        Me.mnuLocalSer.Text = "Local Services"
        '
        'mnuBilling
        '
        Me.mnuBilling.Index = 6
        Me.mnuBilling.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuViewBill, Me.mnuPaymts, Me.mnuBillReceiv})
        Me.mnuBilling.Shortcut = System.Windows.Forms.Shortcut.CtrlB
        Me.mnuBilling.Text = "Billing"
        '
        'mnuViewBill
        '
        Me.mnuViewBill.Index = 0
        Me.mnuViewBill.Text = "View Bills"
        '
        'mnuPaymts
        '
        Me.mnuPaymts.Index = 1
        Me.mnuPaymts.Text = "Payments"
        '
        'mnuBillReceiv
        '
        Me.mnuBillReceiv.Index = 2
        Me.mnuBillReceiv.Text = "Bills Receivables"
        '
        'mnuTrack
        '
        Me.mnuTrack.Index = 7
        Me.mnuTrack.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTrackBooking, Me.mnuTrackVehi, Me.mnuTrackCust, Me.mnuTrackArri, Me.mnuTrackDept, Me.mnuTrackBill})
        Me.mnuTrack.Shortcut = System.Windows.Forms.Shortcut.CtrlT
        Me.mnuTrack.Text = "Tracking"
        '
        'mnuTrackBooking
        '
        Me.mnuTrackBooking.Index = 0
        Me.mnuTrackBooking.Text = "Bookings"
        '
        'mnuTrackVehi
        '
        Me.mnuTrackVehi.Index = 1
        Me.mnuTrackVehi.Text = "Vehicles"
        '
        'mnuTrackCust
        '
        Me.mnuTrackCust.Index = 2
        Me.mnuTrackCust.Text = "Customers"
        '
        'mnuTrackArri
        '
        Me.mnuTrackArri.Index = 3
        Me.mnuTrackArri.Text = "Arrivals"
        '
        'mnuTrackDept
        '
        Me.mnuTrackDept.Index = 4
        Me.mnuTrackDept.Text = "Departures"
        '
        'mnuTrackBill
        '
        Me.mnuTrackBill.Index = 5
        Me.mnuTrackBill.Text = "Bills"
        '
        'mnuReports
        '
        Me.mnuReports.Index = 8
        Me.mnuReports.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.mnuReports.Text = "Reports"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 9
        Me.mnuHelp.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.mnuHelp.Text = "Help"
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton7, Me.ToolBarButton10})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(792, 42)
        Me.ToolBar1.TabIndex = 1
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Text = "Clear"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Text = "New"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.Text = "Save"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.Text = "Close"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.Text = "Edit"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.Text = "Delete"
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(792, 553)
        Me.Controls.Add(Me.ToolBar1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = ":: Radiant Reservation System :: Integrated Package for Tour Operating Companies"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub mnuAgentMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAgentMas.Click
        Dim frmagents As New AgentMaster
        frmagents.MdiParent = Me
        frmagents.Show()
    End Sub
    Private Sub mnuTrackBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrackBooking.Click
        Dim trkbook As New Booking_Tracking
        trkbook.MdiParent = Me
        trkbook.Show()
    End Sub

    Private Sub mnuTrackCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrackCust.Click
        Dim CUSTTRACK As New CustomerTracking
        CUSTTRACK.MdiParent = Me
        CUSTTRACK.Show()
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button.Text = "Clear" Then

            Dim x As Object
            x = Me.ActiveMdiChild
            If IsNothing(x) = True Then Exit Sub 'if no form / mdi chaild open 
            x.clearproc()
            ToolBar1.Buttons.Item(0).Enabled = True  'clear
            ToolBar1.Buttons.Item(1).Enabled = True  'new
            ToolBar1.Buttons.Item(2).Enabled = False 'save
            ToolBar1.Buttons.Item(3).Enabled = True 'close
            ToolBar1.Buttons.Item(4).Enabled = False 'edit
            ToolBar1.Buttons.Item(5).Enabled = False 'delete
            ToolBar1.Buttons.Item(6).Enabled = True ' exit
            mnunew.Enabled = True
            mnuedit.Enabled = False
            mnuclose.Enabled = True
            mnudelete.Enabled = False
            mnusave.Enabled = False
            mnuexit.Enabled = True
        End If
        If e.Button.Text = "New" Then

            Dim x As Object
            x = Me.ActiveMdiChild
            If IsNothing(x) = True Then Exit Sub 'if no form / mdi chaild open 
            x.newproc()

            ToolBar1.Buttons.Item(0).Enabled = True  'clear
            ToolBar1.Buttons.Item(1).Enabled = False  'new
            ToolBar1.Buttons.Item(2).Enabled = True 'save
            ToolBar1.Buttons.Item(3).Enabled = True 'close
            ToolBar1.Buttons.Item(4).Enabled = False 'edit
            ToolBar1.Buttons.Item(5).Enabled = False 'delete
            ToolBar1.Buttons.Item(6).Enabled = True ' exit
            mnunew.Enabled = False
            mnuedit.Enabled = False
            mnuclose.Enabled = True
            mnudelete.Enabled = False
            mnusave.Enabled = True
            mnuexit.Enabled = True
            Exit Sub
        End If
        If e.Button.Text = "Save" Then

            Dim x As Object
            x = Me.ActiveMdiChild
            If IsNothing(x) = True Then Exit Sub 'if no form / mdi chaild open 
            x.saveproc()

            ToolBar1.Buttons.Item(0).Enabled = True  'clear
            ToolBar1.Buttons.Item(1).Enabled = True  'new
            ToolBar1.Buttons.Item(2).Enabled = True 'save
            ToolBar1.Buttons.Item(3).Enabled = True 'close
            ToolBar1.Buttons.Item(4).Enabled = False 'edit
            ToolBar1.Buttons.Item(5).Enabled = False 'delete
            ToolBar1.Buttons.Item(6).Enabled = True ' exit
            mnunew.Enabled = True
            mnuedit.Enabled = False
            mnuclose.Enabled = True
            mnudelete.Enabled = False
            mnusave.Enabled = True
            mnuexit.Enabled = True
            Exit Sub
        End If
        If e.Button.Text = "Close" Then
            Try
                Me.ActiveMdiChild.Close()
            Catch ex As Exception
                MsgBox("No Form Open", MsgBoxStyle.OKOnly, Prjtitle)
                Exit Sub
            End Try
            Exit Sub
        End If
        If e.Button.Text = "Edit" Then
            Dim x As Object
            x = Me.ActiveMdiChild
            If IsNothing(x) = True Then Exit Sub 'if no form / mdi chaild open 
            x.editproc()

            ToolBar1.Buttons.Item(0).Enabled = True  'clear
            ToolBar1.Buttons.Item(1).Enabled = False  'new
            ToolBar1.Buttons.Item(2).Enabled = True 'save
            ToolBar1.Buttons.Item(3).Enabled = True 'close
            ToolBar1.Buttons.Item(4).Enabled = False 'edit
            ToolBar1.Buttons.Item(5).Enabled = False 'delete
            ToolBar1.Buttons.Item(6).Enabled = True ' exit
            mnunew.Enabled = False
            mnuedit.Enabled = False
            mnuclose.Enabled = True
            mnudelete.Enabled = False
            mnusave.Enabled = True
            mnuexit.Enabled = True
            Exit Sub
        End If
        If e.Button.Text = "Delete" Then
            Dim x As Object
            x = Me.ActiveMdiChild
            If IsNothing(x) = True Then Exit Sub 'if no form / mdi chaild open 
            x.delproc()
            ToolBar1.Buttons.Item(0).Enabled = True  'clear
            ToolBar1.Buttons.Item(1).Enabled = True  'new
            ToolBar1.Buttons.Item(2).Enabled = False 'save
            ToolBar1.Buttons.Item(3).Enabled = True 'close
            ToolBar1.Buttons.Item(4).Enabled = False 'edit
            ToolBar1.Buttons.Item(5).Enabled = False 'delete
            ToolBar1.Buttons.Item(6).Enabled = True ' exit
            mnunew.Enabled = True
            mnuedit.Enabled = False
            mnusave.Enabled = False
            mnuclose.Enabled = True
            mnudelete.Enabled = False
            mnuexit.Enabled = True
            Exit Sub
        End If
        If e.Button.Text = "Exit" Then
            If MessageBox.Show("Are You sure You want to close the package", "Confirm Exit?", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then

                Application.Exit()
            End If
        End If
    End Sub
    Private Sub mnuTrackVehi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrackVehi.Click
        Dim trkvcl As New Track_Veh
        trkvcl.MdiParent = Me
        trkvcl.Show()
    End Sub
    Private Sub mnuTrackBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrackBill.Click
        Dim trackingbills As New TRACKING_BILLS
        trackingbills.MdiParent = Me
        trackingbills.Show()
    End Sub

    Private Sub mnuReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReports.Click
        Dim report As New Reports
        report.MdiParent = Me
        report.Show()
    End Sub

    Private Sub mnuTrackArri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrackArri.Click
        Dim arrivals As New ArrivalsTracking
        arrivals.MdiParent = Me
        arrivals.Show()
    End Sub

    Private Sub mnuTrackDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrackDept.Click
        Dim depatures As New DeparturesTracking
        depatures.MdiParent = Me
        depatures.Show()
    End Sub


    Private Sub mnuPaymts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPaymts.Click
        Dim payments As New Payment_Billing
        payments.MdiParent = Me
        payments.Show()
    End Sub
    Private Sub mnuCompMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCompMas.Click
        Dim commas As New company_master
        commas.MdiParent = Me
        commas.Show()
    End Sub
    Private Sub mnuStateMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStateMas.Click
        Dim Statemast As New StateMaster
        Statemast.MdiParent = Me
        Statemast.Show()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim code As New Code
        code.MdiParent = Me
        code.Show()
    End Sub
    Private Sub mnufixedItiSch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnufixedItiSch.Click
        'fixed itinaries schdule
        Dim fixiti As New FixItiner_Sched
        fixiti.MdiParent = Me
        fixiti.Show()
    End Sub

    Private Sub Mnuuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnuuser.Click
        'USer Master
        Dim usermast As New UserMaster
        usermast.MdiParent = Me
        usermast.Show()
    End Sub


    Private Sub mnuDistMas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDistMas.Click
        Dim dista As New Distance_Mast
        dista.MdiParent = Me
        dista.Show()
    End Sub
    Private Sub mnuTravMas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTravMas.Click
        Dim trave As New Travels_Master
        trave.MdiParent = Me
        trave.Show()
    End Sub
    Private Sub mnuClientProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClientProfile.Click
        Dim cust As New Customer
        cust.MdiParent = Me
        cust.Show()
    End Sub

    Private Sub mnuFixItiBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFixItiBooking.Click

        Dim fixit As New FixItiner_Booking
        fixit.MdiParent = Me
        fixit.Show()
    End Sub

    Private Sub mnuCustItiBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustItiBooking.Click

        Dim custite As New Custom_Itine
        custite.MdiParent = Me
        custite.Show()

    End Sub
    Private Sub mnuAirTrav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAirTrav.Click
        Dim Airli As New Airline_Travels
        Airli.MdiParent = Me
        Airli.Show()

    End Sub

    Private Sub mnuHotMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHotMas.Click
        Dim hotelmast As New Hotelmast
        hotelmast.MdiParent = Me
        hotelmast.Show()
    End Sub

    Private Sub mnuHotSeas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHotSeas.Click
        Dim hotseason As New Hotel_Season
        hotseason.MdiParent = Me
        hotseason.Show()
    End Sub

    Private Sub mnuHotSur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHotSur.Click
        Dim hotserg As New Hotel_Surcharg
        hotserg.MdiParent = Me
        hotserg.Show()
    End Sub

    Private Sub mnuHotChain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHotChain.Click
        Dim chainhot As New Hotel_Chain
        chainhot.MdiParent = Me
        chainhot.Show()
    End Sub

    Private Sub mnuRoomCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRoomCat.Click
        Dim roomcat As New Room_catg
        roomcat.MdiParent = Me
        roomcat.Show()
    End Sub

    Private Sub mnuHotRoomTarif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHotRoomTarif.Click
        Dim roomtar As New Hotel_Room_Tariff
        roomtar.MdiParent = Me
        roomtar.Show()

    End Sub
    Private Sub mnuLocationMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLocationMas.Click
        Dim locmaster As New Location_Master
        locmaster.MdiParent = Me
        locmaster.Show()
    End Sub

    Private Sub mnuCityMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCityMas.Click
        Dim citymas As New City_Master
        citymas.MdiParent = Me
        citymas.Show()
    End Sub

    Private Sub mnuCounMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCounMas.Click
        Dim coumas As New Country_master
        coumas.MdiParent = Me
        coumas.Show()
    End Sub

    Private Sub mnuChiRoomTarif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChiRoomTarif.Click
        Dim childtarif As New Child_Room_Tarif
        childtarif.MdiParent = Me
        childtarif.Show()
    End Sub
    Private Sub mnuFixItin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFixItin.Click
        Dim fixedpack As New FixedItineraries
        fixedpack.MdiParent = Me
        fixedpack.Show()
    End Sub
    Private Sub mnuHotMealTarif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHotMealTarif.Click
        Dim mealtarif As New Hotel_Meal_Tariff
        mealtarif.MdiParent = Me
        mealtarif.Show()
    End Sub

    Private Sub mnuHotVouc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHotVouc.Click
        Dim vouhotel As New Hotel_Voucher
        vouhotel.MdiParent = Me
        vouhotel.Show()
    End Sub

    Private Sub mnuVehTyp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVehTyp.Click
        Dim vehtype As New Veh_Type
        vehtype.MdiParent = Me
        vehtype.Show()
    End Sub

    Private Sub mnuVehMas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVehMas.Click
        Dim VEHMAST As New VEHICLE_Mast
        VEHMAST.MdiParent = Me
        VEHMAST.Show()
    End Sub

    Private Sub mnuAgentTyp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAgentTyp.Click
        Dim agenttyp As New Agent_Type
        agenttyp.MdiParent = Me
        agenttyp.Show()
    End Sub

    Private Sub mnuVehTariff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVehTariff.Click
        Dim vehtar As New Veh_Tariff
        vehtar.MdiParent = Me
        vehtar.Show()
    End Sub
    Private Sub mnuVehAlloca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVehAlloca.Click

        Dim vehduty As New Veh_DutySlip
        vehduty.MdiParent = Me
        vehduty.Show()
    End Sub

    Private Sub mnuVehVouc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVehVouc.Click
        Dim vehvouvh As New Veh_Voucher
        vehvouvh.MdiParent = Me
        vehvouvh.Show()
    End Sub
    Private Sub mnuFlightTim_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFlightTim.Click
        Dim fd As New FlightDetails
        fd.MdiParent = Me
        fd.Show()
    End Sub
    Private Sub mnuFerryTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFerryTim.Click
        Dim ferry As New FerryDetails
        ferry.MdiParent = Me
        ferry.Show()
    End Sub

    Private Sub mnuClientCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClientCode.Click
        Dim clcod As New Code
        clcod.MdiParent = Me
        clcod.Show()
    End Sub
    Private Sub mnuLocalSer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLocalSer.Click

        Dim local As New Local_Service
        local.MdiParent = Me
        local.Show()

    End Sub
    Private Sub mnuActProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActProv.Click
        Dim activi As New Activity_Provider
        activi.MdiParent = Me
        activi.Show()

    End Sub

    Private Sub mnuAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAct.Click
        Dim acti As New Activity
        acti.MdiParent = Me
        acti.Show()
    End Sub

    Private Sub mnuStafMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStafMas.Click
        Dim staf As New Staff_Master
        staf.MdiParent = Me
        staf.Show()

    End Sub

    Private Sub mnuHotFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHotFac.Click
        Dim hotfaci As New Hotel_Facilit
        hotfaci.MdiParent = Me
        hotfaci.Show()

    End Sub

    Private Sub mnuClientArriDept_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClientArriDept.Click

        Dim memb As New Cust_Member
        memb.MdiParent = Me
        memb.Show()

    End Sub

    Private Sub mnuActVou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActVou.Click
        Dim actvou As New Activ_Voucher
        actvou.MdiParent = Me
        actvou.Show()
    End Sub

    Private Sub Mnunew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnunew.Click
        'short cut key for newprocedure
        Dim objnewproc As Object
        objnewproc = Me.ActiveMdiChild
        objnewproc.newproc()
        ' enabling and disabling of tool bar buttons
        ToolBar1.Buttons.Item(0).Enabled = True  'clear
        ToolBar1.Buttons.Item(1).Enabled = False  'new
        ToolBar1.Buttons.Item(2).Enabled = True 'save
        ToolBar1.Buttons.Item(3).Enabled = True 'close
        ToolBar1.Buttons.Item(4).Enabled = False 'edit
        ToolBar1.Buttons.Item(5).Enabled = False 'delete
        ToolBar1.Buttons.Item(6).Enabled = True ' exit
        mnunew.Enabled = False
        mnuedit.Enabled = False
        mnuclose.Enabled = True
        mnudelete.Enabled = False
        mnusave.Enabled = True
        mnuexit.Enabled = True

    End Sub

    Private Sub mnuedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuedit.Click

        Dim objeditpro As Object
        objeditpro = Me.ActiveMdiChild
        objeditpro.editproc()
        ' tool bar buttons enabling and disabling
        ToolBar1.Buttons.Item(0).Enabled = True  'clear
        ToolBar1.Buttons.Item(1).Enabled = False  'new
        ToolBar1.Buttons.Item(2).Enabled = True 'save
        ToolBar1.Buttons.Item(3).Enabled = True 'close
        ToolBar1.Buttons.Item(4).Enabled = False 'edit
        ToolBar1.Buttons.Item(5).Enabled = False 'delete
        ToolBar1.Buttons.Item(6).Enabled = True ' exit
        mnunew.Enabled = False
        mnuedit.Enabled = False
        mnuclose.Enabled = True
        mnudelete.Enabled = False
        mnusave.Enabled = True
        mnuexit.Enabled = True
    End Sub

    Private Sub mnusave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusave.Click


        Dim objsaveproce As Object
        objsaveproce = Me.ActiveMdiChild
        objsaveproce.saveproc()
        'enabling and disabling of tool bar buttons

        ToolBar1.Buttons.Item(0).Enabled = True  'clear
        ToolBar1.Buttons.Item(1).Enabled = True  'new
        ToolBar1.Buttons.Item(2).Enabled = True 'save
        ToolBar1.Buttons.Item(3).Enabled = True 'close
        ToolBar1.Buttons.Item(4).Enabled = False 'edit
        ToolBar1.Buttons.Item(5).Enabled = False 'delete
        ToolBar1.Buttons.Item(6).Enabled = True ' exit
        mnunew.Enabled = True
        mnuedit.Enabled = False
        mnuclose.Enabled = True
        mnudelete.Enabled = False
        mnusave.Enabled = True
        mnuexit.Enabled = True

    End Sub
    Public Sub clearproc()

    End Sub
    Public Sub newproc()

    End Sub
    Public Sub saveproc()

    End Sub
    Public Sub editproc()

    End Sub
    Public Sub delproc()

    End Sub

    Private Sub mnudelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnudelete.Click

        Dim objdelproc As Object
        objdelproc = Me.ActiveMdiChild
        objdelproc.delproc()
        'tool bar buttons enabling and disabling
        ToolBar1.Buttons.Item(0).Enabled = True  'clear
        ToolBar1.Buttons.Item(1).Enabled = True  'new
        ToolBar1.Buttons.Item(2).Enabled = False 'save
        ToolBar1.Buttons.Item(3).Enabled = True 'close
        ToolBar1.Buttons.Item(4).Enabled = False 'edit
        ToolBar1.Buttons.Item(5).Enabled = False 'delete
        ToolBar1.Buttons.Item(6).Enabled = True ' exit
        mnunew.Enabled = True
        mnuedit.Enabled = False
        mnusave.Enabled = False
        mnuclose.Enabled = True
        mnudelete.Enabled = False
        mnuexit.Enabled = True

    End Sub

    Private Sub mnulocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnulocation.Click

    End Sub

    Private Sub mnuVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVehicle.Click

    End Sub

    Private Sub mnuHotel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHotel.Click

    End Sub

    Private Sub mnuItineraries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItineraries.Click

    End Sub

    Private Sub mnuBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBilling.Click

    End Sub

    Private Sub mnuViewBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewBill.Click

    End Sub

    Private Sub mnuBillReceiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBillReceiv.Click

    End Sub

    Private Sub mnuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click

    End Sub

    Private Sub mnuTrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrack.Click

    End Sub

    Private Sub mnuclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuclose.Click
        Try
            Me.ActiveMdiChild.Close()
        Catch ex As Exception
            MessageBox.Show("No Form Open")
        End Try
    End Sub

    Private Sub mnulogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnulogin.Click
        Dim loginfrm As New login
        loginfrm.MdiParent = Me
        loginfrm.Show()
    End Sub

    Public Sub setfrmload()
        ToolBar1.Buttons.Item(0).Enabled = True  'clear
        ToolBar1.Buttons.Item(1).Enabled = True  'new
        ToolBar1.Buttons.Item(2).Enabled = False 'save
        ToolBar1.Buttons.Item(3).Enabled = True 'close
        ToolBar1.Buttons.Item(4).Enabled = False 'edit
        ToolBar1.Buttons.Item(5).Enabled = False 'delete
        ToolBar1.Buttons.Item(6).Enabled = True ' exit
        mnunew.Enabled = True
        mnuedit.Enabled = False
        mnuclose.Enabled = True
        mnudelete.Enabled = False
        mnusave.Enabled = False
        mnuexit.Enabled = True

    End Sub

    Public Sub setdblclick()
        ToolBar1.Buttons.Item(0).Enabled = True  'clear
        ToolBar1.Buttons.Item(1).Enabled = False 'new
        ToolBar1.Buttons.Item(2).Enabled = False 'save
        ToolBar1.Buttons.Item(3).Enabled = True 'close
        ToolBar1.Buttons.Item(4).Enabled = True 'edit
        ToolBar1.Buttons.Item(5).Enabled = True 'delete
        ToolBar1.Buttons.Item(6).Enabled = True ' exit
        mnunew.Enabled = False
        mnuedit.Enabled = True
        mnuclose.Enabled = True
        mnudelete.Enabled = True
        mnusave.Enabled = False
        mnuexit.Enabled = True

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setfrmload()

    End Sub
End Class
