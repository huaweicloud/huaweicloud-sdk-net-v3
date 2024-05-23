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
    public class ListCreateAccountStatusesResponse : SdkResponse
    {

        /// <summary>
        /// 包含有关请求的详细信息的对象列表。
        /// </summary>
        [JsonProperty("create_account_statuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateAccountStatusDto> CreateAccountStatuses { get; set; }

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
            sb.Append("class ListCreateAccountStatusesResponse {\n");
            sb.Append("  createAccountStatuses: ").Append(CreateAccountStatuses).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCreateAccountStatusesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCreateAccountStatusesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateAccountStatuses == input.CreateAccountStatuses ||
                    this.CreateAccountStatuses != null &&
                    input.CreateAccountStatuses != null &&
                    this.CreateAccountStatuses.SequenceEqual(input.CreateAccountStatuses)
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
                if (this.CreateAccountStatuses != null)
                    hashCode = hashCode * 59 + this.CreateAccountStatuses.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
