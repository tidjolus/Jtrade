using System.IO;
using System;

namespace Jtrade
{
	
	public static class Log
	{
		
	    public static void WriteLog(string logMessage)
        {
	    	DateTime nowDate = DateTime.Now;
            string shortDate = String.Format("{0:yyyy-MM-dd HH:mm:ss}", nowDate);
            string rootPath = Path.GetFullPath("./Data/Log/");
            string stringLogPath = rootPath + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt";
            var log_FileInfo = new FileInfo(stringLogPath);
            var log_DirInfo = new DirectoryInfo(log_FileInfo.DirectoryName);
            if (!log_DirInfo.Exists) log_DirInfo.Create();
            using (var file_Stream = new FileStream(stringLogPath, FileMode.Append))
            {
                using (var log = new StreamWriter(file_Stream))
                {
                	log.WriteLine(shortDate.ToString() + " : " + logMessage);
                }
            }
        }
	}
}
