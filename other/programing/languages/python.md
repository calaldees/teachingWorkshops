https://book.pythontips.com/en/latest/index.html


https://black.readthedocs.io/
[Google StyleGuide](https://google.github.io/styleguide/pyguide.html)
[pep8](https://www.python.org/dev/peps/pep-0008/)

[Google DocString Guide](https://sphinxcontrib-napoleon.readthedocs.io/en/latest/example_google.html)
[sphinx docstring format](https://thomas-cokelaer.info/tutorials/sphinx/docstring_python.html#template.MainClass1.function1)


See lanaguageEdgeCases
https://github.com/satwikkansal/wtfpython


Professional Interview Screening

what is PEP8 -> style guide
what is a decorator -> function wrapper
what is the difference between list & tuple -> mutability

```python
    >>> aa=(x+1 for x in range(3)) ; print(tuple(aa), tuple(aa))
    ((1, 2, 3), ())
    # Q: Why? - A: The generator is exhausted

    >>> aa=[1,2,3] ; bb=aa ; aa[:]=[4,5,6] ; print(aa, bb)
    ([4, 5, 6], [4, 5, 6])
    # Q: Why? - A: aa an bb reference the same list

    >>> dd = {i for i in (1,2,2,3)} ; dd &= {2,3,4} ; print(dd)
    set([2, 3])
    # Q: Why? - A: sets have no duplicates `&=` is union_in-place modification
```
    #aa=[1,2,3];bb=aa;aa=[4,5,6];print(aa,bb)




```python
dd={'a':1, 'b':2}
for k in dd.keys():
    dd[k]=2
print(dd)


for i in (1,2,3):
    if i == 4:
        break
else:
    

```


from itertools import chain, cycle, permutations
from functools partial, lru_cache, reduce, wraps
from collections import defaultdict, namedtuple, ChainMap, deque