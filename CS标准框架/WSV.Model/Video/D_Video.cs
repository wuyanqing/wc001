using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Video
{
    public class D_Video
    {
        private string _VIDEO_name, _VIDEO_table;
        private int  _VIDEO_Standard,_VIDEO_Source, _VIDEO_Brightness, _VIDEO_Contrast, _VIDEO_Hue, _VIDEO_Saturation, _VIDEO_Suality;

        public string VIDEO_name
        {
            get { return _VIDEO_name; }
            set { _VIDEO_name = value; }
        }
        public string VIDEO_table
        {
            get { return _VIDEO_table; }
            set { _VIDEO_table = value; }
        }
        public int VIDEO_Standard
        {
            get { return _VIDEO_Standard; }
            set { _VIDEO_Standard = value; }
        }
        public int VIDEO_Source
        {
            get { return _VIDEO_Source; }
            set { _VIDEO_Source = value; }
        }
        public int VIDEO_Brightness
        {
            get { return _VIDEO_Brightness; }
            set { _VIDEO_Brightness = value; }
        }
        public int VIDEO_Contrast
        {
            get { return _VIDEO_Contrast; }
            set { _VIDEO_Contrast = value; }
        }
        public int VIDEO_Hue
        {
            get { return _VIDEO_Hue; }
            set { _VIDEO_Hue = value; }
        }
        public int VIDEO_Saturation
        {
            get { return _VIDEO_Saturation; }
            set { _VIDEO_Saturation = value; }
        }
        public int VIDEO_Suality
        {
            get { return _VIDEO_Suality; }
            set { _VIDEO_Suality = value; }
        }
    }
}
