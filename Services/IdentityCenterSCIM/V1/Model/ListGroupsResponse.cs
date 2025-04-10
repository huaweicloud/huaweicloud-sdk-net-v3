using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterSCIM.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 总结果数
        /// </summary>
        [JsonProperty("totalResults", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalResults { get; set; }

        /// <summary>
        /// 每页的元素个数
        /// </summary>
        [JsonProperty("itemsPerPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemsPerPage { get; set; }

        /// <summary>
        /// 起始索引
        /// </summary>
        [JsonProperty("startIndex", NullValueHandling = NullValueHandling.Ignore)]
        public string StartIndex { get; set; }

        /// <summary>
        /// 概要
        /// </summary>
        [JsonProperty("schemas", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Schemas { get; set; }

        /// <summary>
        /// 包含用户组信息的列表
        /// </summary>
        [JsonProperty("Resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<GetGroupResp> Resources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGroupsResponse {\n");
            sb.Append("  totalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  itemsPerPage: ").Append(ItemsPerPage).Append("\n");
            sb.Append("  startIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  schemas: ").Append(Schemas).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGroupsResponse input)
        {
            if (input == null) return false;
            if (this.TotalResults != input.TotalResults || (this.TotalResults != null && !this.TotalResults.Equals(input.TotalResults))) return false;
            if (this.ItemsPerPage != input.ItemsPerPage || (this.ItemsPerPage != null && !this.ItemsPerPage.Equals(input.ItemsPerPage))) return false;
            if (this.StartIndex != input.StartIndex || (this.StartIndex != null && !this.StartIndex.Equals(input.StartIndex))) return false;
            if (this.Schemas != input.Schemas || (this.Schemas != null && input.Schemas != null && !this.Schemas.SequenceEqual(input.Schemas))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;

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
                if (this.TotalResults != null) hashCode = hashCode * 59 + this.TotalResults.GetHashCode();
                if (this.ItemsPerPage != null) hashCode = hashCode * 59 + this.ItemsPerPage.GetHashCode();
                if (this.StartIndex != null) hashCode = hashCode * 59 + this.StartIndex.GetHashCode();
                if (this.Schemas != null) hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                return hashCode;
            }
        }
    }
}
