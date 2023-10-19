using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CoveredIPVO 
    {

        /// <summary>
        /// ip地址
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 覆盖ip地址。
        /// </summary>
        [JsonProperty("covered_Ip", NullValueHandling = NullValueHandling.Ignore)]
        public string CoveredIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoveredIPVO {\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  coveredIp: ").Append(CoveredIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CoveredIPVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CoveredIPVO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.CoveredIp == input.CoveredIp ||
                    (this.CoveredIp != null &&
                    this.CoveredIp.Equals(input.CoveredIp))
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
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.CoveredIp != null)
                    hashCode = hashCode * 59 + this.CoveredIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
