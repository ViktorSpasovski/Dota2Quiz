# **Dota2 Quiz**
A Dota 2 Quiz game made for college purposes.
Created and developed by Viktor Spasovski.

___

## 1. Опис на апликацијата
Апликацијата Dota 2 Quiz е едноставна neverending игра која преку интерактивни прашања поврзани со играта им овозможува на корисниците да го тестираат своето знаење од истата.

Со цел да се обезбеди поголемо задоволство кај корисниците, играта исто така има сопствен multiplier систем, кој го зголемува бројот на поени кој го добива корисникот во зависност од колку прашања по ред одговорил точно.

Целта на играта е да се освојат што е можно повеќе поени со цел да се биде прв на highscores листата.

## 2. Упатство на користење

Целата игра се движи низ вкупно 5 екрани, односно (почетниот, new game, highscores, about и game over).

Почетниот екран содржи три контроли (new game, highscores и about) кои се подолу објаснети, а тој изгледа вака:

![Main screen](/Screenshots/MainScreen.png?raw=true "Main screen")
⋅(слика 1)

#### 2.1 New game

Креирање на нова игра е возможно преку почетниот екран, односно со самото стартување на апликацијата. При креирање на нова игра, по случаен (random) избор се одбира прашање од веќе постоечката база со прашања и се прикажува на новиот екран заедно со соодветните одговори.

Тоа изгледа вака:

![Game Screen](/Screenshots/NewGame.png?raw=true "Game screen")

(слика 2)

Доколку корисникот одлучи дека сака да ја прекине играта со клик на 'X' во горниот десен агол се појавува нов прозорец за потврдување на истото со цел да се избегне ненамерен излез од играта.

#### 2.2 Highscores

Тука се чуваат најдобрите 14 играчи, чија листа се освежува секој пат кога ќе се заврши една игра или пак кога ќе се отвори Highscores екранот. Резултати се зачувуваат во оваа листа само доколку корисникот го внесе своето име во Game over екранот (види слика 5) и го стисни копчето 'Save highscore'.

*Листата е подредена по опаѓачки редослед.

Highscores екран:

![Highscores](/Screenshots/Highscores.png?raw=true "Highscores")

⋅(слика 3)

#### 2.3 About

На овој екран се прикажани краток опис на апликацијата, упатство за истата како и креатор на оваа апликација.

About екран:

![About](/Screenshots/About.png?raw=true "About")

⋅(слика 4)

#### 2.4 Game over

'Game over' екранот се појавува секој пат кога играчот ќе снема „обиди за погодување“ односно ке изгуби. На овој екран се наоѓа завршниот резултат од играта, како и опција за внесување на име и зачувување на резултат и запишување во Highscores листата.

![Game over](/Screenshots/GameOverName.png?raw=true "Game over")

⋅(слика 5)

#### 2.5 Правила на играта

Самата игра е едноставна па со тоа и правилата на играта се едноставни:
* Секое точно одговорено го зголемува multiplier-от за 1. (1x -> 2x -> 3x ...)
* Секое неточно одговорено прашање го ресетира multiplier-ot на 1х.
* Секое неточно одговорено прашање го намалува бројот на преостанати обиди (guesses left) за 1.
* Играта завршува кога играчот ќе има 0 преостанати обиди.
