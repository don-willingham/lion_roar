
Play a lion roar sound when motion is detected from an attached PIR sensor on an Arduino.

**Why?** Because a coworker 3d printed a [Hairy Lion](http://www.thingiverse.com/thing:2007221), and he could use a voice!

**Where** is lion_roar.wav... that's not included. I don't own the copyright to a lion roaring sound. You could use the sound from [MGM Logo 3 Roar 2008 Restoration](https://www.youtube.com/watch?v=OVCxJ1aT24A).  Maybe I'll find something 'free' (Creative Commons) and include that.

**Hardware** I used an Arduino Uno [clone](https://www.amazon.com/gp/product/B01EWOE0UU/ref=oh_aui_detailpage_o00_s00?ie=UTF8&psc=1) and a (single) [OSOYOO HC-SR501 PIR sensor](https://www.amazon.com/gp/product/B011NV1QT8/ref=oh_aui_detailpage_o03_s00?ie=UTF8&psc=1), (link is to a 5 pack)

**Setup** I connected the PIR to pin-2, power, and ground per [Adafruit's using a PIR](https://learn.adafruit.com/pir-passive-infrared-proximity-motion-sensor/using-a-pir). Then either run the perl script or build the C# solution.
  * Perl: The original prototype is written in Perl. I needed to run "cpan install Device::SerialPort" on my Fedora 24 system. It also requires "aplay", which is part of the "alsa-utils" package.
  * C#: I rewrote it again, in C#, which could be more user friendly, is it doesn't call an external application. Drop a lion_roar.wav into charp/LionRoar/ subdirectory, then build the LionRoar.sln, and run it, ensure correct COM port is selected, and click Start.
