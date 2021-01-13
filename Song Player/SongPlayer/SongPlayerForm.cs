using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* TeenCoder: Windows Programming
   
   Song Player Application

   Copyright 2013 CompuScholar, Inc.
*/
/*
 *  C# Programming
 *  Aaron Hales
 *  Chapter 13 Activity
 *  Activity: Song Player
 *  1/5/21
 */
namespace SongPlayer
{
    public partial class SongPlayerForm : Form
    {
        // the form data consists of a list of songs
        LinkedList<Song> songs;

        // the constructor is provided complete as part of the activity starter
        public SongPlayerForm()
        {
            InitializeComponent();

            // fill out our songs array
            initializeSongs();

        }

        // This code is ADDED FOR ACTIVITY by the student
        private void initializeSongs()
        {
            songs = new LinkedList<Song>();

            Song s1 = new Song("Twinkle Twinkle");
            s1.AddNote(Note.NOTE_C, Note.DURATION_HALF);
            s1.AddNote(Note.NOTE_C, Note.DURATION_HALF);
            s1.AddNote(Note.NOTE_G, Note.DURATION_HALF);
            s1.AddNote(Note.NOTE_G, Note.DURATION_HALF);
            s1.AddNote(Note.NOTE_A, Note.DURATION_HALF);
            s1.AddNote(Note.NOTE_A, Note.DURATION_HALF);
            s1.AddNote(Note.NOTE_G, Note.DURATION_HALF);

            songs.AddLast(s1);  // add this song to our list
            SongListBox.Items.Add(s1.Name);  // add song name to list box


            Song s2 = new Song("Happy Birthday");
            s2.AddNote(Note.NOTE_C, Note.DURATION_QUARTER);
            s2.AddNote(Note.NOTE_C, Note.DURATION_QUARTER);
            s2.AddNote(Note.NOTE_D, Note.DURATION_HALF);
            s2.AddNote(Note.NOTE_C, Note.DURATION_HALF);
            s2.AddNote(Note.NOTE_F, Note.DURATION_HALF);
            s2.AddNote(Note.NOTE_E, Note.DURATION_WHOLE);

            songs.AddLast(s2);  // add this song to our list
            SongListBox.Items.Add(s2.Name);  // add song name to list box

            // song from web
            Song s3 = new Song("Don't You");
            s3.AddNote(Note.NOTE_D, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_G, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_G, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_F, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_G, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_A, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_G, Note.DURATION_HALF);
            s3.AddNote(Note.NOTE_A, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_A, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_G, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_G, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_A, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_G, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_G, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_A, Note.DURATION_REST);
            s3.AddNote(Note.NOTE_D, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_G, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_G, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_F, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_G, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_A, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_G, Note.DURATION_HALF);
            s3.AddNote(Note.NOTE_E, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_G, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_G, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_B, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_A, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_A, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_B, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_A, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_G, Note.DURATION_EIGHTH);
            s3.AddNote(Note.NOTE_G, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_G, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_A, Note.DURATION_REST);
            s3.AddNote(Note.NOTE_D, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_G, Note.DURATION_QUARTER);
            s3.AddNote(Note.NOTE_G, Note.DURATION_QUARTER);

            songs.AddLast(s3);
            SongListBox.Items.Add(s3.Name);

            // song my me
            Song s4 = new Song("The Most Garbage Song");
            s4.AddNote(Note.NOTE_A, Note.DURATION_QUARTER);
            s4.AddNote(Note.NOTE_A, Note.DURATION_QUARTER);
            s4.AddNote(Note.NOTE_F, Note.DURATION_QUARTER);
            s4.AddNote(Note.NOTE_F, Note.DURATION_QUARTER);
            s4.AddNote(Note.NOTE_C, Note.DURATION_QUARTER);
            s4.AddNote(Note.NOTE_C, Note.DURATION_QUARTER);
            s4.AddNote(Note.NOTE_B, Note.DURATION_REST);
            s4.AddNote(Note.NOTE_E, Note.DURATION_EIGHTH);
            s4.AddNote(Note.NOTE_G, Note.DURATION_QUARTER);
            s4.AddNote(Note.NOTE_A, Note.DURATION_HALF);
            s4.AddNote(Note.NOTE_B, Note.DURATION_WHOLE);
            s4.AddNote(Note.NOTE_A, Note.DURATION_EIGHTH);
            s4.AddNote(Note.NOTE_E, Note.DURATION_QUARTER);
            s4.AddNote(Note.NOTE_A, Note.DURATION_QUARTER);
            s4.AddNote(Note.NOTE_E, Note.DURATION_EIGHTH);
            s4.AddNote(Note.NOTE_G, Note.DURATION_EIGHTH);
            s4.AddNote(Note.NOTE_G, Note.DURATION_EIGHTH);
            s4.AddNote(Note.NOTE_G, Note.DURATION_EIGHTH);
            s4.AddNote(Note.NOTE_C, Note.DURATION_HALF);

            songs.AddLast(s4);
            SongListBox.Items.Add(s4.Name);
        }

        // This function is provided as part of the activity starter.
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // get the current selection index
            int selection = SongListBox.SelectedIndex;
            if (selection >= 0)
            {
                // get the selected song from the list
                Song s = songs.ElementAt(selection);

                // play the song
                Console.WriteLine(s.Name);
                s.Play();
                
            }

        }

        private void SongPlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
