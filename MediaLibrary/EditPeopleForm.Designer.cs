namespace MediaLibrary
{
    partial class EditPeopleForm
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
            this.personSearchBox = new MediaLibrary.PersonSearchBox();
            this.editorTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.aliasesTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.usernamesLabel = new System.Windows.Forms.Label();
            this.addUsernameFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.usernamesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siteTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.addUsernameButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.editorTablePanel.SuspendLayout();
            this.addUsernameFlowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // personSearchBox
            // 
            this.personSearchBox.Location = new System.Drawing.Point(105, 13);
            this.personSearchBox.Name = "personSearchBox";
            this.personSearchBox.SelectedPerson = null;
            this.personSearchBox.Size = new System.Drawing.Size(450, 22);
            this.personSearchBox.TabIndex = 2;
            this.personSearchBox.SelectedPersonChanged += new System.EventHandler<System.EventArgs>(this.PersonSearchBox_SelectedPersonChanged);
            // 
            // editorTablePanel
            // 
            this.editorTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorTablePanel.AutoScroll = true;
            this.editorTablePanel.ColumnCount = 2;
            this.editorTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.editorTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editorTablePanel.Controls.Add(this.nameLabel, 0, 0);
            this.editorTablePanel.Controls.Add(this.nameTextBox, 1, 0);
            this.editorTablePanel.Controls.Add(this.aliasesTablePanel, 1, 1);
            this.editorTablePanel.Controls.Add(this.usernamesLabel, 0, 2);
            this.editorTablePanel.Controls.Add(this.addUsernameFlowPanel, 1, 2);
            this.editorTablePanel.Enabled = false;
            this.editorTablePanel.Location = new System.Drawing.Point(12, 41);
            this.editorTablePanel.Name = "editorTablePanel";
            this.editorTablePanel.RowCount = 3;
            this.editorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.editorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editorTablePanel.Size = new System.Drawing.Size(546, 296);
            this.editorTablePanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 5);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(77, 26);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "&Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(93, 3);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(450, 32);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Validated += new System.EventHandler(this.NameTextBox_Validated);
            // 
            // aliasesTablePanel
            // 
            this.aliasesTablePanel.AutoSize = true;
            this.aliasesTablePanel.ColumnCount = 2;
            this.aliasesTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.aliasesTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.aliasesTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.aliasesTablePanel.Location = new System.Drawing.Point(86, 41);
            this.aliasesTablePanel.Name = "aliasesTablePanel";
            this.aliasesTablePanel.RowCount = 1;
            this.aliasesTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.aliasesTablePanel.Size = new System.Drawing.Size(457, 0);
            this.aliasesTablePanel.TabIndex = 3;
            // 
            // usernamesLabel
            // 
            this.usernamesLabel.AutoSize = true;
            this.usernamesLabel.Location = new System.Drawing.Point(3, 44);
            this.usernamesLabel.Name = "usernamesLabel";
            this.usernamesLabel.Size = new System.Drawing.Size(63, 13);
            this.usernamesLabel.TabIndex = 4;
            this.usernamesLabel.Text = "&Usernames:";
            // 
            // addUsernameFlowPanel
            // 
            this.addUsernameFlowPanel.AutoSize = true;
            this.addUsernameFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addUsernameFlowPanel.Controls.Add(this.usernamesFlowPanel);
            this.addUsernameFlowPanel.Controls.Add(this.panel1);
            this.addUsernameFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUsernameFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.addUsernameFlowPanel.Location = new System.Drawing.Point(86, 47);
            this.addUsernameFlowPanel.Name = "addUsernameFlowPanel";
            this.addUsernameFlowPanel.Size = new System.Drawing.Size(457, 246);
            this.addUsernameFlowPanel.TabIndex = 5;
            // 
            // usernamesFlowPanel
            // 
            this.usernamesFlowPanel.AutoSize = true;
            this.usernamesFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usernamesFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernamesFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.usernamesFlowPanel.Name = "usernamesFlowPanel";
            this.usernamesFlowPanel.Size = new System.Drawing.Size(324, 0);
            this.usernamesFlowPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addUsernameButton);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.siteTextBox);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 30);
            this.panel1.TabIndex = 7;
            // 
            // siteTextBox
            // 
            this.siteTextBox.Location = new System.Drawing.Point(4, 5);
            this.siteTextBox.Name = "siteTextBox";
            this.siteTextBox.Size = new System.Drawing.Size(100, 20);
            this.siteTextBox.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(110, 5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(130, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // addUsernameButton
            // 
            this.addUsernameButton.Location = new System.Drawing.Point(246, 3);
            this.addUsernameButton.Name = "addUsernameButton";
            this.addUsernameButton.Size = new System.Drawing.Size(75, 23);
            this.addUsernameButton.TabIndex = 2;
            this.addUsernameButton.Text = "Add Username";
            this.addUsernameButton.UseVisualStyleBackColor = true;
            this.addUsernameButton.Click += new System.EventHandler(this.AddUsernameButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 349);
            this.Controls.Add(this.editorTablePanel);
            this.Controls.Add(this.personSearchBox);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit People";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditPersonForm_KeyDown);
            this.editorTablePanel.ResumeLayout(false);
            this.editorTablePanel.PerformLayout();
            this.addUsernameFlowPanel.ResumeLayout(false);
            this.addUsernameFlowPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonSearchBox personSearchBox;
        private System.Windows.Forms.TableLayoutPanel editorTablePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TableLayoutPanel aliasesTablePanel;
        private System.Windows.Forms.Label usernamesLabel;
        private System.Windows.Forms.FlowLayoutPanel addUsernameFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel usernamesFlowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addUsernameButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox siteTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
