using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowFileTreeResult 
    {

        /// <summary>
        /// **参数解释**: 上传权限。 **取值范围**: true：有权限。 false：无权限。 
        /// </summary>
        [JsonProperty("uploadAccess", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadAccess { get; set; }

        /// <summary>
        /// **参数解释**: 总数。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public string Total { get; set; }

        /// <summary>
        /// **参数解释**: 父路径。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// **参数解释**: 创建时间。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// **参数解释**: 子文件及文件夹信息。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowFileTreeResultChildren> Children { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFileTreeResult {\n");
            sb.Append("  uploadAccess: ").Append(UploadAccess).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFileTreeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFileTreeResult input)
        {
            if (input == null) return false;
            if (this.UploadAccess != input.UploadAccess || (this.UploadAccess != null && !this.UploadAccess.Equals(input.UploadAccess))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Children != input.Children || (this.Children != null && input.Children != null && !this.Children.SequenceEqual(input.Children))) return false;

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
                if (this.UploadAccess != null) hashCode = hashCode * 59 + this.UploadAccess.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Children != null) hashCode = hashCode * 59 + this.Children.GetHashCode();
                return hashCode;
            }
        }
    }
}
