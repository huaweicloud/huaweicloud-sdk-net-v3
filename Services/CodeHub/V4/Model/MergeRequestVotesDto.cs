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
    /// 合并请求打分记录(单人)
    /// </summary>
    public class MergeRequestVotesDto 
    {

        /// <summary>
        /// **参数解释：** 打分记录的id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 分数。
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public int? Score { get; set; }

        /// <summary>
        /// **参数解释：** 作者名。
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// **参数解释：** 作者用户名。
        /// </summary>
        [JsonProperty("author_username", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorUsername { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 最后一次提交记录的id。
        /// </summary>
        [JsonProperty("last_committed_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCommittedId { get; set; }

        /// <summary>
        /// **参数解释：** 作者id。
        /// </summary>
        [JsonProperty("author_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AuthorId { get; set; }

        /// <summary>
        /// **参数解释：** 作者头像url。
        /// </summary>
        [JsonProperty("avatar_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// **参数解释：** 作者昵称。
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// **参数解释：** 作者租户名称。
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestVotesDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  authorUsername: ").Append(AuthorUsername).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  lastCommittedId: ").Append(LastCommittedId).Append("\n");
            sb.Append("  authorId: ").Append(AuthorId).Append("\n");
            sb.Append("  avatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestVotesDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestVotesDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Score != input.Score || (this.Score != null && !this.Score.Equals(input.Score))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.AuthorUsername != input.AuthorUsername || (this.AuthorUsername != null && !this.AuthorUsername.Equals(input.AuthorUsername))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.LastCommittedId != input.LastCommittedId || (this.LastCommittedId != null && !this.LastCommittedId.Equals(input.LastCommittedId))) return false;
            if (this.AuthorId != input.AuthorId || (this.AuthorId != null && !this.AuthorId.Equals(input.AuthorId))) return false;
            if (this.AvatarUrl != input.AvatarUrl || (this.AvatarUrl != null && !this.AvatarUrl.Equals(input.AvatarUrl))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;

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
                if (this.Score != null) hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.AuthorUsername != null) hashCode = hashCode * 59 + this.AuthorUsername.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.LastCommittedId != null) hashCode = hashCode * 59 + this.LastCommittedId.GetHashCode();
                if (this.AuthorId != null) hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.AvatarUrl != null) hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                return hashCode;
            }
        }
    }
}
