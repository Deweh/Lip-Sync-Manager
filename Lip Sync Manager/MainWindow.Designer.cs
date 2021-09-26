
namespace Lip_Sync_Manager
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.step1Btn = new System.Windows.Forms.Button();
            this.step2Btn = new System.Windows.Forms.Button();
            this.step3Btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dialogueBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updatedSelectedBtn = new System.Windows.Forms.Button();
            this.voicetypeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pluginnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.step4Btn = new System.Windows.Forms.Button();
            this.step5Btn = new System.Windows.Forms.Button();
            this.step6Btn = new System.Windows.Forms.Button();
            this.allStepsBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.clearToolStripMenuItem.Text = "Clear Project";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // step1Btn
            // 
            this.step1Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.step1Btn.Location = new System.Drawing.Point(585, 552);
            this.step1Btn.Name = "step1Btn";
            this.step1Btn.Size = new System.Drawing.Size(203, 23);
            this.step1Btn.TabIndex = 1;
            this.step1Btn.Text = "Step 1: Generate WAV Files";
            this.step1Btn.UseVisualStyleBackColor = true;
            this.step1Btn.Click += new System.EventHandler(this.step1Btn_Click);
            // 
            // step2Btn
            // 
            this.step2Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.step2Btn.Location = new System.Drawing.Point(585, 581);
            this.step2Btn.Name = "step2Btn";
            this.step2Btn.Size = new System.Drawing.Size(203, 23);
            this.step2Btn.TabIndex = 2;
            this.step2Btn.Text = "Step 2: Generate Lip Syncing";
            this.step2Btn.UseVisualStyleBackColor = true;
            this.step2Btn.Click += new System.EventHandler(this.step2Btn_Click);
            // 
            // step3Btn
            // 
            this.step3Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.step3Btn.Location = new System.Drawing.Point(585, 610);
            this.step3Btn.Name = "step3Btn";
            this.step3Btn.Size = new System.Drawing.Size(203, 23);
            this.step3Btn.TabIndex = 3;
            this.step3Btn.Text = "Step 3: Silence WAV Files";
            this.step3Btn.UseVisualStyleBackColor = true;
            this.step3Btn.Click += new System.EventHandler(this.step3Btn_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(567, 629);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filename";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dialogue";
            this.columnHeader3.Width = 443;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filename:";
            // 
            // filenameBox
            // 
            this.filenameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filenameBox.Location = new System.Drawing.Point(585, 107);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(203, 20);
            this.filenameBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dialogue:";
            // 
            // dialogueBox
            // 
            this.dialogueBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogueBox.Location = new System.Drawing.Point(585, 150);
            this.dialogueBox.Multiline = true;
            this.dialogueBox.Name = "dialogueBox";
            this.dialogueBox.Size = new System.Drawing.Size(203, 151);
            this.dialogueBox.TabIndex = 8;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(585, 307);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(203, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updatedSelectedBtn
            // 
            this.updatedSelectedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updatedSelectedBtn.Location = new System.Drawing.Point(585, 336);
            this.updatedSelectedBtn.Name = "updatedSelectedBtn";
            this.updatedSelectedBtn.Size = new System.Drawing.Size(203, 23);
            this.updatedSelectedBtn.TabIndex = 10;
            this.updatedSelectedBtn.Text = "Update Selected";
            this.updatedSelectedBtn.UseVisualStyleBackColor = true;
            this.updatedSelectedBtn.Click += new System.EventHandler(this.updatedSelectedBtn_Click);
            // 
            // voicetypeBox
            // 
            this.voicetypeBox.Location = new System.Drawing.Point(361, 22);
            this.voicetypeBox.Name = "voicetypeBox";
            this.voicetypeBox.Size = new System.Drawing.Size(203, 20);
            this.voicetypeBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Voice Type:";
            // 
            // pluginnameBox
            // 
            this.pluginnameBox.Location = new System.Drawing.Point(82, 22);
            this.pluginnameBox.Name = "pluginnameBox";
            this.pluginnameBox.Size = new System.Drawing.Size(203, 20);
            this.pluginnameBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Plugin Name:";
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeBtn.Location = new System.Drawing.Point(585, 365);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(203, 23);
            this.removeBtn.TabIndex = 15;
            this.removeBtn.Text = "Remove Selected";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // step4Btn
            // 
            this.step4Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.step4Btn.Location = new System.Drawing.Point(585, 639);
            this.step4Btn.Name = "step4Btn";
            this.step4Btn.Size = new System.Drawing.Size(203, 23);
            this.step4Btn.TabIndex = 16;
            this.step4Btn.Text = "Step 4: Convert WAV Files to XWM";
            this.step4Btn.UseVisualStyleBackColor = true;
            this.step4Btn.Click += new System.EventHandler(this.step4Btn_Click);
            // 
            // step5Btn
            // 
            this.step5Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.step5Btn.Location = new System.Drawing.Point(585, 668);
            this.step5Btn.Name = "step5Btn";
            this.step5Btn.Size = new System.Drawing.Size(203, 23);
            this.step5Btn.TabIndex = 17;
            this.step5Btn.Text = "Step 5: Combine Files into FUZ";
            this.step5Btn.UseVisualStyleBackColor = true;
            this.step5Btn.Click += new System.EventHandler(this.step5Btn_Click);
            // 
            // step6Btn
            // 
            this.step6Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.step6Btn.Location = new System.Drawing.Point(585, 697);
            this.step6Btn.Name = "step6Btn";
            this.step6Btn.Size = new System.Drawing.Size(203, 23);
            this.step6Btn.TabIndex = 18;
            this.step6Btn.Text = "Step 6: Delete XWM, LIP && WAV";
            this.step6Btn.UseVisualStyleBackColor = true;
            this.step6Btn.Click += new System.EventHandler(this.step6Btn_Click);
            // 
            // allStepsBtn
            // 
            this.allStepsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.allStepsBtn.Location = new System.Drawing.Point(585, 523);
            this.allStepsBtn.Name = "allStepsBtn";
            this.allStepsBtn.Size = new System.Drawing.Size(203, 23);
            this.allStepsBtn.TabIndex = 19;
            this.allStepsBtn.Text = "Run All Steps";
            this.allStepsBtn.UseVisualStyleBackColor = true;
            this.allStepsBtn.Click += new System.EventHandler(this.allStepsBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pluginnameBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.voicetypeBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 57);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Settings";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 732);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.allStepsBtn);
            this.Controls.Add(this.step6Btn);
            this.Controls.Add(this.step5Btn);
            this.Controls.Add(this.step4Btn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.updatedSelectedBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dialogueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filenameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.step3Btn);
            this.Controls.Add(this.step2Btn);
            this.Controls.Add(this.step1Btn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lip Sync Manager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button step1Btn;
        private System.Windows.Forms.Button step2Btn;
        private System.Windows.Forms.Button step3Btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dialogueBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updatedSelectedBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox voicetypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pluginnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button step4Btn;
        private System.Windows.Forms.Button step5Btn;
        private System.Windows.Forms.Button step6Btn;
        private System.Windows.Forms.Button allStepsBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

