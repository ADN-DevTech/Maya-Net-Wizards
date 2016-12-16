Copyright (c) Autodesk, Inc. All rights reserved 

Maya .Net API C# Wizards
by Cyrille Fauvel - Autodesk Developer Network (ADN)
January 2014

Permission to use, copy, modify, and distribute this software in
object code form for any purpose and without fee is hereby granted, 
provided that the above copyright notice appears in all copies and 
that both that copyright notice and the limited warranty and
restricted rights notice below appear in all supporting 
documentation.

AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS. 
AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC. 
DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
UNINTERRUPTED OR ERROR FREE.
 
 Maya-Net-Wizards
================

A set of Maya API C# Wizards for Visual Studio

The plug-in wizard for the Maya .NET API simplifies the construction of Maya plug-ins by providing a project template and class templates for defining: 
- Command plug-ins with support for undo/redo  
- Command plug-ins without support for undo/redo  
- DAG node plug-ins  


Written by Cyrille Fauvel (Autodesk Developer Network)
Maintained by Zhong Wu(Autodesk Developer Network)
http://www.autodesk.com/adn  
http://around-the-corner.typepad.com/  


1) Visual Studio Install
------------------------
- copy the 'Maya CSharp plug-in.zip' to the 
'&lt;current user&gt;/Documents/Visual Studio 2012/Templates/ProjectTemplates/Visual C#' directory.  
- copy the 'Maya CSharp Command with Undo.zip', 'Maya CSharp Command.zip', and 'Maya CSharp Node.zip' files 
to the '&lt;current user&gt;/Documents/Visual Studio 2012/Templates/ItemTemplates/Visual C#' directory.  

2) In Visual Studio, do as follows
----------------------------------
- create a C# project, and select the Maya C# plug-in option.  
- right-click the project to select Add > Class, and select among three options: 
  - Maya C# Command  
  - Maya C# Command with Undo Support  
  - Maya C# Node  

a Wix/MSI installer project will be coming soon

<b>Note:</b> 
- The latest plug-in wizard for the Maya .NET API is updated for Visual Studio 2012, and work for Maya 2015, 2016 and 2017. 
- Maya 2014 requires using the VC 10.0 Service Pack 1 runtime and the .Net Framework 4.0. You can use Visual Studio 2012 to develop C# plug-ins, but have to use the .Net 4.0 framework.
