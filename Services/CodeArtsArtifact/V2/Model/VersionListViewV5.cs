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
    public class VersionListViewV5 
    {

        /// <summary>
        /// **参数解释**： 发布库版本的状态。 **取值范围**： - test：测试包。 - prod：发布包。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 发布库版本的名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("build_version", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildVersion { get; set; }

        /// <summary>
        /// **参数解释**： 版本下的文件个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("files_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FilesCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionListViewV5 {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  buildVersion: ").Append(BuildVersion).Append("\n");
            sb.Append("  filesCount: ").Append(FilesCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VersionListViewV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VersionListViewV5 input)
        {
            if (input == null) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.BuildVersion != input.BuildVersion || (this.BuildVersion != null && !this.BuildVersion.Equals(input.BuildVersion))) return false;
            if (this.FilesCount != input.FilesCount || (this.FilesCount != null && !this.FilesCount.Equals(input.FilesCount))) return false;

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
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.BuildVersion != null) hashCode = hashCode * 59 + this.BuildVersion.GetHashCode();
                if (this.FilesCount != null) hashCode = hashCode * 59 + this.FilesCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
