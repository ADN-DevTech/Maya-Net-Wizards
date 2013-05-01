using System;
using Autodesk.Maya.Runtime;
using Autodesk.Maya.OpenMaya;

// This line is mandatory to declare a new node type in Maya
// You need to change the last 2 parameters with your own
// node name and unique ID
// Unique node ID can be obtain on http://www.autodesk.com/developmaya
#error You need to change the Node name and Unique ID below before continuing, then remove this line.
[assembly: MPxNodeClass(typeof($rootnamespace$.$safeitemrootname$), "$safeitemrootname$", 0x00000001)]

namespace $rootnamespace$
{
	// This class is instantiated by Maya for each node created in a Maya
	// scene.
	public class $safeitemrootname$ : MPxNode, IMPxNode
	{

		// Declare input and output attributes
		[MPxNodeNumeric("in", "input", MFnNumericData.Type.kFloat, Storable = true)]
		public static MObject input = null;

		[MPxNodeNumeric("out", "output", MFnNumericData.Type.kFloat, Storable = false, Writable = false)]
		[MPxNodeAffectedBy("input")]
		public static MObject output = null;

		override public bool compute(MPlug plug, MDataBlock dataBlock)
		{
			if ( plug.attribute.equalEqual(output) ) {
				// Put your Node output attribute code here
				// ...

				// Tell Maya you handled the plug and the plug value is now up to date.
				dataBlock.setClean(plug);
				return true;
			}
			return false;
		}

	}

}
