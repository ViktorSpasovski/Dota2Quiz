using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dota2_Quiz.Properties;

namespace Dota2_Quiz
{
    public partial class Game : Form
    {
        int selected;
        int multi = 1;
        int guess = 3;
        int score = 0;
        
        List<Question> questions = new List<Question>();
        
        Question q1 = new Question("Hand of Midas", new string[] { "branch", "gauntlet", "midas" }, "midas");
        Question q2 = new Question("Mask of Madness", new string[] { "madness", "dominator", "defiance" }, "madness");
        Question q3 = new Question("Ultimate Orb", new string[] { "linken", "ultimate", "energy" }, "ultimate");
        Question q4 = new Question("Crystalys", new string[] { "mjollnir", "raindrop", "crystalys" }, "crystalys");
        Question q5 = new Question("Phase Boots", new string[] { "phase", "boots", "travel" }, "phase");
        Question q6 = new Question("Glimmer Cape", new string[] { "glimmer", "veil", "cloak" }, "glimmer");
        Question q7 = new Question("Stout Shield", new string[] { "buckler", "vanguard", "stout" }, "stout");
        Question q8 = new Question("Echo Sabre", new string[] { "sabre", "demonedge", "halberd" }, "sabre");
        Question q9 = new Question("Clarity", new string[] { "smoke", "clarity", "raindrop" }, "clarity");
        Question q10 = new Question("Bloodthorn", new string[] { "blight", "bloodthorn", "orchid" }, "bloodthorn");
        Question q11 = new Question("Diffusal blade", new string[] { "sabre", "diffusal", "shadow" }, "diffusal");
        Question q12 = new Question("Orb of Venom", new string[] { "blight", "refresher", "venom" }, "venom");
        Question q13 = new Question("Ring of Health", new string[] { "aquila", "regen", "health" }, "health");
        Question q14 = new Question("Oblivion Staff", new string[] { "atos", "orchid", "oblivion" }, "oblivion");
        Question q15 = new Question("Pipe of Insight", new string[] { "pipe", "quarterstaff", "dragonlance" }, "pipe");
        Question q16 = new Question("Skull Basher", new string[] { "bkb", "morbidmask", "skullbasher" }, "skullbasher");
        Question q17 = new Question("Vladimir's Offering", new string[] { "urn", "vladimirs", "hex" }, "vladimirs");
        Question q18 = new Question("Iron Talon", new string[] { "talon", "oblivion", "helm" }, "talon");
        Question q19 = new Question("Morbid Mask", new string[] { "morbidmask", "vladimirs", "madness" }, "morbidmask");
        Question q20 = new Question("Heaven's Halberd", new string[] { "diffusal", "crystalys", "halberd" }, "halberd");

        public Game()
        {
            InitializeComponent();

            aboutText.Parent = aboutBackground;
            aboutText.BackColor = Color.Transparent;
            aboutText.Text = "Dota 2 Quiz is a game that tests your item knowledge through a series of interactive questions.\n\n\n\n\n\n- - - - - - - - - - - - - - - - - How to play: - - - - - - - - - - - - - - - - -\n1. Click 'new game'\n2. Select the corresponding picture of the item to the name given above the pictures.\n3. The more correct answers in a row, the bigger the point multiplier.\n4. Score as many points as you can.\n\n\n\n\n\n\nCreated and developed by Viktor Spasovski";
            aboutText.Location = new Point(20, 20);
            playersHighscores.Parent = highscoresBackground;
            playersHighscores.BackColor = Color.Transparent;
            playersHighscores.Location = new Point(20, 20);
            addHighscores();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelHighscores.Visible = false;
            panelAbout.Visible = true;
            panelGame.Visible = false;
            panelGameOver.Visible = false;
        }

        private void buttonHighScores_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelHighscores.Visible = true;
            panelAbout.Visible = false;
            panelGame.Visible = false;
            panelGameOver.Visible = false;
            addHighscores();
        }

        private void highscoresClose_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelHighscores.Visible = false;
            panelAbout.Visible = false;
            panelGame.Visible = false;
            panelGameOver.Visible = false;
        }

        private void aboutClose_Click_1(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelHighscores.Visible = false;
            panelAbout.Visible = false;
            panelGame.Visible = false;
            panelGameOver.Visible = false;
        }

        private void buttonCloseGame_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Would you really like to quit this game?", "Quit?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                panelMain.Visible = true;
                panelHighscores.Visible = false;
                panelAbout.Visible = false;
                panelGame.Visible = false;
                panelGameOver.Visible = false;
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelHighscores.Visible = false;
            panelAbout.Visible = false;
            panelGame.Visible = true;
            panelGameOver.Visible = false;
            guess = 3;
            score = 0;
            multi = 1;
            scoreGame.Text = "Score: " + score.ToString();

            newQuestion();
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (questions[selected].getAnswer1() == questions[selected].answer)
            {
                score = score + multi;
                multi++;
                newQuestion();
            }
            else
            {
                guess--;
                multi = 1;
                newQuestion();
            }
            multiplier.Text = multi.ToString() + "x";
            guesses.Text = guess.ToString();

            scoreGame.Text = "Score: " + score.ToString();
            scoreGame.Left = (scoreGame.Parent.Width - scoreGame.Width) / 2;

            if (guess == 0)
            {
                panelGameOver.Visible = true;
                panelGame.Visible = false;
                scoreText.Text = "Score: " + score.ToString();
                scoreText.Left = (scoreText.Parent.Width - scoreText.Width) / 2;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (questions[selected].getAnswer2() == questions[selected].answer)
            {
                score = score + multi;
                multi++;
                newQuestion();
            }
            else
            {
                guess--;
                multi = 1;
                newQuestion();
            }
            multiplier.Text = multi.ToString() + "x";
            guesses.Text = guess.ToString();
            
            scoreGame.Text = "Score: " + score.ToString();
            scoreGame.Left = (scoreGame.Parent.Width - scoreGame.Width) / 2;

            if (guess == 0)
            {
                panelGameOver.Visible = true;
                panelGame.Visible = false;
                scoreText.Text = "Score: " + score.ToString();
                scoreText.Left = (scoreText.Parent.Width - scoreText.Width) / 2;
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (questions[selected].getAnswer3() == questions[selected].answer)
            {
                score = score + multi;
                multi++;
                newQuestion();
            }
            else
            {
                guess--;
                multi = 1;
                newQuestion();
            }
            multiplier.Text = multi.ToString() + "x";
            guesses.Text = guess.ToString();
            
            scoreGame.Text = "Score: " + score.ToString();
            scoreGame.Left = (scoreGame.Parent.Width - scoreGame.Width) / 2;

            if (guess == 0)
            {
                panelGameOver.Visible = true;
                panelGame.Visible = false;
                scoreText.Text = "Score: " + score.ToString();
                scoreText.Left = (scoreText.Parent.Width - scoreText.Width) / 2;
            }
        }

        public void newQuestion()
        {
            questions.Add(q1);
            questions.Add(q2);
            questions.Add(q3);
            questions.Add(q4);
            questions.Add(q5);
            questions.Add(q6);
            questions.Add(q7);
            questions.Add(q8);
            questions.Add(q9);
            questions.Add(q10);
            questions.Add(q11);
            questions.Add(q12);
            questions.Add(q13);
            questions.Add(q14);
            questions.Add(q15);
            questions.Add(q16);
            questions.Add(q17);
            questions.Add(q18);
            questions.Add(q19);
            questions.Add(q20);

            Random random = new Random();
            int r = random.Next(questions.Count);
            selected = r;
            question.Text = questions[r].ToString();
            question.Left = (question.Parent.Width - question.Width) / 2;
            object ob1 = Resources.ResourceManager.GetObject(questions[r].getAnswer1());
            one.Image = (Image)ob1;
            object ob2 = Resources.ResourceManager.GetObject(questions[r].getAnswer2());
            two.Image = (Image)ob2;
            object ob3 = Resources.ResourceManager.GetObject(questions[r].getAnswer3());
            three.Image = (Image)ob3;
        }

        private void gameOverClose_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelHighscores.Visible = false;
            panelAbout.Visible = false;
            panelGame.Visible = false;
            panelGameOver.Visible = false;
        }

        private void saveHighscore_Click(object sender, EventArgs e)
        {
            string nameScore = textName.Text + "," + score.ToString() + Environment.NewLine;
            File.AppendAllText("highscores.txt", nameScore);

            addHighscores();
            panelMain.Visible = false;
            panelHighscores.Visible = true;
            panelAbout.Visible = false;
            panelGame.Visible = false;
            panelGameOver.Visible = false;
        }

        private void addHighscores()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            playersHighscores.Text = "";

            if (File.Exists("highscores.txt"))
            {
                string[] scores = File.ReadAllLines("highscores.txt");
                for (int i = 0; i < scores.Length; i++)
                {
                    string[] parts = scores[i].Split(',');
                    //playersHighscores.Text = playersHighscores.Text + (i + 1) + ". " + parts[0] + " - " + parts[1] + "\n"; 
                    dict.Add(parts[0], Convert.ToInt32(parts[1]));
                }
                var sortedDict = from entry in dict orderby entry.Value descending select entry;
                sortedDict.ToDictionary(pair => pair.Key, pair => pair.Value);

                int j = 1;
                foreach (KeyValuePair<string, int> entry in sortedDict)
                {
                    playersHighscores.Text = playersHighscores.Text + j + ". " + entry.Key + " - " + entry.Value + "\n";
                    j++;
                }
            }
            else
            {
                File.Create("highscores.txt").Close();
                File.WriteAllText("highscores.txt", "Viktor,999\n");
            }
            
        }
    }
}
