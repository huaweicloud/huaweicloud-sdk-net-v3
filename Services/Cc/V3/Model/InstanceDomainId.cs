using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 网络实例（VPC，VGW）所属账号ID。
    /// </summary>
    public class InstanceDomainId 
    {

        /// <summary>
        /// 网络实例（VPC，VGW）所属账号ID。
        /// </summary>
        [JsonProperty("instance_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _InstanceDomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceDomainId {\n");
            sb.Append("  _instanceDomainId: ").Append(_InstanceDomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceDomainId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceDomainId input)
        {
            if (input == null) return false;
            if (this._InstanceDomainId != input._InstanceDomainId || (this._InstanceDomainId != null && !this._InstanceDomainId.Equals(input._InstanceDomainId))) return false;

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
                if (this._InstanceDomainId != null) hashCode = hashCode * 59 + this._InstanceDomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
