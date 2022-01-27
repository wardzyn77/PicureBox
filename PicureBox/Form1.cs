using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PicureBox.Properties;

namespace PicureBox
{
    public partial class Form1 : Form
    {
        private enum order {Poprzedni, Następny};
        private List<string> _listFile;
        private int _curFileNumber, _lasFileNumber;
        private string _fileExtOK;
        private string _picture
        {
            get
            {
                return Settings.Default.DefaultPicture;
            }
            set
            {
                Settings.Default.DefaultPicture = value;
            }
        }
        private string _folder;

        public Form1()
        {
            InitializeComponent();
            _fileExtOK = "JPG, JPEG, BMP, GIF";
            if (_picture.Length > 0)
            {
                ViewPhoto(_picture);
                GetFileFolderFromFile(_picture);
                GetFileTable(_picture);
                SetBtnPrevNextEnable();
            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            var path = GetFileFolder();
            if (path.Length > 0)
            {
                ViewPhoto(path);
                GetFileFolderFromFile(path);
                GetFileTable(path);
                SetBtnPrevNextEnable();
            }
        }

        private string GetFileFolder()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Pliki graficzne *.jpg|*.jpg| *.jpeg|*.jpeg| *bmp|*bmp| *gif|*gif";
            fileDialog.Title = "Wybierz zdjęcie do załadowania";
            if (fileDialog.ShowDialog() == DialogResult.OK)
                return fileDialog.FileName;
            return "";
        }

        private void ViewPhoto(string path)
        {
            picbPhoto.ImageLocation = path;
            btnDeletePhoto.Enabled = true;
            lbFile.Text = path;
            picbPhoto.Visible = true;
        }

        private void GetFileFolderFromFile(string path)
        {
            _folder = Path.GetDirectoryName(path);
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            picbPhoto.ImageLocation = "";
            btnDeletePhoto.Enabled = false;
            btnNext.Enabled = false;
            btnPreview.Enabled = false;
            lbFile.Text = "";
            ClearVariableLocal();
        }

        private void ClearVariableLocal()
        {
            _folder = "";
            _listFile = null;
            _curFileNumber = 0;
            _lasFileNumber = 0;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _picture = picbPhoto.ImageLocation;
            Settings.Default.Save();
        }

        private void GetFileTable(string fileFolder)
        {
            _listFile = Directory.GetFiles(_folder).ToList();
            _listFile = Directory.GetFiles(_folder).ToList().Where(s => _fileExtOK.Contains(s.Split('.').Last().ToUpper())).ToList();
            _curFileNumber = _listFile.Select((s, index) => new { s, index }).Where(x => x.s == fileFolder).Select(x => x.index).FirstOrDefault();
            _lasFileNumber = _listFile.Count - 1;
        }

        private void SetBtnPrevNextEnable()
        {
            btnPreview.Enabled = true;
            if (_curFileNumber == 0)
                btnPreview.Enabled = false;
            btnNext.Enabled = true;
            if (_curFileNumber == _lasFileNumber)
                btnNext.Enabled = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            GetNextPreviewPhoto(order.Poprzedni);
            SetBtnPrevNextEnable();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GetNextPreviewPhoto(order.Następny);
            SetBtnPrevNextEnable();
        }

        private void GetNextPreviewPhoto(order order)
        {   //Po tym jak ograniczyłem listę plików w tablicy, po zaczytaniu folderu, do danych .ext można ograniczyć tą metodę.
            string file;
            int i = 1;
            while (true)
            {
                if (order == order.Poprzedni)
                {
                    file = _listFile[_curFileNumber - i];
                    _curFileNumber--;
                }
                else
                {
                    file = _listFile[_curFileNumber + i];
                    _curFileNumber++;
                }
                var fileExt = file.Split('.').Last().ToUpper();
                if (_fileExtOK.Contains(fileExt))
                    break;
                if (_curFileNumber == 0 || _curFileNumber == _lasFileNumber)
                {
                    var btnInfo = "koniec";
                    if (order == order.Poprzedni)
                        btnInfo = "początek";
                    MessageBox.Show($"Brak pliku do wyświetlenia\nOsiągnięto {btnInfo} folderu");
                    return;
                }
            }
            ViewPhoto(file);
        }
    }
}
