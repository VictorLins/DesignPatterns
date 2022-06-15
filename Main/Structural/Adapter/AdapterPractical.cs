namespace Main.Adapter
{
    public static class AdapterPractical
    {
        public static void Execute()
        {
            MediaPlayer lMediaPlayer = new MediaPlayer();
            lMediaPlayer.Play("C:\\FolderA\\FileA.mp4");

            lMediaPlayer = new VideoPlayerAdapter();
            lMediaPlayer.Play("C:\\FolderA\\FileA.mp4");
            lMediaPlayer.Play("C:\\FolderA\\FileB.flv");

            lMediaPlayer = new AudioPlayerAdapter();
            lMediaPlayer.Play("C:\\FolderA\\FileC.mp3");
            lMediaPlayer.Play("C:\\FolderA\\FileD.aac");
            lMediaPlayer.Play("C:\\FolderA\\FileE.oog");
        }
    }

    public class MediaPlayer
    {
        public virtual void Play(String prFile)
        {
            Console.WriteLine("MediaPlayer - Media Player Unknown...");
        }
    }

    public class VideoPlayerAdapter : MediaPlayer
    {
        private VideoPlayerLibrary _VideoPlayerLibrary = new VideoPlayerLibrary();

        public override void Play(String prFile)
        {
            string lExtension = prFile.Substring(prFile.Length - 3);

            switch (lExtension.ToUpper())
            {
                case "AVI":
                    _VideoPlayerLibrary.PlayAVIFile(prFile);
                    break;
                case "MP4":
                    _VideoPlayerLibrary.PlayMP4File(prFile);
                    break;
                case "FLV":
                    _VideoPlayerLibrary.PlayFLVFile(prFile);
                    break;
                default:
                    Console.WriteLine("VideoPlayerAdapter - Video Format Not Supported...");
                    break;
            }
        }
    }

    public class AudioPlayerAdapter : MediaPlayer
    {
        private AudioPlayerLibrary _AudioPlayerLibrary = new AudioPlayerLibrary();

        public override void Play(String prFile)
        {
            string lExtension = prFile.Substring(prFile.Length - 3);

            switch (lExtension.ToUpper())
            {
                case "MP3":
                    _AudioPlayerLibrary.PlayMP3File(prFile);
                    break;
                case "AAC":
                    _AudioPlayerLibrary.PlayAACFile(prFile);
                    break;
                default:
                    Console.WriteLine("AudioPlayerAdapter - Audio Format Not Supported...");
                    break;
            }
        }
    }

    public class VideoPlayerLibrary
    {
        public void PlayAVIFile(String prFile) { Console.WriteLine("VideoPlayerLibrary - Playing AVI File..."); }
        public void PlayMP4File(String prFile) { Console.WriteLine("VideoPlayerLibrary - Playing MP4 File..."); }
        public void PlayFLVFile(String prFile) { Console.WriteLine("VideoPlayerLibrary - Playing FLV File..."); }
    }

    public class AudioPlayerLibrary
    {
        public void PlayMP3File(String prFile) { Console.WriteLine("AudioPlayerLibrary - Playing MP3 File..."); }
        public void PlayAACFile(String prFile) { Console.WriteLine("AudioPlayerLibrary - Playing AAC File..."); }
    }
}