# Import the turtle graphics module, used for creating standard graphics and drawings
import turtle

t = turtle.Turtle()
#t.forward(100)
# t.right(90)
# t.forward(100)

# Screen setup

win = Turtle.screen() # Creates a window or screen using Turtle

# Sets the title to Pong
win.title("Pong")

# Changes the background color to black
win.bgcolor("Black")

# Sets dimensions as 800 by 600
win.setup(width = 800, height = 600)

win.tracer(0)