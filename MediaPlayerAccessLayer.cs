using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using DPMediaPlayer;

namespace MusicDiskMaker
{
    public sealed class MediaPlayerAccessLayer
    {
		private static bool playingPlayList = false;
		private static DPMediaPlayer.DPMediaPlayer player;
		private static AlbumArtForm form = new AlbumArtForm();
		private static string[] libraryList = null;
		private static Random random = null;
		private static int songsPlayed = 0;
		private static int historyIndex = 0;
		private static List<int> history = new List<int>();

		private MediaPlayerAccessLayer()
		{
		}

		static MediaPlayerAccessLayer()
		{
			form.MediaControlClicked += new MediaControlEventHandler(form_MediaControlClicked);
		}


		static DPMediaPlayer.PlayListInfo[] GetPlayListsInfo()
		{
			return player.GetPlayListsInfo();
		}

		static void form_MediaControlClicked(string action)
		{
			switch (action)
			{
				case "Next" :
					player.PlayNext();
					//if (historyIndex < history.Count - 1)
					//{
					//    PlayPlayList(history[historyIndex++]);
					//}
					//else
					//{
					//    player.PlayPlayList();
					//}
					break;
				case "Previous" :
					player.PlayPrevious();
					break;
				case "Pause" :
					Player.Pause();
					break;
				case "Play" :
					Player.Play();
					break;
				case "VolumeUp" :
					player.VolumeUp();
					break;
				case "VolumeDown" :
					player.VolumeDown();
					break;
			}
		}


		public static DPMediaPlayer.DPMediaPlayer Player
		{
			get
			{
				if (player == null)
				{
					player = new DPMediaPlayer.DPMediaPlayer();
					player.MediaEnded += new DPMediaPlayer.PlayStateChangedEventHandler(player_MediaEnded);
					player.PlayerPlaying += new DPMediaPlayer.PlayerPlayingEventHandler(player_PlayerPlaying);
				}
				return player;
			}
		}

		static void player_PlayerPlaying(DPMediaPlayer.PlayerPlayingEventArgs args)
		{
			ID3Lib.TrackInfo trackinfo = new ID3Lib.TrackInfo(args.Url);
			form.DisplayNextTrack(new ID3Lib.TrackInfo(args.Url));
			form.Invoke(form.StartDurationCounter, new object[] { 
				args.Duration,
				args.DurationString,
				args.Url });
		}

		static void player_MediaEnded(object args)
		{
			if (playingPlayList)
			{
				player.PlayNext();
			}
			else
			{
				PlayNext();
			}
		}


		public static void SetRandomize(bool randomize)
		{
			player.Randomize = randomize;
		}

		private static void PlayNext()
		{
			int notFoundCounter = 0;
			if (libraryList != null && libraryList.Length > 0)
			{
				string filePath = libraryList[random.Next(libraryList.Length)];
				if (!File.Exists(filePath))
				{
					notFoundCounter++;
					if (notFoundCounter > 10)
					{
						throw new Exception("Too many files not found in PlayLibrary.");
					}
				}

				ID3Lib.TrackInfo info = null;
				int tryCount = 0;
				while (info == null)
				{
					tryCount++;
					if (tryCount > 10)
					{
						throw new Exception("Too many failures trying to get track information for next track.");
					}
					try
					{
						info = new ID3Lib.TrackInfo(filePath);
					}
					catch (IOException)
					{
					}
				}
				Player.Play(info.FilePath);
				form.Invoke(form.DisplayNextTrack, new object[] { info } );
				//Play(info);
			}
		}


		public static void ShowArt()
		{
			form.Show();
		}

		public static void Play(ID3Lib.TrackInfo trackInfo)
		{
			playingPlayList = false;

			if (File.Exists(trackInfo.FilePath))
			{
				Player.Play(trackInfo.FilePath);
			}
			else
			{
				throw new FileNotFoundException();
			}

			form.TrackInfo = trackInfo;
			form.Show();
		}


		public static void PlayPlayList(int listIndex)
		{
			player.PlayPlayList(listIndex);
		}


		public static void Play(string filePath)
		{
			ID3Lib.TrackInfo trackInfo = null;
			if (File.Exists(filePath))
			{
				trackInfo = new ID3Lib.TrackInfo(filePath);
				Play(trackInfo);
			}
			else
			{
				throw new FileNotFoundException();
			}

			if (trackInfo != null)
			{
				form.TrackInfo = trackInfo;
				form.Show();
			}
		}

		public static void PlayLibrary(string path)
		{
			if (!Directory.Exists(path))
			{
				throw new FileNotFoundException();
			}

			libraryList = Directory.GetFiles(path, "*.mp3", SearchOption.AllDirectories);
			random = new Random();
			Play(libraryList[random.Next(libraryList.Length)]);
		}


		internal static string GetCurrentPositionString()
		{
			return player.GetCurrentPositionString();
		}

		internal static double GetCurrentPosition()
		{
			return player.GetCurrentPosition();
		}

		internal static void PlayPlayList(DPMediaPlayer.PlayListInfo playListInfo, bool randomize)
		{
			playingPlayList = true;
			player.PlayPlayList(playListInfo, randomize);
		}
	}
}
