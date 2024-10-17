using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteSubAppRequest 
    {

        /// <summary>
        /// 子应用id
        /// </summary>
        [SDKProperty("sub_app_id", IsPath = true)]
        [JsonProperty("sub_app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubAppId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSubAppRequest {\n");
            sb.Append("  subAppId: ").Append(SubAppId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSubAppRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSubAppRequest input)
        {
            if (input == null) return false;
            if (this.SubAppId != input.SubAppId || (this.SubAppId != null && !this.SubAppId.Equals(input.SubAppId))) return false;

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
                if (this.SubAppId != null) hashCode = hashCode * 59 + this.SubAppId.GetHashCode();
                return hashCode;
            }
        }
    }
}
