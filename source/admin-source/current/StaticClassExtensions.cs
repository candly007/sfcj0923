using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Windows.Forms;

public static class StaticClassExtensions
{
	public static Process Parent(this Process process)
	{
		try
		{
			return Process.GetProcessById(process.ParentProcessId());
		}
		catch
		{
			return null;
		}
	}

	private static int ParentProcessId(this Process process)
	{
		using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher($"SELECT ParentProcessId FROM Win32_Process WHERE ProcessId = {process.Id}");
		return (from ManagementObject mo in managementObjectSearcher.Get()
			select Convert.ToInt32(mo["ParentProcessId"])).FirstOrDefault();
	}

	public static void AddCheckedChangedToAll(this List<CheckBox> list, EventHandler handler)
	{
		if (list == null)
		{
			return;
		}
		foreach (CheckBox item in list)
		{
			if (item != null)
			{
				item.CheckedChanged -= handler;
				item.CheckedChanged += handler;
			}
		}
	}

	public static void EndCheckedChangedToAll(this List<CheckBox> list, bool Is允许点击, bool Is取消所有点击 = false)
	{
		if (list == null)
		{
			return;
		}
		foreach (CheckBox item in list)
		{
			if (item != null)
			{
				item.Enabled = Is允许点击;
				if (Is取消所有点击)
				{
					item.Checked = false;
				}
			}
		}
	}

	public static string ToStrings(this int[] list)
	{
		if (list == null)
		{
			return string.Empty;
		}
		string text = string.Empty;
		for (int i = 0; i < list.Length; i++)
		{
			text += $",{list[i]}";
		}
		if (text.Length > 0)
		{
			text = text.Remove(0, 1);
		}
		return text;
	}

	public static string ToStrings(this List<通用属性类> list)
	{
		if (list == null)
		{
			return string.Empty;
		}
		string text = string.Empty;
		for (int i = 0; i < list.Count; i++)
		{
			text += $",{list[i].属性名字}+{list[i].属性数值}";
		}
		if (text.Length > 0)
		{
			text = text.Remove(0, 1);
		}
		return text;
	}

	public static string ToStrings(this List<道具数据> list)
	{
		if (list == null)
		{
			return string.Empty;
		}
		string text = string.Empty;
		for (int i = 0; i < list.Count; i++)
		{
			text += $"{list[i].名字},{list[i].图标},{list[i].叠加}{((i + 1 < list.Count) ? "\r\n" : string.Empty)}";
		}
		return text;
	}
}
