namespace PianoChordGenerator.WinUI
{
    partial class frmPianoChordGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPianoChordGenerator));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChordSheetGenerator = new System.Windows.Forms.TabPage();
            this.btnGenerateChordSheet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSelectedChords = new System.Windows.Forms.ListBox();
            this.lblChordsToExport = new System.Windows.Forms.Label();
            this.grpChordSelect = new System.Windows.Forms.GroupBox();
            this.picRootPosition = new System.Windows.Forms.PictureBox();
            this.radRootPosition = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picSecondInversion = new System.Windows.Forms.PictureBox();
            this.rad2ndInversion = new System.Windows.Forms.RadioButton();
            this.picFirstInversion = new System.Windows.Forms.PictureBox();
            this.rad1stInversion = new System.Windows.Forms.RadioButton();
            this.btnRemoveChord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddChord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboChordSelect = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabChordSheetGenerator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpChordSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRootPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondInversion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstInversion)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChordSheetGenerator);
            this.tabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 707);
            this.tabControl1.TabIndex = 0;
            // 
            // tabChordSheetGenerator
            // 
            this.tabChordSheetGenerator.Controls.Add(this.btnGenerateChordSheet);
            this.tabChordSheetGenerator.Controls.Add(this.groupBox2);
            this.tabChordSheetGenerator.Controls.Add(this.lblChordsToExport);
            this.tabChordSheetGenerator.Controls.Add(this.grpChordSelect);
            this.tabChordSheetGenerator.Controls.Add(this.btnRemoveChord);
            this.tabChordSheetGenerator.Controls.Add(this.label3);
            this.tabChordSheetGenerator.Controls.Add(this.btnAddChord);
            this.tabChordSheetGenerator.Controls.Add(this.label1);
            this.tabChordSheetGenerator.Controls.Add(this.cboChordSelect);
            this.tabChordSheetGenerator.Location = new System.Drawing.Point(4, 37);
            this.tabChordSheetGenerator.Name = "tabChordSheetGenerator";
            this.tabChordSheetGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tabChordSheetGenerator.Size = new System.Drawing.Size(933, 666);
            this.tabChordSheetGenerator.TabIndex = 0;
            this.tabChordSheetGenerator.Text = "Chord Sheet Generator";
            this.tabChordSheetGenerator.UseVisualStyleBackColor = true;
            // 
            // btnGenerateChordSheet
            // 
            this.btnGenerateChordSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGenerateChordSheet.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateChordSheet.Location = new System.Drawing.Point(14, 594);
            this.btnGenerateChordSheet.Name = "btnGenerateChordSheet";
            this.btnGenerateChordSheet.Size = new System.Drawing.Size(853, 51);
            this.btnGenerateChordSheet.TabIndex = 3;
            this.btnGenerateChordSheet.Text = "Generate Chord Sheet";
            this.btnGenerateChordSheet.UseVisualStyleBackColor = false;
            this.btnGenerateChordSheet.Click += new System.EventHandler(this.btnGenerateChordSheet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstSelectedChords);
            this.groupBox2.Location = new System.Drawing.Point(547, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 450);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lstSelectedChords
            // 
            this.lstSelectedChords.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSelectedChords.FormattingEnabled = true;
            this.lstSelectedChords.ItemHeight = 27;
            this.lstSelectedChords.Location = new System.Drawing.Point(24, 34);
            this.lstSelectedChords.Name = "lstSelectedChords";
            this.lstSelectedChords.Size = new System.Drawing.Size(270, 301);
            this.lstSelectedChords.TabIndex = 2;
            // 
            // lblChordsToExport
            // 
            this.lblChordsToExport.AutoSize = true;
            this.lblChordsToExport.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChordsToExport.Location = new System.Drawing.Point(547, 95);
            this.lblChordsToExport.Name = "lblChordsToExport";
            this.lblChordsToExport.Size = new System.Drawing.Size(168, 24);
            this.lblChordsToExport.TabIndex = 1;
            this.lblChordsToExport.Text = "Chords to Export:";
            // 
            // grpChordSelect
            // 
            this.grpChordSelect.Controls.Add(this.picRootPosition);
            this.grpChordSelect.Controls.Add(this.radRootPosition);
            this.grpChordSelect.Controls.Add(this.label5);
            this.grpChordSelect.Controls.Add(this.label2);
            this.grpChordSelect.Controls.Add(this.label4);
            this.grpChordSelect.Controls.Add(this.picSecondInversion);
            this.grpChordSelect.Controls.Add(this.rad2ndInversion);
            this.grpChordSelect.Controls.Add(this.picFirstInversion);
            this.grpChordSelect.Controls.Add(this.rad1stInversion);
            this.grpChordSelect.Location = new System.Drawing.Point(14, 113);
            this.grpChordSelect.Name = "grpChordSelect";
            this.grpChordSelect.Size = new System.Drawing.Size(391, 459);
            this.grpChordSelect.TabIndex = 7;
            this.grpChordSelect.TabStop = false;
            // 
            // picRootPosition
            // 
            this.picRootPosition.Location = new System.Drawing.Point(63, 43);
            this.picRootPosition.Name = "picRootPosition";
            this.picRootPosition.Size = new System.Drawing.Size(302, 108);
            this.picRootPosition.TabIndex = 4;
            this.picRootPosition.TabStop = false;
            this.picRootPosition.Click += new System.EventHandler(this.picRootPosition_Click);
            // 
            // radRootPosition
            // 
            this.radRootPosition.AutoSize = true;
            this.radRootPosition.Location = new System.Drawing.Point(17, 67);
            this.radRootPosition.Name = "radRootPosition";
            this.radRootPosition.Size = new System.Drawing.Size(21, 20);
            this.radRootPosition.TabIndex = 5;
            this.radRootPosition.TabStop = true;
            this.radRootPosition.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "2nd Inversion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Root Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "1st Inversion";
            // 
            // picSecondInversion
            // 
            this.picSecondInversion.Location = new System.Drawing.Point(60, 336);
            this.picSecondInversion.Name = "picSecondInversion";
            this.picSecondInversion.Size = new System.Drawing.Size(302, 108);
            this.picSecondInversion.TabIndex = 4;
            this.picSecondInversion.TabStop = false;
            this.picSecondInversion.Click += new System.EventHandler(this.picSecondInversion_Click);
            // 
            // rad2ndInversion
            // 
            this.rad2ndInversion.AutoSize = true;
            this.rad2ndInversion.Location = new System.Drawing.Point(14, 350);
            this.rad2ndInversion.Name = "rad2ndInversion";
            this.rad2ndInversion.Size = new System.Drawing.Size(21, 20);
            this.rad2ndInversion.TabIndex = 5;
            this.rad2ndInversion.TabStop = true;
            this.rad2ndInversion.UseVisualStyleBackColor = true;
            // 
            // picFirstInversion
            // 
            this.picFirstInversion.Location = new System.Drawing.Point(63, 196);
            this.picFirstInversion.Name = "picFirstInversion";
            this.picFirstInversion.Size = new System.Drawing.Size(302, 108);
            this.picFirstInversion.TabIndex = 4;
            this.picFirstInversion.TabStop = false;
            this.picFirstInversion.Click += new System.EventHandler(this.picFirstInversion_Click);
            // 
            // rad1stInversion
            // 
            this.rad1stInversion.AutoSize = true;
            this.rad1stInversion.Location = new System.Drawing.Point(17, 218);
            this.rad1stInversion.Name = "rad1stInversion";
            this.rad1stInversion.Size = new System.Drawing.Size(21, 20);
            this.rad1stInversion.TabIndex = 5;
            this.rad1stInversion.TabStop = true;
            this.rad1stInversion.UseVisualStyleBackColor = true;
            // 
            // btnRemoveChord
            // 
            this.btnRemoveChord.Location = new System.Drawing.Point(411, 263);
            this.btnRemoveChord.Name = "btnRemoveChord";
            this.btnRemoveChord.Size = new System.Drawing.Size(112, 34);
            this.btnRemoveChord.TabIndex = 3;
            this.btnRemoveChord.Text = "<";
            this.btnRemoveChord.UseVisualStyleBackColor = true;
            this.btnRemoveChord.Click += new System.EventHandler(this.btnRemoveChord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select a Chord Inversion:";
            // 
            // btnAddChord
            // 
            this.btnAddChord.Location = new System.Drawing.Point(411, 195);
            this.btnAddChord.Name = "btnAddChord";
            this.btnAddChord.Size = new System.Drawing.Size(112, 34);
            this.btnAddChord.TabIndex = 3;
            this.btnAddChord.Text = ">";
            this.btnAddChord.UseVisualStyleBackColor = true;
            this.btnAddChord.Click += new System.EventHandler(this.btnAddChord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Chord:";
            // 
            // cboChordSelect
            // 
            this.cboChordSelect.FormattingEnabled = true;
            this.cboChordSelect.Location = new System.Drawing.Point(14, 32);
            this.cboChordSelect.Name = "cboChordSelect";
            this.cboChordSelect.Size = new System.Drawing.Size(365, 36);
            this.cboChordSelect.TabIndex = 0;
            this.cboChordSelect.SelectedIndexChanged += new System.EventHandler(this.cboChordSelect_SelectedIndexChanged);
            // 
            // frmPianoChordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 788);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPianoChordGenerator";
            this.Text = "Piano Chord Generator";
            this.tabControl1.ResumeLayout(false);
            this.tabChordSheetGenerator.ResumeLayout(false);
            this.tabChordSheetGenerator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpChordSelect.ResumeLayout(false);
            this.grpChordSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRootPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondInversion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstInversion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChordSheetGenerator;
        private System.Windows.Forms.Button btnAddChord;
        private System.Windows.Forms.ListBox lstSelectedChords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChordSelect;
        private System.Windows.Forms.PictureBox picRootPosition;
        private System.Windows.Forms.RadioButton radRootPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picSecondInversion;
        private System.Windows.Forms.RadioButton rad2ndInversion;
        private System.Windows.Forms.PictureBox picFirstInversion;
        private System.Windows.Forms.RadioButton rad1stInversion;
        private System.Windows.Forms.Button btnRemoveChord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpChordSelect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblChordsToExport;
        private System.Windows.Forms.Button btnGenerateChordSheet;
    }
}

