using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SubPicLayoutInfo 
    {

        /// <summary>
        /// 多画面信息。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 子画面从左到右的索引。
        /// </summary>
        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public int? Left { get; set; }

        /// <summary>
        /// 子画面从上到下的索引。
        /// </summary>
        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public int? Top { get; set; }

        /// <summary>
        /// 子画面横向尺寸。
        /// </summary>
        [JsonProperty("xSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? XSize { get; set; }

        /// <summary>
        /// 子画面横向尺寸。
        /// </summary>
        [JsonProperty("ySize", NullValueHandling = NullValueHandling.Ignore)]
        public int? YSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubPicLayoutInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  left: ").Append(Left).Append("\n");
            sb.Append("  top: ").Append(Top).Append("\n");
            sb.Append("  xSize: ").Append(XSize).Append("\n");
            sb.Append("  ySize: ").Append(YSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubPicLayoutInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubPicLayoutInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Left != input.Left || (this.Left != null && !this.Left.Equals(input.Left))) return false;
            if (this.Top != input.Top || (this.Top != null && !this.Top.Equals(input.Top))) return false;
            if (this.XSize != input.XSize || (this.XSize != null && !this.XSize.Equals(input.XSize))) return false;
            if (this.YSize != input.YSize || (this.YSize != null && !this.YSize.Equals(input.YSize))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Left != null) hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Top != null) hashCode = hashCode * 59 + this.Top.GetHashCode();
                if (this.XSize != null) hashCode = hashCode * 59 + this.XSize.GetHashCode();
                if (this.YSize != null) hashCode = hashCode * 59 + this.YSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
