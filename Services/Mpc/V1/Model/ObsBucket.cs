using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ObsBucket 
    {

        /// <summary>
        /// 桶名称 
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// 桶的创建时间 
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationDate { get; set; }

        /// <summary>
        /// 授权结果，取值[0,1]，0表示未授权给转码服务，1表示已授权转码服务 
        /// </summary>
        [JsonProperty("is_authorized", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAuthorized { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsBucket {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  isAuthorized: ").Append(IsAuthorized).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsBucket);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsBucket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.IsAuthorized == input.IsAuthorized ||
                    (this.IsAuthorized != null &&
                    this.IsAuthorized.Equals(input.IsAuthorized))
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
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.IsAuthorized != null)
                    hashCode = hashCode * 59 + this.IsAuthorized.GetHashCode();
                return hashCode;
            }
        }
    }
}
