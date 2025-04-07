using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Windows.Forms;

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

            // Lock 을 하거나
            // 화면 보호기를 설정하고, 설정에서 화면보호기 빠져나올 때 로그인 표시를 하거나
            // ...

            //LockWorkStation();
            SetScreenSaverRunning();
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
