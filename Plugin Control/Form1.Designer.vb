<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ColumnHeader7 As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloseUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader7
        '
        ColumnHeader7.Text = ""
        ColumnHeader7.Width = 208
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.LargeImageList = Me.ImageList2
        Me.ListView1.Location = New System.Drawing.Point(5, 7)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(825, 345)
        Me.ListView1.SmallImageList = Me.ImageList2
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 130
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IP"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "OS"
        Me.ColumnHeader3.Width = 164
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PC"
        Me.ColumnHeader4.Width = 105
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Country"
        Me.ColumnHeader5.Width = 115
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Plugins Count"
        Me.ColumnHeader6.Width = 99
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseUserToolStripMenuItem, Me.RestartUserToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(162, 56)
        '
        'CloseUserToolStripMenuItem
        '
        Me.CloseUserToolStripMenuItem.Image = CType(resources.GetObject("CloseUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseUserToolStripMenuItem.Name = "CloseUserToolStripMenuItem"
        Me.CloseUserToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.CloseUserToolStripMenuItem.Text = "Close User"
        '
        'RestartUserToolStripMenuItem
        '
        Me.RestartUserToolStripMenuItem.Image = CType(resources.GetObject("RestartUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestartUserToolStripMenuItem.Name = "RestartUserToolStripMenuItem"
        Me.RestartUserToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.RestartUserToolStripMenuItem.Text = "Restart User"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Pitcairn.png")
        Me.ImageList2.Images.SetKeyName(1, "Nepal.png")
        Me.ImageList2.Images.SetKeyName(2, "Nigeria.png")
        Me.ImageList2.Images.SetKeyName(3, "Russia.png")
        Me.ImageList2.Images.SetKeyName(4, "Monaco.png")
        Me.ImageList2.Images.SetKeyName(5, "Mongolia.png")
        Me.ImageList2.Images.SetKeyName(6, "Montenegro.png")
        Me.ImageList2.Images.SetKeyName(7, "Montserrat.png")
        Me.ImageList2.Images.SetKeyName(8, "Morocco.png")
        Me.ImageList2.Images.SetKeyName(9, "Mozambique.png")
        Me.ImageList2.Images.SetKeyName(10, "Myanmar.png")
        Me.ImageList2.Images.SetKeyName(11, "Namibia.png")
        Me.ImageList2.Images.SetKeyName(12, "Nauru.png")
        Me.ImageList2.Images.SetKeyName(13, "Netherlands.png")
        Me.ImageList2.Images.SetKeyName(14, "Netherlands-Antilles.png")
        Me.ImageList2.Images.SetKeyName(15, "New-Caledonia.png")
        Me.ImageList2.Images.SetKeyName(16, "New-Zealand.png")
        Me.ImageList2.Images.SetKeyName(17, "Nicaragua.png")
        Me.ImageList2.Images.SetKeyName(18, "Niger.png")
        Me.ImageList2.Images.SetKeyName(19, "Niue.png")
        Me.ImageList2.Images.SetKeyName(20, "Norfolk-Island.png")
        Me.ImageList2.Images.SetKeyName(21, "Northern-Ireland.png")
        Me.ImageList2.Images.SetKeyName(22, "Northern-Mariana-Islands.png")
        Me.ImageList2.Images.SetKeyName(23, "North-Korea.png")
        Me.ImageList2.Images.SetKeyName(24, "Norway.png")
        Me.ImageList2.Images.SetKeyName(25, "Oman.png")
        Me.ImageList2.Images.SetKeyName(26, "Pakistan.png")
        Me.ImageList2.Images.SetKeyName(27, "Palau.png")
        Me.ImageList2.Images.SetKeyName(28, "Palestinian-Territory.png")
        Me.ImageList2.Images.SetKeyName(29, "Panama.png")
        Me.ImageList2.Images.SetKeyName(30, "Papua-New-Guinea.png")
        Me.ImageList2.Images.SetKeyName(31, "Paraguay.png")
        Me.ImageList2.Images.SetKeyName(32, "Peru.png")
        Me.ImageList2.Images.SetKeyName(33, "Philippines.png")
        Me.ImageList2.Images.SetKeyName(34, "Poland.png")
        Me.ImageList2.Images.SetKeyName(35, "Portugal.png")
        Me.ImageList2.Images.SetKeyName(36, "Puerto-Rico.png")
        Me.ImageList2.Images.SetKeyName(37, "Qatar.png")
        Me.ImageList2.Images.SetKeyName(38, "Reunion.png")
        Me.ImageList2.Images.SetKeyName(39, "Romania.png")
        Me.ImageList2.Images.SetKeyName(40, "Rwanda.png")
        Me.ImageList2.Images.SetKeyName(41, "Saint-Barthelemy.png")
        Me.ImageList2.Images.SetKeyName(42, "Comoros.png")
        Me.ImageList2.Images.SetKeyName(43, "Costa-Rica.png")
        Me.ImageList2.Images.SetKeyName(44, "Croatian.png")
        Me.ImageList2.Images.SetKeyName(45, "Denmark.png")
        Me.ImageList2.Images.SetKeyName(46, "Djibouti.png")
        Me.ImageList2.Images.SetKeyName(47, "El-Salvador.png")
        Me.ImageList2.Images.SetKeyName(48, "Estonia.png")
        Me.ImageList2.Images.SetKeyName(49, "European-Union.png")
        Me.ImageList2.Images.SetKeyName(50, "Ex-Yugoslavia.png")
        Me.ImageList2.Images.SetKeyName(51, "Fiji.png")
        Me.ImageList2.Images.SetKeyName(52, "France.png")
        Me.ImageList2.Images.SetKeyName(53, "French-Polynesia.png")
        Me.ImageList2.Images.SetKeyName(54, "Gambia.png")
        Me.ImageList2.Images.SetKeyName(55, "Greenland.png")
        Me.ImageList2.Images.SetKeyName(56, "Guam.png")
        Me.ImageList2.Images.SetKeyName(57, "Guernsey.png")
        Me.ImageList2.Images.SetKeyName(58, "Guyana.png")
        Me.ImageList2.Images.SetKeyName(59, "Colombia.png")
        Me.ImageList2.Images.SetKeyName(60, "Congo.png")
        Me.ImageList2.Images.SetKeyName(61, "Congo-Kinshasa.png")
        Me.ImageList2.Images.SetKeyName(62, "Cook-Islands.png")
        Me.ImageList2.Images.SetKeyName(63, "Cuba.png")
        Me.ImageList2.Images.SetKeyName(64, "Cyprus.png")
        Me.ImageList2.Images.SetKeyName(65, "Czech-Republic.png")
        Me.ImageList2.Images.SetKeyName(66, "Dominicana.png")
        Me.ImageList2.Images.SetKeyName(67, "Dominican-Republic.png")
        Me.ImageList2.Images.SetKeyName(68, "East-Timor.png")
        Me.ImageList2.Images.SetKeyName(69, "Ecuador.png")
        Me.ImageList2.Images.SetKeyName(70, "Egypt.png")
        Me.ImageList2.Images.SetKeyName(71, "England.png")
        Me.ImageList2.Images.SetKeyName(72, "Equatorial-Guinea.png")
        Me.ImageList2.Images.SetKeyName(73, "Eritrea.png")
        Me.ImageList2.Images.SetKeyName(74, "Ethiopia.png")
        Me.ImageList2.Images.SetKeyName(75, "Falkland-Islands.png")
        Me.ImageList2.Images.SetKeyName(76, "Faroe-Islands.png")
        Me.ImageList2.Images.SetKeyName(77, "Finland.png")
        Me.ImageList2.Images.SetKeyName(78, "French-Southern-Territories.png")
        Me.ImageList2.Images.SetKeyName(79, "Gabon.png")
        Me.ImageList2.Images.SetKeyName(80, "Georgia.png")
        Me.ImageList2.Images.SetKeyName(81, "Germany.png")
        Me.ImageList2.Images.SetKeyName(82, "Ghana.png")
        Me.ImageList2.Images.SetKeyName(83, "Gibraltar.png")
        Me.ImageList2.Images.SetKeyName(84, "Greece.png")
        Me.ImageList2.Images.SetKeyName(85, "Grenada.png")
        Me.ImageList2.Images.SetKeyName(86, "Guadeloupe.png")
        Me.ImageList2.Images.SetKeyName(87, "Guatemala.png")
        Me.ImageList2.Images.SetKeyName(88, "Guinea.png")
        Me.ImageList2.Images.SetKeyName(89, "Guinea-Bissau.png")
        Me.ImageList2.Images.SetKeyName(90, "Haiti.png")
        Me.ImageList2.Images.SetKeyName(91, "Holy-see.png")
        Me.ImageList2.Images.SetKeyName(92, "Honduras.png")
        Me.ImageList2.Images.SetKeyName(93, "Hong-Kong.png")
        Me.ImageList2.Images.SetKeyName(94, "Hungary.png")
        Me.ImageList2.Images.SetKeyName(95, "Iceland.png")
        Me.ImageList2.Images.SetKeyName(96, "India.png")
        Me.ImageList2.Images.SetKeyName(97, "Indonesia.png")
        Me.ImageList2.Images.SetKeyName(98, "Iran.png")
        Me.ImageList2.Images.SetKeyName(99, "Iraq.png")
        Me.ImageList2.Images.SetKeyName(100, "Ireland.png")
        Me.ImageList2.Images.SetKeyName(101, "Isle-of-Man.png")
        Me.ImageList2.Images.SetKeyName(102, "Israel.png")
        Me.ImageList2.Images.SetKeyName(103, "Italy.png")
        Me.ImageList2.Images.SetKeyName(104, "Ivory-Coast.png")
        Me.ImageList2.Images.SetKeyName(105, "Jamaica.png")
        Me.ImageList2.Images.SetKeyName(106, "Jan-Mayen.png")
        Me.ImageList2.Images.SetKeyName(107, "Japan.png")
        Me.ImageList2.Images.SetKeyName(108, "Jarvis-Island.png")
        Me.ImageList2.Images.SetKeyName(109, "Jersey.png")
        Me.ImageList2.Images.SetKeyName(110, "Jordan.png")
        Me.ImageList2.Images.SetKeyName(111, "Kazakhstan.png")
        Me.ImageList2.Images.SetKeyName(112, "Kenya.png")
        Me.ImageList2.Images.SetKeyName(113, "Kiribati.png")
        Me.ImageList2.Images.SetKeyName(114, "Korea.png")
        Me.ImageList2.Images.SetKeyName(115, "Kuwait.png")
        Me.ImageList2.Images.SetKeyName(116, "Kyrgyzstan.png")
        Me.ImageList2.Images.SetKeyName(117, "Laos.png")
        Me.ImageList2.Images.SetKeyName(118, "Latvia.png")
        Me.ImageList2.Images.SetKeyName(119, "Lebanon.png")
        Me.ImageList2.Images.SetKeyName(120, "Lesotho.png")
        Me.ImageList2.Images.SetKeyName(121, "Liberia.png")
        Me.ImageList2.Images.SetKeyName(122, "Libya.png")
        Me.ImageList2.Images.SetKeyName(123, "Liechtenstein.png")
        Me.ImageList2.Images.SetKeyName(124, "Lithuania.png")
        Me.ImageList2.Images.SetKeyName(125, "Luxembourg.png")
        Me.ImageList2.Images.SetKeyName(126, "Macau.png")
        Me.ImageList2.Images.SetKeyName(127, "Macedonia.png")
        Me.ImageList2.Images.SetKeyName(128, "Madagascar.png")
        Me.ImageList2.Images.SetKeyName(129, "Malawi.png")
        Me.ImageList2.Images.SetKeyName(130, "Malaysia.png")
        Me.ImageList2.Images.SetKeyName(131, "Maldives.png")
        Me.ImageList2.Images.SetKeyName(132, "Mali.png")
        Me.ImageList2.Images.SetKeyName(133, "Malta.png")
        Me.ImageList2.Images.SetKeyName(134, "Marshall-Islands.png")
        Me.ImageList2.Images.SetKeyName(135, "Martinique.png")
        Me.ImageList2.Images.SetKeyName(136, "Mauritania.png")
        Me.ImageList2.Images.SetKeyName(137, "Mauritius.png")
        Me.ImageList2.Images.SetKeyName(138, "Mayotte.png")
        Me.ImageList2.Images.SetKeyName(139, "Mexico.png")
        Me.ImageList2.Images.SetKeyName(140, "Micronesia.png")
        Me.ImageList2.Images.SetKeyName(141, "Moldova.png")
        Me.ImageList2.Images.SetKeyName(142, "Aland-Islands.png")
        Me.ImageList2.Images.SetKeyName(143, "Albania.png")
        Me.ImageList2.Images.SetKeyName(144, "Algeria.png")
        Me.ImageList2.Images.SetKeyName(145, "American-Samoa.png")
        Me.ImageList2.Images.SetKeyName(146, "Andorra.png")
        Me.ImageList2.Images.SetKeyName(147, "Angola.png")
        Me.ImageList2.Images.SetKeyName(148, "Antigua-and-Barbuda.png")
        Me.ImageList2.Images.SetKeyName(149, "Armenia.png")
        Me.ImageList2.Images.SetKeyName(150, "Australia.png")
        Me.ImageList2.Images.SetKeyName(151, "Austria.png")
        Me.ImageList2.Images.SetKeyName(152, "Azerbaijan.png")
        Me.ImageList2.Images.SetKeyName(153, "Bahamas.png")
        Me.ImageList2.Images.SetKeyName(154, "Bahrain.png")
        Me.ImageList2.Images.SetKeyName(155, "Belarus.png")
        Me.ImageList2.Images.SetKeyName(156, "Bermuda.png")
        Me.ImageList2.Images.SetKeyName(157, "Bhutan.png")
        Me.ImageList2.Images.SetKeyName(158, "Bolivia.png")
        Me.ImageList2.Images.SetKeyName(159, "Bosnian.png")
        Me.ImageList2.Images.SetKeyName(160, "Botswana.png")
        Me.ImageList2.Images.SetKeyName(161, "Brunei.png")
        Me.ImageList2.Images.SetKeyName(162, "Bulgaria.png")
        Me.ImageList2.Images.SetKeyName(163, "Burma.png")
        Me.ImageList2.Images.SetKeyName(164, "Burundi.png")
        Me.ImageList2.Images.SetKeyName(165, "Cameroon.png")
        Me.ImageList2.Images.SetKeyName(166, "Cape-Verde.png")
        Me.ImageList2.Images.SetKeyName(167, "Cayman-Islands.png")
        Me.ImageList2.Images.SetKeyName(168, "CentralAfricanRepublic.png")
        Me.ImageList2.Images.SetKeyName(169, "Chad.png")
        Me.ImageList2.Images.SetKeyName(170, "Chile.png")
        Me.ImageList2.Images.SetKeyName(171, "Christmas-Island.png")
        Me.ImageList2.Images.SetKeyName(172, "Afghanistan.png")
        Me.ImageList2.Images.SetKeyName(173, "Anguilla.png")
        Me.ImageList2.Images.SetKeyName(174, "Antarctica.png")
        Me.ImageList2.Images.SetKeyName(175, "Argentina.png")
        Me.ImageList2.Images.SetKeyName(176, "Aruba.png")
        Me.ImageList2.Images.SetKeyName(177, "Bangladesh.png")
        Me.ImageList2.Images.SetKeyName(178, "Barbados.png")
        Me.ImageList2.Images.SetKeyName(179, "Belgium.png")
        Me.ImageList2.Images.SetKeyName(180, "Belize.png")
        Me.ImageList2.Images.SetKeyName(181, "Benin.png")
        Me.ImageList2.Images.SetKeyName(182, "BIOT.png")
        Me.ImageList2.Images.SetKeyName(183, "Bouvet-Island.png")
        Me.ImageList2.Images.SetKeyName(184, "Brazil.png")
        Me.ImageList2.Images.SetKeyName(185, "British-Antarctic-Territory.png")
        Me.ImageList2.Images.SetKeyName(186, "British-Virgin-Islands.png")
        Me.ImageList2.Images.SetKeyName(187, "Burkina-Faso.png")
        Me.ImageList2.Images.SetKeyName(188, "Cambodia.png")
        Me.ImageList2.Images.SetKeyName(189, "Canada.png")
        Me.ImageList2.Images.SetKeyName(190, "China.png")
        Me.ImageList2.Images.SetKeyName(191, "Cocos-Islands.png")
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(180, 52)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(179, 24)
        Me.ToolStripMenuItem1.Text = "Add Plugin"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(179, 24)
        Me.ToolStripMenuItem2.Text = "Delete a Plugin"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView2)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(838, 185)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(260, 169)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subs :"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8})
        Me.ListView2.ContextMenuStrip = Me.ContextMenuStrip3
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(7, 21)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(247, 139)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = ""
        Me.ColumnHeader8.Width = 207
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(185, 28)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(184, 24)
        Me.ToolStripMenuItem3.Text = "Send Commend"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListView3)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(838, 12)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(260, 165)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Plugins :"
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader7})
        Me.ListView3.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.LargeImageList = Me.ImageList1
        Me.ListView3.Location = New System.Drawing.Point(7, 20)
        Me.ListView3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(247, 137)
        Me.ListView3.SmallImageList = Me.ImageList1
        Me.ListView3.StateImageList = Me.ImageList1
        Me.ListView3.TabIndex = 0
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Pinion.bmp")
        Me.ImageList1.Images.SetKeyName(1, "Aland-Islands.png")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 358)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1107, 26)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(63, 20)
        Me.ToolStripStatusLabel1.Text = "Ready ..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 384)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Plugin Control"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

End Class
