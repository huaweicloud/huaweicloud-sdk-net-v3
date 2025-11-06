using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AddProjectWebhookResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** webhook地址。 **取值范围：** 字符串长度不少于0，不超过500。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释：** 是否启用推送事件。
        /// </summary>
        [JsonProperty("push_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PushEvents { get; set; }

        /// <summary>
        /// **参数解释：** 推送事件分支过滤正则规则。 **取值范围：** 字符串长度不少于0，不超过500。                
        /// </summary>
        [JsonProperty("push_events_branch_regex_filter", NullValueHandling = NullValueHandling.Ignore)]
        public string PushEventsBranchRegexFilter { get; set; }

        /// <summary>
        /// **参数解释：** 是否启用Tag推送事件。
        /// </summary>
        [JsonProperty("tag_push_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TagPushEvents { get; set; }

        /// <summary>
        /// **参数解释：** 是否启用合并请求事件。
        /// </summary>
        [JsonProperty("merge_requests_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MergeRequestsEvents { get; set; }

        /// <summary>
        /// **参数解释：** 是否启用评论事件。
        /// </summary>
        [JsonProperty("note_events", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoteEvents { get; set; }

        /// <summary>
        /// **参数解释：** token值，作为返回值时会使用掩码代替实际值。 **取值范围：** 字符串长度不少于0，不超过2000。
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// **参数解释：** token类型，默认为X-Repo-Token。 **取值范围：** 字符串长度不少于0，不超过200。
        /// </summary>
        [JsonProperty("token_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenType { get; set; }

        /// <summary>
        /// **参数解释：** 名称。 **取值范围：** 字符串长度不少于0，不超过200。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 描述。 **取值范围：** 字符串长度不少于0，不超过200。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** Webhook id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **参数解释：** yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSXXX
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。 **参数解释：** yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSXXX
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddProjectWebhookResponse {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  pushEvents: ").Append(PushEvents).Append("\n");
            sb.Append("  pushEventsBranchRegexFilter: ").Append(PushEventsBranchRegexFilter).Append("\n");
            sb.Append("  tagPushEvents: ").Append(TagPushEvents).Append("\n");
            sb.Append("  mergeRequestsEvents: ").Append(MergeRequestsEvents).Append("\n");
            sb.Append("  noteEvents: ").Append(NoteEvents).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  tokenType: ").Append(TokenType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddProjectWebhookResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddProjectWebhookResponse input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.PushEvents != input.PushEvents || (this.PushEvents != null && !this.PushEvents.Equals(input.PushEvents))) return false;
            if (this.PushEventsBranchRegexFilter != input.PushEventsBranchRegexFilter || (this.PushEventsBranchRegexFilter != null && !this.PushEventsBranchRegexFilter.Equals(input.PushEventsBranchRegexFilter))) return false;
            if (this.TagPushEvents != input.TagPushEvents || (this.TagPushEvents != null && !this.TagPushEvents.Equals(input.TagPushEvents))) return false;
            if (this.MergeRequestsEvents != input.MergeRequestsEvents || (this.MergeRequestsEvents != null && !this.MergeRequestsEvents.Equals(input.MergeRequestsEvents))) return false;
            if (this.NoteEvents != input.NoteEvents || (this.NoteEvents != null && !this.NoteEvents.Equals(input.NoteEvents))) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
            if (this.TokenType != input.TokenType || (this.TokenType != null && !this.TokenType.Equals(input.TokenType))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.PushEvents != null) hashCode = hashCode * 59 + this.PushEvents.GetHashCode();
                if (this.PushEventsBranchRegexFilter != null) hashCode = hashCode * 59 + this.PushEventsBranchRegexFilter.GetHashCode();
                if (this.TagPushEvents != null) hashCode = hashCode * 59 + this.TagPushEvents.GetHashCode();
                if (this.MergeRequestsEvents != null) hashCode = hashCode * 59 + this.MergeRequestsEvents.GetHashCode();
                if (this.NoteEvents != null) hashCode = hashCode * 59 + this.NoteEvents.GetHashCode();
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.TokenType != null) hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
