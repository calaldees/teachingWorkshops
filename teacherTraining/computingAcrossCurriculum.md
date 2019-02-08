Computing Across the Curriculum
===============================

Objectives
----------

* Understand the power of context based learning.
    * Computing relates to EVERYTHING!
* Consider how we can support colleges with our Computing skills


[Computing in the curriculum: Challenges and strategies from a teacher’s perspective](https://link.springer.com/article/10.1007/s10639-016-9482-0)

[Ofstead inspection](https://onefourseven.org.uk/blog/ofsted-on-computing/)

[Ofsetd Assessing Computing](https://www.softegg.co.uk/blog/ofsted-inspecting-the-computing-curriculum)

[Myles Berry](https://www.youtube.com/watch?v=-JBgaR8sNcE)
A high-quality computing eduation equips pupils to use computational thinking and creativity to understand and change the world
Computing has deeps links with mathematics, science and design and technology, and provides insight into both natural and artificial systems.

Ofstead say - Computing curriculm is good or better when
Context relevent to pupils lives and reflect increasing use of computing in the world of inductry. Wider community to provide enrichment activities
Links with other sibjects in school are productive in strengthening pupils leaning in computing

* computer science
* information technology
* digital literacy

All subjects - terminology for all subjects

Barefoot

Logic: predicting alaysing
Algorithus: making steps & rules
Decomposition: breaking down into parts
Patterns: spotting using similaritys
Abstraction: removing unessiscary detail
Evaluation: making judgememt

Tinkering: experimenting & playing
Creating: designing & making
Debugging: finding & fixing
Perservering: keeping going
Collaboration: working together

Paper plane - deomposition

science classification - binary tree

Blender - scripted 3d animation project
Conways life
Algorithmic art - recusion
Music demos - elevated - perlin noise
Use applications in differnt languages
Rasbery Pie weather station - tweet the weather
Graph drawing - pandas python - met office weaterh data
kinect + scratch
phse - no goverment cencorship - free speech
re - Turing test - what rights do they need?
History of comuting timeline


promotes spiritual, moal, cultural, mental and physical development of putpis

[Ofsted inspections: myths](https://www.gov.uk/government/publications/school-inspection-handbook-from-september-2015/ofsted-inspections-mythbusting)

Other subjects want you to train them in all aspects of computers (ICT and Computing) for their class's rather than facilitating you
Indipendence from teachers

Example Lesson
--------------

3d_image

* Etemology
    * Stereo-Scopic
        * Two - Optic
* History
* Physics
    * Light filters
* ICT - Image Manipulation
* Computing - Automation
    * RGB Pixels
    * Layer mode
    * Algorithums (for each pixel)
* Phyosophy
    * How to we experience the world
* Art - Create own abstract worlds


Ideas
-----

* Geography
    * Traceroute on map
    * River Vally Simulation
    * [World Elevation Data](http://www.shadedrelief.com/natural3/pages/extra.html)
* Physics
    * Simulation
* Maths
    * Matrix
    * Stats
    * Mechanics
        * game forces
* Biology
* Chemistry
* Business Studies
    * simulated investments?
* Economics
    * Simulation - Traffic
* Art
    * Animation
        * 2D
        * 3D
* Langauges
    * English Ghrama
* Socialogy
    * Surveys
* Psycology
    * Valve hire psycologists
    * Facebook
    * Google - AB Testing - Color of buttons
    * flash card
* DT
    * CAD/CAM
* Music
    * MIDI - Theory
* MFL
    * [Language Letter Frequency](https://en.wikipedia.org/wiki/Letter_frequency)

* Simulation
    * [traffic-simulation.de](http://www.traffic-simulation.de)
    * [Traffic Junction Simulation Video](https://www.youtube.com/watch?v=yITr127KZtQ)
    * [SkyLines Forum](https://forum.paradoxplaza.com/forum/index.php?threads/perpetual-traffic-jam.937466/)

Look at the spec - suggest an activity


https://earthengine.google.com/timelapse/
http://www.hillside.co.uk/tour/tour.html



DNA
Human DNA 6 Billion pairs
4 bytes per pair (A-G,C-T)
6000000000000 * 4 / 1024 / 1024 / 1024 / 1024 = 21 Terrabyes?


https://regex101.com/
import random
import re
random.seed(0)
dna = ''.join(random.choice(('A', 'G', 'C', 'T')) for x in range(10000))
re.search(r'AC[AG].GT.{8,10}AAA', dna)
re.search(r'AC[AG].GT[AT]{5,6}AAA', dna)


[Conways game of life](http://www.conwaylife.com/)
[Conway basic paterns](http://pi.math.cornell.edu/~lipa/mec/lesson6.html)
[Simple](https://playgameoflife.com/)
[Example](https://pmav.eu/stuff/javascript-game-of-life-v3.1.1/)
[Example 2](https://www.samcodes.co.uk/project/game-of-life/)



[Primary English Example](https://www.somerset.org.uk/sites/edtech/Primary%20Computing/Computing%20across%20curriculum/English%20and%20computing.pdf)


[Computing Curriculum is not just about code - its polital power](https://mirandanet.ac.uk/blog/2017/09/02/coding-lessons-computing-curriculum/) See closing two paragraphs


[Met Office Weather Data](https://www.metoffice.gov.uk/climate/uk/data)
[National Office of Satistics](https://www.ons.gov.uk/)

[Lightening Maps](https://www.lightningmaps.org/)


[ID](https://wiki.openstreetmap.org/wiki/ID) Open Streetmap Javascript Editor


[Plotly](https://plot.ly/) [Simple Scatter Example](https://plot.ly/python/line-and-scatter/#simple-scatter-plot)
```python
import plotly.plotly as py
import plotly.graph_objs as go

# Create random data with numpy
import numpy as np

N = 1000
random_x = np.random.randn(N)
random_y = np.random.randn(N)

# Create a trace
trace = go.Scatter(
    x = random_x,
    y = random_y,
    mode = 'markers'
)

data = [trace]

import plotly
plotly.offline.plot(data, filename='basic-line')
```


recursion - mini tree

common factors