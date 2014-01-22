Maya-Net-Wizards
================

A Maya C# Wizards for Wizards for Visual Studio

The plug-in wizard for the Maya .NET SDK simplifies the construction of Maya plug-ins by providing a project template and class templates for defining: 
- Command plug-ins with support for undo/redo  
- Command plug-ins without support for undo/redo  
- DAG node plug-ins  


Written by Cyrille Fauvel (Autodesk Developer Network)  
http://www.autodesk.com/adn  
http://around-the-corner.typepad.com/  

1) Visual Studio Install
------------------------
- copy the 'Maya CSharp plug-in.zip' to the 
'&lt;current user&gt;/Documents/Visual Studio 2010/Templates/ProjectTemplates/Visual C#' directory.  
- copy the 'Maya CSharp Command with Undo.zip', 'Maya CSharp Command.zip', and 'Maya CSharp Node.zip' files 
to the '&lt;current user&gt;/Documents/Visual Studio 2010/Templates/ItemTemplates/Visual C#' directory.  

2) In Visual Studio, do as follows
----------------------------------
- create a C# project, and select the Maya C# plug-in option.  
- right-click the project to select Add > Class, and select among three options: 
  - Maya C# Command  
  - Maya C# Command with Undo Support  
  - Maya C# Node  

a Wix/MSI installer project will be coming soon

<b>Note:</b> Maya 2014 requires using the VC 10.0 Service Pack 1 runtime and the .Net Framework 4.0. You can use Visual Studio 2012 to develop C# plug-ins, but have to use the .Net 4.0 framework.
