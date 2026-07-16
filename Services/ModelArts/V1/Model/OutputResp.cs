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
    public class OutputResp 
    {

        /// <summary>
        /// **参数解释**：数据输出通道名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：数据输出通道描述信息。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：数据输出通道映射的容器本地路径。 **取值范围**：不涉及。
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
        public RemoteResp Remote { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputResp {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  localDir: ").Append(LocalDir).Append("\n");
            sb.Append("  accessMethod: ").Append(AccessMethod).Append("\n");
            sb.Append("  remote: ").Append(Remote).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutputResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutputResp input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.LocalDir != input.LocalDir || (this.LocalDir != null && !this.LocalDir.Equals(input.LocalDir))) return false;
            if (this.AccessMethod != input.AccessMethod || (this.AccessMethod != null && !this.AccessMethod.Equals(input.AccessMethod))) return false;
            if (this.Remote != input.Remote || (this.Remote != null && !this.Remote.Equals(input.Remote))) return false;

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
                return hashCode;
            }
        }
    }
}
