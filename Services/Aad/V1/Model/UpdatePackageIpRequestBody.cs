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
    /// 更新全量防护对象的请求体
    /// </summary>
    public class UpdatePackageIpRequestBody 
    {

        /// <summary>
        /// 全量防护ip列表
        /// </summary>
        [JsonProperty("protected_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateProtectedIpInPolicyBody> ProtectedIpList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePackageIpRequestBody {\n");
            sb.Append("  protectedIpList: ").Append(ProtectedIpList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePackageIpRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePackageIpRequestBody input)
        {
            if (input == null) return false;
            if (this.ProtectedIpList != input.ProtectedIpList || (this.ProtectedIpList != null && input.ProtectedIpList != null && !this.ProtectedIpList.SequenceEqual(input.ProtectedIpList))) return false;

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
                if (this.ProtectedIpList != null) hashCode = hashCode * 59 + this.ProtectedIpList.GetHashCode();
                return hashCode;
            }
        }
    }
}
