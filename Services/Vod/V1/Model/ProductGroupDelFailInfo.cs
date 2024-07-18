using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductGroupDelFailInfo 
    {

        /// <summary>
        /// 模板组ID
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 模板组删除失败的原因
        /// </summary>
        [JsonProperty("fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailReason { get; set; }

        /// <summary>
        /// 删除失败的产物的信息
        /// </summary>
        [JsonProperty("products", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductDelFailInfo> Products { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductGroupDelFailInfo {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  failReason: ").Append(FailReason).Append("\n");
            sb.Append("  products: ").Append(Products).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductGroupDelFailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductGroupDelFailInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.Products == input.Products ||
                    this.Products != null &&
                    input.Products != null &&
                    this.Products.SequenceEqual(input.Products)
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.FailReason != null)
                    hashCode = hashCode * 59 + this.FailReason.GetHashCode();
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
                return hashCode;
            }
        }
    }
}
