using System;
using Autodesk.Maya.OpenMaya;

// This line is mandatory to declare a new command in Maya
// You need to change the last parameter without your own
// node name and unique ID
#warning You need to change the Command name before continuing, then remove this line.
[assembly: MPxCommandClass(typeof($safeprojectname$.MyCommand), "MyCommand")]

namespace $safeprojectname$
{
	// This class is instantiated by Maya each time when a command 
	// is called by the user or a script.
	public class MyCommand : MPxCommand, IMPxCommand
	{

		public override void doIt (MArgList argl)
		{
			MGlobal.displayInfo ("Hello World\n") ;
			// Put your command code here
			// ...

		}

	}

}
