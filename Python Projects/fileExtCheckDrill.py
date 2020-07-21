import os

for file in os.listdir("\pyProjects"):
    if file.endswith(".txt"):
        print(os.path.join("/pyProjects", file))
        print("last modified: %s" % os.path.getmtime(file))
