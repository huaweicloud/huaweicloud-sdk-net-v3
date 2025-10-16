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
    /// （批量）删除发布。
    /// </summary>
    public class DeletePublicationRequestBody 
    {

        /// <summary>
        /// 删除的发布id列表（需要是同一实例的发布）。
        /// </summary>
        [JsonProperty("publication_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicationIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePublicationRequestBody {\n");
            sb.Append("  publicationIds: ").Append(PublicationIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeletePublicationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeletePublicationRequestBody input)
        {
            if (input == null) return false;
            if (this.PublicationIds != input.PublicationIds || (this.PublicationIds != null && input.PublicationIds != null && !this.PublicationIds.SequenceEqual(input.PublicationIds))) return false;

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
                if (this.PublicationIds != null) hashCode = hashCode * 59 + this.PublicationIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
