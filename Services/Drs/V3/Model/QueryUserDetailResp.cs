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
    /// 迁移用户响应体
    /// </summary>
    public class QueryUserDetailResp 
    {

        /// <summary>
        /// 用户账户id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 账户。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 说明。
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 是否支持迁移
        /// </summary>
        [JsonProperty("is_transfer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTransfer { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        [JsonProperty("privileges", NullValueHandling = NullValueHandling.Ignore)]
        public string Privileges { get; set; }

        /// <summary>
        /// 密码。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 账号拥有的角色
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// 是否选择。
        /// </summary>
        [JsonProperty("selected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Selected { get; set; }

        /// <summary>
        /// 无法同步的用户权限
        /// </summary>
        [JsonProperty("no_privileges", NullValueHandling = NullValueHandling.Ignore)]
        public string NoPrivileges { get; set; }

        /// <summary>
        /// 父用户
        /// </summary>
        [JsonProperty("parent_account", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentAccount { get; set; }

        /// <summary>
        /// 无法同步父子关系的父用户
        /// </summary>
        [JsonProperty("no_parent_account", NullValueHandling = NullValueHandling.Ignore)]
        public string NoParentAccount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryUserDetailResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  isTransfer: ").Append(IsTransfer).Append("\n");
            sb.Append("  privileges: ").Append(Privileges).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  roles: ").Append(Roles).Append("\n");
            sb.Append("  selected: ").Append(Selected).Append("\n");
            sb.Append("  noPrivileges: ").Append(NoPrivileges).Append("\n");
            sb.Append("  parentAccount: ").Append(ParentAccount).Append("\n");
            sb.Append("  noParentAccount: ").Append(NoParentAccount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryUserDetailResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryUserDetailResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.IsTransfer == input.IsTransfer ||
                    (this.IsTransfer != null &&
                    this.IsTransfer.Equals(input.IsTransfer))
                ) && 
                (
                    this.Privileges == input.Privileges ||
                    (this.Privileges != null &&
                    this.Privileges.Equals(input.Privileges))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Selected == input.Selected ||
                    (this.Selected != null &&
                    this.Selected.Equals(input.Selected))
                ) && 
                (
                    this.NoPrivileges == input.NoPrivileges ||
                    (this.NoPrivileges != null &&
                    this.NoPrivileges.Equals(input.NoPrivileges))
                ) && 
                (
                    this.ParentAccount == input.ParentAccount ||
                    (this.ParentAccount != null &&
                    this.ParentAccount.Equals(input.ParentAccount))
                ) && 
                (
                    this.NoParentAccount == input.NoParentAccount ||
                    (this.NoParentAccount != null &&
                    this.NoParentAccount.Equals(input.NoParentAccount))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.IsTransfer != null)
                    hashCode = hashCode * 59 + this.IsTransfer.GetHashCode();
                if (this.Privileges != null)
                    hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Selected != null)
                    hashCode = hashCode * 59 + this.Selected.GetHashCode();
                if (this.NoPrivileges != null)
                    hashCode = hashCode * 59 + this.NoPrivileges.GetHashCode();
                if (this.ParentAccount != null)
                    hashCode = hashCode * 59 + this.ParentAccount.GetHashCode();
                if (this.NoParentAccount != null)
                    hashCode = hashCode * 59 + this.NoParentAccount.GetHashCode();
                return hashCode;
            }
        }
    }
}
