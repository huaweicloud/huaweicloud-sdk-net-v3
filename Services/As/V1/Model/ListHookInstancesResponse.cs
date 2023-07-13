using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListHookInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 伸缩实例生命周期挂钩列表。
        /// </summary>
        [JsonProperty("instance_hanging_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceHangingInfos> InstanceHangingInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHookInstancesResponse {\n");
            sb.Append("  instanceHangingInfo: ").Append(InstanceHangingInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHookInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHookInstancesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceHangingInfo == input.InstanceHangingInfo ||
                    this.InstanceHangingInfo != null &&
                    input.InstanceHangingInfo != null &&
                    this.InstanceHangingInfo.SequenceEqual(input.InstanceHangingInfo)
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
                if (this.InstanceHangingInfo != null)
                    hashCode = hashCode * 59 + this.InstanceHangingInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
