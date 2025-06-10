import turtle

win = turtle.screen()

win.title("Pong")
win.bgcolor("Black")
win.setup(width = 800, height=600)
win.tracer(0)

# Left paddle
left_pad = turtle.Turtle()