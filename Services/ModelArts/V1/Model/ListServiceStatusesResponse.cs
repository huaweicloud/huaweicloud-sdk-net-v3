using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListServiceStatusesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：服务开通状态。 **取值范围**：数组元素个数限制为16个
        /// </summary>
        [JsonProperty("service_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceStatusItem> ServiceList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServiceStatusesResponse {\n");
            sb.Append("  serviceList: ").Append(ServiceList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServiceStatusesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServiceStatusesResponse input)
        {
            if (input == null) return false;
            if (this.ServiceList != input.ServiceList || (this.ServiceList != null && input.ServiceList != null && !this.ServiceList.SequenceEqual(input.ServiceList))) return false;

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
                if (this.ServiceList != null) hashCode = hashCode * 59 + this.ServiceList.GetHashCode();
                return hashCode;
            }
        }
    }
}
