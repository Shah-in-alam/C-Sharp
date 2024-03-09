using System;


namespace Spotify
{
    public class Program
    {
        static void Main(string[] args)
        {
            Artist Justin = new Artist("Justin Bieber", Genres.Pop);
            Artist Dua = new Artist("Dua Lipa", Genres.Pop);
            Artist Drake = new Artist("Drake", Genres.Rap);
            Artist JLO = new Artist("Jennifer Lopez", Genres.Pop);
            Artist Tayler = new Artist("Taylor Swift", Genres.Pop);
            Artist Skrillex = new Artist("Skrillex", Genres.Dubstep);
            Artist Metallica = new Artist("Metallica", Genres.Metal);
            Artist Billie = new Artist("Billie Eilish", Genres.Pop);

            Justin.AddAlbum();
            Dua.AddAlbum();
            Drake.RemoveAlbum();


            List<Artist> artists = new List<Artist>();
            artists.Add(Justin);
            artists.Add(Dua);
            artists.Add(Drake);
            artists.Add(JLO);
            artists.Add(Tayler);
            artists.Add(Skrillex);
            artists.Add(Metallica);
            artists.Add(Billie);

            foreach (Artist artist in artists) 
            {
                Console.WriteLine(artist);
            }

            Song sorry = new Song("Sorry", Justin, Genres.Pop, 2000);
            Song onekiss = new Song("One kiss", Dua, Genres.Pop, 3000);
            Song hotlineBling = new Song("Hotline Bling", Drake, Genres.Pop, 4000);
            Song onthefloor = new Song("On the floor", JLO, Genres.Pop, 5000);
            Song shakeitoff = new Song("Shake it off", Tayler, Genres.Pop, 6000);
            Song one = new Song("One", Metallica, Genres.Metal, 7000);
            Song bangerang = new Song("Bangerang", Skrillex, Genres.Dubstep, 8000);
            Song badguy = new Song("Bad Guy", Billie, Genres.Pop, 9000); 
            
            

            List<Song> Songs = new List<Song>();
            Songs.Add(sorry);
            Songs.Add(onekiss);
            Songs.Add(hotlineBling);
            Songs.Add(onthefloor);
            Songs.Add(shakeitoff);
            Songs.Add(one);
            Songs.Add(bangerang);
            Songs.Add(badguy);


            //foreach (var item  in Artists)
            {
               // item.Play();
            }//

            playlist DSPS = new playlist("Dsps",Songs);
            playlist MyFav = new playlist("MyFav", Songs);

            Console.WriteLine(DSPS);
            Console.WriteLine(MyFav);
            DSPS.Play();
            MyFav.Play();

        }
        
    }
}
