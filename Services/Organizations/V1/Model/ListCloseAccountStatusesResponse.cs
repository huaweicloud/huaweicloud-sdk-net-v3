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
    public class ListCloseAccountStatusesResponse : SdkResponse
    {

        /// <summary>
        /// 包含有关请求的详细信息的对象列表。
        /// </summary>
        [JsonProperty("close_account_statuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<CloseAccountStatusDto> CloseAccountStatuses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCloseAccountStatusesResponse {\n");
            sb.Append("  closeAccountStatuses: ").Append(CloseAccountStatuses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCloseAccountStatusesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCloseAccountStatusesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloseAccountStatuses == input.CloseAccountStatuses ||
                    this.CloseAccountStatuses != null &&
                    input.CloseAccountStatuses != null &&
                    this.CloseAccountStatuses.SequenceEqual(input.CloseAccountStatuses)
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
                if (this.CloseAccountStatuses != null)
                    hashCode = hashCode * 59 + this.CloseAccountStatuses.GetHashCode();
                return hashCode;
            }
        }
    }
}
