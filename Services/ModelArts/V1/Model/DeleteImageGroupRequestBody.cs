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
    /// 删除镜像组请求体，支持is_force字段删除关联swr镜像，默认为false
    /// </summary>
    public class DeleteImageGroupRequestBody 
    {

        /// <summary>
        /// 是否删除关联的swr镜像，默认为false  **参数解释**：是否删除关联的swr镜像。 **约束限制**：true或false。 **取值范围**：布尔类型。 **默认取值**：false。
        /// </summary>
        [JsonProperty("is_force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForce { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteImageGroupRequestBody {\n");
            sb.Append("  isForce: ").Append(IsForce).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteImageGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteImageGroupRequestBody input)
        {
            if (input == null) return false;
            if (this.IsForce != input.IsForce || (this.IsForce != null && !this.IsForce.Equals(input.IsForce))) return false;

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
                if (this.IsForce != null) hashCode = hashCode * 59 + this.IsForce.GetHashCode();
                return hashCode;
            }
        }
    }
}
