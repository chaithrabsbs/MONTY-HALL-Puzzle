
using MHP.Classes;
using MHP.Interfaces;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MHP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Switch door", "Caption", MessageBoxButtons.YesNo);

            textBox2.Text = "";//for displaying result
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            int NoOfSimulations = int.Parse(textBox1.Text);
            ArrayList result = new ArrayList(); //declaring array to store the result


            IGame game = new Game(NoOfSimulations);
            var player = new Player(game);


            if (dialogResult == DialogResult.Yes)
            {
                result = player.AutoPlay(shouldChangeChoice: true);

                textBox2.Text = result[0].ToString();
                textBox3.Text = result[1].ToString();
                textBox4.Text = result[2].ToString();
                textBox5.Text = result[3].ToString();


                game.ResetGame();


            }
            else if (dialogResult == DialogResult.No)
            {
                result = player.AutoPlay(shouldChangeChoice: false);

                textBox2.Text = result[0].ToString();
                textBox3.Text = result[1].ToString();
                textBox4.Text = result[2].ToString();
                textBox5.Text = result[3].ToString();


                game.ResetGame();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}