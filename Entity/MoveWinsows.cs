using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace Entity
{
    public class MoveWinsows
    {

        public MoveWinsows()
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        public extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        public void MoverVentana( IntPtr intPtr)
        {
            ReleaseCapture();
            SendMessage(intPtr, 0x112, 0xf012, 0);
        }
        
       
    }
}
