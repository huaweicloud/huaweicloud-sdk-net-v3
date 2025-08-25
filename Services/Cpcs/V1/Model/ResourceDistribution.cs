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
    public class ResourceDistribution 
    {

        /// <summary>
        /// 密钥管理服务密钥数量
        /// </summary>
        [JsonProperty("kms", NullValueHandling = NullValueHandling.Ignore)]
        public int? Kms { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceDistribution {\n");
            sb.Append("  kms: ").Append(Kms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceDistribution);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceDistribution input)
        {
            if (input == null) return false;
            if (this.Kms != input.Kms || (this.Kms != null && !this.Kms.Equals(input.Kms))) return false;

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
                if (this.Kms != null) hashCode = hashCode * 59 + this.Kms.GetHashCode();
                return hashCode;
            }
        }
    }
}
