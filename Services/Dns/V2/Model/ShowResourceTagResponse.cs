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
    /// Response Object
    /// </summary>
    public class ShowResourceTagResponse : SdkResponse
    {

        /// <summary>
        /// 指定实例的标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 企业项目或默认项目
        /// </summary>
        [JsonProperty("enterpriseProjectOrDefault", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectOrDefault { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowResourceTagResponse {\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectOrDefault: ").Append(EnterpriseProjectOrDefault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowResourceTagResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowResourceTagResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.EnterpriseProjectOrDefault == input.EnterpriseProjectOrDefault ||
                    (this.EnterpriseProjectOrDefault != null &&
                    this.EnterpriseProjectOrDefault.Equals(input.EnterpriseProjectOrDefault))
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
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectOrDefault != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectOrDefault.GetHashCode();
                return hashCode;
            }
        }
    }
}
