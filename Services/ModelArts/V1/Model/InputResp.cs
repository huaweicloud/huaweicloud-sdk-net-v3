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
    /// 
    /// </summary>
    public class InputResp 
    {

        /// <summary>
        /// **参数解释**：数据输入通道名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：数据输入通道描述信息。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：数据输入通道映射的容器本地路径。例如，“/home/ma-user/modelarts/inputs/data_url_0”。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("local_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalDir { get; set; }

        /// <summary>
        /// **参数解释**：数据输入通道路径（local_dir）的下发方式。 **取值范围**： - parameter：超参形式 - env：环境变量形式
        /// </summary>
        [JsonProperty("access_method", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remote", NullValueHandling = NullValueHandling.Ignore)]
        public InputDataInfoResp Remote { get; set; }

        /// <summary>
        /// **参数解释**：数据输入约束。
        /// </summary>
        [JsonProperty("remote_constraint", NullValueHandling = NullValueHandling.Ignore)]
        public List<InputRespRemoteConstraint> RemoteConstraint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputResp {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  localDir: ").Append(LocalDir).Append("\n");
            sb.Append("  accessMethod: ").Append(AccessMethod).Append("\n");
            sb.Append("  remote: ").Append(Remote).Append("\n");
            sb.Append("  remoteConstraint: ").Append(RemoteConstraint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InputResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InputResp input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.LocalDir != input.LocalDir || (this.LocalDir != null && !this.LocalDir.Equals(input.LocalDir))) return false;
            if (this.AccessMethod != input.AccessMethod || (this.AccessMethod != null && !this.AccessMethod.Equals(input.AccessMethod))) return false;
            if (this.Remote != input.Remote || (this.Remote != null && !this.Remote.Equals(input.Remote))) return false;
            if (this.RemoteConstraint != input.RemoteConstraint || (this.RemoteConstraint != null && input.RemoteConstraint != null && !this.RemoteConstraint.SequenceEqual(input.RemoteConstraint))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LocalDir != null) hashCode = hashCode * 59 + this.LocalDir.GetHashCode();
                if (this.AccessMethod != null) hashCode = hashCode * 59 + this.AccessMethod.GetHashCode();
                if (this.Remote != null) hashCode = hashCode * 59 + this.Remote.GetHashCode();
                if (this.RemoteConstraint != null) hashCode = hashCode * 59 + this.RemoteConstraint.GetHashCode();
                return hashCode;
            }
        }
    }
}
