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
    /// **参数解释**： 查询VPC间防火墙使用引流VPC返回体 **取值范围**： 不涉及
    /// </summary>
    public class ShowEwAssociatedVpcRespData 
    {

        /// <summary>
        /// **参数解释**： 使用引流VPC列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("inspection_vpc_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<InspectionVpcInfo> InspectionVpcList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEwAssociatedVpcRespData {\n");
            sb.Append("  inspectionVpcList: ").Append(InspectionVpcList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEwAssociatedVpcRespData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEwAssociatedVpcRespData input)
        {
            if (input == null) return false;
            if (this.InspectionVpcList != input.InspectionVpcList || (this.InspectionVpcList != null && input.InspectionVpcList != null && !this.InspectionVpcList.SequenceEqual(input.InspectionVpcList))) return false;

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
                if (this.InspectionVpcList != null) hashCode = hashCode * 59 + this.InspectionVpcList.GetHashCode();
                return hashCode;
            }
        }
    }
}
