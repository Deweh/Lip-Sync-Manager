using NAudio.Wave;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lip_Sync_Manager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new[] { filenameBox.Text, dialogueBox.Text }));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                var n = listView1.SelectedItems[0];
                filenameBox.Text = n.SubItems[0].Text;
                dialogueBox.Text = n.SubItems[1].Text;
            }
        }

        private void updatedSelectedBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var n = listView1.SelectedItems[0];
                n.SubItems[0].Text = filenameBox.Text;
                n.SubItems[1].Text = dialogueBox.Text;
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var n = listView1.SelectedItems[0];
                listView1.Items.Remove(n);
            }
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog() { Filter = "Lip Sync Manager Project|*.lsm" };

            if (saveDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var projList = new List<VoiceLineEntry>();

            foreach (ListViewItem itm in listView1.Items)
            {
                projList.Add(new VoiceLineEntry
                {
                    fileName = itm.SubItems[0].Text,
                    dialogue = itm.SubItems[1].Text
                });
            }

            var proj = new LSMProject
            {
                pluginName = pluginnameBox.Text,
                voiceType = voicetypeBox.Text,
                lines = projList
            };

            File.WriteAllText(saveDialog.FileName, JsonConvert.SerializeObject(proj));
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsDialog = new SettingsWindow();
            if (Properties.Settings.Default.AlwaysOnTop == true)
            {
                settingsDialog.TopMost = true;
            }
            settingsDialog.ShowDialog();

            if (Properties.Settings.Default.AlwaysOnTop == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog() { Filter = "Lip Sync Manager Project|*.lsm" };

            if (openDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            loadProj(openDialog.FileName);
        }

        private void loadProj(string filename)
        {

            var proj = JsonConvert.DeserializeObject<LSMProject>(File.ReadAllText(filename));

            pluginnameBox.Text = proj.pluginName;
            voicetypeBox.Text = proj.voiceType;
            listView1.Items.Clear();

            foreach (var line in proj.lines)
            {
                listView1.Items.Add(new ListViewItem(new[] { line.fileName, line.dialogue }));
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to clear this project?", "Notice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listView1.Items.Clear();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AlwaysOnTop == true)
            {
                this.TopMost = true;
            }

            var args = Environment.GetCommandLineArgs();

            foreach (var singleArg in args)
            {
                if (File.Exists(singleArg) && Path.GetExtension(singleArg) == ".lsm")
                {
                    loadProj(singleArg);
                    break;
                }
            }
        }

        async private void allStepsBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to run all steps?", "Notice", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            await RunStep1();
            await RunStep2();
            await RunStep3();
            await RunStep4();
            await RunStep5();
            await RunStep6();

            MessageBox.Show("All steps finished.");
        }

        async private void step1Btn_Click(object sender, EventArgs e)
        {
            await RunStep1();
            MessageBox.Show("WAV files generated.");
        }

        async private void step2Btn_Click(object sender, EventArgs e)
        {
            await RunStep2();
            MessageBox.Show("Lip sync generated.");
        }

        async private void step3Btn_Click(object sender, EventArgs e)
        {
            await RunStep3();
            MessageBox.Show("WAV files silenced.");
        }

        async private void step4Btn_Click(object sender, EventArgs e)
        {
            await RunStep4();
            MessageBox.Show("WAV files converted to XWM.");
        }

        async private void step5Btn_Click(object sender, EventArgs e)
        {
            await RunStep5();
            MessageBox.Show("Combined files into FUZ.");
        }

        async private void step6Btn_Click(object sender, EventArgs e)
        {
            await RunStep6();
            MessageBox.Show("Deleted XWM, LIP & WAV files.");
        }

        async private Task RunStep1()
        {
            step1Btn.Enabled = false;
            step1Btn.Text = "Generating...";

            foreach (ListViewItem itm in listView1.Items)
            {
                await Task.Run(() =>
                {
                    using (SpeechSynthesizer synth = new SpeechSynthesizer())
                    {
                        synth.Rate = -3;
                        synth.Volume = 100;

                        synth.SetOutputToWaveFile(Path.Combine(Properties.Settings.Default.FO4Dir, "Data", "Sound", "Voice", pluginnameBox.Text, voicetypeBox.Text, itm.SubItems[0].Text + ".wav"),
                          new SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
                        synth.Speak(itm.SubItems[1].Text);
                    }
                });
            }

            step1Btn.Text = "Step 1: Generate WAV Files";
            step1Btn.Enabled = true;
        }

        async private Task RunStep2()
        {
            step2Btn.Enabled = false;
            step2Btn.Text = "Running Lip Gen...";

            var lipGenStartInfo = new ProcessStartInfo(Path.Combine(Properties.Settings.Default.FO4Dir, "CreationKit32.exe"));
            lipGenStartInfo.Arguments = $"-GenerateLIPS:{pluginnameBox.Text}";
            lipGenStartInfo.WorkingDirectory = Properties.Settings.Default.FO4Dir;

            var lipGenProcess = Process.Start(lipGenStartInfo);
            var lipFilesGenerated = false;

            await Task.Run(() =>
            {
                while (!lipFilesGenerated)
                {
                    System.Threading.Thread.Sleep(5000);

                    var fileDoesNotExist = false;
                    foreach (ListViewItem itm in listView1.Items)
                    {
                        if (!File.Exists(Path.Combine(Properties.Settings.Default.FO4Dir, "Data", "Sound", "Voice", pluginnameBox.Text, voicetypeBox.Text, itm.SubItems[0].Text + ".lip")))
                        {
                            fileDoesNotExist = true;
                            break;
                        }
                    }

                    if (!fileDoesNotExist)
                    {
                        lipFilesGenerated = true;
                    }
                }
            });

            lipGenProcess.Kill();

            step2Btn.Text = "Step 2: Generate Lip Syncing";
            step2Btn.Enabled = true;
        }

        async private Task RunStep3()
        {
            step3Btn.Enabled = false;
            step3Btn.Text = "Silencing...";

            foreach (ListViewItem itm in listView1.Items)
            {
                await Task.Run(() =>
                {
                    var wavFile = Path.Combine(Properties.Settings.Default.FO4Dir, "Data", "Sound", "Voice", pluginnameBox.Text, voicetypeBox.Text, itm.SubItems[0].Text + ".wav");
                    TimeSpan wavDuration;
                    WaveFormat wavFormat;

                    using (WaveFileReader wf = new WaveFileReader(wavFile))
                    {
                        wavDuration = wf.TotalTime - TimeSpan.FromSeconds(1);
                        wavFormat = wf.WaveFormat;
                    }

                    File.Delete(wavFile);

                    using (WaveFileWriter wf = new WaveFileWriter(wavFile, wavFormat))
                    {
                        int bytesPerMillisecond = wavFormat.AverageBytesPerSecond / 1000;
                        var silentBytes = new byte[((int)wavDuration.TotalMilliseconds) * bytesPerMillisecond];
                        wf.Write(silentBytes, 0, silentBytes.Length);
                    }
                });
            }

            step3Btn.Text = "Step 3: Silence WAV Files";
            step3Btn.Enabled = true;
        }

        async private Task RunStep4()
        {
            step4Btn.Enabled = false;
            step4Btn.Text = "Converting...";

            foreach (ListViewItem itm in listView1.Items)
            {
                await Task.Run(() =>
                {
                    var soundFile = Path.Combine(Properties.Settings.Default.FO4Dir, "Data", "Sound", "Voice", pluginnameBox.Text, voicetypeBox.Text, itm.SubItems[0].Text);
                    var xwmStartInfo = new ProcessStartInfo(Path.Combine(Properties.Settings.Default.FO4Dir, "Tools", "Audio", "xwmaencode.exe"));
                    xwmStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    xwmStartInfo.Arguments = $"-b 32000 \"{soundFile + ".wav"}\" \"{soundFile + ".xwm"}\"";

                    var xwmProcess = Process.Start(xwmStartInfo);
                    xwmProcess.WaitForExit();
                });
            }

            step4Btn.Text = "Step 4: Convert WAV Files to XWM";
            step4Btn.Enabled = true;
        }

        async private Task RunStep5()
        {
            step5Btn.Enabled = false;
            step5Btn.Text = "Combining...";

            await Task.Run(() =>
            {
                var voicePath = Path.Combine(Properties.Settings.Default.FO4Dir, "Data", "Sound", "Voice", pluginnameBox.Text, voicetypeBox.Text);
                var fuzerStartInfo = new ProcessStartInfo(Path.Combine(Properties.Settings.Default.FO4Dir, "Tools", "LipGen", "LipFuzer", "LIPFuzer.exe"));
                fuzerStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                fuzerStartInfo.WorkingDirectory = voicePath;
                fuzerStartInfo.Arguments = "-a xwm";

                var fuzerProcess = Process.Start(fuzerStartInfo);
                fuzerProcess.WaitForExit();
            });

            step5Btn.Text = "Step 5: Combine Files into FUZ";
            step5Btn.Enabled = true;
        }

        async private Task RunStep6()
        {
            step6Btn.Enabled = false;
            step6Btn.Text = "Deleting...";

            foreach (ListViewItem itm in listView1.Items)
            {
                await Task.Run(() =>
                {
                    var soundFile = Path.Combine(Properties.Settings.Default.FO4Dir, "Data", "Sound", "Voice", pluginnameBox.Text, voicetypeBox.Text, itm.SubItems[0].Text);

                    File.Delete(soundFile + ".xwm");
                    File.Delete(soundFile + ".lip");
                    File.Delete(soundFile + ".wav");
                });
            }

            step6Btn.Text = "Step 6: Delete XWM, LIP && WAV";
            step6Btn.Enabled = true;
        }
    }

    public class VoiceLineEntry
    {
        public string fileName = string.Empty;
        public string dialogue = string.Empty;
    }

    public class LSMProject
    {
        public string pluginName = string.Empty;
        public string voiceType = string.Empty;
        public List<VoiceLineEntry> lines = new List<VoiceLineEntry>();
    }
}
