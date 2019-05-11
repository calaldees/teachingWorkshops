Science and Evolution of Computer Graphics
==========================================


Part 1 - 2D Graphics as pixel data
-------------------------------

Computer displays are all broken into describe chunks called `pixels`

[8x8 pixel graphic](https://www.google.com/search?q=8x8+smile)

* Gameboy - 160 x 144 - [Super Mario World](https://www.youtube.com/watch?v=sdSpTUHIGgw)
* NES - 256 x 240
* Playstation 1 - 256 x 224
* DVD - 720 x 480
* 1080p - 1920 x 1080


```python
    def draw_sprite(data, width=8):
        """
            --####--
            -#----#-
            #-#--#-#
            #------#
            #-####-#
            #------#
            -#----#-
            --####--

            As linear pixel data
            --####---#----#-#-#--#-##------##-####-##------#-#----#---####--
        """
        for line_number in range(len(data)//width):
            print(data[line_number * width:(line_number + 1) * width])

    sprite_data = '--####---#----#-#-#--#-##------##-####-##------#-#----#---####--'
    draw_sprite(sprite_data)
```

The process of taking chunks from data from one memory location and copying it to another is called `blit-ing` [bit block transfer](https://en.wikipedia.org/wiki/Bit_blit).

[MicroMages NES Game - 8x8 Sprite explanation](https://youtu.be/ZWQ0591PAxM?t=162)


Part 2 - 3D Graphics as pixels
------------------------------

### Wireframe 3D - Drawing of lines

[Bresenham's line algorithm](https://en.wikipedia.org/wiki/Bresenham%27s_line_algorithm)

Examples
* [BattleZone](https://www.youtube.com/watch?v=e5_MXGkLvpI) PC
* [Red Alarm](https://www.google.com/search?q=red+alarm+virtual+boy)
* [Red Alarm Review](http://www.nintendolife.com/reviews/2009/04/red_alarm_retro)
* [Elite](https://youtu.be/1ZT6ItqZ2xc) BBC

### Filled Polygons

[Polygon Filling Algorithm](https://www.tutorialspoint.com/computer_graphics/polygon_filling_algorithm.htm)

Examples
* [Carrier Command](https://youtu.be/NvpcGs-NJPw?t=408) Amiga
* [Elite](https://youtu.be/z_ei6LSj8IM?t=33) PC

Draw triangles in the correct order

### Textured Mapping

* [Software Texture Mapping](https://youtu.be/RyYEGdGwnFs)
* [Quake 1 - Different renderers](https://www.youtube.com/watch?v=6STlawZarcU)

The processes of taking triangle geometry and drawing it as pixels is called `rasterisation`

Quake 1 engine was sold/licensed to game developers.


Part 3 - Modern 3D Graphics Chipsets
------------------------------------

3D Graphics Cards are a completely separate computer inside your computer that is dedicated to drawing triangles.

Modern game programmers do NOT write code to 'blit sprites' or 'rasterise triangles'. These are solved problems.
Modern game programmers use graphics library's and hardware.

Mobile chipsets - 200 Million triangles per second - source [imagination graphics benchmark guide](https://www.imgtec.com/blog/consumer-guide-to-graphics-benchmarks/)

