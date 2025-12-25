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
    public class StorageInfoDOV5 
    {

        /// <summary>
        /// **参数解释**: 使用空间（字节）。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("used_space_length", NullValueHandling = NullValueHandling.Ignore)]
        public long? UsedSpaceLength { get; set; }

        /// <summary>
        /// **参数解释**: 使用空间（带单位）。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("used_space", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedSpace { get; set; }

        /// <summary>
        /// **参数解释**: 文件数量。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("files_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? FilesCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageInfoDOV5 {\n");
            sb.Append("  usedSpaceLength: ").Append(UsedSpaceLength).Append("\n");
            sb.Append("  usedSpace: ").Append(UsedSpace).Append("\n");
            sb.Append("  filesCount: ").Append(FilesCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageInfoDOV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StorageInfoDOV5 input)
        {
            if (input == null) return false;
            if (this.UsedSpaceLength != input.UsedSpaceLength || (this.UsedSpaceLength != null && !this.UsedSpaceLength.Equals(input.UsedSpaceLength))) return false;
            if (this.UsedSpace != input.UsedSpace || (this.UsedSpace != null && !this.UsedSpace.Equals(input.UsedSpace))) return false;
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
                if (this.UsedSpaceLength != null) hashCode = hashCode * 59 + this.UsedSpaceLength.GetHashCode();
                if (this.UsedSpace != null) hashCode = hashCode * 59 + this.UsedSpace.GetHashCode();
                if (this.FilesCount != null) hashCode = hashCode * 59 + this.FilesCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
