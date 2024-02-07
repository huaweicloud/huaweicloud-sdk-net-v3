using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// 批量创建全域弹性公网IP请求体对象
    /// </summary>
    public class BatchCreateGlobalEipRequestBodyGlobalEip 
    {

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用户自定义的资源描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 全域弹性公网IP池子名称
        /// </summary>
        [JsonProperty("geip_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GeipPoolName { get; set; }

        /// <summary>
        /// 接入点信息
        /// </summary>
        [JsonProperty("access_site", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessSite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("internet_bandwidth_info", NullValueHandling = NullValueHandling.Ignore)]
        public BatchCreateGlobalEipRequestBodyGlobalEipInternetBandwidthInfo InternetBandwidthInfo { get; set; }

        /// <summary>
        /// 批创个数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 全域弹性公网IP标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateGlobalEipRequestBodyGlobalEipTags> Tags { get; set; }

        /// <summary>
        /// 资源的企业项目id
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateGlobalEipRequestBodyGlobalEip {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  geipPoolName: ").Append(GeipPoolName).Append("\n");
            sb.Append("  accessSite: ").Append(AccessSite).Append("\n");
            sb.Append("  internetBandwidthInfo: ").Append(InternetBandwidthInfo).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateGlobalEipRequestBodyGlobalEip);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateGlobalEipRequestBodyGlobalEip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.GeipPoolName == input.GeipPoolName ||
                    (this.GeipPoolName != null &&
                    this.GeipPoolName.Equals(input.GeipPoolName))
                ) && 
                (
                    this.AccessSite == input.AccessSite ||
                    (this.AccessSite != null &&
                    this.AccessSite.Equals(input.AccessSite))
                ) && 
                (
                    this.InternetBandwidthInfo == input.InternetBandwidthInfo ||
                    (this.InternetBandwidthInfo != null &&
                    this.InternetBandwidthInfo.Equals(input.InternetBandwidthInfo))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.GeipPoolName != null)
                    hashCode = hashCode * 59 + this.GeipPoolName.GetHashCode();
                if (this.AccessSite != null)
                    hashCode = hashCode * 59 + this.AccessSite.GetHashCode();
                if (this.InternetBandwidthInfo != null)
                    hashCode = hashCode * 59 + this.InternetBandwidthInfo.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
