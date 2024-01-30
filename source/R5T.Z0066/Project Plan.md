# R5T.Z0066
Examples values for all purposes (strictly-framework typed). (netstandard2.1)


## Allowed dependencies

No functionality it allowed, just values.

* R5T.Y0006 - Common .NET documentation instances.
* R5T.T0131 - Values marker attribute.
* netstandard2.1


## How this library works

All values are strictly-framework typed (stringly-typed, etc.).
All values start out in a "Raw" values listing, and are then "Refined" into other values listings. Raw values are numbered (N###) for easy addition.
For example, a path "C:\Temp" will start out as Raw.IPaths.N001.
That path might then be forwarded as Raw.IWindowsPaths.N001, Raw.IRootedPaths.N001, IRootedPaths.C_Temp, IDirectoryPaths.C_Temp, IDirectoryPaths.NonDirectoryIndicated, IPaths.Example_NonDirectoryIndicated_DirectoryPath, etc.

Paths don't have to start in Raw.IPaths, but could start in Raw.IRootedPaths for example. However, values really should start in a raw values listing!

There will be pathological paths as well.

And not just paths, this library contains ALL example values, for any purpose. Directory names, file names, strings, date times, anything!

There are also value sets, as in IFilePathSets. These should also start raw (Raw.IFilePathSets.N001), and are of array type.

Instance sets contain public _Raw and _Pathological listings, public since they are more specific. The Raw and Pathological listings themselves might contain a _FileNames: Z0066.IFileNames, but those are private since they are more general (avoids crazy loops like FileNames.\_Pathological.\_Raw.\_FileNames.\_Pathological... at least publicly).


## Notes

Raw value instance lists are numbed using the N### natter format. Three digits is acceptable (I'll figure out what to do when 1000 values are reached...)
*** Numbering should be STRICT *** in the raw value instance listings. No jumping to N100 just to indicate some qualitative information; save that for a separate raw listing or a forwarded refined listing.
Values are numbered for easy addition, but there is the risk of duplicates. A duplicate values tester script can be created later to worry about duplicates.


## External projects

* [Bogus](https://github.com/bchavez/Bogus)


## Prior Work

* R5T.Z0046 - Strongly-typed (bad), and somewhat balkanized. Does not have a good raw-refined level of values organization.
* R5T.Z0004 - Strictly-framework typed, but no raw-refined breakdown.
* R5T.T0021.X0002 - Values are stored as static class constants, and accessed via the crazed old extension methods on extension method bases!
* R5T.Salamis.Private - Two random paths, but encased in nested static classes, and as R5T.T0017.PathDescriptor values.
* R5T.Salamis - The OG that started it all (well, with regards to paths).
