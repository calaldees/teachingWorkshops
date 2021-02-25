list_of_dicts = []
f = open("project_recordsearch_data.csv", 'r')
for line in f:
    #d = {}
    worklist = line.split("|")

    #worklist = list(map(lambda ss: ss.strip() , worklist))

    #def strip_my_string(ss):
    #    return ss.strip()
    #worklist = map(strip_my_string , worklist)

    #worklist2 = []
    #for item in worklist:
    #    worklist2.append(item.strip())
    #worklist = worklist2
    
    #for index in range(len(worklist)):
    #  worklist[index] = worklist[index].strip()

    worklist = [
        item.strip()
        for item in worklist
    ]
    
    list_of_dicts.append({
        "First Name": worklist[0],
        "Surname": worklist[1],
        "Date of Birth": worklist[2],
        "Address": worklist[3],
    })
    
print (list_of_dicts)