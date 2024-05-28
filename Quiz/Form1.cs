using System;
using System.Media;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Quiz
{
    public partial class Form2 : Form
    {
        String QuizFilename { get; set; }
        String MusicFilename { get; set; }
        StreamReader sr { get; set; }
        int CorrectAnswer { get; set; }
        RadioButton[] answers;

        public Form2(String[] args)
        {
            InitializeComponent();
            if (InitializeFiles(args))
            {
                CorrectAnswer = LoadQuestion();
                answers = new RadioButton[] { null, Ans1, Ans2, Ans3, Ans4, Ans5 };
            }

        }

        private Boolean InitializeFiles(String[] args)
        {
            bool aok = true;
            if (args.Length > 0)
            {
                QuizFilename = args[0];
                try
                {
                    sr = new StreamReader(QuizFilename);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    aok = false;
                }
            }
            else
                aok = false;
            if (args.Length > 1)
                MusicFilename = args[1];
            return aok;
        }

        private int LoadQuestion()
        {
            int retVal = 0;
            try
            {
                lblQuestion.Text = sr.ReadLine();
                if (lblQuestion.Text.Length > 1)
                {
                    Ans1.Text = sr.ReadLine();
                    Ans2.Text = sr.ReadLine();
                    Ans3.Text = sr.ReadLine();
                    Ans4.Text = sr.ReadLine();
                    Ans5.Text = sr.ReadLine();
                    String strCA = sr.ReadLine();
                    Int16 intCA = 0;
                    if (!Int16.TryParse(strCA, out intCA))
                    {
                        Thread.Sleep(5000);
                        MessageBox.Show("We do not know what the correct answer is");
                    }
                  //  SoundPlayer simpleSound = new SoundPlayer(MusicFilename);
                  //  simpleSound.Play();
                    retVal = intCA;
                }
                else
                {
                    GameOver();
                }
            }
            catch 
            {
                GameOver();
            }
            return retVal;
        }

        private void cbSubmit_Click(object sender, EventArgs e)
        {
            Int16 points = 0;
            if (answers[CorrectAnswer].Checked)
            {
                lblResponse.Text = ":-)";
                String strPoints = lblPoints.Text;
                if (Int16.TryParse(strPoints, out points))
                {
                    ++points;
                    lblPoints.Text = points.ToString();
                }
            }
            else
            {
                lblResponse.Text = ":-(";
                MessageBox.Show("The correct answer is " + CorrectAnswer);
            }
         //   cbSubmit.Enabled = false;
        }

        private void cbNext_Click(object sender, EventArgs e)
        {
            Int16 points = 0;
            if (answers[CorrectAnswer].Checked)
            {
                lblResponse.Text = ":-)";
                String strPoints = lblPoints.Text;
                if (Int16.TryParse(strPoints, out points))
                {
                    ++points;
                    lblPoints.Text = points.ToString();
                }
                


            }
            else
            {
                lblResponse.Text = ":-(";
                MessageBox.Show("The correct answer is " + CorrectAnswer);
            }
     
            CorrectAnswer = LoadQuestion();
        
            if (CorrectAnswer == 0)
            { 
                GameOver();
            }
        }
        private void GameOver()
        {
            cbNext.Enabled = false;
            MessageBox.Show("Game over\n your score is " + lblPoints.Text + " points");
            this.Close();

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void Ans2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ans1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}   
