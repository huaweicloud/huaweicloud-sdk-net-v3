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
    public class AutoClassificationResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public AutoClassificationResultStatus Status { get; set; }

        /// <summary>
        /// 对应票证具体结构化识别的结果。 
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public Object Content { get; set; }

        /// <summary>
        /// 对应票证的类别。         
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 文字块的区域位置信息，列表形式，包含文字区域四个顶点的二维坐标（x,y）;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> Location { get; set; }

        /// <summary>
        /// 对应票证中是否含有印章。可选值包括： -  true：该票证中含有印章。 -  false：该票证中不含有印章。 
        /// </summary>
        [JsonProperty("seal_mark", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SealMark { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoClassificationResult {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  sealMark: ").Append(SealMark).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoClassificationResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoClassificationResult input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Location != input.Location || (this.Location != null && input.Location != null && !this.Location.SequenceEqual(input.Location))) return false;
            if (this.SealMark != input.SealMark || (this.SealMark != null && !this.SealMark.Equals(input.SealMark))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.SealMark != null) hashCode = hashCode * 59 + this.SealMark.GetHashCode();
                return hashCode;
            }
        }
    }
}
