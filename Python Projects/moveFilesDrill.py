import os, sqlite3, tkinter, shutil
from tkinter import *
from tkinter import filedialog

class MainClass():

    def __init__(self,master):
        self.parent=master
        self.myGUI()
        

    def myGUI(self):
        self.source_path = StringVar()
        self.destination_path = StringVar()
        
        # frames
        self.frame1 = Frame(myGUI)
        self.frame1.pack(fill=X)

        self.frame2 = Frame(myGUI)
        self.frame2.pack(fill=X)

        self.frame3 = Frame(myGUI)
        self.frame3.pack(fill=X)

        # buttons
        self.browse1 = Button(self.frame1, text='Source Folder', \
                         command=self.browseSource, width=14)
        self.browse1.pack(side=LEFT, padx=20, pady=5)

        self.browse2 = Button(self.frame2, text='Destination Folder', \
                         command=self.browseDestination, width=14)
        self.browse2.pack(side=LEFT, padx=20, pady=5)

        self.transfer_button = Button(self.frame3, text='Transfer Files', \
                                 command=self.txtFileMove)
        self.transfer_button.pack(padx=20, pady=10)

        # entry fields
        self.dir1 = Entry(self.frame1, textvariable=self.source_path)
        self.dir1.pack(fill=X, padx=5, expand=True)
                
        self.dir2 = Entry(self.frame2, textvariable=self.destination_path)
        self.dir2.pack(fill=X, padx=5, expand=True)


    def browseSource(self):
        global source_path
        self.filename = filedialog.askdirectory()
        self.source_path.set(self.filename)
        print(self.filename)

    def browseDestination(self):
        global destination_path
        self.filename2 = filedialog.askdirectory()
        self.destination_path.set(self.filename2)
        print(self.filename2)

    def txtFileMove(self):
        connect = sqlite3.connect('drill_database.db')
        cursor = connect.cursor()

        cursor.execute('DROP TABLE IF EXISTS fileTable')
        cursor.execute('CREATE TABLE IF NOT EXISTS fileTable(id \
        INTEGER PRIMARY KEY AUTOINCREMENT, Filename TEXT)')

        cursor.executemany('INSERT INTO fileTable(Filename) VALUES \
                            (?)', [(file,) for file in self.filename if \
                            file.endswith('.txt')])
        connect.commit()

        cursor.execute("SELECT * FROM fileTable")

        rows = cursor.fetchall()
        for row in rows:
            print(row)
        
        for file in os.listdir(self.filename):
            if file.endswith(".txt"):
                print(os.path.join("/txtMove", file))
                print("last modified: %s" % os.path.getmtime(file))
                shutil.move(file, self.filename2)
                
        

        cursor.close()
        connect.close()

if __name__ == '__main__':
    myGUI = Tk()
    app=MainClass(myGUI)
    myGUI.title('Check files')
    myGUI.mainloop()

