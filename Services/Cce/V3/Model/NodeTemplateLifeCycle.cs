using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeTemplateLifeCycle 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("preInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string PreInstall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("postInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string PostInstall { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeTemplateLifeCycle {\n");
            sb.Append("  preInstall: ").Append(PreInstall).Append("\n");
            sb.Append("  postInstall: ").Append(PostInstall).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeTemplateLifeCycle);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeTemplateLifeCycle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreInstall == input.PreInstall ||
                    (this.PreInstall != null &&
                    this.PreInstall.Equals(input.PreInstall))
                ) && 
                (
                    this.PostInstall == input.PostInstall ||
                    (this.PostInstall != null &&
                    this.PostInstall.Equals(input.PostInstall))
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
                if (this.PreInstall != null)
                    hashCode = hashCode * 59 + this.PreInstall.GetHashCode();
                if (this.PostInstall != null)
                    hashCode = hashCode * 59 + this.PostInstall.GetHashCode();
                return hashCode;
            }
        }
    }
}
