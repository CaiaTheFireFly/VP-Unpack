# VP-Unpack

Intended to unpack files from some of the popular Rare games. Primarily Viva Pinata, but support will be added for: Viva Pinata: Trouble in Paradise, Viva Pinata (Xbox Edition), and Banjo Kazooie: Nuts and Bolts. Kameo Elements of Power appears to share similar file structure traits, so it may be added later down the line.

Currently work is being done on the .PKG archive format.

So far the only functionality is to extract the embedded files contained in the .PKG archives:

(All files contained in a .PKG have custom extensions made by me)

- .PKG is a wrapper for each sub-file (.CAFF, output folders will be named as such). .CAFF contains up to 4 compressed xlib streams.

  - .VREF (Contains references to the other files and offset/size data for additional streams. Starts with an index to the name of each object, then after the string block           there's an indexed list for the objects, containing the offset, size, and file indicator for said object).
  
  - .VDAT (Contains information for each object. Namely animation data, model vertex/face count, shader info, possibly more "major" info, and other references).

  - .VGPU (Contains model, texture, and possibly other raw data types. Models are structured into vertex data, then face data. Textures are .DDS format (possible .PNG as well).

  - .VLUT (Unknown data, appears to be offsets. At this time I'm speculating that it's used as a lookup table for quickly finding common data).
  
Usage:
 
- Open solution.
- Build (Delete the ModelExtract and ProcessInfo files if present).
- Open program.
- Set your paths in the Settings window.
- Select a .PKG (only Viva Pinata (PC) at this time). (Use the .PKG option under File, ignore Tools for the time being).
- View the names, offsets, and sizes of chunks within the .VDAT files for each .CAFF.
- Happy exploring.
  
Issues:
 
- Model extraction is manually easy, simply count the length of each vertex data section (this can vary depending on what additional info is present, find the coordinates,
   UV coordinates, and then read through the face data. Automated this is tricky because the vertex/face info is back in the .VDAT file, I've yet to nail down the exact            structure of this to reliably get to the offset/size/structure type (for vertex data).
   
- Textures are thankfully able to be automated. Since the .VREF file gives the offset and size of these blocks it's simply a matter jumping over the tacked on head to the data,
   then dumping the full .DDS file. Not yet implemented.
   
- Animations are still unknown. The info is present in the .VDAT, but I've yet to correlate any of it to it's matching model.
