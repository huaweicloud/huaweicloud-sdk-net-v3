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
    /// 角色业务配置请求。
    /// </summary>
    public class RoleBusinessReq 
    {

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
        public List<RoleKnowledgeLibraryReq> KnowledgeLibraryList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleBusinessReq {\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  prompt: ").Append(Prompt).Append("\n");
            sb.Append("  knowledgeLibraryList: ").Append(KnowledgeLibraryList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoleBusinessReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoleBusinessReq input)
        {
            if (input == null) return false;
            if (this.Language != input.Language) return false;
            if (this.Prompt != input.Prompt || (this.Prompt != null && !this.Prompt.Equals(input.Prompt))) return false;
            if (this.KnowledgeLibraryList != input.KnowledgeLibraryList || (this.KnowledgeLibraryList != null && input.KnowledgeLibraryList != null && !this.KnowledgeLibraryList.SequenceEqual(input.KnowledgeLibraryList))) return false;

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
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Prompt != null) hashCode = hashCode * 59 + this.Prompt.GetHashCode();
                if (this.KnowledgeLibraryList != null) hashCode = hashCode * 59 + this.KnowledgeLibraryList.GetHashCode();
                return hashCode;
            }
        }
    }
}
