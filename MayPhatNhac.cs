using System.Media;
namespace Songs
{
    public partial class MayPhatNhac : Form
    {
        List<Song> songs = new List<Song>();

        string imagePath = "data\\picture\\7 Years.png";
        string mp3Path = "data\\wav\\7 Years.wav";
        private SoundPlayer soundPlayer;
        public MayPhatNhac()
        {
            InitializeComponent();
        }

        private void MayPhatNhac_Load(object sender, EventArgs e)
        {
            try
            {
                pbx_imageSong.Image = Image.FromFile($"data\\picture\\7 Years.png");
                soundPlayer = new SoundPlayer("data\\wav\\7 Years.wav");
                Song song1 = new Song();
                song1.name = "7 Years";
                songs.Add( song1 );
                Song song2 = new Song();
                song2.name = "Muon noi voi em";
                songs.Add(song2);
                gv_listNhac.DataSource = songs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_startAndPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_startAndPause.Text == "Start")
                {
                    btn_startAndPause.Text = "Pause";
                    soundPlayer.Play();
                }
                else
                {
                    btn_startAndPause.Text = "Start";
                    soundPlayer.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_listNhac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                DataGridViewRow row = gv_listNhac.Rows[e.RowIndex];
                pbx_imageSong.Image = Image.FromFile($"data\\picture\\{row.Cells[0].Value.ToString()}.png");
                soundPlayer = new SoundPlayer($"data\\wav\\{row.Cells[0].Value.ToString()}.wav");
            }
            catch(Exception ex)
            {

            }
        }
    }
}