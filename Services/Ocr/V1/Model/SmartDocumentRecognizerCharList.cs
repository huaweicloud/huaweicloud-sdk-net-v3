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
    /// 
    /// </summary>
    public class SmartDocumentRecognizerCharList 
    {

        /// <summary>
        /// 单字符识别结果。 
        /// </summary>
        [JsonProperty("char", NullValueHandling = NullValueHandling.Ignore)]
        public string Char { get; set; }

        /// <summary>
        /// 单字符的置信度，置信度越大，表示本次识别的文字的可靠性越高，在统计意义上，置信度越大，准确率越高。置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("char_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? CharConfidence { get; set; }

        /// <summary>
        /// 单字符的位置信息，列表形式，分别表示文字块4个顶点的x, y坐标;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("char_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> CharLocation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerCharList {\n");
            sb.Append("  Char: ").Append(Char).Append("\n");
            sb.Append("  charConfidence: ").Append(CharConfidence).Append("\n");
            sb.Append("  charLocation: ").Append(CharLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerCharList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerCharList input)
        {
            if (input == null) return false;
            if (this.Char != input.Char || (this.Char != null && !this.Char.Equals(input.Char))) return false;
            if (this.CharConfidence != input.CharConfidence || (this.CharConfidence != null && !this.CharConfidence.Equals(input.CharConfidence))) return false;
            if (this.CharLocation != input.CharLocation || (this.CharLocation != null && input.CharLocation != null && !this.CharLocation.SequenceEqual(input.CharLocation))) return false;

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
                if (this.Char != null) hashCode = hashCode * 59 + this.Char.GetHashCode();
                if (this.CharConfidence != null) hashCode = hashCode * 59 + this.CharConfidence.GetHashCode();
                if (this.CharLocation != null) hashCode = hashCode * 59 + this.CharLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
