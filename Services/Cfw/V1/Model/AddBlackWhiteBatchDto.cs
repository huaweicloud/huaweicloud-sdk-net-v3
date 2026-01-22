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
    public class AddBlackWhiteBatchDto 
    {

        /// <summary>
        /// **参数解释**： 黑白名单信息列表 **约束限制**： 不涉及  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("list_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<BlackWhiteInfo> ListItems { get; set; }

        /// <summary>
        /// **参数解释**： 黑白名单列表类型 **约束限制**： 不涉及 **取值范围**： 4：黑名单 5：白名单 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("list_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ListType { get; set; }

        /// <summary>
        /// **参数解释**： 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用查询防火墙实例接口获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得，type为0时，object_id为互联网边界防护对象ID，type为1时，object_id为VPC边界防护对象ID，type可通过data.records.protect_objects.type（.表示各对象之间层级的区分）获得 **约束限制**： 不涉及  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddBlackWhiteBatchDto {\n");
            sb.Append("  listItems: ").Append(ListItems).Append("\n");
            sb.Append("  listType: ").Append(ListType).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddBlackWhiteBatchDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddBlackWhiteBatchDto input)
        {
            if (input == null) return false;
            if (this.ListItems != input.ListItems || (this.ListItems != null && input.ListItems != null && !this.ListItems.SequenceEqual(input.ListItems))) return false;
            if (this.ListType != input.ListType || (this.ListType != null && !this.ListType.Equals(input.ListType))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;

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
                if (this.ListItems != null) hashCode = hashCode * 59 + this.ListItems.GetHashCode();
                if (this.ListType != null) hashCode = hashCode * 59 + this.ListType.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
