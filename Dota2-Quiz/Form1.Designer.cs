namespace Dota2_Quiz
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonHighScores = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.aboutText = new System.Windows.Forms.Label();
            this.aboutBackground = new System.Windows.Forms.PictureBox();
            this.aboutClose = new System.Windows.Forms.Button();
            this.headerAbout = new System.Windows.Forms.PictureBox();
            this.panelHighscores = new System.Windows.Forms.Panel();
            this.playersHighscores = new System.Windows.Forms.Label();
            this.highscoresBackground = new System.Windows.Forms.PictureBox();
            this.highscoresClose = new System.Windows.Forms.Button();
            this.headerHighscores = new System.Windows.Forms.PictureBox();
            this.panelGame = new System.Windows.Forms.Panel();
            this.scoreGame = new System.Windows.Forms.Label();
            this.three = new System.Windows.Forms.PictureBox();
            this.two = new System.Windows.Forms.PictureBox();
            this.one = new System.Windows.Forms.PictureBox();
            this.question = new System.Windows.Forms.Label();
            this.guesses = new System.Windows.Forms.Label();
            this.multiplier = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headerGame = new System.Windows.Forms.Label();
            this.buttonCloseGame = new System.Windows.Forms.Button();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.saveHighscore = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gameOverClose = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerAbout)).BeginInit();
            this.panelHighscores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highscoresBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerHighscores)).BeginInit();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.three)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.one)).BeginInit();
            this.panelGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.buttonAbout);
            this.panelMain.Controls.Add(this.buttonHighScores);
            this.panelMain.Controls.Add(this.buttonNewGame);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(584, 361);
            this.panelMain.TabIndex = 0;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.BackgroundImage = global::Dota2_Quiz.Properties.Resources.dota_about;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Location = new System.Drawing.Point(201, 281);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(182, 42);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonHighScores
            // 
            this.buttonHighScores.BackColor = System.Drawing.Color.Transparent;
            this.buttonHighScores.BackgroundImage = global::Dota2_Quiz.Properties.Resources.dota_highscores;
            this.buttonHighScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHighScores.Location = new System.Drawing.Point(201, 219);
            this.buttonHighScores.Name = "buttonHighScores";
            this.buttonHighScores.Size = new System.Drawing.Size(182, 42);
            this.buttonHighScores.TabIndex = 3;
            this.buttonHighScores.UseVisualStyleBackColor = false;
            this.buttonHighScores.Click += new System.EventHandler(this.buttonHighScores_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.BackgroundImage = global::Dota2_Quiz.Properties.Resources.dota_new_game;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Location = new System.Drawing.Point(201, 157);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(182, 42);
            this.buttonNewGame.TabIndex = 4;
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.Transparent;
            this.panelAbout.Controls.Add(this.aboutText);
            this.panelAbout.Controls.Add(this.aboutBackground);
            this.panelAbout.Controls.Add(this.aboutClose);
            this.panelAbout.Controls.Add(this.headerAbout);
            this.panelAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAbout.Location = new System.Drawing.Point(0, 0);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(584, 361);
            this.panelAbout.TabIndex = 6;
            // 
            // aboutText
            // 
            this.aboutText.ForeColor = System.Drawing.Color.White;
            this.aboutText.Location = new System.Drawing.Point(27, 94);
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(530, 241);
            this.aboutText.TabIndex = 3;
            this.aboutText.Text = "label1";
            this.aboutText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aboutBackground
            // 
            this.aboutBackground.Image = global::Dota2_Quiz.Properties.Resources.background;
            this.aboutBackground.Location = new System.Drawing.Point(12, 79);
            this.aboutBackground.Name = "aboutBackground";
            this.aboutBackground.Size = new System.Drawing.Size(560, 270);
            this.aboutBackground.TabIndex = 2;
            this.aboutBackground.TabStop = false;
            // 
            // aboutClose
            // 
            this.aboutClose.BackgroundImage = global::Dota2_Quiz.Properties.Resources.dota_close;
            this.aboutClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutClose.Location = new System.Drawing.Point(510, 12);
            this.aboutClose.Name = "aboutClose";
            this.aboutClose.Size = new System.Drawing.Size(62, 42);
            this.aboutClose.TabIndex = 1;
            this.aboutClose.UseVisualStyleBackColor = false;
            this.aboutClose.Click += new System.EventHandler(this.aboutClose_Click_1);
            // 
            // headerAbout
            // 
            this.headerAbout.BackgroundImage = global::Dota2_Quiz.Properties.Resources.dota_about;
            this.headerAbout.Location = new System.Drawing.Point(13, 13);
            this.headerAbout.Name = "headerAbout";
            this.headerAbout.Size = new System.Drawing.Size(180, 40);
            this.headerAbout.TabIndex = 0;
            this.headerAbout.TabStop = false;
            // 
            // panelHighscores
            // 
            this.panelHighscores.BackColor = System.Drawing.Color.Transparent;
            this.panelHighscores.Controls.Add(this.playersHighscores);
            this.panelHighscores.Controls.Add(this.highscoresBackground);
            this.panelHighscores.Controls.Add(this.highscoresClose);
            this.panelHighscores.Controls.Add(this.headerHighscores);
            this.panelHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHighscores.Location = new System.Drawing.Point(0, 0);
            this.panelHighscores.Name = "panelHighscores";
            this.panelHighscores.Size = new System.Drawing.Size(584, 361);
            this.panelHighscores.TabIndex = 7;
            // 
            // playersHighscores
            // 
            this.playersHighscores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersHighscores.ForeColor = System.Drawing.Color.White;
            this.playersHighscores.Location = new System.Drawing.Point(27, 94);
            this.playersHighscores.Name = "playersHighscores";
            this.playersHighscores.Size = new System.Drawing.Size(530, 240);
            this.playersHighscores.TabIndex = 4;
            this.playersHighscores.Text = "1.";
            // 
            // highscoresBackground
            // 
            this.highscoresBackground.Image = global::Dota2_Quiz.Properties.Resources.background;
            this.highscoresBackground.Location = new System.Drawing.Point(13, 79);
            this.highscoresBackground.Name = "highscoresBackground";
            this.highscoresBackground.Size = new System.Drawing.Size(560, 270);
            this.highscoresBackground.TabIndex = 3;
            this.highscoresBackground.TabStop = false;
            // 
            // highscoresClose
            // 
            this.highscoresClose.BackgroundImage = global::Dota2_Quiz.Properties.Resources.dota_close;
            this.highscoresClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highscoresClose.Location = new System.Drawing.Point(510, 13);
            this.highscoresClose.Name = "highscoresClose";
            this.highscoresClose.Size = new System.Drawing.Size(62, 42);
            this.highscoresClose.TabIndex = 1;
            this.highscoresClose.UseVisualStyleBackColor = false;
            this.highscoresClose.Click += new System.EventHandler(this.highscoresClose_Click);
            // 
            // headerHighscores
            // 
            this.headerHighscores.BackgroundImage = global::Dota2_Quiz.Properties.Resources.dota_highscores;
            this.headerHighscores.Location = new System.Drawing.Point(13, 13);
            this.headerHighscores.Name = "headerHighscores";
            this.headerHighscores.Size = new System.Drawing.Size(180, 40);
            this.headerHighscores.TabIndex = 0;
            this.headerHighscores.TabStop = false;
            // 
            // panelGame
            // 
            this.panelGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGame.BackColor = System.Drawing.Color.Transparent;
            this.panelGame.BackgroundImage = global::Dota2_Quiz.Properties.Resources.game_background;
            this.panelGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGame.Controls.Add(this.scoreGame);
            this.panelGame.Controls.Add(this.three);
            this.panelGame.Controls.Add(this.two);
            this.panelGame.Controls.Add(this.one);
            this.panelGame.Controls.Add(this.question);
            this.panelGame.Controls.Add(this.guesses);
            this.panelGame.Controls.Add(this.multiplier);
            this.panelGame.Controls.Add(this.label2);
            this.panelGame.Controls.Add(this.label1);
            this.panelGame.Controls.Add(this.headerGame);
            this.panelGame.Controls.Add(this.buttonCloseGame);
            this.panelGame.Font = new System.Drawing.Font("Trajan Pro", 9.5F);
            this.panelGame.ForeColor = System.Drawing.Color.Tan;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(584, 361);
            this.panelGame.TabIndex = 8;
            // 
            // scoreGame
            // 
            this.scoreGame.AutoSize = true;
            this.scoreGame.Font = new System.Drawing.Font("Trajan Pro", 9.5F, System.Drawing.FontStyle.Bold);
            this.scoreGame.Location = new System.Drawing.Point(255, 314);
            this.scoreGame.Name = "scoreGame";
            this.scoreGame.Size = new System.Drawing.Size(74, 17);
            this.scoreGame.TabIndex = 12;
            this.scoreGame.Text = "Score: 0";
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.White;
            this.three.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.three.Location = new System.Drawing.Point(379, 219);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(85, 64);
            this.three.TabIndex = 11;
            this.three.TabStop = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.White;
            this.two.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.two.Location = new System.Drawing.Point(250, 219);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(85, 64);
            this.two.TabIndex = 10;
            this.two.TabStop = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.White;
            this.one.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.one.Location = new System.Drawing.Point(121, 219);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(85, 64);
            this.one.TabIndex = 9;
            this.one.TabStop = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // question
            // 
            this.question.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Trajan Pro", 12F);
            this.question.Location = new System.Drawing.Point(214, 165);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(156, 21);
            this.question.TabIndex = 8;
            this.question.Text = "[question here]";
            // 
            // guesses
            // 
            this.guesses.AutoSize = true;
            this.guesses.Font = new System.Drawing.Font("Trajan Pro", 9.5F, System.Drawing.FontStyle.Bold);
            this.guesses.Location = new System.Drawing.Point(437, 113);
            this.guesses.Name = "guesses";
            this.guesses.Size = new System.Drawing.Size(17, 17);
            this.guesses.TabIndex = 7;
            this.guesses.Text = "3";
            // 
            // multiplier
            // 
            this.multiplier.AutoSize = true;
            this.multiplier.Font = new System.Drawing.Font("Trajan Pro", 9.5F, System.Drawing.FontStyle.Bold);
            this.multiplier.Location = new System.Drawing.Point(228, 113);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(25, 17);
            this.multiplier.TabIndex = 7;
            this.multiplier.Text = "1x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Guesses left:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Multiplier:";
            // 
            // headerGame
            // 
            this.headerGame.AutoSize = true;
            this.headerGame.Font = new System.Drawing.Font("Trajan Pro", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerGame.ForeColor = System.Drawing.Color.Tan;
            this.headerGame.Location = new System.Drawing.Point(13, 26);
            this.headerGame.Name = "headerGame";
            this.headerGame.Size = new System.Drawing.Size(469, 17);
            this.headerGame.TabIndex = 4;
            this.headerGame.Text = "Choose the correct answer to the question above it";
            // 
            // buttonCloseGame
            // 
            this.buttonCloseGame.BackgroundImage = global::Dota2_Quiz.Properties.Resources.dota_close;
            this.buttonCloseGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseGame.Location = new System.Drawing.Point(510, 13);
            this.buttonCloseGame.Name = "buttonCloseGame";
            this.buttonCloseGame.Size = new System.Drawing.Size(62, 42);
            this.buttonCloseGame.TabIndex = 1;
            this.buttonCloseGame.UseVisualStyleBackColor = false;
            this.buttonCloseGame.Click += new System.EventHandler(this.buttonCloseGame_Click);
            // 
            // panelGameOver
            // 
            this.panelGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.panelGameOver.BackgroundImage = global::Dota2_Quiz.Properties.Resources.game_background;
            this.panelGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGameOver.Controls.Add(this.saveHighscore);
            this.panelGameOver.Controls.Add(this.textName);
            this.panelGameOver.Controls.Add(this.label3);
            this.panelGameOver.Controls.Add(this.scoreText);
            this.panelGameOver.Controls.Add(this.label8);
            this.panelGameOver.Controls.Add(this.gameOverClose);
            this.panelGameOver.Font = new System.Drawing.Font("Trajan Pro", 9.5F);
            this.panelGameOver.ForeColor = System.Drawing.Color.Tan;
            this.panelGameOver.Location = new System.Drawing.Point(0, 0);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(584, 361);
            this.panelGameOver.TabIndex = 12;
            // 
            // saveHighscore
            // 
            this.saveHighscore.BackColor = System.Drawing.Color.Black;
            this.saveHighscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveHighscore.Location = new System.Drawing.Point(224, 310);
            this.saveHighscore.Name = "saveHighscore";
            this.saveHighscore.Size = new System.Drawing.Size(136, 27);
            this.saveHighscore.TabIndex = 8;
            this.saveHighscore.Text = "Save highscore";
            this.saveHighscore.UseVisualStyleBackColor = false;
            this.saveHighscore.Click += new System.EventHandler(this.saveHighscore_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(224, 277);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(136, 23);
            this.textName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter your name:";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Trajan Pro", 15F);
            this.scoreText.Location = new System.Drawing.Point(248, 167);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(89, 26);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "Score: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trajan Pro", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tan;
            this.label8.Location = new System.Drawing.Point(167, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 42);
            this.label8.TabIndex = 4;
            this.label8.Text = "GAME OVER";
            // 
            // gameOverClose
            // 
            this.gameOverClose.BackgroundImage = global::Dota2_Quiz.Properties.Resources.dota_close;
            this.gameOverClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameOverClose.Location = new System.Drawing.Point(510, 13);
            this.gameOverClose.Name = "gameOverClose";
            this.gameOverClose.Size = new System.Drawing.Size(62, 42);
            this.gameOverClose.TabIndex = 1;
            this.gameOverClose.UseVisualStyleBackColor = false;
            this.gameOverClose.Click += new System.EventHandler(this.gameOverClose_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dota2_Quiz.Properties.Resources.dota_background;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHighscores);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelGameOver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 200);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dota 2 Quiz";
            this.panelMain.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aboutBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerAbout)).EndInit();
            this.panelHighscores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.highscoresBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerHighscores)).EndInit();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.one)).EndInit();
            this.panelGameOver.ResumeLayout(false);
            this.panelGameOver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHighScores;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.PictureBox headerAbout;
        private System.Windows.Forms.Panel panelHighscores;
        private System.Windows.Forms.PictureBox headerHighscores;
        private System.Windows.Forms.Button highscoresClose;
        private System.Windows.Forms.Button aboutClose;
        private System.Windows.Forms.PictureBox aboutBackground;
        private System.Windows.Forms.Label aboutText;
        private System.Windows.Forms.PictureBox highscoresBackground;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button buttonCloseGame;
        private System.Windows.Forms.Label headerGame;
        private System.Windows.Forms.Label guesses;
        private System.Windows.Forms.Label multiplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.PictureBox three;
        private System.Windows.Forms.PictureBox two;
        private System.Windows.Forms.PictureBox one;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button gameOverClose;
        private System.Windows.Forms.Label scoreGame;
        private System.Windows.Forms.Button saveHighscore;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playersHighscores;
    }
}

