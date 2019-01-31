using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

namespace 天若OCR文字识别
{
	// Token: 0x0200002F RID: 47
	internal static class Program
	{
		// Token: 0x06000288 RID: 648 RVA: 0x0001DB94 File Offset: 0x0001BD94
		private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string name = MethodBase.GetCurrentMethod().DeclaringType.Namespace + "." + new AssemblyName(args.Name).Name + ".dll";
			Assembly result;
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name))
			{
				byte[] array = new byte[manifestResourceStream.Length];
				manifestResourceStream.Read(array, 0, array.Length);
				result = Assembly.Load(array);
			}
			return result;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002EEC File Offset: 0x000010EC
		public static void ProgramStart()
		{
			Program.ProgramStarted = new EventWaitHandle(false, EventResetMode.AutoReset, "天若OCR文字识别",out Program.createNew);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001DC2C File Offset: 0x0001BE2C
		public static void Get_version(string url)
		{
			try
			{
				string input = "";
				HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
				httpWebRequest.Method = "GET";
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
					{
						input = streamReader.ReadToEnd();
						streamReader.Close();
						httpWebResponse.Close();
					}
				}
				httpWebRequest.Abort();
				httpWebRequest = null;
				string text = "<li";
				string text2 = "</ul></li>";
				string text3 = "id=\"ml_";
				string text4 = "\"";
				string text5 = "";
				MatchCollection matchCollection = Regex.Matches(input, string.Concat(new string[]
				{
					"(?<=(",
					text,
					"))[.\\s\\S]*?(?=(",
					text2,
					"))"
				}));
				for (int i = 0; i < matchCollection.Count; i++)
				{
					bool flag = matchCollection[i].Value.ToString().Contains(StaticValue.content);
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					if (flag6)
					{
						text5 = new Regex(string.Concat(new string[]
						{
							"(?<=(",
							text3,
							"))[.\\s\\S]*?(?=(",
							text4,
							"))"
						}), RegexOptions.Multiline | RegexOptions.Singleline).Match(matchCollection[i].Value.ToString()).Value;
						break;
					}
				}
				string text6 = Program.Get_html("http://cc.ys168.com/f_ht/ajcx/wj.aspx?cz=dq&mlbh=" + text5 + "&_dlmc=tianruoyouxin&_dlmm=");
				string text7 = "版本V";
				string text8 = "<";
				bool flag7 = text6 == "";
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				bool flag11 = flag10;
				bool flag12 = flag11;
				if (flag12)
				{
					Program.version_url = "0";
					Program.download_url = "0";
				}
				else
				{
					bool flag13 = text5 == "";
					bool flag14 = flag13;
					bool flag15 = flag14;
					bool flag16 = flag15;
					bool flag17 = flag16;
					bool flag18 = flag17;
					if (flag18)
					{
						Program.version_url = "0";
						Program.download_url = "0";
					}
					else
					{
						Program.version_url = new Regex(string.Concat(new string[]
						{
							"(?<=(",
							text7,
							"))[.\\s\\S]*?(?=(",
							text8,
							"))"
						}), RegexOptions.Multiline | RegexOptions.Singleline).Match(text6).Value;
						string text9 = "url=\"";
						string text10 = "\"";
						Program.download_url = new Regex(string.Concat(new string[]
						{
							"(?<=(",
							text9,
							"))[.\\s\\S]*?(?=(",
							text10,
							"))"
						}), RegexOptions.Multiline | RegexOptions.Singleline).Match(text6).Value;
					}
				}
			}
			catch
			{
				Program.version_url = "0";
				Program.download_url = "0";
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001DF70 File Offset: 0x0001C170
		[STAThread]
		public static void Main(string[] args)
		{
			Program.setini();
			Program.bool_error();
			Program.checkTimer = new System.Timers.Timer();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Version version = Environment.OSVersion.Version;
			Version value = new Version("6.1");
			Program.factor = Program.GetDpi_factor();
			if (version.CompareTo(value) >= 0)
			{
				Program.SetProcessDPIAware();
			}
			Program.ProgramStart();
			if (!Program.createNew)
			{
				Program.ProgramStarted.Set();
				Fmflags fmflags = new Fmflags();
				fmflags.Show();
				fmflags.DrawStr("软件已经运行");
				return;
			}
			try
			{
				AppDomain.CurrentDomain.AssemblyResolve += Program.CurrentDomain_AssemblyResolve;
			}
			catch
			{
				MessageBox.Show("调用dll出错！");
			}
			if (args.Length != 0 && args[0] == "更新")
			{
				new FmSetting
				{
					Start_set = ""
				}.ShowDialog();
			}
			if (inihelp.GetValue("更新", "检测更新") == "True" || inihelp.GetValue("更新", "检测更新") == "发生错误")
			{
				//MessageBox.Show("开放全新的版本，有兴趣的想办法联系我，受制于吾爱规矩该软件不留联系方式。\r\n若不愿使用，请在设置中关闭检测更新！\r\n该版本不再进行维护！", "提醒");
				new Thread(new ThreadStart(Program.check_update)).Start();
				if (inihelp.GetValue("更新", "更新间隔") == "True")
				{
					Program.checkTimer.Enabled = true;
					Program.checkTimer.Interval = 3600000.0 * (double)Convert.ToInt32(inihelp.GetValue("更新", "间隔时间"));
					Program.checkTimer.Elapsed += Program.checkTimer_Elapsed;
					Program.checkTimer.Start();
				}
			}
			else
			{
				Fmflags fmflags2 = new Fmflags();
				fmflags2.Show();
				fmflags2.DrawStr("天若OCR文字识别");
			}
			Program.ReleaseDLL();
			Application.Run(new FmMain());
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0001E14C File Offset: 0x0001C34C
		public static void DeleteFile(string path)
		{
			Messageload messageload = new Messageload();
			messageload.ShowDialog();
			DialogResult dialogResult = messageload.DialogResult;
			bool flag = File.GetAttributes(path) == FileAttributes.Directory;
			bool flag2 = flag;
			bool flag3 = flag2;
			bool flag4 = flag3;
			bool flag5 = flag4;
			bool flag6 = flag5;
			if (flag6)
			{
				Directory.Delete(path, true);
			}
			else
			{
				File.Delete(path);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
		public static string Get_html(string url)
		{
			string result = "";
			HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "GET";
			httpWebRequest.Headers.Add("Accept-Language:zh-CN,zh;q=0.8");
			try
			{
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
					{
						result = streamReader.ReadToEnd();
						streamReader.Close();
						httpWebResponse.Close();
					}
				}
				httpWebRequest.Abort();
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600028E RID: 654
		[DllImport("wininet")]
		private static extern bool InternetGetConnectedState(out int connectionDescription, int reservedValue);

		// Token: 0x0600028F RID: 655 RVA: 0x0001E278 File Offset: 0x0001C478
		public static bool IsConnectedInternet()
		{
			int num = 0;
			return Program.InternetGetConnectedState(out num, 0);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001E294 File Offset: 0x0001C494
		public static int GetPidByProcessName(string processName)
		{
			Process[] processesByName = Process.GetProcessesByName(processName);
			int num = 0;
			bool flag = num >= processesByName.Length;
			bool flag2 = flag;
			bool flag3 = flag2;
			bool flag4 = flag3;
			bool flag5 = flag4;
			bool flag6 = flag5;
			int result;
			if (flag6)
			{
				result = 0;
			}
			else
			{
				result = processesByName[num].Id;
			}
			return result;
		}

		// Token: 0x06000291 RID: 657
		[DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();

		// Token: 0x06000292 RID: 658 RVA: 0x0001E2E8 File Offset: 0x0001C4E8
		public static float GetDpi_factor()
		{
			float result;
			try
			{
				string name = "AppliedDPI";
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop\\WindowMetrics", true);
				string value = registryKey.GetValue(name).ToString();
				registryKey.Close();
				result = Convert.ToSingle(value) / 96f;
			}
			catch
			{
				result = 1f;
			}
			return result;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002F05 File Offset: 0x00001105
		public static void check_update()
		{
			Program.Get_update("http://cc.ys168.com/f_ht/ajcx/ml.aspx?cz=ml_dq&_dlmc=tianruoyouxin&_dlmm=");
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001E354 File Offset: 0x0001C554
		public static void Get_update(string url)
		{
			Fmflags fmflags = new Fmflags();
			fmflags.Show();
			fmflags.DrawStr("天若OCR文字识别");
			try
			{
				string input = "";
				HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
				httpWebRequest.Method = "GET";
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
					{
						input = streamReader.ReadToEnd();
						streamReader.Close();
						httpWebResponse.Close();
					}
				}
				httpWebRequest.Abort();
				httpWebRequest = null;
				string text = "<li";
				string text2 = "</ul></li>";
				string text3 = "id=\"ml_";
				string text4 = "\"";
				string text5 = "";
				MatchCollection matchCollection = Regex.Matches(input, string.Concat(new string[]
				{
					"(?<=(",
					text,
					"))[.\\s\\S]*?(?=(",
					text2,
					"))"
				}));
				for (int i = 0; i < matchCollection.Count; i++)
				{
					if (matchCollection[i].Value.ToString().Contains(StaticValue.content))
					{
						text5 = new Regex(string.Concat(new string[]
						{
							"(?<=(",
							text3,
							"))[.\\s\\S]*?(?=(",
							text4,
							"))"
						}), RegexOptions.Multiline | RegexOptions.Singleline).Match(matchCollection[i].Value.ToString()).Value;
						break;
					}
				}
				string text6 = Program.Get_html("http://cc.ys168.com/f_ht/ajcx/wj.aspx?cz=dq&mlbh=" + text5 + "&_dlmc=tianruoyouxin&_dlmm=");
				string text7 = "版本V";
				string text8 = "<";
				if (text6 == "")
				{
					Program.version_url = "0";
					Program.download_url = "0";
				}
				else if (text5 == "")
				{
					Program.version_url = "0";
					Program.download_url = "0";
				}
				else
				{
					Program.version_url = new Regex(string.Concat(new string[]
					{
						"(?<=(",
						text7,
						"))[.\\s\\S]*?(?=(",
						text8,
						"))"
					}), RegexOptions.Multiline | RegexOptions.Singleline).Match(text6).Value;
					string text9 = "url=\"";
					string text10 = "\"";
					Program.download_url = new Regex(string.Concat(new string[]
					{
						"(?<=(",
						text9,
						"))[.\\s\\S]*?(?=(",
						text10,
						"))"
					}), RegexOptions.Multiline | RegexOptions.Singleline).Match(text6).Value;
				}
			}
			catch
			{
				Program.version_url = "0";
				Program.download_url = "0";
			}
			if (Program.version_url != "0" && Convert.ToSingle(Program.version_url) > Convert.ToSingle(StaticValue.current_v))
			{
				fmflags.Show();
				fmflags.DrawStr("有新版本V" + Program.version_url);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001E688 File Offset: 0x0001C888
		private static void DeleteItself()
		{
			string text = Path.GetDirectoryName(Application.ExecutablePath) + "\\DeleteItself.bat";
			using (StreamWriter streamWriter = new StreamWriter(text, false, Encoding.Default))
			{
				streamWriter.Write(string.Format(":del\r\n del \"{0}\"\r\nif exist \"{0}\" goto del\r\ndel %0\r\n", Application.ExecutablePath.Replace("/", "\\")));
			}
			HelpWin32.WinExec(text, 0u);
			Application.Exit();
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001E70C File Offset: 0x0001C90C
		public static void ReleaseDLL()
		{
			if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data"))
			{
				Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Data");
			}
			if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\screenshot.wav"))
			{
				Program.StreamToFile(Assembly.GetExecutingAssembly().GetManifestResourceStream("天若OCR文字识别.screenshot.wav"), "Data\\screenshot.wav");
			}
			if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\update.exe"))
			{
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("天若OCR文字识别.update.exe");
				byte[] array = new byte[manifestResourceStream.Length];
				manifestResourceStream.Read(array, 0, (int)manifestResourceStream.Length);
				File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "Data\\update.exe", array);
			}
			if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Emgu.CV.World.dll"))
			{
				Stream manifestResourceStream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream("天若OCR文字识别.Emgu.CV.World.dll");
				byte[] array2 = new byte[manifestResourceStream2.Length];
				manifestResourceStream2.Read(array2, 0, (int)manifestResourceStream2.Length);
				File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "Emgu.CV.World.dll", array2);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001DC2C File Offset: 0x0001BE2C
		public static void Get_update_x(string url)
		{
			try
			{
				string input = "";
				HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
				httpWebRequest.Method = "GET";
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
					{
						input = streamReader.ReadToEnd();
						streamReader.Close();
						httpWebResponse.Close();
					}
				}
				httpWebRequest.Abort();
				httpWebRequest = null;
				string text = "<li";
				string text2 = "</ul></li>";
				string text3 = "id=\"ml_";
				string text4 = "\"";
				string text5 = "";
				MatchCollection matchCollection = Regex.Matches(input, string.Concat(new string[]
				{
					"(?<=(",
					text,
					"))[.\\s\\S]*?(?=(",
					text2,
					"))"
				}));
				for (int i = 0; i < matchCollection.Count; i++)
				{
					bool flag = matchCollection[i].Value.ToString().Contains(StaticValue.content);
					bool flag2 = flag;
					bool flag3 = flag2;
					bool flag4 = flag3;
					bool flag5 = flag4;
					bool flag6 = flag5;
					if (flag6)
					{
						text5 = new Regex(string.Concat(new string[]
						{
							"(?<=(",
							text3,
							"))[.\\s\\S]*?(?=(",
							text4,
							"))"
						}), RegexOptions.Multiline | RegexOptions.Singleline).Match(matchCollection[i].Value.ToString()).Value;
						break;
					}
				}
				string text6 = Program.Get_html("http://cc.ys168.com/f_ht/ajcx/wj.aspx?cz=dq&mlbh=" + text5 + "&_dlmc=tianruoyouxin&_dlmm=");
				string text7 = "版本V";
				string text8 = "<";
				bool flag7 = text6 == "";
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				bool flag11 = flag10;
				bool flag12 = flag11;
				if (flag12)
				{
					Program.version_url = "0";
					Program.download_url = "0";
				}
				else
				{
					bool flag13 = text5 == "";
					bool flag14 = flag13;
					bool flag15 = flag14;
					bool flag16 = flag15;
					bool flag17 = flag16;
					bool flag18 = flag17;
					if (flag18)
					{
						Program.version_url = "0";
						Program.download_url = "0";
					}
					else
					{
						Program.version_url = new Regex(string.Concat(new string[]
						{
							"(?<=(",
							text7,
							"))[.\\s\\S]*?(?=(",
							text8,
							"))"
						}), RegexOptions.Multiline | RegexOptions.Singleline).Match(text6).Value;
						string text9 = "url=\"";
						string text10 = "\"";
						Program.download_url = new Regex(string.Concat(new string[]
						{
							"(?<=(",
							text9,
							"))[.\\s\\S]*?(?=(",
							text10,
							"))"
						}), RegexOptions.Multiline | RegexOptions.Singleline).Match(text6).Value;
					}
				}
			}
			catch
			{
				Program.version_url = "0";
				Program.download_url = "0";
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002F13 File Offset: 0x00001113
		public static void checkTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			Program.Get_update_check("http://cc.ys168.com/f_ht/ajcx/ml.aspx?cz=ml_dq&_dlmc=tianruoyouxin&_dlmm=");
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001E854 File Offset: 0x0001CA54
		public static void Get_update_check(string url)
		{
			try
			{
				string input = "";
				HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
				httpWebRequest.Method = "GET";
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
					{
						input = streamReader.ReadToEnd();
						streamReader.Close();
						httpWebResponse.Close();
					}
				}
				httpWebRequest.Abort();
				httpWebRequest = null;
				string text = "<li";
				string text2 = "</ul></li>";
				string text3 = "id=\"ml_";
				string text4 = "\"";
				string text5 = "";
				MatchCollection matchCollection = Regex.Matches(input, string.Concat(new string[]
				{
					"(?<=(",
					text,
					"))[.\\s\\S]*?(?=(",
					text2,
					"))"
				}));
				for (int i = 0; i < matchCollection.Count; i++)
				{
					bool flag = matchCollection[i].Value.ToString().Contains(StaticValue.content);
					bool flag2 = flag;
					bool flag3 = flag2;
					if (flag3)
					{
						text5 = new Regex(string.Concat(new string[]
						{
							"(?<=(",
							text3,
							"))[.\\s\\S]*?(?=(",
							text4,
							"))"
						}), RegexOptions.Multiline | RegexOptions.Singleline).Match(matchCollection[i].Value.ToString()).Value;
						break;
					}
				}
				string text6 = Program.Get_html("http://cc.ys168.com/f_ht/ajcx/wj.aspx?cz=dq&mlbh=" + text5 + "&_dlmc=tianruoyouxin&_dlmm=");
				string text7 = "版本V";
				string text8 = "<";
				bool flag4 = text6 != "" || text5 != "";
				bool flag5 = flag4;
				bool flag6 = flag5;
				if (flag6)
				{
					Program.version_url = new Regex(string.Concat(new string[]
					{
						"(?<=(",
						text7,
						"))[.\\s\\S]*?(?=(",
						text8,
						"))"
					}), RegexOptions.Multiline | RegexOptions.Singleline).Match(text6).Value;
					string text9 = "url=\"";
					string text10 = "\"";
					Program.download_url = new Regex(string.Concat(new string[]
					{
						"(?<=(",
						text9,
						"))[.\\s\\S]*?(?=(",
						text10,
						"))"
					}), RegexOptions.Multiline | RegexOptions.Singleline).Match(text6).Value;
				}
				else
				{
					Program.version_url = "0";
					Program.download_url = "0";
				}
			}
			catch
			{
				Program.version_url = "0";
				Program.download_url = "0";
			}
			bool flag7 = !(Program.version_url != "0") || Convert.ToSingle(Program.version_url) <= Convert.ToSingle(StaticValue.current_v);
			bool flag8 = flag7;
			bool flag9 = flag8;
			if (flag9)
			{
				Fmflags fmflags = new Fmflags();
				fmflags.Show();
				fmflags.DrawStr("当前已是最新版本");
			}
			else
			{
				Fmflags fmflags2 = new Fmflags();
				fmflags2.Show();
				fmflags2.DrawStr("有新版本V" + Program.version_url);
				Program.Get_update_x("http://cc.ys168.com/f_ht/ajcx/ml.aspx?cz=ml_dq&_dlmc=tianruoyouxin&_dlmm=");
				bool flag10 = Program.version_url == "0";
				bool flag11 = flag10;
				bool flag12 = flag11;
				if (flag12)
				{
					MessageBox.Show("更新程序失效，请到百度网盘下载！", "提醒");
					Process.Start("https://pan.baidu.com/s/1P2xb9kBwX1gj8j2_APivZw");
				}
				else
				{
					bool flag13 = Program.version_url != "0";
					bool flag14 = flag13;
					bool flag15 = flag14;
					if (flag15)
					{
						bool flag16 = new Version(Program.version_url) > new Version(StaticValue.current_v);
						bool flag17 = flag16;
						bool flag18 = flag17;
						if (flag18)
						{
							Process.Start("Data\\update.exe", " " + Program.download_url + " " + Path.GetFileName(Application.ExecutablePath));
							Environment.Exit(0);
						}
						else
						{
							Process.Start("Data\\update.exe", " 最新版本");
						}
					}
				}
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002F13 File Offset: 0x00001113
		public static void check_update_cc()
		{
			Program.Get_update_check("http://cc.ys168.com/f_ht/ajcx/ml.aspx?cz=ml_dq&_dlmc=tianruoyouxin&_dlmm=");
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0001ECAC File Offset: 0x0001CEAC
		public static void setini()
		{
			string path = AppDomain.CurrentDomain.BaseDirectory + "Data\\config.ini";
			if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data"))
			{
				Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Data");
			}
			if (!File.Exists(path))
			{
				using (File.Create(path))
				{
				}
				inihelp.SetValue("配置", "接口", "搜狗");
				inihelp.SetValue("配置", "开机自启", "True");
				inihelp.SetValue("配置", "快速翻译", "True");
				inihelp.SetValue("配置", "识别弹窗", "True");
				inihelp.SetValue("配置", "窗体动画", "窗体");
				inihelp.SetValue("配置", "记录数目", "20");
				inihelp.SetValue("配置", "自动保存", "True");
				inihelp.SetValue("配置", "截图位置", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
				inihelp.SetValue("配置", "翻译接口", "谷歌");
				inihelp.SetValue("快捷键", "文字识别", "F4");
				inihelp.SetValue("快捷键", "翻译文本", "F9");
				inihelp.SetValue("快捷键", "记录界面", "请按下快捷键");
				inihelp.SetValue("快捷键", "识别界面", "请按下快捷键");
				inihelp.SetValue("密钥_百度", "secret_id", "YsZKG1wha34PlDOPYaIrIIKO");
				inihelp.SetValue("密钥_百度", "secret_key", "HPRZtdOHrdnnETVsZM2Nx7vbDkMfxrkD");
				inihelp.SetValue("代理", "代理类型", "系统代理");
				inihelp.SetValue("代理", "服务器", "");
				inihelp.SetValue("代理", "端口", "");
				inihelp.SetValue("代理", "需要密码", "False");
				inihelp.SetValue("代理", "服务器账号", "");
				inihelp.SetValue("代理", "服务器密码", "");
				inihelp.SetValue("更新", "检测更新", "True");
				inihelp.SetValue("更新", "更新间隔", "True");
				inihelp.SetValue("更新", "间隔时间", "24");
				inihelp.SetValue("截图音效", "自动保存", "True");
				inihelp.SetValue("截图音效", "音效路径", "Data\\screenshot.wav");
				inihelp.SetValue("截图音效", "粘贴板", "False");
				inihelp.SetValue("工具栏", "合并", "False");
				inihelp.SetValue("工具栏", "分段", "False");
				inihelp.SetValue("工具栏", "分栏", "False");
				inihelp.SetValue("工具栏", "拆分", "False");
				inihelp.SetValue("工具栏", "检查", "False");
				inihelp.SetValue("工具栏", "翻译", "False");
				inihelp.SetValue("工具栏", "顶置", "True");
				inihelp.SetValue("取色器", "类型", "RGB");
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001F014 File Offset: 0x0001D214
		public static byte[] StreamToBytes(Stream stream)
		{
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			stream.Seek(0L, SeekOrigin.Begin);
			return array;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001F04C File Offset: 0x0001D24C
		public static void StreamToFile(Stream stream, string fileName)
		{
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			stream.Seek(0L, SeekOrigin.Begin);
			FileStream fileStream = new FileStream(fileName, FileMode.Create);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			binaryWriter.Write(array);
			binaryWriter.Close();
			fileStream.Close();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001F0A4 File Offset: 0x0001D2A4
		public static void bool_error()
		{
			if (inihelp.GetValue("配置", "接口") == "发生错误")
			{
				inihelp.SetValue("配置", "接口", "搜狗");
			}
			if (inihelp.GetValue("配置", "开机自启") == "发生错误")
			{
				inihelp.SetValue("配置", "开机自启", "True");
			}
			if (inihelp.GetValue("配置", "快速翻译") == "发生错误")
			{
				inihelp.SetValue("配置", "快速翻译", "True");
			}
			if (inihelp.GetValue("配置", "识别弹窗") == "发生错误")
			{
				inihelp.SetValue("配置", "识别弹窗", "True");
			}
			if (inihelp.GetValue("配置", "窗体动画") == "发生错误")
			{
				inihelp.SetValue("配置", "窗体动画", "窗体");
			}
			if (inihelp.GetValue("配置", "记录数目") == "发生错误")
			{
				inihelp.SetValue("配置", "记录数目", "20");
			}
			if (inihelp.GetValue("配置", "自动保存") == "发生错误")
			{
				inihelp.SetValue("配置", "自动保存", "True");
			}
			if (inihelp.GetValue("配置", "翻译接口") == "发生错误")
			{
				inihelp.SetValue("配置", "翻译接口", "谷歌");
			}
			if (inihelp.GetValue("配置", "截图位置") == "发生错误")
			{
				inihelp.SetValue("配置", "截图位置", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
			}
			if (inihelp.GetValue("快捷键", "文字识别") == "发生错误")
			{
				inihelp.SetValue("快捷键", "文字识别", "F4");
			}
			if (inihelp.GetValue("快捷键", "翻译文本") == "发生错误")
			{
				inihelp.SetValue("快捷键", "翻译文本", "F9");
			}
			if (inihelp.GetValue("快捷键", "记录界面") == "发生错误")
			{
				inihelp.SetValue("快捷键", "记录界面", "请按下快捷键");
			}
			if (inihelp.GetValue("快捷键", "识别界面") == "发生错误")
			{
				inihelp.SetValue("快捷键", "识别界面", "请按下快捷键");
			}
			if (inihelp.GetValue("密钥_百度", "secret_id") == "发生错误")
			{
				inihelp.SetValue("密钥_百度", "secret_id", "YsZKG1wha34PlDOPYaIrIIKO");
			}
			if (inihelp.GetValue("密钥_百度", "secret_key") == "发生错误")
			{
				inihelp.SetValue("密钥_百度", "secret_key", "HPRZtdOHrdnnETVsZM2Nx7vbDkMfxrkD");
			}
			if (inihelp.GetValue("代理", "代理类型") == "发生错误")
			{
				inihelp.SetValue("代理", "代理类型", "系统代理");
			}
			if (inihelp.GetValue("代理", "服务器") == "发生错误")
			{
				inihelp.SetValue("代理", "服务器", "");
			}
			if (inihelp.GetValue("代理", "端口") == "发生错误")
			{
				inihelp.SetValue("代理", "端口", "");
			}
			if (inihelp.GetValue("代理", "需要密码") == "发生错误")
			{
				inihelp.SetValue("代理", "需要密码", "False");
			}
			if (inihelp.GetValue("代理", "服务器账号") == "发生错误")
			{
				inihelp.SetValue("代理", "服务器账号", "");
			}
			if (inihelp.GetValue("代理", "服务器密码") == "发生错误")
			{
				inihelp.SetValue("代理", "服务器密码", "");
			}
			if (inihelp.GetValue("更新", "检测更新") == "发生错误")
			{
				inihelp.SetValue("更新", "检测更新", "True");
			}
			if (inihelp.GetValue("更新", "更新间隔") == "发生错误")
			{
				inihelp.SetValue("更新", "更新间隔", "True");
			}
			if (inihelp.GetValue("更新", "间隔时间") == "发生错误")
			{
				inihelp.SetValue("更新", "间隔时间", "24");
			}
			if (inihelp.GetValue("截图音效", "自动保存") == "发生错误")
			{
				inihelp.SetValue("截图音效", "自动保存", "True");
			}
			if (inihelp.GetValue("截图音效", "音效路径") == "发生错误")
			{
				inihelp.SetValue("截图音效", "音效路径", "Data\\screenshot.wav");
			}
			if (inihelp.GetValue("截图音效", "粘贴板") == "发生错误")
			{
				inihelp.SetValue("截图音效", "粘贴板", "False");
			}
			if (inihelp.GetValue("工具栏", "合并") == "发生错误")
			{
				inihelp.SetValue("工具栏", "合并", "False");
			}
			if (inihelp.GetValue("工具栏", "拆分") == "发生错误")
			{
				inihelp.SetValue("工具栏", "拆分", "False");
			}
			if (inihelp.GetValue("工具栏", "检查") == "发生错误")
			{
				inihelp.SetValue("工具栏", "检查", "False");
			}
			if (inihelp.GetValue("工具栏", "翻译") == "发生错误")
			{
				inihelp.SetValue("工具栏", "翻译", "False");
			}
			if (inihelp.GetValue("工具栏", "分段") == "发生错误")
			{
				inihelp.SetValue("工具栏", "分段", "False");
			}
			if (inihelp.GetValue("工具栏", "分栏") == "发生错误")
			{
				inihelp.SetValue("工具栏", "分栏", "False");
			}
			if (inihelp.GetValue("工具栏", "顶置") == "发生错误")
			{
				inihelp.SetValue("工具栏", "顶置", "True");
			}
			if (inihelp.GetValue("取色器", "类型") == "发生错误")
			{
				inihelp.SetValue("取色器", "类型", "RGB");
			}
			if (inihelp.GetValue("特殊", "ali_cookie") == "发生错误")
			{
				inihelp.SetValue("特殊", "ali_cookie", "cna=noXhE38FHGkCAXDve7YaZ8Tn; cnz=noXhE4/VhB8CAbZ773ApeV14; isg=BGJi2c2YTeeP6FG7S_Re8kveu-jEs2bNwToQnKz7jlWAfwL5lEO23eh9q3km9N5l; ");
			}
			if (inihelp.GetValue("特殊", "ali_account") == "发生错误")
			{
				inihelp.SetValue("特殊", "ali_account", "");
			}
			if (inihelp.GetValue("特殊", "ali_password") == "发生错误")
			{
				inihelp.SetValue("特殊", "ali_password", "");
			}
		}

		// Token: 0x040001FF RID: 511
		public static EventWaitHandle ProgramStarted;

		// Token: 0x04000200 RID: 512
		public static float factor;

		// Token: 0x04000201 RID: 513
		public static bool createNew;

		// Token: 0x04000202 RID: 514
		public static string download_url = "0";

		// Token: 0x04000203 RID: 515
		public static string version_url = "0";

		// Token: 0x04000204 RID: 516
		public static System.Timers.Timer checkTimer;

		// Token: 0x04000205 RID: 517
		public static bool inProgss;
	}
}
