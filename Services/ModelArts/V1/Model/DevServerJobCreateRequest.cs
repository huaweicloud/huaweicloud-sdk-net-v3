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
    public class DevServerJobCreateRequest 
    {

        /// <summary>
        /// **参数解释**：任务名称。 **约束限制**：^[-_.a-zA-Z0-9]{1,64}$。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：任务描述。 **约束限制**：^[-_.a-zA-Z0-9]{1,64}$。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：DevServer实例id列表。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("server_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServerIds { get; set; }

        /// <summary>
        /// **参数解释**：任务模板类型。 **约束限制**：^[-_.a-zA-Z0-9]{1,64}$。 **取值范围**：-COMMON  -SERVICE_DEPLOY 等。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：任务失败后是否重启。 **约束限制**：不涉及。 **取值范围**：- true   -false。 **默认取值**：false。
        /// </summary>
        [JsonProperty("is_reboot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReboot { get; set; }

        /// <summary>
        /// **参数解释**：任务实例列表。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<DevServerJobItem> Items { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevServerJobCreateRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  serverIds: ").Append(ServerIds).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  isReboot: ").Append(IsReboot).Append("\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DevServerJobCreateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DevServerJobCreateRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ServerIds != input.ServerIds || (this.ServerIds != null && input.ServerIds != null && !this.ServerIds.SequenceEqual(input.ServerIds))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.IsReboot != input.IsReboot || (this.IsReboot != null && !this.IsReboot.Equals(input.IsReboot))) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;

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
                if (this.ServerIds != null) hashCode = hashCode * 59 + this.ServerIds.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsReboot != null) hashCode = hashCode * 59 + this.IsReboot.GetHashCode();
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }
    }
}
