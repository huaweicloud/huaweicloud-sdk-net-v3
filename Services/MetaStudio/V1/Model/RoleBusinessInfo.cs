using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 角色业务配置基本信息。
    /// </summary>
    public class RoleBusinessInfo 
    {

        /// <summary>
        /// 角色业务配置ID。
        /// </summary>
        [JsonProperty("role_business_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleBusinessId { get; set; }

        /// <summary>
        /// 角色ID。
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 提示词。
        /// </summary>
        [JsonProperty("prompt", NullValueHandling = NullValueHandling.Ignore)]
        public string Prompt { get; set; }

        /// <summary>
        /// 知识库列表
        /// </summary>
        [JsonProperty("knowledge_library_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RoleKnowledgeLibraryInfo> KnowledgeLibraryList { get; set; }

        /// <summary>
        /// 创建时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleBusinessInfo {\n");
            sb.Append("  roleBusinessId: ").Append(RoleBusinessId).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  prompt: ").Append(Prompt).Append("\n");
            sb.Append("  knowledgeLibraryList: ").Append(KnowledgeLibraryList).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoleBusinessInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoleBusinessInfo input)
        {
            if (input == null) return false;
            if (this.RoleBusinessId != input.RoleBusinessId || (this.RoleBusinessId != null && !this.RoleBusinessId.Equals(input.RoleBusinessId))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.Language != input.Language) return false;
            if (this.Prompt != input.Prompt || (this.Prompt != null && !this.Prompt.Equals(input.Prompt))) return false;
            if (this.KnowledgeLibraryList != input.KnowledgeLibraryList || (this.KnowledgeLibraryList != null && input.KnowledgeLibraryList != null && !this.KnowledgeLibraryList.SequenceEqual(input.KnowledgeLibraryList))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.RoleBusinessId != null) hashCode = hashCode * 59 + this.RoleBusinessId.GetHashCode();
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Prompt != null) hashCode = hashCode * 59 + this.Prompt.GetHashCode();
                if (this.KnowledgeLibraryList != null) hashCode = hashCode * 59 + this.KnowledgeLibraryList.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
