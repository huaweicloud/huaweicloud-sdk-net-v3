using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 文档模板版本。
    /// </summary>
    public class DocumentTemplateVersion 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("document_template_version", NullValueHandling = NullValueHandling.Ignore)]
        public DocumentTemplateVersionEnum _DocumentTemplateVersion { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTemplateVersion {\n");
            sb.Append("  _documentTemplateVersion: ").Append(_DocumentTemplateVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentTemplateVersion);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DocumentTemplateVersion input)
        {
            if (input == null) return false;
            if (this._DocumentTemplateVersion != input._DocumentTemplateVersion) return false;

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
                hashCode = hashCode * 59 + this._DocumentTemplateVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
