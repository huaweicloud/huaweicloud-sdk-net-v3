using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 文件夹信息。
    /// </summary>
    public class FolderInfo 
    {

        /// <summary>
        /// 文件夹名称。
        /// </summary>
        [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }

        /// <summary>
        /// 文件inode。
        /// </summary>
        [JsonProperty("inode_no", NullValueHandling = NullValueHandling.Ignore)]
        public long? InodeNo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderInfo {\n");
            sb.Append("  prefix: ").Append(Prefix).Append("\n");
            sb.Append("  inodeNo: ").Append(InodeNo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FolderInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FolderInfo input)
        {
            if (input == null) return false;
            if (this.Prefix != input.Prefix || (this.Prefix != null && !this.Prefix.Equals(input.Prefix))) return false;
            if (this.InodeNo != input.InodeNo || (this.InodeNo != null && !this.InodeNo.Equals(input.InodeNo))) return false;

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
                if (this.Prefix != null) hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.InodeNo != null) hashCode = hashCode * 59 + this.InodeNo.GetHashCode();
                return hashCode;
            }
        }
    }
}
