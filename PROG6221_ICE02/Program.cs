using System;
using System.Media;

Class Program
{
    static void Main()
    {
        String[] wavFiles = {"wav1.wav", "wav2.wav", "wav3.wav"};
        Bool[] played = {false, flase, false};

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select a WAV file to play:");

            for (int i = 0; i < wavFiles.Length; i++);
            {
                if (played[i])
                Console.ForegroundColour = ConsoleColor.Green;

                Console.WriteLine($"{i + 1} + {wavFiles[i]}");
                Console.ResetColour();
            }

            Console.Write("Enter your choice (1-3) or 0 to exit: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice>1 && choice <= 3)
            {
                playWavFile(wavFiles[choice - 1]);
                played[choice - 1] = true;
            }
            else if (choice == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key to try again.");
                Console.ReadKey();
            }

        }

    }
    static void playWavFile(String filePath)
    {
        try
        {
            using (SoundPlayer player = new SoundPlayer(filePath))
            {
                player.PlaySync();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing file: {ex.Message}");
            Console.ReadKey();
        }
    }

}
