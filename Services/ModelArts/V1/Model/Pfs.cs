using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练作业obsfs挂载卷信息。
    /// </summary>
    public class Pfs 
    {

        /// <summary>
        /// obsfs的地址。如：“/test-bucket/path”。
        /// </summary>
        [JsonProperty("pfs_path", NullValueHandling = NullValueHandling.Ignore)]
        public string PfsPath { get; set; }

        /// <summary>
        /// 挂载到训练容器中的路径，如：“/example/path”。
        /// </summary>
        [JsonProperty("local_path", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pfs {\n");
            sb.Append("  pfsPath: ").Append(PfsPath).Append("\n");
            sb.Append("  localPath: ").Append(LocalPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Pfs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Pfs input)
        {
            if (input == null) return false;
            if (this.PfsPath != input.PfsPath || (this.PfsPath != null && !this.PfsPath.Equals(input.PfsPath))) return false;
            if (this.LocalPath != input.LocalPath || (this.LocalPath != null && !this.LocalPath.Equals(input.LocalPath))) return false;

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
                if (this.PfsPath != null) hashCode = hashCode * 59 + this.PfsPath.GetHashCode();
                if (this.LocalPath != null) hashCode = hashCode * 59 + this.LocalPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
