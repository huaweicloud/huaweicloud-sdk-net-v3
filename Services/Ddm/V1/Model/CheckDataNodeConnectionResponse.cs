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
    public class CheckDataNodeConnectionResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  rds测试连通性相关信息的集合。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("rds_check_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<CheckRdsConnectionResqVO> RdsCheckInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckDataNodeConnectionResponse {\n");
            sb.Append("  rdsCheckInfos: ").Append(RdsCheckInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckDataNodeConnectionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckDataNodeConnectionResponse input)
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
