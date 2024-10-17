using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateParam 
    {

        /// <summary>
        /// 数据的服务实例级唯一标识，字符长度范围为[1, 256]。
        /// </summary>
        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

        /// <summary>
        /// 数据的描述信息，字符长度范围为[1, 2048]。
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        /// 数据的自定义字符标签，用于进行条件过滤。格式为键值对{key:value}。 - key: 必须为服务实例custom_tags中已存在的key，可在创建服务实例时进行配置，或在更新服务实例时进行新增。 - value: 类型为字符串，字符长度范围为[1, 64]。
        /// </summary>
        [JsonProperty("custom_tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> CustomTags { get; set; }

        /// <summary>
        /// 数据的自定义数值标签，用于进行条件过滤。格式为键值对{key:value}。 - key: 必须为服务实例custom_num_tags中已存在的key，可在创建服务实例时进行配置，或在更新服务实例时进行新增。 - value: 类型为数值，格式为double。
        /// </summary>
        [JsonProperty("custom_num_tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, double?> CustomNumTags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateParam {\n");
            sb.Append("  itemId: ").Append(ItemId).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  customTags: ").Append(CustomTags).Append("\n");
            sb.Append("  customNumTags: ").Append(CustomNumTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateParam input)
        {
            if (input == null) return false;
            if (this.ItemId != input.ItemId || (this.ItemId != null && !this.ItemId.Equals(input.ItemId))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;
            if (this.CustomTags != input.CustomTags || (this.CustomTags != null && input.CustomTags != null && !this.CustomTags.SequenceEqual(input.CustomTags))) return false;
            if (this.CustomNumTags != input.CustomNumTags || (this.CustomNumTags != null && input.CustomNumTags != null && !this.CustomNumTags.SequenceEqual(input.CustomNumTags))) return false;

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
                if (this.ItemId != null) hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.CustomTags != null) hashCode = hashCode * 59 + this.CustomTags.GetHashCode();
                if (this.CustomNumTags != null) hashCode = hashCode * 59 + this.CustomNumTags.GetHashCode();
                return hashCode;
            }
        }
    }
}
