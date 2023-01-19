using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AssociateRouteTableAndSubnetReq 
    {

        /// <summary>
        /// 路由表关联子网ID列表 
        /// </summary>
        [JsonProperty("associate", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Associate { get; set; }

        /// <summary>
        /// 路由表解除关联子网ID列表
        /// </summary>
        [JsonProperty("disassociate", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Disassociate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateRouteTableAndSubnetReq {\n");
            sb.Append("  associate: ").Append(Associate).Append("\n");
            sb.Append("  disassociate: ").Append(Disassociate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateRouteTableAndSubnetReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateRouteTableAndSubnetReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Associate == input.Associate ||
                    this.Associate != null &&
                    input.Associate != null &&
                    this.Associate.SequenceEqual(input.Associate)
                ) && 
                (
                    this.Disassociate == input.Disassociate ||
                    this.Disassociate != null &&
                    input.Disassociate != null &&
                    this.Disassociate.SequenceEqual(input.Disassociate)
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
                if (this.Associate != null)
                    hashCode = hashCode * 59 + this.Associate.GetHashCode();
                if (this.Disassociate != null)
                    hashCode = hashCode * 59 + this.Disassociate.GetHashCode();
                return hashCode;
            }
        }
    }
}
