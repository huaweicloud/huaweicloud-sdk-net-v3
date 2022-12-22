using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteBlackWhiteListUsingDeleteRequest 
    {

        /// <summary>
        /// 黑白名单id
        /// </summary>
        [SDKProperty("list_id", IsPath = true)]
        [JsonProperty("list_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteBlackWhiteListUsingDeleteRequest {\n");
            sb.Append("  listId: ").Append(ListId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteBlackWhiteListUsingDeleteRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteBlackWhiteListUsingDeleteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
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
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                return hashCode;
            }
        }
    }
}
