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
    public class GeneralTextCharList 
    {

        /// <summary>
        /// 单字符识别结果。 
        /// </summary>
        [JsonProperty("char", NullValueHandling = NullValueHandling.Ignore)]
        public string Char { get; set; }

        /// <summary>
        /// 单字符的区域位置信息，列表形式，包含字符区域四个顶点的二维坐标（x,y）;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("char_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> CharLocation { get; set; }

        /// <summary>
        /// 单字符识别结果的置信度。 
        /// </summary>
        [JsonProperty("char_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? CharConfidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralTextCharList {\n");
            sb.Append("  Char: ").Append(Char).Append("\n");
            sb.Append("  charLocation: ").Append(CharLocation).Append("\n");
            sb.Append("  charConfidence: ").Append(CharConfidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeneralTextCharList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GeneralTextCharList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Char == input.Char ||
                    (this.Char != null &&
                    this.Char.Equals(input.Char))
                ) && 
                (
                    this.CharLocation == input.CharLocation ||
                    this.CharLocation != null &&
                    input.CharLocation != null &&
                    this.CharLocation.SequenceEqual(input.CharLocation)
                ) && 
                (
                    this.CharConfidence == input.CharConfidence ||
                    (this.CharConfidence != null &&
                    this.CharConfidence.Equals(input.CharConfidence))
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
                if (this.Char != null)
                    hashCode = hashCode * 59 + this.Char.GetHashCode();
                if (this.CharLocation != null)
                    hashCode = hashCode * 59 + this.CharLocation.GetHashCode();
                if (this.CharConfidence != null)
                    hashCode = hashCode * 59 + this.CharConfidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
