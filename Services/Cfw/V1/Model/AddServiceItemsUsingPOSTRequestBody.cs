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
    public class AddServiceItemsUsingPOSTRequestBody 
    {

        /// <summary>
        /// 服务组id，可通过[获取服务组列表接口](ListServiceSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SetId { get; set; }

        /// <summary>
        /// 服务组成员列表
        /// </summary>
        [JsonProperty("service_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddServiceItemsUsingPOSTRequestBodyServiceItems> ServiceItems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddServiceItemsUsingPOSTRequestBody {\n");
            sb.Append("  setId: ").Append(SetId).Append("\n");
            sb.Append("  serviceItems: ").Append(ServiceItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddServiceItemsUsingPOSTRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddServiceItemsUsingPOSTRequestBody input)
        {
            if (input == null) return false;
            if (this.SetId != input.SetId || (this.SetId != null && !this.SetId.Equals(input.SetId))) return false;
            if (this.ServiceItems != input.ServiceItems || (this.ServiceItems != null && input.ServiceItems != null && !this.ServiceItems.SequenceEqual(input.ServiceItems))) return false;

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
                if (this.SetId != null) hashCode = hashCode * 59 + this.SetId.GetHashCode();
                if (this.ServiceItems != null) hashCode = hashCode * 59 + this.ServiceItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
