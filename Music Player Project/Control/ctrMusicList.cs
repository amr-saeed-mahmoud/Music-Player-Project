using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Music_Player_Project.Control
{
    public partial class ctrMusicList : UserControl
    {
        public class SelectedMusicEventArgs : EventArgs
        {
            public string CurMusicName { get; set; }
            public string MusicFilePath {  get; set; }
            public NAudio.Wave.AudioFileReader CurMusic { get; }

            public SelectedMusicEventArgs(string curMusicName, string MusicFilePath)
            {
                string[] MusicPath = Directory.GetFiles(Util.MusicFolderPath, curMusicName, SearchOption.AllDirectories);
                this.CurMusicName = curMusicName;
                this.MusicFilePath = MusicPath[0];
                this.CurMusic = new NAudio.Wave.AudioFileReader(MusicFilePath);
            }
        }

        public delegate void SelectedMusicEventHandler(object sender, SelectedMusicEventArgs e);

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public event SelectedMusicEventHandler SelectedMusic;

        private void MusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnItemSelected();
        }
        protected virtual void OnItemSelected()
        {
            if (SelectedMusic != null && MusicList.SelectedItems.Count > 0)
            {
                string SelectedMusicName = MusicList.SelectedItems[0].Text;

                string[] MusicFilePath = Directory.GetFiles(Util.MusicFolderPath, SelectedMusicName, SearchOption.TopDirectoryOnly);
                if (MusicFilePath.Length > 0 && SelectedMusic != null)
                {
                    SelectedMusic?.Invoke(this, new SelectedMusicEventArgs(SelectedMusicName, MusicFilePath[0]));
                }
            }
        }
        public ctrMusicList()
        {
            InitializeComponent();
        }

        private void FailMusicList()
        {
            List<string> Music = Util.GetAllMusicNameFromMusicProjectFile();
            foreach (string item in Music)
            {
                MusicList.Items.Add(item);
            }
        }
        private void ctrMusicList_Load(object sender, EventArgs e)
        {
            FailMusicList();
        }

        public int SelectedMusicIndex
        {
            get 
            {
                int LastIndex = MusicList.SelectedIndices.Count - 1;
                return MusicList.SelectedIndices[LastIndex];
            }
        }
        public int CountOfMusicInMusicList
        {
            get { return MusicList.Items.Count; }
        }

        public void ChangeSelectedIndex(int Index)
        {
            MusicList.SelectedIndices.Clear();
            MusicList.SelectedIndices.Add(Index);
        }
        
    }
}
