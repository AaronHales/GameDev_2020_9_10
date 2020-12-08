using System;
using Tunes;

public namespace Album
{
    public class ArtWork
    {
        
    }
    public class Song
    {
        Music track1 = new Music();

        Console.writeLine(track1.note);
    }

    public class Track_list
    {
        String[] trackList = new String[10];
        trackList[0] = "Deep Stone Lullaby";
        trackList[1] = "Fallen Empire";
        trackList[2] = "Beyond Light";
        trackList[3] = "Buried Secrets";
        trackList[4] = "Europa";
        trackList[5] = "Second Thoughts";
        trackList[6] = "Lament";
        trackList[7] = "Look Within";
        trackList[8] = "Whiteout";
        trackList[9] = "Stay Down";
        trackList[10] = "Forbidden Knowledge";
    }
    
}