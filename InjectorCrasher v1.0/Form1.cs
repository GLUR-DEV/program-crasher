namespace InjectorCrasher_v2._1
{
    public partial class InjectorCrasher : Form
    {
        public InjectorCrasher()
        {
            InitializeComponent();
        }

        private void InjectorCrasher_Load(object sender, EventArgs e)
        {
            injector1.Show();
            support1.Hide();
        }

        private void InjectorButton_Click(object sender, EventArgs e)
        {
            injector1.Show();
            support1.Hide();
        }

        private void SupportButton_Click(object sender, EventArgs e)
        {
            injector1.Hide();
            support1.Show();
        }

        private void injector1_Load(object sender, EventArgs e)
        {

        }
    }
}