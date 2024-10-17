using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowReleaseResponse : SdkResponse
    {

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("chart_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ChartName { get; set; }

        /// <summary>
        /// 是否公开模板
        /// </summary>
        [JsonProperty("chart_public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChartPublic { get; set; }

        /// <summary>
        /// 模板版本
        /// </summary>
        [JsonProperty("chart_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ChartVersion { get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// 模板实例描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 模板实例名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 模板实例所在的命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 模板实例参数
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public string Parameters { get; set; }

        /// <summary>
        /// 模板实例需要的资源
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public string Resources { get; set; }

        /// <summary>
        /// 模板实例状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 模板实例状态描述
        /// </summary>
        [JsonProperty("status_description", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }

        /// <summary>
        /// 模板实例的值
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public string Values { get; set; }

        /// <summary>
        /// 模板实例版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReleaseResponse {\n");
            sb.Append("  chartName: ").Append(ChartName).Append("\n");
            sb.Append("  chartPublic: ").Append(ChartPublic).Append("\n");
            sb.Append("  chartVersion: ").Append(ChartVersion).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  clusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReleaseResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReleaseResponse input)
        {
            if (input == null) return false;
            if (this.ChartName != input.ChartName || (this.ChartName != null && !this.ChartName.Equals(input.ChartName))) return false;
            if (this.ChartPublic != input.ChartPublic || (this.ChartPublic != null && !this.ChartPublic.Equals(input.ChartPublic))) return false;
            if (this.ChartVersion != input.ChartVersion || (this.ChartVersion != null && !this.ChartVersion.Equals(input.ChartVersion))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.ClusterName != input.ClusterName || (this.ClusterName != null && !this.ClusterName.Equals(input.ClusterName))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && !this.Parameters.Equals(input.Parameters))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && !this.Resources.Equals(input.Resources))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StatusDescription != input.StatusDescription || (this.StatusDescription != null && !this.StatusDescription.Equals(input.StatusDescription))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.Values != input.Values || (this.Values != null && !this.Values.Equals(input.Values))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;

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
                if (this.ChartName != null) hashCode = hashCode * 59 + this.ChartName.GetHashCode();
                if (this.ChartPublic != null) hashCode = hashCode * 59 + this.ChartPublic.GetHashCode();
                if (this.ChartVersion != null) hashCode = hashCode * 59 + this.ChartVersion.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterName != null) hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null) hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
