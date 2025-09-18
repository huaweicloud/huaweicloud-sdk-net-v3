using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateDefectRequestBody 
    {

        /// <summary>
        /// 问题id,多个时英文逗号分隔
        /// </summary>
        [JsonProperty("defect_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectId { get; set; }

        /// <summary>
        /// 状态2：已忽略 1：已解决 0：未解决
        /// </summary>
        [JsonProperty("defect_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDefectRequestBody {\n");
            sb.Append("  defectId: ").Append(DefectId).Append("\n");
            sb.Append("  defectStatus: ").Append(DefectStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDefectRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDefectRequestBody input)
        {
            if (input == null) return false;
            if (this.DefectId != input.DefectId || (this.DefectId != null && !this.DefectId.Equals(input.DefectId))) return false;
            if (this.DefectStatus != input.DefectStatus || (this.DefectStatus != null && !this.DefectStatus.Equals(input.DefectStatus))) return false;

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
                if (this.DefectId != null) hashCode = hashCode * 59 + this.DefectId.GetHashCode();
                if (this.DefectStatus != null) hashCode = hashCode * 59 + this.DefectStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
