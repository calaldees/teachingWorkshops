aa = [676, 51, 2, 9]
print(aa)

# total = 0
# print(f'We started with a total of {total}')
# for item in aa:
#     print(f'The item is {item}')
#     print(f'The total is {total}')
#     total = total + item
#     print(f'After I added item the total is now {total}')
#     print()
# print('The final total is')
# print(total)


# data = []
# with open('test.txt', 'r') as filehandle:
#     for line in filehandle:
#         line = line.strip()
#         data.append(line)

# print(f'I have read in {data}')

data = [
    'file',
    'to',
    'write yeah',
]
with open('out.txt', 'w') as filehandle:
    for item in data:
        filehandle.write(item + '\n')

