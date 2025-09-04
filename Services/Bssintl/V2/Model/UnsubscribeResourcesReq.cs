using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UnsubscribeResourcesReq 
    {

        /// <summary>
        /// 资源ID列表。 最大支持1次性输入10个资源ID，只能输入主资源ID。 哪些资源是主资源请根据“查询客户包年/包月资源列表”接口响应参数中的“is_main_resource”来标识。
        /// </summary>
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// 退订类型，取值如下： 1：退订资源及其已续费周期。2：只退订资源已续费周期，不退订资源。
        /// </summary>
        [JsonProperty("unsubscribe_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnsubscribeType { get; set; }

        /// <summary>
        /// 退订理由分类，取值如下： 1：产品不好用2：产品功能无法满足需求3：不会操作/操作过于复杂4：对服务不满意5：其他
        /// </summary>
        [JsonProperty("unsubscribe_reason_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnsubscribeReasonType { get; set; }

        /// <summary>
        /// 退订原因，一般由客户输入。
        /// </summary>
        [JsonProperty("unsubscribe_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string UnsubscribeReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnsubscribeResourcesReq {\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("  unsubscribeType: ").Append(UnsubscribeType).Append("\n");
            sb.Append("  unsubscribeReasonType: ").Append(UnsubscribeReasonType).Append("\n");
            sb.Append("  unsubscribeReason: ").Append(UnsubscribeReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnsubscribeResourcesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnsubscribeResourcesReq input)
        {
            if (input == null) return false;
            if (this.ResourceIds != input.ResourceIds || (this.ResourceIds != null && input.ResourceIds != null && !this.ResourceIds.SequenceEqual(input.ResourceIds))) return false;
            if (this.UnsubscribeType != input.UnsubscribeType || (this.UnsubscribeType != null && !this.UnsubscribeType.Equals(input.UnsubscribeType))) return false;
            if (this.UnsubscribeReasonType != input.UnsubscribeReasonType || (this.UnsubscribeReasonType != null && !this.UnsubscribeReasonType.Equals(input.UnsubscribeReasonType))) return false;
            if (this.UnsubscribeReason != input.UnsubscribeReason || (this.UnsubscribeReason != null && !this.UnsubscribeReason.Equals(input.UnsubscribeReason))) return false;

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
                if (this.ResourceIds != null) hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                if (this.UnsubscribeType != null) hashCode = hashCode * 59 + this.UnsubscribeType.GetHashCode();
                if (this.UnsubscribeReasonType != null) hashCode = hashCode * 59 + this.UnsubscribeReasonType.GetHashCode();
                if (this.UnsubscribeReason != null) hashCode = hashCode * 59 + this.UnsubscribeReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
