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
    public class DeleteParam 
    {

        /// <summary>
        /// 是否幂等删除数据，默认为false。仅对指定ID删除生效。 - false: 数据不存在时返回错误信息。 - true: 数据不存在时返回成功，用于幂等删除场景。
        /// </summary>
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        /// <summary>
        /// 数据的服务实例级唯一标识，字符长度范围为[1, 256]。 - item_id/custom_tags/custom_num_tags中必须给定至少一个参数，以支持对服务实例中的数据进行指定ID删除或条件删除。 - 如给定item_id参数，则进行指定ID删除，否则进行条件删除。
        /// </summary>
        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

        /// <summary>
        /// 自定义字符标签，用于对服务实例中的数据进行条件删除。格式为键值对{key:value}。 - key: 必须为服务实例custom_tags中已存在的key，可在创建服务实例时进行配置，或在更新服务实例时进行新增。 - value: 标签值列表，列表内多个标签值为“或”关系，即满足一个即可。列表长度范围为[1, 32]，标签值类型为字符串，字符长度范围为[1, 64]。
        /// </summary>
        [JsonProperty("custom_tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<string>> CustomTags { get; set; }

        /// <summary>
        /// 自定义数值标签，用于对服务实例中的数据进行custom_num_tags条件删除。格式为键值对{key:value}。 - key: 必须为服务实例custom_num_tags中已存在的key，可在创建服务实例时进行配置，或在更新服务实例时进行新增。针对没有设置该数值标签的数据，会直接过滤。 - value: 标签值的取值范围，标签值在给定的取值范围内即视为符合条件。
        /// </summary>
        [JsonProperty("custom_num_tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, RangeParam> CustomNumTags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteParam {\n");
            sb.Append("  force: ").Append(Force).Append("\n");
            sb.Append("  itemId: ").Append(ItemId).Append("\n");
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
            return this.Equals(input as DeleteParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Force == input.Force ||
                    (this.Force != null &&
                    this.Force.Equals(input.Force))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.CustomTags == input.CustomTags ||
                    this.CustomTags != null &&
                    input.CustomTags != null &&
                    this.CustomTags.SequenceEqual(input.CustomTags)
                ) && 
                (
                    this.CustomNumTags == input.CustomNumTags ||
                    this.CustomNumTags != null &&
                    input.CustomNumTags != null &&
                    this.CustomNumTags.SequenceEqual(input.CustomNumTags)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Force != null)
                    hashCode = hashCode * 59 + this.Force.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.CustomTags != null)
                    hashCode = hashCode * 59 + this.CustomTags.GetHashCode();
                if (this.CustomNumTags != null)
                    hashCode = hashCode * 59 + this.CustomNumTags.GetHashCode();
                return hashCode;
            }
        }
    }
}
