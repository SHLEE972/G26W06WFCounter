namespace G26W06WFCounter
{
    partial class Form1
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
        private void InitializeComponent() {
            labelCount = new Label();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // labelCount
            // 
            labelCount.BackColor = SystemColors.Info;
            labelCount.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            labelCount.Location = new Point(12, 9);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(337, 226);
            labelCount.TabIndex = 0;
            labelCount.Text = "0";
            labelCount.TextAlign = ContentAlignment.MiddleCenter;
            labelCount.Click += label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 238);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(337, 55);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "증가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(12, 299);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(165, 61);
            btnSubtract.TabIndex = 2;
            btnSubtract.Text = "감소";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(183, 299);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(166, 61);
            btnReset.TabIndex = 3;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 372);
            Controls.Add(btnReset);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(labelCount);
            Name = "Form1";
            Text = "카운터";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private void BtnSubtract_Click(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        #endregion

        private Label labelCount;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnReset;
    }
}
