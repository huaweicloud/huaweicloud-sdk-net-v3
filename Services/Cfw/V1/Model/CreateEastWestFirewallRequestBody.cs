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
    /// 创建东西向防火墙body体
    /// </summary>
    public class CreateEastWestFirewallRequestBody 
    {

        /// <summary>
        /// 出方向关联ER实例id
        /// </summary>
        [JsonProperty("er_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ErId { get; set; }

        /// <summary>
        /// inspection cidr
        /// </summary>
        [JsonProperty("inspection_cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string InspectionCidr { get; set; }

        /// <summary>
        /// 东西向防火墙模式，填写er
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEastWestFirewallRequestBody {\n");
            sb.Append("  erId: ").Append(ErId).Append("\n");
            sb.Append("  inspectionCidr: ").Append(InspectionCidr).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEastWestFirewallRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEastWestFirewallRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErId == input.ErId ||
                    (this.ErId != null &&
                    this.ErId.Equals(input.ErId))
                ) && 
                (
                    this.InspectionCidr == input.InspectionCidr ||
                    (this.InspectionCidr != null &&
                    this.InspectionCidr.Equals(input.InspectionCidr))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.ErId != null)
                    hashCode = hashCode * 59 + this.ErId.GetHashCode();
                if (this.InspectionCidr != null)
                    hashCode = hashCode * 59 + this.InspectionCidr.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
