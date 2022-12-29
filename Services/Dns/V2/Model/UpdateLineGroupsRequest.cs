using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateLineGroupsRequest 
    {

        /// <summary>
        /// 待更新的线路分组ID。
        /// </summary>
        [SDKProperty("linegroup_id", IsPath = true)]
        [JsonProperty("linegroup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LinegroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateLineGroupsBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLineGroupsRequest {\n");
            sb.Append("  linegroupId: ").Append(LinegroupId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLineGroupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLineGroupsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LinegroupId == input.LinegroupId ||
                    (this.LinegroupId != null &&
                    this.LinegroupId.Equals(input.LinegroupId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.LinegroupId != null)
                    hashCode = hashCode * 59 + this.LinegroupId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
