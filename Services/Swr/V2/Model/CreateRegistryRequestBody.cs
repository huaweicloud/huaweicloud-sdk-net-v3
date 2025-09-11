using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateRegistryRequestBody 
    {

        /// <summary>
        /// 目标仓库名称，1-64字符组成，只能包含英文大小写、数字、汉字、中划线和下划线。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 目标仓库描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 仓库类型，swr-pro(开源harbor仓库)、swr-pro-internal(SWR企业版仓库)、huawei-SWR(SWR基础版仓库)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 企业仓库实例所属的项目ID，当type为swr-pro-internal时必填
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 区域ID，当type为swr-pro-internal时必填
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 企业仓库实例ID，当type为swr-pro-internal时必填
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 目标仓库的地址
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("credential", NullValueHandling = NullValueHandling.Ignore)]
        public Credential Credential { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dns_conf", NullValueHandling = NullValueHandling.Ignore)]
        public DnsConf DnsConf { get; set; }

        /// <summary>
        /// 是否验证远程证书
        /// </summary>
        [JsonProperty("insecure", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Insecure { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRegistryRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  credential: ").Append(Credential).Append("\n");
            sb.Append("  dnsConf: ").Append(DnsConf).Append("\n");
            sb.Append("  insecure: ").Append(Insecure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRegistryRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRegistryRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Credential != input.Credential || (this.Credential != null && !this.Credential.Equals(input.Credential))) return false;
            if (this.DnsConf != input.DnsConf || (this.DnsConf != null && !this.DnsConf.Equals(input.DnsConf))) return false;
            if (this.Insecure != input.Insecure || (this.Insecure != null && !this.Insecure.Equals(input.Insecure))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Credential != null) hashCode = hashCode * 59 + this.Credential.GetHashCode();
                if (this.DnsConf != null) hashCode = hashCode * 59 + this.DnsConf.GetHashCode();
                if (this.Insecure != null) hashCode = hashCode * 59 + this.Insecure.GetHashCode();
                return hashCode;
            }
        }
    }
}
