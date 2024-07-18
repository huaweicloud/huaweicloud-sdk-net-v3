using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AutopilotEniNetworkUpdate 
    {

        /// <summary>
        /// IPv4子网ID列表。 只允许新增子网，不可删除已有子网，请谨慎选择。  请求体中需包含所有已经存在的subnet。
        /// </summary>
        [JsonProperty("subnets", NullValueHandling = NullValueHandling.Ignore)]
        public List<AutopilotNetworkSubnet> Subnets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutopilotEniNetworkUpdate {\n");
            sb.Append("  subnets: ").Append(Subnets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutopilotEniNetworkUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutopilotEniNetworkUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subnets == input.Subnets ||
                    this.Subnets != null &&
                    input.Subnets != null &&
                    this.Subnets.SequenceEqual(input.Subnets)
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
                if (this.Subnets != null)
                    hashCode = hashCode * 59 + this.Subnets.GetHashCode();
                return hashCode;
            }
        }
    }
}
