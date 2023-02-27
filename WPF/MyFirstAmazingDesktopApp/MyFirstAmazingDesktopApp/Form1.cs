
namespace MyFirstAmazingDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"{e.X} {e.Y}");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var rnd = new Random();
            if (e.Button == MouseButtons.Left)
                this.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            else if (e.Button == MouseButtons.Right)
                BackColor = Color.DeepPink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////lbl.Text = "Button has been clicked";
            //var label = new Label
            //{
            //    Location = new Point(200, 200),
            //    Text = "new label",
            //    Font = new Font("Comic Sans Ms", 50, FontStyle.Bold | FontStyle.Italic),
            //    AutoSize = true
            //};
            //Controls.Remove(lbl);
            //Controls.Add(label);

            //var input = txtbox_name.Text;
            //lbl.Text = input;
            lbl.Text = txtbox_name.Text;

        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.HotPink;
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.DeepSkyBlue;
        }

        private void btn_mbox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("message");
            //MessageBox.Show("message", "caption");
            //MessageBox.Show("Are you Ok?", "caption", MessageBoxButtons.YesNoCancel);
            DialogResult dr = MessageBox.Show("Are you Ok?", "caption", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (dr == DialogResult.Yes)
                lbl.Text = "Yes";
            else if(dr == DialogResult.No)
                lbl.Text = "No"; 
            else if(dr == DialogResult.Cancel)
                lbl.Text = "Cancel";
                
        }
    }
}