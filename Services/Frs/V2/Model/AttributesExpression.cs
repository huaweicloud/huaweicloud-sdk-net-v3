using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// 人脸表情，包括中性、高兴、害怕、惊讶、伤心、生气、厌恶。
    /// </summary>
    public class AttributesExpression 
    {

        /// <summary>
        /// 人脸表情类型： • neutral：中性 • happy：高兴 • fear：害怕 • surprise：惊讶 • sad：伤心 • angry：生气 • disgust：厌恶 • unknown：图片质量问题导致未识别
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 表情置信度，取值范围[0-1]。
        /// </summary>
        [JsonProperty("probability", NullValueHandling = NullValueHandling.Ignore)]
        public double? Probability { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributesExpression {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  probability: ").Append(Probability).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttributesExpression);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttributesExpression input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Probability != input.Probability || (this.Probability != null && !this.Probability.Equals(input.Probability))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Probability != null) hashCode = hashCode * 59 + this.Probability.GetHashCode();
                return hashCode;
            }
        }
    }
}
