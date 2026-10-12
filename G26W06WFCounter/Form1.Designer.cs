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
            btnDown = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // labelCount
            // 
            labelCount.BackColor = SystemColors.Info;
            labelCount.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            labelCount.Location = new Point(79, 55);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(446, 228);
            labelCount.TabIndex = 0;
            labelCount.Text = "0";
            labelCount.TextAlign = ContentAlignment.MiddleCenter;
            labelCount.Click += label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(79, 286);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(224, 60);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "증가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(304, 286);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(221, 60);
            btnDown.TabIndex = 2;
            btnDown.Text = "감소";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += OnDown;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(79, 352);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(446, 60);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "초기화";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += OnRemove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 495);
            Controls.Add(btnRemove);
            Controls.Add(btnDown);
            Controls.Add(btnAdd);
            Controls.Add(labelCount);
            Name = "Form1";
            Text = "카운터";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelCount;
        private Button btnAdd;
        private Button btnDown;
        private Button btnRemove;
    }
}
