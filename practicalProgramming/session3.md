show java - highlight
Spec bingo

arrays

```python
aa = [51,27,3,91,12]
print(aa)
print(aa[0])
print(aa[1])
print(aa[4])
print(aa[5])
print(aa[-1])
print(aa[-2])
print(aa[1:3])

bb = ['bob', 'jane', 'amy']
print(bb[1])

# Statically typed languages struggle to do this - arrays must be of the same type
cc = ['bob', 27, True]
print(cc[0])
print(cc[1])
print(cc[2])
```

```python
for x in aa:
    print(x)
```

```python
for x in aa:
    x = x + 1
    print(x)
```

```python
total = 0
for x in aa:
    total = total + x
print("I went through aa and the total is " + total)
```


```python
# Strings are lists/arrays
name = 'Allan'
for letter in name:
    print('letter is ' + letter)
print(name[0])
print(name[1])
```


```python
with open('test.txt', 'r') as f:
    for line in f:
        print(line)
```

```python
line_count = 0
with open("in.txt", 'r') as f:
  for line in f:
    print("Line " + str(line_count) + ": " + line)
    line_count += 1
```

```python
line_to_write = "Append to end of file"
with open("out.txt", 'a') as f:
    f.write(line_to_write + "\n")
```



```python
names = [
    'bob',
    'sally',
    'jim',
    'amy',
]
with open("out.txt", 'a') as f:
    for name in names:
        f.write(name + "\n")
```


```python
lines = []
line_input = ''
print('Collecting input - type `stop` to stop')
while line_input != 'stop':
    line_input = input('>>> ')
    lines.append(line_input)

print('collected')
print(lines)
print('now im going to write to file')

with open("out.txt", 'a') as f:
    for line in lines:
        f.write(line + "\n")
```



```python
# Deliverate use differnt variables names for lines
def collect_lines():
    lines = []
    line_input = ''
    print('Collecting input - type `stop` to stop')
    while line_input != 'stop':
        line_input = input('>>> ')
        lines.append(line_input)
    return lines

def write_to_file(filename, lines_to_write):
    with open(filename, 'a') as f:
        for line in lines_to_write:
            f.write(line + "\n")
    print('file ' + filename + ' wrote ' + len(lines_to_write))

my_lines = collect_lines()
print('i got')
print(my_lines)
write_to_file("out.txt", my_lines)
print('im done')
```

Read them back and and print each line followed by ' is cool'


```python
text = 'bob, jane, freddy'
text_split = text.split(',')
print(text)
print(text[0])
print(text[1])
print(text[2])

for name in text_split:
    print(name + ' is cool')


# strip

# possible
text_strip_split = []
for name in text.split(','):
    text_strip_split.append(name.strip())
# possible
for i in range(len(text_split)):
    text_split[i] = text_split[i].strip()
# possible
text_split = [
    name.strip()
    for name in text_split
]
# possible
text_split = list(map(lambda name: name.strip(), text_split))
# possible
for i, name in enumerate(text_split):
    text_split[i] = name.strip()
# possible
text_split = [name.strip() for name in text.split(',')]


','.join(names)

```


filehandle.readlines()

arrays/lists (it's a list because it is dynamic - python does not have arrays)
loops
file read
file write
split/join strings

--

Projects

--

nested if, nested iteration?
scope?


imperetive = sequence, iteration, selection
staticly typed
dynamicly typed

