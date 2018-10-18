using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ConvertWav
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Sound example program");
                Console.WriteLine("1: Display WAV info from file");
                Console.WriteLine("2: Convert from MP3 to WAV");
                Console.WriteLine("3: Convert from WAV to MP3");
                Console.WriteLine("4: Quit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Display WAV information");
                        Console.WriteLine("Please enter a file name (eg Alarm01.wav :");
                        ReadWav(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Convert from MP3 to WAV");
                        Console.WriteLine("Please enter a file name of the MP3 file (eg Alarm01.mp3) :");
                        string oldfile = Console.ReadLine();
                        Console.WriteLine("Please enter a file name of the WAV file (eg Alarm01.wav) :");
                        string newfile = Console.ReadLine();
                        LameMp3ToWav(oldfile, newfile);
                        break;
                    case 3:
                        Console.WriteLine("Convert from WAV to MP3");
                        Console.WriteLine("Please enter a file name of the WAV file (eg Alarm01.wav) :");
                        string ofile = Console.ReadLine();
                        Console.WriteLine("Please enter a file name of the MP3 file (eg Alarm01.mp3) :");
                        string nfile = Console.ReadLine();
                        LameWavToMp3(ofile, nfile);
                        break;
                    case 4:
                        loop = false;
                        break;
                }
            }
            while (loop);
        }

        private static void ReadWav(string wavFile)
        {
            // connect to the file
            Stream waveFileStream = File.OpenRead(wavFile);

            // set up the reader to read the file
            BinaryReader reader = new BinaryReader(waveFileStream);

            // read the header info of the wav file
            int chunkID = reader.ReadInt32();
            int fileSize = reader.ReadInt32();
            int riffType = reader.ReadInt32();
            int fmtID = reader.ReadInt32();
            int fmtSize = reader.ReadInt32();
            int fmtCode = reader.ReadInt16();
            int fmtChannels = reader.ReadInt16();
            int fmtSampleRate = reader.ReadInt32();
            int fmtAvgBPS = reader.ReadInt32();
            int fmtBlockAlign = reader.ReadInt16();
            int fmtBitDepth = reader.ReadInt16();

            if (fmtSize == 18)
            {
                // Read any extra values
                int fmtExtraSize = reader.ReadInt16();
                reader.ReadBytes(fmtExtraSize);
            }

            int dataID = reader.ReadInt32();
            int dataSize = reader.ReadInt32();

            // read the data samples into a byte array
            Console.WriteLine("reading in the file");
            byte[] dataBytes = reader.ReadBytes(dataSize);

            // outputs some info for the file
            Console.WriteLine("sample rate= " + fmtSampleRate);
            Console.WriteLine("file size= " + fileSize);
            Console.WriteLine("channels= " + fmtChannels);
            Console.WriteLine("bit depth= " + fmtBitDepth);
            Console.WriteLine("Avg BPS= " + fmtBitDepth);
            Console.WriteLine("Press enter to see the data");
            Console.ReadLine();

            // each sample is made up of 2 bytes
            // each byte is separate, this combines them to one integer
            Console.WriteLine("joining 2 bytes to get each sample");
            int newcount = 0;
            int[] newbytes = new int[(dataBytes.Length / 2)];
            for (int i = 1; i < dataBytes.Length - 1; i = i + 2)
            {
                newbytes[newcount] = (dataBytes[i + 1] << 8) | dataBytes[i];
                newcount++;
            }

            // split right and left channels
            // if the sound is stereo ie 2 channels
            // the first value is channel 1 and the next is channel 2 and so on
            Console.WriteLine("spliting left and right channel");
            int[] left = new int[newbytes.Length / 2];
            int[] right = new int[newbytes.Length / 2];

            newcount = 0;
            for (int i = 0; i < newbytes.Length - 1; i = i + 2)
            {
                left[newcount] = newbytes[i];
                if (fmtChannels == 2)
                    right[newcount] = newbytes[i + 1];
                Console.WriteLine(left[newcount]+" "+right[newcount]);
                newcount++;
            }

            // output info about the data processed
            Console.WriteLine("Final File information");
            Console.WriteLine("samples= " + newcount);
            Console.WriteLine("time= " + (newcount / fmtSampleRate + " seconds"));
        }

        private static void LameWavToMp3(string wavFile, string outmp3File)
        {
            // this will use the lame.exe to convert a wav into an mp3
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"lame.exe";
            psi.Arguments = "-V2 " + wavFile + " " + outmp3File;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process p = Process.Start(psi);
            p.WaitForExit();
        }

        private static void LameMp3ToWav(string mp3File, string outwavFile)
        {
            // --decode will ensure you get a wav file in the normal format
            // otherwise it is compressed and can't be read in normal way
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"lame.exe";
            psi.Arguments = "--decode " + mp3File + " " + outwavFile;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process p = Process.Start(psi);
            p.WaitForExit();
        }
    }
}
