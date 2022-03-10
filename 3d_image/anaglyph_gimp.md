# Stereoscopic 3D Anaglyph
How to create red/cyan 3D images with GIMP

## Setup
* Download example ‘left’ and ‘right’ images to your computer's ‘Documents’ folder
    * http://calaldees.dreamhosters.com/pictures/lasar/
* Open GIMP
    * Window -> Single-Window Mode
    * File -> Open as Layers

## Layers
* Right (Group) [Mode: Screen] {link}
    * Cyan [Mode: Multiply] {link}
    * Right.jpg {move to calibrate}
* Left (Group) [Mode: Screen]
    * Red [Mode:  Multiply]
    * Left.jpg

## GIMP Techniques (Reminders)
* Within ‘Layers’ Tab
    * Create Right/Left Layer Groups
        * (right click) ‘New Layer Group’
        * (double click to rename) Right and Left
        * Merge Mode: Screen
    * Create Color Filter Layer
        * (right click) ‘New Layer’
        * Fill with RED
        * (right click - RED Layer) ‘Duplicate Layer’
        * Colors -> Invert (to make) Cyan Layer
        * Merge Mode: Multiply
* Calibrate your central point (where the red/cyan meet)
    * Cyan == invisible to right eye
    * Red == invisible to left eye
    * Cyan to the right of red == towards the screen
    * Red to the right of cyan == into the screen
* Move tool - move active layer (hold shift)
    * (ensure move tool is is `layer` rather than `selection`)

## References

* [Flickr Anaglyphic 3D Group](https://www.flickr.com/groups/365182@N21/)
* [How to make 3D images with GIMP](http://strakul.blogspot.co.uk/2012/03/how-to-make-3d-images-with-gimp.html)
* [Gimp Layer Modes](https://docs.gimp.org/en/gimp-concepts-layer-modes.html#layer-mode-multiply)
