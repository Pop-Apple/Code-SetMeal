import _tkinter
import tkinter
import sys
from tkinter import messagebox
from typing import Sized, Text

root = tkinter.Tk()

root.title(u"Template App")
root.geometry("400x200")
## Label Ctrl
Label1 = tkinter.Label(text=u'Hello Python World', foreground='#000000',)
Label1.place(x=10, y=10)

##TextBox Ctrl
TextBox1 = tkinter.Entry(width=38)
TextBox1.place(x=10, y=30)

def btn1_click():
    messagebox = tkinter.messagebox.showinfo("Tkinter", "Hello " + TextBox1.get())

Button1 = tkinter.Button(root, text=u'   Checked   ', command=btn1_click)
Button1.place(x=150, y=10)



## END AGAIN :)
root.mainloop()