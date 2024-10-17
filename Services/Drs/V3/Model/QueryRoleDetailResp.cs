using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 迁移角色响应体
    /// </summary>
    public class QueryRoleDetailResp 
    {

        /// <summary>
        /// 角色。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 说明。
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 是否支持迁移。
        /// </summary>
        [JsonProperty("is_transfer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTransfer { get; set; }

        /// <summary>
        /// 角色权限。
        /// </summary>
        [JsonProperty("privileges", NullValueHandling = NullValueHandling.Ignore)]
        public string Privileges { get; set; }

        /// <summary>
        /// 继承的角色。
        /// </summary>
        [JsonProperty("inherits_roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InheritsRoles { get; set; }

        /// <summary>
        /// 是否选择。
        /// </summary>
        [JsonProperty("selected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Selected { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRoleDetailResp {\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  isTransfer: ").Append(IsTransfer).Append("\n");
            sb.Append("  privileges: ").Append(Privileges).Append("\n");
            sb.Append("  inheritsRoles: ").Append(InheritsRoles).Append("\n");
            sb.Append("  selected: ").Append(Selected).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryRoleDetailResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryRoleDetailResp input)
        {
            if (input == null) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.IsTransfer != input.IsTransfer || (this.IsTransfer != null && !this.IsTransfer.Equals(input.IsTransfer))) return false;
            if (this.Privileges != input.Privileges || (this.Privileges != null && !this.Privileges.Equals(input.Privileges))) return false;
            if (this.InheritsRoles != input.InheritsRoles || (this.InheritsRoles != null && input.InheritsRoles != null && !this.InheritsRoles.SequenceEqual(input.InheritsRoles))) return false;
            if (this.Selected != input.Selected || (this.Selected != null && !this.Selected.Equals(input.Selected))) return false;

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
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.IsTransfer != null) hashCode = hashCode * 59 + this.IsTransfer.GetHashCode();
                if (this.Privileges != null) hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                if (this.InheritsRoles != null) hashCode = hashCode * 59 + this.InheritsRoles.GetHashCode();
                if (this.Selected != null) hashCode = hashCode * 59 + this.Selected.GetHashCode();
                return hashCode;
            }
        }
    }
}
