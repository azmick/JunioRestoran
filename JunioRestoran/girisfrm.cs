namespace JunioRestoran
{
    public partial class girisfrm : Form
    {
        public girisfrm()
        {
            InitializeComponent();
        }

        cGenel gnl = new cGenel();
        private void girisfrm_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetbyInformation(kullanicicb);
        }

        private void kullanicilbl_Click(object sender, EventArgs e)
        {

        }

        private void sifrelbl_Click(object sender, EventArgs e)
        {

        }

        private void girisbtn_Click(Object sender, EventArgs e) {
            cPersoneller p = new cPersoneller();
            bool result = p.personelEntryControl(sifretxt.Text, gnl._personelId);
            if (result)
            {
                this.Hide();//dogruysa bu formu gizle ve diger foruma gec
                menufrmcs menu = new menufrmcs();
                menu.Show();
            }
        }
    }
}