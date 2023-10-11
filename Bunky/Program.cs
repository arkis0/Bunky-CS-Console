using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace Bunky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        }
 
        static void click(int x, int y)
        {
            var inputSimulator = new InputSimulator();
            inputSimulator.Mouse.MoveMouseToPositionOnVirtualDesktop(x, y);
            inputSimulator.Mouse.LeftButtonClick();
        }

        static void buy_resources()
        {
            var inputSimulator = new InputSimulator();
            Thread.Sleep(200);
            click(458, 494); //zakładka odnawiania
            Thread.Sleep(200);
            click(967, 791); //przycisk kup zasoby
            Thread.Sleep(200);
            click(1070, 620); //potwierdź zakup
            Thread.Sleep(200);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.ESCAPE); //#powrót na home screen
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.ESCAPE); //swobodny widok
            Console.WriteLine("Resources were ordered");
        }
        public static int check_progress_of_research(int researchLevel)
        {
            int x = 993;
            int y = 329;
            int matching_pixels_research = 0;
            int total_pixels = 597;
            int step_size = 4;


            for (int i = 0; i < total_pixels; i += step_size)
            {
                //Color pixelColor = new Bitmap(1, 1).GetPixel(x, y);
                //if (pixelColor.R == 255 && pixelColor.G == 255 && pixelColor.B == 255)
                //{
                //    matching_pixels_research++;
                //}
                //x += step_size;
            }

            researchLevel = 0;
            return researchLevel;
        }



    }
}
