using System;
using System.Windows.Forms;

public class 定义菜单类 : Singleton<定义菜单类>
{
	public ContextMenuStrip 创建自定义菜单(EventHandler 事件1 = null, string 事件文本1 = "", EventHandler 事件2 = null, string 事件文本2 = "", EventHandler 事件3 = null, string 事件文本3 = "", EventHandler 事件4 = null, string 事件文本4 = "", EventHandler 事件5 = null, string 事件文本5 = "")
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		if (事件1 != null)
		{
			contextMenuStrip.Items.Add(事件文本1, null, 事件1);
		}
		if (事件2 != null)
		{
			contextMenuStrip.Items.Add(事件文本2, null, 事件2);
		}
		if (事件3 != null)
		{
			contextMenuStrip.Items.Add(事件文本3, null, 事件3);
		}
		if (事件4 != null)
		{
			contextMenuStrip.Items.Add(事件文本4, null, 事件4);
		}
		if (事件5 != null)
		{
			contextMenuStrip.Items.Add(事件文本5, null, 事件5);
		}
		return contextMenuStrip;
	}

	public ContextMenuStrip 创建修改删除菜单(EventHandler 修改事件, EventHandler 删除事件)
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		if (修改事件 != null)
		{
			contextMenuStrip.Items.Add("修改", null, 修改事件);
		}
		if (删除事件 != null)
		{
			contextMenuStrip.Items.Add("删除", null, 删除事件);
		}
		return contextMenuStrip;
	}

	public ContextMenuStrip 创建无双列表菜单(EventHandler 淘汰事件)
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		if (淘汰事件 != null)
		{
			contextMenuStrip.Items.Add("淘汰当前玩家", null, 淘汰事件);
		}
		return contextMenuStrip;
	}

	public ContextMenuStrip 创建CDK删除菜单(EventHandler 删除事件, EventHandler 删除全部事件)
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		if (删除事件 != null)
		{
			contextMenuStrip.Items.Add("删除", null, 删除事件);
		}
		if (删除全部事件 != null)
		{
			contextMenuStrip.Items.Add("删除全部", null, 删除全部事件);
		}
		return contextMenuStrip;
	}
}
