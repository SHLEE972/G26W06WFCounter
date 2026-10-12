namespace G26W06WFCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int count = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnAdd(object sender, EventArgs e)
        {
            count++;
            labelCount.Text =$"{count}"; 
        }
    }
}
