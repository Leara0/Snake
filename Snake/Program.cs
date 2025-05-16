using Snake;

PlayGame.PlayTheGame();

/*Steps:
xCreate an apple
x random coord generate and write 'apple'
x  - rewrite apple
x move the snake
x - clear screen between movement (remember to rewrite apple)
x - use a list to store coord for each segment
x    + add new segment to end (.Add()) and remove old segment from begining (.RemoveAt[0])
x - continue on in the direction snake has been going
x steer the snake when direction is pressed
x  only responds if perpendicular direction is pressed
x  responds and changes direction of snake
x generate a new apple when one is eaten
x - new coord generated and printed (print every time screen is cleared)
x grow the snake when apple is eaten
x - overwrite or skip the remove old segment
 kill the game if the snake hits itself or the wall
 - check if snake List<(int X, int Y)> contains new coord or if it is outside window height or width


*/