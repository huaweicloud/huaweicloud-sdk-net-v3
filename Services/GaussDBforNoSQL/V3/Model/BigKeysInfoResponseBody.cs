using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BigKeysInfoResponseBody 
    {

        /// <summary>
        /// 大Key所在的DB。
        /// </summary>
        [JsonProperty("db_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? DbId { get; set; }

        /// <summary>
        /// 大Key类型。
        /// </summary>
        [JsonProperty("key_type", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyType { get; set; }

        /// <summary>
        /// 大Key名。
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 大Key的长度。
        /// </summary>
        [JsonProperty("key_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeySize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BigKeysInfoResponseBody {\n");
            sb.Append("  dbId: ").Append(DbId).Append("\n");
            sb.Append("  keyType: ").Append(KeyType).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  keySize: ").Append(KeySize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BigKeysInfoResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BigKeysInfoResponseBody input)
        {
            if (input == null) return false;
            if (this.DbId != input.DbId || (this.DbId != null && !this.DbId.Equals(input.DbId))) return false;
            if (this.KeyType != input.KeyType || (this.KeyType != null && !this.KeyType.Equals(input.KeyType))) return false;
            if (this.KeyName != input.KeyName || (this.KeyName != null && !this.KeyName.Equals(input.KeyName))) return false;
            if (this.KeySize != input.KeySize || (this.KeySize != null && !this.KeySize.Equals(input.KeySize))) return false;

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
                if (this.DbId != null) hashCode = hashCode * 59 + this.DbId.GetHashCode();
                if (this.KeyType != null) hashCode = hashCode * 59 + this.KeyType.GetHashCode();
                if (this.KeyName != null) hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.KeySize != null) hashCode = hashCode * 59 + this.KeySize.GetHashCode();
                return hashCode;
            }
        }
    }
}
