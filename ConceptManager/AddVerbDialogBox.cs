
//VisualStudio supplied
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConceptManager
{
    /// <summary>
    /// Dialog box to add a verb
    /// </summary>
    public partial class AddVerbDialogBox : Form
    {
        private static Verb ve;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVerbDialogBox" /> class.
        /// </summary>
        public AddVerbDialogBox(Verb v)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;

            ve = v;
            ve.type = VerbType.none;

            messageIcon.Image = System.Drawing.SystemIcons.Question.ToBitmap();
            knownInformation.Text = string.Format("'{0}' is a {1} person {2}, {3} tense verb.\r\n\r\nPlease select its type !", v.spelling, v.person.ToString(), v.form.ToString(), v.tense.ToString());
        }

        /// <summary>
        /// Returns a Verb
        /// </summary>
        /// <returns>The verb that is being added</returns>
        public static Verb v()
        {
            return ve;
        }


        private void actionVerb_CheckedChanged(object sender, EventArgs e)
        {
            ve.type = VerbType.action;
        }

        private void linkingVerb_CheckedChanged(object sender, EventArgs e)
        {
            ve.type = VerbType.linking;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ve.type != VerbType.none)
            {
                this.Close();
            }
            else
            {
                this.errorNoSelection.SetError(this.verbTypeGroupBox, "Please select a type !");
            }
        }
    }
}
