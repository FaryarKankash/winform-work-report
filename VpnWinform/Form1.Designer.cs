namespace VpnWinform
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.Project_List = new System.Windows.Forms.DataGridView();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.Projects_label = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.Report_List = new System.Windows.Forms.DataGridView();
            this.Delete_Report_Btn = new MaterialSkin.Controls.MaterialButton();
            this.Work_label = new MaterialSkin.Controls.MaterialLabel();
            this.Projects = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.Project_Submit_Btn = new MaterialSkin.Controls.MaterialButton();
            this.Project_Description_TextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Project_Deadline_TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Project_Name_TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.Add_Project_label = new MaterialSkin.Controls.MaterialLabel();
            this.Work = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.Work_Project_Name_TextBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.Report_Submit_Btn = new MaterialSkin.Controls.MaterialButton();
            this.Report_Description_Textbox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.Report_Date_Textbox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.Report_Time_Textbox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Project_List)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_List)).BeginInit();
            this.Projects.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.Work.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.Projects);
            this.materialTabControl1.Controls.Add(this.Work);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1194, 643);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.materialCard2);
            this.Home.Controls.Add(this.materialCard1);
            this.Home.ImageKey = "home.png";
            this.Home.Location = new System.Drawing.Point(4, 39);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1186, 600);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.Project_List);
            this.materialCard2.Controls.Add(this.materialButton2);
            this.materialCard2.Controls.Add(this.Projects_label);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 287);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1052, 269);
            this.materialCard2.TabIndex = 2;
            // 
            // Project_List
            // 
            this.Project_List.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Project_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Project_List.Location = new System.Drawing.Point(17, 40);
            this.Project_List.Name = "Project_List";
            this.Project_List.RowHeadersWidth = 51;
            this.Project_List.RowTemplate.Height = 24;
            this.Project_List.Size = new System.Drawing.Size(876, 212);
            this.Project_List.TabIndex = 13;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(900, 40);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(73, 36);
            this.materialButton2.TabIndex = 11;
            this.materialButton2.Text = "Delete";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // Projects_label
            // 
            this.Projects_label.AutoSize = true;
            this.Projects_label.Depth = 0;
            this.Projects_label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Projects_label.Location = new System.Drawing.Point(17, 14);
            this.Projects_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Projects_label.Name = "Projects_label";
            this.Projects_label.Size = new System.Drawing.Size(62, 19);
            this.Projects_label.TabIndex = 1;
            this.Projects_label.Text = "Projects:";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.Report_List);
            this.materialCard1.Controls.Add(this.Delete_Report_Btn);
            this.materialCard1.Controls.Add(this.Work_label);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1052, 254);
            this.materialCard1.TabIndex = 0;
            // 
            // Report_List
            // 
            this.Report_List.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Report_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report_List.Location = new System.Drawing.Point(17, 36);
            this.Report_List.Name = "Report_List";
            this.Report_List.RowHeadersWidth = 51;
            this.Report_List.RowTemplate.Height = 24;
            this.Report_List.Size = new System.Drawing.Size(876, 201);
            this.Report_List.TabIndex = 14;
            // 
            // Delete_Report_Btn
            // 
            this.Delete_Report_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Delete_Report_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete_Report_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Delete_Report_Btn.Depth = 0;
            this.Delete_Report_Btn.HighEmphasis = true;
            this.Delete_Report_Btn.Icon = null;
            this.Delete_Report_Btn.Location = new System.Drawing.Point(900, 36);
            this.Delete_Report_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Delete_Report_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Delete_Report_Btn.Name = "Delete_Report_Btn";
            this.Delete_Report_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Delete_Report_Btn.Size = new System.Drawing.Size(73, 36);
            this.Delete_Report_Btn.TabIndex = 8;
            this.Delete_Report_Btn.Text = "Delete";
            this.Delete_Report_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Delete_Report_Btn.UseAccentColor = false;
            this.Delete_Report_Btn.UseVisualStyleBackColor = true;
            this.Delete_Report_Btn.Click += new System.EventHandler(this.Delete_Report_Btn_Click);
            // 
            // Work_label
            // 
            this.Work_label.AutoSize = true;
            this.Work_label.Depth = 0;
            this.Work_label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Work_label.Location = new System.Drawing.Point(17, 14);
            this.Work_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Work_label.Name = "Work_label";
            this.Work_label.Size = new System.Drawing.Size(94, 19);
            this.Work_label.TabIndex = 1;
            this.Work_label.Text = "Work reports:";
            // 
            // Projects
            // 
            this.Projects.Controls.Add(this.materialCard3);
            this.Projects.ImageKey = "document.png";
            this.Projects.Location = new System.Drawing.Point(4, 39);
            this.Projects.Name = "Projects";
            this.Projects.Padding = new System.Windows.Forms.Padding(3);
            this.Projects.Size = new System.Drawing.Size(1186, 600);
            this.Projects.TabIndex = 1;
            this.Projects.Text = "Projects";
            this.Projects.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.Project_Submit_Btn);
            this.materialCard3.Controls.Add(this.Project_Description_TextBox);
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.Project_Deadline_TextBox);
            this.materialCard3.Controls.Add(this.materialLabel1);
            this.materialCard3.Controls.Add(this.Project_Name_TextBox);
            this.materialCard3.Controls.Add(this.Add_Project_label);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(17, 17);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(980, 543);
            this.materialCard3.TabIndex = 0;
            // 
            // Project_Submit_Btn
            // 
            this.Project_Submit_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Project_Submit_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Project_Submit_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Project_Submit_Btn.Depth = 0;
            this.Project_Submit_Btn.HighEmphasis = true;
            this.Project_Submit_Btn.Icon = null;
            this.Project_Submit_Btn.Location = new System.Drawing.Point(380, 487);
            this.Project_Submit_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Project_Submit_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Project_Submit_Btn.Name = "Project_Submit_Btn";
            this.Project_Submit_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Project_Submit_Btn.Size = new System.Drawing.Size(75, 36);
            this.Project_Submit_Btn.TabIndex = 7;
            this.Project_Submit_Btn.Text = "Submit";
            this.Project_Submit_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Project_Submit_Btn.UseAccentColor = false;
            this.Project_Submit_Btn.UseVisualStyleBackColor = true;
            this.Project_Submit_Btn.Click += new System.EventHandler(this.Project_Submit_Btn_Click);
            // 
            // Project_Description_TextBox
            // 
            this.Project_Description_TextBox.AnimateReadOnly = false;
            this.Project_Description_TextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Project_Description_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Project_Description_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Project_Description_TextBox.Depth = 0;
            this.Project_Description_TextBox.HideSelection = true;
            this.Project_Description_TextBox.Location = new System.Drawing.Point(17, 278);
            this.Project_Description_TextBox.MaxLength = 32767;
            this.Project_Description_TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.Project_Description_TextBox.Name = "Project_Description_TextBox";
            this.Project_Description_TextBox.PasswordChar = '\0';
            this.Project_Description_TextBox.ReadOnly = false;
            this.Project_Description_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Project_Description_TextBox.SelectedText = "";
            this.Project_Description_TextBox.SelectionLength = 0;
            this.Project_Description_TextBox.SelectionStart = 0;
            this.Project_Description_TextBox.ShortcutsEnabled = true;
            this.Project_Description_TextBox.Size = new System.Drawing.Size(818, 192);
            this.Project_Description_TextBox.TabIndex = 6;
            this.Project_Description_TextBox.TabStop = false;
            this.Project_Description_TextBox.Text = "Add description";
            this.Project_Description_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Project_Description_TextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(14, 245);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(136, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Project description:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(458, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(118, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Project deadline:";
            // 
            // Project_Deadline_TextBox
            // 
            this.Project_Deadline_TextBox.AnimateReadOnly = false;
            this.Project_Deadline_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Project_Deadline_TextBox.Depth = 0;
            this.Project_Deadline_TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Project_Deadline_TextBox.LeadingIcon = null;
            this.Project_Deadline_TextBox.Location = new System.Drawing.Point(458, 153);
            this.Project_Deadline_TextBox.MaxLength = 50;
            this.Project_Deadline_TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.Project_Deadline_TextBox.Multiline = false;
            this.Project_Deadline_TextBox.Name = "Project_Deadline_TextBox";
            this.Project_Deadline_TextBox.Size = new System.Drawing.Size(377, 50);
            this.Project_Deadline_TextBox.TabIndex = 3;
            this.Project_Deadline_TextBox.Text = "";
            this.Project_Deadline_TextBox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 118);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Project Name:";
            // 
            // Project_Name_TextBox
            // 
            this.Project_Name_TextBox.AnimateReadOnly = false;
            this.Project_Name_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Project_Name_TextBox.Depth = 0;
            this.Project_Name_TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Project_Name_TextBox.LeadingIcon = null;
            this.Project_Name_TextBox.Location = new System.Drawing.Point(17, 153);
            this.Project_Name_TextBox.MaxLength = 50;
            this.Project_Name_TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.Project_Name_TextBox.Multiline = false;
            this.Project_Name_TextBox.Name = "Project_Name_TextBox";
            this.Project_Name_TextBox.Size = new System.Drawing.Size(377, 50);
            this.Project_Name_TextBox.TabIndex = 1;
            this.Project_Name_TextBox.Text = "";
            this.Project_Name_TextBox.TrailingIcon = null;
            // 
            // Add_Project_label
            // 
            this.Add_Project_label.AutoSize = true;
            this.Add_Project_label.Depth = 0;
            this.Add_Project_label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Add_Project_label.Location = new System.Drawing.Point(17, 14);
            this.Add_Project_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add_Project_label.Name = "Add_Project_label";
            this.Add_Project_label.Size = new System.Drawing.Size(81, 19);
            this.Add_Project_label.TabIndex = 0;
            this.Add_Project_label.Text = "Add project";
            // 
            // Work
            // 
            this.Work.Controls.Add(this.materialCard4);
            this.Work.ImageKey = "Work.png";
            this.Work.Location = new System.Drawing.Point(4, 39);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(1186, 600);
            this.Work.TabIndex = 2;
            this.Work.Text = "Work";
            this.Work.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.Work_Project_Name_TextBox);
            this.materialCard4.Controls.Add(this.materialLabel8);
            this.materialCard4.Controls.Add(this.Report_Submit_Btn);
            this.materialCard4.Controls.Add(this.Report_Description_Textbox);
            this.materialCard4.Controls.Add(this.materialLabel4);
            this.materialCard4.Controls.Add(this.materialLabel5);
            this.materialCard4.Controls.Add(this.Report_Date_Textbox);
            this.materialCard4.Controls.Add(this.materialLabel6);
            this.materialCard4.Controls.Add(this.Report_Time_Textbox);
            this.materialCard4.Controls.Add(this.materialLabel7);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(23, 17);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(980, 543);
            this.materialCard4.TabIndex = 1;
            // 
            // Work_Project_Name_TextBox
            // 
            this.Work_Project_Name_TextBox.AutoResize = false;
            this.Work_Project_Name_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Work_Project_Name_TextBox.Depth = 0;
            this.Work_Project_Name_TextBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Work_Project_Name_TextBox.DropDownHeight = 174;
            this.Work_Project_Name_TextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Work_Project_Name_TextBox.DropDownWidth = 121;
            this.Work_Project_Name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Work_Project_Name_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Work_Project_Name_TextBox.FormattingEnabled = true;
            this.Work_Project_Name_TextBox.IntegralHeight = false;
            this.Work_Project_Name_TextBox.ItemHeight = 43;
            this.Work_Project_Name_TextBox.Location = new System.Drawing.Point(20, 261);
            this.Work_Project_Name_TextBox.MaxDropDownItems = 4;
            this.Work_Project_Name_TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.Work_Project_Name_TextBox.Name = "Work_Project_Name_TextBox";
            this.Work_Project_Name_TextBox.Size = new System.Drawing.Size(374, 49);
            this.Work_Project_Name_TextBox.StartIndex = 0;
            this.Work_Project_Name_TextBox.TabIndex = 10;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(20, 239);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(98, 19);
            this.materialLabel8.TabIndex = 9;
            this.materialLabel8.Text = "Project name:";
            // 
            // Report_Submit_Btn
            // 
            this.Report_Submit_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Report_Submit_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Report_Submit_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Report_Submit_Btn.Depth = 0;
            this.Report_Submit_Btn.HighEmphasis = true;
            this.Report_Submit_Btn.Icon = null;
            this.Report_Submit_Btn.Location = new System.Drawing.Point(380, 487);
            this.Report_Submit_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Report_Submit_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Report_Submit_Btn.Name = "Report_Submit_Btn";
            this.Report_Submit_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Report_Submit_Btn.Size = new System.Drawing.Size(75, 36);
            this.Report_Submit_Btn.TabIndex = 7;
            this.Report_Submit_Btn.Text = "Submit";
            this.Report_Submit_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Report_Submit_Btn.UseAccentColor = false;
            this.Report_Submit_Btn.UseVisualStyleBackColor = true;
            this.Report_Submit_Btn.Click += new System.EventHandler(this.Report_Submit_Btn_Click);
            // 
            // Report_Description_Textbox
            // 
            this.Report_Description_Textbox.AnimateReadOnly = false;
            this.Report_Description_Textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Report_Description_Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Report_Description_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Report_Description_Textbox.Depth = 0;
            this.Report_Description_Textbox.HideSelection = true;
            this.Report_Description_Textbox.Location = new System.Drawing.Point(20, 372);
            this.Report_Description_Textbox.MaxLength = 32767;
            this.Report_Description_Textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Report_Description_Textbox.Name = "Report_Description_Textbox";
            this.Report_Description_Textbox.PasswordChar = '\0';
            this.Report_Description_Textbox.ReadOnly = false;
            this.Report_Description_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Report_Description_Textbox.SelectedText = "";
            this.Report_Description_Textbox.SelectionLength = 0;
            this.Report_Description_Textbox.SelectionStart = 0;
            this.Report_Description_Textbox.ShortcutsEnabled = true;
            this.Report_Description_Textbox.Size = new System.Drawing.Size(818, 106);
            this.Report_Description_Textbox.TabIndex = 6;
            this.Report_Description_Textbox.TabStop = false;
            this.Report_Description_Textbox.Text = "Add description";
            this.Report_Description_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Report_Description_Textbox.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(17, 339);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Report description:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(458, 118);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Report date:";
            // 
            // Report_Date_Textbox
            // 
            this.Report_Date_Textbox.AnimateReadOnly = false;
            this.Report_Date_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Report_Date_Textbox.Depth = 0;
            this.Report_Date_Textbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Report_Date_Textbox.LeadingIcon = null;
            this.Report_Date_Textbox.Location = new System.Drawing.Point(458, 153);
            this.Report_Date_Textbox.MaxLength = 50;
            this.Report_Date_Textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Report_Date_Textbox.Multiline = false;
            this.Report_Date_Textbox.Name = "Report_Date_Textbox";
            this.Report_Date_Textbox.Size = new System.Drawing.Size(377, 50);
            this.Report_Date_Textbox.TabIndex = 3;
            this.Report_Date_Textbox.Text = "";
            this.Report_Date_Textbox.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(17, 118);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(76, 19);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Work time:";
            // 
            // Report_Time_Textbox
            // 
            this.Report_Time_Textbox.AnimateReadOnly = false;
            this.Report_Time_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Report_Time_Textbox.Depth = 0;
            this.Report_Time_Textbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Report_Time_Textbox.LeadingIcon = null;
            this.Report_Time_Textbox.Location = new System.Drawing.Point(17, 153);
            this.Report_Time_Textbox.MaxLength = 50;
            this.Report_Time_Textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Report_Time_Textbox.Multiline = false;
            this.Report_Time_Textbox.Name = "Report_Time_Textbox";
            this.Report_Time_Textbox.Size = new System.Drawing.Size(377, 50);
            this.Report_Time_Textbox.TabIndex = 1;
            this.Report_Time_Textbox.Text = "";
            this.Report_Time_Textbox.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(17, 14);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(112, 19);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Add work report";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document.png");
            this.imageList1.Images.SetKeyName(1, "home.png");
            this.imageList1.Images.SetKeyName(2, "Work.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 710);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Project_List)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_List)).EndInit();
            this.Projects.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.Work.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Projects;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel Work_label;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel Projects_label;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel Add_Project_label;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox Project_Deadline_TextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox Project_Name_TextBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 Project_Description_TextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton Project_Submit_Btn;
        private System.Windows.Forms.TabPage Work;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialButton Report_Submit_Btn;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 Report_Description_Textbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox Report_Date_Textbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox Report_Time_Textbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox Work_Project_Name_TextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton Delete_Report_Btn;
        private System.Windows.Forms.DataGridView Project_List;
        private System.Windows.Forms.DataGridView Report_List;
    }
}

