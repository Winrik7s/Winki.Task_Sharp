using System.Runtime.InteropServices;
using System.Diagnostics;
using Windows.Win32;

namespace Winki.Task_Sharp
{
    public class Program
    {
        [DllImport("user32.dll")]
        static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);

        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Hello, GitHub!", "Test Platform Invoke", 0);

            var windowHandle = Process.GetCurrentProcess().MainWindowHandle;

            PInvoke.MessageBox((Windows.Win32.Foundation.HWND)windowHandle, "Hello, GitHub!", 
                "Test win32metadata", Windows.Win32.UI.WindowsAndMessaging.MESSAGEBOX_STYLE.MB_OK);
        }
    }
}