using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Preston.Media
{
    internal class V1GenreCollection : List<V1GenreItem>
    {

        internal V1GenreCollection()
        {
            V1GenreItem[] genres = new V1GenreItem[] {
                new V1GenreItem(255, ""),
                new V1GenreItem(0, "Blues"),
                new V1GenreItem(1, "Classic Rock"),
                new V1GenreItem(2, "Country"),
                new V1GenreItem(3, "Dance"),
                new V1GenreItem(4, "Disco"),
                new V1GenreItem(5, "Funk"),
                new V1GenreItem(6, "Grunge"),
                new V1GenreItem(7, "Hip-Hop"),
                new V1GenreItem(8, "Jazz"),
                new V1GenreItem(9, "Metal"),
                new V1GenreItem(10, "New Age"),
                new V1GenreItem(11, "Oldies"),
                new V1GenreItem(12, "Other"),
                new V1GenreItem(13, "Pop"),
                new V1GenreItem(14, "R&B"),
                new V1GenreItem(15, "Rap"),
                new V1GenreItem(16, "Reggae"),
                new V1GenreItem(17, "Rock"),
                new V1GenreItem(18, "Techno"),
                new V1GenreItem(19, "Industrial"),
                new V1GenreItem(20, "Alternative"),
                new V1GenreItem(21, "Ska"),
                new V1GenreItem(22, "Death Metal"),
                new V1GenreItem(23, "Pranks"),
                new V1GenreItem(24, "Soundtrack"),
                new V1GenreItem(25, "Euro-Techno"),
                new V1GenreItem(26, "Ambient"),
                new V1GenreItem(27, "Trip-Hop"),
                new V1GenreItem(28, "Vocal"),
                new V1GenreItem(29, "Jazz+Funk"),
                new V1GenreItem(30, "Fusion"),
                new V1GenreItem(31, "Trance"),
                new V1GenreItem(32, "Classical"),
                new V1GenreItem(33, "Instrumental"),
                new V1GenreItem(34, "Acid"),
                new V1GenreItem(35, "House"),
                new V1GenreItem(36, "Game"),
                new V1GenreItem(37, "Sound Clip"),
                new V1GenreItem(38, "Gospel"),
                new V1GenreItem(39, "Noise"),
                new V1GenreItem(40, "AlternRock"),
                new V1GenreItem(41, "Bass"),
                new V1GenreItem(42, "Soul"),
                new V1GenreItem(43, "Punk"),
                new V1GenreItem(44, "Space"),
                new V1GenreItem(45, "Meditative"),
                new V1GenreItem(46, "Instrumental Pop"),
                new V1GenreItem(47, "Instrumental Rock"),
                new V1GenreItem(48, "Ethnic"),
                new V1GenreItem(49, "Gothic"),
                new V1GenreItem(50, "Darkwave"),
                new V1GenreItem(51, "Techno-Industrial"),
                new V1GenreItem(52, "Electronic"),
                new V1GenreItem(53, "Pop-Folk"),
                new V1GenreItem(54, "Eurodance"),
                new V1GenreItem(55, "Dream"),
                new V1GenreItem(56, "Southern Rock"),
                new V1GenreItem(57, "Comedy"),
                new V1GenreItem(58, "Cult"),
                new V1GenreItem(59, "Gangsta"),
                new V1GenreItem(60, "Top 40"),
                new V1GenreItem(61, "Christian Rap"),
                new V1GenreItem(62, "Pop/Funk"),
                new V1GenreItem(63, "Jungle"),
                new V1GenreItem(64, "Native American"),
                new V1GenreItem(65, "Cabaret"),
                new V1GenreItem(66, "New Wave"),
                new V1GenreItem(67, "Psychadelic"),
                new V1GenreItem(68, "Rave"),
                new V1GenreItem(69, "Showtunes"),
                new V1GenreItem(70, "Trailer"),
                new V1GenreItem(71, "Lo-Fi"),
                new V1GenreItem(72, "Tribal"),
                new V1GenreItem(73, "Acid Punk"),
                new V1GenreItem(74, "Acid Jazz"),
                new V1GenreItem(75, "Polka"),
                new V1GenreItem(76, "Retro"),
                new V1GenreItem(77, "Musical"),
                new V1GenreItem(78, "Rock & Roll"),
                new V1GenreItem(79, "Hard Rock"),
                new V1GenreItem(80, "Folk"),
                new V1GenreItem(81, "Folk-Rock"),
                new V1GenreItem(82, "National Folk"),
                new V1GenreItem(83, "Swing"),
                new V1GenreItem(84, "Fast Fusion"),
                new V1GenreItem(85, "Bebob"),
                new V1GenreItem(86, "Latin"),
                new V1GenreItem(87, "Revival"),
                new V1GenreItem(88, "Celtic"),
                new V1GenreItem(89, "Bluegrass"),
                new V1GenreItem(90, "Avantgarde"),
                new V1GenreItem(91, "Gothic Rock"),
                new V1GenreItem(92, "Progressive Rock"),
                new V1GenreItem(93, "Psychedelic Rock"),
                new V1GenreItem(94, "Symphonic Rock"),
                new V1GenreItem(95, "Slow Rock"),
                new V1GenreItem(96, "Big Band"),
                new V1GenreItem(97, "Chorus"),
                new V1GenreItem(98, "Easy Listening"),
                new V1GenreItem(99, "Acoustic"),
                new V1GenreItem(100, "Humour"),
                new V1GenreItem(101, "Speech"),
                new V1GenreItem(102, "Chanson"),
                new V1GenreItem(103, "Opera"),
                new V1GenreItem(104, "Chamber Music"),
                new V1GenreItem(105, "Sonata"),
                new V1GenreItem(106, "Symphony"),
                new V1GenreItem(107, "Booty Bass"),
                new V1GenreItem(108, "Primus"),
                new V1GenreItem(109, "Porn Groove"),
                new V1GenreItem(110, "Satire"),
                new V1GenreItem(111, "Slow Jam"),
                new V1GenreItem(112, "Club"),
                new V1GenreItem(113, "Tango"),
                new V1GenreItem(114, "Samba"),
                new V1GenreItem(115, "Folklore"),
                new V1GenreItem(116, "Ballad"),
                new V1GenreItem(117, "Power Ballad"),
                new V1GenreItem(118, "Rhythmic Soul"),
                new V1GenreItem(119, "Freestyle"),
                new V1GenreItem(120, "Duet"),
                new V1GenreItem(121, "Punk Rock"),
                new V1GenreItem(122, "Drum Solo"),
                new V1GenreItem(123, "A capella"),
                new V1GenreItem(124, "Euro-House"),
                new V1GenreItem(125, "Dance Hall")
            };

            this.AddRange(genres);
            this.Sort();
        }

        public V1GenreItem GetGenreItem(int genreId)
        {
            for (int count = 0; count < this.Count; count++)
            {
                if (this[count].GenreId == genreId)
                {
                    return this[count];
                }
            }

            return new V1GenreItem(255, "");
        }


    }
}
