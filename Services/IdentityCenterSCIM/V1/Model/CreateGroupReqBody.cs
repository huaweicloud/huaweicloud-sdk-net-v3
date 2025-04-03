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
    public class CreateGroupReqBody 
    {

        /// <summary>
        /// 外部标识符
        /// </summary>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// 包含用户组显示名称的字符串
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 用户组中的成员对象列表
        /// </summary>
        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public List<MemberItemDto> Members { get; set; }

        /// <summary>
        /// 概要
        /// </summary>
        [JsonProperty("schemas", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Schemas { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGroupReqBody {\n");
            sb.Append("  externalId: ").Append(ExternalId).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  members: ").Append(Members).Append("\n");
            sb.Append("  schemas: ").Append(Schemas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateGroupReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateGroupReqBody input)
        {
            if (input == null) return false;
            if (this.ExternalId != input.ExternalId || (this.ExternalId != null && !this.ExternalId.Equals(input.ExternalId))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Members != input.Members || (this.Members != null && input.Members != null && !this.Members.SequenceEqual(input.Members))) return false;
            if (this.Schemas != input.Schemas || (this.Schemas != null && input.Schemas != null && !this.Schemas.SequenceEqual(input.Schemas))) return false;

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
                if (this.ExternalId != null) hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Members != null) hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.Schemas != null) hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                return hashCode;
            }
        }
    }
}
