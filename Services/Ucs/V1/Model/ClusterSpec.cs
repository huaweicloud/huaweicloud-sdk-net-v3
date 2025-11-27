using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ClusterSpec 
    {

        /// <summary>
        /// 集群和karmada控制面之间的同步模式
        /// </summary>
        [JsonProperty("syncMode", NullValueHandling = NullValueHandling.Ignore)]
        public string SyncMode { get; set; }

        /// <summary>
        /// 容器舰队id
        /// </summary>
        [JsonProperty("clusterGroupID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterGroupID { get; set; }

        /// <summary>
        /// 集群类型，取值如下： - grouped：在舰队中纳管的集群 - discrete：未加入舰队的集群 
        /// </summary>
        [JsonProperty("manageType", NullValueHandling = NullValueHandling.Ignore)]
        public string ManageType { get; set; }

        /// <summary>
        /// 集群包含的RuleNamespace列表
        /// </summary>
        [JsonProperty("ruleNamespaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleNamespace> RuleNamespaces { get; set; }

        /// <summary>
        /// apiserver地址
        /// </summary>
        [JsonProperty("apiEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("secretRef", NullValueHandling = NullValueHandling.Ignore)]
        public LocalSecretReference SecretRef { get; set; }

        /// <summary>
        /// 是否跳过https校验
        /// </summary>
        [JsonProperty("insecureSkipTLSVerification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InsecureSkipTLSVerification { get; set; }

        /// <summary>
        /// 代理链接
        /// </summary>
        [JsonProperty("proxyURL", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyURL { get; set; }

        /// <summary>
        /// 提供商
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// CCE Turbo集群是否支持管理边缘基础设施。
        /// </summary>
        [JsonProperty("enableDistMgt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDistMgt { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("projectID", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectID { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        [JsonProperty("projectName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [JsonProperty("zone", NullValueHandling = NullValueHandling.Ignore)]
        public string Zone { get; set; }

        /// <summary>
        /// 污点
        /// </summary>
        [JsonProperty("taints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// 是否已经下载过证书
        /// </summary>
        [JsonProperty("IsDownloadedCert", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDownloadedCert { get; set; }

        /// <summary>
        /// 策略管理id
        /// </summary>
        [JsonProperty("policyId", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// 集群所属domainID
        /// </summary>
        [JsonProperty("operatorNamespace", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorNamespace { get; set; }

        /// <summary>
        /// 连接代理服务器的终端节点服务ID列表，仅非华为云集群返回该字段
        /// </summary>
        [JsonProperty("connectProxyEndpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConnectEndpoint> ConnectProxyEndpoints { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterSpec {\n");
            sb.Append("  syncMode: ").Append(SyncMode).Append("\n");
            sb.Append("  clusterGroupID: ").Append(ClusterGroupID).Append("\n");
            sb.Append("  manageType: ").Append(ManageType).Append("\n");
            sb.Append("  ruleNamespaces: ").Append(RuleNamespaces).Append("\n");
            sb.Append("  apiEndpoint: ").Append(ApiEndpoint).Append("\n");
            sb.Append("  secretRef: ").Append(SecretRef).Append("\n");
            sb.Append("  insecureSkipTLSVerification: ").Append(InsecureSkipTLSVerification).Append("\n");
            sb.Append("  proxyURL: ").Append(ProxyURL).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  enableDistMgt: ").Append(EnableDistMgt).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  city: ").Append(City).Append("\n");
            sb.Append("  projectID: ").Append(ProjectID).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  zone: ").Append(Zone).Append("\n");
            sb.Append("  taints: ").Append(Taints).Append("\n");
            sb.Append("  isDownloadedCert: ").Append(IsDownloadedCert).Append("\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  operatorNamespace: ").Append(OperatorNamespace).Append("\n");
            sb.Append("  connectProxyEndpoints: ").Append(ConnectProxyEndpoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterSpec input)
        {
            if (input == null) return false;
            if (this.SyncMode != input.SyncMode || (this.SyncMode != null && !this.SyncMode.Equals(input.SyncMode))) return false;
            if (this.ClusterGroupID != input.ClusterGroupID || (this.ClusterGroupID != null && !this.ClusterGroupID.Equals(input.ClusterGroupID))) return false;
            if (this.ManageType != input.ManageType || (this.ManageType != null && !this.ManageType.Equals(input.ManageType))) return false;
            if (this.RuleNamespaces != input.RuleNamespaces || (this.RuleNamespaces != null && input.RuleNamespaces != null && !this.RuleNamespaces.SequenceEqual(input.RuleNamespaces))) return false;
            if (this.ApiEndpoint != input.ApiEndpoint || (this.ApiEndpoint != null && !this.ApiEndpoint.Equals(input.ApiEndpoint))) return false;
            if (this.SecretRef != input.SecretRef || (this.SecretRef != null && !this.SecretRef.Equals(input.SecretRef))) return false;
            if (this.InsecureSkipTLSVerification != input.InsecureSkipTLSVerification || (this.InsecureSkipTLSVerification != null && !this.InsecureSkipTLSVerification.Equals(input.InsecureSkipTLSVerification))) return false;
            if (this.ProxyURL != input.ProxyURL || (this.ProxyURL != null && !this.ProxyURL.Equals(input.ProxyURL))) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.EnableDistMgt != input.EnableDistMgt || (this.EnableDistMgt != null && !this.EnableDistMgt.Equals(input.EnableDistMgt))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.City != input.City || (this.City != null && !this.City.Equals(input.City))) return false;
            if (this.ProjectID != input.ProjectID || (this.ProjectID != null && !this.ProjectID.Equals(input.ProjectID))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.Zone != input.Zone || (this.Zone != null && !this.Zone.Equals(input.Zone))) return false;
            if (this.Taints != input.Taints || (this.Taints != null && input.Taints != null && !this.Taints.SequenceEqual(input.Taints))) return false;
            if (this.IsDownloadedCert != input.IsDownloadedCert || (this.IsDownloadedCert != null && !this.IsDownloadedCert.Equals(input.IsDownloadedCert))) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.OperatorNamespace != input.OperatorNamespace || (this.OperatorNamespace != null && !this.OperatorNamespace.Equals(input.OperatorNamespace))) return false;
            if (this.ConnectProxyEndpoints != input.ConnectProxyEndpoints || (this.ConnectProxyEndpoints != null && input.ConnectProxyEndpoints != null && !this.ConnectProxyEndpoints.SequenceEqual(input.ConnectProxyEndpoints))) return false;

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
                if (this.SyncMode != null) hashCode = hashCode * 59 + this.SyncMode.GetHashCode();
                if (this.ClusterGroupID != null) hashCode = hashCode * 59 + this.ClusterGroupID.GetHashCode();
                if (this.ManageType != null) hashCode = hashCode * 59 + this.ManageType.GetHashCode();
                if (this.RuleNamespaces != null) hashCode = hashCode * 59 + this.RuleNamespaces.GetHashCode();
                if (this.ApiEndpoint != null) hashCode = hashCode * 59 + this.ApiEndpoint.GetHashCode();
                if (this.SecretRef != null) hashCode = hashCode * 59 + this.SecretRef.GetHashCode();
                if (this.InsecureSkipTLSVerification != null) hashCode = hashCode * 59 + this.InsecureSkipTLSVerification.GetHashCode();
                if (this.ProxyURL != null) hashCode = hashCode * 59 + this.ProxyURL.GetHashCode();
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.EnableDistMgt != null) hashCode = hashCode * 59 + this.EnableDistMgt.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.City != null) hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.ProjectID != null) hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Zone != null) hashCode = hashCode * 59 + this.Zone.GetHashCode();
                if (this.Taints != null) hashCode = hashCode * 59 + this.Taints.GetHashCode();
                if (this.IsDownloadedCert != null) hashCode = hashCode * 59 + this.IsDownloadedCert.GetHashCode();
                if (this.PolicyId != null) hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.OperatorNamespace != null) hashCode = hashCode * 59 + this.OperatorNamespace.GetHashCode();
                if (this.ConnectProxyEndpoints != null) hashCode = hashCode * 59 + this.ConnectProxyEndpoints.GetHashCode();
                return hashCode;
            }
        }
    }
}
