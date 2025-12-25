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
    public class ShowFileTreeResultChildren 
    {

        /// <summary>
        /// **参数解释**: 文件或文件夹名称。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**: 访问地址。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// **参数解释**: 路径。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释**: 更新时间，时间格式：yyyy-MM-dd HH:mm:ss。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
        public string Modified { get; set; }

        /// <summary>
        /// **参数解释**: 是否为文件夹。 **取值范围**: true：文件夹。 false：文件。 
        /// </summary>
        [JsonProperty("folder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Folder { get; set; }

        /// <summary>
        /// **参数解释**: 修改人。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// **参数解释**: 是否存在下一层。 **取值范围**: true：是。 false：否。 
        /// </summary>
        [JsonProperty("has_child", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasChild { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFileTreeResultChildren {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  modified: ").Append(Modified).Append("\n");
            sb.Append("  folder: ").Append(Folder).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  hasChild: ").Append(HasChild).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFileTreeResultChildren);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFileTreeResultChildren input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Modified != input.Modified || (this.Modified != null && !this.Modified.Equals(input.Modified))) return false;
            if (this.Folder != input.Folder || (this.Folder != null && !this.Folder.Equals(input.Folder))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.HasChild != input.HasChild || (this.HasChild != null && !this.HasChild.Equals(input.HasChild))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Modified != null) hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Folder != null) hashCode = hashCode * 59 + this.Folder.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.HasChild != null) hashCode = hashCode * 59 + this.HasChild.GetHashCode();
                return hashCode;
            }
        }
    }
}
