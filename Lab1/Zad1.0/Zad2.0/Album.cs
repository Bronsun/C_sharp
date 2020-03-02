using System;

namespace Zad2._0{

class Album{
        ////Tworzenie konstruktora, który umozliwy nam dopisywanie parametrow do naszej klasy/////////
    public Album(){
        album_ = "Unkonwn"; 
        artist_ = "Unknown";
        date_=0;
        track_=0;
        licznik_++;
        }
    public Album(string album_,int date_)
    {
        this.album_=album_;
        this.date_=date_;
        licznik_++;
    }
    public Album(int track_)
    {
        if (track_<0){
            Console.WriteLine("The number of tracks is wrong");
        }else{
            this.track_=track_;
            licznik_++;
        }
    }
    private string album_,artist_;
    public string albumName{
        get{return album_;}
        set{album_=value;}
    }
    public string artistName{
        get{return artist_;}
        set{artist_=value;}
    }

    private int date_, track_;
    public int date{
        get{return date_;}
        set{date_=value;}
    }
    public int numberOfTracks{
        get{return track_;}
        set{track_=value;}

    }
    public static int licznik_;

    public void ShowAlbumInfo(){


         Console.WriteLine("Album: " + albumName + " Artist:" + artistName + " :date(" + date + ")\n" + "nr.track:" + numberOfTracks);
        }



        public static int HowManyAlbums(){return licznik_;}
        public static int ClearAlbumCounter(){ return licznik_ =0;}
    }
    
    

}
