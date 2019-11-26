namespace LiveSplit
{
    partial class ChangableRoutesSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.chkUseRoutes = new System.Windows.Forms.CheckBox();
            this.grpHotkeys = new System.Windows.Forms.GroupBox();
            this.tlpHotkeys = new System.Windows.Forms.TableLayoutPanel();
            this.lblPreviousRoute = new System.Windows.Forms.Label();
            this.lblNextRoute = new System.Windows.Forms.Label();
            this.btnPreviousRoute = new System.Windows.Forms.Button();
            this.btnNextRoute = new System.Windows.Forms.Button();
            this.grpAppearance = new System.Windows.Forms.GroupBox();
            this.tlpAppearance = new System.Windows.Forms.TableLayoutPanel();
            this.grpBackground = new System.Windows.Forms.GroupBox();
            this.tlpBackground = new System.Windows.Forms.TableLayoutPanel();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.btnBgColor1 = new System.Windows.Forms.Button();
            this.btnBgColor2 = new System.Windows.Forms.Button();
            this.cmbGradientType = new System.Windows.Forms.ComboBox();
            this.grpTextAppearance = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkTextFontOverride = new System.Windows.Forms.CheckBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.chkTextColorOverride = new System.Windows.Forms.CheckBox();
            this.lblTextColor = new System.Windows.Forms.Label();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.chkShowLabel = new System.Windows.Forms.CheckBox();
            this.grpRoutes = new System.Windows.Forms.GroupBox();
            this.tlpRoutes = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRoutes = new System.Windows.Forms.DataGridView();
            this.RouteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.changableRoutesSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpSettings.SuspendLayout();
            this.grpHotkeys.SuspendLayout();
            this.tlpHotkeys.SuspendLayout();
            this.grpAppearance.SuspendLayout();
            this.tlpAppearance.SuspendLayout();
            this.grpBackground.SuspendLayout();
            this.tlpBackground.SuspendLayout();
            this.grpTextAppearance.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpRoutes.SuspendLayout();
            this.tlpRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).BeginInit();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changableRoutesSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpSettings, 0, 0);
            this.tlpMain.Controls.Add(this.grpRoutes, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(7, 7);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(462, 546);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpSettings
            // 
            this.tlpSettings.AutoSize = true;
            this.tlpSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpSettings.ColumnCount = 1;
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettings.Controls.Add(this.chkUseRoutes, 0, 0);
            this.tlpSettings.Controls.Add(this.grpHotkeys, 0, 3);
            this.tlpSettings.Controls.Add(this.grpAppearance, 0, 2);
            this.tlpSettings.Controls.Add(this.chkShowLabel, 0, 1);
            this.tlpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSettings.Location = new System.Drawing.Point(3, 3);
            this.tlpSettings.Name = "tlpSettings";
            this.tlpSettings.RowCount = 4;
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.Size = new System.Drawing.Size(456, 269);
            this.tlpSettings.TabIndex = 0;
            // 
            // chkUseRoutes
            // 
            this.chkUseRoutes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUseRoutes.AutoSize = true;
            this.chkUseRoutes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.changableRoutesSettingsBindingSource, "RoutesEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUseRoutes.Location = new System.Drawing.Point(3, 4);
            this.chkUseRoutes.Name = "chkUseRoutes";
            this.chkUseRoutes.Size = new System.Drawing.Size(126, 17);
            this.chkUseRoutes.TabIndex = 0;
            this.chkUseRoutes.Text = "Use Route Switching";
            this.toolTip1.SetToolTip(this.chkUseRoutes, "Should route switching be enabled");
            this.chkUseRoutes.UseVisualStyleBackColor = true;
            this.chkUseRoutes.CheckedChanged += new System.EventHandler(this.chkUseRoutes_CheckedChanged);
            // 
            // grpHotkeys
            // 
            this.grpHotkeys.AutoSize = true;
            this.grpHotkeys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpHotkeys.Controls.Add(this.tlpHotkeys);
            this.grpHotkeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHotkeys.Location = new System.Drawing.Point(3, 217);
            this.grpHotkeys.Name = "grpHotkeys";
            this.grpHotkeys.Size = new System.Drawing.Size(450, 49);
            this.grpHotkeys.TabIndex = 1;
            this.grpHotkeys.TabStop = false;
            this.grpHotkeys.Text = "Hotkeys";
            // 
            // tlpHotkeys
            // 
            this.tlpHotkeys.AutoSize = true;
            this.tlpHotkeys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpHotkeys.BackColor = System.Drawing.SystemColors.Control;
            this.tlpHotkeys.ColumnCount = 4;
            this.tlpHotkeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHotkeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHotkeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHotkeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHotkeys.Controls.Add(this.lblPreviousRoute, 1, 0);
            this.tlpHotkeys.Controls.Add(this.lblNextRoute, 3, 0);
            this.tlpHotkeys.Controls.Add(this.btnPreviousRoute, 0, 0);
            this.tlpHotkeys.Controls.Add(this.btnNextRoute, 2, 0);
            this.tlpHotkeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHotkeys.Location = new System.Drawing.Point(3, 16);
            this.tlpHotkeys.Name = "tlpHotkeys";
            this.tlpHotkeys.RowCount = 1;
            this.tlpHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHotkeys.Size = new System.Drawing.Size(444, 30);
            this.tlpHotkeys.TabIndex = 0;
            // 
            // lblPreviousRoute
            // 
            this.lblPreviousRoute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPreviousRoute.AutoSize = true;
            this.lblPreviousRoute.Location = new System.Drawing.Point(33, 8);
            this.lblPreviousRoute.Name = "lblPreviousRoute";
            this.lblPreviousRoute.Size = new System.Drawing.Size(86, 13);
            this.lblPreviousRoute.TabIndex = 2;
            this.lblPreviousRoute.Text = "Previous Route: ";
            this.lblPreviousRoute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNextRoute
            // 
            this.lblNextRoute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNextRoute.AutoSize = true;
            this.lblNextRoute.Location = new System.Drawing.Point(255, 8);
            this.lblNextRoute.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.lblNextRoute.Name = "lblNextRoute";
            this.lblNextRoute.Size = new System.Drawing.Size(67, 13);
            this.lblNextRoute.TabIndex = 0;
            this.lblNextRoute.Text = "Next Route: ";
            // 
            // btnPreviousRoute
            // 
            this.btnPreviousRoute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPreviousRoute.BackgroundImage = global::LiveSplit.Properties.Resources.Configure;
            this.btnPreviousRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreviousRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviousRoute.Location = new System.Drawing.Point(3, 3);
            this.btnPreviousRoute.Name = "btnPreviousRoute";
            this.btnPreviousRoute.Size = new System.Drawing.Size(24, 24);
            this.btnPreviousRoute.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnPreviousRoute, "Change Previous Route Hotkey");
            this.btnPreviousRoute.UseVisualStyleBackColor = true;
            // 
            // btnNextRoute
            // 
            this.btnNextRoute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNextRoute.BackgroundImage = global::LiveSplit.Properties.Resources.Configure;
            this.btnNextRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextRoute.Location = new System.Drawing.Point(225, 3);
            this.btnNextRoute.Name = "btnNextRoute";
            this.btnNextRoute.Size = new System.Drawing.Size(24, 24);
            this.btnNextRoute.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnNextRoute, "Change Next Route Hotkey");
            this.btnNextRoute.UseVisualStyleBackColor = true;
            this.btnNextRoute.Click += new System.EventHandler(this.btnNextRoute_Click);
            // 
            // grpAppearance
            // 
            this.grpAppearance.AutoSize = true;
            this.grpAppearance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAppearance.Controls.Add(this.tlpAppearance);
            this.grpAppearance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAppearance.Enabled = false;
            this.grpAppearance.Location = new System.Drawing.Point(3, 55);
            this.grpAppearance.Name = "grpAppearance";
            this.grpAppearance.Size = new System.Drawing.Size(450, 156);
            this.grpAppearance.TabIndex = 2;
            this.grpAppearance.TabStop = false;
            this.grpAppearance.Text = "Appearance";
            // 
            // tlpAppearance
            // 
            this.tlpAppearance.AutoSize = true;
            this.tlpAppearance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpAppearance.ColumnCount = 1;
            this.tlpAppearance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAppearance.Controls.Add(this.grpBackground, 0, 0);
            this.tlpAppearance.Controls.Add(this.grpTextAppearance, 0, 1);
            this.tlpAppearance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAppearance.Location = new System.Drawing.Point(3, 16);
            this.tlpAppearance.Name = "tlpAppearance";
            this.tlpAppearance.RowCount = 2;
            this.tlpAppearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAppearance.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAppearance.Size = new System.Drawing.Size(444, 137);
            this.tlpAppearance.TabIndex = 0;
            // 
            // grpBackground
            // 
            this.grpBackground.AutoSize = true;
            this.grpBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBackground.Controls.Add(this.tlpBackground);
            this.grpBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBackground.Location = new System.Drawing.Point(3, 3);
            this.grpBackground.Name = "grpBackground";
            this.grpBackground.Size = new System.Drawing.Size(438, 48);
            this.grpBackground.TabIndex = 0;
            this.grpBackground.TabStop = false;
            this.grpBackground.Text = "Background";
            // 
            // tlpBackground
            // 
            this.tlpBackground.AutoSize = true;
            this.tlpBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBackground.ColumnCount = 4;
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBackground.Controls.Add(this.lblBackgroundColor, 0, 0);
            this.tlpBackground.Controls.Add(this.btnBgColor1, 1, 0);
            this.tlpBackground.Controls.Add(this.btnBgColor2, 2, 0);
            this.tlpBackground.Controls.Add(this.cmbGradientType, 3, 0);
            this.tlpBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBackground.Location = new System.Drawing.Point(3, 16);
            this.tlpBackground.Name = "tlpBackground";
            this.tlpBackground.RowCount = 1;
            this.tlpBackground.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBackground.Size = new System.Drawing.Size(432, 29);
            this.tlpBackground.TabIndex = 0;
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(3, 8);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(95, 13);
            this.lblBackgroundColor.TabIndex = 0;
            this.lblBackgroundColor.Text = "Background Color:";
            // 
            // btnBgColor1
            // 
            this.btnBgColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBgColor1.Location = new System.Drawing.Point(153, 3);
            this.btnBgColor1.Name = "btnBgColor1";
            this.btnBgColor1.Size = new System.Drawing.Size(23, 23);
            this.btnBgColor1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnBgColor1, "Choose the background color");
            this.btnBgColor1.UseVisualStyleBackColor = true;
            // 
            // btnBgColor2
            // 
            this.btnBgColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBgColor2.Location = new System.Drawing.Point(182, 3);
            this.btnBgColor2.Name = "btnBgColor2";
            this.btnBgColor2.Size = new System.Drawing.Size(23, 23);
            this.btnBgColor2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnBgColor2, "Choose the background color");
            this.btnBgColor2.UseVisualStyleBackColor = true;
            // 
            // cmbGradientType
            // 
            this.cmbGradientType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradientType.FormattingEnabled = true;
            this.cmbGradientType.Location = new System.Drawing.Point(211, 4);
            this.cmbGradientType.Name = "cmbGradientType";
            this.cmbGradientType.Size = new System.Drawing.Size(218, 21);
            this.cmbGradientType.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbGradientType, "Choose the gradient type");
            // 
            // grpTextAppearance
            // 
            this.grpTextAppearance.AutoSize = true;
            this.grpTextAppearance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpTextAppearance.Controls.Add(this.tableLayoutPanel1);
            this.grpTextAppearance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTextAppearance.Location = new System.Drawing.Point(3, 57);
            this.grpTextAppearance.Name = "grpTextAppearance";
            this.grpTextAppearance.Size = new System.Drawing.Size(438, 77);
            this.grpTextAppearance.TabIndex = 1;
            this.grpTextAppearance.TabStop = false;
            this.grpTextAppearance.Text = "Text";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Controls.Add(this.chkTextFontOverride, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFont, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnChooseFont, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkTextColorOverride, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTextColor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnChooseColor, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chkTextFontOverride
            // 
            this.chkTextFontOverride.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkTextFontOverride.AutoSize = true;
            this.chkTextFontOverride.Location = new System.Drawing.Point(3, 6);
            this.chkTextFontOverride.Name = "chkTextFontOverride";
            this.chkTextFontOverride.Size = new System.Drawing.Size(142, 17);
            this.chkTextFontOverride.TabIndex = 0;
            this.chkTextFontOverride.Text = "Override Layout Settings";
            this.toolTip1.SetToolTip(this.chkTextFontOverride, "Override the global layout settings for this label\'s font");
            this.chkTextFontOverride.UseVisualStyleBackColor = true;
            // 
            // lblFont
            // 
            this.lblFont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(203, 8);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(34, 13);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "Font: ";
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.Location = new System.Drawing.Point(354, 3);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFont.TabIndex = 2;
            this.btnChooseFont.Text = "Choose...";
            this.toolTip1.SetToolTip(this.btnChooseFont, "Choose a font");
            this.btnChooseFont.UseVisualStyleBackColor = true;
            // 
            // chkTextColorOverride
            // 
            this.chkTextColorOverride.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkTextColorOverride.AutoSize = true;
            this.chkTextColorOverride.Location = new System.Drawing.Point(3, 35);
            this.chkTextColorOverride.Name = "chkTextColorOverride";
            this.chkTextColorOverride.Size = new System.Drawing.Size(142, 17);
            this.chkTextColorOverride.TabIndex = 3;
            this.chkTextColorOverride.Text = "Override Layout Settings";
            this.toolTip1.SetToolTip(this.chkTextColorOverride, "Override the global layout settings for this label\'s color");
            this.chkTextColorOverride.UseVisualStyleBackColor = true;
            // 
            // lblTextColor
            // 
            this.lblTextColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTextColor.AutoSize = true;
            this.lblTextColor.Location = new System.Drawing.Point(203, 37);
            this.lblTextColor.Name = "lblTextColor";
            this.lblTextColor.Size = new System.Drawing.Size(34, 13);
            this.lblTextColor.TabIndex = 4;
            this.lblTextColor.Text = "Color:";
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseColor.Location = new System.Drawing.Point(380, 32);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(23, 23);
            this.btnChooseColor.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnChooseColor, "Choose a text color");
            this.btnChooseColor.UseVisualStyleBackColor = true;
            // 
            // chkShowLabel
            // 
            this.chkShowLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkShowLabel.AutoSize = true;
            this.chkShowLabel.Location = new System.Drawing.Point(3, 30);
            this.chkShowLabel.Name = "chkShowLabel";
            this.chkShowLabel.Size = new System.Drawing.Size(145, 17);
            this.chkShowLabel.TabIndex = 3;
            this.chkShowLabel.Text = "Show Route Name Label";
            this.toolTip1.SetToolTip(this.chkShowLabel, "Should the current route name  be displayed");
            this.chkShowLabel.UseVisualStyleBackColor = true;
            this.chkShowLabel.CheckedChanged += new System.EventHandler(this.chkShowLabel_CheckedChanged);
            // 
            // grpRoutes
            // 
            this.grpRoutes.AutoSize = true;
            this.grpRoutes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpRoutes.Controls.Add(this.tlpRoutes);
            this.grpRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRoutes.Location = new System.Drawing.Point(3, 278);
            this.grpRoutes.Name = "grpRoutes";
            this.grpRoutes.Size = new System.Drawing.Size(456, 265);
            this.grpRoutes.TabIndex = 1;
            this.grpRoutes.TabStop = false;
            this.grpRoutes.Text = "Routes";
            // 
            // tlpRoutes
            // 
            this.tlpRoutes.AutoSize = true;
            this.tlpRoutes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpRoutes.ColumnCount = 1;
            this.tlpRoutes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoutes.Controls.Add(this.dgvRoutes, 0, 1);
            this.tlpRoutes.Controls.Add(this.tlpButtons, 0, 0);
            this.tlpRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoutes.Location = new System.Drawing.Point(3, 16);
            this.tlpRoutes.Name = "tlpRoutes";
            this.tlpRoutes.RowCount = 2;
            this.tlpRoutes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRoutes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRoutes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRoutes.Size = new System.Drawing.Size(450, 246);
            this.tlpRoutes.TabIndex = 0;
            // 
            // dgvRoutes
            // 
            this.dgvRoutes.AllowUserToResizeColumns = false;
            this.dgvRoutes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRoutes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoutes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoutes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RouteName,
            this.Path});
            this.dgvRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoutes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvRoutes.Location = new System.Drawing.Point(3, 43);
            this.dgvRoutes.Name = "dgvRoutes";
            this.dgvRoutes.RowHeadersVisible = false;
            this.dgvRoutes.Size = new System.Drawing.Size(444, 200);
            this.dgvRoutes.TabIndex = 1;
            // 
            // RouteName
            // 
            this.RouteName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RouteName.HeaderText = "Name";
            this.RouteName.Name = "RouteName";
            this.RouteName.ToolTipText = "The name of the route";
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ToolTipText = "The path to the splits file for the route";
            // 
            // tlpButtons
            // 
            this.tlpButtons.AutoSize = true;
            this.tlpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpButtons.ColumnCount = 4;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.Controls.Add(this.btnAddRoute, 0, 0);
            this.tlpButtons.Controls.Add(this.btnMoveUp, 1, 0);
            this.tlpButtons.Controls.Add(this.btnMoveDown, 2, 0);
            this.tlpButtons.Controls.Add(this.btnRemove, 3, 0);
            this.tlpButtons.Location = new System.Drawing.Point(3, 3);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(146, 34);
            this.tlpButtons.TabIndex = 2;
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.BackgroundImage = global::LiveSplit.Properties.Resources.Add;
            this.btnAddRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRoute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRoute.Location = new System.Drawing.Point(10, 5);
            this.btnAddRoute.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(24, 24);
            this.btnAddRoute.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAddRoute, "Add a route to this run");
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackgroundImage = global::LiveSplit.Properties.Resources.UpArrow;
            this.btnMoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoveUp.Location = new System.Drawing.Point(44, 5);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(5);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(24, 24);
            this.btnMoveUp.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnMoveUp, "Move the selected route up");
            this.btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackgroundImage = global::LiveSplit.Properties.Resources.DownArrow;
            this.btnMoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoveDown.Location = new System.Drawing.Point(78, 5);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(5);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(24, 24);
            this.btnMoveDown.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnMoveDown, "Move the selected route down");
            this.btnMoveDown.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::LiveSplit.Properties.Resources.Remove;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Location = new System.Drawing.Point(112, 5);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 24);
            this.btnRemove.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnRemove, "Remove the selected route from the list of routes");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // changableRoutesSettingsBindingSource
            // 
            this.changableRoutesSettingsBindingSource.DataSource = typeof(LiveSplit.ChangableRoutesSettings);
            // 
            // ChangableRoutesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tlpMain);
            this.Name = "ChangableRoutesSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(476, 560);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpSettings.ResumeLayout(false);
            this.tlpSettings.PerformLayout();
            this.grpHotkeys.ResumeLayout(false);
            this.grpHotkeys.PerformLayout();
            this.tlpHotkeys.ResumeLayout(false);
            this.tlpHotkeys.PerformLayout();
            this.grpAppearance.ResumeLayout(false);
            this.grpAppearance.PerformLayout();
            this.tlpAppearance.ResumeLayout(false);
            this.tlpAppearance.PerformLayout();
            this.grpBackground.ResumeLayout(false);
            this.grpBackground.PerformLayout();
            this.tlpBackground.ResumeLayout(false);
            this.tlpBackground.PerformLayout();
            this.grpTextAppearance.ResumeLayout(false);
            this.grpTextAppearance.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpRoutes.ResumeLayout(false);
            this.grpRoutes.PerformLayout();
            this.tlpRoutes.ResumeLayout(false);
            this.tlpRoutes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutes)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changableRoutesSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpSettings;
        private System.Windows.Forms.CheckBox chkUseRoutes;
        private System.Windows.Forms.GroupBox grpRoutes;
        private System.Windows.Forms.TableLayoutPanel tlpRoutes;
        private System.Windows.Forms.DataGridView dgvRoutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox grpHotkeys;
        private System.Windows.Forms.TableLayoutPanel tlpHotkeys;
        private System.Windows.Forms.Button btnNextRoute;
        private System.Windows.Forms.Label lblPreviousRoute;
        private System.Windows.Forms.Button btnPreviousRoute;
        private System.Windows.Forms.Label lblNextRoute;
        private System.Windows.Forms.GroupBox grpAppearance;
        private System.Windows.Forms.TableLayoutPanel tlpAppearance;
        private System.Windows.Forms.GroupBox grpBackground;
        private System.Windows.Forms.TableLayoutPanel tlpBackground;
        private System.Windows.Forms.GroupBox grpTextAppearance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkTextFontOverride;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.CheckBox chkTextColorOverride;
        private System.Windows.Forms.Label lblTextColor;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.Button btnBgColor1;
        private System.Windows.Forms.Button btnBgColor2;
        private System.Windows.Forms.ComboBox cmbGradientType;
        private System.Windows.Forms.CheckBox chkShowLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource changableRoutesSettingsBindingSource;
    }
}
