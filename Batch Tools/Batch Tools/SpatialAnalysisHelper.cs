using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.esriSystem;


namespace ZHDGIS.Land.Server.SpatialAnalysis
{
	public sealed class SpatialAnalysisHelper
	{
		/// <summary>
		/// 运行地理分析工具
		/// </summary>
		/// <param name="gp"></param>
		/// <param name="process"></param>
		/// <param name="trackCancel"></param>
		/// <returns></returns>
		public static IGeoProcessorResult2 RunGeoProcessor(Geoprocessor gp, IGPProcess process, ITrackCancel trackCancel)
		{
			IGeoProcessorResult2 gpResult = null;
			try
			{
				gpResult = gp.Execute(process, trackCancel) as IGeoProcessorResult2; //执行分析
				return gpResult;
			}
			catch (Exception ex)
			{
#if DEBUG
				System.Diagnostics.Debug.WriteLine(string.Format("#RunGP:{0};{1}", ex.Message, ex.StackTrace));
#endif
				return gpResult;
			}
		}

		/// <summary>
		/// 输出结果的过程信息
		/// </summary>
		/// <param name="gpResult"></param>
		/// <returns></returns>
		public static string GetMessages(IGeoProcessorResult2 gpResult)
		{
			StringBuilder msgBuilder = new StringBuilder();
			if (gpResult != null)
			{
				for (int i = 0; i < gpResult.MessageCount; i++)
				{
					msgBuilder.Append(gpResult.GetMessage(i));
                    msgBuilder.Append(" ");
				}
			}
			return msgBuilder.ToString();
		}

		/// <summary>
		/// 输出地理处理的过程信息
		/// </summary>
		/// <param name="gp"></param>
		/// <returns></returns>
		public static string GetMessages2(Geoprocessor gp)
		{
			StringBuilder msgBuilder = new StringBuilder();
			if (gp != null)
			{
				for (int i = 0; i < gp.MessageCount; i++)
				{
					msgBuilder.Append(gp.GetMessage(i));
                    msgBuilder.Append(" ");
				}
			}
			return msgBuilder.ToString();
		}
	}
}
