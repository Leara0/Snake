using Snake;

PlayGame.PlayTheGame();

/*Steps:
 xCreate an apple
  x random coord generate and write 'apple'
 move the snake
 - clear screen between movement (remember to rewrite apple)
 - use a list to store coord for each segment 
    + add new segment to end (.Add()) and remove old segment from begining (.RemoveAt[0])
 - continue on in the direction snake has been going
 steer the snake when direction is pressed
 - only responds if perpendicular direction is pressed
 - responds and changes direction of snake
 generate a new apple when one is eaten
 - new coord generated and printed (print every time screen is cleared)
 grow the snake when apple is eaten
 - overwrite or skip the remove old segment
 kill the game if the snake hits itself or the wall
 - check if snake List<(int X, int Y)> contains new coord or if it is outside window height or width
 

*/