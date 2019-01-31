using System;
using System.Drawing;

namespace 天若OCR文字识别
{
	// Token: 0x02000030 RID: 48
	public static class StaticValue
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x0001F7D4 File Offset: 0x0001D9D4
		static StaticValue()
		{
			StaticValue.note = "";
			StaticValue.v_notecount = 40;
			StaticValue.copy_f = "无格式";
			StaticValue.content = "天若OCR更新";
			StaticValue.zh_en = true;
			StaticValue.zh_jp = false;
			StaticValue.zh_ko = false;
			StaticValue.set_默认 = true;
			StaticValue.set_拆分 = false;
			StaticValue.set_合并 = false;
			StaticValue.set_翻译 = false;
			StaticValue.set_记录 = false;
			StaticValue.set_截图 = false;
			StaticValue.Dpifactor = 1f;
			StaticValue.current_v = "4.49";
			StaticValue.v_date = "2019-01-13";
		}

		// Token: 0x04000206 RID: 518
		public static string v_Split;

		// Token: 0x04000207 RID: 519
		public static string v_Restore;

		// Token: 0x04000208 RID: 520
		public static string v_Merge;

		// Token: 0x04000209 RID: 521
		public static string v_googleTranslate_txt;

		// Token: 0x0400020A RID: 522
		public static string v_googleTranslate_back;

		// Token: 0x0400020B RID: 523
		public static int image_h;

		// Token: 0x0400020C RID: 524
		public static int image_w;

		// Token: 0x0400020D RID: 525
		public static string v_single;

		// Token: 0x0400020E RID: 526
		public static Image image_OCR;

		// Token: 0x0400020F RID: 527
		public static string current_v;

		// Token: 0x04000210 RID: 528
		public static string copy_f;

		// Token: 0x04000211 RID: 529
		public static string content;

		// Token: 0x04000212 RID: 530
		public static bool zh_en;

		// Token: 0x04000213 RID: 531
		public static bool zh_jp;

		// Token: 0x04000214 RID: 532
		public static bool zh_ko;

		// Token: 0x04000215 RID: 533
		public static bool set_默认;

		// Token: 0x04000216 RID: 534
		public static bool set_拆分;

		// Token: 0x04000217 RID: 535
		public static bool set_合并;

		// Token: 0x04000218 RID: 536
		public static bool set_翻译;

		// Token: 0x04000219 RID: 537
		public static bool set_记录;

		// Token: 0x0400021A RID: 538
		public static bool set_截图;

		// Token: 0x0400021B RID: 539
		public static float Dpifactor;

		// Token: 0x0400021C RID: 540
		public static IntPtr mainhandle;

		// Token: 0x0400021D RID: 541
		public static string note;

		// Token: 0x0400021E RID: 542
		public static string[] v_note;

		// Token: 0x0400021F RID: 543
		public static int v_notecount;

		// Token: 0x04000220 RID: 544
		public static string baiduAPI_ID = "";

		// Token: 0x04000221 RID: 545
		public static string baiduAPI_key = "";

		// Token: 0x04000222 RID: 546
		public static bool 截图排斥;

		// Token: 0x04000223 RID: 547
		public static bool v_topmost;

		// Token: 0x04000224 RID: 548
		public static Image v_screenimage;

		// Token: 0x04000225 RID: 549
		public static string v_date;
	}
}
