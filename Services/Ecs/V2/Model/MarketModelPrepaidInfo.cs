using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MarketModelPrepaidInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("expired_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiredTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketModelPrepaidInfo {\n");
            sb.Append("  expiredTime: ").Append(ExpiredTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MarketModelPrepaidInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MarketModelPrepaidInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiredTime == input.ExpiredTime ||
                    (this.ExpiredTime != null &&
                    this.ExpiredTime.Equals(input.ExpiredTime))
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
                if (this.ExpiredTime != null)
                    hashCode = hashCode * 59 + this.ExpiredTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
