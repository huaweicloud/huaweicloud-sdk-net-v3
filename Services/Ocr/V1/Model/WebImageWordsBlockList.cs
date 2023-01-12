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
    public class WebImageWordsBlockList 
    {

        /// <summary>
        /// 文字块识别结果。 
        /// </summary>
        [JsonProperty("words", NullValueHandling = NullValueHandling.Ignore)]
        public string Words { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。 置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 文字块的区域位置信息，列表形式，包含文字区域四个顶点的二维坐标（x,y）;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> Location { get; set; }

        /// <summary>
        /// 文字块所属字体类型，列表形式，表示与文字块的文字最接近的字体类型。 
        /// </summary>
        [JsonProperty("font_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FontList { get; set; }

        /// <summary>
        /// 文字块所属字体类型的概率，列表形式，与font_list一一对应，表示文字块的文字属于某种字体类型的概率。 
        /// </summary>
        [JsonProperty("font_scores", NullValueHandling = NullValueHandling.Ignore)]
        public List<float?> FontScores { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebImageWordsBlockList {\n");
            sb.Append("  words: ").Append(Words).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  fontList: ").Append(FontList).Append("\n");
            sb.Append("  fontScores: ").Append(FontScores).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebImageWordsBlockList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WebImageWordsBlockList input)
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
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.Location == input.Location ||
                    this.Location != null &&
                    input.Location != null &&
                    this.Location.SequenceEqual(input.Location)
                ) && 
                (
                    this.FontList == input.FontList ||
                    this.FontList != null &&
                    input.FontList != null &&
                    this.FontList.SequenceEqual(input.FontList)
                ) && 
                (
                    this.FontScores == input.FontScores ||
                    this.FontScores != null &&
                    input.FontScores != null &&
                    this.FontScores.SequenceEqual(input.FontScores)
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
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.FontList != null)
                    hashCode = hashCode * 59 + this.FontList.GetHashCode();
                if (this.FontScores != null)
                    hashCode = hashCode * 59 + this.FontScores.GetHashCode();
                return hashCode;
            }
        }
    }
}
