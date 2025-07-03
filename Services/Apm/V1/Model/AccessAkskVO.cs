using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// ak/sk数据模型。
    /// </summary>
    public class AccessAkskVO 
    {

        /// <summary>
        /// ak/sk的id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// ak/sk的生成时间。
        /// </summary>
        [JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// ak/sk的修改时间。
        /// </summary>
        [JsonProperty("gmt_modify", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtModify { get; set; }

        /// <summary>
        /// 内部租户id。
        /// </summary>
        [JsonProperty("inner_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? InnerDomainId { get; set; }

        /// <summary>
        /// 生成的ak。
        /// </summary>
        [JsonProperty("ak", NullValueHandling = NullValueHandling.Ignore)]
        public string Ak { get; set; }

        /// <summary>
        /// 生成的sk。
        /// </summary>
        [JsonProperty("sk", NullValueHandling = NullValueHandling.Ignore)]
        public string Sk { get; set; }

        /// <summary>
        /// ak/sk的状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// ak/sk的描述信息。
        /// </summary>
        [JsonProperty("descp", NullValueHandling = NullValueHandling.Ignore)]
        public string Descp { get; set; }

        /// <summary>
        /// ak/sk的生成时间戳。
        /// </summary>
        [JsonProperty("gmt_create_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? GmtCreateTimestamp { get; set; }

        /// <summary>
        /// ak/sk的修改时间戳。
        /// </summary>
        [JsonProperty("gmt_modify_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? GmtModifyTimestamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessAkskVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  gmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  gmtModify: ").Append(GmtModify).Append("\n");
            sb.Append("  innerDomainId: ").Append(InnerDomainId).Append("\n");
            sb.Append("  ak: ").Append(Ak).Append("\n");
            sb.Append("  sk: ").Append(Sk).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  descp: ").Append(Descp).Append("\n");
            sb.Append("  gmtCreateTimestamp: ").Append(GmtCreateTimestamp).Append("\n");
            sb.Append("  gmtModifyTimestamp: ").Append(GmtModifyTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessAkskVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessAkskVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.GmtCreate != input.GmtCreate || (this.GmtCreate != null && !this.GmtCreate.Equals(input.GmtCreate))) return false;
            if (this.GmtModify != input.GmtModify || (this.GmtModify != null && !this.GmtModify.Equals(input.GmtModify))) return false;
            if (this.InnerDomainId != input.InnerDomainId || (this.InnerDomainId != null && !this.InnerDomainId.Equals(input.InnerDomainId))) return false;
            if (this.Ak != input.Ak || (this.Ak != null && !this.Ak.Equals(input.Ak))) return false;
            if (this.Sk != input.Sk || (this.Sk != null && !this.Sk.Equals(input.Sk))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Descp != input.Descp || (this.Descp != null && !this.Descp.Equals(input.Descp))) return false;
            if (this.GmtCreateTimestamp != input.GmtCreateTimestamp || (this.GmtCreateTimestamp != null && !this.GmtCreateTimestamp.Equals(input.GmtCreateTimestamp))) return false;
            if (this.GmtModifyTimestamp != input.GmtModifyTimestamp || (this.GmtModifyTimestamp != null && !this.GmtModifyTimestamp.Equals(input.GmtModifyTimestamp))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.GmtCreate != null) hashCode = hashCode * 59 + this.GmtCreate.GetHashCode();
                if (this.GmtModify != null) hashCode = hashCode * 59 + this.GmtModify.GetHashCode();
                if (this.InnerDomainId != null) hashCode = hashCode * 59 + this.InnerDomainId.GetHashCode();
                if (this.Ak != null) hashCode = hashCode * 59 + this.Ak.GetHashCode();
                if (this.Sk != null) hashCode = hashCode * 59 + this.Sk.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Descp != null) hashCode = hashCode * 59 + this.Descp.GetHashCode();
                if (this.GmtCreateTimestamp != null) hashCode = hashCode * 59 + this.GmtCreateTimestamp.GetHashCode();
                if (this.GmtModifyTimestamp != null) hashCode = hashCode * 59 + this.GmtModifyTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
