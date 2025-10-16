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
    /// 直接创建订阅时需要的参数。
    /// </summary>
    public class CreateSubscription4InstanceInfo 
    {

        /// <summary>
        /// 直接创建订阅时，服务器来源为云上实例的发布id。
        /// </summary>
        [JsonProperty("publication_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationId { get; set; }

        /// <summary>
        /// 直接创建订阅时，服务器来源为云上实例的发布名称。
        /// </summary>
        [JsonProperty("publication_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscription4InstanceInfo {\n");
            sb.Append("  publicationId: ").Append(PublicationId).Append("\n");
            sb.Append("  publicationName: ").Append(PublicationName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubscription4InstanceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubscription4InstanceInfo input)
        {
            if (input == null) return false;
            if (this.PublicationId != input.PublicationId || (this.PublicationId != null && !this.PublicationId.Equals(input.PublicationId))) return false;
            if (this.PublicationName != input.PublicationName || (this.PublicationName != null && !this.PublicationName.Equals(input.PublicationName))) return false;

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
                if (this.PublicationId != null) hashCode = hashCode * 59 + this.PublicationId.GetHashCode();
                if (this.PublicationName != null) hashCode = hashCode * 59 + this.PublicationName.GetHashCode();
                return hashCode;
            }
        }
    }
}
