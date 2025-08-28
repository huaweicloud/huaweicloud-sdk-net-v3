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
    /// 修改文档分段信息请求。
    /// </summary>
    public class UpdateDocumentSegmentReq 
    {

        /// <summary>
        /// 文档ID。
        /// </summary>
        [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentId { get; set; }

        /// <summary>
        /// 文档分段文本ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 分段序号
        /// </summary>
        [JsonProperty("text_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? TextIndex { get; set; }

        /// <summary>
        /// 文档分段文本。
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDocumentSegmentReq {\n");
            sb.Append("  documentId: ").Append(DocumentId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  textIndex: ").Append(TextIndex).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDocumentSegmentReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDocumentSegmentReq input)
        {
            if (input == null) return false;
            if (this.DocumentId != input.DocumentId || (this.DocumentId != null && !this.DocumentId.Equals(input.DocumentId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TextIndex != input.TextIndex || (this.TextIndex != null && !this.TextIndex.Equals(input.TextIndex))) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;

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
                if (this.DocumentId != null) hashCode = hashCode * 59 + this.DocumentId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TextIndex != null) hashCode = hashCode * 59 + this.TextIndex.GetHashCode();
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                return hashCode;
            }
        }
    }
}
