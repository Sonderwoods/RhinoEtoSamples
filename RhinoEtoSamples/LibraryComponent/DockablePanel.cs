using System;
using Rhino;
using Rhino.Commands;
using Rhino.UI.Controls;
using Eto.Forms;
using Project;

namespace RhinoEtoSamples.SettingsDummy
{
    /// <summary>
    /// This is the user control that is buried in the tabbed, docking panel.
    /// </summary>
    [System.Runtime.InteropServices.Guid("1EE73599-4DC8-471F-A729-774A57524FB7")]
    public class CollapsibleSectionUIPanel : Dialog<Rhino.Commands.Result>
    {

        /// <summary>
        /// Returns the ID of this panel.
        /// </summary>
        public static Guid PanelId
        {
            get
            {
                return typeof(CollapsibleSectionUIPanel).GUID;
            }
        }

        /// <summary>
        /// Public constructor
        /// </summary>
        public CollapsibleSectionUIPanel()
        {
            InitializeComponents();
            InitializeLayout();
        }

        private void InitializeComponents()
        {

        }


        private void InitializeLayout()
        {
            // Create holder for sections. The holder can expand/collaps sections and
            // displays a title for each section
            EtoCollapsibleSectionHolder holder = new EtoCollapsibleSectionHolder();

            // Create two sections
            SectionOne section1 = new SectionOne();
            SectionTwo section2 = new SectionTwo();

            // Populate the holder with sections
            holder.Add(section1);
            holder.Add(section2);


            DefaultButton = new Button { Text = "OK" };
            DefaultButton.Click += (sender, e) => Close(Rhino.Commands.Result.Success);

            AbortButton = new Button { Text = "C&ancel" };
            AbortButton.Click += (sender, e) => Close(Rhino.Commands.Result.Cancel);

            // Create a tablelayout that contains the holder and add it to the UI
            // Content
            TableLayout tableLayout = new TableLayout()
            {
                Rows =
                {
                    holder,
                    new TableRow(DefaultButton, AbortButton)
                }
            };

            Content = tableLayout;
        }
    }
}
