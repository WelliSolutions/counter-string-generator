using System;
using System.Drawing;
using System.Windows.Forms;

namespace CounterStringGenerator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var link = (LinkLabel) sender;
            var linkText = link.Text.Substring(link.LinkArea.Start, link.LinkArea.Length);
            txtLength.Text = linkText;
        }

        private void OnExpand(object sender, System.EventArgs e)
        {
            Size = MaximumSize;
            lblExpand.Visible = false;
        }

        private StringGenerator generator = new StringGenerator();

        private void btnCopy_Click(object sender, System.EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var length = int.Parse(txtLength.Text);
                char specialChar = txtSpecialChar.Text[0];
                Clipboard.SetText(generator.Generate(length, specialChar));
            }
            catch (FormatException)
            {
            }
            catch (IndexOutOfRangeException)
            {
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Size = MinimumSize;
        }

        private void SpecialCharChanged(object sender, EventArgs e)
        {
            if (txtSpecialChar.Text.Length == 1)
            {
                txtSpecialChar.BackColor = SystemColors.Window;
                if ("0123456789".IndexOf(txtSpecialChar.Text, StringComparison.CurrentCulture) > 0)
                {
                    txtSpecialChar.BackColor = Color.Pink;
                }
            }
            else
            {
                txtSpecialChar.BackColor = Color.Pink;
            }
        }

        private void OnLengthChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtLength.Text, out var temp))
            {
                txtLength.BackColor = SystemColors.Window;
                if (temp <= 0)
                {
                    txtLength.BackColor = Color.Pink;
                }
            }
            else
            {
                txtLength.BackColor = Color.Pink;
            }
        }
    }
}
