using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 为应用(组)添加(取消)授权的操作，必须为app_group_ids,app_ids同时赋值。 &gt; - 批量操作的应用组或者发布应用的授权模式必须统一，即要么都为应用类型的授权，要么都为应用组类型的授权，否则会直接失败(授权类型在创建应用组时指定)。
    /// </summary>
    public class AppGroupAuthorizeReq 
    {

        /// <summary>
        /// 应用组ID,最多同时操作10个。
        /// </summary>
        [JsonProperty("app_group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AppGroupIds { get; set; }

        /// <summary>
        /// 用户(组),单次最多允许操作50个用户(组)。
        /// </summary>
        [JsonProperty("accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountInfo> Accounts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppGroupAuthorizeReq {\n");
            sb.Append("  appGroupIds: ").Append(AppGroupIds).Append("\n");
            sb.Append("  accounts: ").Append(Accounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppGroupAuthorizeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppGroupAuthorizeReq input)
        {
            if (input == null) return false;
            if (this.AppGroupIds != input.AppGroupIds || (this.AppGroupIds != null && input.AppGroupIds != null && !this.AppGroupIds.SequenceEqual(input.AppGroupIds))) return false;
            if (this.Accounts != input.Accounts || (this.Accounts != null && input.Accounts != null && !this.Accounts.SequenceEqual(input.Accounts))) return false;

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
                if (this.AppGroupIds != null) hashCode = hashCode * 59 + this.AppGroupIds.GetHashCode();
                if (this.Accounts != null) hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                return hashCode;
            }
        }
    }
}
