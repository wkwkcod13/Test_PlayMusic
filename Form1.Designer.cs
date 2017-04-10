namespace mPlay
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一首ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一首ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快轉5秒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.到轉5秒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隨機撥放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重複ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.順序播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbr_Vol = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.從檔案開啟ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.從資料夾開啟ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Vol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 172);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.播放ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(473, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.從資料夾開啟ToolStripMenuItem1,
            this.從檔案開啟ToolStripMenuItem1,
            this.結束ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.檔案ToolStripMenuItem.Text = "檔案(&O)";
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.結束ToolStripMenuItem.Text = "退出(&E)";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // 播放ToolStripMenuItem
            // 
            this.播放ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上一首ToolStripMenuItem,
            this.下一首ToolStripMenuItem,
            this.快轉5秒ToolStripMenuItem,
            this.到轉5秒ToolStripMenuItem,
            this.隨機撥放ToolStripMenuItem,
            this.重複ToolStripMenuItem,
            this.順序播放ToolStripMenuItem});
            this.播放ToolStripMenuItem.Name = "播放ToolStripMenuItem";
            this.播放ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.播放ToolStripMenuItem.Text = "播放(&P)";
            this.播放ToolStripMenuItem.Click += new System.EventHandler(this.播放ToolStripMenuItem_Click);
            // 
            // 上一首ToolStripMenuItem
            // 
            this.上一首ToolStripMenuItem.Name = "上一首ToolStripMenuItem";
            this.上一首ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.上一首ToolStripMenuItem.Text = "上一首(&U)";
            this.上一首ToolStripMenuItem.Click += new System.EventHandler(this.上一首ToolStripMenuItem_Click);
            // 
            // 下一首ToolStripMenuItem
            // 
            this.下一首ToolStripMenuItem.Name = "下一首ToolStripMenuItem";
            this.下一首ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.下一首ToolStripMenuItem.Text = "下一首(&N)";
            this.下一首ToolStripMenuItem.Click += new System.EventHandler(this.下一首ToolStripMenuItem_Click);
            // 
            // 快轉5秒ToolStripMenuItem
            // 
            this.快轉5秒ToolStripMenuItem.Name = "快轉5秒ToolStripMenuItem";
            this.快轉5秒ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.快轉5秒ToolStripMenuItem.Text = "快轉5秒(&H)";
            this.快轉5秒ToolStripMenuItem.Click += new System.EventHandler(this.快轉5秒ToolStripMenuItem_Click);
            // 
            // 到轉5秒ToolStripMenuItem
            // 
            this.到轉5秒ToolStripMenuItem.Name = "到轉5秒ToolStripMenuItem";
            this.到轉5秒ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.到轉5秒ToolStripMenuItem.Text = "到轉5秒(&G)";
            this.到轉5秒ToolStripMenuItem.Click += new System.EventHandler(this.到轉5秒ToolStripMenuItem_Click);
            // 
            // 隨機撥放ToolStripMenuItem
            // 
            this.隨機撥放ToolStripMenuItem.Name = "隨機撥放ToolStripMenuItem";
            this.隨機撥放ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.隨機撥放ToolStripMenuItem.Text = "隨機撥放(&R)";
            this.隨機撥放ToolStripMenuItem.Click += new System.EventHandler(this.隨機撥放ToolStripMenuItem_Click);
            // 
            // 重複ToolStripMenuItem
            // 
            this.重複ToolStripMenuItem.Name = "重複ToolStripMenuItem";
            this.重複ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.重複ToolStripMenuItem.Text = "循環播放(&C)";
            this.重複ToolStripMenuItem.Click += new System.EventHandler(this.重複ToolStripMenuItem_Click);
            // 
            // 順序播放ToolStripMenuItem
            // 
            this.順序播放ToolStripMenuItem.Name = "順序播放ToolStripMenuItem";
            this.順序播放ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.順序播放ToolStripMenuItem.Text = "順序播放(&K)";
            this.順序播放ToolStripMenuItem.Click += new System.EventHandler(this.順序播放ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 242);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(444, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(430, 253);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 10;
            // 
            // tbr_Vol
            // 
            this.tbr_Vol.Location = new System.Drawing.Point(345, 293);
            this.tbr_Vol.Maximum = 100;
            this.tbr_Vol.Name = "tbr_Vol";
            this.tbr_Vol.Size = new System.Drawing.Size(111, 45);
            this.tbr_Vol.TabIndex = 11;
            this.tbr_Vol.Scroll += new System.EventHandler(this.tba_Vol_Scroll);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // 從檔案開啟ToolStripMenuItem1
            // 
            this.從檔案開啟ToolStripMenuItem1.Name = "從檔案開啟ToolStripMenuItem1";
            this.從檔案開啟ToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.從檔案開啟ToolStripMenuItem1.Text = "從檔案開啟(&F)";
            this.從檔案開啟ToolStripMenuItem1.Click += new System.EventHandler(this.從檔案開啟ToolStripMenuItem1_Click);
            // 
            // 從資料夾開啟ToolStripMenuItem1
            // 
            this.從資料夾開啟ToolStripMenuItem1.Name = "從資料夾開啟ToolStripMenuItem1";
            this.從資料夾開啟ToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.從資料夾開啟ToolStripMenuItem1.Text = "從資料夾開啟(&T)";
            this.從資料夾開啟ToolStripMenuItem1.Click += new System.EventHandler(this.從資料夾開啟ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 332);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbr_Vol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "mPlay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Vol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一首ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一首ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快轉5秒ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 到轉5秒ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隨機撥放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重複ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 順序播放ToolStripMenuItem;
        private System.Windows.Forms.TrackBar tbr_Vol;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 從資料夾開啟ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 從檔案開啟ToolStripMenuItem1;
    }
}

