using System.Runtime.InteropServices;

namespace Winki.Task_Sharp
{
    public class Program
    {
        [DllImport("user32.dll")]
        static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);

        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Hello, GitHub!", "Test Platform Invoke", 0);
        }
    }
}