using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListInstancesRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("include_failure", IsQuery = true)]
        [JsonProperty("include_failure", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeFailure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name_equal", IsQuery = true)]
        [JsonProperty("name_equal", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEqual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("ip", IsQuery = true)]
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  includeFailure: ").Append(IncludeFailure).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  nameEqual: ").Append(NameEqual).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.IncludeFailure == input.IncludeFailure ||
                    (this.IncludeFailure != null &&
                    this.IncludeFailure.Equals(input.IncludeFailure))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.NameEqual == input.NameEqual ||
                    (this.NameEqual != null &&
                    this.NameEqual.Equals(input.NameEqual))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.IncludeFailure != null)
                    hashCode = hashCode * 59 + this.IncludeFailure.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.NameEqual != null)
                    hashCode = hashCode * 59 + this.NameEqual.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                return hashCode;
            }
        }
    }
}
