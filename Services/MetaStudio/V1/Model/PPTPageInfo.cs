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
    /// PPT图片元数据。
    /// </summary>
    public class PPTPageInfo 
    {

        /// <summary>
        /// **参数解释**： 页面编号。 **约束限制**： 不涉及
        /// </summary>
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// **参数解释**： 页面对应图片文件ID。 **约束限制**： 不涉及 **取值范围**： 字符长度1-64位 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// **参数解释**： 页面对应图片文件ID **约束限制**： 不涉及 **取值范围**： 字符长度0-2048位 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("page_content", NullValueHandling = NullValueHandling.Ignore)]
        public string PageContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PPTPageInfo {\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("  pageContent: ").Append(PageContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PPTPageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PPTPageInfo input)
        {
            if (input == null) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.FileId != input.FileId || (this.FileId != null && !this.FileId.Equals(input.FileId))) return false;
            if (this.PageContent != input.PageContent || (this.PageContent != null && !this.PageContent.Equals(input.PageContent))) return false;

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
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.FileId != null) hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.PageContent != null) hashCode = hashCode * 59 + this.PageContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
