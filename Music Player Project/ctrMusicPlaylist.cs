using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Music_Player_Project.Control.ctrMusicList;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Music_Player_Project
{
    public partial class ctrMusicPlaylist : UserControl
    {

        // --------------Event Parts---------------
        public class PlaylistSelectedEventArgs
        {
            public int PlayListIndex { get; }
            public string PlaylistName { get; } 
            public string PlaylistsLocation { get; }
            public enMode Mode;

            public PlaylistSelectedEventArgs(int PlaylistIndex, string PlaylistName)
            {
                this.PlayListIndex = PlaylistIndex;
                this.PlaylistName = PlaylistName;
                this.PlaylistsLocation = Path.Combine(Directory.GetCurrentDirectory(), "Playlist");
            }
        }
        public delegate void SelectedPlaylist(object sender, PlaylistSelectedEventArgs e);

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public event SelectedPlaylist OnSelectedPlaylist;

        public class MusicSelectedEventArgs
        {
            public string MusicName { get; }
            public int MusicIndex { get; }
            public string MusicPath { get; }
            public NAudio.Wave.AudioFileReader CurMusic { get; set; }

            public MusicSelectedEventArgs(string MusicName, int MusicIndex)
            {
                this.MusicName = MusicName;
                this.MusicIndex = MusicIndex;
                
                try
                {
                    this.MusicPath = Directory.GetFiles(PlayListsFolder, $"{MusicName}.mp3", SearchOption.AllDirectories)[0];
                }
                catch { this.MusicPath = ""; }
                try
                {
                    CurMusic = new NAudio.Wave.AudioFileReader(MusicPath);
                }
                catch { CurMusic = null; }
            }
        }
        public delegate void SelectedMusic(object sender, MusicSelectedEventArgs e);
        
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public event SelectedMusic OnSelectedMusic;




        public class AddMusicEventArgs : EventArgs
        {
            public int PlayListIndex { get; }
            public string PlaylistName { get; }
            public string PlaylistsLocation { get; }
            

            public AddMusicEventArgs(int PlaylistIndex, string PlaylistName)
            {
                this.PlayListIndex = PlaylistIndex;
                this.PlaylistName = PlaylistName;
                this.PlaylistsLocation = Path.Combine(Directory.GetCurrentDirectory(), "Playlist");
            }
        }
        public delegate void AddMusicEvent(object sender, AddMusicEventArgs e);

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public event AddMusicEvent OnAddMusicEvent;





        //----------------------------------------------------

        public int CurMusicIndex
        {
            get
            {
                if (PlayLists.SelectedIndices.Count > 0)
                    return PlayLists.SelectedIndices[0];
                else return -1;
            }
            set 
            {
                PlayLists.SelectedIndices.Clear();
                PlayLists.SelectedIndices.Add(value); 
            }
        }

        public int CountOfMusicInSelectedPlaylist
        {
            get { return PlayLists.Items.Count; }
        }


        private static string PlayListsFolder = @"C:\Users\amrs5\OneDrive\Desktop\Music Player Project\Music Player Project\bin\Debug\PlayList";
        public enum enMode { PlaylistMode = 0, MusicMode = 1}
        enMode Mode = enMode.PlaylistMode;

        public ctrMusicPlaylist()
        {
            InitializeComponent();
        }

        public bool CreatePlaylist(string PlaylistName)
        {
            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), PlaylistName);
            if (!Util.CreateFolderIfNotExist(FolderPath))
                return false;
            else return true;
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            string PlaylistPath = Path.Combine(ctrMusicPlaylist.PlayListsFolder, txtPlaylistName.Text.Trim());
            
            if (string.IsNullOrEmpty(txtPlaylistName.Text.Trim()))
            {
                MessageBox.Show("Enter a Vlaid Playlist Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Directory.Exists(PlaylistPath.Trim()))
            {
                MessageBox.Show("Playlist is Already Exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (Util.CreateFolderIfNotExist(PlaylistPath))
            {
                MessageBox.Show($"Playlist : {txtPlaylistName.Text} Added Succesfully", "Sucessful Process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PlayLists.Items.Add(txtPlaylistName.Text);
                txtPlaylistName.Clear();
            }
            else MessageBox.Show("Error When Adding Playlist to Files", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void GetAllPlayList()// this function fill list view with playlist file
        {
            PlayLists.Items.Clear();
            try
            {
                foreach (string Folder in Directory.GetDirectories(ctrMusicPlaylist.PlayListsFolder))
                {
                    PlayLists.Items.Add(Path.GetFileNameWithoutExtension(Folder));
                }
            }
            catch(Exception e) { MessageBox.Show(e.Message); }
        }
        private bool FailPlaylistWithMusic(string PlaylistName)// fill list view with music that exist in playlist when select playlist
        {
            if (string.IsNullOrEmpty(PlaylistName)) return false;
            PlayLists.Items.Clear();
            string PlaylistPath = Path.Combine(@ctrMusicPlaylist.PlayListsFolder, PlaylistName);
            try
            {
                foreach (string File in Directory.GetFiles(PlaylistPath))
                {
                    PlayLists.Items.Add(Path.GetFileNameWithoutExtension(File));
                }
                return true;
            }
            catch { return false; }
            

        }

        private void ctrMusicPlaylist_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.PlaylistMode)
            {
                GetAllPlayList();
            }
        }

        MouseButtons LastButtonPressed;

        private void PlayLists_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (LastButtonPressed == MouseButtons.Right)
            {
                Point clickPoint = PlayLists.PointToClient(MousePosition);
                cmsPlaylistProperty.Show(PlayLists, clickPoint);
                return;
            }
            if (PlayLists.SelectedItems.Count == 0)
            {
                return;
            }

            if (Mode == enMode.PlaylistMode)
            {
                if (FailPlaylistWithMusic(PlayLists.SelectedItems[0].Text))
                {
                    btnBack.Enabled = true;
                    if (OnSelectedPlaylist != null)
                        OnSelectedPlaylist(this, new PlaylistSelectedEventArgs(PlayLists.SelectedIndices[0], PlayLists.SelectedItems[0].Text));

                }
                pnlCreatePlaylistSection.Visible = false;
                PlayLists.SelectedIndices.Clear();
                PlayLists.SelectedItems.Clear();
                Mode = enMode.MusicMode;// change current mode to MusicMode
            }
            else
            {
                if (OnSelectedMusic != null)
                    OnSelectedMusic(this, new MusicSelectedEventArgs(PlayLists.SelectedItems[0].Text, PlayLists.SelectedIndices[0]));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GetAllPlayList();
            Mode = enMode.PlaylistMode;
            pnlCreatePlaylistSection.Visible = true;
            btnBack.Enabled = false;
        }

        private void PlayLists_MouseUp(object sender, MouseEventArgs e)
        {
            LastButtonPressed = e.Button;
        }

        private void PlayLists_MouseDown(object sender, MouseEventArgs e)
        {
            LastButtonPressed = e.Button;
        }

        private bool DeletePlaylist(string PlaylistName)
        {
            try
            {
                string PlaylistPath = Path.Combine(ctrMusicPlaylist.PlayListsFolder, PlaylistName);
                Directory.Delete(PlaylistPath, true);
                return true;
            }
            catch { return false; }
            
        }
        private void deletePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string PlaylistName;
            if (PlayLists.SelectedItems.Count > 0 && e != null)
            {
                PlaylistName = PlayLists.SelectedItems[PlayLists.SelectedItems.Count - 1].Text;
            }
            else return;

            if (MessageBox.Show($"Are You Sure you want delete Playlist {PlaylistName}", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeletePlaylist(PlaylistName);
                GetAllPlayList();
                PlayLists.SelectedItems.Clear();
                PlayLists.SelectedIndices.Clear();

            }
        }

        private void txtPlaylistName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                btnCreatePlaylist.PerformClick();
        }

        private void PlayLists_Resize(object sender, EventArgs e)
        {
            btnBack.Location = new Point(PlayLists.Top + PlayLists.Width - btnBack.Width);
        }

        private void addMusicToPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnAddMusicEvent != null)
                OnAddMusicEvent?.Invoke(this, new AddMusicEventArgs(PlayLists.SelectedIndices[0], PlayLists.SelectedItems[0].Text));
        }
    }
}
