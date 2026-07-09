using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UploadDatabaseSslFileRequest 
    {

        /// <summary>
        /// 私钥文本内容
        /// </summary>
        [JsonProperty("pem_key_txt", NullValueHandling = NullValueHandling.Ignore)]
        public string PemKeyTxt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadDatabaseSslFileRequest {\n");
            sb.Append("  pemKeyTxt: ").Append(PemKeyTxt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadDatabaseSslFileRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadDatabaseSslFileRequest input)
        {
            if (input == null) return false;
            if (this.PemKeyTxt != input.PemKeyTxt || (this.PemKeyTxt != null && !this.PemKeyTxt.Equals(input.PemKeyTxt))) return false;

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
                if (this.PemKeyTxt != null) hashCode = hashCode * 59 + this.PemKeyTxt.GetHashCode();
                return hashCode;
            }
        }
    }
}
