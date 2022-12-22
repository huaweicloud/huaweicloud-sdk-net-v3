using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 分组详情
    /// </summary>
    public class CommonPoolsWithBorderGroupDict 
    {

        /// <summary>
        /// 同组的公共池列表
        /// </summary>
        [JsonProperty("publicip_pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicipPools { get; set; }

        /// <summary>
        /// 分组：中心还是边缘
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonPoolsWithBorderGroupDict {\n");
            sb.Append("  publicipPools: ").Append(PublicipPools).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommonPoolsWithBorderGroupDict);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommonPoolsWithBorderGroupDict input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicipPools == input.PublicipPools ||
                    this.PublicipPools != null &&
                    input.PublicipPools != null &&
                    this.PublicipPools.SequenceEqual(input.PublicipPools)
                ) && 
                (
                    this.PublicBorderGroup == input.PublicBorderGroup ||
                    (this.PublicBorderGroup != null &&
                    this.PublicBorderGroup.Equals(input.PublicBorderGroup))
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
                if (this.PublicipPools != null)
                    hashCode = hashCode * 59 + this.PublicipPools.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
