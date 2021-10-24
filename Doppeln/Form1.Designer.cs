
namespace Doppeln
{
    partial class mainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.Skin = new FlatUI.FormSkin();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.saveButton = new FlatUI.FlatButton();
            this.inputPicture = new System.Windows.Forms.PictureBox();
            this.flatButton1 = new FlatUI.FlatButton();
            this.malBox = new FlatUI.FlatComboBox();
            this.selectPicButton = new FlatUI.FlatButton();
            this.fileBox = new System.Windows.Forms.ListBox();
            this.statusBar = new FlatUI.FlatStatusBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.infoText = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.ListBox();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini1 = new FlatUI.FlatMini();
            this.Skin.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPicture)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Skin
            // 
            this.Skin.BackColor = System.Drawing.Color.White;
            this.Skin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Skin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.Skin.Controls.Add(this.flatTabControl1);
            this.Skin.Controls.Add(this.flatClose1);
            this.Skin.Controls.Add(this.flatMini1);
            this.Skin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Skin.FlatColor = System.Drawing.Color.Orange;
            this.Skin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Skin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Skin.HeaderMaximize = false;
            this.Skin.Location = new System.Drawing.Point(0, 0);
            this.Skin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Skin.Name = "Skin";
            this.Skin.Size = new System.Drawing.Size(974, 746);
            this.Skin.TabIndex = 0;
            this.Skin.Text = "Doppeln";
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.Orange;
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 50);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(974, 696);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.inputPicture);
            this.tabPage1.Controls.Add(this.flatButton1);
            this.tabPage1.Controls.Add(this.malBox);
            this.tabPage1.Controls.Add(this.selectPicButton);
            this.tabPage1.Controls.Add(this.fileBox);
            this.tabPage1.Controls.Add(this.statusBar);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(966, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BaseColor = System.Drawing.Color.Orange;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveButton.Location = new System.Drawing.Point(377, 575);
            this.saveButton.Name = "saveButton";
            this.saveButton.Rounded = false;
            this.saveButton.Size = new System.Drawing.Size(368, 41);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save Output";
            this.saveButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // inputPicture
            // 
            this.inputPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.inputPicture.Location = new System.Drawing.Point(130, 21);
            this.inputPicture.Name = "inputPicture";
            this.inputPicture.Size = new System.Drawing.Size(512, 512);
            this.inputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputPicture.TabIndex = 4;
            this.inputPicture.TabStop = false;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.Orange;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(8, 575);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(368, 41);
            this.flatButton1.TabIndex = 10;
            this.flatButton1.Text = "Create Output";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // malBox
            // 
            this.malBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.malBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.malBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.malBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.malBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.malBox.ForeColor = System.Drawing.Color.White;
            this.malBox.FormattingEnabled = true;
            this.malBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.malBox.ItemHeight = 22;
            this.malBox.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32"});
            this.malBox.Location = new System.Drawing.Point(8, 539);
            this.malBox.Name = "malBox";
            this.malBox.Size = new System.Drawing.Size(737, 28);
            this.malBox.TabIndex = 9;
            // 
            // selectPicButton
            // 
            this.selectPicButton.BackColor = System.Drawing.Color.Transparent;
            this.selectPicButton.BaseColor = System.Drawing.Color.Orange;
            this.selectPicButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectPicButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectPicButton.Location = new System.Drawing.Point(751, 575);
            this.selectPicButton.Name = "selectPicButton";
            this.selectPicButton.Rounded = false;
            this.selectPicButton.Size = new System.Drawing.Size(207, 41);
            this.selectPicButton.TabIndex = 3;
            this.selectPicButton.Text = "Select As Picture";
            this.selectPicButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.selectPicButton.Click += new System.EventHandler(this.selectPicButton_Click);
            // 
            // fileBox
            // 
            this.fileBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.fileBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileBox.ForeColor = System.Drawing.Color.White;
            this.fileBox.FormattingEnabled = true;
            this.fileBox.ItemHeight = 17;
            this.fileBox.Location = new System.Drawing.Point(751, 6);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(207, 561);
            this.fileBox.TabIndex = 2;
            // 
            // statusBar
            // 
            this.statusBar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.statusBar.ForeColor = System.Drawing.Color.White;
            this.statusBar.Location = new System.Drawing.Point(3, 622);
            this.statusBar.Name = "statusBar";
            this.statusBar.RectColor = System.Drawing.Color.Orange;
            this.statusBar.ShowTimeDate = false;
            this.statusBar.Size = new System.Drawing.Size(960, 23);
            this.statusBar.TabIndex = 0;
            this.statusBar.TextColor = System.Drawing.Color.White;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.infoText);
            this.tabPage2.Controls.Add(this.logBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoText.Location = new System.Drawing.Point(120, 457);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(759, 168);
            this.infoText.TabIndex = 4;
            this.infoText.Text = resources.GetString("infoText.Text");
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.ForeColor = System.Drawing.Color.White;
            this.logBox.FormattingEnabled = true;
            this.logBox.ItemHeight = 17;
            this.logBox.Location = new System.Drawing.Point(8, 6);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(952, 425);
            this.logBox.TabIndex = 3;
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(944, 15);
            this.flatClose1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 1;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(920, 15);
            this.flatMini1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 0;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 746);
            this.Controls.Add(this.Skin);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doppeln";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Skin.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputPicture)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin Skin;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FlatUI.FlatStatusBar statusBar;
        private System.Windows.Forms.ListBox fileBox;
        private FlatUI.FlatButton selectPicButton;
        private System.Windows.Forms.PictureBox inputPicture;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatComboBox malBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Label infoText;
        private FlatUI.FlatButton saveButton;
    }
}

