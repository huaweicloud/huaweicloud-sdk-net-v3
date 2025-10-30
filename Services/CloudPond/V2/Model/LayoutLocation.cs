using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// 设备位置信息
    /// </summary>
    public class LayoutLocation 
    {

        /// <summary>
        /// 机柜ID
        /// </summary>
        [JsonProperty("rack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RackId { get; set; }

        /// <summary>
        /// 起始U位
        /// </summary>
        [JsonProperty("start_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartIndex { get; set; }

        /// <summary>
        /// U位数
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Unit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayoutLocation {\n");
            sb.Append("  rackId: ").Append(RackId).Append("\n");
            sb.Append("  startIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LayoutLocation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LayoutLocation input)
        {
            if (input == null) return false;
            if (this.RackId != input.RackId || (this.RackId != null && !this.RackId.Equals(input.RackId))) return false;
            if (this.StartIndex != input.StartIndex || (this.StartIndex != null && !this.StartIndex.Equals(input.StartIndex))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;

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
                if (this.RackId != null) hashCode = hashCode * 59 + this.RackId.GetHashCode();
                if (this.StartIndex != null) hashCode = hashCode * 59 + this.StartIndex.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
