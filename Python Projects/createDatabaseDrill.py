import sqlite3

fileList = ('information.docx', 'Hello.txt', 'myImage.png', \
            'myMovie.mpg', 'World.txt', 'data.pdf', 'myPhoto.jpg')

connect = sqlite3.connect('drill_database.db')
cursor = connect.cursor()

cursor.execute('DROP TABLE IF EXISTS fileTable')
cursor.execute('CREATE TABLE IF NOT EXISTS fileTable(id \
INTEGER PRIMARY KEY AUTOINCREMENT, Filename TEXT)')


cursor.executemany('INSERT INTO fileTable(Filename) VALUES (?)', \
                   [(file,) for file in fileList if file.endswith('.txt')])
connect.commit()

cursor.execute("SELECT * FROM fileTable")
rows = cursor.fetchall()
for row in rows:
    print(row)

cursor.close()
connect.close()
    



