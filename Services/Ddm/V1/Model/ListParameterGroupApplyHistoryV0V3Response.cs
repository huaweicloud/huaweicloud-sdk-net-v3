using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListParameterGroupApplyHistoryV0V3Response : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  参数组应用记录相关信息的集合。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("rds_check_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplyHistory> RdsCheckInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListParameterGroupApplyHistoryV0V3Response {\n");
            sb.Append("  rdsCheckInfos: ").Append(RdsCheckInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListParameterGroupApplyHistoryV0V3Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListParameterGroupApplyHistoryV0V3Response input)
        {
            if (input == null) return false;
            if (this.RdsCheckInfos != input.RdsCheckInfos || (this.RdsCheckInfos != null && input.RdsCheckInfos != null && !this.RdsCheckInfos.SequenceEqual(input.RdsCheckInfos))) return false;

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
                if (this.RdsCheckInfos != null) hashCode = hashCode * 59 + this.RdsCheckInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
