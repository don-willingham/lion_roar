#!/usr/bin/perl
# Perl script to listen on a serial port for "Motion detected!" from
# an Arduino running a sketch from
# https://learn.adafruit.com/pir-passive-infrared-proximity-motion-sensor/using-a-pir
# When motion is detected, it will play a lion roar sound.
# Perl script borrowed serial input code from
# http://stackoverflow.com/questions/11365111/newbie-perl-serial-programming
use strict;

use warnings;
use Device::SerialPort;

my $secondsBetweenRoar = 300; # Limit the number of roars
my $lastRoar = time() - $secondsBetweenRoar; # Assume
                              # the lion roared a duration ago
my $serialPort = "/dev/ttyACM0";
my $wav_file = "lion_roar.wav";
my $PortObj=Device::SerialPort->new($serialPort);
$PortObj->databits(8);
$PortObj->baudrate(9600);
$PortObj->parity("none");
$PortObj->stopbits(1);
$PortObj->handshake("none");

$|++; # Disable output buffering
      # http://www.perlmonks.org/?node_id=280025

my $line = "";
while( 1 ){
   my ($count,$saw)=$PortObj->read(1);
   if ($count > 0) {
      # Append new character to line
      $line .= $saw;
      # If line includes a newline at the end
      if ($saw =~ /\n$/) {
         if ($line =~ /^Motion\ detected/i) {
            # Get time now, and compute time since roar
            my $timeNow = time();
            my $timeDiff = $timeNow - $lastRoar;
            # If we've waited long enough
            if ($timeDiff > $secondsBetweenRoar) {
               # Update last roar time
               $lastRoar = $timeNow;
               # Play sound
               system("aplay ".$wav_file);
            } else {
               # Report motion, but how much longer before another roar
               print "\nWait another ".($secondsBetweenRoar-$timeDiff).
                     "seconds";
            }
         }
         # Reset line
         $line = "";
      }
   } else {
      print ".";
      # Throttle it
      sleep 1;
   }
}
