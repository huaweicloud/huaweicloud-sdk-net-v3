using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowCcspClusterListRequest 
    {

        /// <summary>
        /// 指定查询返回记录条数，默认值10
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 索引位置，从page_num指定的下一条数据开始查询默认值为0
        /// </summary>
        [SDKProperty("page_num", IsQuery = true)]
        [JsonProperty("page_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNum { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 集群所属的服务类型： - **ENCRYPT_DECRYPT** : 加解密服务； - **SIGN_VERIFY** : 签名验签服务； - **KMS** : 密钥管理服务； - **TIMESTAMP** : 时间戳服务； - **COLLA_SIGN** : 协同签名服务； - **OTP** : 动态令牌服务； - **DB_ENCRYPT** : 数据库加密服务； - **FILE_ENCRYPT** : 文件加密服务 - **TIMESTAMP** : 时间戳服务； - **DIGIT_SEAL** : 电子签章服务； - **SSL_VPN** : ssl vpn服务；
        /// </summary>
        [SDKProperty("service_type", IsQuery = true)]
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 排序属性，目前支持以下属性： - **create_time** : 集群的创建时间（默认）
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 排序方向，支持以下值： - **DESC** : 降序（默认） - **ASC** : 升序
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCcspClusterListRequest {\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  pageNum: ").Append(PageNum).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCcspClusterListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCcspClusterListRequest input)
        {
            if (input == null) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.PageNum != input.PageNum || (this.PageNum != null && !this.PageNum.Equals(input.PageNum))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;

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
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.PageNum != null) hashCode = hashCode * 59 + this.PageNum.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                return hashCode;
            }
        }
    }
}
