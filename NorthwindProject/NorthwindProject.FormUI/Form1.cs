using Northwind.Service;

namespace NorthwindProject.FormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunService service = new UrunService();
            dataGridView1.DataSource = service.Listele();
        }
    }
}