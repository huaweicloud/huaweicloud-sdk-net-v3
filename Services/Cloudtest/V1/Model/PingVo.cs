using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PingVo 
    {

        /// <summary>
        /// ping地址
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("sub_task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubTaskName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PingVo {\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  subTaskName: ").Append(SubTaskName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PingVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PingVo input)
        {
            if (input == null) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.SubTaskName != input.SubTaskName || (this.SubTaskName != null && !this.SubTaskName.Equals(input.SubTaskName))) return false;

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
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.SubTaskName != null) hashCode = hashCode * 59 + this.SubTaskName.GetHashCode();
                return hashCode;
            }
        }
    }
}
