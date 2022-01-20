using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WIA;
using CommonDialog = WIA.CommonDialog;

namespace ScanerDriverWIA
{
    public partial class Form1 : Form
    {
        private int resolution = 200;
        private int scanMode = 1;
        CommonDialog sysAppScan = new CommonDialog();
        public Form1()
        {
            InitializeComponent();
            radioButtonRGBMode.Checked = true;
            radioButtonDPI200.Checked = true;
            radioButtonJPGFormat.Checked = true;

            try
            {
                DeviceManager device = new DeviceManager();

                for (int i = 1; i <= device.DeviceInfos.Count; i++)
                {
                    if (device.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                        continue;

                    comboBoxDevices.Items.Add(device.DeviceInfos[i].Properties["Name"].get_Value());
                }
            }
            catch(COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonRefreshDevices_Click(object sender, System.EventArgs e)
        {
            comboBoxDevices.Items.Clear();
            try
            {
                DeviceManager device = new DeviceManager();

                for (int i = 1; i <= device.DeviceInfos.Count; i++)
                {
                    if (device.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                        continue;

                    comboBoxDevices.Items.Add(device.DeviceInfos[i].Properties["Name"].get_Value());
                }
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void makeChanges(IProperties props, object propName, object propValue)
        {
            Property prop = props.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        private void setScannerOptions(IItem scanner)
        {
            string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";

            makeChanges(scanner.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, textBoxVertical.Text);
            makeChanges(scanner.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, textBoxHorizontal.Text);
        }

        private void setDPI(IItem scanner)
        {
            string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";

            makeChanges(scanner.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, resolution);
            makeChanges(scanner.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, resolution);
        }

        private void setScanMode(IItem scanner)
        {
            string WIA_SCAN_COLOR_MODE = "6146";

            makeChanges(scanner.Properties, WIA_SCAN_COLOR_MODE, scanMode);
        }



        private void radioButton1BitMode_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton1BitMode.Checked)
                scanMode = 4;
        }

        private void radioButtonGreyScaleMode_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonGreyScaleMode.Checked)
                scanMode = 2;
        }

        private void radioButtonRGBMode_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonRGBMode.Checked)
                scanMode = 1;
        }

        private void radioButtonDPI100_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonDPI100.Checked)
                resolution = 100;
        }

        private void radioButtonDPI150_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonDPI150.Checked)
                resolution = 150;
        }

        private void radioButtonDPI200_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonDPI200.Checked)
                resolution = 200;
        }

        private void radioButtonDPI300_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonDPI300.Checked)
                resolution = 300;
        }

        private void radioButtonDPI400_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonDPI400.Checked)
                resolution = 400;
        }

        private void radioButtonDPI600_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonDPI600.Checked)
                resolution = 600;
        }

        private void radioButtonDPI1200_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonDPI1200.Checked)
                resolution = 1200;
        }

        private void buttonScan_Click(object sender, System.EventArgs e)
        {
            try
            {
                DeviceInfo scannerInfo = null;
                DeviceManager device = new DeviceManager();
                string scannerName = (string) comboBoxDevices.SelectedItem;

                for(int i = 1; i <= device.DeviceInfos.Count; i++)
                {
                    if (device.DeviceInfos[i].Properties["Name"].get_Value() == scannerName)
                        scannerInfo = device.DeviceInfos[i];
                }

                if (scannerInfo == null)
                    MessageBox.Show("No scanner selected!");

                Item scanner = scannerInfo.Connect().Items[1];

                setScannerOptions(scanner);
                setDPI(scanner);
                setScanMode(scanner);

                ImageFile image = scanner.Transfer();

                File.Delete("image.jpg");
                image.SaveFile("image.jpg");
                pictureBoxScannedImage.ImageLocation = "image.jpg";
            }
            catch(COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonScanSystemApp_Click(object sender, System.EventArgs e)
        {
            ImageFile image = sysAppScan.ShowAcquireImage();

            File.Delete("image.jpg");
            image.SaveFile("image.jpg");
            pictureBoxScannedImage.ImageLocation = "image.jpg";
        }

        private void buttonSaveImage_Click(object sender, System.EventArgs e)
        {
            string path = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            Image image = Image.FromFile("image.jpg");

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                path = path.Split('.')[0];

                if (radioButtonJPGFormat.Checked)
                    path += radioButtonJPGFormat.Text;
                if (radioButtonPNGFormat.Checked)
                    path += radioButtonPNGFormat.Text;
                MessageBox.Show("File saved in: " + path);
            }
            else
            {
                MessageBox.Show("ERROR WITH SAVE PATH");
            }

            if (File.Exists(path))
                File.Delete(path);

            image.Save(path);
            pictureBoxScannedImage.ImageLocation = path;
        }

    }
}
