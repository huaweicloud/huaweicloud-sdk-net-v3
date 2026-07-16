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
    /// 作业流程阶段信息列表的子阶段元信息。
    /// </summary>
    public class SubStage 
    {

        /// <summary>
        /// **参数解释**：子阶段名称。  **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：子阶段英文描述信息。  **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("en_message", NullValueHandling = NullValueHandling.Ignore)]
        public string EnMessage { get; set; }

        /// <summary>
        /// **参数解释**：子阶段中文描述信息。  **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("zh_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ZhMessage { get; set; }

        /// <summary>
        /// **参数解释**：子阶段开始时间。  **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubStage {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  enMessage: ").Append(EnMessage).Append("\n");
            sb.Append("  zhMessage: ").Append(ZhMessage).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubStage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubStage input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EnMessage != input.EnMessage || (this.EnMessage != null && !this.EnMessage.Equals(input.EnMessage))) return false;
            if (this.ZhMessage != input.ZhMessage || (this.ZhMessage != null && !this.ZhMessage.Equals(input.ZhMessage))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.EnMessage != null) hashCode = hashCode * 59 + this.EnMessage.GetHashCode();
                if (this.ZhMessage != null) hashCode = hashCode * 59 + this.ZhMessage.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
