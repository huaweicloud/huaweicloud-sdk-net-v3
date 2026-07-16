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
    public class Config 
    {

        /// <summary>
        /// **参数解释**：自定义脚本内容（base64编码）或脚本绝对路径。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("script", NullValueHandling = NullValueHandling.Ignore)]
        public string Script { get; set; }

        /// <summary>
        /// **参数解释**：脚本类型。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - COMMAND：script中需要指定脚本内容（base64编码）。 - SCRIPT：script中需要指定脚本路径。  **默认取值**：SCRIPT。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：自定义脚本执行方式，同步或异步执行。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - BLOCK：同步 - ASYNC：异步  **默认取值**：ASYNC
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Config {\n");
            sb.Append("  script: ").Append(Script).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Config);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Config input)
        {
            if (input == null) return false;
            if (this.Script != input.Script || (this.Script != null && !this.Script.Equals(input.Script))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;

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
                if (this.Script != null) hashCode = hashCode * 59 + this.Script.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
