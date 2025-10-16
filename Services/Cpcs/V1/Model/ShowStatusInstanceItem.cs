using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowStatusInstanceItem 
    {

        /// <summary>
        /// 实例列表
        /// </summary>
        [JsonProperty("instance_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowStatusInstanceItemInstanceList> InstanceList { get; set; }

        /// <summary>
        /// 采集时间，UNIX时间戳，单位毫秒
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timestamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatusInstanceItem {\n");
            sb.Append("  instanceList: ").Append(InstanceList).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatusInstanceItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatusInstanceItem input)
        {
            if (input == null) return false;
            if (this.InstanceList != input.InstanceList || (this.InstanceList != null && input.InstanceList != null && !this.InstanceList.SequenceEqual(input.InstanceList))) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;

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
                if (this.InstanceList != null) hashCode = hashCode * 59 + this.InstanceList.GetHashCode();
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
