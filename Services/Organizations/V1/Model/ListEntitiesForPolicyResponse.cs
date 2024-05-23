using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEntitiesForPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 结构列表，每个结构都包含有关指定策略附加到的实体的详细信息。
        /// </summary>
        [JsonProperty("attached_entities", NullValueHandling = NullValueHandling.Ignore)]
        public List<EntityDto> AttachedEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoDto PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEntitiesForPolicyResponse {\n");
            sb.Append("  attachedEntities: ").Append(AttachedEntities).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEntitiesForPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEntitiesForPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttachedEntities == input.AttachedEntities ||
                    this.AttachedEntities != null &&
                    input.AttachedEntities != null &&
                    this.AttachedEntities.SequenceEqual(input.AttachedEntities)
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
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
                if (this.AttachedEntities != null)
                    hashCode = hashCode * 59 + this.AttachedEntities.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
