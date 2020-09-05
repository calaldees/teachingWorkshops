 # pytest test.py --doctest-modules --pdb

def add(a, b):
    """
    My function to add stuff

    >>> add(1, 1)
    2
    >>> add(2, 2)
    4
    >>> add(-1, 5)
    100
    """
    return a + b


answer = add(10, 2)
print(answer)
