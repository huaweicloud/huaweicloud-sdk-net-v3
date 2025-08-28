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
    /// 开始分段任务请求信息。
    /// </summary>
    public class StartDocumentSegmentTaskReq 
    {

        /// <summary>
        /// 文档ID。
        /// </summary>
        [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartDocumentSegmentTaskReq {\n");
            sb.Append("  documentId: ").Append(DocumentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartDocumentSegmentTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartDocumentSegmentTaskReq input)
        {
            if (input == null) return false;
            if (this.DocumentId != input.DocumentId || (this.DocumentId != null && !this.DocumentId.Equals(input.DocumentId))) return false;

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
                return hashCode;
            }
        }
    }
}
