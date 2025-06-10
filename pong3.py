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
left_pad.goto(-350, 0)