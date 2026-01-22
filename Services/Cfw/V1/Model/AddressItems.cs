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
    public class AddressItems 
    {

        /// <summary>
        /// 地址组成员id列表
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddressItemIdWithoutName> Items { get; set; }

        /// <summary>
        /// 覆盖IP列表
        /// </summary>
        [JsonProperty("covered_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoveredIPVO> CoveredIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressItems {\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("  coveredIp: ").Append(CoveredIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddressItems);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddressItems input)
        {
            if (input == null) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;
            if (this.CoveredIp != input.CoveredIp || (this.CoveredIp != null && input.CoveredIp != null && !this.CoveredIp.SequenceEqual(input.CoveredIp))) return false;

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
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.CoveredIp != null) hashCode = hashCode * 59 + this.CoveredIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
