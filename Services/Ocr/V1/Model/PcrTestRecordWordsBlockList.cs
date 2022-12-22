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
    public class PcrTestRecordWordsBlockList 
    {

        /// <summary>
        /// 文字块识别结果。 
        /// </summary>
        [JsonProperty("words", NullValueHandling = NullValueHandling.Ignore)]
        public string Words { get; set; }

        /// <summary>
        /// 识别到的文字块的区域位置信息，列表形式，分别表示文字块4个顶点的（x,y）坐标；采用图像坐标系，图像坐标原点为图像左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> Location { get; set; }

        /// <summary>
        /// 字段的平均置信度，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PcrTestRecordWordsBlockList {\n");
            sb.Append("  words: ").Append(Words).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PcrTestRecordWordsBlockList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PcrTestRecordWordsBlockList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Words == input.Words ||
                    (this.Words != null &&
                    this.Words.Equals(input.Words))
                ) && 
                (
                    this.Location == input.Location ||
                    this.Location != null &&
                    input.Location != null &&
                    this.Location.SequenceEqual(input.Location)
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Words != null)
                    hashCode = hashCode * 59 + this.Words.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
