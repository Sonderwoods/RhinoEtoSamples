using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace RhinoEtoSamples
{
    public class RhinoEtoSamplesInfo : GH_AssemblyInfo
    {
        public override string Name => "RhinoEtoSamples";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("6d312fa7-efe8-4dd4-b31a-b9327fb58a47");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}