namespace G26W06WFCounter
{
    public partial class Form1 : Form {
        private
            int count = 0;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void OnAdd(object sender, EventArgs e) {
            labelCount.Text = $"{++count}";
            //labelCount.Text = (++count).ToString();
            //labelCount.Text = "" + ++count;
        }

        private void OnDown(object sender, EventArgs e) {
            labelCount.Text = $"{--count}";
        }

        private void OnRemove(object sender, EventArgs e) {
            labelCount.Text = $"{count = 0}";
        }
    }
}

