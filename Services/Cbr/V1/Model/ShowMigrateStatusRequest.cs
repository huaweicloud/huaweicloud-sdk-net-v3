using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowMigrateStatusRequest 
    {

        /// <summary>
        /// 是否查询其他区域结果
        /// </summary>
        [SDKProperty("all_regions", IsQuery = true)]
        [JsonProperty("all_regions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllRegions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMigrateStatusRequest {\n");
            sb.Append("  allRegions: ").Append(AllRegions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMigrateStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMigrateStatusRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllRegions == input.AllRegions ||
                    (this.AllRegions != null &&
                    this.AllRegions.Equals(input.AllRegions))
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
                if (this.AllRegions != null)
                    hashCode = hashCode * 59 + this.AllRegions.GetHashCode();
                return hashCode;
            }
        }
    }
}
