# postage
Windows 7 C# program to show weight plus calculated postage and stamp count required

Stamps.com has a promotion which includes a free USB-based/powered scale but this comes tied with a montly subscription/membership program which is likely too expensive.  It's not unusual then to see these scales on the desks of people who can't calculate postage since they dropped the monthly program given the unnecessary cost.

![stampsdotcomscale](https://user-images.githubusercontent.com/15971213/26984664-1d33b5c4-4cf5-11e7-80e9-5d92fb96e09c.jpg)

This Windows application will return that functionality without incurring any cost.  It's a simple, Windows form app which displays the weight, calculated postage and indicates the number of stamps of each type minimally required by the US Postal Service for 1st Class envelopes.  It will additionally determine the rate for envelopes which are likely FLATS (larger envelopes) even though it can't technically see what type of envelope size was dropped onto the scale.  For this reason, it's important to note that an oversized large envelope less than 3.5 ounces can't be accurately calculated for postage; in this case you'd note the weight and manually make your own determination.  I have included the rate calculations as text on the display, however.  The upper useful range for this scale is about 14 ounces since you'd likely just use a flat-rate envelope at that point to save money.

## Interface
The scale is both connected via and powered by a USB cable to your computer.

Programmatic access to the USB interface here is using [mikeobrien/HidLibrary](https://github.com/mikeobrien/HidLibrary), a Windows DLL to serve up that functionality.  I've included the DLL here for ease-of-use.

There was also a useful C# class for handshaking to a digital scale and I'm using [nricciar/usb_scale](https://github.com/nricciar/usb_scale) for this without modifications.  Again, this is included in this repository.

## Dependencies
This was targeted to Windows 7 but it will likely work on anything newer.

The program is coded against the **.NET Framework 4.5.2** interface so if you don't already have this installed, [this link](https://www.microsoft.com/en-us/download/details.aspx?id=42643) will install it for you.

## Testing
I have laboriously tested every ounce between 0.0 and 14 ounces and it calculated things perfectly.  I was personally surprised to find that for years I've been putting too many stamps on envelopes so you would likely save some money if you are in a business which sends out mail on a frequent basis.

## Running the executable
I've included a production build for Windows, feel free to run this without compiling it.  If you attempt to build and that fails for whatever reason, note that you might have to `git fetch` again to re-pull the original files from the `bin\release` folder.

```
c:\programs> git clone --depth 1 https://github.com/OutsourcedGuru/postage
c:\programs> cd postage\postage\bin\release
c:\programs\postage\postage\bin\release> postage
```

![postage](https://user-images.githubusercontent.com/15971213/26986998-aa4c87b6-4cfe-11e7-9a30-fc75ae585186.jpg)

## Building
```
c:\programs> git clone --depth 1 https://github.com/OutsourcedGuru/postage.git
c:\programs> cd postage
c:\programs\postage> start postage.sln
# Verify that Production has been selected as the target and choose Build.  Everything in the BIN\release folder is
# distributed
c:\programs\postage> cd postage\bin\release
c:\programs\postage\postage\bin\release> postage
```

Make sure that nothing is on top of the scale when it is either turned on or plugged into the computer via its USB cable.  Either activity performs a [tare](https://en.wikipedia.org/wiki/Tare_weight) function to reset things to zero.
