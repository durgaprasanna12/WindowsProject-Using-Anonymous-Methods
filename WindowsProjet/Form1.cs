namespace WindowsProjet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b= new Button();
            b.Text = "Click me";
            b.Size = new Size(100, 50);
            b.Location = new Point(100, 100); 
            this.Controls.Add(b);
            b.Click += ( sender, e) =>
            {
                MessageBox.Show("Button clicked!");
            };
        }
       
    }
}
