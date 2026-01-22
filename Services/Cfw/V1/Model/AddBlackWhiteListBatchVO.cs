using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddBlackWhiteListBatchVO 
    {

        /// <summary>
        /// **参数解释**： 黑白名单重复添加列表 **约束限制**： 不涉及  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("duplicated_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<BlackWhiteInfo> DuplicatedList { get; set; }

        /// <summary>
        /// **参数解释**： 黑白名单添加失败列表 **约束限制**： 不涉及  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("failed_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<BlackWhiteInfo> FailedList { get; set; }

        /// <summary>
        /// **参数解释**： 黑白名单添加成功列表 **约束限制**： 不涉及  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("success_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<BlackWhiteInfo> SuccessList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddBlackWhiteListBatchVO {\n");
            sb.Append("  duplicatedList: ").Append(DuplicatedList).Append("\n");
            sb.Append("  failedList: ").Append(FailedList).Append("\n");
            sb.Append("  successList: ").Append(SuccessList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddBlackWhiteListBatchVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddBlackWhiteListBatchVO input)
        {
            if (input == null) return false;
            if (this.DuplicatedList != input.DuplicatedList || (this.DuplicatedList != null && input.DuplicatedList != null && !this.DuplicatedList.SequenceEqual(input.DuplicatedList))) return false;
            if (this.FailedList != input.FailedList || (this.FailedList != null && input.FailedList != null && !this.FailedList.SequenceEqual(input.FailedList))) return false;
            if (this.SuccessList != input.SuccessList || (this.SuccessList != null && input.SuccessList != null && !this.SuccessList.SequenceEqual(input.SuccessList))) return false;

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
                if (this.DuplicatedList != null) hashCode = hashCode * 59 + this.DuplicatedList.GetHashCode();
                if (this.FailedList != null) hashCode = hashCode * 59 + this.FailedList.GetHashCode();
                if (this.SuccessList != null) hashCode = hashCode * 59 + this.SuccessList.GetHashCode();
                return hashCode;
            }
        }
    }
}
