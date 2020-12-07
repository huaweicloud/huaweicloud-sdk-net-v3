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
    /// Request Object
    /// </summary>
    public class ListMessageTemplateDetailsRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("message_template_id", IsPath = true)]
        [JsonProperty("message_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageTemplateId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMessageTemplateDetailsRequest {\n");
            sb.Append("  messageTemplateId: ").Append(MessageTemplateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMessageTemplateDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMessageTemplateDetailsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessageTemplateId == input.MessageTemplateId ||
                    (this.MessageTemplateId != null &&
                    this.MessageTemplateId.Equals(input.MessageTemplateId))
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
                if (this.MessageTemplateId != null)
                    hashCode = hashCode * 59 + this.MessageTemplateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
