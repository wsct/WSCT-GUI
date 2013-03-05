using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ZeToken.WinSCard.WinSCardGUI.Tools
{
  public class Logger: ILogger
  {
    RichTextBox _logs;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="logs"></param>
    public Logger(RichTextBox logs)
    {
      _logs = logs;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="infos"></param>
    public void add(String infos)
    {
      add(LogLevel.INFO, infos);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="level"></param>
    /// <param name="infos"></param>
    public void add(LogLevel level, String infos)
    {
      switch (level)
      {
        case LogLevel.FATAL:
        case LogLevel.ERROR:
          _logs.SelectionColor = System.Drawing.Color.Red;
          break;
        case LogLevel.WARNING:
          _logs.SelectionColor = System.Drawing.Color.DarkBlue;
          break;
        case LogLevel.NORMAL:
        case LogLevel.INFO:
          _logs.SelectionColor = System.Drawing.Color.Black;
          break;
      }
      _logs.AppendText(String.Format("{0}.{1:d3} [{2,5:}] {3}\n", DateTime.Now, DateTime.Now.Millisecond, level, infos));
    }
  }
}