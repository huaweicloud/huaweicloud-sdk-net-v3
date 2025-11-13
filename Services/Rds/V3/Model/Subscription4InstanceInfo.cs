using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 本地订阅信息。
    /// </summary>
    public class Subscription4InstanceInfo 
    {

        /// <summary>
        /// 发布服务器来源为云上实例时的发布实例id。
        /// </summary>
        [JsonProperty("publication_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationInstanceId { get; set; }

        /// <summary>
        /// 发布服务器名称。
        /// </summary>
        [JsonProperty("publication_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationInstanceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription4InstanceInfo {\n");
            sb.Append("  publicationInstanceId: ").Append(PublicationInstanceId).Append("\n");
            sb.Append("  publicationInstanceName: ").Append(PublicationInstanceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Subscription4InstanceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Subscription4InstanceInfo input)
        {
            if (input == null) return false;
            if (this.PublicationInstanceId != input.PublicationInstanceId || (this.PublicationInstanceId != null && !this.PublicationInstanceId.Equals(input.PublicationInstanceId))) return false;
            if (this.PublicationInstanceName != input.PublicationInstanceName || (this.PublicationInstanceName != null && !this.PublicationInstanceName.Equals(input.PublicationInstanceName))) return false;

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
                if (this.PublicationInstanceId != null) hashCode = hashCode * 59 + this.PublicationInstanceId.GetHashCode();
                if (this.PublicationInstanceName != null) hashCode = hashCode * 59 + this.PublicationInstanceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
