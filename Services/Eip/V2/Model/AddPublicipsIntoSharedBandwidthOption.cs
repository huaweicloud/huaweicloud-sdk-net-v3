using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// 带宽对象
    /// </summary>
    public class AddPublicipsIntoSharedBandwidthOption 
    {

        /// <summary>
        /// 功能说明：要插入共享带宽的弹性公网IP或者IPv6端口信息  约束：WHOLE类型的带宽支持多个弹性公网IP或者IPv6端口，跟租户的配额相关，默认一个共享带宽的配额为20
        /// </summary>
        [JsonProperty("publicip_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<InsertPublicipInfo> PublicipInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddPublicipsIntoSharedBandwidthOption {\n");
            sb.Append("  publicipInfo: ").Append(PublicipInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddPublicipsIntoSharedBandwidthOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddPublicipsIntoSharedBandwidthOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicipInfo == input.PublicipInfo ||
                    this.PublicipInfo != null &&
                    input.PublicipInfo != null &&
                    this.PublicipInfo.SequenceEqual(input.PublicipInfo)
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
                if (this.PublicipInfo != null)
                    hashCode = hashCode * 59 + this.PublicipInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
