namespace Electric_savings
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void months_SelectedIndexChanged(object sender, EventArgs e)
        {
            display.Visible = true;
        }

        private void display_Click(object sender, EventArgs e)
        {
            String file = "C:\\Users\\space\\Downloads\\savings.txt\"";
            String[] monthData = new String[24];
            if (System.IO.File.Exists(file))
            {
                StreamReader fileReader = new System.IO.StreamReader(file);
                String textline;
                int counter = 0;
                while (fileReader.Peek() != -1)
                {
                    textline = fileReader.ReadLine();
                    monthData[counter] = textline;
                    counter++;
                }
            }
            String month = months.Text;
            double savings = 0;
            for(int i = 0; i < monthData.Length; i++)
            {
                if (monthData[i].Equals(month))
                {
                    Double.TryParse(monthData[i + 1], out savings);
                }
            }
            results.Text = "The elctric savings for " + month + " is " + savings;
            results.Visible = true;
        }
    }
}
