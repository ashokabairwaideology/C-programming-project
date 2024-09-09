'Name developer: T. Sreekanth
'Dt:26/06/06
'Purpose :
'Version :1
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb

Public Class Reports

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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Grb_month As System.Windows.Forms.GroupBox
    Friend WithEvents Grb_Year As System.Windows.Forms.GroupBox
    Friend WithEvents Grbin_between As System.Windows.Forms.GroupBox
    Friend WithEvents Grb_ason As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Grb_VehType As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Grb_Agent_type As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cobcountry As System.Windows.Forms.ComboBox
    Friend WithEvents grb_country As System.Windows.Forms.GroupBox
    Friend WithEvents cob_agentype As System.Windows.Forms.ComboBox
    Friend WithEvents cob_vehtype As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_ason As System.Windows.Forms.DateTimePicker
    Friend WithEvents cob_month As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_year As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents grb_state As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cobstate As System.Windows.Forms.ComboBox
    Friend WithEvents grb_city As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cobcity As System.Windows.Forms.ComboBox
    Friend WithEvents grblocations As System.Windows.Forms.GroupBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents coblocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GRBactivity As System.Windows.Forms.GroupBox
    Friend WithEvents Cobactivi As System.Windows.Forms.ComboBox
    Friend WithEvents Veh_no As System.Windows.Forms.Label
    Friend WithEvents Cobvehicle As System.Windows.Forms.ComboBox
    Friend WithEvents Txtinvoice As System.Windows.Forms.TextBox
    Friend WithEvents Grbvehno As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Activities Tariff")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Activity Vouchers")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Activity Wise Bookings")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List Of Activity Providers")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Activity", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ferry Arrivals")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ferry Departures")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ferry Timings", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Flight Arrivals")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Flight Departures")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Flight Timings", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List Of Agents")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Country Wise")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("State Wise")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List Of Cities", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List Of Countries")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotels City Wise")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotels In Chain")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotels State Wise")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List Of Hotels", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List of Location Distance")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List Of Locations")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List Of Staff")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List Of States")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Admin", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode11, TreeNode12, TreeNode15, TreeNode16, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Agent Wise")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Between Any Dates")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bookings")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location Wise")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customers", New System.Windows.Forms.TreeNode() {TreeNode26, TreeNode27, TreeNode28, TreeNode29})
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotel Facilities")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotel Meal Tariff")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Between Dates")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chain of Hotel Wise")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotel Wise")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotel Reservation", New System.Windows.Forms.TreeNode() {TreeNode33, TreeNode34, TreeNode35})
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotel RoomTariff")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotel Vouchers")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotel", New System.Windows.Forms.TreeNode() {TreeNode31, TreeNode32, TreeNode36, TreeNode37, TreeNode38})
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List Of Fixed Itineraries")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Schedule of Fixed Itineraries")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Itineraries", New System.Windows.Forms.TreeNode() {TreeNode40, TreeNode41})
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Activity Providers")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Agents")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Airlines Travels Agents")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer's")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotels")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Staff")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Travles Agents")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mailing List", New System.Windows.Forms.TreeNode() {TreeNode43, TreeNode44, TreeNode45, TreeNode46, TreeNode47, TreeNode48, TreeNode49})
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Available Vehicles As On Date")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Invoice")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List Of Vehicles")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vehicle Allocation")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vehicle Vouchers")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vehicle Wise Bookings ")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vehicles", New System.Windows.Forms.TreeNode() {TreeNode51, TreeNode52, TreeNode53, TreeNode54, TreeNode55, TreeNode56})
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reports", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode25, TreeNode30, TreeNode39, TreeNode42, TreeNode50, TreeNode57})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Txtinvoice = New System.Windows.Forms.TextBox
        Me.Grbvehno = New System.Windows.Forms.GroupBox
        Me.Cobvehicle = New System.Windows.Forms.ComboBox
        Me.Veh_no = New System.Windows.Forms.Label
        Me.GRBactivity = New System.Windows.Forms.GroupBox
        Me.Cobactivi = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.grblocations = New System.Windows.Forms.GroupBox
        Me.lblLocation = New System.Windows.Forms.Label
        Me.coblocation = New System.Windows.Forms.ComboBox
        Me.grb_country = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cobcountry = New System.Windows.Forms.ComboBox
        Me.Grb_Agent_type = New System.Windows.Forms.GroupBox
        Me.cob_agentype = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Grb_VehType = New System.Windows.Forms.GroupBox
        Me.cob_vehtype = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Grb_ason = New System.Windows.Forms.GroupBox
        Me.dtp_ason = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Grb_month = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cob_month = New System.Windows.Forms.ComboBox
        Me.Grb_Year = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtp_year = New System.Windows.Forms.ComboBox
        Me.Grbin_between = New System.Windows.Forms.GroupBox
        Me.dtp_to = New System.Windows.Forms.DateTimePicker
        Me.dtp_from = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_show = New System.Windows.Forms.Button
        Me.grb_state = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cobstate = New System.Windows.Forms.ComboBox
        Me.grb_city = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cobcity = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.Grbvehno.SuspendLayout()
        Me.GRBactivity.SuspendLayout()
        Me.grblocations.SuspendLayout()
        Me.grb_country.SuspendLayout()
        Me.Grb_Agent_type.SuspendLayout()
        Me.Grb_VehType.SuspendLayout()
        Me.Grb_ason.SuspendLayout()
        Me.Grb_month.SuspendLayout()
        Me.Grb_Year.SuspendLayout()
        Me.Grbin_between.SuspendLayout()
        Me.grb_state.SuspendLayout()
        Me.grb_city.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.HideSelection = False
        Me.TreeView1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = ""
        TreeNode1.Text = "Activities Tariff"
        TreeNode2.Name = ""
        TreeNode2.Text = "Activity Vouchers"
        TreeNode3.Name = ""
        TreeNode3.Text = "Activity Wise Bookings"
        TreeNode4.Name = ""
        TreeNode4.Text = "List Of Activity Providers"
        TreeNode5.Name = ""
        TreeNode5.Text = "Activity"
        TreeNode6.Name = ""
        TreeNode6.Text = "Ferry Arrivals"
        TreeNode7.Name = ""
        TreeNode7.Text = "Ferry Departures"
        TreeNode8.Name = ""
        TreeNode8.Text = "Ferry Timings"
        TreeNode9.Name = ""
        TreeNode9.Text = "Flight Arrivals"
        TreeNode10.Name = ""
        TreeNode10.Text = "Flight Departures"
        TreeNode11.Name = ""
        TreeNode11.Text = "Flight Timings"
        TreeNode12.Name = ""
        TreeNode12.Text = "List Of Agents"
        TreeNode13.Name = ""
        TreeNode13.Text = "Country Wise"
        TreeNode14.Name = ""
        TreeNode14.Text = "State Wise"
        TreeNode15.Name = ""
        TreeNode15.Text = "List Of Cities"
        TreeNode16.Name = ""
        TreeNode16.Text = "List Of Countries"
        TreeNode17.Name = ""
        TreeNode17.Text = "Hotels City Wise"
        TreeNode18.Name = ""
        TreeNode18.Text = "Hotels In Chain"
        TreeNode19.Name = ""
        TreeNode19.Text = "Hotels State Wise"
        TreeNode20.Name = ""
        TreeNode20.Text = "List Of Hotels"
        TreeNode21.Name = ""
        TreeNode21.Text = "List of Location Distance"
        TreeNode22.Name = ""
        TreeNode22.Text = "List Of Locations"
        TreeNode23.Name = ""
        TreeNode23.Text = "List Of Staff"
        TreeNode24.Name = ""
        TreeNode24.Text = "List Of States"
        TreeNode25.Name = ""
        TreeNode25.Text = "Admin"
        TreeNode26.Name = ""
        TreeNode26.Text = "Agent Wise"
        TreeNode27.Name = ""
        TreeNode27.Text = "Between Any Dates"
        TreeNode28.Name = ""
        TreeNode28.Text = "Bookings"
        TreeNode29.Name = ""
        TreeNode29.Text = "Location Wise"
        TreeNode30.Name = ""
        TreeNode30.Text = "Customers"
        TreeNode31.Name = ""
        TreeNode31.Text = "Hotel Facilities"
        TreeNode32.Name = ""
        TreeNode32.Text = "Hotel Meal Tariff"
        TreeNode33.Name = ""
        TreeNode33.Text = "Between Dates"
        TreeNode34.Name = ""
        TreeNode34.Text = "Chain of Hotel Wise"
        TreeNode35.Name = ""
        TreeNode35.Text = "Hotel Wise"
        TreeNode36.Name = ""
        TreeNode36.Text = "Hotel Reservation"
        TreeNode37.Name = ""
        TreeNode37.Text = "Hotel RoomTariff"
        TreeNode38.Name = ""
        TreeNode38.Text = "Hotel Vouchers"
        TreeNode39.Name = ""
        TreeNode39.Text = "Hotel"
        TreeNode40.Name = ""
        TreeNode40.Text = "List Of Fixed Itineraries"
        TreeNode41.Name = ""
        TreeNode41.Text = "Schedule of Fixed Itineraries"
        TreeNode42.Name = ""
        TreeNode42.Text = "Itineraries"
        TreeNode43.Name = ""
        TreeNode43.Text = "Activity Providers"
        TreeNode44.Name = ""
        TreeNode44.Text = "Agents"
        TreeNode45.Name = ""
        TreeNode45.Text = "Airlines Travels Agents"
        TreeNode46.Name = ""
        TreeNode46.Text = "Customer's"
        TreeNode47.Name = ""
        TreeNode47.Text = "Hotels"
        TreeNode48.Name = ""
        TreeNode48.Text = "Staff"
        TreeNode49.Name = ""
        TreeNode49.Text = "Travles Agents"
        TreeNode50.Name = ""
        TreeNode50.Text = "Mailing List"
        TreeNode51.Name = ""
        TreeNode51.Text = "Available Vehicles As On Date"
        TreeNode52.Name = ""
        TreeNode52.Text = "Invoice"
        TreeNode53.Name = ""
        TreeNode53.Text = "List Of Vehicles"
        TreeNode54.Name = ""
        TreeNode54.Text = "Vehicle Allocation"
        TreeNode55.Name = ""
        TreeNode55.Text = "Vehicle Vouchers"
        TreeNode56.Name = ""
        TreeNode56.Text = "Vehicle Wise Bookings "
        TreeNode57.Name = ""
        TreeNode57.Text = "Vehicles"
        TreeNode58.Name = ""
        TreeNode58.Text = "Reports"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode58})
        Me.TreeView1.Size = New System.Drawing.Size(241, 477)
        Me.TreeView1.Sorted = True
        Me.TreeView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Txtinvoice)
        Me.Panel1.Controls.Add(Me.Grbvehno)
        Me.Panel1.Controls.Add(Me.GRBactivity)
        Me.Panel1.Controls.Add(Me.grblocations)
        Me.Panel1.Controls.Add(Me.grb_country)
        Me.Panel1.Controls.Add(Me.Grb_Agent_type)
        Me.Panel1.Controls.Add(Me.Grb_VehType)
        Me.Panel1.Controls.Add(Me.Grb_ason)
        Me.Panel1.Controls.Add(Me.Grb_month)
        Me.Panel1.Controls.Add(Me.Grb_Year)
        Me.Panel1.Controls.Add(Me.Grbin_between)
        Me.Panel1.Controls.Add(Me.btn_show)
        Me.Panel1.Controls.Add(Me.grb_state)
        Me.Panel1.Controls.Add(Me.grb_city)
        Me.Panel1.Location = New System.Drawing.Point(248, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 472)
        Me.Panel1.TabIndex = 1
        '
        'Txtinvoice
        '
        Me.Txtinvoice.Location = New System.Drawing.Point(28, 398)
        Me.Txtinvoice.Name = "Txtinvoice"
        Me.Txtinvoice.Size = New System.Drawing.Size(100, 21)
        Me.Txtinvoice.TabIndex = 2
        '
        'Grbvehno
        '
        Me.Grbvehno.Controls.Add(Me.Cobvehicle)
        Me.Grbvehno.Controls.Add(Me.Veh_no)
        Me.Grbvehno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grbvehno.Location = New System.Drawing.Point(80, 328)
        Me.Grbvehno.Name = "Grbvehno"
        Me.Grbvehno.Size = New System.Drawing.Size(208, 32)
        Me.Grbvehno.TabIndex = 14
        Me.Grbvehno.TabStop = False
        '
        'Cobvehicle
        '
        Me.Cobvehicle.Location = New System.Drawing.Point(96, 8)
        Me.Cobvehicle.Name = "Cobvehicle"
        Me.Cobvehicle.Size = New System.Drawing.Size(104, 21)
        Me.Cobvehicle.TabIndex = 1
        '
        'Veh_no
        '
        Me.Veh_no.AutoSize = True
        Me.Veh_no.Location = New System.Drawing.Point(16, 8)
        Me.Veh_no.Name = "Veh_no"
        Me.Veh_no.Size = New System.Drawing.Size(67, 13)
        Me.Veh_no.TabIndex = 0
        Me.Veh_no.Text = "Vehicle No"
        '
        'GRBactivity
        '
        Me.GRBactivity.Controls.Add(Me.Cobactivi)
        Me.GRBactivity.Controls.Add(Me.Label11)
        Me.GRBactivity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBactivity.Location = New System.Drawing.Point(80, 360)
        Me.GRBactivity.Name = "GRBactivity"
        Me.GRBactivity.Size = New System.Drawing.Size(208, 32)
        Me.GRBactivity.TabIndex = 13
        Me.GRBactivity.TabStop = False
        '
        'Cobactivi
        '
        Me.Cobactivi.Location = New System.Drawing.Point(96, 8)
        Me.Cobactivi.Name = "Cobactivi"
        Me.Cobactivi.Size = New System.Drawing.Size(104, 21)
        Me.Cobactivi.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Activity"
        '
        'grblocations
        '
        Me.grblocations.Controls.Add(Me.lblLocation)
        Me.grblocations.Controls.Add(Me.coblocation)
        Me.grblocations.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grblocations.Location = New System.Drawing.Point(80, 264)
        Me.grblocations.Name = "grblocations"
        Me.grblocations.Size = New System.Drawing.Size(208, 32)
        Me.grblocations.TabIndex = 12
        Me.grblocations.TabStop = False
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(16, 10)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(54, 13)
        Me.lblLocation.TabIndex = 14
        Me.lblLocation.Text = "Location"
        '
        'coblocation
        '
        Me.coblocation.Items.AddRange(New Object() {"Country Wise", "State Wise", "City Wise"})
        Me.coblocation.Location = New System.Drawing.Point(96, 8)
        Me.coblocation.Name = "coblocation"
        Me.coblocation.Size = New System.Drawing.Size(104, 21)
        Me.coblocation.TabIndex = 13
        '
        'grb_country
        '
        Me.grb_country.Controls.Add(Me.Label8)
        Me.grb_country.Controls.Add(Me.cobcountry)
        Me.grb_country.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_country.Location = New System.Drawing.Point(80, 168)
        Me.grb_country.Name = "grb_country"
        Me.grb_country.Size = New System.Drawing.Size(208, 32)
        Me.grb_country.TabIndex = 11
        Me.grb_country.TabStop = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(14, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Country"
        '
        'cobcountry
        '
        Me.cobcountry.Location = New System.Drawing.Point(96, 8)
        Me.cobcountry.Name = "cobcountry"
        Me.cobcountry.Size = New System.Drawing.Size(104, 21)
        Me.cobcountry.TabIndex = 11
        '
        'Grb_Agent_type
        '
        Me.Grb_Agent_type.Controls.Add(Me.cob_agentype)
        Me.Grb_Agent_type.Controls.Add(Me.Label7)
        Me.Grb_Agent_type.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb_Agent_type.Location = New System.Drawing.Point(80, 136)
        Me.Grb_Agent_type.Name = "Grb_Agent_type"
        Me.Grb_Agent_type.Size = New System.Drawing.Size(208, 32)
        Me.Grb_Agent_type.TabIndex = 8
        Me.Grb_Agent_type.TabStop = False
        '
        'cob_agentype
        '
        Me.cob_agentype.Location = New System.Drawing.Point(96, 8)
        Me.cob_agentype.Name = "cob_agentype"
        Me.cob_agentype.Size = New System.Drawing.Size(104, 21)
        Me.cob_agentype.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Agent Type"
        '
        'Grb_VehType
        '
        Me.Grb_VehType.Controls.Add(Me.cob_vehtype)
        Me.Grb_VehType.Controls.Add(Me.Label6)
        Me.Grb_VehType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb_VehType.Location = New System.Drawing.Point(80, 296)
        Me.Grb_VehType.Name = "Grb_VehType"
        Me.Grb_VehType.Size = New System.Drawing.Size(208, 32)
        Me.Grb_VehType.TabIndex = 7
        Me.Grb_VehType.TabStop = False
        '
        'cob_vehtype
        '
        Me.cob_vehtype.Location = New System.Drawing.Point(96, 8)
        Me.cob_vehtype.Name = "cob_vehtype"
        Me.cob_vehtype.Size = New System.Drawing.Size(104, 21)
        Me.cob_vehtype.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Vehicle Type "
        '
        'Grb_ason
        '
        Me.Grb_ason.Controls.Add(Me.dtp_ason)
        Me.Grb_ason.Controls.Add(Me.Label5)
        Me.Grb_ason.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb_ason.Location = New System.Drawing.Point(80, 40)
        Me.Grb_ason.Name = "Grb_ason"
        Me.Grb_ason.Size = New System.Drawing.Size(208, 32)
        Me.Grb_ason.TabIndex = 6
        Me.Grb_ason.TabStop = False
        '
        'dtp_ason
        '
        Me.dtp_ason.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ason.Location = New System.Drawing.Point(96, 8)
        Me.dtp_ason.Name = "dtp_ason"
        Me.dtp_ason.Size = New System.Drawing.Size(104, 21)
        Me.dtp_ason.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "As On Date"
        '
        'Grb_month
        '
        Me.Grb_month.Controls.Add(Me.Label3)
        Me.Grb_month.Controls.Add(Me.cob_month)
        Me.Grb_month.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb_month.Location = New System.Drawing.Point(80, 72)
        Me.Grb_month.Name = "Grb_month"
        Me.Grb_month.Size = New System.Drawing.Size(208, 32)
        Me.Grb_month.TabIndex = 5
        Me.Grb_month.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(16, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "During Month"
        '
        'cob_month
        '
        Me.cob_month.Location = New System.Drawing.Point(96, 8)
        Me.cob_month.Name = "cob_month"
        Me.cob_month.Size = New System.Drawing.Size(104, 21)
        Me.cob_month.TabIndex = 7
        '
        'Grb_Year
        '
        Me.Grb_Year.Controls.Add(Me.Label4)
        Me.Grb_Year.Controls.Add(Me.dtp_year)
        Me.Grb_Year.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb_Year.Location = New System.Drawing.Point(80, 104)
        Me.Grb_Year.Name = "Grb_Year"
        Me.Grb_Year.Size = New System.Drawing.Size(208, 32)
        Me.Grb_Year.TabIndex = 3
        Me.Grb_Year.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(16, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "During Year"
        '
        'dtp_year
        '
        Me.dtp_year.Location = New System.Drawing.Point(96, 8)
        Me.dtp_year.Name = "dtp_year"
        Me.dtp_year.Size = New System.Drawing.Size(104, 21)
        Me.dtp_year.TabIndex = 8
        '
        'Grbin_between
        '
        Me.Grbin_between.Controls.Add(Me.dtp_to)
        Me.Grbin_between.Controls.Add(Me.dtp_from)
        Me.Grbin_between.Controls.Add(Me.Label2)
        Me.Grbin_between.Controls.Add(Me.Label1)
        Me.Grbin_between.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grbin_between.Location = New System.Drawing.Point(8, 0)
        Me.Grbin_between.Name = "Grbin_between"
        Me.Grbin_between.Size = New System.Drawing.Size(352, 40)
        Me.Grbin_between.TabIndex = 2
        Me.Grbin_between.TabStop = False
        '
        'dtp_to
        '
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(232, 16)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(104, 18)
        Me.dtp_to.TabIndex = 6
        '
        'dtp_from
        '
        Me.dtp_from.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(72, 16)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(104, 18)
        Me.dtp_from.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From Date"
        '
        'btn_show
        '
        Me.btn_show.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show.Location = New System.Drawing.Point(144, 424)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(80, 24)
        Me.btn_show.TabIndex = 0
        Me.btn_show.Text = "Show"
        '
        'grb_state
        '
        Me.grb_state.Controls.Add(Me.Label9)
        Me.grb_state.Controls.Add(Me.cobstate)
        Me.grb_state.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_state.Location = New System.Drawing.Point(80, 200)
        Me.grb_state.Name = "grb_state"
        Me.grb_state.Size = New System.Drawing.Size(208, 32)
        Me.grb_state.TabIndex = 11
        Me.grb_state.TabStop = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "State"
        '
        'cobstate
        '
        Me.cobstate.Location = New System.Drawing.Point(96, 8)
        Me.cobstate.Name = "cobstate"
        Me.cobstate.Size = New System.Drawing.Size(104, 21)
        Me.cobstate.TabIndex = 11
        '
        'grb_city
        '
        Me.grb_city.Controls.Add(Me.Label10)
        Me.grb_city.Controls.Add(Me.cobcity)
        Me.grb_city.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_city.Location = New System.Drawing.Point(80, 232)
        Me.grb_city.Name = "grb_city"
        Me.grb_city.Size = New System.Drawing.Size(208, 32)
        Me.grb_city.TabIndex = 11
        Me.grb_city.TabStop = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "City"
        '
        'cobcity
        '
        Me.cobcity.Location = New System.Drawing.Point(96, 8)
        Me.cobcity.Name = "cobcity"
        Me.cobcity.Size = New System.Drawing.Size(104, 21)
        Me.cobcity.TabIndex = 11
        '
        'Reports
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(608, 477)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeView1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Grbvehno.ResumeLayout(False)
        Me.Grbvehno.PerformLayout()
        Me.GRBactivity.ResumeLayout(False)
        Me.GRBactivity.PerformLayout()
        Me.grblocations.ResumeLayout(False)
        Me.grblocations.PerformLayout()
        Me.grb_country.ResumeLayout(False)
        Me.Grb_Agent_type.ResumeLayout(False)
        Me.Grb_VehType.ResumeLayout(False)
        Me.Grb_VehType.PerformLayout()
        Me.Grb_ason.ResumeLayout(False)
        Me.Grb_month.ResumeLayout(False)
        Me.Grb_month.PerformLayout()
        Me.Grb_Year.ResumeLayout(False)
        Me.Grb_Year.PerformLayout()
        Me.Grbin_between.ResumeLayout(False)
        Me.Grbin_between.PerformLayout()
        Me.grb_state.ResumeLayout(False)
        Me.grb_city.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '
    'string variables compname, address,locations are used for formula fields in reports
    '
    'string variables a,b,c,d,e1,f,p,q,r are used for selection formula manipulations
    '
    Public a, b, c, d, e1, f, g, h, p, q, r, s As String
    Dim i As Integer

    Public cmd, cmd2 As OleDbCommand
    Dim ord As OleDbDataReader

    '
    'Procedure used for filling the formula fields in the reports
    '
    Public Sub databaseconnect(ByVal crp As Object)
        Dim Logoninfos As New TableLogOnInfos
        Dim Logoninfo As New TableLogOnInfo
        Dim Connectioninfo As New ConnectionInfo
        Dim crTables As Tables
        Dim crTable As Table
        Dim TableCounter
        Dim str As String
        With Connectioninfo
            '.ServerName = " "
            '.DatabaseName = ""
            .UserID = "ADMIN"
            .Password = ""
        End With
        crTables = crp.Database.Tables
        Try
            For Each crTable In crTables
                Logoninfo = crTable.LogOnInfo
                Logoninfo.ConnectionInfo = Connectioninfo
                crTable.ApplyLogOnInfo(Logoninfo)
                crTable.Location = Application.StartupPath & "\Travelz.mdb;"
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
        End Try
    End Sub
    Public Sub formulafill(ByVal str As Object)
        Dim compname, add, add1, address, city, state, country, locations, loc As String
        con.Open()
        i = 0
        Try
            cmd = New OleDbCommand("SELECT c1.companyname, c1.address, c1.address1, c2.city, s.state, c3.country FROM companymaster AS c1, citymaster AS c2, statemaster AS s, countrymaster AS c3 WHERE c1.CityId=c2.CityId and c1.StateId=s.StateId and c1.CountryId=c3.CountryId", con)
            ord = cmd.ExecuteReader
            If ord.Read Then
                compname = Trim(ord(0))
                add = Trim(ord(1))
                add1 = Trim(ord(2))
                city = Trim(ord(3))
                state = Trim(ord(4))
                country = Trim(ord(5))
            End If
            ord.Close()
            If compname = "" Then
                If MessageBox.Show("Company Details are not entered, Please enter and retry", "Company Name Not found?", MessageBoxButtons.OK) = DialogResult.OK Then
                    i = 1
                    Exit Sub
                End If
            End If
            address = add & "," & add1
            locations = city & ", " & state & ", " & country
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
        Finally
            str.DataDefinition.FormulaFields("compname").Text = " ' " & compname & " ' "
            str.DataDefinition.FormulaFields("address").Text = " ' " & address & " ' "
            str.DataDefinition.FormulaFields("Location").Text = " ' " & locations & " ' "
            CloseConnection()
        End Try
    End Sub
    Public Sub formulafill(ByVal report As Object, ByVal heading As String)
        Dim compname, add, add1, address, city, state, country, locations, loc As String
        con.Open()
        Try
            cmd = New OleDbCommand("SELECT c1.companyname, c1.address, c1.address1, c2.city, s.state, c3.country FROM companymaster AS c1, citymaster AS c2, statemaster AS s, countrymaster AS c3 WHERE c1.CityId=c2.CityId and c1.StateId=s.StateId and c1.CountryId=c3.CountryId", con)
            ord = cmd.ExecuteReader
            If ord.Read Then
                compname = Trim(ord(0))
                add = Trim(ord(1))
                add1 = Trim(ord(2))
                city = Trim(ord(3))
                state = Trim(ord(4))
                country = Trim(ord(5))
            End If
            ord.Close()
            address = add & "," & add1
            locations = city & ", " & state & ", " & country
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
        End Try
        report.DataDefinition.FormulaFields("compname").Text = " ' " & compname & " ' "
        report.DataDefinition.FormulaFields("address").Text = " ' " & address & " ' "
        report.DataDefinition.FormulaFields("Location").Text = " ' " & locations & " ' "
        report.DataDefinition.FormulaFields("ArrDep").Text = " ' " & heading & " ' "
    End Sub
    Public Sub reportgen(ByVal rpt As Object, ByVal frm As ReportViewer)
        Try
            databaseconnect(rpt)
            formulafill(rpt)
            If i = 1 Then
                Exit Sub
            End If
            frm.CrystalReportViewer1.ReportSource = rpt
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
        End Try
    End Sub
    Public Sub reportgen(ByVal rpt As Object, ByVal frm As ReportViewer, ByVal str As String)
        Try
            databaseconnect(rpt)
            formulafill(rpt, str)
            frm.CrystalReportViewer1.ReportSource = rpt
            frm.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
        End Try
    End Sub
    Public Sub hideall()
        Grb_Agent_type.Visible = False
        Grb_ason.Visible = False
        grb_city.Visible = False
        Grb_month.Visible = False
        grb_country.Visible = False
        grb_state.Visible = False
        Grb_VehType.Visible = False
        Grb_Year.Visible = False
        Grbin_between.Visible = False
        grblocations.Visible = False
        GRBactivity.Visible = False
        Grbvehno.Visible = False
    End Sub
    Public Sub showgroup(ByVal grb1 As GroupBox)
        grb1.Visible = True
    End Sub
    Public Sub showgroup(ByVal grb1 As GroupBox, ByVal grb2 As GroupBox)
        grb1.Visible = True
        grb2.Visible = True
    End Sub
    Public Sub showgroup(ByVal grb1 As GroupBox, ByVal grb2 As GroupBox, ByVal grb3 As GroupBox)
        grb1.Visible = True
        grb2.Visible = True
        grb3.Visible = True
    End Sub
    Public Sub showgroup(ByVal grb1 As GroupBox, ByVal grb2 As GroupBox, ByVal grb3 As GroupBox, ByVal grb4 As GroupBox)
        grb1.Visible = True
        grb2.Visible = True
        grb3.Visible = True
        grb4.Visible = True
    End Sub
    '
    'procedure used for showing message box when no report can be generated for the 
    'selection made in the tree view
    '
    Public Sub Noreport()
        MessageBox.Show("No option is selected, Please Select a option and then try", "Select a option then Try")
    End Sub
    '
    'Public Function getid(ByVal cobname As ComboBox)
    '    a = cobname.Text
    '    If a <> "" Then
    '        b = (a.Substring(a.IndexOf("-")))
    '        Return b
    '    End If
    'End Function
    'Public Function countrylist()
    '    a = cobcountry.Text
    '    If a <> "" Then
    '        b = (a.Substring(0, a.IndexOf("-")))
    '        Return b
    '    End If
    'End Function
    'Public Function statelist()
    '    c = cobstate.Text
    '    If c <> "" Then
    '        d = (c.Substring(0, c.IndexOf("-")))
    '        Return d
    '    End If
    'End Function
    'Public Function citylist()
    '    e1 = cobcity.Text
    '    If e1 <> "" Then
    '        f = (e1.Substring(0, e1.IndexOf("-")))
    '        Return f
    '    End If
    'End Function
    'Public Function agenttypelist()
    '    g = cob_agentype.Text
    '    If g <> "" Then
    '        h = (g.Substring(0, g.IndexOf("-")))
    '        Return h
    '    End If
    'End Function
    'Public Function vehtypelist()
    '    g = cob_vehtype.Text
    '    If g <> "" Then
    '        h = (g.Substring(0, g.IndexOf("-")))
    '        Return h
    '    End If
    'End Function
    'Public Function vehnolist()
    '    a = Cobvehicle.Text
    '    If g <> "" Then
    '        h = (g.Substring(0, g.IndexOf("-")))
    '        Return h
    '    End If
    'End Function
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        'If TreeView1.SelectedNode.Text = "List Of States" Then
        '    'grb_country.Visible = True
        '    hideall()
        '    showgroup(grb_country)
        'End If
        'If TreeView1.SelectedNode.Text = "Country Wise" Or TreeView1.SelectedNode.Text = "State Wise" Or TreeView1.SelectedNode.Text = "List Of Locations" Then
        '    hideall()
        '    showgroup(grb_country)
        'End If
        'If TreeView1.SelectedNode.Text = "List Of Agents" Then
        '    hideall()
        '    showgroup(grb_country, Grb_Agent_type)
        '    combofill1(cob_agentype, "select * from Agent_Type")
        'End If
        'If TreeView1.SelectedNode.Text = "Agent Wise" Then
        '    hideall()
        '    showgroup(Grb_Agent_type)
        '    combofill1(cob_agentype, "select * from Agent_Type")
        'End If
        'If TreeView1.SelectedNode.Text = "Between Any Dates" Then
        '    hideall()
        '    showgroup(Grbin_between)
        'End If
        'If TreeView1.SelectedNode.Text = "List Of Countries" Or TreeView1.SelectedNode.Text = "Activities Tariff" Then
        '    hideall()
        'End If
        'If TreeView1.SelectedNode.Text = "Available Vehicles As On Date" Or TreeView1.SelectedNode.Text = "List Of Vehicles" Or TreeView1.SelectedNode.Text = "Vehicle Allocation" Then
        '    hideall()
        '    showgroup(Grb_VehType)
        '    combofill1(cob_vehtype, "select VehTypeid,VehType from Veh_Type")
        'End If
        'If TreeView1.SelectedNode.Text = "Location Wise" Then
        '    hideall()
        '    showgroup(grblocations)
        'End If
        'If TreeView1.SelectedNode.Text = "Activity Wise Bookings" Then
        '    hideall()
        '    showgroup(GRBactivity, Grbin_between)
        '    combofill1(Cobactivi, "select Activ_ID,activity from activity")
        'End If
        'If TreeView1.SelectedNode.Text = " Vehicle Wise Bookings" Then
        '    hideall()
        '    showgroup(Grbvehno, Grbin_between)
        '    Dim ord As OleDb.OleDbDataReader
        '    Openconnection()
        '    cmd = New OleDb.OleDbCommand("select distinct(RegNo) from Veh_DutySlip", con)
        '    ord = cmd.ExecuteReader
        '    While ord.Read
        '        Cobvehicle.Items.Add(ord(0))
        '    End While
        '    ord.Close()
        '    cmd.Dispose()
        '    CloseConnection()
        'End If
        If TreeView1.SelectedNode.Text = "Invoice" Then
            hideall()
        End If

        If TreeView1.SelectedNode.Text = "List Of Countries" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "List Of States" Then
            hideall()
            showgroup(grb_country)
        End If
        If TreeView1.SelectedNode.Text = "Country Wise" Then
            hideall()
            showgroup(grb_country)
        End If
        If TreeView1.SelectedNode.Text = "State Wise" Then
            hideall()
            showgroup(grb_country)
        End If
        If TreeView1.SelectedNode.Text = "List Of Locations" Then
            hideall()
            showgroup(grb_country)
        End If
        If TreeView1.SelectedNode.Text = "List Of Agents" Then
            hideall()
            showgroup(grb_country, Grb_Agent_type)
        End If
        If TreeView1.SelectedNode.Text = "List Of Vehicles" Then
            hideall()
            showgroup(Grb_VehType)
            combofill1(cob_vehtype, "select VehTypeid,VehType from Veh_Type")
        End If
        If TreeView1.SelectedNode.Text = "Available Vehicles As On Date" Then
            hideall()
            showgroup(Grb_VehType)
            combofill1(cob_vehtype, "select VehTypeid,VehType from Veh_Type")
        End If
        If TreeView1.SelectedNode.Text = "List Of Staff" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Hotels State Wise" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Hotels City Wise" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Hotels In Chain" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Flight Arrivals" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Flight Departures" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Ferry Arrivals" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Ferry Departures" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Between Any Dates" Then
            hideall()
            showgroup(Grbin_between)
        End If
        If TreeView1.SelectedNode.Text = "Agents" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Customer's" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Hotels" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Staff" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Activity Providers" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Travles Agents" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Airlines Travels Agents" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Activities Tariff" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Activity Wise Bookings" Then
            hideall()
            showgroup(GRBactivity, Grbin_between)
            combofill1(Cobactivi, "select Activ_ID,activity from activity")
        End If
        If TreeView1.SelectedNode.Text = "List Of Activity Providers" Then
            hideall()
            showgroup(grb_country)
        End If
        If TreeView1.SelectedNode.Text = "Hotel Facilities" Then
            hideall()
            showgroup(grb_country)
        End If
        If TreeView1.SelectedNode.Text = "Hotel Meal Tariff" Then
            hideall()
            showgroup(grb_country)
        End If
        If TreeView1.SelectedNode.Text = "Hotel RoomTariff" Then
            hideall()
            showgroup(grb_country)
        End If
        If TreeView1.SelectedNode.Text = "List of Location Distance" Then
            hideall()
            showgroup(grb_country)
        End If
        If TreeView1.SelectedNode.Text = "Agent Wise" Then
            hideall()
            showgroup(Grb_Agent_type)

        End If
        If TreeView1.SelectedNode.Text = "Vehicle Allocation" Then
            hideall()
            showgroup(Grbvehno, Grbin_between)
            combofill1(Cobvehicle, "select distinct(RegNo) from Veh_DutySlip")
        End If
        If TreeView1.SelectedNode.Text = "Bookings" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Location Wise" Then
            hideall()
            showgroup(grblocations)
        End If
        If TreeView1.SelectedNode.Text = "Vehicle Wise Bookings " Then
            hideall()
            showgroup(Grbvehno, Grbin_between)
            combofill1(Cobvehicle, "select distinct(RegNo) from Veh_DutySlip")
        End If
        '
        'Nodes with out reports
        '
        If TreeView1.SelectedNode.Text = "" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Reports" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Activity" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Admin" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Customers" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Hotel" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Itineraries" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Mailing List" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Vehicles" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Ferry Timings" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Flight Timings" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "List Of Cities" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "List Of Hotels" Then
            hideall()
        End If
        If TreeView1.SelectedNode.Text = "Hotel Reservation" Then
            hideall()
        End If
    End Sub

    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        combofill1(cobcountry, "select * from countrymaster")
        combofill1(cob_agentype, "select * from Agent_Type")
        hideall()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        '
        'Checking for the invalid requests

        If TreeView1.SelectedNode.Text = "Invoice" Then

            showinvoice()
        End If
        '
        If TreeView1.SelectedNode.Text = "" Then
            Noreport()
        End If
        'Reports
        If TreeView1.SelectedNode.Text = "Reports" Then
            Noreport()
        End If
        'Masters
        If TreeView1.SelectedNode.Text = "Masters" Then
            Noreport()
        End If
        'Customers
        If TreeView1.SelectedNode.Text = "Customers" Then
            Noreport()
        End If
        'Mailing List
        If TreeView1.SelectedNode.Text = "Mailing List" Then
            Noreport()
        End If
        'Itineraries
        If TreeView1.SelectedNode.Text = "Itineraries" Then
            Noreport()
        End If
        'List Of Cities
        If TreeView1.SelectedNode.Text = "List Of Cities" Then
            Noreport()
        End If
        'List Of Hotels
        If TreeView1.SelectedNode.Text = "List Of Hotels" Then
            Noreport()
        End If
        'Flight Timings
        If TreeView1.SelectedNode.Text = "Flight Timings" Then
            Noreport()
        End If
        'Ferry Timings
        If TreeView1.SelectedNode.Text = "Ferry Timings" Then
            Noreport()
        End If
        'Hotel Reservation
        If TreeView1.SelectedNode.Text = "Hotel Reservation" Then
            Noreport()
        End If
        If TreeView1.SelectedNode.Text = "Hotel" Then
            Noreport()
        End If
        If TreeView1.SelectedNode.Text = "Vehicles" Then
            Noreport()
        End If

        '
        'Checking for valid requests for which reports can be generated
        '

        'Report for List of Countries
        If TreeView1.SelectedNode.Text = "List Of Countries" Then
            countryrep()
        End If
        'Report for List of States based on country selected

        If TreeView1.SelectedNode.Text = "List Of States" Then
            staterep()
        End If
        'Report for list of cities country wise based on selection made
        If TreeView1.SelectedNode.Text = "Country Wise" Then
            citycountryrep()
        End If
        If TreeView1.SelectedNode.Text = "State Wise" Then
            citystaterep()
        End If
        If TreeView1.SelectedNode.Text = "List Of Locations" Then
            locate()
        End If
        If TreeView1.SelectedNode.Text = "List Of Agents" Then
            agentrep()
        End If
        If TreeView1.SelectedNode.Text = "List Of Vehicles" Then
            ownvehrep()
        End If
        If TreeView1.SelectedNode.Text = "Available Vehicles As On Date" Then
            availvehrep()
        End If
        If TreeView1.SelectedNode.Text = "List Of Staff" Then
            staffrep()
        End If
        If TreeView1.SelectedNode.Text = "Hotels State Wise" Then
            hotelstaterep()
        End If
        If TreeView1.SelectedNode.Text = "Hotels City Wise" Then
            hotelcityrep()
        End If
        If TreeView1.SelectedNode.Text = "Hotels In Chain" Then
            hotelchainrep()
        End If
        If TreeView1.SelectedNode.Text = "Flight Arrivals" Then
            flightarrivals()
        End If
        If TreeView1.SelectedNode.Text = "Flight Departures" Then
            flightdepartures()
        End If
        If TreeView1.SelectedNode.Text = "Ferry Arrivals" Then
            ferryarrivalsrep()
        End If
        If TreeView1.SelectedNode.Text = "Ferry Departures" Then
            ferrydepartures()
        End If
        If TreeView1.SelectedNode.Text = "Between Any Dates" Then
            custbtwdates()
        End If
        If TreeView1.SelectedNode.Text = "Agents" Then
            mailagentrep()
        End If
        If TreeView1.SelectedNode.Text = "Customer's" Then
            mailcustrep()
        End If
        If TreeView1.SelectedNode.Text = "Hotels" Then
            mailhotelrep()
        End If
        If TreeView1.SelectedNode.Text = "Staff" Then
            mailstaffrep()
        End If
        If TreeView1.SelectedNode.Text = "Activity Providers" Then
            mailactivityprorep()
        End If
        If TreeView1.SelectedNode.Text = "Travles Agents" Then
            mailtravelsrep()
        End If
        If TreeView1.SelectedNode.Text = "Airlines Travels Agents" Then
            mailairlinetravelsrep()
        End If
        If TreeView1.SelectedNode.Text = "Activities Tariff" Then
            activityrep()
        End If
        If TreeView1.SelectedNode.Text = "Activity Wise Bookings" Then
            Act_Wise_Booking()
        End If

        If TreeView1.SelectedNode.Text = "List Of Activity Providers" Then
            activityproviderrep()
        End If
        If TreeView1.SelectedNode.Text = "Hotel Facilities" Then
            hotelfacilitesrep()
        End If
        If TreeView1.SelectedNode.Text = "Hotel Meal Tariff" Then
            hotelmealtariffrep()
        End If
        If TreeView1.SelectedNode.Text = "Hotel RoomTariff" Then
            hotelroomtariffrep()
        End If
        If TreeView1.SelectedNode.Text = "List of Location Distance" Then
            locationdistance()
        End If
        If TreeView1.SelectedNode.Text = "Agent Wise" Then
            custagentwise()
        End If
        If TreeView1.SelectedNode.Text = "Vehicle Allocation" Then
            vehallo()
        End If
        If TreeView1.SelectedNode.Text = "Bookings" Then
            custbooking()
        End If
        If TreeView1.SelectedNode.Text = "Location Wise" And coblocation.Text = "" Then
            custlist()
        End If
        If TreeView1.SelectedNode.Text = "Location Wise" And coblocation.Text = "Country Wise" Then
            custlist("Country Wise")
        End If
        If TreeView1.SelectedNode.Text = "Location Wise" And coblocation.Text = "State Wise" Then
            custlist("State Wise")
        End If
        If TreeView1.SelectedNode.Text = "Location Wise" And coblocation.Text = "City Wise" Then
            custlist("City Wise")
        End If
        If TreeView1.SelectedNode.Text = "Vehicle Wise Bookings " Then
            vehwisebooking()
        End If

    End Sub
    Private Sub cobcountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobcountry.SelectedIndexChanged
        If TreeView1.SelectedNode.Text = "Country Wise" Or TreeView1.SelectedNode.Text = "State Wise" Or TreeView1.SelectedNode.Text = "List Of Locations" Or TreeView1.SelectedNode.Text = "List Of Agents" Then
            showgroup(grb_state)
            p = getid(cobcountry)
            If p = "" Then
            Else
                cobstate.Items.Clear()
                combofill1(cobstate, "select stateid,state from statemaster where countryid='" & p & "'")
            End If
        End If
    End Sub

    Private Sub cobstate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobstate.SelectedIndexChanged
        If TreeView1.SelectedNode.Text = "List Of Locations" Or TreeView1.SelectedNode.Text = "List Of Agents" Then
            showgroup(grb_city)
            cobcity.Items.Clear()
            r = getid(cobstate)
            If r = "" Then
            Else
                combofill1(cobcity, "select cityid,city from citymaster where stateid='" & r & "'")
            End If
        End If
    End Sub
    Private Sub locate()
        Dim location As New ReportViewer
        Dim rptlocation As New rptlistoflocations
        p = getid(cobcountry)
        If p = "" Then
        Else
            rptlocation.RecordSelectionFormula = " {CountryMaster.CountryId} = '" & p & " ' "
        End If
        q = getid(cobstate)
        If q = "" Then
        Else
            rptlocation.RecordSelectionFormula = " {statemaster.stateid} = '" & q & " ' "
        End If
        r = getid(cobcity)
        If r = "" Then
        Else
            rptlocation.RecordSelectionFormula = " {citymaster.cityid} = '" & r & " ' "
        End If
        reportgen(rptlocation, location)
    End Sub
    Private Sub staterep()
        Dim statelist As New ReportViewer
        Dim rptstate As New rptlistofstates
        p = getid(cobcountry)
        If p = "" Then
        Else
            rptstate.RecordSelectionFormula = " {CountryMaster.CountryId} = '" & p & " ' "
        End If
        reportgen(rptstate, statelist)
    End Sub
    Private Sub citycountryrep()
        Dim citycountry As New ReportViewer
        Dim rptcitycountry As New rptlistofcities_country
        p = getid(cobcountry)
        If p = "" Then
        Else
            rptcitycountry.RecordSelectionFormula = " {CountryMaster.CountryId} = '" & p & " ' "
        End If
        q = getid(cobstate)
        If q = "" Then
        Else
            rptcitycountry.RecordSelectionFormula = " {statemaster.stateid} = '" & q & " ' "
        End If
        'databaseconnect(rptcitycountry)
        'formulafill(rptcitycountry)
        'citycountry.CrystalReportViewer1.ReportSource = rptcitycountry
        'citycountry.Show()
        reportgen(rptcitycountry, citycountry)
    End Sub
    Private Sub citystaterep()
        Dim citystate As New ReportViewer
        Dim rptcitystate As New rptlistofcities_state
        p = getid(cobcountry)
        If p = "" Then
        Else
            rptcitystate.RecordSelectionFormula = " {CountryMaster.CountryId} = '" & p & " ' "
        End If
        q = getid(cobstate)
        If q = "" Then
        Else
            rptcitystate.RecordSelectionFormula = " {statemaster.stateid} = '" & q & " ' "
        End If
        reportgen(rptcitystate, citystate)
    End Sub
    Private Sub countryrep()
        Dim countrylist As New ReportViewer
        Dim rptcountry As New rptlistofcountries
        reportgen(rptcountry, countrylist)
    End Sub
    Private Sub agentrep()
        Dim agentlist As New ReportViewer
        Dim rptagent As New rptagentmast
        p = getid(cobcountry)
        If p = "" Then
        Else
            rptagent.RecordSelectionFormula = " {CountryMaster.CountryId} = '" & p & " ' "
        End If
        q = getid(cobstate)
        If q = "" Then
        Else
            rptagent.RecordSelectionFormula = " {statemaster.stateid} = '" & q & " ' "
        End If
        r = getid(cobcity)
        If r = "" Then
        Else
            rptagent.RecordSelectionFormula = " {citymaster.cityid} = '" & r & " ' "
        End If
        s = getid(cob_agentype)
        If s = "" Then
        Else
            rptagent.RecordSelectionFormula = " {Agent_Type.Agenttypeid} = '" & s & " ' "
        End If
        reportgen(rptagent, agentlist)
    End Sub
    Private Sub ownvehrep()
        Dim ownvehlist As New ReportViewer
        Dim rptownveh As New rptlistofownvehicles1
        Dim own As String
        own = "List Of Own Vehicles"
        databaseconnect(rptownveh)
        s = getid(cob_vehtype)
        If s = "" Then
        Else
            rptownveh.RecordSelectionFormula = " {Veh_Type.VehTypeid} = '" & s & " ' "
        End If
        reportgen(rptownveh, ownvehlist)
    End Sub
    Private Sub staffrep()
        Dim stafflist As New ReportViewer
        Dim rptstafflist As New rptlistofstaff
        reportgen(rptstafflist, stafflist)
    End Sub
    Private Sub hotelstaterep()
        Dim hotelliststatewise As New ReportViewer
        Dim rpthotelstate As New rptlistofhotelsstatewise
        reportgen(rpthotelstate, hotelliststatewise)
    End Sub
    Private Sub hotelcityrep()
        Dim hotellistcitywise As New ReportViewer
        Dim rpthotelcity As New rptlistofhotelscitywise
        reportgen(rpthotelcity, hotellistcitywise)
    End Sub
    Private Sub hotelchainrep()
        Dim hotellistinchain As New ReportViewer
        Dim rpthotelchain As New rptlistofhotelsinchain
        reportgen(rpthotelchain, hotellistinchain)
    End Sub
    Private Sub custbtwdates()
        Dim custlist As New ReportViewer
        Dim rptcustbtwdateslist As New rptcustbtwdates
        rptcustbtwdateslist.RecordSelectionFormula = "{Cust_Master.Cust_JDate} > #" & dtp_from.Value & "#   And {Cust_Master.Cust_JDate} < #" & dtp_to.Value & "#"
        reportgen(rptcustbtwdateslist, custlist)
    End Sub
    Private Sub mailagentrep()
        Dim mailagent As New ReportViewer
        Dim rptmailagent As New rptmaillistagents
        databaseconnect(rptmailagent)
        mailagent.CrystalReportViewer1.ReportSource = rptmailagent
        mailagent.Show()
    End Sub
    Private Sub mailcustrep()
        Dim mailcust As New ReportViewer
        Dim rptmailcust As New rptmaillistcustomers
        databaseconnect(rptmailcust)
        mailcust.CrystalReportViewer1.ReportSource = rptmailcust
        mailcust.Show()
    End Sub
    Private Sub mailhotelrep()
        Dim mailhotel As New ReportViewer
        Dim rptmailhotel As New rptmaillisthotels
        databaseconnect(rptmailhotel)
        mailhotel.CrystalReportViewer1.ReportSource = rptmailhotel
        mailhotel.Show()
    End Sub
    Private Sub mailstaffrep()
        Dim mailstaff As New ReportViewer
        Dim rptmailstaff As New rptmailliststaff
        databaseconnect(rptmailstaff)
        mailstaff.CrystalReportViewer1.ReportSource = rptmailstaff
        mailstaff.Show()
    End Sub
    Private Sub mailactivityprorep()
        Dim mailactivitypro As New ReportViewer
        Dim rptmailactivitypro As New rptmailistactivityproviders
        databaseconnect(rptmailactivitypro)
        mailactivitypro.CrystalReportViewer1.ReportSource = rptmailactivitypro
        mailactivitypro.Show()
    End Sub
    Private Sub mailtravelsrep()
        Dim mailtravels As New ReportViewer
        Dim rptmailtravles As New rptmailisttravles
        databaseconnect(rptmailtravles)
        mailtravels.CrystalReportViewer1.ReportSource = rptmailtravles
        mailtravels.Show()
    End Sub
    Private Sub mailairlinetravelsrep()
        Dim mailairlinetravels As New ReportViewer
        Dim rptmailairlinetravles As New rptmailistairlines
        databaseconnect(rptmailairlinetravles)
        mailairlinetravels.CrystalReportViewer1.ReportSource = rptmailairlinetravles
        mailairlinetravels.Show()
    End Sub
    Private Sub activityrep()
        Dim activity As New ReportViewer
        Dim rptactivity As New rptlistofactivities
        reportgen(rptactivity, activity)
    End Sub
    Private Sub activityproviderrep()
        Dim activityprovider As New ReportViewer
        Dim rptactivityprovider As New rptlistofactivityproviders
        reportgen(rptactivityprovider, activityprovider)
    End Sub
    Private Sub hotelfacilitesrep()
        Dim hotelfacliites As New ReportViewer
        Dim rpthotelfacilites As New rpthotelfacilities
        reportgen(rpthotelfacilites, hotelfacliites)
    End Sub
    Private Sub hotelmealtariffrep()
        Dim hotelmealtariff As New ReportViewer
        Dim rpthotelmealtariff As New rpthotelmealtariff
        reportgen(rpthotelmealtariff, hotelmealtariff)
    End Sub
    Private Sub hotelroomtariffrep()
        Dim hotelroomtariff As New ReportViewer
        Dim rpthotelroomtariff As New rpthotelroomtariff
        reportgen(rpthotelroomtariff, hotelroomtariff)
    End Sub
    Private Sub flightarrivals()
        Dim flightarrivals As New ReportViewer
        Dim rptflightarrivals As New rptflightarrdep
        Dim fno(15), fcode(10), fname(25), fcity(50), fport(20), tcity(50), tport(20), fad(12) As String
        Dim dttime(25) As DateTime
        Dim i As Integer
        Dim rc As Integer
        i = 0
        con.Open()
        Try
            cmd = New OleDbCommand("select f.FlightNo,FlightCode, f.FlightName, c1.City as FromCity,f.FromAirport, c2.City as ToCity,f.ToAirport, f.ArrdepTime,f.Flight_ArrDep from CityMaster as c1, CityMaster as c2, Flight_Details as f where f.FromCityId=c1.CityId and f.ToCityId=c2.CityId", con)
            ord = cmd.ExecuteReader
            While ord.Read
                fno(i) = ord(0)
                fcode(i) = ord(1)
                fname(i) = ord(2)
                fcity(i) = ord(3)
                fport(i) = ord(4)
                tcity(i) = ord(5)
                tport(i) = ord(6)
                dttime(i) = ord(7)
                fad(i) = ord(8)
                i += 1
            End While
            ord.Close()
            cmd.Dispose()
            cmd = New OleDbCommand("delete * from RepFlightArrDep", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            rc = i
            For i = 0 To rc - 1
                cmd2 = New OleDbCommand("insert into RepFlightArrDep values('" & fno(i) & "','" & fcode(i) & "','" & fname(i) & "','" & fcity(i) & "','" & fport(i) & "','" & tcity(i) & "','" & tport(i) & "','" & FormatDateTime(dttime(i), DateFormat.LongTime) & "','" & fad(i) & "')", con)
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()
            Next
            CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        End Try
        Dim a, b, c As String
        a = "Arr"
        b = "List Of Flight Arrivals"
        c = "ArrDep"
        rptflightarrivals.RecordSelectionFormula = " {RepFlightArrDep.ArrDep} = '" & a & " ' "
        reportgen(rptflightarrivals, flightarrivals, b)
    End Sub
    Private Sub flightdepartures()
        Dim flightdeps As New ReportViewer
        Dim rptflightdepartures As New rptflightarrdep
        Dim fno(15), fcode(10), fname(25), fcity(50), fport(20), tcity(50), tport(20), fad(12) As String
        Dim dttime(25) As DateTime
        Dim i As Integer
        Dim rc As Integer
        i = 0
        con.Open()
        Try
            cmd = New OleDbCommand("select f.FlightNo,FlightCode, f.FlightName, c1.City as FromCity,f.FromAirport, c2.City as ToCity,f.ToAirport, f.ArrdepTime,f.Flight_ArrDep from CityMaster as c1, CityMaster as c2, Flight_Details as f where f.FromCityId=c1.CityId and f.ToCityId=c2.CityId", con)
            ord = cmd.ExecuteReader
            While ord.Read
                fno(i) = ord(0)
                fcode(i) = ord(1)
                fname(i) = ord(2)
                fcity(i) = ord(3)
                fport(i) = ord(4)
                tcity(i) = ord(5)
                tport(i) = ord(6)
                dttime(i) = ord(7)
                fad(i) = ord(8)
                i += 1
            End While
            ord.Close()
            cmd.Dispose()
            cmd = New OleDbCommand("delete * from RepFlightArrDep", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            rc = i
            For i = 0 To rc - 1
                cmd2 = New OleDbCommand("insert into RepFlightArrDep values('" & fno(i) & "','" & fcode(i) & "','" & fname(i) & "','" & fcity(i) & "','" & fport(i) & "','" & tcity(i) & "','" & tport(i) & "','" & FormatDateTime(dttime(i), DateFormat.LongTime) & "','" & fad(i) & "')", con)
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()
            Next
            CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        End Try
        Dim a, b, c As String
        a = "Dep"
        b = "List Of Flight Departures"
        c = "ArrDep"
        rptflightdepartures.RecordSelectionFormula = " {RepFlightArrDep.ArrDep} = '" & a & " ' "
        reportgen(rptflightdepartures, flightdeps, b)
    End Sub
    Private Sub ferryarrivalsrep()
        Dim ferryarrivals As New ReportViewer
        Dim rptferryarrivals As New rptferryarrdep
        Dim fno(15), fcode(10), fname(25), fcity(50), fport(20), tcity(50), tport(20), fad(12) As String
        Dim dttime(25) As DateTime
        Dim i As Integer
        Dim rc As Integer
        i = 0
        con.Open()
        Try
            cmd = New OleDbCommand("select f.FerryNo,FerryCode, f.FerryName, c1.City as FromCity,f.FromPort, c2.City as ToCity,f.ToPort, f.ArrdepTime,f.Ferry_ArrDep from CityMaster as c1, CityMaster as c2, Ferry_Details as f where f.FromCityId=c1.CityId and f.ToCityId=c2.CityId", con)
            ord = cmd.ExecuteReader
            While ord.Read
                fno(i) = ord(0)
                fcode(i) = ord(1)
                fname(i) = ord(2)
                fcity(i) = ord(3)
                fport(i) = ord(4)
                tcity(i) = ord(5)
                tport(i) = ord(6)
                dttime(i) = ord(7)
                fad(i) = ord(8)
                i += 1
            End While
            ord.Close()
            cmd.Dispose()
            cmd = New OleDbCommand("delete * from RepFerryArrDep", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            rc = i
            For i = 0 To rc - 1
                cmd2 = New OleDbCommand("insert into RepFerryArrDep values('" & fno(i) & "','" & fcode(i) & "','" & fname(i) & "','" & fcity(i) & "','" & fport(i) & "','" & tcity(i) & "','" & tport(i) & "','" & FormatDateTime(dttime(i), DateFormat.LongTime) & "','" & fad(i) & "')", con)
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()
            Next
            CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        End Try
        Dim a, b, c As String
        a = "Arr"
        b = "List Of Ferry Arrivals"
        c = "ArrDep"
        rptferryarrivals.RecordSelectionFormula = " {RepFerryArrDep.ArrDep} = '" & a & " ' "
        reportgen(rptferryarrivals, ferryarrivals, b)
    End Sub
    Private Sub ferrydepartures()
        Dim ferrydeps As New ReportViewer
        Dim rptferrydepartures As New rptferryarrdep
        Dim fno(15), fcode(10), fname(25), fcity(50), fport(20), tcity(50), tport(20), fad(12) As String
        Dim dttime(25) As DateTime
        Dim i As Integer
        Dim rc As Integer
        i = 0
        con.Open()
        Try
            cmd = New OleDbCommand("select f.FerryNo,FerryCode, f.FerryName, c1.City as FromCity,f.FromPort, c2.City as ToCity,f.ToPort, f.ArrdepTime,f.Ferry_ArrDep from CityMaster as c1, CityMaster as c2, Ferry_Details as f where f.FromCityId=c1.CityId and f.ToCityId=c2.CityId", con)
            ord = cmd.ExecuteReader
            While ord.Read
                fno(i) = ord(0)
                fcode(i) = ord(1)
                fname(i) = ord(2)
                fcity(i) = ord(3)
                fport(i) = ord(4)
                tcity(i) = ord(5)
                tport(i) = ord(6)
                dttime(i) = ord(7)
                fad(i) = ord(8)
                i += 1
            End While
            ord.Close()
            cmd.Dispose()
            cmd = New OleDbCommand("delete * from RepFerryArrDep", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            rc = i
            For i = 0 To rc - 1
                'cmd2 = New OleDbCommand("insert into repdistance values('" & sql(i) & "','" & sql1(i) & "'," & kms(i) & ",'" & cmn(i) & "')", con)
                cmd2 = New OleDbCommand("insert into RepFerryArrDep values('" & fno(i) & "','" & fcode(i) & "','" & fname(i) & "','" & fcity(i) & "','" & fport(i) & "','" & tcity(i) & "','" & tport(i) & "','" & FormatDateTime(dttime(i), DateFormat.LongTime) & "','" & fad(i) & "')", con)
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()
            Next
            CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        End Try
        Dim a, b, c As String
        a = "Dep"
        b = "List Of Ferry Departures"
        c = "ArrDep"
        rptferrydepartures.RecordSelectionFormula = " {RepFerryArrDep.ArrDep} = '" & a & " ' "
        reportgen(rptferrydepartures, ferrydeps, b)
    End Sub
    Private Sub locationdistance()
        Dim locationdist As New ReportViewer
        Dim rptlocationdist As New rptlocdist
        Dim sql(25), sql1(25), cmn(25) As String
        Dim kms(25), i As Integer
        Dim rc As Integer
        i = 0
        con.Open()
        Try
            cmd = New OleDbCommand("select fl.location,tl.location,d.kms,d.remarks from locationmaster fl,locationmaster tl,distance d where fl.locationid=d.flocationid and tl.locationid=d.tlocationid ", con)
            ord = cmd.ExecuteReader
            While ord.Read
                sql(i) = ord(0)
                sql1(i) = ord(1)
                kms(i) = ord(2)
                cmn(i) = ord(3)
                i += 1
            End While
            ord.Close()
            cmd.Dispose()
            cmd = New OleDbCommand("delete * from repdistance", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            rc = i
            For i = 0 To rc - 1
                cmd2 = New OleDbCommand("insert into repdistance values('" & sql(i) & "','" & sql1(i) & "'," & kms(i) & ",'" & cmn(i) & "')", con)
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()
            Next
            CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, Prjtitle)
            CloseConnection()
            Exit Sub
        End Try
        reportgen(rptlocationdist, locationdist)
    End Sub
    Public Sub printproc()
        MsgBox("Print Option Is Not Available", MsgBoxStyle.OKOnly, Prjtitle)
    End Sub
    Public Sub delproc()

    End Sub
    Public Sub saveproc()

    End Sub
    Public Sub editproc()

    End Sub
    Public Sub newproc()

    End Sub
    Public Sub clearproc()

    End Sub
    Private Sub availvehrep()
        Dim availvehlist As New ReportViewer
        Dim rptavailveh As New rptlistofownvehicles1
        Dim a, avail As String
        a = "Y"
        avail = "List Of Available Vehicles As On Date"
        databaseconnect(rptavailveh)
        rptavailveh.RecordSelectionFormula = " {OwnVehicleMaster.Availab_Flag} = '" & a & " ' "
        s = getid(cob_vehtype)
        If s = "" Then
        Else
            rptavailveh.RecordSelectionFormula = " {Veh_Type.VehTypeid} = '" & s & " ' "
        End If
        reportgen(rptavailveh, availvehlist)
    End Sub
    Private Sub custagentwise()
        Dim custagentrep As New ReportViewer
        Dim rptcustagent As New rptlistofcustomers
        Dim agent As String
        agent = "List Of Customers Agentwise"
        databaseconnect(rptcustagent)
        s = getid(cob_agentype)
        If s = "" Then
        Else
            rptcustagent.RecordSelectionFormula = " {Agent_Type.Agenttypeid} = '" & s & " ' "
        End If
        'formulafill(rptcustagent)
        'rptcustagent.DataDefinition.FormulaFields("details").Text = " ' " & agent & " ' "
        'custagentrep.CrystalReportViewer1.ReportSource = rptcustagent
        'custagentrep.Show()
        reportgen(rptcustagent, custagentrep)
    End Sub
    Private Sub vehallo()
        Dim vehallrep As New ReportViewer
        Dim rptvehall As New rptvehallo
        databaseconnect(rptvehall)
        s = getid(cob_vehtype)
        If s = "" Then
        Else
            rptvehall.RecordSelectionFormula = " {Veh_Type.VehTypeid} = '" & s & " ' "
        End If
        formulafill(rptvehall)
        vehallrep.CrystalReportViewer1.ReportSource = rptvehall
        vehallrep.Show()
    End Sub
    Private Sub vehwisebooking()
        Dim vehbooking As New ReportViewer
        Dim rptveh As New rptVehicle_wise_booking
        rptveh.DataDefinition.RecordSelectionFormula = "{veh_voucher.veh_vouchdt} > #" & dtp_from.Value & "#   And {veh_voucher.veh_vouchdt} < #" & dtp_to.Value & "#"
        reportgen(rptveh, vehbooking)

    End Sub
    Private Sub custbooking()
        Dim custbooking As New ReportViewer
        Dim rptcustbooking As New rptcustbookings
        showgroup(Grbin_between)
        rptcustbooking.DataDefinition.RecordSelectionFormula = "{Booking_Itinary.Bkdate} > #" & dtp_from.Value & "#   And {Booking_Itinary.Bkdate} < #" & dtp_to.Value & "#"
        reportgen(rptcustbooking, custbooking)
    End Sub
    Private Sub custlist(ByVal loc As String)
        Dim custrep As New ReportViewer
        Dim rptcust As New rptlistofcustomers
        Dim heading, details As String
        heading = "List of Customers " + loc
        details = "details"
        databaseconnect(rptcust)
        formulafill(rptcust)
        rptcust.DataDefinition.FormulaFields("details").Text = " ' " & heading & " ' "
        custrep.CrystalReportViewer1.ReportSource = rptcust
        custrep.Show()

    End Sub
    Private Sub custlist()
        Dim custrep As New ReportViewer
        Dim rptcust As New rptlistofcustomers
        reportgen(rptcust, custrep)
    End Sub
    Private Sub Act_Wise_Booking()
        Dim activitybooking As New ReportViewer
        Dim rptactivitybooking As New rptActivityWiseBookings
        Dim i As Integer
        Dim str, str1 As String
        If Cobactivi.Text <> "" Then
            i = InStr(Cobactivi.Text, "-")
            str = Mid(Cobactivi.Text, 1, i - 1)
            str1 = Mid(Cobactivi.Text, i + 1)
            str1 = " Activity = " & str1
            rptactivitybooking.DataDefinition.FormulaFields("Activity").Text = "'" & str1 & "'"
            rptactivitybooking.DataDefinition.RecordSelectionFormula = "{Activ_Voucher.ActVouDt} > #" & dtp_from.Value & "#   And {Activ_Voucher.ActVouDt} < #" & dtp_to.Value & "# And {Activ_Voucher.Activ_ID} = '" & str & "'"
            reportgen(rptactivitybooking, activitybooking)
        Else
            rptactivitybooking.DataDefinition.RecordSelectionFormula = "{Activ_Voucher.ActVouDt} > #" & dtp_from.Value & "#   And {Activ_Voucher.ActVouDt} < #" & dtp_to.Value & "#"
            reportgen(rptactivitybooking, activitybooking)
        End If
    End Sub

    Private Sub Showinvoice()
        Dim invo As New ReportViewer
        Dim rptinvo As New Tprinvoice


        ' '' ''Dim citycountry As New ReportViewer
        ' '' ''Dim rptcitycountry As New rptlistofcities_country
        ' '' ''p = getid(cobcountry)
        If Txtinvoice.Text = "" Then
            MsgBox(" Enter invoice no", MsgBoxStyle.OkOnly, Prjtitle)
        Else
            rptinvo.RecordSelectionFormula = " {CountryMaster.CountryId} = '" & p & " ' "

        End If

        databaseconnect(rptinvo)
        formulafill(rptinvo)
        invo.CrystalReportViewer1.ReportSource = rptinvo
        invo.Show()


        ' '' ''Else
        ' '' ''    rptcitycountry.RecordSelectionFormula = " {CountryMaster.CountryId} = '" & p & " ' "
        ' '' ''End If
        ' '' ''q = getid(cobstate)
        ' '' ''If q = "" Then
        ' '' ''Else
        ' '' ''    rptcitycountry.RecordSelectionFormula = " {statemaster.stateid} = '" & q & " ' "
        ' '' ''End If
        'databaseconnect(rptcitycountry)
        'formulafill(rptcitycountry)
        'citycountry.CrystalReportViewer1.ReportSource = rptcitycountry
        'citycountry.Show()
        ' '' ''reportgen(rptcitycountry, citycountry)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
