# Assemblify
Platform for managing internal .Net assembly libraries.

This repo contains experimental code which I'm evaluating as the basis for an intranet based assembly publishing system.

Rather than uisng NuGet references and creating NuGet packages for our own internally generated assemblies that we have no intention of ever sharing, it is far simpler to just set project references to assemblies in a folder somewhere on the network. This code is intended to be the basis for this kind of system.

Publishing an assembly in a system like this will simply mean right-click on a VS project (in VS) and choosing "Assemblify -> Publish", the system will then copy the project's DLL to the designated assemblify root folder.

Consuming an assembly will consists of simply uisng the "Add Reference" dialog in VS and browing the assemblify folder and selecting the desired assembly.

Naturally a VS extension is called for sooner or later.

By supporting assembly level attributes too, we can simplify the workflow somewhat when it comes to publishing assemblies.
