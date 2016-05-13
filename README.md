# **Dota2 Quiz**
Dota 2 Quiz game made for college purposes.
Created and developed by Viktor Spasovski.

___

## 1. Опис на апликацијата
Апликацијата Dota 2 Quiz е едноставна neverending игра која преку интерактивни прашања поврзани со играта им овозможува на корисниците да го тестираат своето знаење од истата.

Со цел да се обезбеди поголемо задоволство кај корисниците, играта исто така има сопствен multiplier систем, кој го зголемува бројот на поени кој го добива корисникот во зависност од колку прашања по ред одговорил точно.

Целта на играта е да се освојат што е можно повеќе поени со цел да се биде прв на highscores листата.

___

## 2. Упатство на користење

Целата игра се движи низ вкупно 5 екрани, односно (почетниот, new game, highscores, about и game over).

Почетниот екран содржи три контроли (new game, highscores и about) кои се подолу објаснети, а тој изгледа вака:

**(Слика 1)**

![Main screen](/Screenshots/MainScreen.png?raw=true "Main screen")

#### 2.1 New game

Креирање на нова игра е возможно преку почетниот екран, односно со самото стартување на апликацијата. При креирање на нова игра, по случаен (random) избор се одбира прашање од веќе постоечката база со прашања и се прикажува на новиот екран заедно со соодветните одговори.

Тоа изгледа вака:

**(Слика 2)**

![Game Screen](/Screenshots/NewGame.png?raw=true "Game screen")

Доколку корисникот одлучи дека сака да ја прекине играта со клик на 'X' во горниот десен агол се појавува нов прозорец за потврдување на истото со цел да се избегне ненамерен излез од играта.

#### 2.2 Highscores

Тука се чуваат најдобрите 14 играчи, чија листа се освежува секој пат кога ќе се заврши една игра или пак кога ќе се отвори Highscores екранот. Резултати се зачувуваат во оваа листа само доколку корисникот го внесе своето име во Game over екранот (види слика 5) и го стисни копчето 'Save highscore'.

*Листата е подредена по опаѓачки редослед.

Highscores екран:

**(Слика 3)**

![Highscores](/Screenshots/Highscores.png?raw=true "Highscores")

#### 2.3 About

На овој екран се прикажани краток опис на апликацијата, упатство за истата како и креатор на оваа апликација.

About екран:

**(Слика 4)**

![About](/Screenshots/About.png?raw=true "About")

#### 2.4 Game over

'Game over' екранот се појавува секој пат кога играчот ќе снема „обиди за погодување“ односно ке изгуби. На овој екран се наоѓа завршниот резултат од играта, како и опција за внесување на име и зачувување на резултат и запишување во Highscores листата.

**(Слика 5)**

![Game over](/Screenshots/GameOverName.png?raw=true "Game over")

#### 2.5 Правила на играта

Самата игра е едноставна па со тоа и правилата на играта се едноставни:
* Секое точно одговорено го зголемува multiplier-от за 1. (1x -> 2x -> 3x ...)
* Секое неточно одговорено прашање го ресетира multiplier-ot на 1х.
* Секое неточно одговорено прашање го намалува бројот на преостанати обиди (guesses left) за 1.
* Играта завршува кога играчот ќе има 0 преостанати обиди.

___

## 3. Претставување на проблемот

#### 3.1 Податочни структури

Сите податоци и функции се иницијализираат само доколку е потребно, со цел да се намали времето на подигнување на апликацијата, што значи дека на пример прашањата се генерираат само доколку е започната нова игра, highscores резултати само доколку се отвори тој екран итн.

Главните елементи на играта се прашањата, а тие се пристапуваат преку листа на објекти од класата `public partial class Question` во која се чуваат информациите за секое од прашањата:

```
public partial class Question
    {
        private string question { get; set; }
        //the question itself
        private string[] answers { get; set; }
        //all the answers
        public string answer { get; set; }
        // the correct answer
        
        public Question() { }

        public Question(string question, string[] answers, string answer)
        {
            this.question = question;
            this.answers = answers;
            this.answer = answer;
        }

        public override string ToString()
        {
            return question;
        }

        public string getAnswer1()
        {
            return answers[0];
        }

        public string getAnswer2()
        {
            return answers[1];
        }

        public string getAnswer3()
        {
            return answers[2];
        }
    }
```
#### 3.2 Прикажување на прашањата

Прашањата се прикажуваат преку повикување на функциијата `newQuestion()` која генерира прашање по случаен избор и ги повлекува соодветните слики за одговорите како и одговорот на прашањето.

```
public void newQuestion()
    {
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
```

#### 3.3 Зачувување на highscore

Зачувувањето на резултат се повикува преку клик на копчето 'Save highscore' на 'Game over' екранот (види слика 5) и тоа преку функцијата `saveHighscore_Click(object sender, EventArgs e)`, со што воедно се повикува и функцијата `addHighscores()` која ги освежува податоци на 'Highscores' екранот. 

*Функциите можат да се видат подолу.

Сите резултати се чуваат во текстуален фајл `highscores.txt` кој доколку не постои, се креира.

```
private void saveHighscore_Click(object sender, EventArgs e)
    {
        string nameScore = textName.Text + "," + score.ToString() + Environment.NewLine;
        File.AppendAllText("highscores.txt", nameScore);

        addHighscores();
        panelHighscores.Visible = true;
    }
```

```
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
```

#### 3.4 GUI (Graphical User Interface)

За изгледот на оваа апликација се користени панели со цел побрза и поконцентрирана навигација и употреба, односно со употреба на само еден прозорец и менување на изгледот на истиот преку повеќе панели. 

Прикажувањето на одговори како слики е овозможено со `PictureBox` каде што при генерирањето на ново прашање, сликата во истите `PictureBox` се менува според одговорите на соодветното прашање.
