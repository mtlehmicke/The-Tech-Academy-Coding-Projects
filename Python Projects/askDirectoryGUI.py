from tkinter import filedialog
from tkinter import *

def browseButton():
    filename = filedialog.askdirectory()
    directoryText.insert('1.0', filename)

master = Tk()

browse = Button(text='Directory', command=browseButton)
browse.grid(row=0, column=1)

directoryText = Text(master, height=2, width=30)
directoryText.grid(row=0, column=3)

master.mainloop()
