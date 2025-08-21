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
    public class InspectionVpcInfo 
    {

        /// <summary>
        /// **参数解释**： 引流VPC  **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("inspection_vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InspectionVpcId { get; set; }

        /// <summary>
        /// **参数解释**： 引流VPC  **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InspectionVpcInfo {\n");
            sb.Append("  inspectionVpcId: ").Append(InspectionVpcId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InspectionVpcInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InspectionVpcInfo input)
        {
            if (input == null) return false;
            if (this.InspectionVpcId != input.InspectionVpcId || (this.InspectionVpcId != null && !this.InspectionVpcId.Equals(input.InspectionVpcId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;

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
                if (this.InspectionVpcId != null) hashCode = hashCode * 59 + this.InspectionVpcId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
