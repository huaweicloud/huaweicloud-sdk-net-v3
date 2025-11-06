using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PromInstanceRequestModel 
    {

        /// <summary>
        /// Prometheus实例名称 名称不能以下划线或中划线开头结尾，只含有中文、英文、数字、下划线、中划线、长度1-100。
        /// </summary>
        [JsonProperty("prom_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PromName { get; set; }

        /// <summary>
        /// Prometheus实例类型。 - ECS：Prometheus for ECS - CCE：Prometheus for CCE - REMOTE_WRITE：Prometheus 通用实例 - CLOUD_SERVICE：Prometheus for 云服务 - ACROSS_ACCOUNT：Prometheus for 多账号聚合实例 [（暂不支持ACROSS_ACCOUNT类型）](tag:hws_eu,g42,sbc,OCB,ctc,cmcc,srg,hk_sbc,ctc,DT)
        /// </summary>
        [JsonProperty("prom_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PromType { get; set; }

        /// <summary>
        /// Prometheus实例版本号。
        /// </summary>
        [JsonProperty("prom_version", NullValueHandling = NullValueHandling.Ignore)]
        public string PromVersion { get; set; }

        /// <summary>
        /// Prometheus实例所属的企业项目。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// Prometheus实例所属projectId。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 被聚合的账号和普罗实例列表。
        /// </summary>
        [JsonProperty("aggr_prometheus_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<AggrPrometheusInfo> AggrPrometheusInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromInstanceRequestModel {\n");
            sb.Append("  promName: ").Append(PromName).Append("\n");
            sb.Append("  promType: ").Append(PromType).Append("\n");
            sb.Append("  promVersion: ").Append(PromVersion).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  aggrPrometheusInfo: ").Append(AggrPrometheusInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PromInstanceRequestModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PromInstanceRequestModel input)
        {
            if (input == null) return false;
            if (this.PromName != input.PromName || (this.PromName != null && !this.PromName.Equals(input.PromName))) return false;
            if (this.PromType != input.PromType || (this.PromType != null && !this.PromType.Equals(input.PromType))) return false;
            if (this.PromVersion != input.PromVersion || (this.PromVersion != null && !this.PromVersion.Equals(input.PromVersion))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.AggrPrometheusInfo != input.AggrPrometheusInfo || (this.AggrPrometheusInfo != null && input.AggrPrometheusInfo != null && !this.AggrPrometheusInfo.SequenceEqual(input.AggrPrometheusInfo))) return false;

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
                if (this.PromName != null) hashCode = hashCode * 59 + this.PromName.GetHashCode();
                if (this.PromType != null) hashCode = hashCode * 59 + this.PromType.GetHashCode();
                if (this.PromVersion != null) hashCode = hashCode * 59 + this.PromVersion.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.AggrPrometheusInfo != null) hashCode = hashCode * 59 + this.AggrPrometheusInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
