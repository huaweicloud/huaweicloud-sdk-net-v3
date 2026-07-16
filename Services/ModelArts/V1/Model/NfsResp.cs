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
    /// nfs方式的挂载卷。
    /// </summary>
    public class NfsResp 
    {

        /// <summary>
        /// **参数解释**：nfs服务端路径，如：“10.10.10.10:/example/path”。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("nfs_server_path", NullValueHandling = NullValueHandling.Ignore)]
        public string NfsServerPath { get; set; }

        /// <summary>
        /// **参数解释**：挂载到训练容器中的路径，如：“/example/path”。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("local_path", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalPath { get; set; }

        /// <summary>
        /// **参数解释**：nfs挂载卷在容器中是否只读。 **取值范围**： - true：只读 - false：非只读
        /// </summary>
        [JsonProperty("read_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NfsResp {\n");
            sb.Append("  nfsServerPath: ").Append(NfsServerPath).Append("\n");
            sb.Append("  localPath: ").Append(LocalPath).Append("\n");
            sb.Append("  readOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NfsResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NfsResp input)
        {
            if (input == null) return false;
            if (this.NfsServerPath != input.NfsServerPath || (this.NfsServerPath != null && !this.NfsServerPath.Equals(input.NfsServerPath))) return false;
            if (this.LocalPath != input.LocalPath || (this.LocalPath != null && !this.LocalPath.Equals(input.LocalPath))) return false;
            if (this.ReadOnly != input.ReadOnly || (this.ReadOnly != null && !this.ReadOnly.Equals(input.ReadOnly))) return false;

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
                if (this.NfsServerPath != null) hashCode = hashCode * 59 + this.NfsServerPath.GetHashCode();
                if (this.LocalPath != null) hashCode = hashCode * 59 + this.LocalPath.GetHashCode();
                if (this.ReadOnly != null) hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                return hashCode;
            }
        }
    }
}
