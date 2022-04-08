using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab20220408 {
		public partial class Form1:Form {
				public Form1() {
						InitializeComponent();
				}

				private void label1_Click(object sender,EventArgs e) {

				}

				private void textBox1_TextChanged(object sender,EventArgs e) {
						try {
								label3.Text = $"Payment:${Single.Parse(textBox1.Text)*24.3}";
						}
						catch (Exception ex){ 
								label3.Text=$"Payment:$0";
						}
				}
		}
}
