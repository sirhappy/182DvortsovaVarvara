using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	class VideoFiele
	{
		string _name;
		int _duration;
		int _quality;
		public VideoFiele(string name ,int duration,int quality)
		{
			_name = name;
			_duration = duration;
			_quality = quality;
		}
		public int Size
		{
			get { return Size; }
			set { Size = value; }
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
			char ch = (char)rnd.Next('a', 'z');
			
			string strstring = "";
			for (int i = 0; i < n; i++)
			{
				strstring += ch;
			}
			return strstring;
		}
		public static Random rnd = new Random();
		public static Random _char  = new Random();
		static void Main(string[] args)
		{
			int n = rnd.Next(5, 15);
			VideoFiele video = new VideoFiele("Video",rnd.Next(60,360),rnd.Next(100,1000));
			VideoFiele[] videos = new VideoFiele[n];
			for(int i = 0; i < videos.Length; i++)
			{
				videos[i] = new VideoFiele(RandomString(rnd.Next(2, 9)), rnd.Next(60, 360), rnd.Next(100, 1000));
			}
			for(int i = 0; i < videos.Length; i++)
			{
				if(videos[i].Size)
			}

			


		}
	}
}
