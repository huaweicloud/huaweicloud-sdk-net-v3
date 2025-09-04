using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RelationInfo 
    {

        /// <summary>
        /// |参数名称：关联资源ID。| |参数约束及描述：关联资源ID。|
        /// </summary>
        [JsonProperty("relative_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelativeResourceId { get; set; }

        /// <summary>
        /// |参数名称：关联资源类型。| |参数约束及描述：关联资源类型，父资源：PARENT；根资源：ROOT|
        /// </summary>
        [JsonProperty("relative_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelativeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationInfo {\n");
            sb.Append("  relativeResourceId: ").Append(RelativeResourceId).Append("\n");
            sb.Append("  relativeType: ").Append(RelativeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RelationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RelationInfo input)
        {
            if (input == null) return false;
            if (this.RelativeResourceId != input.RelativeResourceId || (this.RelativeResourceId != null && !this.RelativeResourceId.Equals(input.RelativeResourceId))) return false;
            if (this.RelativeType != input.RelativeType || (this.RelativeType != null && !this.RelativeType.Equals(input.RelativeType))) return false;

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
                if (this.RelativeResourceId != null) hashCode = hashCode * 59 + this.RelativeResourceId.GetHashCode();
                if (this.RelativeType != null) hashCode = hashCode * 59 + this.RelativeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
