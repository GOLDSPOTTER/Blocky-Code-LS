namespace LS
{
    partial class ProjectEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEditor));
            panel1 = new Panel();
            SaveProjectButton = new Button();
            TitleLabel = new Label();
            CodingCanvasLabel = new Label();
            BlockPalleteLabel = new Label();
            tblCodeArea = new TableLayoutPanel();
            pbWhenClicked = new PictureBox();
            EventsColor = new PictureBox();
            MotionColor = new PictureBox();
            OperatorsColor = new PictureBox();
            pictureBox1 = new PictureBox();
            pbForLoop = new PictureBox();
            BackButton = new Button();
            lblList = new Label();
            panel1.SuspendLayout();
            tblCodeArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWhenClicked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EventsColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MotionColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OperatorsColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbForLoop).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(SaveProjectButton);
            panel1.Controls.Add(TitleLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 108);
            panel1.TabIndex = 3;
            // 
            // SaveProjectButton
            // 
            SaveProjectButton.BackColor = SystemColors.Highlight;
            SaveProjectButton.ForeColor = SystemColors.Control;
            SaveProjectButton.Location = new Point(119, 39);
            SaveProjectButton.Name = "SaveProjectButton";
            SaveProjectButton.Size = new Size(80, 23);
            SaveProjectButton.TabIndex = 5;
            SaveProjectButton.Text = "Save Project";
            SaveProjectButton.UseVisualStyleBackColor = false;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = SystemColors.HotTrack;
            TitleLabel.ForeColor = SystemColors.ControlText;
            TitleLabel.Location = new Point(359, 47);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(73, 15);
            TitleLabel.TabIndex = 4;
            TitleLabel.Text = "Blocky Code";
            // 
            // CodingCanvasLabel
            // 
            CodingCanvasLabel.AutoSize = true;
            CodingCanvasLabel.Location = new Point(345, 111);
            CodingCanvasLabel.Name = "CodingCanvasLabel";
            CodingCanvasLabel.Size = new Size(87, 15);
            CodingCanvasLabel.TabIndex = 4;
            CodingCanvasLabel.Text = "Coding Canvas";
            // 
            // BlockPalleteLabel
            // 
            BlockPalleteLabel.AutoSize = true;
            BlockPalleteLabel.Location = new Point(23, 146);
            BlockPalleteLabel.Name = "BlockPalleteLabel";
            BlockPalleteLabel.Size = new Size(74, 15);
            BlockPalleteLabel.TabIndex = 5;
            BlockPalleteLabel.Text = "Block Pallete";
            // 
            // tblCodeArea
            // 
            tblCodeArea.ColumnCount = 2;
            tblCodeArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.5836563F));
            tblCodeArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.4163437F));
            tblCodeArea.Controls.Add(pbWhenClicked, 1, 0);
            tblCodeArea.Controls.Add(EventsColor, 0, 0);
            tblCodeArea.Controls.Add(MotionColor, 0, 1);
            tblCodeArea.Controls.Add(OperatorsColor, 0, 2);
            tblCodeArea.Controls.Add(pictureBox1, 0, 3);
            tblCodeArea.Controls.Add(pbForLoop, 1, 1);
            tblCodeArea.Location = new Point(12, 164);
            tblCodeArea.Name = "tblCodeArea";
            tblCodeArea.RowCount = 4;
            tblCodeArea.RowStyles.Add(new RowStyle(SizeType.Percent, 51.0989F));
            tblCodeArea.RowStyles.Add(new RowStyle(SizeType.Percent, 48.9011F));
            tblCodeArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tblCodeArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblCodeArea.Size = new Size(391, 286);
            tblCodeArea.TabIndex = 6;
            // 
            // pbWhenClicked
            // 
            pbWhenClicked.Image = (Image)resources.GetObject("pbWhenClicked.Image");
            pbWhenClicked.Location = new Point(200, 3);
            pbWhenClicked.Name = "pbWhenClicked";
            pbWhenClicked.Size = new Size(188, 49);
            pbWhenClicked.TabIndex = 7;
            pbWhenClicked.TabStop = false;
            pbWhenClicked.Tag = "When clicked";
            pbWhenClicked.MouseDown += codeBlock_MouseDown;
            // 
            // EventsColor
            // 
            EventsColor.Image = (Image)resources.GetObject("EventsColor.Image");
            EventsColor.Location = new Point(3, 3);
            EventsColor.Name = "EventsColor";
            EventsColor.Size = new Size(65, 77);
            EventsColor.SizeMode = PictureBoxSizeMode.Zoom;
            EventsColor.TabIndex = 8;
            EventsColor.TabStop = false;
            // 
            // MotionColor
            // 
            MotionColor.Image = (Image)resources.GetObject("MotionColor.Image");
            MotionColor.Location = new Point(3, 86);
            MotionColor.Name = "MotionColor";
            MotionColor.Size = new Size(65, 55);
            MotionColor.SizeMode = PictureBoxSizeMode.Zoom;
            MotionColor.TabIndex = 9;
            MotionColor.TabStop = false;
            // 
            // OperatorsColor
            // 
            OperatorsColor.Image = (Image)resources.GetObject("OperatorsColor.Image");
            OperatorsColor.Location = new Point(3, 166);
            OperatorsColor.Name = "OperatorsColor";
            OperatorsColor.Size = new Size(65, 53);
            OperatorsColor.SizeMode = PictureBoxSizeMode.Zoom;
            OperatorsColor.TabIndex = 10;
            OperatorsColor.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pbForLoop
            // 
            pbForLoop.Image = (Image)resources.GetObject("pbForLoop.Image");
            pbForLoop.Location = new Point(200, 86);
            pbForLoop.Name = "pbForLoop";
            pbForLoop.Size = new Size(188, 62);
            pbForLoop.SizeMode = PictureBoxSizeMode.StretchImage;
            pbForLoop.TabIndex = 12;
            pbForLoop.TabStop = false;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(651, 423);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(148, 27);
            BackButton.TabIndex = 13;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Location = new Point(527, 111);
            lblList.Name = "lblList";
            lblList.Size = new Size(95, 15);
            lblList.TabIndex = 14;
            lblList.Text = "Label from thing";
            // 
            // ProjectEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblList);
            Controls.Add(BackButton);
            Controls.Add(tblCodeArea);
            Controls.Add(BlockPalleteLabel);
            Controls.Add(CodingCanvasLabel);
            Controls.Add(panel1);
            Name = "ProjectEditor";
            Text = "ProjectEditor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tblCodeArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbWhenClicked).EndInit();
            ((System.ComponentModel.ISupportInitialize)EventsColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)MotionColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)OperatorsColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbForLoop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label TitleLabel;
        private Button SaveProjectButton;
        private Label CodingCanvasLabel;
        private Label BlockPalleteLabel;
        private TableLayoutPanel tblCodeArea;
        private PictureBox pbWhenClicked;
        private PictureBox EventsColor;
        private PictureBox MotionColor;
        private PictureBox OperatorsColor;
        private PictureBox pictureBox1;
        private Button BackButton;
        private Label lblList;
        private PictureBox pbForLoop;
    }
}