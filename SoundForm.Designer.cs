namespace _2
{
    partial class SoundForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.DelSongText = new System.Windows.Forms.TextBox();
            this.GoToStart = new System.Windows.Forms.Button();
            this.panelMusic = new System.Windows.Forms.Panel();
            this.StartAddMusic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextFilename = new System.Windows.Forms.TextBox();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.TextAuthor = new System.Windows.Forms.TextBox();
            this.Deleate = new System.Windows.Forms.Button();
            this.AddMusic = new System.Windows.Forms.Button();
            this.listBoxAllMusic = new System.Windows.Forms.ListBox();
            this.past = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.DellAllBtn = new System.Windows.Forms.Button();
            this.panelMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Введите название песни";
            // 
            // DelSongText
            // 
            this.DelSongText.Location = new System.Drawing.Point(163, 389);
            this.DelSongText.Name = "DelSongText";
            this.DelSongText.Size = new System.Drawing.Size(100, 20);
            this.DelSongText.TabIndex = 20;
            // 
            // GoToStart
            // 
            this.GoToStart.Location = new System.Drawing.Point(364, 314);
            this.GoToStart.Name = "GoToStart";
            this.GoToStart.Size = new System.Drawing.Size(75, 23);
            this.GoToStart.TabIndex = 19;
            this.GoToStart.Text = "[]";
            this.GoToStart.UseVisualStyleBackColor = true;
            this.GoToStart.Click += new System.EventHandler(this.GoToStart_Click_1);
            // 
            // panelMusic
            // 
            this.panelMusic.Controls.Add(this.StartAddMusic);
            this.panelMusic.Controls.Add(this.label3);
            this.panelMusic.Controls.Add(this.label2);
            this.panelMusic.Controls.Add(this.label1);
            this.panelMusic.Controls.Add(this.TextFilename);
            this.panelMusic.Controls.Add(this.TextTitle);
            this.panelMusic.Controls.Add(this.TextAuthor);
            this.panelMusic.Location = new System.Drawing.Point(261, 12);
            this.panelMusic.Name = "panelMusic";
            this.panelMusic.Size = new System.Drawing.Size(200, 123);
            this.panelMusic.TabIndex = 18;
            this.panelMusic.Visible = false;
            // 
            // StartAddMusic
            // 
            this.StartAddMusic.Location = new System.Drawing.Point(113, 62);
            this.StartAddMusic.Name = "StartAddMusic";
            this.StartAddMusic.Size = new System.Drawing.Size(75, 23);
            this.StartAddMusic.TabIndex = 6;
            this.StartAddMusic.Text = "Add";
            this.StartAddMusic.UseVisualStyleBackColor = true;
            this.StartAddMusic.Click += new System.EventHandler(this.StartAddMusic_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Author";
            // 
            // TextFilename
            // 
            this.TextFilename.Location = new System.Drawing.Point(7, 100);
            this.TextFilename.Name = "TextFilename";
            this.TextFilename.Size = new System.Drawing.Size(100, 20);
            this.TextFilename.TabIndex = 2;
            // 
            // TextTitle
            // 
            this.TextTitle.Location = new System.Drawing.Point(7, 62);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(100, 20);
            this.TextTitle.TabIndex = 1;
            // 
            // TextAuthor
            // 
            this.TextAuthor.Location = new System.Drawing.Point(7, 21);
            this.TextAuthor.Name = "TextAuthor";
            this.TextAuthor.Size = new System.Drawing.Size(100, 20);
            this.TextAuthor.TabIndex = 0;
            // 
            // Deleate
            // 
            this.Deleate.Location = new System.Drawing.Point(163, 415);
            this.Deleate.Name = "Deleate";
            this.Deleate.Size = new System.Drawing.Size(75, 23);
            this.Deleate.TabIndex = 17;
            this.Deleate.Text = "Del";
            this.Deleate.UseVisualStyleBackColor = true;
            this.Deleate.Click += new System.EventHandler(this.Deleate_Click_1);
            // 
            // AddMusic
            // 
            this.AddMusic.Location = new System.Drawing.Point(163, 12);
            this.AddMusic.Name = "AddMusic";
            this.AddMusic.Size = new System.Drawing.Size(75, 23);
            this.AddMusic.TabIndex = 16;
            this.AddMusic.Text = "Add";
            this.AddMusic.UseVisualStyleBackColor = true;
            this.AddMusic.Click += new System.EventHandler(this.AddMusic_Click_1);
            // 
            // listBoxAllMusic
            // 
            this.listBoxAllMusic.FormattingEnabled = true;
            this.listBoxAllMusic.Location = new System.Drawing.Point(1, 3);
            this.listBoxAllMusic.Name = "listBoxAllMusic";
            this.listBoxAllMusic.Size = new System.Drawing.Size(156, 446);
            this.listBoxAllMusic.TabIndex = 15;
            // 
            // past
            // 
            this.past.Location = new System.Drawing.Point(318, 258);
            this.past.Name = "past";
            this.past.Size = new System.Drawing.Size(50, 50);
            this.past.TabIndex = 14;
            this.past.Text = "<";
            this.past.UseVisualStyleBackColor = true;
            this.past.Click += new System.EventHandler(this.past_Click_1);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(430, 258);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(50, 50);
            this.Next.TabIndex = 13;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click_1);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(374, 258);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(50, 50);
            this.start.TabIndex = 12;
            this.start.Text = "|>";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.Location = new System.Drawing.Point(332, 235);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(139, 17);
            this.listBoxMusic.TabIndex = 11;
            // 
            // DellAllBtn
            // 
            this.DellAllBtn.Location = new System.Drawing.Point(167, 202);
            this.DellAllBtn.Name = "DellAllBtn";
            this.DellAllBtn.Size = new System.Drawing.Size(75, 23);
            this.DellAllBtn.TabIndex = 22;
            this.DellAllBtn.Text = "DelALL";
            this.DellAllBtn.UseVisualStyleBackColor = true;
            this.DellAllBtn.Click += new System.EventHandler(this.DellAllBtn_Click);
            // 
            // SoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DellAllBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DelSongText);
            this.Controls.Add(this.GoToStart);
            this.Controls.Add(this.panelMusic);
            this.Controls.Add(this.Deleate);
            this.Controls.Add(this.AddMusic);
            this.Controls.Add(this.listBoxAllMusic);
            this.Controls.Add(this.past);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.start);
            this.Controls.Add(this.listBoxMusic);
            this.Name = "SoundForm";
            this.Text = "Form2";
            this.panelMusic.ResumeLayout(false);
            this.panelMusic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DelSongText;
        private System.Windows.Forms.Button GoToStart;
        private System.Windows.Forms.Panel panelMusic;
        private System.Windows.Forms.Button StartAddMusic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextFilename;
        private System.Windows.Forms.TextBox TextTitle;
        private System.Windows.Forms.TextBox TextAuthor;
        private System.Windows.Forms.Button Deleate;
        private System.Windows.Forms.Button AddMusic;
        private System.Windows.Forms.ListBox listBoxAllMusic;
        private System.Windows.Forms.Button past;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ListBox listBoxMusic;
        private System.Windows.Forms.Button DellAllBtn;
    }
}