using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 识别文字块列表，输出顺序从左到右，先上后下。
    /// </summary>
    public class GeneralTextWordsBlockList 
    {

        /// <summary>
        /// 文字块识别结果。 
        /// </summary>
        [JsonProperty("words", NullValueHandling = NullValueHandling.Ignore)]
        public string Words { get; set; }

        /// <summary>
        /// 文字块的区域位置信息，列表形式，包含文字区域四个顶点的二维坐标（x,y）;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> Location { get; set; }

        /// <summary>
        /// 文字块识别结果的置信度。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 文字块对应的单字符识别列表，输出顺序从左到右，先上后下。 
        /// </summary>
        [JsonProperty("char_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<GeneralTextCharList> CharList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralTextWordsBlockList {\n");
            sb.Append("  words: ").Append(Words).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  charList: ").Append(CharList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeneralTextWordsBlockList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GeneralTextWordsBlockList input)
        {
            if (input == null) return false;
            if (this.Words != input.Words || (this.Words != null && !this.Words.Equals(input.Words))) return false;
            if (this.Location != input.Location || (this.Location != null && input.Location != null && !this.Location.SequenceEqual(input.Location))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
            if (this.CharList != input.CharList || (this.CharList != null && input.CharList != null && !this.CharList.SequenceEqual(input.CharList))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Words != null) hashCode = hashCode * 59 + this.Words.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.CharList != null) hashCode = hashCode * 59 + this.CharList.GetHashCode();
                return hashCode;
            }
        }
    }
}
