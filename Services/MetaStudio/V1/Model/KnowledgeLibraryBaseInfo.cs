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
    /// 知识库基础信息。
    /// </summary>
    public class KnowledgeLibraryBaseInfo 
    {

        /// <summary>
        /// 知识库ID。
        /// </summary>
        [JsonProperty("knowledge_library_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KnowledgeLibraryId { get; set; }

        /// <summary>
        /// 知识库名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeLibraryBaseInfo {\n");
            sb.Append("  knowledgeLibraryId: ").Append(KnowledgeLibraryId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KnowledgeLibraryBaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KnowledgeLibraryBaseInfo input)
        {
            if (input == null) return false;
            if (this.KnowledgeLibraryId != input.KnowledgeLibraryId || (this.KnowledgeLibraryId != null && !this.KnowledgeLibraryId.Equals(input.KnowledgeLibraryId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;

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
                if (this.KnowledgeLibraryId != null) hashCode = hashCode * 59 + this.KnowledgeLibraryId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
