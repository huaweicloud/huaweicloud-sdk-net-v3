using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowUserEmailsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 用户id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 用户名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 用户长id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// **参数解释：** 用户状态。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 最后活跃时间。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("last_activity_on", NullValueHandling = NullValueHandling.Ignore)]
        public string LastActivityOn { get; set; }

        /// <summary>
        /// **参数解释：** 提交邮箱。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("commit_email", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitEmail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserEmailsResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  lastActivityOn: ").Append(LastActivityOn).Append("\n");
            sb.Append("  commitEmail: ").Append(CommitEmail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserEmailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserEmailsResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.LastActivityOn != input.LastActivityOn || (this.LastActivityOn != null && !this.LastActivityOn.Equals(input.LastActivityOn))) return false;
            if (this.CommitEmail != input.CommitEmail || (this.CommitEmail != null && !this.CommitEmail.Equals(input.CommitEmail))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.LastActivityOn != null) hashCode = hashCode * 59 + this.LastActivityOn.GetHashCode();
                if (this.CommitEmail != null) hashCode = hashCode * 59 + this.CommitEmail.GetHashCode();
                return hashCode;
            }
        }
    }
}
