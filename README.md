# INV S BL  SNAKE
Ashley Soderlund, Computer Science Student

> The starting goal of this repository was to code the computer game 'Snake' using C#. It has then changed for the time being to have a few different aspects that change the game to INV S BL  SNAKE (invisible snake). After a week of work and using a new language, this is my current version (though very buggy) of snake with a twist.


## Project Creation
-Visual Studio Code, Version: 1.64
-.NET Core, Version: 6.0.4
-GitHub

## Running Program
-Pull all files


## Program Eplaination
### UML Class Diagram
![image](https://user-images.githubusercontent.com/69334327/166716266-3399e279-63b8-4a2d-b6e0-5c1d35c44ee4.png)

All the classes are held within the same namespace, `SnakeGame`. There are four files to separate the four classes (`Game()`, `Snake()`, `Fruit()`, `OldFruit()`), and the Game class holds the `Main()` from which the program runs. The main class asks the user if they would like to play. If the user enters yes, then the program will give directions on how to play the game. After the user hits any key, the game board will display. The game board has a piece of fruit on it represented by the * character and the snake represented by the o character. Once the user presses the Up, Down, Left, or Right Arrow on the keyboard, the snake will move one character in that direction. The snake will only display enough characters for its size, so as the snake moves, the last character of the snake will be removed. </br>
If the snake runs into the fruit on the board, the fruit will change locations to a new spot on the board and the snake will grow in size by 1. The count of the fruit collected will grow by 1. Because the game is not like normal snake and the user makes all the movement of the snake, if the snake tries to go on a path it has previously taken, the snake characters will not display on the board. It means the user will have to know where the snake it at even without seeing it. </br>
After each movement the user makes, the board is updates and displayed with the changes. The functions `checkWin()` and `checkLose()` are called to make sure the user hasn’t run into something for the game to end or that their total number of fruits is equal to 10. </br>
There are three different ways for a game of snake to end. The goal of the program is to beat the game, so winning the game by collecting 10 * or fruits will end the game. The next way to end the game is by losing the game, which is done by running into the boarder of the game board. The final way is to quit by hitting the Escape key on your keyboard. It will show the generic output message with the total of fruits you had collected. </br>


