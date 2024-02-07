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
    /// 创建全域弹性公网IP段请求对象信息
    /// </summary>
    public class CreateGlobalEipSegmentRequestBodyGlobalEipSegment 
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
        /// 掩码长度。取值范围由GET /v3/{domain_id}/global-eip-segments/support-masks接口提供
        /// </summary>
        [JsonProperty("mask", NullValueHandling = NullValueHandling.Ignore)]
        public int? Mask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("internet_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public CreateGlobalEipSegmentRequestBodyGlobalEipSegmentInternetBandwidth InternetBandwidth { get; set; }

        /// <summary>
        /// 全域弹性公网IP段标签
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
            sb.Append("class CreateGlobalEipSegmentRequestBodyGlobalEipSegment {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  geipPoolName: ").Append(GeipPoolName).Append("\n");
            sb.Append("  accessSite: ").Append(AccessSite).Append("\n");
            sb.Append("  mask: ").Append(Mask).Append("\n");
            sb.Append("  internetBandwidth: ").Append(InternetBandwidth).Append("\n");
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
            return this.Equals(input as CreateGlobalEipSegmentRequestBodyGlobalEipSegment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateGlobalEipSegmentRequestBodyGlobalEipSegment input)
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
                    this.Mask == input.Mask ||
                    (this.Mask != null &&
                    this.Mask.Equals(input.Mask))
                ) && 
                (
                    this.InternetBandwidth == input.InternetBandwidth ||
                    (this.InternetBandwidth != null &&
                    this.InternetBandwidth.Equals(input.InternetBandwidth))
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
                if (this.Mask != null)
                    hashCode = hashCode * 59 + this.Mask.GetHashCode();
                if (this.InternetBandwidth != null)
                    hashCode = hashCode * 59 + this.InternetBandwidth.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
