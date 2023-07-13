using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 批量删除IP地址组中的IP。
    /// </summary>
    public class BatchDeleteIpListOption 
    {

        /// <summary>
        /// IP列表。
        /// </summary>
        [JsonProperty("ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpGroupIp> IpList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteIpListOption {\n");
            sb.Append("  ipList: ").Append(IpList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteIpListOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteIpListOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpList == input.IpList ||
                    this.IpList != null &&
                    input.IpList != null &&
                    this.IpList.SequenceEqual(input.IpList)
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
                if (this.IpList != null)
                    hashCode = hashCode * 59 + this.IpList.GetHashCode();
                return hashCode;
            }
        }
    }
}
