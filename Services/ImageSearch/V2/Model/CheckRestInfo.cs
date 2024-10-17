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
    /// 检查数据的相关信息。
    /// </summary>
    public class CheckRestInfo 
    {

        /// <summary>
        /// 数据是否存在，存在返回true，不存在返回false。仅在指定ID检查时包含该字段。
        /// </summary>
        [JsonProperty("existed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Existed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("item_info", NullValueHandling = NullValueHandling.Ignore)]
        public ItemSource ItemInfo { get; set; }

        /// <summary>
        /// 检查结果列表，仅在条件检查时包含该字段。
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<SearchItem> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("check_info", NullValueHandling = NullValueHandling.Ignore)]
        public CheckInfo CheckInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckRestInfo {\n");
            sb.Append("  existed: ").Append(Existed).Append("\n");
            sb.Append("  itemInfo: ").Append(ItemInfo).Append("\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("  checkInfo: ").Append(CheckInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckRestInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckRestInfo input)
        {
            if (input == null) return false;
            if (this.Existed != input.Existed || (this.Existed != null && !this.Existed.Equals(input.Existed))) return false;
            if (this.ItemInfo != input.ItemInfo || (this.ItemInfo != null && !this.ItemInfo.Equals(input.ItemInfo))) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;
            if (this.CheckInfo != input.CheckInfo || (this.CheckInfo != null && !this.CheckInfo.Equals(input.CheckInfo))) return false;

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
                if (this.Existed != null) hashCode = hashCode * 59 + this.Existed.GetHashCode();
                if (this.ItemInfo != null) hashCode = hashCode * 59 + this.ItemInfo.GetHashCode();
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.CheckInfo != null) hashCode = hashCode * 59 + this.CheckInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
