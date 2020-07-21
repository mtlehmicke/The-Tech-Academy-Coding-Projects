from tkinter import *
import tkinter

master = tkinter.Tk()
master.title('Check files')
master.option_add('*font', ('arial', 11,))

# frames
frame1 = Frame(master)
frame1.pack(fill=X)

frame2 = Frame(master)
frame2.pack(fill=X)

frame3 = Frame(master)
frame3.pack(fill=X)

# buttons
browse1 = Button(frame1, text='Browse...', width=12)
browse1.pack(side=LEFT, padx=20, pady=5)

browse2 = Button(frame2, text='Browse...', width=12)
browse2.pack(side=LEFT, padx=20, pady=5)

check_button = Button(frame3, text='Check for files...', height=2)
check_button.pack(side=LEFT, padx=20, pady=10)

close_button = Button(frame3, text='Close Program', height=2)
close_button.pack(side=RIGHT, padx=20, pady=10)

# entry fields
entry1 = Entry(frame1)
entry1.pack(fill=X, padx=5, expand=True)
        
entry2 = Entry(frame2)
entry2.pack(fill=X, padx=5, expand=True)

master.mainloop()
