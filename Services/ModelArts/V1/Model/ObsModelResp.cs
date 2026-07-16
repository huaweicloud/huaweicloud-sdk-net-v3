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
    /// **参数解释**：自定义训练作业产物obs输出信息。
    /// </summary>
    public class ObsModelResp 
    {

        /// <summary>
        /// **参数解释**：自定义训练作业产物保存的OBS地址，如：“obs://example/path”。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("obs_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsPath { get; set; }

        /// <summary>
        /// **参数解释**：自定义训练作业产物保存的宿主机的路径，如：“/example/path”。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("local_path", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsModelResp {\n");
            sb.Append("  obsPath: ").Append(ObsPath).Append("\n");
            sb.Append("  localPath: ").Append(LocalPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsModelResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsModelResp input)
        {
            if (input == null) return false;
            if (this.ObsPath != input.ObsPath || (this.ObsPath != null && !this.ObsPath.Equals(input.ObsPath))) return false;
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
                if (this.ObsPath != null) hashCode = hashCode * 59 + this.ObsPath.GetHashCode();
                if (this.LocalPath != null) hashCode = hashCode * 59 + this.LocalPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
