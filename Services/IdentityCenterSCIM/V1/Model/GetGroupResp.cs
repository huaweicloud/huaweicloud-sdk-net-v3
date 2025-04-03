using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterSCIM.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GetGroupResp 
    {

        /// <summary>
        /// 用户组的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 外部标识符
        /// </summary>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public MetaDto Meta { get; set; }

        /// <summary>
        /// 概要
        /// </summary>
        [JsonProperty("schemas", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Schemas { get; set; }

        /// <summary>
        /// 包含用户显示名称的字符串
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 用户组中的成员对象列表
        /// </summary>
        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public List<MemberItemDto> Members { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetGroupResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  externalId: ").Append(ExternalId).Append("\n");
            sb.Append("  meta: ").Append(Meta).Append("\n");
            sb.Append("  schemas: ").Append(Schemas).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  members: ").Append(Members).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetGroupResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetGroupResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ExternalId != input.ExternalId || (this.ExternalId != null && !this.ExternalId.Equals(input.ExternalId))) return false;
            if (this.Meta != input.Meta || (this.Meta != null && !this.Meta.Equals(input.Meta))) return false;
            if (this.Schemas != input.Schemas || (this.Schemas != null && input.Schemas != null && !this.Schemas.SequenceEqual(input.Schemas))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Members != input.Members || (this.Members != null && input.Members != null && !this.Members.SequenceEqual(input.Members))) return false;

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
                if (this.ExternalId != null) hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Meta != null) hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.Schemas != null) hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Members != null) hashCode = hashCode * 59 + this.Members.GetHashCode();
                return hashCode;
            }
        }
    }
}
