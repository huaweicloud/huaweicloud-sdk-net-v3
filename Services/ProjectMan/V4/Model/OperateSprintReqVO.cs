using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// **参数解释**： 批量基线/取消基线请求体，包含需要操作的计划ID列表和基线属性信息。 **约束限制**： 不涉及。
    /// </summary>
    public class OperateSprintReqVO 
    {

        /// <summary>
        /// **参数解释**： 发布/迭代计划ID列表，通过[发布/迭代计划列表查询](ListPlan.xml)接口获取，响应消息体中的**id**字段的值就是发布/迭代ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attribute", NullValueHandling = NullValueHandling.Ignore)]
        public BaseLineVO Attribute { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateSprintReqVO {\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  attribute: ").Append(Attribute).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateSprintReqVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateSprintReqVO input)
        {
            if (input == null) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;
            if (this.Attribute != input.Attribute || (this.Attribute != null && !this.Attribute.Equals(input.Attribute))) return false;

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
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.Attribute != null) hashCode = hashCode * 59 + this.Attribute.GetHashCode();
                return hashCode;
            }
        }
    }
}
