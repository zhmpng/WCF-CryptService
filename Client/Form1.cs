using Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class CryptographyForm : Form
    {

        private InstanceContext _instanseContext;
        private CryptographyClient _client;
        private bool _connetctionStatus = false;

        public enum Methods
        { 
            MD5, SHA1, SHA256, SHA512
        }


        public class CallbackHandler : ICryptographyCallback
        {
            CryptographyForm form;
            public CallbackHandler(CryptographyForm form)
            {
                this.form = form;
            }
            public void Count(int count)
            {
                form.ClientLabel.Text = $"Общее число клиентов: {count}";
            }
        }

        public CryptographyForm()
        {
            InitializeComponent();
        }

        private void Connection_Click(object sender, EventArgs e)
        {
            try
            {
                _instanseContext = new InstanceContext(new CallbackHandler(this));
                _client = new CryptographyClient(_instanseContext);
                _client.Connection();
                foreach (var item in Enum.GetValues(typeof(Methods)))
                    MethodsCollection.Items.Add(item);
                MethodsCollection.SelectedIndex = 0;
                _connetctionStatus = true;
                return;
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
                TryDisconnection();
                return;
            }
        }

        private void Disconnection_Click(object sender, EventArgs e)
        {
            TryDisconnection();
        }

        private void TryDisconnection()
        {
            try
            {
                _client.Disconnection();
                _client.Close();
                _connetctionStatus = false;

                MethodsCollection.Items.Clear();
                ResultBox.Text = string.Empty;
                InputTextBox.Text = string.Empty;
                ClientLabel.Text = "Отсутсвует подключение!";
            }
            catch { }
        }

        private void RefreshHash()
        {
            string str = InputTextBox.Text;
            if (string.IsNullOrEmpty(str))
            {
                ResultBox.Text = string.Empty; 
                return;
            }
            string hash = string.Empty;
            try
            {
                switch ((Methods)MethodsCollection.SelectedIndex)
                {
                    case Methods.MD5: hash = _client.EncryptToMD5(str); break;

                    case Methods.SHA1: hash = _client.EncryptToSHA1(str); break;
                    case Methods.SHA256: hash = _client.EncryptToSHA256(str); break;
                    case Methods.SHA512: hash = _client.EncryptToSHA512(str); break;
                    default:
                        ResultBox.Text = string.Empty;
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                TryDisconnection();
                return;
            }
            finally
            {
                ResultBox.Text = hash;
            }
        }

        private void MethodsCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshHash();
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshHash();
        }

        private void SendResult_Click(object sender, EventArgs e)
        {
            if (_connetctionStatus)
                try
                {
                    string input = InputTextBox.Text;
                    string result = ResultBox.Text;
                    Methods methods = (Methods)MethodsCollection.SelectedItem;

                    if (!string.IsNullOrEmpty(input) && !string.IsNullOrEmpty(result))
                    {
                        _client.WriteResult($"{input} => {methods} => {result}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    TryDisconnection();
                    return;
                }
        }

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            if (_connetctionStatus)
            {
                _client.Disconnection();
                _client.Close();
            }
        }
    }
}
