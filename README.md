# VP-Unpack

Intended to unpack Viva Pinata (also Viva Pinata: Trouble in Paradise, Viva Pinata (Xbox Edition), and Banjo Kazooie: Nuts and Bolts (in the future)) files.
Specifially the .pkg archive format.

So far the only functionality is to extract (some) of these .pkg files into their component files:

(All files contained in a .pkg have custom extensions made by me)

- .pkg is a wrapper for each sub-file (.caff, output folders will be named as such). .caff (should, see issues below) contain a multiple of 4 of compressed xlib streams.

  - .vref (Contains references to the other files. Starts with an index to the name of each object, then after the string block there's an indexed list for the objects,
  containing the offset, size, and file indicator for said object.)
  
  - .vnfo (Contains information for each object. Namely animation data, model vertex/face count, shader info, possibly more "major" info, and other references.)

  - .vdat (Contains model, texture, and possibly other raw data types. Models are structured into vertex data, then face data. Textures are .dds format (possible .png as well?).

  - .vunk (Unknown data, appears to be offsets. Have yet to find any link to any internal or external file)
  
Usage:
 
- Open solution.
- Build (Delete the ModelExtract and ProcessInfo files if present).
- Copy the VPPC_OFFSETS.xml from the solution folder to your program root (my bad, will automate this later).
- Open program.
- Set your paths in the Settings window.
- Select a .pkg (only Viva Pinata (PC) at this time).
- It will then try to extract to your specificed output path.
- If it works, congrats. If it failed then either the info in the .xml file is wrong, or it's just one of my many screw-ups :)
- Happy exploring.
  
Issues:
 
- The multiple of 4 rules seems to break in some areas, since I cannot find a way to identify each vfile from it's contents alone, manual input of the stream offsets must be
   input into the offsets .xml. This is a very poor solution as there's just far too many streams to sort through by even 10 people.
   
- Manual additions to the .xml are tedious. Currently you must generate an MD5 has of each .pkg file and add each stream offset (I have been using a program called "Offzip" to
   get the offsets (Offzip is made by Luigi Auriemma, you can get it here: https://aluigi.altervista.org/mytoolz.htm). 
   
- Parsing the vfiles is manually easy, due to the lack of info gathered from how the .exe reads these files leaves massive gaps for it to be automated by this program. Simple
   things like the length of the string block index in .vref is a challenge to parse.
   
- Model extraction is again manually easy, simply count the length of each vertex data section (this can vary depending on what additional info is present, find the coordinates,
   UV coordinates, and then read through the face data. Automated this is tricky because the vertex/face info is back in the .vnfo file, I've yet to nail down the exact structure
   of this to reliably get to the offset/size/structure type (for vertex data).
   
- Textures are thankfully able to be automated. Since the .vref file gives the offset and size of these blocks it's simply a matter jumping over the tacked on head to the data,
   then dumping the full .dds file. There seems to be either different types of files that match my texture extraction portion of code(not yet implemented), or there's a bug
   somewhere in that code that generates false positives.
   
- Animations are still unknown. The info is present in the .vnfo, but I've yet to correlate any of it to it's matching model.
