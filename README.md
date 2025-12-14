Snake Game is a classic arcade-style game developed using C# Windows Forms 🎮.
The player controls a snake 🐍 to eat food 🍎, grow longer, and score points 🏆 while avoiding collisions with walls 🧱 and itself ⚠️.
The game supports multiple difficulty levels 🐢🐇🐉, sound effects 🔊, and pause/resume functionality ⏸️▶️.

Features

Snake Movement

Controlled via keyboard arrows ⬆️⬇️⬅️➡️.

Moves continuously at a speed determined by the selected difficulty.

Levels

Three levels: Easy, Medium, Hard 🐢🐇🐉.

Each level adjusts the snake's speed:

Easy: slower 🐢

Medium: moderate 🐇

Hard: fast 🐉

Selecting a level automatically starts the game ⚡.

Food & Growth

Red food 🍎 appears at random positions on the canvas.

Eating food increases snake length ➕ and score 🏆.

Collision Detection

Hitting walls 🧱 or the snake itself ⚠️ triggers Game Over.

Game Over stops the game ⏹️ and displays the final score.

Sound Effects

Eating food: sound effect 🔊.

Game over: sound effect 🔊.

Pause & Resume

Game can be paused ⏸️ by clicking menu or using buttons.

Resume ▶️ continues the game without resetting the snake or score.

User Interface (UI)

Canvas 🎨: Displays the snake 🟡 and food 🔴.

Score Labels 🏆: Shows current score and high score.

Buttons 🔘: Start, Resume, Stop.

MenuStrip 🍔: Levels menu to select difficulty.

Game Mechanics

Snake starts with two segments: head and body.

Snake moves in the current direction, updating each segment's position.

Food appears randomly; eating it extends the snake by one segment.

Timer controls game speed ⏱️, which varies by selected level.

Game ends if the snake collides with boundaries or itself.

Code Structure

Form1.cs: Main form handling UI, game logic, and events.

Circle class: Represents snake segments and food.

Settings class: Stores snake movement direction and cell size.

SoundPlayer 🔊: Plays eating and game over sounds.

MenuStrip events 🍔: Handle level selection and game pausing.

Controls & Keys

Arrow keys ⬆️⬇️⬅️➡️ → Move snake.

Start button ▶️ → Start game manually.

Resume button ▶️ → Resume after pause.

Menu levels 🐢🐇🐉 → Change difficulty and auto-start game.


