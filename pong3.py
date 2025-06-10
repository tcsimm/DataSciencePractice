import turtle

win = turtle.screen()

win.title("Pong")
win.bgcolor("Black")
win.setup(width = 800, height=600)
win.tracer(0)

# Left paddle
left_pad = turtle.Turtle()
left_pad.speed(0)
left_pad.shape("square")
left_pad.color("white")
left_pad.shapesize(stretch_wid=6, stretch_len=1)
left_pad.penup()
left_pad.goto(-350, 0 )

# Right paddle
right_pad = turtle.Turtle()
right_pad.speed(0)
right_pad.shape("square")
right_pad.color("white")
right_pad.shapesize(stretch_wid=6, stretch_len=1)
right_pad.penup()
right_pad.goto(350,0)

# Ball
ball = turtle.Turtle()
ball.speed(0)
ball.shape("circle")
ball.color("white")
ball.penup()
ball.goto(0,0)
ball.dx = 0.175
ball.dy = 0.175

# Paddle movement
def left_up():
    y = left_pad.ycor()
    if y < 250:
        left_pad.sety(y + 20)
        
def left_down():
    y = left_pad.ycor()
    if y > -240:
        left_pad.sety(y - 20)
        
def right_up():
    y = right_pad.ycor()
    if y < 250:
        right_pad.sety(y + 20)
        
def right_down():
    y = right_pad.ycor()
    if y > -240:
        right_pad.sety(y - 20)
        
# Key bindings
win.listen()
win.onkeypress(left_up, "w")
win.onkeypress(left_down, "s")
win.onkeypress(right_up, "Up")
win.onkeypress(right_down, "Down")

# Main game loop
while True:
    win.update()
    
    # Move ball
    ball.setx(ball.xcor() + ball.dx)
    ball.sety(ball.ycor() + ball.dy)