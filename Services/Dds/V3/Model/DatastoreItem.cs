using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 数据库信息。
    /// </summary>
    public class DatastoreItem 
    {

        /// <summary>
        /// 数据库引擎。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 数据库版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 是否有补丁版本的数据库支持升级，返回true时可以通过升级补丁接口进行数据库升级，否则不允许升级补丁。
        /// </summary>
        [JsonProperty("patch_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PatchAvailable { get; set; }

        /// <summary>
        /// 数据库的完整版本号。
        /// </summary>
        [JsonProperty("whole_version", NullValueHandling = NullValueHandling.Ignore)]
        public string WholeVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatastoreItem {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  patchAvailable: ").Append(PatchAvailable).Append("\n");
            sb.Append("  wholeVersion: ").Append(WholeVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatastoreItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatastoreItem input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.PatchAvailable != input.PatchAvailable || (this.PatchAvailable != null && !this.PatchAvailable.Equals(input.PatchAvailable))) return false;
            if (this.WholeVersion != input.WholeVersion || (this.WholeVersion != null && !this.WholeVersion.Equals(input.WholeVersion))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.PatchAvailable != null) hashCode = hashCode * 59 + this.PatchAvailable.GetHashCode();
                if (this.WholeVersion != null) hashCode = hashCode * 59 + this.WholeVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
