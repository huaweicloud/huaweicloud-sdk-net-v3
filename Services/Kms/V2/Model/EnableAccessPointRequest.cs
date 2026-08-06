using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class EnableAccessPointRequest 
    {

        /// <summary>
        /// **参数解释：** 接入点ID。 **约束限制：** 不涉及 **取值范围：** UUID格式，字符长度36-36。 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("access_point_id", IsPath = true)]
        [JsonProperty("access_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessPointId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableAccessPointRequest {\n");
            sb.Append("  accessPointId: ").Append(AccessPointId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnableAccessPointRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnableAccessPointRequest input)
        {
            if (input == null) return false;
            if (this.AccessPointId != input.AccessPointId || (this.AccessPointId != null && !this.AccessPointId.Equals(input.AccessPointId))) return false;

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
                if (this.AccessPointId != null) hashCode = hashCode * 59 + this.AccessPointId.GetHashCode();
                return hashCode;
            }
        }
    }
}
