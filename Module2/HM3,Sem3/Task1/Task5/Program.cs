using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	class VideoFiele
	{
		string _name;//имя видео
		int _duration;//длительность в секундах
		int _quality;// качество видеофайла
		public VideoFiele(string name ,int duration,int quality)
		{
			_name = name;
			_duration = duration;
			_quality = quality;
		}
		public int Size//размер видеофайла
		{
			get { return _duration * _quality; }
		}
		public string GetInfo()
		{
			string res = $"name ={_name}, duration ={_duration},quality = {_quality}";
			return res;
		}
	}
	
	class Program
	{
		public static string RandomString(int n )
		{
			string strstring = "";
			for (int i = 0; i < n; i++)
			{
				strstring += (char)rnd.Next('a', 'z'); ;
			}
			return strstring;
		}
		public static Random rnd = new Random();
		public static Random _char  = new Random();
		static void Main(string[] args)
		{
			int n = rnd.Next(5, 15);
			VideoFiele video = new VideoFiele("Video",rnd.Next(60,360),rnd.Next(100,1000));//обьект видеофайл
			VideoFiele[] videos = new VideoFiele[n];//массив из обьектов типа Vidoefile

			for(int i = 0; i < videos.Length; i++)
			{
				videos[i] = new VideoFiele(RandomString(rnd.Next(2, 9)), rnd.Next(60, 360), rnd.Next(100, 1000));
			}
			
			for(int i = 0; i < videos.Length; i++)
			{
				if (videos[i].Size > video.Size)
				{
					Console.WriteLine(videos[i].GetInfo());
				}
			}
			Console.ReadLine();



		}
	}
}
