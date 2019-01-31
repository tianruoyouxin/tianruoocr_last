using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace 天若OCR文字识别
{
	// Token: 0x02000013 RID: 19
	public partial class Fmnote : Form
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00014CD8 File Offset: 0x00012ED8
		public Fmnote()
		{
			this.InitializeComponent();
			base.Focus();
			base.TopMost = true;
			base.ShowInTaskbar = false;
			base.Location = new Point(Screen.AllScreens[0].WorkingArea.Width - base.Width, Screen.AllScreens[0].WorkingArea.Height - base.Height);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00014D50 File Offset: 0x00012F50
		private void Form1_Load(object sender, EventArgs e)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FmMain));
			base.Icon = (Icon)componentResourceManager.GetObject("minico.Icon");
			this.dataGridView1.ColumnCount = 1;
			this.dataGridView1.RowCount = StaticValue.v_notecount;
			this.dataGridView1.Columns[0].Width = Convert.ToInt32(400f * Program.factor);
			this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			for (int i = 0; i < StaticValue.v_notecount; i++)
			{
				bool flag = i < 9;
				if (flag)
				{
					this.dataGridView1.Rows[i].Cells[0].Value = "0" + (i + 1).ToString() + "." + StaticValue.v_note[i].ToString();
				}
				else
				{
					this.dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString() + "." + StaticValue.v_note[i].ToString();
				}
			}
			this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
			this.dataGridView1.Size = new Size(Convert.ToInt32(402f * Program.factor), StaticValue.v_notecount * this.dataGridView1.Rows[0].Cells[0].Size.Height + 2);
			base.ClientSize = this.dataGridView1.Size;
			base.MaximumSize = new Size(base.Size.Width, Screen.GetWorkingArea(this).Height / 4 * 3);
			this.dataGridView1.MaximumSize = new Size(base.Size.Width, Screen.GetWorkingArea(this).Height / 4 * 3 - 5);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00014F94 File Offset: 0x00013194
		private void copy_click(object sender, EventArgs e)
		{
			string text = "";
			int[] array = new int[this.dataGridView1.SelectedRows.Count];
			int num = 0;
			foreach (object obj in this.dataGridView1.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				array[num] = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString().Substring(0, 2));
				num++;
			}
			int[] array2 = array;
			for (int i = 0; i < array2.Length - 1; i++)
			{
				for (int j = 0; j < array2.Length - 1 - i; j++)
				{
					bool flag = array2[j] > array2[j + 1];
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					bool flag7 = flag6;
					bool flag8 = flag7;
					if (flag8)
					{
						int num2 = array2[j];
						array2[j] = array2[j + 1];
						array2[j + 1] = num2;
					}
				}
			}
			for (int k = 0; k < array2.Length; k++)
			{
				bool flag9 = k == array2.Length - 1;
				bool flag10 = flag9;
				bool flag11 = flag10;
				bool flag12 = flag11;
				bool flag13 = flag12;
				bool flag14 = flag13;
				bool flag15 = flag14;
				bool flag16 = flag15;
				if (flag16)
				{
					text += this.dataGridView1.Rows[array2[k] - 1].Cells[0].Value.ToString().Remove(0, 3);
				}
				else
				{
					text = text + this.dataGridView1.Rows[array2[k] - 1].Cells[0].Value.ToString().Remove(0, 3) + "\r\n";
				}
			}
			Clipboard.SetDataObject(text);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002BA9 File Offset: 0x00000DA9
		private void CopyItem_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00015198 File Offset: 0x00013398
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000151AC File Offset: 0x000133AC
		public string Text_note
		{
			get
			{
				return null;
			}
			set
			{
				for (int i = 0; i < StaticValue.v_notecount; i++)
				{
					bool flag = i < 9;
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					bool flag7 = flag6;
					bool flag8 = flag7;
					if (flag8)
					{
						this.dataGridView1.Rows[i].Cells[0].Value = "0" + (i + 1).ToString() + "." + StaticValue.v_note[i].ToString();
					}
					else
					{
						this.dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString() + "." + StaticValue.v_note[i].ToString();
					}
				}
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0001528C File Offset: 0x0001348C
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 274 && (int)m.WParam == 61536)
			{
				base.Visible = false;
				return;
			}
			if (m.Msg == 163)
			{
				base.Location = new Point(Screen.AllScreens[0].WorkingArea.Width - base.Width, Screen.AllScreens[0].WorkingArea.Height - base.Height);
			}
			base.WndProc(ref m);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00015318 File Offset: 0x00013518
		private void doub_click(object sender, EventArgs e)
		{
			bool flag = this.dataGridView1.SelectedCells[0].Value.ToString().Remove(0, 3) != "";
			bool flag2 = flag;
			bool flag3 = flag2;
			bool flag4 = flag3;
			bool flag5 = flag4;
			bool flag6 = flag5;
			bool flag7 = flag6;
			bool flag8 = flag7;
			if (flag8)
			{
				Clipboard.SetDataObject(this.dataGridView1.SelectedCells[0].Value.ToString().Remove(0, 3));
				Fmflags fmflags = new Fmflags();
				fmflags.Show();
				fmflags.DrawStr("已复制");
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00015198 File Offset: 0x00013398
		// (set) Token: 0x06000177 RID: 375 RVA: 0x000153B4 File Offset: 0x000135B4
		public string Text_note_change
		{
			get
			{
				return null;
			}
			set
			{
				this.dataGridView1.Rows.Clear();
				this.dataGridView1.ColumnCount = 1;
				this.dataGridView1.RowCount = StaticValue.v_notecount;
				this.dataGridView1.Columns[0].Width = Convert.ToInt32(400f * Program.factor);
				this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
				this.dataGridView1.AllowUserToResizeRows = false;
				this.dataGridView1.AllowUserToResizeColumns = false;
				for (int i = 0; i < StaticValue.v_notecount; i++)
				{
					bool flag = i < 9;
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					bool flag7 = flag6;
					bool flag8 = flag7;
					if (flag8)
					{
						this.dataGridView1.Rows[i].Cells[0].Value = "0" + (i + 1).ToString() + ".";
					}
					else
					{
						this.dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString() + ".";
					}
				}
				this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
				this.dataGridView1.Size = new Size(Convert.ToInt32(402f * Program.factor), StaticValue.v_notecount * this.dataGridView1.Rows[0].Cells[0].Size.Height + 2);
				base.ClientSize = this.dataGridView1.Size;
				base.MaximumSize = new Size(base.Size.Width, Screen.GetWorkingArea(this).Height / 4 * 3);
				this.dataGridView1.MaximumSize = new Size(base.Size.Width, Screen.GetWorkingArea(this).Height / 4 * 3 - 5);
			}
		}
	}
}
