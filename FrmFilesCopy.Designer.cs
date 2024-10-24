namespace DZ_FileCopySync
{
    partial class FrmFilesCopy
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
            pgCopyProgress1 = new ProgressBar();
            pgCopyProgress2 = new ProgressBar();
            pgCopyProgress3 = new ProgressBar();
            pgCopyProgress4 = new ProgressBar();
            pgCopyProgressTotal = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCopy = new Button();
            SuspendLayout();
            // 
            // pgCopyProgress1
            // 
            pgCopyProgress1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pgCopyProgress1.Location = new Point(101, 12);
            pgCopyProgress1.Name = "pgCopyProgress1";
            pgCopyProgress1.Size = new Size(300, 30);
            pgCopyProgress1.TabIndex = 0;
            // 
            // pgCopyProgress2
            // 
            pgCopyProgress2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pgCopyProgress2.Location = new Point(101, 48);
            pgCopyProgress2.Name = "pgCopyProgress2";
            pgCopyProgress2.Size = new Size(300, 30);
            pgCopyProgress2.TabIndex = 1;
            // 
            // pgCopyProgress3
            // 
            pgCopyProgress3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pgCopyProgress3.Location = new Point(101, 84);
            pgCopyProgress3.Name = "pgCopyProgress3";
            pgCopyProgress3.Size = new Size(300, 30);
            pgCopyProgress3.TabIndex = 2;
            // 
            // pgCopyProgress4
            // 
            pgCopyProgress4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pgCopyProgress4.Location = new Point(101, 120);
            pgCopyProgress4.Name = "pgCopyProgress4";
            pgCopyProgress4.Size = new Size(300, 30);
            pgCopyProgress4.TabIndex = 3;
            // 
            // pgCopyProgressTotal
            // 
            pgCopyProgressTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pgCopyProgressTotal.Location = new Point(101, 172);
            pgCopyProgressTotal.Name = "pgCopyProgressTotal";
            pgCopyProgressTotal.Size = new Size(300, 30);
            pgCopyProgressTotal.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 5;
            label1.Text = "Файл 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 6;
            label2.Text = "Файл 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 7;
            label3.Text = "Файл 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 8;
            label4.Text = "Файл 4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 182);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Все файлы";
            // 
            // btnCopy
            // 
            btnCopy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCopy.Location = new Point(295, 208);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(106, 29);
            btnCopy.TabIndex = 10;
            btnCopy.Text = "Копировать";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // FrmFilesCopy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 253);
            Controls.Add(btnCopy);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pgCopyProgressTotal);
            Controls.Add(pgCopyProgress4);
            Controls.Add(pgCopyProgress3);
            Controls.Add(pgCopyProgress2);
            Controls.Add(pgCopyProgress1);
            Name = "FrmFilesCopy";
            Text = "Копирование файлов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pgCopyProgress1;
        private ProgressBar pgCopyProgress2;
        private ProgressBar pgCopyProgress3;
        private ProgressBar pgCopyProgress4;
        private ProgressBar pgCopyProgressTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCopy;
    }
}
