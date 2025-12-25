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
    public class DownloadFolderInfo 
    {

        /// <summary>
        /// **参数解释**： 文件总数。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("filesCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesCount { get; set; }

        /// <summary>
        /// **参数解释**： 占用空间。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("usedSpace", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedSpace { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadFolderInfo {\n");
            sb.Append("  filesCount: ").Append(FilesCount).Append("\n");
            sb.Append("  usedSpace: ").Append(UsedSpace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadFolderInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadFolderInfo input)
        {
            if (input == null) return false;
            if (this.FilesCount != input.FilesCount || (this.FilesCount != null && !this.FilesCount.Equals(input.FilesCount))) return false;
            if (this.UsedSpace != input.UsedSpace || (this.UsedSpace != null && !this.UsedSpace.Equals(input.UsedSpace))) return false;

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
                if (this.FilesCount != null) hashCode = hashCode * 59 + this.FilesCount.GetHashCode();
                if (this.UsedSpace != null) hashCode = hashCode * 59 + this.UsedSpace.GetHashCode();
                return hashCode;
            }
        }
    }
}
