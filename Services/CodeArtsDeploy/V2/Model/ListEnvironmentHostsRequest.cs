using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListEnvironmentHostsRequest 
    {

        /// <summary>
        /// 应用id
        /// </summary>
        [SDKProperty("application_id", IsPath = true)]
        [JsonProperty("application_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [SDKProperty("environment_id", IsPath = true)]
        [JsonProperty("environment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// 主机名、ip关键字模糊搜索
        /// </summary>
        [SDKProperty("key_field", IsQuery = true)]
        [JsonProperty("key_field", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyField { get; set; }

        /// <summary>
        /// 是否为代理机,true为代理机
        /// </summary>
        [SDKProperty("as_proxy", IsQuery = true)]
        [JsonProperty("as_proxy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsProxy { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [SDKProperty("page_index", IsQuery = true)]
        [JsonProperty("page_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// 分页查询每页条数
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnvironmentHostsRequest {\n");
            sb.Append("  applicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  environmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("  keyField: ").Append(KeyField).Append("\n");
            sb.Append("  asProxy: ").Append(AsProxy).Append("\n");
            sb.Append("  pageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnvironmentHostsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnvironmentHostsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.EnvironmentId == input.EnvironmentId ||
                    (this.EnvironmentId != null &&
                    this.EnvironmentId.Equals(input.EnvironmentId))
                ) && 
                (
                    this.KeyField == input.KeyField ||
                    (this.KeyField != null &&
                    this.KeyField.Equals(input.KeyField))
                ) && 
                (
                    this.AsProxy == input.AsProxy ||
                    (this.AsProxy != null &&
                    this.AsProxy.Equals(input.AsProxy))
                ) && 
                (
                    this.PageIndex == input.PageIndex ||
                    (this.PageIndex != null &&
                    this.PageIndex.Equals(input.PageIndex))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.EnvironmentId != null)
                    hashCode = hashCode * 59 + this.EnvironmentId.GetHashCode();
                if (this.KeyField != null)
                    hashCode = hashCode * 59 + this.KeyField.GetHashCode();
                if (this.AsProxy != null)
                    hashCode = hashCode * 59 + this.AsProxy.GetHashCode();
                if (this.PageIndex != null)
                    hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
