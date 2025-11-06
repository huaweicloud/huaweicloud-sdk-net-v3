using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BranchSimpleDto 
    {

        /// <summary>
        /// 分支名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否为默认分支
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        /// <summary>
        /// 用户是否为默认分支
        /// </summary>
        [JsonProperty("can_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// 是否为默认分支
        /// </summary>
        [JsonProperty("can_read", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanRead { get; set; }

        /// <summary>
        /// 是否为默认分支
        /// </summary>
        [JsonProperty("can_download", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDownload { get; set; }

        /// <summary>
        /// 是否为默认分支
        /// </summary>
        [JsonProperty("can_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanPush { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BranchSimpleDto {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canRead: ").Append(CanRead).Append("\n");
            sb.Append("  canDownload: ").Append(CanDownload).Append("\n");
            sb.Append("  canPush: ").Append(CanPush).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BranchSimpleDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BranchSimpleDto input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Default != input.Default || (this.Default != null && !this.Default.Equals(input.Default))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.CanRead != input.CanRead || (this.CanRead != null && !this.CanRead.Equals(input.CanRead))) return false;
            if (this.CanDownload != input.CanDownload || (this.CanDownload != null && !this.CanDownload.Equals(input.CanDownload))) return false;
            if (this.CanPush != input.CanPush || (this.CanPush != null && !this.CanPush.Equals(input.CanPush))) return false;

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
                if (this.Default != null) hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanRead != null) hashCode = hashCode * 59 + this.CanRead.GetHashCode();
                if (this.CanDownload != null) hashCode = hashCode * 59 + this.CanDownload.GetHashCode();
                if (this.CanPush != null) hashCode = hashCode * 59 + this.CanPush.GetHashCode();
                return hashCode;
            }
        }
    }
}
