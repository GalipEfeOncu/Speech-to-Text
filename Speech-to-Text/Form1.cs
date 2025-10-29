using System;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using Vosk;

namespace Speech_to_Text
{
    public partial class Form1 : Form
    {
        private WaveInEvent? waveIn;
        private VoskRecognizer? recognizer;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitVosk()
        {
            String turkish = "vosk-model-small-tr-0.3";
            String english = "vosk-model-small-en-us-0.15";
            String currentLanguage;

            if (radioEnglish.Checked)
            {
                currentLanguage = english;
                lblStatus.Text = "Language: English";
            }
            else
            {
                currentLanguage = turkish;
                lblStatus.Text = "Language: Turkish";
            }

            try { Vosk.Vosk.GpuInit(); } catch { } // GPU desteği varsa başlatır
            var modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, currentLanguage);
            recognizer?.Dispose();
            var model = new Model(modelPath);
            recognizer = new VoskRecognizer(model, 16000.0f); // 16kHz
        }

        private void WaveIn_DataAvailable(object? sender, WaveInEventArgs e)
        {
            if (recognizer == null) return;

            if (recognizer.AcceptWaveform(e.Buffer, e.BytesRecorded))
            {
                var result = recognizer.Result();
                if (!String.IsNullOrWhiteSpace(result) && result != "{}" && !result.Contains("\"text\" : \"\""))
                {
                    Invoke(new Action(() =>
                    {
                        txtResults.AppendText(result + Environment.NewLine);
                    }));
                }
            }
        }

        private void StopListening()
        {
            if (waveIn != null)
            {
                waveIn.StopRecording();
                waveIn.Dispose();
                waveIn = null;
                txtResults.AppendText("Stopped listening.\r\n");
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            InitVosk();

            waveIn = new WaveInEvent();
            waveIn.DeviceNumber = 0;
            waveIn.WaveFormat = new WaveFormat(16000, 1); // 16kHz mono
            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.StartRecording();

            string language = radioEnglish.Checked ? "English" : "Turkish";

            txtResults.AppendText($"Listening in {language} \r\n");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopListening();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    "speech_result.txt"
                );
                File.WriteAllText(path, txtResults.Text);
                MessageBox.Show("Text saved successfully " + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void radioEnglish_CheckedChanged(object sender, EventArgs e) => StopListening();
        private void radioTurkish_CheckedChanged(object sender, EventArgs e) => StopListening();

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
            recognizer?.Dispose();
        }
    }
}
