// Visual Studio supplied
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
    /// Encapsulates the home (Dashboard) for the application
    /// </summary>
    public partial class Dashboard : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dashboard" /> class.
        /// </summary>
        public Dashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Puts out a dialog box to ask for the definition of a word.
        /// </summary>
        /// <param name="v">The properties of the verb that is being added</param>
        public static void AddVerb(Verb v)
        {
            new AddVerbDialogBox(v).ShowDialog();
            Concepts.AddVerb(AddVerbDialogBox.v());
        }

        private void parseButton_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren()) return;
            try
            {
            var rval = new ParserInterface.ParserOutput();

            rval = ParserInterface.DoParse(sentenceTextBox.Text);
            sentenceTextBox.Text = rval.sentence;
            pennTreeListBox.DataSource = rval.Items;
            signatureTextBox.Text = rval.Signature;
            conceptTreeListBox.DataSource = ModelBuilder.DoSentence(rval.Signature, rval.T);
            }
            catch (InvalidOperationException ev)
            {
                MessageBox.Show(ev.Message);
            }    
        }

        private void sentenceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (sentenceTextBox.Text == "")
            {
                sentenceError.SetError(sentenceTextBox, "Please Provide a Sentence.");
                e.Cancel = true;
                return;
            }

            if (!sentenceTextBox.Text.EndsWith("."))
            {
                sentenceError.SetError(sentenceTextBox,"Sentence requires a period.");
                e.Cancel = true;
            }
        }

        private void sentenceTextBox_Leave(object sender, EventArgs e)
        {
            sentenceError.SetError(sentenceTextBox, "");
        }
    }
}
