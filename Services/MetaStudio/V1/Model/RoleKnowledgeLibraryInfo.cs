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
    /// 角色知识库基本信息。
    /// </summary>
    public class RoleKnowledgeLibraryInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("knowledge_type", NullValueHandling = NullValueHandling.Ignore)]
        public KnowledgeTypeEnum KnowledgeType { get; set; }
        /// <summary>
        /// 知识库列表
        /// </summary>
        [JsonProperty("knowledge_library_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<KnowledgeLibraryBaseInfo> KnowledgeLibraryInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleKnowledgeLibraryInfo {\n");
            sb.Append("  knowledgeType: ").Append(KnowledgeType).Append("\n");
            sb.Append("  knowledgeLibraryInfoList: ").Append(KnowledgeLibraryInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoleKnowledgeLibraryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoleKnowledgeLibraryInfo input)
        {
            if (input == null) return false;
            if (this.KnowledgeType != input.KnowledgeType) return false;
            if (this.KnowledgeLibraryInfoList != input.KnowledgeLibraryInfoList || (this.KnowledgeLibraryInfoList != null && input.KnowledgeLibraryInfoList != null && !this.KnowledgeLibraryInfoList.SequenceEqual(input.KnowledgeLibraryInfoList))) return false;

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
                if (this.KnowledgeLibraryInfoList != null) hashCode = hashCode * 59 + this.KnowledgeLibraryInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
