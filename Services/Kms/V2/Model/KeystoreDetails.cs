using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// 密钥库详情
    /// </summary>
    public class KeystoreDetails 
    {

        /// <summary>
        /// 密钥库ID
        /// </summary>
        [JsonProperty("keystore_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreId { get; set; }

        /// <summary>
        /// 用户域ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 密钥库别名
        /// </summary>
        [JsonProperty("keystore_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreAlias { get; set; }

        /// <summary>
        /// 密钥库类型
        /// </summary>
        [JsonProperty("keystore_type", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreType { get; set; }

        /// <summary>
        /// DHSM集群id，要求集群当前未创建专属密钥库
        /// </summary>
        [JsonProperty("hsm_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HsmClusterId { get; set; }

        /// <summary>
        /// 集群ID。当类型为DEFAULT时，cluster_id为”0”。当类型为DHSM时，cluster_id为hsm_cluster_id。当类型为CDMS时，默认密码卡集群，集群ID为“1”。自定义密码卡集群，为cdms_cluster_id
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 密钥库创建时间，UTC时间戳。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoreDetails {\n");
            sb.Append("  keystoreId: ").Append(KeystoreId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  keystoreAlias: ").Append(KeystoreAlias).Append("\n");
            sb.Append("  keystoreType: ").Append(KeystoreType).Append("\n");
            sb.Append("  hsmClusterId: ").Append(HsmClusterId).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoreDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoreDetails input)
        {
            if (input == null) return false;
            if (this.KeystoreId != input.KeystoreId || (this.KeystoreId != null && !this.KeystoreId.Equals(input.KeystoreId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.KeystoreAlias != input.KeystoreAlias || (this.KeystoreAlias != null && !this.KeystoreAlias.Equals(input.KeystoreAlias))) return false;
            if (this.KeystoreType != input.KeystoreType || (this.KeystoreType != null && !this.KeystoreType.Equals(input.KeystoreType))) return false;
            if (this.HsmClusterId != input.HsmClusterId || (this.HsmClusterId != null && !this.HsmClusterId.Equals(input.HsmClusterId))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.KeystoreId != null) hashCode = hashCode * 59 + this.KeystoreId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.KeystoreAlias != null) hashCode = hashCode * 59 + this.KeystoreAlias.GetHashCode();
                if (this.KeystoreType != null) hashCode = hashCode * 59 + this.KeystoreType.GetHashCode();
                if (this.HsmClusterId != null) hashCode = hashCode * 59 + this.HsmClusterId.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
