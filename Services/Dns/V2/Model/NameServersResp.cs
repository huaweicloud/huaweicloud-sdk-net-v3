using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NameServersResp 
    {

        /// <summary>
        /// 待查询名称服务器的类型。  取值范围: public, private。  如果为空，表示查询所有类型的名称服务器。 如果为public，表示查询公网的名称服务器。  如果为private，表示查询内网的名称服务器。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 待查询的region ID。  当查询公网的名称服务器时，此处不填。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 名称服务器列表。
        /// </summary>
        [JsonProperty("ns_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<NsRecords> NsRecords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NameServersResp {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  nsRecords: ").Append(NsRecords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NameServersResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NameServersResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.NsRecords == input.NsRecords ||
                    this.NsRecords != null &&
                    input.NsRecords != null &&
                    this.NsRecords.SequenceEqual(input.NsRecords)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.NsRecords != null)
                    hashCode = hashCode * 59 + this.NsRecords.GetHashCode();
                return hashCode;
            }
        }
    }
}
