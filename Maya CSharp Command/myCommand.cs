using System;
using Autodesk.Maya.Runtime;
using Autodesk.Maya.OpenMaya;

// This line is mandatory to declare a new command in Maya
// You need to change the last parameter without your own
// node name and unique ID
#warning You may need to change the Command name before continuing, then remove this line.
[assembly: MPxCommandClass(typeof($rootnamespace$.$safeitemrootname$), "$safeitemrootname$")]

namespace $rootnamespace$
{
	// This class is instantiated by Maya each time when a command 
	// is called by the user or a script.
	public class $safeitemrootname$ : MPxCommand, IMPxCommand
	{

		override public void doIt(MArgList argl)
		{
			// Put your command code here
			// ...

		}

	}

}

