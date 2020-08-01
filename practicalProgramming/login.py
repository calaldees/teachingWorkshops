
def login():
    username = input('username: ')
    password = input('password: ')
    if username == 'bob' and password == 'god':
        print('Accepted')
    else:
        print('Denied')

