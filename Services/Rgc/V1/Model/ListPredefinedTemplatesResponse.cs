using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPredefinedTemplatesResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<PredefinedTemplate> Templates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPredefinedTemplatesResponse {\n");
            sb.Append("  templates: ").Append(Templates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPredefinedTemplatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPredefinedTemplatesResponse input)
        {
            if (input == null) return false;
            if (this.Templates != input.Templates || (this.Templates != null && input.Templates != null && !this.Templates.SequenceEqual(input.Templates))) return false;

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
                if (this.Templates != null) hashCode = hashCode * 59 + this.Templates.GetHashCode();
                return hashCode;
            }
        }
    }
}
