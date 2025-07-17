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
    public class PicLayoutInfo 
    {

        /// <summary>
        /// 横向小格子数。
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public int? X { get; set; }

        /// <summary>
        /// 纵向小格子数。
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public int? Y { get; set; }

        /// <summary>
        /// 多画面信息。
        /// </summary>
        [JsonProperty("subPicLayoutInfoList", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubPicLayoutInfo> SubPicLayoutInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PicLayoutInfo {\n");
            sb.Append("  x: ").Append(X).Append("\n");
            sb.Append("  y: ").Append(Y).Append("\n");
            sb.Append("  subPicLayoutInfoList: ").Append(SubPicLayoutInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PicLayoutInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PicLayoutInfo input)
        {
            if (input == null) return false;
            if (this.X != input.X || (this.X != null && !this.X.Equals(input.X))) return false;
            if (this.Y != input.Y || (this.Y != null && !this.Y.Equals(input.Y))) return false;
            if (this.SubPicLayoutInfoList != input.SubPicLayoutInfoList || (this.SubPicLayoutInfoList != null && input.SubPicLayoutInfoList != null && !this.SubPicLayoutInfoList.SequenceEqual(input.SubPicLayoutInfoList))) return false;

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
                if (this.X != null) hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null) hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.SubPicLayoutInfoList != null) hashCode = hashCode * 59 + this.SubPicLayoutInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
