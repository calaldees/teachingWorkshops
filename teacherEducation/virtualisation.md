Virtualisation
--------------

School computers are often managed machines. Students are unable to install new tools. 
This makes computing teaching problematic as you constantly need to experiment with a range of tools.
Students also need network access to run their own servers/ports.
If you as a teacher were in control and managed the base VM image, you could install new tools as-and-when needed.

* This task is to
    * Give you experience of virtualisation (if you have not done this before)
    * Show you have a VM can give your teaching flexibility with installing _libraries_ and other support tools
    * (If you are not familiar with VM's I suggest this is a skill that you develop and investigate. Get as far as you can)
    * (extension) check the extension below if you're hardcore enough

* Download [Ubuntu Desktop iso](https://ubuntu.com/download/desktop/) (3GB)
    * I suggested ubuntu as it has out of the box vm guest integration. You can use another variant should you wish.
* Setup a linux VM from your image
    * Suggest [VirtualBox](https://www.virtualbox.org/) or [HyperV](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v)
        * Or other virtualisation software of your choice.
    * Gotchas
        * `vt-x` may need to be [enable in your bios](https://2nwiki.2n.cz/pages/viewpage.action?pageId=75202968)
        * HyperV may need to be [installed/activated](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v) 
            * Note that HyperV is not available on Windows 10 "Home" (only in pro/enterprise/education).
* Attempt to run the following `python` program
    * You should be able to launch a terminal
        * If you don't know your way around a bash prompt I strongly advise you to learn the basics
    * ?You may need to install `python3-pip` for your distribution. (`sudo apt-get update && sudo apt-get install python3-pip`)
    * ```bash
        curl -O "https://raw.githubusercontent.com/calaldees/TeachProgramming/master/teachprogramming/static/projects/data/elavation.py"
        curl -O "http://shadedrelief.com/natural3/ne3_data/8192/elev_bump_8k.jpg"
        pip3 install pillow
        python3 elavation.py
      ```
    * you can read the code at [elavation.py](https://github.com/calaldees/TeachProgramming/blob/master/teachprogramming/static/projects/data/elavation.py)

* (extension) for the hardcore - These are discussions to have with your school technicians
    * Consider a VM solution that would allow a student to take a VM on a USB3 stick between home and school. What tools would need to be installed. How quickly/simply could this VHD be mounted/used? any tech ideas?
    * Consider VM's starting up with 2 network adaptors
        1. A NAT network adaptor for general internet access and package downloads
        2. A bridged network device on a separate subnet. 
        * Could this be done? Could a class set of VM's have unfiltered access to this subnet. That way students could run their own web-servers/port-scanners without affecting the real school network. What would this configuration look like?
    * If you were to create a base VM image, how would this be distributed around the network/school machines? Would the binary image be deployed to all machines overnight? Would each machine just mount a network image and use some filesystem layer to store data deltas on the local machine?
