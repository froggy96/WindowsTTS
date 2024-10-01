using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Globalization;

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
    }
}
