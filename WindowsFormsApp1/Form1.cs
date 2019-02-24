using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HuffmanWordCompression
{
    public partial class HuffmanWordsForm : Form
    {
        public HuffmanWordsForm()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            tbDecoded.Text = string.Empty;
            tbEncoded.Text = string.Empty;

            string input = tbRawText.Text;
            HuffmanTree huffmanTree = new HuffmanTree();
            string[] words = tbRawText.Text.Split(' ');

            // Build the Huffman tree
            huffmanTree.Build(words);

            // Encode
            BitArray encoded = huffmanTree.Encode(words);

            //Console.Write("Encoded: ");
            foreach (bool bit in encoded)
            {
                tbEncoded.Text += (bit ? 1 : 0) + "";
            }
            Console.WriteLine();

            // Decode
            tbDecoded.Text = huffmanTree.Decode(encoded);
        }

        private void tbRawText_TextChanged(object sender, EventArgs e)
        {
            if (tbRawText.Text != String.Empty)
            {
                btnEncode.Enabled = true;
            }
            else
            {
                btnEncode.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbRawText.Text = string.Empty;
            tbEncoded.Text = string.Empty;
            tbDecoded.Text = string.Empty;
            btnEncode.Enabled = false;
        }
    }
}
