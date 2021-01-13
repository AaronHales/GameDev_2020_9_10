using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

/* TeenCoder: Windows Programming
   
   Song Player Application

   Copyright 2013 CompuScholar, Inc.
*/

namespace SongPlayer
{

    // This class is provided as part of the Activity Starter program.
    class Note
    {
        // Define common note frequencies
        public static int NOTE_C = 524;
        public static int NOTE_D = 594;
        public static int NOTE_E = 660;
        public static int NOTE_F = 698;
        public static int NOTE_G = 784;
        public static int NOTE_A = 880;
        public static int NOTE_B = 988;

        // Define common note durations (in milliseconds)
        public static int DURATION_WHOLE = 1600;
        public static int DURATION_HALF = 800;
        public static int DURATION_QUARTER = 400;
        public static int DURATION_EIGHTH = 200;
        public static int DURATION_REST = 1;

        // Declare the properties for this note
        public int Frequency;
        public int Duration;

        // This constructor requires the Frequency and Duration for this note
        public Note(int frequency, int duration)
        {
            Frequency = frequency;
            Duration = duration;
        }
    }

    // This class code is ADDED FOR ACTIVITY by the student
    class Song
    {
        // student code to implement the Song class goes here
        public string Name;
        public LinkedList<Note> Notes;

        public Song (String songName)
        {
            Name = songName;
            Notes = new LinkedList<Note>();
        }
        public void AddNote(int frequency, int duration)
        {
            Notes.AddLast(new Note(frequency, duration));
        }

        public void Play()
        {
            foreach (Note myNote in Notes)
            {
                Console.Beep(myNote.Frequency, myNote.Duration);
            }
        }
    }

}
