using System;
using System.Drawing;
using System.Windows.Forms;

namespace JDP {
	internal static class Program {
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain());
		}

		public static void SetFontAndScaling(Form form) {
			form.SuspendLayout();
			form.Font = new Font("Tahoma", 8.25f);
			if (form.Font.Name != "Tahoma") form.Font = new Font("Arial", 8.25f);
			form.AutoScaleMode = AutoScaleMode.Font;
			form.AutoScaleDimensions = new SizeF(6f, 13f);
			form.ResumeLayout(false);
		}
	}
}
