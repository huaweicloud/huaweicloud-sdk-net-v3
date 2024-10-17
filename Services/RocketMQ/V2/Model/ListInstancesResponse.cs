using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 实例列表。
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowInstanceResp> Instances { get; set; }

        /// <summary>
        /// 实例数量。
        /// </summary>
        [JsonProperty("instance_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesResponse {\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("  instanceNum: ").Append(InstanceNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesResponse input)
        {
            if (input == null) return false;
            if (this.Instances != input.Instances || (this.Instances != null && input.Instances != null && !this.Instances.SequenceEqual(input.Instances))) return false;
            if (this.InstanceNum != input.InstanceNum || (this.InstanceNum != null && !this.InstanceNum.Equals(input.InstanceNum))) return false;

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
                if (this.Instances != null) hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.InstanceNum != null) hashCode = hashCode * 59 + this.InstanceNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
