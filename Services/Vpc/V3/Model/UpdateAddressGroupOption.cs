using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateAddressGroupOption 
    {

        /// <summary>
        /// 功能说明：地址组名称 取值范围：0-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：IP地址组描述信息 取值范围：0-255个字符 约束：不能包含“&lt;”和“&gt;”。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：IP地址组可包含地址集 取值范围：可以是单个ip地址，ip地址范围，ip地址cidr 约束：当前一个地址组ip_set数量限制默认值为20，即配置的ip地址、ip地址范围或ip地址cidr的总数默认限制20
        /// </summary>
        [JsonProperty("ip_set", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpSet { get; set; }

        /// <summary>
        /// 功能说明：地址组最大条目数，限制地址组可以包含的地址数量 取值范围：0-20
        /// </summary>
        [JsonProperty("max_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// 功能说明：IP地址组包含的IP列表及其备注信息 约束：ip数量限制默认20, 与ip_set参数只能二选一
        /// </summary>
        [JsonProperty("ip_extra_set", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpExtraSetOption> IpExtraSet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAddressGroupOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  ipSet: ").Append(IpSet).Append("\n");
            sb.Append("  maxCapacity: ").Append(MaxCapacity).Append("\n");
            sb.Append("  ipExtraSet: ").Append(IpExtraSet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAddressGroupOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAddressGroupOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IpSet != input.IpSet || (this.IpSet != null && input.IpSet != null && !this.IpSet.SequenceEqual(input.IpSet))) return false;
            if (this.MaxCapacity != input.MaxCapacity || (this.MaxCapacity != null && !this.MaxCapacity.Equals(input.MaxCapacity))) return false;
            if (this.IpExtraSet != input.IpExtraSet || (this.IpExtraSet != null && input.IpExtraSet != null && !this.IpExtraSet.SequenceEqual(input.IpExtraSet))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IpSet != null) hashCode = hashCode * 59 + this.IpSet.GetHashCode();
                if (this.MaxCapacity != null) hashCode = hashCode * 59 + this.MaxCapacity.GetHashCode();
                if (this.IpExtraSet != null) hashCode = hashCode * 59 + this.IpExtraSet.GetHashCode();
                return hashCode;
            }
        }
    }
}
