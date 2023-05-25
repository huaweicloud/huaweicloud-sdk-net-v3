using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowDomainRequest 
    {

        /// <summary>
        /// 源项目ID
        /// </summary>
        [SDKProperty("source_project_id", IsPath = true)]
        [JsonProperty("source_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainRequest {\n");
            sb.Append("  sourceProjectId: ").Append(SourceProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceProjectId == input.SourceProjectId ||
                    (this.SourceProjectId != null &&
                    this.SourceProjectId.Equals(input.SourceProjectId))
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
                if (this.SourceProjectId != null)
                    hashCode = hashCode * 59 + this.SourceProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
