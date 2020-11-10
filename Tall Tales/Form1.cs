using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tall_Tales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void story_bttn_Click(object sender, EventArgs e)
        {
            //  Clear the text in the FinalStoryText text box.
            final_story_txt.Text = "";
            //  Write the first line of text to our Final Story.
            string my_story_text = "Once upon a  time, there was a ";

            //  Append  current value in  SpeciesComboBox to  end of the text
            my_story_text += species_cb.Text;

            //Write the next line in our story, appending the activity chosen  
            // by the user in  the Activity list.
            my_story_text += " named " + name_txt_box.Text + ". ";

            //Write the next line in our story, appending the activity chosen  
            // by the user in  the Activity list.
            my_story_text += "This creature was always " + activity_list.Text;
            //  Check to see if the user has selected the first checkbox.
            if (checkBox1.Checked == true)
            {
                //  If the third checkbox is checked, add 'and ' and the text 
                //  that was selected.
                my_story_text += " and  " + checkBox1.Text;
            }

            //  Check to see if the user has selected the second checkbox.
            if (checkBox2.Checked == true)
            {
                //  If the third checkbox is checked, add 'and ' and the text 
                //  that was selected.
                my_story_text += " and  " + checkBox2.Text;
            }

            //  Check to see if the user has selected the third checkbox.
            if (checkBox3.Checked == true)
            {
                //  If the third checkbox is checked, add 'and ' and the text 
                //  that was selected.
                my_story_text += " and  " + checkBox3.Text;
            }

            //  Write the next line in our story.
            my_story_text += ". One day this creature saw a ";
            //  Check to see which RadioButton was selected by the user.
            if (radioButton1.Checked == true)
            {
                // If  first RadioButton is selected, add  its text to  story.
                my_story_text += radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                //  If  second RadioButton is selected, add its text to  story.
                my_story_text += radioButton2.Text;
            }

            else if (radioButton3.Checked == true)
            {
                //  If  third RadioButton is selected, add its text to  story.
                my_story_text += radioButton3.Text;
            }
            //  Write the final line of our story, appending  user's choice of 
            //  either 'good' or 'bad' from the GoodBadList listbox.
            my_story_text += "This was a " + good_bad_list.Text + " day.";

            //  update our output text box with the final story string
            final_story_txt.Text = my_story_text;
        }
    }
}
