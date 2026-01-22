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
    public class BatchDeleteAddressSetsDto 
    {

        /// <summary>
        /// **参数解释**： 防护对象ID，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得，注意type为0的为互联网边界防护对象id，type为1的为VPC边界防护对象id。 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// **参数解释**： 地址组ID，可以通过调用[查询地址组列表接口]获得，通过返回值中的data.records.set_id获得 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("set_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SetIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteAddressSetsDto {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  setIds: ").Append(SetIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteAddressSetsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteAddressSetsDto input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.SetIds != input.SetIds || (this.SetIds != null && input.SetIds != null && !this.SetIds.SequenceEqual(input.SetIds))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.SetIds != null) hashCode = hashCode * 59 + this.SetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
