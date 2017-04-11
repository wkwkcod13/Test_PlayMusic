using System;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Collections.Concurrent;
using System.Timers;

namespace mPlay
{
    public partial class Form1 : Form
    {
        private static string[] fileNameExtension = { "mp3","mp4","wav","wv","wma","mpc","aac"};
        private string[] args;

        private ConcurrentDictionary<string, int> playList = new ConcurrentDictionary<string, int>();
        private System.Timers.Timer timer = new System.Timers.Timer();//設定計時器


        public Form1(string[] args)
        {
            InitializeComponent();
            this.args = args;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllowDrop = true;//啟動拖拉
            listBox1.AllowDrop = true;

            //事件綁定
            wPlayer.CurrentItemChange += CurrentItemChange;//正在播放的物件改變時

            wPlayer.settings.volume = 10;

            tbr_Vol.Value = 10;
            tbr_Vol.Maximum = 100;
            tbr_Vol.Minimum = 0;

            timer.Elapsed += Elapsed;
            timer.Interval = 100;

            if (args != null && args.Length > 0)
                CheckType(args);
        }

        public void Elapsed(object sender, ElapsedEventArgs e)
        {
            if (wPlayer.playState == WMPPlayState.wmppsPlaying)
                PositionChange();
        }

        public delegate void DesignerChange();
        public delegate void DeleGateInvoke();

        ///設定目前播放進度條
        public void PositionChange()
        {
            this.Invoke(new DesignerChange(() =>
            {
                trackBar1.Maximum = (int)(wPlayer.currentMedia.duration * 1000);//設定撥放進度條(結束)
                trackBar1.Value = (int)(wPlayer.controls.currentPosition * 1000);
            }));
        }

        //設定撥放進度條
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar obj = sender as TrackBar;
            wPlayer.controls.currentPosition = ((double)obj.Value) / 1000;
        }


        //播放物件改變時觸發
        public void CurrentItemChange(Object item)
        {
            IWMPMedia currentItem = item as IWMPMedia;
            label1.Text = currentItem.name;//設定目前撥放的歌名
            trackBar1.Minimum = 0;//設定撥放進度條(初始)
            trackBar1.Maximum = (int)(currentItem.duration * 1000);//設定撥放進度條(結束)
            int index = -1;
            //更新播放頁面的
            for(int i = 0;i < wPlayer.currentPlaylist.count; i++)
            {
                if (currentItem.isIdentical[wPlayer.currentPlaylist.Item[i]])
                {
                    index = i;
                    break;
                }
            }
            PlayListChange(index);
        }
        public void PlayListChange(int index)
        {
            this.Invoke(new DesignerChange(() =>
            {
                listBox1.SelectedIndex = index;
            }));
        }

        IWMPPlaylist playerLists;
        WindowsMediaPlayer wPlayer = new WindowsMediaPlayer();
        //播放
        private void button2_Click(object sender, EventArgs e)
        {
            wPlayer.controls.play();
            timer.Enabled = true;
        }
        //拖拉後處理
        private void OnDragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
            CheckType(fileNames);
        }
        //拖拉進入點
        private void OnDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        //停止
        private void button1_Click(object sender, EventArgs e)
        {
            wPlayer.controls.stop();
            trackBar1.Value = 0;
            timer.Enabled = false;
        }

        //重複播放
        private void 重複ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wPlayer.settings.setMode("loop", true);
        }

        //檢查檔案名稱
        private void CheckType(string[] fileNames)
        {
            Invoke(new DeleGateInvoke(() =>
            {

                foreach (string names in fileNames)
                {
                    string[] tmp = names.Split('.');//檢查副檔名排除mp3以外的檔案

                    bool match = false;
                    //只有一個符合就可
                    foreach (string eName in fileNameExtension)
                    {
                        if (tmp[tmp.Length - 1].ToLower() == eName)
                        {
                            match = true;
                            break;
                        }
                    }
                    if (!match)
                    {
                        continue;
                    }

                    tmp = names.Split('\\');
                    listBox1.Items.Add(tmp[tmp.Length - 1]);
                    IWMPMedia media = wPlayer.newMedia(names);
                    playList.TryAdd(tmp[tmp.Length - 1], wPlayer.currentPlaylist.count);
                    wPlayer.currentPlaylist.insertItem(wPlayer.currentPlaylist.count, media);
                }
            }));
        }

        private void 順序播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wPlayer.settings.setMode("shuffle",false);
        }

        private void 隨機撥放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wPlayer.settings.setMode("shuffle", true);
        }

        //設定音量大小
        private void tba_Vol_Scroll(object sender, EventArgs e)
        {
            wPlayer.settings.volume = tbr_Vol.Value;
        }

        private void 到轉5秒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wPlayer.controls.currentPosition = wPlayer.controls.currentPosition - 5.0d;
        }

        private void 快轉5秒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wPlayer.controls.currentPosition = wPlayer.controls.currentPosition + 5.0d;
        }

        private void 上一首ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wPlayer.controls.previous();
        }

        private void 下一首ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wPlayer.controls.next();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 && listBox1.SelectedIndex != -1)
            {
                wPlayer.controls.playItem(wPlayer.currentPlaylist.Item[playList[listBox1.Text]]);
                timer.Enabled = true;
            }
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (wPlayer.playState == WMPPlayState.wmppsPaused)
            {
                wPlayer.controls.play();
            }
            else if (wPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                wPlayer.controls.pause();
            }
        }

        //從資料夾開啟
        private void 從資料夾開啟ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string patch = folderBrowserDialog1.SelectedPath;
                string[] fileNames = Directory.GetFiles(patch);
                CheckType(fileNames);
            }
        }

        //從檔案開啟
        private void 從檔案開啟ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog1.FileNames;
                CheckType(fileNames);
            }
        }
    }
}
