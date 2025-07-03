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
    /// 
    /// </summary>
    public class CmdbTagEntity 
    {

        /// <summary>
        /// 环境标签名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// UUID。
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("descp", NullValueHandling = NullValueHandling.Ignore)]
        public string Descp { get; set; }

        /// <summary>
        /// 创建者id。
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatorId { get; set; }

        /// <summary>
        /// 环境id列表。
        /// </summary>
        [JsonProperty("env_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> EnvIdList { get; set; }

        /// <summary>
        /// 环境标签id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间。
        /// </summary>
        [JsonProperty("gmt_modify", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtModify { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CmdbTagEntity {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  descp: ").Append(Descp).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  envIdList: ").Append(EnvIdList).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  gmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  gmtModify: ").Append(GmtModify).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CmdbTagEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CmdbTagEntity input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.Descp != input.Descp || (this.Descp != null && !this.Descp.Equals(input.Descp))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.EnvIdList != input.EnvIdList || (this.EnvIdList != null && input.EnvIdList != null && !this.EnvIdList.SequenceEqual(input.EnvIdList))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.GmtCreate != input.GmtCreate || (this.GmtCreate != null && !this.GmtCreate.Equals(input.GmtCreate))) return false;
            if (this.GmtModify != input.GmtModify || (this.GmtModify != null && !this.GmtModify.Equals(input.GmtModify))) return false;

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
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Descp != null) hashCode = hashCode * 59 + this.Descp.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.EnvIdList != null) hashCode = hashCode * 59 + this.EnvIdList.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.GmtCreate != null) hashCode = hashCode * 59 + this.GmtCreate.GetHashCode();
                if (this.GmtModify != null) hashCode = hashCode * 59 + this.GmtModify.GetHashCode();
                return hashCode;
            }
        }
    }
}
