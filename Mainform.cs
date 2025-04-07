using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace WindowsTTS
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            string words = tbText.Text.Trim();
            using (var speaker = new SpeechSynthesizer())
            {

                if (rbLangEn.Checked && rbGenFemale.Checked)
                {
                    speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, CultureInfo.GetCultureInfo("en-US"));
                }
                else if (rbLangEn.Checked && rbGenMale.Checked)
                {
                    speaker.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, CultureInfo.GetCultureInfo("en-US"));
                }
                else if (rbLangKo.Checked && rbGenFemale.Checked)
                {
                    speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, CultureInfo.GetCultureInfo("ko-KR"));
                }
                else
                {
                    speaker.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, CultureInfo.GetCultureInfo("ko-KR"));
                }

                speaker.Speak(words);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            LockWorkStation();
            //SetScreenSaverRunning();
        }


        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        private static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern void LockWorkStation();
        
        //...
        private const int SC_SCREENSAVE = 0xF140;
        private const int WM_SYSCOMMAND = 0x0112;
        //...

        public static void SetScreenSaverRunning()
        {
            SendMessage(GetDesktopWindow(), WM_SYSCOMMAND, SC_SCREENSAVE, 0);
        }
    }
}
