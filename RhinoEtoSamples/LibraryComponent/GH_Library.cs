using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Commands;
using Rhino;
using Rhino.Geometry;
using Rhino.UI;

namespace RhinoEtoSamples.SettingsDummy
{

    


    public class GH_Library : GH_Component
    {
        /// <summary>
        /// Entries in the library
        /// </summary>
        public List<Entry> Entries = new List<Entry>();


        /// <summary>
        /// Initializes a new instance of the OpenSettings class.
        /// </summary>
        public GH_Library()
          : base("OpenSettings", "OpenSettings",
              "Right click me to open a settings dialog\nBased on the CsSamplesEtoCoffee example and the CsCollabsiblePanel example",
              "RhinoEtosExamples", "RhinoEtosExamples")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Entries", "Entries", "Entries", GH_ParamAccess.list);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("D2016527-9309-489E-AF1C-3441AEE849B9"); }
        }

        public override void AppendAdditionalMenuItems(System.Windows.Forms.ToolStripDropDown menu)
        {
            base.AppendAdditionalMenuItems(menu);
        }


        public Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            var form = new CollapsibleSectionUIPanel();
            var rc = form.ShowModal(RhinoEtoApp.MainWindow);
            return rc;
        }


    }
}