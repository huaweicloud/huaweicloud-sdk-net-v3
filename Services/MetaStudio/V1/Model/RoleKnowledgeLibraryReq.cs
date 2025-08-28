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
    /// 角色知识库配置请求信息。
    /// </summary>
    public class RoleKnowledgeLibraryReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("knowledge_type", NullValueHandling = NullValueHandling.Ignore)]
        public KnowledgeTypeEnum KnowledgeType { get; set; }
        /// <summary>
        /// 知识库ID列表
        /// </summary>
        [JsonProperty("knowledge_library_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> KnowledgeLibraryIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleKnowledgeLibraryReq {\n");
            sb.Append("  knowledgeType: ").Append(KnowledgeType).Append("\n");
            sb.Append("  knowledgeLibraryIdList: ").Append(KnowledgeLibraryIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoleKnowledgeLibraryReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoleKnowledgeLibraryReq input)
        {
            if (input == null) return false;
            if (this.KnowledgeType != input.KnowledgeType) return false;
            if (this.KnowledgeLibraryIdList != input.KnowledgeLibraryIdList || (this.KnowledgeLibraryIdList != null && input.KnowledgeLibraryIdList != null && !this.KnowledgeLibraryIdList.SequenceEqual(input.KnowledgeLibraryIdList))) return false;

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
                hashCode = hashCode * 59 + this.KnowledgeType.GetHashCode();
                if (this.KnowledgeLibraryIdList != null) hashCode = hashCode * 59 + this.KnowledgeLibraryIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
