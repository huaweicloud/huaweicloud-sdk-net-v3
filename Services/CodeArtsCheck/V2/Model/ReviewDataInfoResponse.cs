using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// **参数解释：** 任务门禁配置列表。
    /// </summary>
    public class ReviewDataInfoResponse 
    {

        /// <summary>
        /// **参数解释：** 运算逻辑。 **取值范围：** 取值为\&quot;≤\&quot;。
        /// </summary>
        [JsonProperty("compareType", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareType { get; set; }

        /// <summary>
        /// **参数解释：** 门禁开关。 **取值范围：** - 0：关闭门禁。 - 1：打开门禁。
        /// </summary>
        [JsonProperty("isCheck", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsCheck { get; set; }

        /// <summary>
        /// **参数解释：** 门禁项。 **取值范围：** 致命问题数。 严重问题数。 一般问题数。 提示问题数。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 门禁阈值。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public int? Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReviewDataInfoResponse {\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  isCheck: ").Append(IsCheck).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReviewDataInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReviewDataInfoResponse input)
        {
            if (input == null) return false;
            if (this.CompareType != input.CompareType || (this.CompareType != null && !this.CompareType.Equals(input.CompareType))) return false;
            if (this.IsCheck != input.IsCheck || (this.IsCheck != null && !this.IsCheck.Equals(input.IsCheck))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.CompareType != null) hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                if (this.IsCheck != null) hashCode = hashCode * 59 + this.IsCheck.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
