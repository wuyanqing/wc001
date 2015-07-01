using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
//using Microsoft.Office.Interop.Owc11;
using System.IO;
using OWC11;
using System.Runtime.InteropServices;
//using Microsoft.Office.Interop;
//using OWC11 = Microsoft.Office.Interop.Owc11;


namespace WSV.BLL.Count
{
    public class ChartFactory
    {
        public ChartFactory()
        {
            InitTypeMap();
            DllRegisterServer();
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        [DllImport("OWC11.dll")]
        public static extern int DllRegisterServer();
        private string[] chartCategoriesArr;
        private string[] chartValuesArr;
        private OWC11.ChartChartTypeEnum chartType = OWC11.ChartChartTypeEnum.chChartTypeColumn3D;//默认值
        private static Hashtable chartMap = new Hashtable();
        private static string chartTypeCh = "垂直柱状统计图";
        private static string chartTitle = "aaa";
        private void InitTypeMap()
        {
            chartMap.Clear();
            OWC11.ChartChartTypeEnum[] chartTypes = new OWC11.ChartChartTypeEnum[]
            { 
                ChartChartTypeEnum.chChartTypeColumnClustered,
　　            ChartChartTypeEnum.chChartTypeColumn3D,
　　            ChartChartTypeEnum.chChartTypeBarClustered,
　　            ChartChartTypeEnum.chChartTypeBar3D,
　　            ChartChartTypeEnum.chChartTypeArea,
　　            ChartChartTypeEnum.chChartTypeArea3D,
　　            ChartChartTypeEnum.chChartTypeDoughnut,
　　            ChartChartTypeEnum.chChartTypeLineStacked,
　　            ChartChartTypeEnum.chChartTypeLine3D,
　　            ChartChartTypeEnum.chChartTypeLineMarkers,
　　            ChartChartTypeEnum.chChartTypePie,
　　            ChartChartTypeEnum.chChartTypePie3D,
　　            ChartChartTypeEnum.chChartTypeRadarSmoothLine,
　　            ChartChartTypeEnum.chChartTypeSmoothLine
            };
            string[] chartTypesCh = new string[] { "垂直柱状统计图", "3D垂直柱状统计图", "水平柱状统计图", "3D水平柱状统计图", "区域统计图", "3D区域统计图", "中空饼图", "折线统计图", "3D折线统计图", "折线带点统计图", "饼图", "3D饼图", "网状统计图", "弧线统计图" };

            for (int i = 0; i < chartTypes.Length; i++)
            {
                chartMap.Add(chartTypesCh[i], chartTypes[i]);
            }
        }

        public ChartSpaceClass BuildCharts()
        {
            string chartCategoriesStr = String.Join("\t", chartCategoriesArr);
            string chartValuesStr = String.Join("\t", chartValuesArr);

            OWC11.ChartSpaceClass oChartSpace = new OWC11.ChartSpaceClass();

            // ------------------------------------------------------------------------
            // Give pie and doughnut charts a legend on the bottom. For the rest of
            // them let the control figure it out on its own.
            // ------------------------------------------------------------------------

            chartType = (ChartChartTypeEnum)chartMap[chartTypeCh];

            if (chartType == ChartChartTypeEnum.chChartTypePie ||
                chartType == ChartChartTypeEnum.chChartTypePie3D ||
                chartType == ChartChartTypeEnum.chChartTypeDoughnut)
            {
                oChartSpace.HasChartSpaceLegend = true;
                oChartSpace.ChartSpaceLegend.Position = ChartLegendPositionEnum.chLegendPositionBottom;
            }

            oChartSpace.Border.Color = "blue";
            oChartSpace.Charts.Add(0);
            oChartSpace.Charts[0].HasTitle = true;
            oChartSpace.Charts[0].Type = chartType;
            oChartSpace.Charts[0].ChartDepth = 125;
            oChartSpace.Charts[0].AspectRatio = 80;
            oChartSpace.Charts[0].Title.Caption = chartTitle;
            oChartSpace.Charts[0].Title.Font.Bold = true;

            //绘图区背景颜色
            //oChartSpace.Charts[0].PlotArea.Interior.Color = "red";
            //绘图区
            // oChartSpace.Charts[0].PlotArea.Floor.Interior.Color = "green";

            oChartSpace.Charts[0].SeriesCollection.Add(0);
            oChartSpace.Charts[0].SeriesCollection[0].DataLabelsCollection.Add();
            //柱状图颜色
            //oChartSpace.Charts[0].SeriesCollection[0].Interior.Color = "red";

            // ------------------------------------------------------------------------
            // If you're charting a pie or a variation thereof percentages make a lot
            // more sense than values...
            // ------------------------------------------------------------------------
            if (chartType == ChartChartTypeEnum.chChartTypePie ||
                chartType == ChartChartTypeEnum.chChartTypePie3D ||
                chartType == ChartChartTypeEnum.chChartTypeDoughnut)
            {
                oChartSpace.Charts[0].SeriesCollection[0].DataLabelsCollection[0].HasPercentage = true;
                oChartSpace.Charts[0].SeriesCollection[0].DataLabelsCollection[0].HasValue = false;
            }
            // ------------------------------------------------------------------------
            // Not so for other chart types where values have more meaning than
            // percentages.
            // ------------------------------------------------------------------------
            else
            {
                oChartSpace.Charts[0].SeriesCollection[0].DataLabelsCollection[0].HasPercentage = false;
                oChartSpace.Charts[0].SeriesCollection[0].DataLabelsCollection[0].HasValue = true;
            }

            // ------------------------------------------------------------------------
            // Plug your own visual bells and whistles here
            // ------------------------------------------------------------------------
            oChartSpace.Charts[0].SeriesCollection[0].Caption = String.Empty;
            oChartSpace.Charts[0].SeriesCollection[0].DataLabelsCollection[0].Font.Name = "verdana";
            oChartSpace.Charts[0].SeriesCollection[0].DataLabelsCollection[0].Font.Size = 10;
            oChartSpace.Charts[0].SeriesCollection[0].DataLabelsCollection[0].Font.Bold = true;
            oChartSpace.Charts[0].SeriesCollection[0].DataLabelsCollection[0].Font.Color = "red";
            oChartSpace.Charts[0].SeriesCollection[0].DataLabelsCollection[0].Position = ChartDataLabelPositionEnum.chLabelPositionCenter;

            if (chartType == ChartChartTypeEnum.chChartTypeBarClustered ||
                chartType == ChartChartTypeEnum.chChartTypeBar3D ||
                chartType == ChartChartTypeEnum.chChartTypeColumnClustered ||
                chartType == ChartChartTypeEnum.chChartTypeColumn3D)
            {
                oChartSpace.Charts[0].SeriesCollection[0].DataLabelsCollection[0].Position = ChartDataLabelPositionEnum.chLabelPositionOutsideEnd;
            }

            oChartSpace.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimCategories,
                Convert.ToInt32(OWC11.ChartSpecialDataSourcesEnum.chDataLiteral), chartCategoriesStr);

            oChartSpace.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimValues,
                Convert.ToInt32(OWC11.ChartSpecialDataSourcesEnum.chDataLiteral), chartValuesStr);

            return oChartSpace;
        }

        public string[] chartCategoriesArrValue
        {
            get
            {
                return chartCategoriesArr;
            }
            set
            {
                chartCategoriesArr = value;
            }
        }

        public string[] chartValuesArrValue
        {
            get
            {
                return chartValuesArr;
            }
            set
            {
                chartValuesArr = value;
            }
        }
        public string chartTypeValue
        {
            get
            {
                return chartTypeCh;
            }
            set
            {
                chartTypeCh = value;
            }
        }
        public string chartTitleValue
        {
            get
            {
                return chartTitle;
            }
            set
            {
                chartTitle = value;
            }
        }
    }
}
