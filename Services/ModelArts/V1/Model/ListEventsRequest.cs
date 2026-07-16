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
    /// Request Object
    /// </summary>
    public class ListEventsRequest 
    {

        /// <summary>
        /// **参数解释**：事件所属资源类型。可选值为pools，表示资源池。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("resource", IsQuery = true)]
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// **参数解释**：事件所属资源名称。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：单页查询最大数量，该值为空或者0时默认返回500条记录，单页最大允许查询500条记录。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**：分页查询的上一页标记，内容为UUID字符串，查询第一页时为空。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("continue", IsQuery = true)]
        [JsonProperty("continue", NullValueHandling = NullValueHandling.Ignore)]
        public string Continue { get; set; }

        /// <summary>
        /// **参数解释**：事件开始时间戳。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("since", IsQuery = true)]
        [JsonProperty("since", NullValueHandling = NullValueHandling.Ignore)]
        public int? Since { get; set; }

        /// <summary>
        /// **参数解释**：事件结束时间戳。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("until", IsQuery = true)]
        [JsonProperty("until", NullValueHandling = NullValueHandling.Ignore)]
        public int? Until { get; set; }

        /// <summary>
        /// **参数解释**：事件类型。 **约束限制**：不涉及。 **取值范围**：可选值如下： - Normal：正常 - Warning：异常 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEventsRequest {\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  Continue: ").Append(Continue).Append("\n");
            sb.Append("  since: ").Append(Since).Append("\n");
            sb.Append("  until: ").Append(Until).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEventsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEventsRequest input)
        {
            if (input == null) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Continue != input.Continue || (this.Continue != null && !this.Continue.Equals(input.Continue))) return false;
            if (this.Since != input.Since || (this.Since != null && !this.Since.Equals(input.Since))) return false;
            if (this.Until != input.Until || (this.Until != null && !this.Until.Equals(input.Until))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Continue != null) hashCode = hashCode * 59 + this.Continue.GetHashCode();
                if (this.Since != null) hashCode = hashCode * 59 + this.Since.GetHashCode();
                if (this.Until != null) hashCode = hashCode * 59 + this.Until.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
