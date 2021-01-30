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
    public class ListCustomLineRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("line_id", IsQuery = true)]
        [JsonProperty("line_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("show_detail", IsQuery = true)]
        [JsonProperty("show_detail", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowDetail { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCustomLineRequest {\n");
            sb.Append("  lineId: ").Append(LineId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  showDetail: ").Append(ShowDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCustomLineRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCustomLineRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineId == input.LineId ||
                    (this.LineId != null &&
                    this.LineId.Equals(input.LineId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.ShowDetail == input.ShowDetail ||
                    (this.ShowDetail != null &&
                    this.ShowDetail.Equals(input.ShowDetail))
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
                if (this.LineId != null)
                    hashCode = hashCode * 59 + this.LineId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.ShowDetail != null)
                    hashCode = hashCode * 59 + this.ShowDetail.GetHashCode();
                return hashCode;
            }
        }
    }
}
