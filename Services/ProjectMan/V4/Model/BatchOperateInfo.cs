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
    /// **参数解释**： 批量操作结果详情，包含操作对象ID和操作人ID。
    /// </summary>
    public class BatchOperateInfo 
    {

        /// <summary>
        /// **参数解释**： 发布/迭代计划ID。 **取值范围**： 长度为18~19个字符的数字字符串。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 最近更新人ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchOperateInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchOperateInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchOperateInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
