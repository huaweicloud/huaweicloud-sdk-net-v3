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
    public class AddDataParam 
    {

        /// <summary>
        /// 是否强制添加数据，默认为false。 - false: 数据已存在则不进行添加。 - true: 数据已存在仍然覆盖添加。
        /// </summary>
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

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
        /// 图像文件的base64字符串，图像入库时，与image_url二选一。要求如下： - 格式：目前仅支持JPEG/JPG/PNG/BMP/WEBP格式的图像。 - 大小：图像文件大小要求不超过5M。 - 尺寸：默认情况下，要求图像的最短边大于64px，最长边小于4096px。部分服务类型有特殊要求，可参见服务类型说明。 - 其他：图片中不能包含旋转信息。
        /// </summary>
        [JsonProperty("image_base64", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// 图像文件的服务可访问URL，字符长度范围为[1, 4096]。图像入库时，与image_base64二选一。
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 关键词列表，关键词数量范围为[1, 100]，关键词字符长度范围为[1, 64]。支持关键词搜索的服务实例添加数据时，如给定此参数，则直接使用给定的keywords作为关键词，否则会自动生成对应的keywords。
        /// </summary>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("optional_params", NullValueHandling = NullValueHandling.Ignore)]
        public AddDataOptionalParam OptionalParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDataParam {\n");
            sb.Append("  force: ").Append(Force).Append("\n");
            sb.Append("  itemId: ").Append(ItemId).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  customTags: ").Append(CustomTags).Append("\n");
            sb.Append("  customNumTags: ").Append(CustomNumTags).Append("\n");
            sb.Append("  imageBase64: ").Append(ImageBase64).Append("\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("  optionalParams: ").Append(OptionalParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDataParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDataParam input)
        {
            if (input == null) return false;
            if (this.Force != input.Force || (this.Force != null && !this.Force.Equals(input.Force))) return false;
            if (this.ItemId != input.ItemId || (this.ItemId != null && !this.ItemId.Equals(input.ItemId))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;
            if (this.CustomTags != input.CustomTags || (this.CustomTags != null && input.CustomTags != null && !this.CustomTags.SequenceEqual(input.CustomTags))) return false;
            if (this.CustomNumTags != input.CustomNumTags || (this.CustomNumTags != null && input.CustomNumTags != null && !this.CustomNumTags.SequenceEqual(input.CustomNumTags))) return false;
            if (this.ImageBase64 != input.ImageBase64 || (this.ImageBase64 != null && !this.ImageBase64.Equals(input.ImageBase64))) return false;
            if (this.ImageUrl != input.ImageUrl || (this.ImageUrl != null && !this.ImageUrl.Equals(input.ImageUrl))) return false;
            if (this.Keywords != input.Keywords || (this.Keywords != null && input.Keywords != null && !this.Keywords.SequenceEqual(input.Keywords))) return false;
            if (this.OptionalParams != input.OptionalParams || (this.OptionalParams != null && !this.OptionalParams.Equals(input.OptionalParams))) return false;

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
                if (this.Force != null) hashCode = hashCode * 59 + this.Force.GetHashCode();
                if (this.ItemId != null) hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.CustomTags != null) hashCode = hashCode * 59 + this.CustomTags.GetHashCode();
                if (this.CustomNumTags != null) hashCode = hashCode * 59 + this.CustomNumTags.GetHashCode();
                if (this.ImageBase64 != null) hashCode = hashCode * 59 + this.ImageBase64.GetHashCode();
                if (this.ImageUrl != null) hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.Keywords != null) hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.OptionalParams != null) hashCode = hashCode * 59 + this.OptionalParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
