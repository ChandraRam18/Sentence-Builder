namespace Sentence_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {
            
        }

        //Clears the output for the user without having to close and reopen the program to type a 
        //new sentence or add a new word
        private void clearButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }
        
        //this let's the user close the program by clicking the "Exit" Button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1A_Click(object sender, EventArgs e)
        {
            string output;
            output = Label1A.Text;
            outputLabel.Text += output;
        }

        private void Label2a_Click(object sender, EventArgs e)
        {
            string output;
            output = Label2a.Text;
            outputLabel.Text += output;
        }

        private void Label3An_Click(object sender, EventArgs e)
        {
            string output;
            output = Label3An.Text;
            outputLabel.Text += output;
        }

        private void Label4The_Click(object sender, EventArgs e)
        {
            string output;
            output = Label4The.Text;
            outputLabel.Text += output;
        }

        private void Label5the_Click(object sender, EventArgs e)
        {
            string output;
            output = Label5the.Text;
            outputLabel.Text += output;
        }

        private void Label6man_Click(object sender, EventArgs e)
        {
            string output;
            output = Label6man.Text;
            outputLabel.Text += output;
        }

        private void Label7woman_Click(object sender, EventArgs e)
        {
            string output;
            output = Label7woman.Text;
            outputLabel.Text += output;
        }

        private void Label8dog_Click(object sender, EventArgs e)
        {
            string output;
            output = Label8dog.Text;
            outputLabel.Text += output;
        }

        private void Label9cat_Click(object sender, EventArgs e)
        {
            string output;
            output = Label9cat.Text;
            outputLabel.Text += output;
        }

        private void Label10car_Click(object sender, EventArgs e)
        {
            string output;
            output = Label10car.Text;
            outputLabel.Text += output;
        }

        private void Label11bicycle_Click(object sender, EventArgs e)
        {
            string output;
            output = Label11bicycle.Text;
            outputLabel.Text += output;
        }

        private void Label12beautiful_Click(object sender, EventArgs e)
        {
            string output;
            output = Label12beautiful.Text;
            outputLabel.Text += output;
        }

        private void Label13big_Click(object sender, EventArgs e)
        {
            string output;
            output = Label13big.Text;
            outputLabel.Text += output;
        }

        private void Label14small_Click(object sender, EventArgs e)
        {
            string output;
            output = Label14small.Text;
            outputLabel.Text += output;
        }

        private void Label15strange_Click(object sender, EventArgs e)
        {
            string output;
            output = Label15strange.Text;
            outputLabel.Text += output;
        }

        private void Label16lookedat_Click(object sender, EventArgs e)
        {
            string output;
            output = Label16lookedat.Text;
            outputLabel.Text += output;
        }

        private void Label17rode_Click(object sender, EventArgs e)
        {
            string output;
            output = Label17rode.Text;
            outputLabel.Text += output;
        }

        private void Label18spoketo_Click(object sender, EventArgs e)
        {
            string output;
            output = Label18spoketo.Text;
            outputLabel.Text += output;
        }

        private void Label19laughedat_Click(object sender, EventArgs e)
        {
            string output;
            output = Label19laughedat.Text;
            outputLabel.Text += output;
        }

        private void Label20drove_Click(object sender, EventArgs e)
        {
            string output;
            output = Label20drove.Text;
            outputLabel.Text += output;
        }

        private void Label21Space_Click(object sender, EventArgs e)
        {
            string output;
            output = Label21Space.Text = " ";
            outputLabel.Text += output;
        }

        private void Label22fullstop_Click(object sender, EventArgs e)
        {
            string output;
            output = Label22fullstop.Text;
            outputLabel.Text += output;
        }

        private void Label23exclamation_Click(object sender, EventArgs e)
        {
            string output;
            output = Label23exclamation.Text;
            outputLabel.Text += output;
        }

        private void Label24saw_Click(object sender, EventArgs e)
        {
            string output;
            output = Label24saw.Text;
            outputLabel.Text += output;
        }

        private void Label25to_Click(object sender, EventArgs e)
        {
            string output;
            output = Label25to.Text;
            outputLabel.Text += output;
        }
    }
}