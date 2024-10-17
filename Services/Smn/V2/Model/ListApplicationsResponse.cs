using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListApplicationsResponse : SdkResponse
    {

        /// <summary>
        /// 请求的唯一标识ID。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回的Application个数。该参数不受offset和limit影响，即返回的是您账户下所有的Application个数。
        /// </summary>
        [JsonProperty("application_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApplicationCount { get; set; }

        /// <summary>
        /// Application列表。
        /// </summary>
        [JsonProperty("applications", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplicationItem> Applications { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListApplicationsResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  applicationCount: ").Append(ApplicationCount).Append("\n");
            sb.Append("  applications: ").Append(Applications).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListApplicationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListApplicationsResponse input)
        {
            if (input == null) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.ApplicationCount != input.ApplicationCount || (this.ApplicationCount != null && !this.ApplicationCount.Equals(input.ApplicationCount))) return false;
            if (this.Applications != input.Applications || (this.Applications != null && input.Applications != null && !this.Applications.SequenceEqual(input.Applications))) return false;

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
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.ApplicationCount != null) hashCode = hashCode * 59 + this.ApplicationCount.GetHashCode();
                if (this.Applications != null) hashCode = hashCode * 59 + this.Applications.GetHashCode();
                return hashCode;
            }
        }
    }
}
