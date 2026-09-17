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
    /// 
    /// </summary>
    public class ListCacheDatasRequest 
    {

        /// <summary>
        /// **参数解释**： 项目的32位uuid，项目唯一标识，通过[查询项目列表](ListProjectsV4.xml)接口获取，响应消息体中的**project_id**字段的值就是项目ID。 **约束限制**： 32位的数字和字母组成的字符串。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("projectUUId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUUId { get; set; }

        /// <summary>
        /// **参数解释：** 字段类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： backlog。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCacheDatasRequest {\n");
            sb.Append("  projectUUId: ").Append(ProjectUUId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCacheDatasRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCacheDatasRequest input)
        {
            if (input == null) return false;
            if (this.ProjectUUId != input.ProjectUUId || (this.ProjectUUId != null && !this.ProjectUUId.Equals(input.ProjectUUId))) return false;
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
                if (this.ProjectUUId != null) hashCode = hashCode * 59 + this.ProjectUUId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
