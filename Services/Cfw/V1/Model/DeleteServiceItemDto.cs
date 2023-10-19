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
    public class DeleteServiceItemDto 
    {

        /// <summary>
        /// 服务组id
        /// </summary>
        [JsonProperty("set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SetId { get; set; }

        /// <summary>
        /// 服务组成员id列表
        /// </summary>
        [JsonProperty("service_item_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServiceItemIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteServiceItemDto {\n");
            sb.Append("  setId: ").Append(SetId).Append("\n");
            sb.Append("  serviceItemIds: ").Append(ServiceItemIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteServiceItemDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteServiceItemDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SetId == input.SetId ||
                    (this.SetId != null &&
                    this.SetId.Equals(input.SetId))
                ) && 
                (
                    this.ServiceItemIds == input.ServiceItemIds ||
                    this.ServiceItemIds != null &&
                    input.ServiceItemIds != null &&
                    this.ServiceItemIds.SequenceEqual(input.ServiceItemIds)
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
                if (this.SetId != null)
                    hashCode = hashCode * 59 + this.SetId.GetHashCode();
                if (this.ServiceItemIds != null)
                    hashCode = hashCode * 59 + this.ServiceItemIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
