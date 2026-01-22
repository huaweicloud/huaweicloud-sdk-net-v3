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
    public class BatchCreateIpsWhiteListDto 
    {

        /// <summary>
        /// **参数解释**：  添加的IPS白名单列表 **约束限制**：  不涉及  **取值范围**： 不涉及  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("ips_white_list_dto_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpsWhiteListDto> IpsWhiteListDtoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateIpsWhiteListDto {\n");
            sb.Append("  ipsWhiteListDtoList: ").Append(IpsWhiteListDtoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateIpsWhiteListDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateIpsWhiteListDto input)
        {
            if (input == null) return false;
            if (this.IpsWhiteListDtoList != input.IpsWhiteListDtoList || (this.IpsWhiteListDtoList != null && input.IpsWhiteListDtoList != null && !this.IpsWhiteListDtoList.SequenceEqual(input.IpsWhiteListDtoList))) return false;

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
                if (this.IpsWhiteListDtoList != null) hashCode = hashCode * 59 + this.IpsWhiteListDtoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
