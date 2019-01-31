using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace 天若OCR文字识别
{
	// Token: 0x02000017 RID: 23
	public class HelpRepaint
	{
		// Token: 0x02000018 RID: 24
		public class ColorItemx
		{
			// Token: 0x060001C8 RID: 456 RVA: 0x00002D23 File Offset: 0x00000F23
			public ColorItemx(string name, Color clr)
			{
				this.Name = name;
				this.ItemColor = clr;
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060001C9 RID: 457 RVA: 0x0001B564 File Offset: 0x00019764
			// (set) Token: 0x060001CA RID: 458 RVA: 0x00002D3D File Offset: 0x00000F3D
			public Color ItemColor
			{
				get
				{
					return this.color;
				}
				set
				{
					this.color = value;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060001CB RID: 459 RVA: 0x0001B57C File Offset: 0x0001977C
			// (set) Token: 0x060001CC RID: 460 RVA: 0x00002D47 File Offset: 0x00000F47
			public string Name
			{
				get
				{
					return this.name;
				}
				set
				{
					this.name = value;
				}
			}

			// Token: 0x0400017F RID: 383
			public string name;

			// Token: 0x04000180 RID: 384
			public Color color;
		}

		// Token: 0x02000019 RID: 25
		public class HWColorPicker : HelpRepaint.FloatLayerBase
		{
			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060001CD RID: 461 RVA: 0x0001B594 File Offset: 0x00019794
			public Color SelectedColor
			{
				get
				{
					return this.selectedColor;
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060001CE RID: 462 RVA: 0x0001B5AC File Offset: 0x000197AC
			// (set) Token: 0x060001CF RID: 463 RVA: 0x00002D51 File Offset: 0x00000F51
			[DefaultValue(true)]
			[Description("是否显示颜色提示")]
			public bool ShowTip
			{
				get
				{
					return this.showTip;
				}
				set
				{
					this.showTip = value;
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x0001B5C4 File Offset: 0x000197C4
			// (set) Token: 0x060001D1 RID: 465 RVA: 0x0001B5DC File Offset: 0x000197DC
			[DefaultValue(typeof(Color), "255, 238, 194")]
			[Description("高亮背景色")]
			public Color HoverBKColor
			{
				get
				{
					return this.hoverBKColor;
				}
				set
				{
					bool flag = this.hoverBKColor != value;
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					bool flag7 = flag6;
					bool flag8 = flag7;
					bool flag9 = flag8;
					bool flag10 = flag9;
					if (flag10)
					{
						bool flag11 = this.hoverBrush != null;
						bool flag12 = flag11;
						bool flag13 = flag12;
						bool flag14 = flag13;
						bool flag15 = flag14;
						bool flag16 = flag15;
						bool flag17 = flag16;
						bool flag18 = flag17;
						bool flag19 = flag18;
						bool flag20 = flag19;
						if (flag20)
						{
							this.hoverBrush.Dispose();
						}
						this.hoverBrush = new SolidBrush(value);
					}
					this.hoverBKColor = value;
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060001D2 RID: 466 RVA: 0x0001B670 File Offset: 0x00019870
			public List<HelpRepaint.ColorItemx> ColorTable
			{
				get
				{
					return this.colorTable;
				}
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x0001B688 File Offset: 0x00019888
			public HWColorPicker()
			{
				this.Font = new Font(this.Font.Name, 9f / StaticValue.Dpifactor, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);
				this.hoverItem = -1;
				this.InitializeComponent();
				this.InitColor();
				this.CalcWindowSize();
				this.sf = new StringFormat();
				this.sf.Alignment = StringAlignment.Center;
				this.sf.LineAlignment = StringAlignment.Center;
				this.HoverBKColor = Color.FromArgb(255, 238, 194);
				this.ShowTip = true;
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x0001B750 File Offset: 0x00019950
			public void CalcWindowSize()
			{
				int width = 152;
				int height = 100;
				base.Size = new Size(width, height);
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x0001B778 File Offset: 0x00019978
			public Rectangle CalcItemBound(int index)
			{
				bool flag = index < 0 || index > 40;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				bool flag11 = index == 40;
				bool flag12 = flag11;
				bool flag13 = flag12;
				bool flag14 = flag13;
				bool flag15 = flag14;
				bool flag16 = flag15;
				bool flag17 = flag16;
				bool flag18 = flag17;
				bool flag19 = flag18;
				bool flag20 = flag19;
				Rectangle result;
				if (flag20)
				{
					result = Rectangle.FromLTRB(0, 0, 0, 0);
				}
				else
				{
					result = new Rectangle(index % 8 * 18 + 3, index / 8 * 18 + 3, 18, 18);
				}
				return result;
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x0001B824 File Offset: 0x00019A24
			public int GetIndexFromPoint(Point point)
			{
				int result;
				if (point.X <= 3 || point.X >= base.Width - 3 || point.Y <= 3 || point.Y >= base.Height - 3)
				{
					result = -1;
				}
				else
				{
					int num = (point.Y - 3) / 18;
					if (num > 4)
					{
						result = 40;
					}
					else
					{
						int num2 = (point.X - 3) / 18;
						result = num * 8 + num2;
					}
				}
				return result;
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x0001B8A0 File Offset: 0x00019AA0
			public void SelectColor(Color clr)
			{
				this.selectedColor = clr;
				bool flag = this.SelectedColorChanged != null;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					this.SelectedColorChanged(this.ctl_T, EventArgs.Empty);
				}
				base.Hide();
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x0001B900 File Offset: 0x00019B00
			public void DrawItem(DrawItemEventArgs e)
			{
				Rectangle bounds = e.Bounds;
				bounds.Inflate(-1, -1);
				e.DrawBackground();
				bool flag = (e.State & DrawItemState.HotLight) > DrawItemState.None;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					e.Graphics.FillRectangle(this.hoverBrush, bounds);
					e.Graphics.DrawRectangle(Pens.Black, bounds);
				}
				bool flag11 = e.Index == 40;
				bool flag12 = !flag11;
				bool flag13 = flag12;
				bool flag14 = flag13;
				bool flag15 = flag14;
				bool flag16 = flag15;
				bool flag17 = flag16;
				bool flag18 = flag17;
				bool flag19 = flag18;
				bool flag20 = flag19;
				if (flag20)
				{
					Rectangle bounds2 = e.Bounds;
					bounds2.Inflate(-3, -3);
					using (Brush brush = new SolidBrush(this.ColorTable[e.Index].ItemColor))
					{
						e.Graphics.FillRectangle(brush, bounds2);
					}
					e.Graphics.DrawRectangle(Pens.Gray, bounds2);
				}
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x0001BA2C File Offset: 0x00019C2C
			public void HWColorPicker_Paint(object sender, PaintEventArgs e)
			{
				e.Graphics.DrawRectangle(Pens.LightGray, 0, 0, 150, 98);
				for (int i = 0; i < 40; i++)
				{
					DrawItemEventArgs e2 = new DrawItemEventArgs(e.Graphics, this.Font, this.CalcItemBound(i), i, DrawItemState.Default, this.ForeColor, this.BackColor);
					this.DrawItem(e2);
				}
			}

			// Token: 0x060001DA RID: 474 RVA: 0x0001BA98 File Offset: 0x00019C98
			public void HWColorPicker_MouseMove(object sender, MouseEventArgs e)
			{
				int indexFromPoint = this.GetIndexFromPoint(e.Location);
				if (indexFromPoint != this.hoverItem)
				{
					Graphics graphics = base.CreateGraphics();
					if (this.hoverItem != -1)
					{
						this.DrawItem(new DrawItemEventArgs(graphics, this.Font, this.CalcItemBound(this.hoverItem), this.hoverItem, DrawItemState.Default));
					}
					if (indexFromPoint <= 40)
					{
						if (indexFromPoint != -1)
						{
							if (this.ShowTip)
							{
								this.ShowToolTip(indexFromPoint);
							}
							this.DrawItem(new DrawItemEventArgs(graphics, this.Font, this.CalcItemBound(indexFromPoint), indexFromPoint, DrawItemState.Default | DrawItemState.HotLight));
						}
						graphics.Dispose();
						this.hoverItem = indexFromPoint;
					}
				}
			}

			// Token: 0x060001DB RID: 475 RVA: 0x0001BB4C File Offset: 0x00019D4C
			public void HWColorPicker_MouseClick(object sender, MouseEventArgs e)
			{
				int indexFromPoint = this.GetIndexFromPoint(e.Location);
				if (indexFromPoint != -1 && indexFromPoint != 40)
				{
					this.SelectedColored = this.colorTable[indexFromPoint].ItemColor;
					base.DialogResult = DialogResult.OK;
				}
			}

			// Token: 0x060001DC RID: 476 RVA: 0x0001BB98 File Offset: 0x00019D98
			public void ShowToolTip(int index)
			{
				bool flag = index == 40;
				bool flag2 = !flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					this.tip.SetToolTip(this, this.ColorTable[index].Name);
				}
			}

			// Token: 0x060001DD RID: 477 RVA: 0x0001BBF0 File Offset: 0x00019DF0
			public void InitColor()
			{
				this.colorTable = new List<HelpRepaint.ColorItemx>();
				this.colorTable.AddRange(new HelpRepaint.ColorItemx[]
				{
					new HelpRepaint.ColorItemx("黑色", Color.FromArgb(0, 0, 0)),
					new HelpRepaint.ColorItemx("褐色", Color.FromArgb(153, 51, 0)),
					new HelpRepaint.ColorItemx("橄榄色", Color.FromArgb(51, 51, 0)),
					new HelpRepaint.ColorItemx("深绿", Color.FromArgb(0, 51, 0)),
					new HelpRepaint.ColorItemx("深青", Color.FromArgb(0, 51, 102)),
					new HelpRepaint.ColorItemx("深蓝", Color.FromArgb(0, 0, 128)),
					new HelpRepaint.ColorItemx("靛蓝", Color.FromArgb(51, 51, 153)),
					new HelpRepaint.ColorItemx("灰色-80%", Color.FromArgb(51, 51, 51)),
					new HelpRepaint.ColorItemx("深红", Color.FromArgb(128, 0, 0)),
					new HelpRepaint.ColorItemx("橙色", Color.FromArgb(255, 102, 0)),
					new HelpRepaint.ColorItemx("深黄", Color.FromArgb(128, 128, 0)),
					new HelpRepaint.ColorItemx("绿色", Color.FromArgb(0, 128, 0)),
					new HelpRepaint.ColorItemx("青色", Color.FromArgb(0, 128, 128)),
					new HelpRepaint.ColorItemx("蓝色", Color.FromArgb(0, 0, 255)),
					new HelpRepaint.ColorItemx("蓝灰", Color.FromArgb(102, 102, 153)),
					new HelpRepaint.ColorItemx("灰色-50%", Color.FromArgb(128, 128, 128)),
					new HelpRepaint.ColorItemx("红色", Color.FromArgb(255, 0, 0)),
					new HelpRepaint.ColorItemx("浅橙", Color.FromArgb(255, 153, 0)),
					new HelpRepaint.ColorItemx("酸橙", Color.FromArgb(153, 204, 0)),
					new HelpRepaint.ColorItemx("海绿", Color.FromArgb(51, 153, 102)),
					new HelpRepaint.ColorItemx("水绿", Color.FromArgb(51, 204, 204)),
					new HelpRepaint.ColorItemx("浅蓝", Color.FromArgb(51, 102, 255)),
					new HelpRepaint.ColorItemx("紫罗兰", Color.FromArgb(128, 0, 128)),
					new HelpRepaint.ColorItemx("灰色-40%", Color.FromArgb(153, 153, 153)),
					new HelpRepaint.ColorItemx("粉红", Color.FromArgb(255, 0, 255)),
					new HelpRepaint.ColorItemx("金色", Color.FromArgb(255, 204, 0)),
					new HelpRepaint.ColorItemx("黄色", Color.FromArgb(255, 255, 0)),
					new HelpRepaint.ColorItemx("鲜绿", Color.FromArgb(0, 255, 0)),
					new HelpRepaint.ColorItemx("青绿", Color.FromArgb(0, 255, 255)),
					new HelpRepaint.ColorItemx("天蓝", Color.FromArgb(0, 204, 255)),
					new HelpRepaint.ColorItemx("梅红", Color.FromArgb(153, 51, 102)),
					new HelpRepaint.ColorItemx("灰色-25%", Color.FromArgb(192, 192, 192)),
					new HelpRepaint.ColorItemx("玫瑰红", Color.FromArgb(255, 153, 204)),
					new HelpRepaint.ColorItemx("茶色", Color.FromArgb(255, 204, 153)),
					new HelpRepaint.ColorItemx("浅黄", Color.FromArgb(255, 255, 204)),
					new HelpRepaint.ColorItemx("浅绿", Color.FromArgb(204, 255, 204)),
					new HelpRepaint.ColorItemx("浅青绿", Color.FromArgb(204, 255, 255)),
					new HelpRepaint.ColorItemx("淡蓝", Color.FromArgb(153, 204, 255)),
					new HelpRepaint.ColorItemx("淡紫", Color.FromArgb(204, 153, 255)),
					new HelpRepaint.ColorItemx("白色", Color.FromArgb(255, 255, 255))
				});
			}

			// Token: 0x060001DE RID: 478 RVA: 0x0001C0A8 File Offset: 0x0001A2A8
			protected override void Dispose(bool disposing)
			{
				bool flag = disposing && this.components != null;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					this.components.Dispose();
				}
				base.Dispose(disposing);
			}

			// Token: 0x060001DF RID: 479 RVA: 0x0001C100 File Offset: 0x0001A300
			public void InitializeComponent()
			{
				this.components = new Container();
				this.tip = new ToolTip(this.components);
				base.SuspendLayout();
				this.BackColor = Color.White;
				base.AutoScaleMode = AutoScaleMode.None;
				base.Name = "HWColorPicker";
				base.Paint += this.HWColorPicker_Paint;
				base.MouseClick += this.HWColorPicker_MouseClick;
				base.MouseMove += this.HWColorPicker_MouseMove;
				base.ClientSize = new Size(114, 115);
				base.SizeGripStyle = SizeGripStyle.Hide;
				base.ResumeLayout(false);
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060001E0 RID: 480 RVA: 0x00002D5B File Offset: 0x00000F5B
			// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002D63 File Offset: 0x00000F63
			public Color SelectedColored { get; private set; }

			// Token: 0x04000182 RID: 386
			[CompilerGenerated]
			private EventHandler SelectedColorChanged;

			// Token: 0x04000183 RID: 387
			public bool showTip;

			// Token: 0x04000184 RID: 388
			public Color selectedColor;

			// Token: 0x04000185 RID: 389
			public Color hoverBKColor;

			// Token: 0x04000186 RID: 390
			public List<HelpRepaint.ColorItemx> colorTable;

			// Token: 0x04000187 RID: 391
			public StringFormat sf;

			// Token: 0x04000188 RID: 392
			public int hoverItem;

			// Token: 0x04000189 RID: 393
			public Control ctl;

			// Token: 0x0400018A RID: 394
			public Brush hoverBrush;

			// Token: 0x0400018B RID: 395
			public IContainer components;

			// Token: 0x0400018C RID: 396
			public ToolTip tip;

			// Token: 0x0400018D RID: 397
			public ToolStripButton ctl_T;
		}

		// Token: 0x0200001A RID: 26
		public class MenuItemRenderer : ToolStripProfessionalRenderer
		{
			// Token: 0x060001E2 RID: 482 RVA: 0x0001C1AC File Offset: 0x0001A3AC
			public MenuItemRenderer()
			{
				this.textFont = new Font("微软雅黑", 9f / StaticValue.Dpifactor, FontStyle.Regular, GraphicsUnit.Point, 0);
				this.menuItemSelectedColor = Color.White;
				this.menuItemBorderColor = Color.White;
				this.menuItemSelectedColor = Color.White;
				this.menuItemBorderColor = Color.LightSlateGray;
			}

			// Token: 0x060001E3 RID: 483 RVA: 0x0001C20C File Offset: 0x0001A40C
			protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
			{
				bool isOnDropDown = e.Item.IsOnDropDown;
				bool flag = isOnDropDown;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				if (flag9)
				{
					bool flag10 = e.Item.Selected && e.Item.Enabled;
					bool flag11 = flag10;
					bool flag12 = flag11;
					bool flag13 = flag12;
					bool flag14 = flag13;
					bool flag15 = flag14;
					bool flag16 = flag15;
					bool flag17 = flag16;
					bool flag18 = flag17;
					bool flag19 = flag18;
					if (flag19)
					{
						this.DrawMenuDropDownItemHighlight(e);
					}
				}
				else
				{
					base.OnRenderMenuItemBackground(e);
				}
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
			public void DrawMenuDropDownItemHighlight(ToolStripItemRenderEventArgs e)
			{
				Rectangle rect = default(Rectangle);
				rect = new Rectangle(2, 0, (int)e.Graphics.VisibleClipBounds.Width - 36, (int)e.Graphics.VisibleClipBounds.Height - 1);
				using (Pen pen = new Pen(this.menuItemBorderColor))
				{
					e.Graphics.DrawRectangle(pen, rect);
				}
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x0001C32C File Offset: 0x0001A52C
			protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
			{
				ToolStrip toolStrip = e.ToolStrip;
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
				bool flag = e.ToolStrip is MenuStrip || e.ToolStrip is ToolStripDropDown;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					e.Graphics.DrawRectangle(new Pen(Color.LightSlateGray), new Rectangle(0, 0, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1));
				}
				else
				{
					bool flag11 = toolStrip != null;
					bool flag12 = flag11;
					bool flag13 = flag12;
					bool flag14 = flag13;
					bool flag15 = flag14;
					bool flag16 = flag15;
					bool flag17 = flag16;
					bool flag18 = flag17;
					bool flag19 = flag18;
					bool flag20 = flag19;
					if (flag20)
					{
						e.Graphics.DrawRectangle(new Pen(Color.White), new Rectangle(0, 0, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1));
					}
					base.OnRenderToolStripBorder(e);
				}
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x0001C44C File Offset: 0x0001A64C
			protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
			{
				Graphics graphics = e.Graphics;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				ToolStripItem item = e.Item;
				bool selected = item.Selected;
				bool flag = selected;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				if (flag9)
				{
					Pen pen = new Pen(Color.LightSlateGray);
					Point[] points = new Point[]
					{
						new Point(0, 0),
						new Point(item.Size.Width - 1, 0),
						new Point(item.Size.Width - 1, item.Size.Height - 3),
						new Point(0, item.Size.Height - 3),
						new Point(0, 0)
					};
					graphics.DrawLines(pen, points);
				}
				else
				{
					base.OnRenderMenuItemBackground(e);
				}
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x0001C554 File Offset: 0x0001A754
			protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
			{
				Graphics graphics = e.Graphics;
				bool flag = e.ToolStrip is ToolStripDropDown;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(e.Item.Width, 0), Color.LightGray, Color.FromArgb(0, Color.LightGray));
					graphics.FillRectangle(brush, new Rectangle(33, e.Item.Height / 2, e.Item.Width / 4 * 3, 1));
				}
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x0001C5FC File Offset: 0x0001A7FC
			protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
			{
				ToolStripItem item = e.Item;
				Graphics graphics = e.Graphics;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				ToolStripItem item2 = e.Item;
				bool selected = item.Selected;
				bool flag = selected;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				if (flag9)
				{
					Pen pen = new Pen(Color.LightSlateGray);
					Point[] points = new Point[]
					{
						new Point(0, 0),
						new Point(item.Size.Width - 1, 0),
						new Point(item.Size.Width - 1, item.Size.Height - 3),
						new Point(0, item.Size.Height - 3),
						new Point(0, 0)
					};
					graphics.DrawLines(pen, points);
				}
				else
				{
					base.OnRenderMenuItemBackground(e);
				}
			}

			// Token: 0x0400018E RID: 398
			public Font textFont;

			// Token: 0x0400018F RID: 399
			public Color menuItemSelectedColor;

			// Token: 0x04000190 RID: 400
			public Color menuItemBorderColor;
		}

		// Token: 0x0200001B RID: 27
		public class MenuItemRendererT : ToolStripProfessionalRenderer
		{
			// Token: 0x060001E9 RID: 489 RVA: 0x0001C70C File Offset: 0x0001A90C
			public MenuItemRendererT()
			{
				this.textFont = new Font("微软雅黑", 9f / StaticValue.Dpifactor, FontStyle.Regular, GraphicsUnit.Point, 0);
				this.menuItemSelectedColor = Color.White;
				this.menuItemBorderColor = Color.White;
				this.menuItemSelectedColor = Color.White;
				this.menuItemBorderColor = Color.LightSlateGray;
			}

			// Token: 0x060001EA RID: 490 RVA: 0x0001C76C File Offset: 0x0001A96C
			protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
			{
				bool isOnDropDown = e.Item.IsOnDropDown;
				bool flag = isOnDropDown;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				if (flag9)
				{
					bool flag10 = e.Item.Selected && e.Item.Enabled;
					bool flag11 = flag10;
					bool flag12 = flag11;
					bool flag13 = flag12;
					bool flag14 = flag13;
					bool flag15 = flag14;
					bool flag16 = flag15;
					bool flag17 = flag16;
					bool flag18 = flag17;
					bool flag19 = flag18;
					if (flag19)
					{
						this.DrawMenuDropDownItemHighlight(e);
					}
				}
				else
				{
					base.OnRenderMenuItemBackground(e);
				}
			}

			// Token: 0x060001EB RID: 491 RVA: 0x0001C804 File Offset: 0x0001AA04
			public void DrawMenuDropDownItemHighlight(ToolStripItemRenderEventArgs e)
			{
				Rectangle rect = default(Rectangle);
				rect = new Rectangle(2, 0, (int)e.Graphics.VisibleClipBounds.Width - 4, (int)e.Graphics.VisibleClipBounds.Height - 1);
				using (Pen pen = new Pen(this.menuItemBorderColor))
				{
					e.Graphics.DrawRectangle(pen, rect);
				}
			}

			// Token: 0x04000191 RID: 401
			public Font textFont;

			// Token: 0x04000192 RID: 402
			public Color menuItemSelectedColor;

			// Token: 0x04000193 RID: 403
			public Color menuItemBorderColor;
		}

		// Token: 0x0200001C RID: 28
		public class myWebBroswer : WebBrowser
		{
			// Token: 0x060001EC RID: 492 RVA: 0x0001C888 File Offset: 0x0001AA88
			public override bool PreProcessMessage(ref Message msg)
			{
				bool flag = msg.Msg == 256 && (int)msg.WParam == 86 && Control.ModifierKeys == Keys.Control;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					Clipboard.SetDataObject((string)Clipboard.GetDataObject().GetData(DataFormats.UnicodeText));
					HelpWin32.keybd_event(Keys.ControlKey, 0, 0u, 0u);
					HelpWin32.keybd_event(Keys.D9, 0, 0u, 0u);
					HelpWin32.keybd_event(Keys.D9, 0, 2u, 0u);
					HelpWin32.keybd_event(Keys.ControlKey, 0, 2u, 0u);
				}
				bool flag11 = msg.Msg == 256 && (int)msg.WParam == 67 && Control.ModifierKeys == Keys.Control;
				bool flag12 = flag11;
				bool flag13 = flag12;
				bool flag14 = flag13;
				bool flag15 = flag14;
				bool flag16 = flag15;
				bool flag17 = flag16;
				bool flag18 = flag17;
				bool flag19 = flag18;
				bool flag20 = flag19;
				if (flag20)
				{
					HelpWin32.keybd_event(Keys.ControlKey, 0, 0u, 0u);
					HelpWin32.keybd_event(Keys.D8, 0, 0u, 0u);
					HelpWin32.keybd_event(Keys.D8, 0, 2u, 0u);
					HelpWin32.keybd_event(Keys.ControlKey, 0, 2u, 0u);
				}
				return base.PreProcessMessage(ref msg);
			}
		}

		// Token: 0x0200001D RID: 29
		[Description("ToolStripItem that allows selecting a color from a color picker control.")]
		[DefaultEvent("SelectedColorChanged")]
		[ToolboxBitmap(typeof(HelpRepaint.ToolStripColorPicker), "ToolStripColorPicker")]
		[DefaultProperty("Color")]
		[ToolboxItem(false)]
		public class ToolStripColorPicker : ToolStripButton
		{
			// Token: 0x060001EE RID: 494 RVA: 0x0001C9BC File Offset: 0x0001ABBC
			public Point GetOpenPoint()
			{
				bool flag = base.Owner == null;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				Point result;
				if (flag10)
				{
					result = new Point(5, 5);
				}
				else
				{
					int num = 0;
					foreach (object obj in base.Parent.Items)
					{
						ToolStripItem toolStripItem = (ToolStripItem)obj;
						bool flag11 = toolStripItem == this;
						bool flag12 = flag11;
						bool flag13 = flag12;
						bool flag14 = flag13;
						bool flag15 = flag14;
						bool flag16 = flag15;
						bool flag17 = flag16;
						bool flag18 = flag17;
						bool flag19 = flag18;
						bool flag20 = flag19;
						if (flag20)
						{
							break;
						}
						num += toolStripItem.Width;
					}
					result = new Point(num, -4);
				}
				return result;
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060001EF RID: 495 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
			// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000237B File Offset: 0x0000057B
			public Point GetPoint
			{
				get
				{
					return this.GetOpenPoint();
				}
				set
				{
				}
			}
		}

		// Token: 0x0200001E RID: 30
		public class ToolStripEx : ToolStrip
		{
			// Token: 0x060001F2 RID: 498 RVA: 0x00002D7E File Offset: 0x00000F7E
			protected override void WndProc(ref Message m)
			{
				if (m.Msg == 33 && base.CanFocus && !this.Focused)
				{
					base.Focus();
				}
				base.WndProc(ref m);
			}
		}

		// Token: 0x0200001F RID: 31
		public class FloatLayerBase : Form
		{
			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060001F4 RID: 500 RVA: 0x0001CAD0 File Offset: 0x0001ACD0
			// (set) Token: 0x060001F5 RID: 501 RVA: 0x0001CAE8 File Offset: 0x0001ACE8
			[DefaultValue(BorderStyle.Fixed3D)]
			[Description("获取或设置边框类型。")]
			public BorderStyle BorderType
			{
				get
				{
					return this._borderType;
				}
				set
				{
					bool flag = this._borderType != value;
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					bool flag7 = flag6;
					bool flag8 = flag7;
					bool flag9 = flag8;
					bool flag10 = flag9;
					if (flag10)
					{
						this._borderType = value;
						base.Invalidate();
					}
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060001F6 RID: 502 RVA: 0x0001CB34 File Offset: 0x0001AD34
			// (set) Token: 0x060001F7 RID: 503 RVA: 0x0001CB4C File Offset: 0x0001AD4C
			[DefaultValue(Border3DStyle.RaisedInner)]
			[Description("获取或设置三维边框样式。")]
			public Border3DStyle Border3DStyle
			{
				get
				{
					return this._border3DStyle;
				}
				set
				{
					bool flag = this._border3DStyle != value;
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					bool flag7 = flag6;
					bool flag8 = flag7;
					bool flag9 = flag8;
					bool flag10 = flag9;
					if (flag10)
					{
						this._border3DStyle = value;
						base.Invalidate();
					}
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060001F8 RID: 504 RVA: 0x0001CB98 File Offset: 0x0001AD98
			// (set) Token: 0x060001F9 RID: 505 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
			[DefaultValue(ButtonBorderStyle.Solid)]
			[Description("获取或设置线型边框样式。")]
			public ButtonBorderStyle BorderSingleStyle
			{
				get
				{
					return this._borderSingleStyle;
				}
				set
				{
					bool flag = this._borderSingleStyle != value;
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					bool flag7 = flag6;
					bool flag8 = flag7;
					bool flag9 = flag8;
					bool flag10 = flag9;
					if (flag10)
					{
						this._borderSingleStyle = value;
						base.Invalidate();
					}
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060001FA RID: 506 RVA: 0x0001CBFC File Offset: 0x0001ADFC
			// (set) Token: 0x060001FB RID: 507 RVA: 0x0001CC14 File Offset: 0x0001AE14
			[DefaultValue(typeof(Color), "DarkGray")]
			[Description("获取或设置边框颜色（仅当边框类型为线型时有效）。")]
			public Color BorderColor
			{
				get
				{
					return this._borderColor;
				}
				set
				{
					bool flag = !(this._borderColor == value);
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					bool flag7 = flag6;
					bool flag8 = flag7;
					bool flag9 = flag8;
					bool flag10 = flag9;
					if (flag10)
					{
						this._borderColor = value;
						base.Invalidate();
					}
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060001FC RID: 508 RVA: 0x0001CC64 File Offset: 0x0001AE64
			protected sealed override CreateParams CreateParams
			{
				get
				{
					CreateParams createParams = base.CreateParams;
					createParams.Style |= 1073741824;
					createParams.Style |= 67108864;
					createParams.Style |= 65536;
					createParams.Style &= -262145;
					createParams.Style &= -8388609;
					createParams.Style &= -4194305;
					createParams.ExStyle = 0;
					createParams.ExStyle |= 65536;
					return createParams;
				}
			}

			// Token: 0x060001FD RID: 509 RVA: 0x00002DB7 File Offset: 0x00000FB7
			public FloatLayerBase()
			{
				this._mouseMsgFilter = new HelpRepaint.FloatLayerBase.AppMouseMessageHandler(this);
				this.InitBaseProperties();
				this._borderType = BorderStyle.Fixed3D;
				this._border3DStyle = Border3DStyle.RaisedInner;
				this._borderSingleStyle = ButtonBorderStyle.Solid;
				this._borderColor = Color.DarkGray;
			}

			// Token: 0x060001FE RID: 510 RVA: 0x0001CD0C File Offset: 0x0001AF0C
			protected override void OnLoad(EventArgs e)
			{
				bool flag = !this._isShowDialogAgain;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					bool flag11 = !base.DesignMode;
					bool flag12 = flag11;
					bool flag13 = flag12;
					bool flag14 = flag13;
					bool flag15 = flag14;
					bool flag16 = flag15;
					bool flag17 = flag16;
					bool flag18 = flag17;
					bool flag19 = flag18;
					bool flag20 = flag19;
					if (flag20)
					{
						Size frameBorderSize = SystemInformation.FrameBorderSize;
						base.Size -= frameBorderSize + frameBorderSize;
					}
					base.OnLoad(e);
				}
			}

			// Token: 0x060001FF RID: 511 RVA: 0x0001CDA8 File Offset: 0x0001AFA8
			protected override void OnShown(EventArgs e)
			{
				bool flag = !this._isShowDialogAgain;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					bool modal = base.Modal;
					bool flag11 = modal;
					bool flag12 = flag11;
					bool flag13 = flag12;
					bool flag14 = flag13;
					bool flag15 = flag14;
					bool flag16 = flag15;
					bool flag17 = flag16;
					bool flag18 = flag17;
					bool flag19 = flag18;
					if (flag19)
					{
						this._isShowDialogAgain = true;
					}
					Control control = null;
					bool flag20 = !base.DesignMode && (control = base.GetNextControl(this, true)) != null;
					bool flag21 = flag20;
					bool flag22 = flag21;
					bool flag23 = flag22;
					bool flag24 = flag23;
					bool flag25 = flag24;
					bool flag26 = flag25;
					bool flag27 = flag26;
					bool flag28 = flag27;
					bool flag29 = flag28;
					if (flag29)
					{
						control.Focus();
					}
					base.OnShown(e);
				}
			}

			// Token: 0x06000200 RID: 512 RVA: 0x0001CE78 File Offset: 0x0001B078
			protected override void WndProc(ref Message m)
			{
				bool flag = m.Msg == 24 && m.WParam != IntPtr.Zero && m.LParam == IntPtr.Zero && base.Modal && base.Owner != null && !base.Owner.IsDisposed;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					bool isMdiChild = base.Owner.IsMdiChild;
					bool flag11 = isMdiChild;
					bool flag12 = flag11;
					bool flag13 = flag12;
					bool flag14 = flag13;
					bool flag15 = flag14;
					bool flag16 = flag15;
					bool flag17 = flag16;
					bool flag18 = flag17;
					bool flag19 = flag18;
					if (flag19)
					{
						HelpRepaint.FloatLayerBase.NativeMethods.EnableWindow(base.Owner.MdiParent.Handle, true);
						HelpRepaint.FloatLayerBase.NativeMethods.SetParent(base.Handle, base.Owner.Handle);
					}
					else
					{
						HelpRepaint.FloatLayerBase.NativeMethods.EnableWindow(base.Owner.Handle, true);
					}
				}
				base.WndProc(ref m);
			}

			// Token: 0x06000201 RID: 513 RVA: 0x0001CF7C File Offset: 0x0001B17C
			protected override void OnPaintBackground(PaintEventArgs e)
			{
				base.OnPaintBackground(e);
				bool flag = this._borderType == BorderStyle.Fixed3D;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					ControlPaint.DrawBorder3D(e.Graphics, base.ClientRectangle, this.Border3DStyle);
				}
				else
				{
					bool flag11 = this._borderType == BorderStyle.FixedSingle;
					bool flag12 = flag11;
					bool flag13 = flag12;
					bool flag14 = flag13;
					bool flag15 = flag14;
					bool flag16 = flag15;
					bool flag17 = flag16;
					bool flag18 = flag17;
					bool flag19 = flag18;
					bool flag20 = flag19;
					if (flag20)
					{
						ControlPaint.DrawBorder(e.Graphics, base.ClientRectangle, this.BorderColor, this.BorderSingleStyle);
					}
				}
			}

			// Token: 0x06000202 RID: 514 RVA: 0x0001D030 File Offset: 0x0001B230
			protected override void OnVisibleChanged(EventArgs e)
			{
				bool flag = !base.DesignMode;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					bool visible = base.Visible;
					bool flag11 = visible;
					bool flag12 = flag11;
					bool flag13 = flag12;
					bool flag14 = flag13;
					bool flag15 = flag14;
					bool flag16 = flag15;
					bool flag17 = flag16;
					bool flag18 = flag17;
					bool flag19 = flag18;
					if (flag19)
					{
						Application.AddMessageFilter(this._mouseMsgFilter);
					}
					else
					{
						Application.RemoveMessageFilter(this._mouseMsgFilter);
					}
				}
				base.OnVisibleChanged(e);
			}

			// Token: 0x06000203 RID: 515 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
			public DialogResult ShowDialog(Control control)
			{
				return this.ShowDialog(control, 0, control.Height);
			}

			// Token: 0x06000204 RID: 516 RVA: 0x0001D0E4 File Offset: 0x0001B2E4
			public DialogResult ShowDialog(Control control, int offsetX, int offsetY)
			{
				return this.ShowDialog(control, new Point(offsetX, offsetY));
			}

			// Token: 0x06000205 RID: 517 RVA: 0x0001D104 File Offset: 0x0001B304
			public DialogResult ShowDialog(Control control, Point offset)
			{
				return this.ShowDialogInternal(control, offset);
			}

			// Token: 0x06000206 RID: 518 RVA: 0x0001D120 File Offset: 0x0001B320
			public DialogResult ShowDialog(ToolStripItem item)
			{
				return this.ShowDialog(item, 0, item.Height + 4);
			}

			// Token: 0x06000207 RID: 519 RVA: 0x0001D144 File Offset: 0x0001B344
			public DialogResult ShowDialog(ToolStripItem item, int offsetX, int offsetY)
			{
				return this.ShowDialog(item, new Point(offsetX, offsetY));
			}

			// Token: 0x06000208 RID: 520 RVA: 0x0001D104 File Offset: 0x0001B304
			public DialogResult ShowDialog(ToolStripItem item, Point offset)
			{
				return this.ShowDialogInternal(item, offset);
			}

			// Token: 0x06000209 RID: 521 RVA: 0x00002DF4 File Offset: 0x00000FF4
			public void Show(Control control)
			{
				this.Show(control, 0, control.Height);
			}

			// Token: 0x0600020A RID: 522 RVA: 0x00002E06 File Offset: 0x00001006
			public void Show(Control control, int offsetX, int offsetY)
			{
				this.Show(control, new Point(offsetX, offsetY));
			}

			// Token: 0x0600020B RID: 523 RVA: 0x00002E18 File Offset: 0x00001018
			public void Show(Control control, Point offset)
			{
				this.ShowInternal(control, offset);
			}

			// Token: 0x0600020C RID: 524 RVA: 0x00002E24 File Offset: 0x00001024
			public void Show(ToolStripItem item)
			{
				this.Show(item, 0, item.Height);
			}

			// Token: 0x0600020D RID: 525 RVA: 0x00002E36 File Offset: 0x00001036
			public void Show(ToolStripItem item, int offsetX, int offsetY)
			{
				this.Show(item, new Point(offsetX, offsetY));
			}

			// Token: 0x0600020E RID: 526 RVA: 0x00002E18 File Offset: 0x00001018
			public void Show(ToolStripItem item, Point offset)
			{
				this.ShowInternal(item, offset);
			}

			// Token: 0x0600020F RID: 527 RVA: 0x0001D164 File Offset: 0x0001B364
			public DialogResult ShowDialogInternal(Component controlOrItem, Point offset)
			{
				bool visible = base.Visible;
				bool flag = visible;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				DialogResult result;
				if (flag9)
				{
					result = DialogResult.None;
				}
				else
				{
					this.SetLocationAndOwner(controlOrItem, offset);
					result = base.ShowDialog();
				}
				return result;
			}

			// Token: 0x06000210 RID: 528 RVA: 0x0001D1BC File Offset: 0x0001B3BC
			public void ShowInternal(Component controlOrItem, Point offset)
			{
				bool flag = !base.Visible;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					this.SetLocationAndOwner(controlOrItem, offset);
					base.Show();
				}
			}

			// Token: 0x06000211 RID: 529 RVA: 0x0001D208 File Offset: 0x0001B408
			public void SetLocationAndOwner(Component controlOrItem, Point offset)
			{
				Point empty = Point.Empty;
				bool flag = controlOrItem is ToolStripItem;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					ToolStripItem toolStripItem = (ToolStripItem)controlOrItem;
					empty.Offset(toolStripItem.Bounds.Location);
					controlOrItem = toolStripItem.Owner;
				}
				Control control = (Control)controlOrItem;
				empty.Offset(HelpRepaint.FloatLayerBase.GetControlLocationInForm(control));
				empty.Offset(offset);
				base.Location = empty;
				base.Owner = control.FindForm();
			}

			// Token: 0x06000212 RID: 530 RVA: 0x0001D2AC File Offset: 0x0001B4AC
			public static Point GetControlLocationInForm(Control c)
			{
				Point location = c.Location;
				while (!((c = c.Parent) is Form))
				{
					location.Offset(c.Location);
				}
				return location;
			}

			// Token: 0x06000213 RID: 531 RVA: 0x0001D2F0 File Offset: 0x0001B4F0
			public void InitBaseProperties()
			{
				base.ControlBox = false;
				base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
				base.Text = string.Empty;
				base.HelpButton = false;
				base.Icon = null;
				base.IsMdiContainer = false;
				base.MaximizeBox = false;
				base.MinimizeBox = false;
				base.ShowIcon = false;
				base.ShowInTaskbar = false;
				base.StartPosition = FormStartPosition.Manual;
				base.TopMost = false;
				base.WindowState = FormWindowState.Normal;
			}

			// Token: 0x06000214 RID: 532 RVA: 0x00002BA9 File Offset: 0x00000DA9
			[Obsolete("请使用别的重载！", true)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			public new DialogResult ShowDialog()
			{
				throw new NotImplementedException();
			}

			// Token: 0x06000215 RID: 533 RVA: 0x00002BA9 File Offset: 0x00000DA9
			[Obsolete("请使用别的重载！", true)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			public new DialogResult ShowDialog(IWin32Window owner)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06000216 RID: 534 RVA: 0x00002BA9 File Offset: 0x00000DA9
			[Obsolete("请使用别的重载！", true)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			public new void Show()
			{
				throw new NotImplementedException();
			}

			// Token: 0x06000217 RID: 535 RVA: 0x00002BA9 File Offset: 0x00000DA9
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			[Obsolete("请使用别的重载！", true)]
			public new void Show(IWin32Window owner)
			{
				throw new NotImplementedException();
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000218 RID: 536 RVA: 0x0001D36C File Offset: 0x0001B56C
			// (set) Token: 0x06000219 RID: 537 RVA: 0x0000237B File Offset: 0x0000057B
			[Obsolete("禁用该属性！", true)]
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public new bool ControlBox
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600021A RID: 538 RVA: 0x0001D380 File Offset: 0x0001B580
			// (set) Token: 0x0600021B RID: 539 RVA: 0x0000237B File Offset: 0x0000057B
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			[Obsolete("设置边框请使用Border相关属性！", true)]
			public new FormBorderStyle FormBorderStyle
			{
				get
				{
					return FormBorderStyle.SizableToolWindow;
				}
				set
				{
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600021C RID: 540 RVA: 0x0001D394 File Offset: 0x0001B594
			// (set) Token: 0x0600021D RID: 541 RVA: 0x0000237B File Offset: 0x0000057B
			[Browsable(false)]
			[Obsolete("禁用该属性！", true)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public sealed override string Text
			{
				get
				{
					return string.Empty;
				}
				set
				{
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600021E RID: 542 RVA: 0x0001D36C File Offset: 0x0001B56C
			// (set) Token: 0x0600021F RID: 543 RVA: 0x0000237B File Offset: 0x0000057B
			[Obsolete("禁用该属性！", true)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			public new bool HelpButton
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000220 RID: 544 RVA: 0x0001D3AC File Offset: 0x0001B5AC
			// (set) Token: 0x06000221 RID: 545 RVA: 0x0000237B File Offset: 0x0000057B
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			[Obsolete("禁用该属性！", true)]
			public new Image Icon
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000222 RID: 546 RVA: 0x0001D36C File Offset: 0x0001B56C
			// (set) Token: 0x06000223 RID: 547 RVA: 0x0000237B File Offset: 0x0000057B
			[Obsolete("禁用该属性！", true)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			public new bool IsMdiContainer
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000224 RID: 548 RVA: 0x0001D36C File Offset: 0x0001B56C
			// (set) Token: 0x06000225 RID: 549 RVA: 0x0000237B File Offset: 0x0000057B
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Obsolete("禁用该属性！", true)]
			[Browsable(false)]
			public new bool MaximizeBox
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000226 RID: 550 RVA: 0x0001D36C File Offset: 0x0001B56C
			// (set) Token: 0x06000227 RID: 551 RVA: 0x0000237B File Offset: 0x0000057B
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			[Obsolete("禁用该属性！", true)]
			public new bool MinimizeBox
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000228 RID: 552 RVA: 0x0001D36C File Offset: 0x0001B56C
			// (set) Token: 0x06000229 RID: 553 RVA: 0x0000237B File Offset: 0x0000057B
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Obsolete("禁用该属性！", true)]
			public new bool ShowIcon
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x0600022A RID: 554 RVA: 0x0001D36C File Offset: 0x0001B56C
			// (set) Token: 0x0600022B RID: 555 RVA: 0x0000237B File Offset: 0x0000057B
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Obsolete("禁用该属性！", true)]
			public new bool ShowInTaskbar
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600022C RID: 556 RVA: 0x0001D3C0 File Offset: 0x0001B5C0
			// (set) Token: 0x0600022D RID: 557 RVA: 0x0000237B File Offset: 0x0000057B
			[Browsable(false)]
			[Obsolete("禁用该属性！", true)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public new FormStartPosition StartPosition
			{
				get
				{
					return FormStartPosition.Manual;
				}
				set
				{
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600022E RID: 558 RVA: 0x0001D36C File Offset: 0x0001B56C
			// (set) Token: 0x0600022F RID: 559 RVA: 0x0000237B File Offset: 0x0000057B
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[Obsolete("禁用该属性！", true)]
			public new bool TopMost
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x06000230 RID: 560 RVA: 0x0001D3D4 File Offset: 0x0001B5D4
			// (set) Token: 0x06000231 RID: 561 RVA: 0x0000237B File Offset: 0x0000057B
			[Browsable(false)]
			[Obsolete("禁用该属性！", true)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public new FormWindowState WindowState
			{
				get
				{
					return FormWindowState.Normal;
				}
				set
				{
				}
			}

			// Token: 0x04000194 RID: 404
			public readonly HelpRepaint.FloatLayerBase.AppMouseMessageHandler _mouseMsgFilter;

			// Token: 0x04000195 RID: 405
			public bool _isShowDialogAgain;

			// Token: 0x04000196 RID: 406
			public BorderStyle _borderType;

			// Token: 0x04000197 RID: 407
			public Border3DStyle _border3DStyle;

			// Token: 0x04000198 RID: 408
			public ButtonBorderStyle _borderSingleStyle;

			// Token: 0x04000199 RID: 409
			public Color _borderColor;

			// Token: 0x02000020 RID: 32
			public class AppMouseMessageHandler : IMessageFilter
			{
				// Token: 0x06000232 RID: 562 RVA: 0x00002E48 File Offset: 0x00001048
				public AppMouseMessageHandler(HelpRepaint.FloatLayerBase layerForm)
				{
					this._layerForm = layerForm;
				}

				// Token: 0x06000233 RID: 563 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
				public bool PreFilterMessage(ref Message m)
				{
					bool flag = m.Msg == 513 && this._layerForm.Visible && !HelpRepaint.FloatLayerBase.NativeMethods.GetWindowRect(this._layerForm.Handle).Contains(Control.MousePosition);
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					bool flag7 = flag6;
					bool flag8 = flag7;
					bool flag9 = flag8;
					bool flag10 = flag9;
					if (flag10)
					{
						this._layerForm.Hide();
					}
					return false;
				}

				// Token: 0x0400019A RID: 410
				public readonly HelpRepaint.FloatLayerBase _layerForm;
			}

			// Token: 0x02000021 RID: 33
			public static class NativeMethods
			{
				// Token: 0x06000234 RID: 564
				[DllImport("user32.dll")]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

				// Token: 0x06000235 RID: 565
				[DllImport("user32.dll", CharSet = CharSet.Auto)]
				public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

				// Token: 0x06000236 RID: 566
				[DllImport("user32.dll")]
				public static extern bool ReleaseCapture();

				// Token: 0x06000237 RID: 567
				[DllImport("user32.dll", SetLastError = true)]
				public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

				// Token: 0x06000238 RID: 568
				[DllImport("user32.dll", SetLastError = true)]
				public static extern bool GetWindowRect(IntPtr hwnd, out HelpRepaint.FloatLayerBase.NativeMethods.RECT lpRect);

				// Token: 0x06000239 RID: 569 RVA: 0x0001D46C File Offset: 0x0001B66C
				public static Rectangle GetWindowRect(IntPtr hwnd)
				{
					HelpRepaint.FloatLayerBase.NativeMethods.RECT rect;
					HelpRepaint.FloatLayerBase.NativeMethods.GetWindowRect(hwnd, out rect);
					return (Rectangle)rect;
				}

				// Token: 0x02000022 RID: 34
				public struct RECT
				{
					// Token: 0x0600023A RID: 570 RVA: 0x0001D490 File Offset: 0x0001B690
					public static explicit operator Rectangle(HelpRepaint.FloatLayerBase.NativeMethods.RECT rect)
					{
						return new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
					}

					// Token: 0x0400019B RID: 411
					public int left;

					// Token: 0x0400019C RID: 412
					public int top;

					// Token: 0x0400019D RID: 413
					public int right;

					// Token: 0x0400019E RID: 414
					public int bottom;
				}
			}
		}

		// Token: 0x02000023 RID: 35
		public class ColorPicker : ToolStripButton
		{
			// Token: 0x0600023B RID: 571 RVA: 0x00002E59 File Offset: 0x00001059
			public ColorPicker()
			{
				this.cp = new HelpRepaint.HWColorPicker
				{
					BorderType = BorderStyle.FixedSingle
				};
			}

			// Token: 0x0600023C RID: 572 RVA: 0x0001D4D0 File Offset: 0x0001B6D0
			protected override void OnClick(EventArgs e)
			{
				bool flag = this.cp.ShowDialog(this) == DialogResult.OK;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				if (flag10)
				{
					this.select_color = this.cp.SelectedColored;
					base.OnClick(e);
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x0600023D RID: 573 RVA: 0x0001D52C File Offset: 0x0001B72C
			public Color SelectedColor
			{
				get
				{
					return this.select_color;
				}
			}

			// Token: 0x0400019F RID: 415
			private readonly HelpRepaint.HWColorPicker cp;

			// Token: 0x040001A0 RID: 416
			public Color select_color;
		}

		// Token: 0x02000024 RID: 36
		public class AdvRichTextBox : RichTextBox
		{
			// Token: 0x0600023E RID: 574 RVA: 0x0001D544 File Offset: 0x0001B744
			public void BeginUpdate()
			{
				this.updating++;
				bool flag = this.updating <= 1;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				if (flag9)
				{
					this.oldEventMask = HelpRepaint.AdvRichTextBox.SendMessage(new HandleRef(this, base.Handle), 1073, 0, 0);
					HelpRepaint.AdvRichTextBox.SendMessage(new HandleRef(this, base.Handle), 11, 0, 0);
				}
			}

			// Token: 0x0600023F RID: 575 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
			public void EndUpdate()
			{
				this.updating--;
				bool flag = this.updating <= 0;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				if (flag9)
				{
					HelpRepaint.AdvRichTextBox.SendMessage(new HandleRef(this, base.Handle), 11, 1, 0);
					HelpRepaint.AdvRichTextBox.SendMessage(new HandleRef(this, base.Handle), 1073, 0, this.oldEventMask);
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000240 RID: 576 RVA: 0x0001D63C File Offset: 0x0001B83C
			// (set) Token: 0x06000241 RID: 577 RVA: 0x0001D6C4 File Offset: 0x0001B8C4
			public new HelpRepaint.TextAlign SelectionAlignment
			{
				get
				{
					HelpRepaint.AdvRichTextBox.PARAFORMAT paraformat = default(HelpRepaint.AdvRichTextBox.PARAFORMAT);
					paraformat.cbSize = Marshal.SizeOf(paraformat);
					HelpRepaint.AdvRichTextBox.SendMessage(new HandleRef(this, base.Handle), 1085, 1, ref paraformat);
					bool flag = (paraformat.dwMask & 8u) == 0u;
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					bool flag7 = flag6;
					bool flag8 = flag7;
					bool flag9 = flag8;
					HelpRepaint.TextAlign result;
					if (flag9)
					{
						result = HelpRepaint.TextAlign.Left;
					}
					else
					{
						result = (HelpRepaint.TextAlign)paraformat.wAlignment;
					}
					return result;
				}
				set
				{
					HelpRepaint.AdvRichTextBox.PARAFORMAT paraformat = default(HelpRepaint.AdvRichTextBox.PARAFORMAT);
					paraformat.cbSize = Marshal.SizeOf(paraformat);
					paraformat.dwMask = 8u;
					paraformat.wAlignment = (short)value;
					HelpRepaint.AdvRichTextBox.SendMessage(new HandleRef(this, base.Handle), 1095, 1, ref paraformat);
				}
			}

			// Token: 0x06000242 RID: 578 RVA: 0x0001D718 File Offset: 0x0001B918
			protected override void OnHandleCreated(EventArgs e)
			{
				base.OnHandleCreated(e);
				bool flag = !base.AutoWordSelection;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				if (flag9)
				{
					base.AutoWordSelection = true;
					base.AutoWordSelection = false;
				}
				HelpRepaint.AdvRichTextBox.SendMessage(new HandleRef(this, base.Handle), 1226, 1, 1);
			}

			// Token: 0x06000243 RID: 579
			[DllImport("user32", CharSet = CharSet.Auto)]
			private static extern int SendMessage(HandleRef hWnd, int msg, int wParam, int lParam);

			// Token: 0x06000244 RID: 580
			[DllImport("user32", CharSet = CharSet.Auto)]
			private static extern int SendMessage(HandleRef hWnd, int msg, int wParam, ref HelpRepaint.AdvRichTextBox.PARAFORMAT lp);

			// Token: 0x06000245 RID: 581 RVA: 0x0001D780 File Offset: 0x0001B980
			public void SetLineSpace()
			{
				HelpRepaint.AdvRichTextBox.PARAFORMAT paraformat = default(HelpRepaint.AdvRichTextBox.PARAFORMAT);
				paraformat.cbSize = Marshal.SizeOf(paraformat);
				paraformat.bLineSpacingRule = 4;
				paraformat.dyLineSpacing = 400;
				paraformat.dwMask = 256u;
				HelpRepaint.AdvRichTextBox.SendMessage(new HandleRef(this, base.Handle), 1095, 0, ref paraformat);
			}

			// Token: 0x17000036 RID: 54
			// (set) Token: 0x06000246 RID: 582 RVA: 0x00002E76 File Offset: 0x00001076
			public string SetLine
			{
				set
				{
					this.SetLineSpace();
				}
			}

			// Token: 0x040001A1 RID: 417
			private const int EM_SETEVENTMASK = 1073;

			// Token: 0x040001A2 RID: 418
			private const int EM_GETPARAFORMAT = 1085;

			// Token: 0x040001A3 RID: 419
			private const int EM_SETPARAFORMAT = 1095;

			// Token: 0x040001A4 RID: 420
			private const int EM_SETTYPOGRAPHYOPTIONS = 1226;

			// Token: 0x040001A5 RID: 421
			private const int WM_SETREDRAW = 11;

			// Token: 0x040001A6 RID: 422
			private const int TO_ADVANCEDTYPOGRAPHY = 1;

			// Token: 0x040001A7 RID: 423
			private const int PFM_ALIGNMENT = 8;

			// Token: 0x040001A8 RID: 424
			private const int SCF_SELECTION = 1;

			// Token: 0x040001A9 RID: 425
			private int updating;

			// Token: 0x040001AA RID: 426
			private int oldEventMask;

			// Token: 0x02000025 RID: 37
			private struct PARAFORMAT
			{
				// Token: 0x040001AB RID: 427
				public int cbSize;

				// Token: 0x040001AC RID: 428
				public uint dwMask;

				// Token: 0x040001AD RID: 429
				public short wNumbering;

				// Token: 0x040001AE RID: 430
				public short wReserved;

				// Token: 0x040001AF RID: 431
				public int dxStartIndent;

				// Token: 0x040001B0 RID: 432
				public int dxRightIndent;

				// Token: 0x040001B1 RID: 433
				public int dxOffset;

				// Token: 0x040001B2 RID: 434
				public short wAlignment;

				// Token: 0x040001B3 RID: 435
				public short cTabCount;

				// Token: 0x040001B4 RID: 436
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
				public int[] rgxTabs;

				// Token: 0x040001B5 RID: 437
				public int dySpaceBefore;

				// Token: 0x040001B6 RID: 438
				public int dySpaceAfter;

				// Token: 0x040001B7 RID: 439
				public int dyLineSpacing;

				// Token: 0x040001B8 RID: 440
				public short sStyle;

				// Token: 0x040001B9 RID: 441
				public byte bLineSpacingRule;

				// Token: 0x040001BA RID: 442
				public byte bOutlineLevel;

				// Token: 0x040001BB RID: 443
				public short wShadingWeight;

				// Token: 0x040001BC RID: 444
				public short wShadingStyle;

				// Token: 0x040001BD RID: 445
				public short wNumberingStart;

				// Token: 0x040001BE RID: 446
				public short wNumberingStyle;

				// Token: 0x040001BF RID: 447
				public short wNumberingTab;

				// Token: 0x040001C0 RID: 448
				public short wBorderSpace;

				// Token: 0x040001C1 RID: 449
				public short wBorderWidth;

				// Token: 0x040001C2 RID: 450
				public short wBorders;
			}
		}

		// Token: 0x02000026 RID: 38
		public enum TextAlign
		{
			// Token: 0x040001C4 RID: 452
			Left = 1,
			// Token: 0x040001C5 RID: 453
			Right,
			// Token: 0x040001C6 RID: 454
			Center,
			// Token: 0x040001C7 RID: 455
			Justify
		}
	}
}
