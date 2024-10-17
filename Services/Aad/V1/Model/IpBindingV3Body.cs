using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// ip绑定请求体
    /// </summary>
    public class IpBindingV3Body 
    {

        /// <summary>
        /// 防护ip列表
        /// </summary>
        [JsonProperty("ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpBindingV3Body {\n");
            sb.Append("  ipList: ").Append(IpList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpBindingV3Body);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpBindingV3Body input)
        {
            if (input == null) return false;
            if (this.IpList != input.IpList || (this.IpList != null && input.IpList != null && !this.IpList.SequenceEqual(input.IpList))) return false;

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
                if (this.IpList != null) hashCode = hashCode * 59 + this.IpList.GetHashCode();
                return hashCode;
            }
        }
    }
}
