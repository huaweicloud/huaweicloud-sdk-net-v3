using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Demo.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UploadMultipartRequestBody 
    {

        /// <summary>
        /// The file to upload.
        /// </summary>
        [JsonProperty("upfile", NullValueHandling = NullValueHandling.Ignore)]
        public System.IO.Stream Upfile { get; set; }

        /// <summary>
        /// Description of file uuid.
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadMultipartRequestBody {\n");
            sb.Append("  upfile: ").Append(Upfile).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadMultipartRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadMultipartRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Upfile == input.Upfile ||
                    (this.Upfile != null &&
                    this.Upfile.Equals(input.Upfile))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.Upfile != null)
                    hashCode = hashCode * 59 + this.Upfile.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }
    }
}
