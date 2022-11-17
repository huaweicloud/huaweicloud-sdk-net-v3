using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowPtrRecordSetRequest 
    {

        /// <summary>
        /// 租户的区域信息。 
        /// </summary>
        [SDKProperty("region", IsPath = true)]
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 弹性IP的ID。
        /// </summary>
        [SDKProperty("floatingip_id", IsPath = true)]
        [JsonProperty("floatingip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingipId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPtrRecordSetRequest {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  floatingipId: ").Append(FloatingipId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPtrRecordSetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPtrRecordSetRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.FloatingipId == input.FloatingipId ||
                    (this.FloatingipId != null &&
                    this.FloatingipId.Equals(input.FloatingipId))
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
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.FloatingipId != null)
                    hashCode = hashCode * 59 + this.FloatingipId.GetHashCode();
                return hashCode;
            }
        }
    }
}
