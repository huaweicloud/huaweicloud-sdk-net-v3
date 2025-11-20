using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceByInstanceIdResponse : SdkResponse
    {

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 企业项目id
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 当前时间
        /// </summary>
        [JsonProperty("current_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product_spec_data", NullValueHandling = NullValueHandling.Ignore)]
        public ProductSpecData ProductSpecData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance_config", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceConfig InstanceConfig { get; set; }

        /// <summary>
        /// 弹性业务带宽是否可更新
        /// </summary>
        [JsonProperty("elastic_service_bw_update_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ElasticServiceBwUpdateEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceByInstanceIdResponse {\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  currentTime: ").Append(CurrentTime).Append("\n");
            sb.Append("  productSpecData: ").Append(ProductSpecData).Append("\n");
            sb.Append("  instanceConfig: ").Append(InstanceConfig).Append("\n");
            sb.Append("  elasticServiceBwUpdateEnable: ").Append(ElasticServiceBwUpdateEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceByInstanceIdResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceByInstanceIdResponse input)
        {
            if (input == null) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CurrentTime != input.CurrentTime || (this.CurrentTime != null && !this.CurrentTime.Equals(input.CurrentTime))) return false;
            if (this.ProductSpecData != input.ProductSpecData || (this.ProductSpecData != null && !this.ProductSpecData.Equals(input.ProductSpecData))) return false;
            if (this.InstanceConfig != input.InstanceConfig || (this.InstanceConfig != null && !this.InstanceConfig.Equals(input.InstanceConfig))) return false;
            if (this.ElasticServiceBwUpdateEnable != input.ElasticServiceBwUpdateEnable || (this.ElasticServiceBwUpdateEnable != null && !this.ElasticServiceBwUpdateEnable.Equals(input.ElasticServiceBwUpdateEnable))) return false;

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
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CurrentTime != null) hashCode = hashCode * 59 + this.CurrentTime.GetHashCode();
                if (this.ProductSpecData != null) hashCode = hashCode * 59 + this.ProductSpecData.GetHashCode();
                if (this.InstanceConfig != null) hashCode = hashCode * 59 + this.InstanceConfig.GetHashCode();
                if (this.ElasticServiceBwUpdateEnable != null) hashCode = hashCode * 59 + this.ElasticServiceBwUpdateEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
