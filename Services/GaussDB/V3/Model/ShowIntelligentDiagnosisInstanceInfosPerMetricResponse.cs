using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowIntelligentDiagnosisInstanceInfosPerMetricResponse : SdkResponse
    {

        /// <summary>
        /// 当前指标的异常实例总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 异常实例信息。
        /// </summary>
        [JsonProperty("instance_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceInfoForDiagnosis> InstanceInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIntelligentDiagnosisInstanceInfosPerMetricResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  instanceInfos: ").Append(InstanceInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIntelligentDiagnosisInstanceInfosPerMetricResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIntelligentDiagnosisInstanceInfosPerMetricResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.InstanceInfos != input.InstanceInfos || (this.InstanceInfos != null && input.InstanceInfos != null && !this.InstanceInfos.SequenceEqual(input.InstanceInfos))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.InstanceInfos != null) hashCode = hashCode * 59 + this.InstanceInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
